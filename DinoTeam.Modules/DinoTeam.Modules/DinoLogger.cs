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
            // đây là đường dẫn tạm thời, e sẽ sửa lại sau khi đưa vào dự án chính
            fileStream = new FileStream(@"D:\C#\DinoDevs\DinoTeam.Modules\ConsoleApp1\Dino.txt",
                FileMode.Append, FileAccess.Write, FileShare.None);
            writter = new
                StreamWriter(fileStream, Encoding.UTF8);
            //fileStream.Dispose();
        }

        public DinoLogger(string filePath)
        {
            fileStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None);
            writter = new
                StreamWriter(fileStream, Encoding.UTF8);
        }

        public void Debug(Logger logger, string debugContent = "")
        {
            writter.Write(logger.Print());
            writter.Write(debugContent);
            writter.Flush();
        }

        public void Info(Logger logger, string infoContent = "")
        {
            writter.Write(logger.Print());
            writter.Write(infoContent);
            writter.Flush();
        }

        public void Error(Logger logger, string errorContent = "")
        {
            writter.Write(logger.Print());
            writter.Write(errorContent);
            writter.Flush();
        }
        
        public void Close()
        {
            writter.Close();
        }
    }
}