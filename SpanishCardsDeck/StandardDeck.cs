using SpanishCardsDeck.Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanishCardsDeck
{
    public partial class StandardDeck : Form
    {
        public List<spanishplayingcard> lstCards { get; set; }
        static string SelectedSign { get; set; }
        static string SelectedCardNumber { get; set; }
        static string RemovedSign { get; set; }
        static string RemovedCardNumber { get; set; }

        Deck deck = new Deck();
        public StandardDeck()
        {
            InitializeComponent();
            deck = new Deck();
        }


        #region privatemethods


        public void NumberOfCards()
        {
            lblCardscount.Text = "Total number of cards in deck: " + deck.Cards.Count().ToString();

            lblCoinscount.Text = "Number of cards in coins: " + deck.Cards.Count(c => c.Sign == Sign.Coins).ToString();
            lblSwordsCount.Text = "Number of cards in swords: " + deck.Cards.Count(c => c.Sign == Sign.Swords).ToString();
            lblCupsCount.Text = "Number of cards in cups: " + deck.Cards.Count(c => c.Sign == Sign.Cups).ToString();
            lblSticksCount.Text = "Number of cards in sticks: " + deck.Cards.Count(c => c.Sign == Sign.Sticks).ToString();
        }

        public void Cardsontable()
        {

            lstcardsontable.DataSource = deck.Cards.Select(a => new { a.Sign, a.CardNumber }).ToList();
        }

        public static String betweenStrings(String text, String start, String end)
        {
            int p1 = text.IndexOf(start) + start.Length;
            int p2 = text.IndexOf(end, p1);

            if (end == "") return (text.Substring(p1));
            else return text.Substring(p1, p2 - p1);
        }
        void countcards()
        {
            lblcardsontablecount.Text = Deck.lstShuffledCards.Count().ToString();
            lblRemovedcount.Text = Deck.lstRemovedCardsfromtable.Count().ToString();
        }
        #endregion

        #region form_methods


        private void StandardDeck_Load(object sender, EventArgs e)
        {
            Deck deck = new Deck();

            NumberOfCards();
            Cardsontable();
            countcards();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            deck = new Deck();
            Deck.clearlstRemovedCardsfromtable();
            lstRemovedcards.DataSource = Deck.lstRemovedCardsfromtable.Select(a => new { a.Sign, a.CardNumber }).ToList();
            lstRemovedcards.Refresh();
            Cardsontable();
            countcards();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            lstcardsontable.DataSource = deck.Shuffle().Select(a => new { a.Sign, a.CardNumber }).ToList();
            countcards();
        }

        private void btnTakeCards_Click(object sender, EventArgs e)
        {
            try
            {
                lstcardsontable.DataSource = deck.TakeCards(SelectedSign, SelectedCardNumber).Select(a => new { a.Sign, a.CardNumber }).ToList();

                lstRemovedcards.DataSource = Deck.lstRemovedCardsfromtable.Select(a => new { a.Sign, a.CardNumber }).ToList();
                lstRemovedcards.Refresh();
                countcards();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please reset your cards and take cards in different place");
            }
        }


        private void lstcardsontable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spancard = lstcardsontable.SelectedItem.ToString();

            SelectedSign = betweenStrings(spancard, "{ Sign =", ",");
            SelectedCardNumber = betweenStrings(spancard, "CardNumber =", "}");
        }



        private void btnRetTable_Click(object sender, EventArgs e)
        {

            deck.ReturnCardstotable(RemovedSign, RemovedCardNumber);

            lstcardsontable.DataSource = Deck.lstShuffledCards.Select(a => new { a.Sign, a.CardNumber }).ToList();
            lstRemovedcards.DataSource = Deck.lstRemovedCardsfromtable.Select(a => new { a.Sign, a.CardNumber }).ToList();
            lstRemovedcards.Refresh();
            lstcardsontable.Refresh();
            countcards();
        }

        private void lstRemovedcards_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spancard = lstRemovedcards.SelectedItem.ToString();

            RemovedSign = betweenStrings(spancard, "{ Sign =", ",");
            RemovedCardNumber = betweenStrings(spancard, "CardNumber =", "}");
        }

        private void btnReturnallcards_Click(object sender, EventArgs e)
        {
            if (Deck.lstRemovedCardsfromtable.Count() > 0)
            {
                deck.ReturnAllCardstotable(RemovedSign, RemovedCardNumber);

                lstcardsontable.DataSource = Deck.lstShuffledCards.Select(a => new { a.Sign, a.CardNumber }).ToList();
                lstRemovedcards.DataSource = Deck.lstRemovedCardsfromtable.Select(a => new { a.Sign, a.CardNumber }).ToList();
                lstRemovedcards.Refresh();
                lstcardsontable.Refresh();
                countcards();
            }
            else
            {
                MessageBox.Show("Please select card");
            }
        }

        #endregion
    }
}
