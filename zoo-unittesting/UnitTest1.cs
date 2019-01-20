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
        public void TestBear1Inherited()
        {
            BrownBear BoBo = new BrownBear();
            Assert.Equal("brown", BoBo.FurColor);
        }
        [Fact]
        public void TestBear2Inherited()
        {
            BrownBear BoBo = new BrownBear();
            Assert.NotEqual("blue", BoBo.FurColor);
        }
        //Polymrphism
        [Fact]
        public void TestBear3Poly()
        {
            Peacock Jane = new Peacock();
            BrownBear BoBo = new BrownBear();
            Assert.NotEqual(Jane.NumLegs, BoBo.NumLegs);
        }

        //Peacock
        [Fact]
        public void TestPeacock1Inherited()
        {
            Peacock Jane = new Peacock();
            Assert.True(Jane.HasFeathers);
        }
        [Fact]
        public void TestPeacock2Inherited()
        {
            Peacock Jane = new Peacock();
            Assert.Equal(2, Jane.NumLegs);
        }

        //Goldfish
        [Fact]
        public void TestGoldfish1NewTrait()
        {
            Goldfish Bill = new Goldfish();
            Bill.Shiney = true;
            Assert.True(Bill.Shiney);
        }
        [Fact]
        public void TestGoldfish2Inherited()
        {
            Goldfish Bill = new Goldfish();
            Bill.OnlyLiveInWater = true;
            Assert.True(Bill.OnlyLiveInWater);
        }


        //Salmon
        [Fact]
        public void TestSalmon1NewTrait()
        {
            Salmon Jasper = new Salmon();
            Jasper.NumOfBabies = 5;
            Assert.Equal(5, Jasper.NumOfBabies);
        }
        [Fact]
        public void TestSalmon2Inherited()
        {
            Salmon Jasper = new Salmon();
            Assert.True(Jasper.HasSpine);
        }

        //Turtle
        [Fact]
        public void TestTurtle1Inherited()
        {
            Turtle Molly = new Turtle();
            Molly.threeChamHeart = true;
            Assert.True(Molly.threeChamHeart);
        }
        [Fact]
        public void TestTurtle2NewTrait()
        {
            Turtle Molly = new Turtle();
            Molly.HasShell = true;
            Assert.True(Molly.HasShell);
        }

        //Snake
        [Fact]
        public void TestSnake1NewTrait()
        {
            Snake Kathy = new Snake();
            Kathy.Color = "Green";
            Assert.Equal("Green", Kathy.Color);
        }
        [Fact]
        public void TestSnake2Inherited()
        {
            Snake Kathy = new Snake();
            Assert.True(Kathy.HasSpine);
        }

        //interface tests: turtle
        [Fact]
        public void TestInterfaceTurtle1()
        {
            Turtle Murtle = new Turtle();

            Assert.Equal(100, Murtle.PlayInterface());
        }
        [Fact]
        public void TestInterfaceTurtle2()
        {
            Turtle Murtle = new Turtle();

            Assert.NotEqual(1000, Murtle.PlayInterface());
        }

        //interface tests: peacock
        [Fact]
        public void TestInterfacePeacock1()
        {
            Peacock George = new Peacock();

            Assert.Equal("Hello from PottyInterface IPotty Peacock", George.PottyInterface());
        }
        [Fact]
        public void TestInterfacePeacock2()
        {
            Peacock George = new Peacock();

            Assert.NotEqual("hi", George.PottyInterface());
        }

        [Fact]
        public void TestInterfacePeacock3()
        {
            Peacock George = new Peacock();

            Assert.Equal(10, George.PlayInterface());
        }

        //interface tests: goldfish
        [Fact]
        public void TestInterfaceGoldfish1()
        {
            Goldfish Peppa = new Goldfish();

            Assert.Equal("Hello from PottyInterface IPotty Goldfish", Peppa.PottyInterface());
        }
        [Fact]
        public void TestInterfaceGoldfish2()
        {
            Goldfish Peppa = new Goldfish();

            Assert.NotEqual("blah", Peppa.PottyInterface());
        }

        //methods have been overwritten
        [Fact]
        public void TestOverridden()
        {
            Peacock Jane = new Peacock();
            BrownBear BoBo = new BrownBear();

            Assert.NotEqual(BoBo.Speak(), Jane.Speak());
        }

        //prove a concrete animal is an Animal, I decided I needed 3 tests to do this. Vertebrate (aka your Animal, because I assumed you just meant top of the tree) and verified each of the stuff in the base (hasSpine, Speak, and Move.)
        [Fact]
        public void TestIsAnAnimal1()
        {
            Peacock Jane = new Peacock();

            Assert.True(Jane.HasSpine); //shouldn't have gotten overridden per my chart
        }
        [Fact]
        public void TestIsAnAnimal2()
        {
            Peacock Jane = new Peacock();

            Assert.Equal(1,Jane.Speak()); 
        }
        [Fact]
        public void TestIsAnAnimal3()
        {
            Peacock Jane = new Peacock();
            Assert.Equal(3, Jane.Move());
        }
    }
}


//Test that each of your concrete animals exhibit the at least 2 appropriate behaviors given to them from a base class.
//Prove that the classes that implement the interface actually implement it
//Prove inheritance
//Prove Polymorphism
//Prove methods have been overridden, all of my methods were VOIDs....thats why I didn't test it before....fixed (unhappily oblidged, but done ;P )
//Prove that one of your concrete animals is an Animal, how!?! can't instantiate an "animal" (i'm pretty cetain Animal in this case is Vertebrate in my case)