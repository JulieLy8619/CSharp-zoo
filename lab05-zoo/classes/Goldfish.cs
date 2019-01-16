using lab05_zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Goldfish : Fish , IPlay
    {
        public bool Shiney { get; set; }
        int IPlay.PlayThings { get; set; } = 1000;
        public override void Move()
        {
            Console.WriteLine("Move in goldfish class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in goldfish class");
        }

        public void Play()
        {
            Console.WriteLine("Play from IPlay in Goldfish");
        }

    }
}
