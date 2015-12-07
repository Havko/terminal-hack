using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalHack
{
    class GameState
    {
        public string difficulty;

        public GameState(string difficulty)
        {
           this.difficulty = difficulty;
        }
       
       
        public List<String> SelectWordList()
        {
            //string wholeFile;
            //string[] lines;
            string line;
            
            var list = new List<string>();
            
            System.IO.StreamReader currReader = new System.IO.StreamReader("C:\\projects\\c#\\terminal-hack\\TerminalHack\\easy.txt");
            //wholeFile = currReader.ReadToEnd();
           // lines = wholeFile.Split(' ');
           // foreach (string line in lines)
            while((line = currReader.ReadLine()) != null)
            {
                list.Add(line);
                
            }
            int seed = (int)DateTime.Now.Ticks;
            Random rand = new Random(seed);
            var finalList = new List<string>();
            for (int i = 0; i<10; i++){
             
            
            int index = rand.Next(list.Count);
            var word = list[index];
            list.RemoveAt(index);
            finalList.Add(word);
            
            }
            return finalList;
        }
    }
}
