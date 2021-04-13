using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishCardsDeck.Standard
{
    public class Deck : IDeck
    {
        public Deck()
        {

            Reset();
        }
        public List<spanishplayingcard> Cards { get; set; }
        public static List<spanishplayingcard> lstRemovedCardsfromtable = new List<spanishplayingcard>();
        public static Dictionary<int, spanishplayingcard> lstRemovedCardsfromtablewithindex = new Dictionary<int, spanishplayingcard>();
        public static List<spanishplayingcard> lstShuffledCards { get; set; }

        public void Reset()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 12)
                                    .Select(c => new spanishplayingcard()
                                    {
                                        Sign = (Sign)s,
                                        CardNumber = (CardNumber)c
                                    }
                                            )
                            )
                   .ToList();

            lstShuffledCards = Cards;
        }

        public List<spanishplayingcard> Shuffle()
        {
            // lstShuffledCards = new List<spanishplayingcard>();
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();

            lstShuffledCards = Cards;
            return Cards;
        }

        public List<spanishplayingcard> TakeCard()
        {
            var card = lstShuffledCards.SingleOrDefault(a => a.Sign == Sign.Coins && a.CardNumber == CardNumber.One);
            lstShuffledCards.Remove(card);

            return lstShuffledCards;
        }

        public List<spanishplayingcard> TakeCards(string sign, string number)
        {
            try
            {
                var card = lstShuffledCards.SingleOrDefault(a => a.Sign == (Sign)Enum.Parse(typeof(Sign), sign, true) && a.CardNumber == (CardNumber)Enum.Parse(typeof(CardNumber), number, true));

                int Removedindex = lstShuffledCards.IndexOf(card);
                lstRemovedCardsfromtable.Add(card);
                lstRemovedCardsfromtablewithindex.Add(Removedindex, card);
                lstShuffledCards.Remove(card);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstShuffledCards;
        }

        public void ReturnCardstotable(string sign, string number)
        {
            spanishplayingcard spcard = new spanishplayingcard();
            spcard.CardNumber = (CardNumber)Enum.Parse(typeof(CardNumber), number, true);
            spcard.Sign = (Sign)Enum.Parse(typeof(Sign), sign, true);

            var mykey = lstRemovedCardsfromtablewithindex.Keys.ElementAt(0);
            lstShuffledCards.Insert(mykey, spcard);

            lstRemovedCardsfromtablewithindex = new Dictionary<int, spanishplayingcard>();
            lstRemovedCardsfromtable = new List<spanishplayingcard>();
        }

        int keyfound { get; set; }
        public void ReturnAllCardstotable(string sign, string number)
        {
            spanishplayingcard spcard = new spanishplayingcard();
            List<spanishplayingcard> lstspcard = new List<spanishplayingcard>();
            spcard.CardNumber = (CardNumber)Enum.Parse(typeof(CardNumber), number, true);
            spcard.Sign = (Sign)Enum.Parse(typeof(Sign), sign, true);
            lstspcard.Add(spcard);


            foreach (KeyValuePair<int, spanishplayingcard> p in lstRemovedCardsfromtablewithindex)
            {
                if (p.Value.CardNumber == spcard.CardNumber && p.Value.Sign == spcard.Sign)
                {
                    keyfound = p.Key;
                    lstRemovedCardsfromtable.Remove(p.Value);
                    break;
                }
            }

            lstShuffledCards.Insert(keyfound, spcard);
            lstRemovedCardsfromtablewithindex.Remove(keyfound);
        }

        public static void clearlstRemovedCardsfromtable()
        {
            lstRemovedCardsfromtable = new List<spanishplayingcard>();
        }
    }
}
