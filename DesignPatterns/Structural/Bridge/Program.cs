using System;
using System.Collections.Generic;

using DesignPatterns.Structural.Bridge.Formatter;
using DesignPatterns.Structural.Bridge.ScriptFormats;

namespace DesignPatterns.Structural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ScriptBase> scriptList = new List<ScriptBase>();
            IFormatter formatter = new BackwardFormatter();

            Book book = new Book(formatter)
            {
                Name = "Samizdat",
                Author = "Soner Yalçın",
                Pages = 568
            };

            Article article = new Article(formatter)
            {
                Author = "Halit Yurtsever",
                Headline = "Design Patterns",
                Publisher = "Google"
            };

            Recipe recipe = new Recipe(formatter)
            {
                Name = "Halit Yurtsever",
                Type = MealType.MainCourse,
                Ingridents = new List<string>() { "Water", "Salt", "Oil", "Bean", "Onion" }
            };

            scriptList.Add(book);
            scriptList.Add(article);
            scriptList.Add(recipe);

            foreach (var script in scriptList)
            {
                script.Print();
                Console.WriteLine("------------------");
            }
        }
    }
}
