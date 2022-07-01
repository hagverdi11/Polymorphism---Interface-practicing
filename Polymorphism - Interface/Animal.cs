using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism___Interface
{
    public abstract class Animal
    {

        public string Name;

        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }

    }
}
