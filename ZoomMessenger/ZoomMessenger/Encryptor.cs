using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZoomMessenger
{
    class Encryptor
    {
        public Encryptor()
        {

        }

        public string EncryptString(string message)
        {
            byte[] bs = Encoding.ASCII.GetBytes(message);
            string toret = bs[0].ToString();
            for (int i = 1; i < bs.Length; i++)
            {
                toret = toret + "." + bs[i].ToString();
            }
            return toret;
        }

        public string DectryptString(string data)
        {
            string[] bytes = data.Split('.');
            byte[] bs = new byte[bytes.Length];
            int i = 0;
            foreach (string b in bytes)
            {
                byte ib = byte.Parse(b);
                bs[i] = ib;
                i++;
            }
            return Encoding.ASCII.GetString(bs);
        }
    }
}
