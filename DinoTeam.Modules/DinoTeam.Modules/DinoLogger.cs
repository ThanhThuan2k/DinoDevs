using DinoDevs.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DinoTeam.Modules
{
    public class DinoLogger
    {
        FileStream fileStream;
        private StreamWriter writter;
        public DinoLogger()
        {
            fileStream = new FileStream(@"D:\C#\DinoDevs\DinoTeam.Modules\ConsoleApp1\Dino.txt",
                FileMode.Append, FileAccess.Write, FileShare.None);
            writter = new
                StreamWriter(fileStream, Encoding.UTF8);
            //fileStream.Dispose();
        }

        public void Debug(Logger logger, string debugContent = "")
        {
            writter.Write(logger.Print());
            writter.Write(debugContent);
            writter.Flush();
        }
        
        public void Close()
        {
            writter.Close();
        }
    }
}