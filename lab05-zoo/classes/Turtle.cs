using System;
using System.Collections.Generic;
using System.Text;
using lab05_zoo.Interfaces;

namespace lab05_zoo.classes
{
    public class Turtle : Reptile , IPlay
    {
        public bool HasShell { get; set; }
        //int IPlay.PlayThings { get; set; } = 100; //why wouldn't this work and let me test it
        public override void Move()
        {
            Console.WriteLine("Move in Turtle class");
        }
        public override int Speak()
        {
            Console.WriteLine("Speak in Turtle class");
            return 75;
        }
        public int PlayInterface()
        {
            Console.WriteLine("PlayInterface from IPlay in Turtle");
            return 100;
        }
    }
}
