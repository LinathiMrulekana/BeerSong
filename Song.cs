using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_1
{
    internal class Song
    {
        private int _icount;
        private string _lyrics1;
        private string _lyrics2;
        private string _chorus;

        public Song(int icount)
        {
            this._icount = icount;
            this._lyrics1 = "bottles of beer on the wall,";
            this._lyrics2 = "bottles of beer.";
            this._chorus = "Take one down and pass it around";

        }

        public void SingSong()
        {
            for (int i = _icount; i > 0; i--)
            {
                Console.WriteLine(i + " " + _lyrics1 + i + " " + _lyrics2);
                Console.WriteLine(_chorus + " " + (i - 1) + " " + _lyrics1);
                if (i < 1)
                {
                    Console.WriteLine(i + "  " + "bottle of beer on the wall,"+ i +" "+ "bottle of beer.");
                    Console.WriteLine(_chorus + " " + (i - 1) + " " + "bottle of beer on the wall,");
                }
            }
        }
    }
}

