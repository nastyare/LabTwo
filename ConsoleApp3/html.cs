using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabTwo
{
    public class HTML : InformationAboutDocument
    {
        public HTML(string name, string author, string[] keywords, string theme, string path)
            : base(name, author, keywords, theme, path)
        {
        }

        public override string OutputLines()
        {
            return $"Название: {Name}\n Автор: {Author}\n Ключевые слова: {string.Join(",", Keywords)}\n " +
                   $"Тема: {Theme}\n Путь к файлу: {Path}";
        }
    }
}
