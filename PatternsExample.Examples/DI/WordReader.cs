using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.DI
{
    public class WordReader : IReader<Document>
    {
        public Document Create(string fileName) =>
            new Document
            {
                Name = fileName,
                Type = "Word",
                CreationDate = DateTime.Today
            };
    }
}
