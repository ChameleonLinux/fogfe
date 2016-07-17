using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fog.Parser
{
    public class File
    {
        public Dictionary<string, string> super;
        public List<Record> data;
    }
    public class Record
    {
        public string id;
        public string dest;
        public string type;
        public string fname;
    }
    public class Parser
    {
        public static File read(string filename)
        {
            StreamReader f = new StreamReader(filename);
            Dictionary<string, string> super = new Dictionary<string, string>();
            List<Record> data = new List<Record>();
            foreach (string l in f.ReadToEnd().Trim().Split(new char[]{ '\n'}, StringSplitOptions.RemoveEmptyEntries))
            {
                string line = l.Trim();
                Console.WriteLine(line + "e");
                if (line[0] == '@')
                {
                    string[] srecord = line.Substring(1).Split(new char[]{' '}, 3);
                    super.Add(srecord[0].Trim(), srecord[1].Trim());
                } else if(line.StartsWith("- "))
                {
                    string[] record = line.Substring(2).Trim().Split(new char[] { ' ' }, 4);
                    Record r = new Record();
                    r.id = record[0];
                    r.dest = record[1];
                    r.type = record[2];
                    r.fname = record[3];
                    data.Add(r);
                }
            }
            f.Close();
            File file = new File();
            file.super = super;
            file.data = data;
            return file;
        }
    }
}
