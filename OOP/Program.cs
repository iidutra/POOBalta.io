﻿using System;
using System.Collections.Generic;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
           var articles = new List<Article>();
           articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));

           foreach (var article in articles)
           {
               Console.WriteLine(article.Title);
               Console.WriteLine(article.Url);
           }
        }
    }
}
