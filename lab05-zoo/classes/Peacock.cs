using System;
using System.Collections.Generic;
using System.Text;
using lab05_zoo.Interfaces;

namespace lab05_zoo.classes
{
    public class Peacock : Bird , IPlay , IPotty
    {
        public override bool HasFeathers { get; set; } = true;
        public override int NumLegs { get; set; } = 2;
        public string MainColorOfTail { get; set; }
        //string ISpeak.SpeakThings { get; set; } = "ISpeak SpeakThings in Peacock";
        //int IPlay.PlayThings { get; set; } = 10;

        public override void Move()
        {
            Console.WriteLine("Move in peacock class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in peacock class");
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleep in peacock class");
        }
        public int PlayInterface()
        {
            Console.WriteLine("Play from IPlay in Peacock");
            return 10;
        }
        public string PottyInterface()
        {
            Console.WriteLine("Potty from IPotty in Peacock");
            return "Hello from PottyInterface IPotty Peacock";
        }

    }
}
