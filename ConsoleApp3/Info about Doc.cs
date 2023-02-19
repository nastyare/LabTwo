using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    public abstract class InformationAboutDocument
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string[] Keywords { get; set; }
        public string Theme { get; set; }
        public string Path { get; set; }

        public InformationAboutDocument(string name, string author, string[] keywords, string theme, string path)
        {
            Name = name;
            Author = author;
            Keywords = keywords;
            Theme = theme;
            Path = path;
        }
        public abstract string OutputLines();
    }
}

