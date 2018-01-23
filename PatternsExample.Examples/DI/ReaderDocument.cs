using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.DI
{
    public class ReaderDocument
    {
        public void CreateDocument(IReader<Document> reader, string name)
        {
            var doc = reader.Create(name);
            Console.WriteLine($"Создан новый {doc.Type} документ - {doc.Name}: {doc.CreationDate}");
        }
    }
}
