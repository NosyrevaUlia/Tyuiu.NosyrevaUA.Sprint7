using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace FirstLib
{
    public class FirstLibrary
    {
        public int len;
        public int number;
        public string firstnumber;
        public int Number(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {                
                string fileData = File.ReadAllText(path);

                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries); 
                int rows = lines.Length;
                
                for (int r = 0; r < rows; r++)
                {
                    string[] line_r = lines[r].Split(';');
                    
                    for(int j = 0;j< line_r.Length;j++)
                    {
                        firstnumber = Convert.ToString(line_r[j]);                       
                    }                    
                }
                number = Convert.ToInt32(firstnumber)+1;                
            }
            return number;
        }
    }
}
