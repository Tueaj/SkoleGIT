using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Cards
    {
        public int color_ { get; private set; }
        public int number_ { get; private set; }
        public Cards(int color=0, int number=0)
        {
            color_= (color > 0 && color < 9 ? color : 0);
            number_ = (number > 0 && number < 5 ? number : 0);
        }
    }
}
