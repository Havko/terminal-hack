using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalHack
{
    class GameState
    {
        

        public GameState()
        {
           
        }

        public List<String> SelectWordList()
        {
            string wholeFile;
            string[] lines;
            
            
            var list = new List<string>();
            System.IO.StreamReader currReader = new System.IO.StreamReader("C:\\projects\\c#\\terminal-hack\\TerminalHack\\TerminalHack\\bin\\Debug\\easy.txt");
            wholeFile = currReader.ReadToEnd();
            lines = wholeFile.Split(' ');
            foreach (string line in lines)
            {
                list.Add(line);
                
            }
            var finalList = new List<string>();
            for (int i = 0; i<10; i++){
            Random rand = new Random(list.Count());
            int index = rand.Next(list.Count);
            var word = list[index];
            list.RemoveAt(index);
            finalList.Add(word);
            }
            return finalList;
        }
    }
}
