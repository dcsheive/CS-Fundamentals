using System;
using System.Collections.Generic;
namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            Player bob = new Player("Bob");
            d.Shuffle();
            bob.TakeCard(d);
            d.Show();
            bob.ShowHand();
        }
        class Card {
            public int val { get; set; }
            public string face { get; set; }
            public string suit { get; set; }
            public Card(int v,string s,string f){
                val = v;
                suit = s;
                face = f;
            }
        }
        class Deck {
            private List<Card> cards { get; set; } = new List<Card>() ;
            private string[] faces = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            private string[] suits = {"Spades","Diamonds","Clubs","Hearts"};
            public Deck(){
                for (int i = 0; i<suits.Length;i++){
                    for (int j = 0; j<faces.Length;j++){
                        cards.Add(new Card(j+1,suits[i],faces[j]));
                    }
                }
            }
            public void Shuffle(){
                int j; 
                Card temp;
                Random r = new Random();
                for (int i = cards.Count - 1; i > 0; i--) {
                    j = (int)(r.NextDouble() * (i + 1));
                    temp = cards[i];
                    cards[i] = cards[j];
                    cards[j] = temp;
                }
            }
            public void Reset(){
                cards.Clear();
                for (int i = 0; i<suits.Length;i++){
                    for (int j = 0; j<faces.Length;j++){
                        cards.Add(new Card(j+1,suits[i],faces[j]));
                    }
                }
            }
            public Card Deal(){
                Card a = cards[cards.Count-1];
                cards.RemoveAt(cards.Count-1);
                return a;
            }
            public void Show(){
                for(int i =0; i<cards.Count;i++){
                    Console.WriteLine("{0} of {1}",cards[i].face, cards[i].suit);
                }
            }
        }
        class Player {
            private string name;
            private Card hand;
            public Player(string n){
                name = n;
            }
            public void TakeCard(Deck deck) {
                hand = deck.Deal();
            }
            public void Discard(){
                hand = null;
            }
            public void ShowHand(){
                Console.WriteLine("{0} has a {1} of {2}", name, hand.face, hand.suit);
            }
            
        }
    }
}
