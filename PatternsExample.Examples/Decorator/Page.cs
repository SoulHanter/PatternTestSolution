using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsExample.Shared.Models;

namespace PatternsExample.Examples.Decorator
{
    public class Page : IPage
    {
        private List<Article> _articles;

        public Page()
        {
            _articles = new List<Article>();
        }

        public void Delete(Article article)
        {
            _articles.Remove(article);
        }

        public Article Publish(string title, string content)
        {
            var article = new Article
            {
                Title = title,
                Content = content
            };
            _articles.Add(article);
            return article;
        }
    }
}
