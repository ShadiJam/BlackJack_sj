using System;

namespace BlackJack
{
    public enum Suit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }

    public enum Rank
    {
        Ace = 11,
        Deuce = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 10,
        Queen = 10,
        King = 10
    }

    public class Card
    {
        public Suit suit;
        public Rank rank;

        public Card(Suit s, Rank r)
        {
            suit = s;
            rank = r;
        }
    }

    public class Deck
    {
        public Card[] cards;
        public Deck()
        {
            cards = new Card[52];
            int i = 0; // 1
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                int j = 0;
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    cards[i * 4 + j] = new Card(s, r);
                    j++;
                }
                i++;
            }
        }
        public Card[] getRandomized()
        {
            return new Card[0];
        }

   //     dealerDeck.getRandomized();
   //think about using the "Swap" function instead of getRandomized after random card pick choice
    }
}

//creates random card pick function
public class Program
{
    static int random()
    {
        int rand = new Random().Next(0, 52);
        return rand;
    }
    public static void Main()
    {
        Console.WriteLine(random());

    }
}
/*creates shuffle function
public Card[] Cards;
public void Shuffle()
{
    Card[] currentDeck = this.Cards;
    this.Cards = new Card[currentDeck.Length];
    List<int> freeIndices = new List<int>(currentDeck.Length);
    Random rand = new Random();

    for (int idx = 0; idx < currentDeck.Length; idx++)
        freeIndices.Add(idx);

    foreach (Card card in currentDeck)
    {

        int indexOfNewIdx = rand.Next(freeIndices.Count);
        int newIdxOfCard = freeIndices[indexOfNewIdx];

        this.Cards[newIdxOfCard] = card;
        freeIndices.Remove(newIdxOfCard);
    }
}
/*creates new deck 
static void Main(string[] args)
{
    Deck dealerDeck = new Deck();
    Deck shuffledDeck = new Deck();

    for (int i = 0; i < dealerDeck.cards.Length; i++)
    {
        Console.Write("Card(0): ", i);
        Console.WriteLine("Suit: (0) ", dealerDeck.cards[i].suit.ToString());
        Console.Write("Card (0): ", i);
        Console.WriteLine("Rank: (0) ", dealerDeck.cards[i].rank.ToString());
        //can combine all the above into one line of code//
    }
}
// 							  



