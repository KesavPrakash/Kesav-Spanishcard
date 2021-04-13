using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishCardsDeck.Standard
{
    public interface IDeck
    {
        List<spanishplayingcard> TakeCard();
        List<spanishplayingcard> TakeCards(string sign, string number);
        void Reset();
        List<spanishplayingcard> Shuffle();
    }
}
