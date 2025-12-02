using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    public class Screen
    {
        public string Title { get; set; }
        public Screen( string title) 
        {
            Title = title;
        }
        public virtual void Show (){

            Console.Clear();
            centerText(Title);
            /* int spacing = (Console.WindowWidth - Title.Length) / 2;
            Console.WriteLine(new string(' ', spacing));
            Console.WriteLine($"\t\t\t {Title}");
            */
        }
        public void centerText(string text) { 
            
            
            Console.SetCursorPosition(Console.WindowTop + Console.WindowWidth/2,Console.CursorTop);
            Console.WriteLine(text);
        
        
        }

    }
}
