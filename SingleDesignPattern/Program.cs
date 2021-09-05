using System;

namespace SingleDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass.Instance.Add();
            SingletonClass.Instance.Update();
            SingletonClass.Instance.Delete();
        }
    }

    public class SingletonClass
    {
        public static SingletonClass Instance { get; set; } = new SingletonClass();

        protected internal SingletonClass()
        {
        }

        public virtual void Add() 
        {
            Console.WriteLine("Add method called......");
        }

        public virtual void Update()
        {
            Console.WriteLine("Update method called.....");
        }


        public virtual void Delete()
        {
            Console.WriteLine("Delete method called......");
        }



    }

}
