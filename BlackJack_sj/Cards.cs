using System;

namespace BlackJack
{
    //creates Suit
    public enum Suit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
    //creates ranks
    public enum Rank
    {
        Ace,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    //creates card classes
    public class Card
    {
        public Suit suit;
        public Rank rank;

        public Card(Suit s, Rank r)
        {
            suit = s;
            rank = r;
        }
        //creates what player will see in console
        public override string ToString()
        {
            return suit.ToString() + "-" + rank.ToString();
        }
        public int asScore()
        {
            switch (rank)
            {
                case Rank.Ace: return 11;
                case Rank.Deuce: return 2;
                case Rank.Three: return 3;
                case Rank.Four: return 4;
                case Rank.Five: return 5;
                case Rank.Six: return 6;
                case Rank.Seven: return 7;
                case Rank.Eight: return 8;
                case Rank.Nine: return 9;
                case Rank.Ten: return 10;
                case Rank.Jack: return 10;
                case Rank.Queen: return 10;
                case Rank.King: return 10;
                default: return 0;
            }
        }
    }
    //creates deck
    public class Deck
    {
        public Card[] cards;
        private int numDealt = 0;
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
        public static void swap(Card[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                int r = new Random().Next(i, 52);
                swap(cards, i, r);
            }
            randomize;
        }
    }
    public Card deal() => (numDealt < cards.Length) ? cards[numDealt++] : null;

    public class Hand() 
    {
        public Card cards[] = new Card[0]
        //you have to create this

        public int score() { }
    //you have to create this
        public override string ToString()
        {
        Console.Write("Card(0): ", i);
        Console.WriteLine("Suit: (0) ", myDeck.cards[i].suit.ToString());
        Console.Write("Card (0): ", i);
        Console.WriteLine("Rank: (0) ", myDeck.cards[i].rank.ToString());
        }
  
        public void take(Card newCard)
        {
        //you have to create this
            var temp = new Card[cards.Length + 1];
            int = 0;
        //there is more that goes in here
        }    
}



/*
            Deck dealerDeck = new Deck();
            Deck shuffledDeck = new Deck();

            for (i = 0; i < dealerDeck.cards.Length; i++)
            {
                Console.Write("Card(0): ", i);
                Console.WriteLine("Suit: (0) ", dealerDeck.cards[i].suit.ToString());
                Console.Write("Card (0): ", i);
                Console.WriteLine("Rank: (0) ", dealerDeck.cards[i].rank.ToString());

            }
        }
        public class Program
        {
            static int random()
            {
                int rand = new Random().Next(0, 52);
                return rand;
            }
        }
    }
}

        /*
        public void Shuffle()
        {
            Card[] currentDeck = this.cards;
            
            this.cards = new Card[currentDeck.Length];
            dealerDeck freeIndices = new dealerDeck(currentDeck.Length);
            Random rand = new Random();

            for (int idx = 0; idx < currentDeck.Length; idx++)
                freeIndices.Add(idx);

            foreach (Card card in currentDeck)
            {

                int indexOfNewIdx = rand.Next(freeIndices.Count);
                int newIdxOfCard = freeIndices[indexOfNewIdx];

                this.cards[newIdxOfCard] = card;
                freeIndices.Remove(newIdxOfCard);
            }
        }
    }
}
        
        public Card[] getRandomized()
        {
            return new Card[0];
        }

        dealerDeck.getRandomized();
   think about using the "Swap" function instead of getRandomized after random card pick choice
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
} */









