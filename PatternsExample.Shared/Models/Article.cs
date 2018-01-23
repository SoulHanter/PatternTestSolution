using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Shared.Models
{
    public class Article
    {
        public Article()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
