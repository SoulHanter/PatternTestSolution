using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.DI
{
    public class ExcelReader : IReader<Document>
    {
        public Document Create(string fileName) =>
            new Document
            {
                Name = fileName,
                Type = "Excel",
                CreationDate = DateTime.Now
            };
    }
}
