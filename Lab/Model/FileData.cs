using System.IO;

namespace Lab.Model
{
    public class FileData
    {
        private string name;
        private StreamReader sw;

        public FileData(string name, StreamReader sw)
        {
            this.name = name;
            this.sw = sw;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public StreamReader Sw
        {
            get { return sw; }
            set { sw = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}