using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NumberHendler(int a);
        public event NumberHendler NewNumber;

        public void Generate()
        {
            Random run = new Random();
            int number = run.Next();
            NewNumber?.Invoke(number);
        }
    }
}
