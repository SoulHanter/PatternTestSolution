using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Decorator
{
    public interface IPage
    {
        Article Publish(string title, string content);
        void Delete(Article article);
    }
}
