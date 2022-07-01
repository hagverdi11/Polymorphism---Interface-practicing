using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism___Interface
{
   public class Person : ISpeak, IEating
    {
        

        public void Eating(DateTime time)
        {
            Console.WriteLine("Person eating" + DateTime.Now);
        }

        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }
    }


    public interface ISpeak
    {
        void Speak();
    }


    public interface IEating
    {
        void Eating(DateTime time);
    }
}
