using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ZoomMessenger
{
    public class Messenger
    {
        WebClient WebClient = new WebClient();

        public Messenger()
        {
            WebClient.UseDefaultCredentials = false;
            WebClient.Credentials = new NetworkCredential("epiz_23539049", "U7kZGrMgpdGlB");
            WebClient.BaseAddress = "ftp://ftpupload.net/";
        }

        public string[] getTalks()
        {
            using (StreamReader reader = new StreamReader(WebClient.OpenRead("/htdocs/talks")))
            {
                string[] toret = reader.ReadToEnd().Split("\r\n".ToCharArray());
                List<string> tokeep = new List<string>();
                foreach (string talk in toret)
                {
                    if (!string.IsNullOrEmpty(talk))
                    {
                        tokeep.Add(talk);
                    }
                }
                reader.Close();
                return tokeep.ToArray();
            }
        }

        public void RegisterTalk(string talkname)
        {
            List<string> talks = new List<string>(getTalks());
            if(talks.Contains(talkname))
            {
                throw new Exception("Talk is already registered");
            }
            talks.Add(talkname);
            using (StreamWriter writer = new StreamWriter(WebClient.OpenWrite("/htdocs/talks")))
            {
                foreach (string talk in talks)
                {
                    writer.WriteLine(talk);
                }
                writer.Close();
            }
        }

        public void UnregisterTalk(string talkname)
        {
            List<string> talks = new List<string>(getTalks());
            if (!talks.Contains(talkname))
            {
                throw new Exception("Talk doesn't exist");
            }
            talks.Remove(talkname);
            using (StreamWriter writer = new StreamWriter(WebClient.OpenWrite("/htdocs/talks")))
            {
                foreach (string talk in talks)
                {
                    writer.WriteLine(talk);
                }
                writer.Close();
            }
        }

        public bool talkExists(string talkname)
        {
            string[] talks = getTalks();
            if(talks.Contains(talkname))
            {
                return true;
            }
            return false;
        }

        public string[] getMessages(string talkname)
        {
            if(!talkExists(talkname))
            {
                throw new Exception("talk doesn't exist");
            }
            using (StreamReader reader = new StreamReader(WebClient.OpenRead("/htdocs/"+talkname)))
            {
                string[] toret = reader.ReadToEnd().Split("\r\n".ToCharArray());
                List<string> tokeep = new List<string>();
                foreach(string message in toret)
                {
                    if(!string.IsNullOrEmpty(message))
                    {
                        tokeep.Add(message);
                    }
                }
                reader.Close();
                return tokeep.ToArray();
            }
        }

        public void sendMessage(string talkname,string newmessage)
        {
            if (!talkExists(talkname))
            {
                throw new Exception("talk doesn't exist");
            }
            List<string> messages = new List<string>(getMessages(talkname));
            messages.Add(newmessage);
            using (StreamWriter writer = new StreamWriter(WebClient.OpenWrite("/htdocs/" + talkname)))
            {
                foreach(string message in messages)
                {
                    writer.WriteLine(message);
                }
                writer.Close();
            }
        }
        
        public void clearMessages(string talkname)
        {
            using (StreamWriter writer = new StreamWriter(WebClient.OpenWrite("/htdocs/" + talkname)))
            {
                writer.Write("Zoom Messenger: We've cleared all your messages in "+talkname+".");
            }
        }

        public void endTalk(string talkname)
        {
            if (!talkExists(talkname))
            {
                throw new Exception("talk doesn't exist");
            }
            FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://ftpupload.net/htdocs/"+talkname);
            ftpWebRequest.Credentials = WebClient.Credentials;
            ftpWebRequest.Method = WebRequestMethods.Ftp.DeleteFile;
            ftpWebRequest.GetResponse().Close();
            UnregisterTalk(talkname);
        }

        public void newTalk(string talkname)
        {
            if(talkExists(talkname))
            {
                throw new Exception("talk exists already");
            }
            WebClient.UploadString("/htdocs/" + talkname, "Zoom Messenger: Welcome to this new talk! Created at " + DateTime.Now + ".");
            RegisterTalk(talkname);
        }
    }
}
