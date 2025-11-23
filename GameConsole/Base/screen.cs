using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    internal class Screen
    {
        public string Title { get; set; }
        public Screen( string title) 
        {
            Title = title;
        }
        public virtual void Show (){

            Console.Clear();
            int spacing = (Console.WindowWidth - Title.Length) / 2;
            Console.WriteLine(new string(' ', spacing));
            Console.WriteLine($"\t\t\t {Title}");
        }

    }
}
