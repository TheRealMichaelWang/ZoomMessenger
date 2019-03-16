using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZoomMessenger
{
    public class ComplexMessage
    {
        public string from;
        public string to;
        public string subject;
        public string body;

        public static ComplexMessage ParseDataString(string datastring)
        {
            string[] args = datastring.Split("‰".ToCharArray());
            
            return new ComplexMessage(args[1], args[0], args[2], args[3]);
        }

        public ComplexMessage(string from,string to,string subject, string body)
        {
            this.body = body.Replace("\r\n","<br>");
            this.subject = subject;
            this.from = from;
            this.to = to;
        }

        public string ToDataString()
        {
            return to + "‰" + from + "‰" + subject + "‰" + body;
        }
    }
}
