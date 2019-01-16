using System;
using lab05_zoo.classes;
using lab05_zoo.Interfaces;

//will need to add namespace of the classes

namespace lab05_zoo
{
    public class Program //so can test
    {
        static void Main(string[] args)
        {
            BrownBear BoBo = new BrownBear();
            Peacock Jane = new Peacock();
            Goldfish Bill = new Goldfish();
            Salmon Jasper = new Salmon();
            Turtle Molly = new Turtle();
            Snake Kathy = new Snake();

            Console.WriteLine("Brownbear Speaks: ");
            BoBo.Speak();

            Console.WriteLine("Peacock Sleeps: ");
            Jane.Sleep();

            Console.WriteLine("Goldfish Moves: ");
            Bill.Move();

            Console.WriteLine("Salmon NumOfBabies");
            Jasper.NumOfBabies = 5;
            Console.WriteLine(Jasper.NumOfBabies);

            Console.WriteLine("Turtle HasShell: ");
            Molly.HasShell = true;
            Console.WriteLine(Molly.HasShell);
            Console.WriteLine("Turtle interface Play: ");
            Console.WriteLine(Molly.Play());

            Console.WriteLine("Snake HasSpine");
            Kathy.HasSpine = true;
            Console.WriteLine(Kathy.HasSpine);

            Console.ReadLine(); //to stop it from auto exit
        }
    }
}


//reminder to self when get to added classes, right click on folder and add a class, change the name at the bottom