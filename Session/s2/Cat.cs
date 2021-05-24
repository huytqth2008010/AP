using System;

namespace T2008M_AP.Session.s2
{
    public class Cat : Animal,ICat,IAnimal
    {
        public string name;

        public override void Running()
        {
            Console.WriteLine("Cat Running");
        }

        public void Speak()
        {
            Console.WriteLine("Meo Meo");
        }

        public void Live()
        {
            Console.WriteLine("Live...");
        }

        public void MeoMeo()
        {
            base.DoSomeThing();
            base.Eat();
        }

        public void MeoMeo(string msg)
        {
            base.DoSomeThing();
            base.Eat();
            Console.WriteLine(msg);
        }

        public void MeoMeo(string msg, int n)
        {
            
        }

        public override void DoSomeThing()
        {
            Console.WriteLine("MeoMeo do something");
        }

        public new void Eat()
        {
            Console.WriteLine("MeoMeo eat..");
        }
    }
    
}