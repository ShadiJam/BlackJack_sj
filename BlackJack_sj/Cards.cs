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
    //creates each card by conbining each suit with each rank
    public class Card
    {
        public Suit suit;
        public Rank rank;

        public Card(Suit s, Rank r)
        {
            suit = s;
            rank = r;
        }
        public int asScore()
        {
            //creates value for each card
            
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
        //translates card id integers into strings
        public override string ToString()
        {
            return suit.ToString() + "-" + rank.ToString();
        }
    }

    public class Deck
    {
        //creates each potential combo of rank and suit and therefore creates a deck of 52 cards
        public Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            int i = 0;
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
        //swaps each card dealt with random card in deck
        public static void swap(Card[] arr, int a, int b)
        {
            var numDealt = arr[a];
            arr[a] = arr[b];
            arr[b] = numDealt;
        }
        public void deckShuffle()
        {
            int rand = new Random().Next(0, 52);
            for (int i = 0; i < 52; i++)
            {
                swap(cards, i, rand);
            }
        }
        //returns a card from shuffled deck and creates list of cards dealt
        private int numDealt = 0;
        
        public Card deal() => (numDealt < cards.Length) ? cards[numDealt++] : null;
        public Card[] takeCard()  
        {
            return new Card[0];
        }
    }
    public class Hand
    {
        public int userScore(Deck deal)
        {

            int sum = 0; 
            foreach.Deal(deal, delegate (int i) { sum += i});
            Console.WriteLine(sum);
            }
           

        }





        
}
            // ***Call THIS handWinner
            //    {
            //    ***userScore == 21 && compScore == 21
            //        }
            //    show compScore
            //    Console.WriteLine("It's a tie!")
            //    Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game. 
            //    Console.ReadLine();

            //    if else {
            //    ***userScore == 21 && compScore < 21
            //    }
            //    Console.WriteLine("You win!")
            //    Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game. 
            //    Console.ReadLine();

            //    if else {
            //    ***userScore == 21 && compScore > 21
            //    }
            //    Console.WriteLine("You win!")
            //    Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game. 
            //    Console.ReadLine();

            //    if else {
            //    ***userScore < 21 && compScore == 21
            //    Console.WriteLine("Sorry, better luck next time!")
            //    Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game.
            //    Console.ReadLine();


            //    if else {
            //    ***userScore < 21 && compScore < 21 
            //      if userScore > compScore {
            //          Console.WriteLine("You win!")
            //          Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game. 
            //          Console.ReadLine();
            //      else if userScore < compScore {
            //          Console.WriteLine("Sorry, better luck next time!")
            //          Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game.
            //          Console.ReadLine();

            //    if else {
            //    ***userScore < 21 && compScore > 21 {
            //          Console.WriteLine("You win!")
            //          Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game. 
            //          Console.ReadLine();
            //    if else {
            //    ****userScore > 21 && compScore == 21 {
            //          Console.WriteLine("Sorry, better luck next time!")
            //          Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game.
            //          Console.ReadLine();
            //    if else {
            //     ***userScore > 21 && compScore < 21 {
            //          Console.WriteLine("Sorry, better luck next time!")
            //          Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game.
            //          Console.ReadLine();

            //    if else {
            //     ***userScore > 21 && compScore > 21 {
            //    Console.WriteLine("Ouch, we both lose!")
            //    Console.WriteLine("Do you want to play BlackJack? (Y/N)"); and repeat game. 
            //    Console.ReadLine();

        }
        
        {
          
        }
    }
}

        
    
        

    
        
        
       
        










/*
 * public override string ToString()
            {
                public void take(Card newCard)
            {
                var temp = new Card[cards.Length + 1];
                int = 0;
                foreach 
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









