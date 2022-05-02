using System;
using System.Collections.Generic;
using System.Text;

namespace SEm2_LABA_5oop
{
    interface IGo
    {
        string Going();
    }

    class Go : IGo
    {
        public string Going()
        {
            return "go!go!go!";
        }
    }

    interface IWalk
    {
        string Walking();
    }

    class Walk : IWalk
    {
        public string Walking()
        {
            return "walk!walk!walk!";
        }
    }

    class Person
    {
        public string Stuff(IGo stuff)
        {
            return stuff.Going();
        }
    }

    class WalkToGoAdapter : IGo
    {
        Walk walk;
        public WalkToGoAdapter(Walk c)
        {
            walk = c;
        }

        public string Going()
        {
            return walk.Walking();
        }
    }
}
