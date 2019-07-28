using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNotePad.Core
{
    public  class ReadWriteOperation
    {
        public string ReadFile(string filePath)
        {
            var sr = new StreamReader(filePath);           
            string result = sr.ReadToEnd();           
            sr.Close();
            return result;            
        }

        public bool WriteFile(string filePath, string text)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                StreamWriter sw = new StreamWriter(stream);
                long endPoint = stream.Length;
                // Set the stream position to the end of the file.        
                stream.Seek(endPoint, SeekOrigin.Begin);
                sw.WriteLine(text);
                sw.Flush();
                return true;
            }             
        }
    }
}
