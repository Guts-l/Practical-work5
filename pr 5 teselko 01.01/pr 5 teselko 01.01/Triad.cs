using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5_teselko_01._01
{
    class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public Triad()
        {
            First = 0;
            Second = 0;
            Third = 0;
        }


        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public bool IsEqual()
        {
            return First == Second && Second == Third;
        }

        public Triad AddNumber(int number)
        {
            return new Triad(
                First + number,
                Second + number,
                Third + number
                );
        }

        public Triad AddTriad(Triad secondTriad)
        {
            return new Triad(
                First + secondTriad.First,
                Second + secondTriad.Second,
                Third + secondTriad.Third
                );
        }

        public Triad MultiplyNumber(int number)
        {
            return new Triad(
                First * number,
                Second * number,
                Third * number
                );
        }

        public override string ToString()
        {
            return $"{First} {Second} {Third}";
        }
    }
}
