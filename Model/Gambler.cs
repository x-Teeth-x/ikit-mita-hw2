using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        public string Name { get; }
        public int Score { get; protected set; }

        public abstract void FetchNewNumber(int i);

        public Gambler(string name)
        {
            Name = name;
        }
    }
    public static class Even
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
    }
}
