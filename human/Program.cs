using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("Bob");
            Human billy = new Human("Billy", 4);
            billy.Attack(bob);
            bob.Display();
            billy.Display();

        }
        public class Human {
            private int strength = 3;
            private int intelligence = 3;
            private int dexterity = 3;
            private string name;
            private int health = 100;
            public Human(string n){
                name=n;
            }
            public Human(string n, int s){
                name = n;
                strength = s;
            }
            public Human(string n, int s, int i, int d, int h){
                name = n;
                strength = s;
                intelligence = i;
                health = h;
                dexterity = d;
            }
            public void Attack(Human h){
                h.health -= strength*5;
            }
            public void Display(){
                Console.WriteLine($"Name: {name}, Health: {health}, STR: {strength}, INT: {intelligence}, DEX: {dexterity}");
            }
        }
    }
}
