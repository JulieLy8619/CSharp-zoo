using System;
using Xunit;
using lab05_zoo.classes;
using lab05_zoo.Interfaces;

namespace lab05_zoo_unittesting
{
    public class UnitTest1
    {
        //BrownBear
        [Fact]
        public void TestBear1()
        {
            BrownBear BoBo = new BrownBear();
            Assert.Equal("brown", BoBo.FurColor);
        }
        [Fact]
        public void TestBear2()
        {
            BrownBear BoBo = new BrownBear();
            Assert.NotEqual("blue", BoBo.FurColor);
        }

        //Peacock
        [Fact]
        public void TestPeacock1()
        {
            Peacock Jane = new Peacock();
            Assert.True(Jane.HasFeathers);
        }
        [Fact]
        public void TestPeacock2()
        {
            Peacock Jane = new Peacock();
            Assert.Equal(2, Jane.NumLegs);
        }

        //Goldfish
        [Fact]
        public void TestFish1()
        {
            Goldfish Bill = new Goldfish();
            Bill.Shiney = true;
            Assert.True(Bill.Shiney);
        }
        [Fact]
        public void TestFish2()
        {
            Goldfish Bill = new Goldfish();
            Bill.OnlyLiveInWater = true;
            Assert.True(Bill.OnlyLiveInWater);
        }


        //Salmon
        [Fact]
        public void TestSalmon1()
        {
            Salmon Jasper = new Salmon();
            Jasper.NumOfBabies = 5;
            Assert.Equal(5, Jasper.NumOfBabies);
        }
        [Fact]
        public void TestSalmon2()
        {
            Salmon Jasper = new Salmon();
            Assert.True(Jasper.HasSpine);
        }

        //Turtle
        [Fact]
        public void TestTurtle1()
        {
            Turtle Molly = new Turtle();
            Molly.threeChamHeart = true;
            Assert.True(Molly.threeChamHeart);
        }
        [Fact]
        public void TestTurtle2()
        {
            Turtle Molly = new Turtle();
            Molly.HasShell = true;
            Assert.True(Molly.HasShell);
        }

        //Snake
        [Fact]
        public void TestSnake1()
        {
            Snake Kathy = new Snake();
            Kathy.Color = "Green";
            Assert.Equal("Green", Kathy.Color);
        }
        [Fact]
        public void TestSnake2()
        {
            Snake Kathy = new Snake();
            Assert.True(Kathy.HasSpine);
        }

        //interface tests: turtle
        [Fact]
        public void TestITurtle1()
        {
            Turtle Murtle = new Turtle();

            Assert.Equal(100, Murtle.Play());
        }
        [Fact]
        public void TestITurtle2()
        {
            Turtle Murtle = new Turtle();

            Assert.NotEqual(1000, Murtle.Play());
        }

        //interface tests: peacock
        [Fact]
        public void TestIPeacock1()
        {
            Peacock George = new Peacock();

            Assert.Equal("Hello from SpeakInterface ISpeak Peacock", George.SpeakInterface());
        }
        [Fact]
        public void TestIPeacock2()
        {
            Peacock George = new Peacock();

            Assert.NotEqual("hi", George.SpeakInterface());
        }

        [Fact]
        public void TestIPeacock3()
        {
            Peacock George = new Peacock();

            Assert.Equal(10, George.Play());
        }

        //interface tests: goldfish
        [Fact]
        public void TestIGoldfish1()
        {
            Goldfish Peppa = new Goldfish();

            Assert.Equal(1000, Peppa.Play());
        }
        [Fact]
        public void TestIGoldfish2()
        {
            Goldfish Peppa = new Goldfish();

            Assert.NotEqual(1080, Peppa.Play());
        }
    }
}


//Test that each of your concrete animals exhibit the at least 2 appropriate behaviors given to them from a base class.