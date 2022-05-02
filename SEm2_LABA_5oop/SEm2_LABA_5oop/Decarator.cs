using System;
using System.Collections.Generic;
using System.Text;

namespace SEm2_LABA_5oop
{
    abstract class Flower
    {
        public Flower(string n)
        {
            this.Name = n;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class SunFlower : Flower
    {
        public SunFlower() : base("Sunflowers")
        { }
        public override int GetCost()
        {
            return 6;
        }
    }

    class PionFlower : Flower
    {
        public PionFlower()
            : base("Pions")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }

    abstract class FlowerDecarator : Flower
    {
        protected Flower Flower;
        public FlowerDecarator(string n, Flower Flower) : base(n)
        {
            this.Flower = Flower;
        }
    }

    class DeliveryFlower : FlowerDecarator
    {
        public DeliveryFlower(Flower p)
            : base(p.Name + ", whith delivery", p)
        { }

        public override int GetCost()
        {
            return Flower.GetCost() + 5;
        }
    }

    class ThereFlower : FlowerDecarator
    {
        public ThereFlower(Flower p)
            : base(p.Name + ", we have this", p)
        { }

        public override int GetCost()
        {
            return Flower.GetCost() - 1;
        }
    }

}
