using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
public class MenuScreen : Screen
    {
        private List<MenuItem> Items { get; set; }
        public MenuScreen(string title) : base(title)
        {
            Items = new List<MenuItem>();
        }
        public void Add(MenuItem item)
        {
            if (item! != null)
            {
                Items.Add(item);
            }
        }

        public void Add(string displayName, Screen screen)
        {
            if (displayName != null && screen != null)
            {
                MenuItem item= new MenuItem(displayName,screen);
                Items.Add(item);
                
            }
        }
        public override void Show()
        {
            base.Show();
            centerText("choose screen");
            bool exit = false;
            int choose = 0;
            while (!exit)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    centerText($"{i + 1}- {Items[i].DisplayName}");
                }
                centerText($"{Items.Count + 1}-Exit");
                centerText($"choose between 1-{Items.Count} ");
                int.TryParse(Console.ReadLine(), out choose);
                if (choose >= 0 && choose <= Items.Count)
                {
                    exit = true;
                }
            }
            Console.Clear();
            if (choose <= Items.Count)
            {
                Items[choose - 1].screen.Show();
                Show();


            }
            Console.ReadKey();

        }
    }
}

