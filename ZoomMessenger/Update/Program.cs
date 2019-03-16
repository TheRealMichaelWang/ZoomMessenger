using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Update
{
    class Program
    {
        static void PrintLineBreak()
        {
            string toprint = "";
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                toprint += "=";
            }
            Console.WriteLine(toprint);
        }
        static void Main(string[] args)
        {
            Console.Title = "Zoom Update";
            Console.WriteLine("Zoom Updater\n\nPlease enter in a number for the following options:");
            Console.WriteLine("1. Update Zoom Messenger");
            Console.WriteLine("2. Clear all Zoom Messenger App Data");
            Console.WriteLine("3. Cancel");
            PrintLineBreak();
            try
            {
                int input = int.Parse(Console.ReadLine());
                PrintLineBreak();
                Console.WriteLine("Output:");
                if(input == 1)
                {
                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        byte[] data = client.DownloadData("https://github.com/TheRealMichaelWang/ZoomMessenger/raw/master/ZoomMessenger.exe");
                        File.WriteAllBytes(Environment.CurrentDirectory + "\\ZoomMessenger.exe", data);
                    }
                }
                else if(input == 2)
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\talks.dat");
                }
                else if(input == 3)
                {
                    
                }
                else
                {
                    throw new Exception("No option was selected");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}