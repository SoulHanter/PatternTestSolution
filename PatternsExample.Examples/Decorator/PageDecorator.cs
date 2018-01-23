using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsExample.Shared.Models;

namespace PatternsExample.Examples.Decorator
{
    public class PageDecorator : IPage
    {
        private IPage _page;

        public PageDecorator(IPage page)
        {
            _page = page;
        }
        public void Delete(Article article)
        {
            _page.Delete(article);

            Console.WriteLine($"Удален пост:\nНазвание статьи:{article.Title}\nСодержание:{article.Content}");
        }

        public Article Publish(string title, string content)
        {
            return _page.Publish(title, content);
        }
    }
}
