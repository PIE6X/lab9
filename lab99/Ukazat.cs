using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab99
{
    class Ukazat
    {
        private List<Word> library = new List<Word>();
        public Ukazat()
        {
            //List<int> init = new List<int>();
            Word book = new Word();
            library.Add(book);
        }
        public Ukazat(string _word, List<int> _pages)
        {
            Word book = new Word(_word, _pages);
            library.Add(book);
        }
        public string Show()
        { 
            string output = "";
          
            for (int i = 0; i < library.Count; i++)
                output += library[i].Show();
            return output;
        }

        public void Add(Word _book)
        {
            library.Add(_book);
        }
        public void Add(string _name, List<int> _pages)
        {
            Word _book = new Word(_name, _pages);
            library.Add(_book);
        }
    }
}
