using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab99
{
    class Word
    {
        private string name;
        private List<int> pages = new List<int>();
        public Word()
        {
            name = "";
            pages.Add(0);
        }
        public Word(string _name, List<int> _pages)
        {
            name = _name;
            pages = _pages;
        }
        public string Show()
        {
            string show = "";
            show += name + " ";
            for (int i = 0; i < pages.Count; i++)
                show += " " + pages[i].ToString();
            show += "\n";
            return show;
        }
    }

}
