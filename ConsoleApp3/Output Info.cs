using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace LabTwo
{
    public sealed class OutputInfo
    {
        private static readonly OutputInfo instance = new OutputInfo();
        private List<InformationAboutDocument> documents = new List<InformationAboutDocument>();

        private OutputInfo() { }

        public static OutputInfo Instance
        {
            get { return instance; }
        }

        public void AddDocument(InformationAboutDocument doc)
        {
            documents.Add(doc);
        }

        public void MenuOfVariants()
        {
            Console.WriteLine("1. Добавить документ");
            Console.WriteLine("2. Показать все документы");
            Console.WriteLine("3. Закрыть");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddDocumentMenu();
                    break;
                case "2":
                    ListAllDocumentsMenu();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого варианта нет.");
                    break;
            }

            MenuOfVariants();
        }

        private void AddDocumentMenu()
        {
            Console.WriteLine("Имя документа:");
            string name = Console.ReadLine();

            Console.WriteLine("Автор:");
            string author = Console.ReadLine();

            Console.WriteLine("Ключевые слова:");
            string[] keywords = Console.ReadLine().Split(',');

            Console.WriteLine("Тема:");
            string theme = Console.ReadLine();

            Console.WriteLine("Путь к документу:");
            string path = Console.ReadLine();

            Console.WriteLine("Формат документа:");
            Console.WriteLine("1. MS Word");
            Console.WriteLine("2. PDF");
            Console.WriteLine("3. MS Excel");
            Console.WriteLine("4. TXT");
            Console.WriteLine("5. HTML");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    documents.Add(new Word(name, author, keywords, theme, path));
                    break;
                case "2":
                    documents.Add(new PDF(name, author, keywords, theme, path));
                    break;
                case "3":
                    documents.Add(new Excel(name, author, keywords, theme, path));
                    break;
                case "4":
                    documents.Add(new TXT(name, author, keywords, theme, path));
                    break;
                case "5":
                    documents.Add(new HTML(name, author, keywords, theme,path));
                    break;
                default:
                    Console.WriteLine("Такого выбора нет.");
                    break;
            }
        }

        private void ListAllDocumentsMenu()
        {
            Console.WriteLine("Список документов:");

            foreach (InformationAboutDocument doc in documents)
            {
                Console.WriteLine(doc.OutputLines());
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OutputInfo outInfo = OutputInfo.Instance;
            outInfo.MenuOfVariants();
        }
    }
}