using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZoomMessenger
{
    public class TalkNameStorage
    {
        public List<string> talks;
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\talks.dat";

        public TalkNameStorage()
        {
            if(!File.Exists(path))
            {
                File.Create(path).Close();
                File.WriteAllText(path, "general forum");
            }
            talks = File.ReadAllLines(path).ToList();
        }

        public void SaveTalks()
        {
            File.WriteAllLines(path, talks.ToArray());
        }

        public void AddTalk(string talkname)
        {
            if (!talks.Contains(talkname))
            {
                if (MessageBox.Show("Would you like to save this talk?", "Zoom Messenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    talks.Add(talkname);
                }
            }
        }

        public void DelTalk(string talkname)
        {
            if (talks.Contains(talkname))
            {
                if (MessageBox.Show("The talk no longer exists. Would you like to forget this talk?", "Zoom Messenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    talks.Remove(talkname);
                }
            }
        }

        public string SelectTalk()
        {
            if(talks.Count == 0)
            {
                return "";
            }
            if(MessageBox.Show("Would you like to use a saved talk?", "Zoom Messenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach(string talk in talks)
                {
                    if(MessageBox.Show("Would you like to join the talk '"+talk + "'?", "Zoom Messenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        return talk;
                    }
                }
            }
            return "";
        }
    }
}
