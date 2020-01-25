using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonPattern
{
    public sealed class SingleTon
    {
        private static int counter;
        //Changed the constructor to private to control the instantiation.
        private static SingleTon Instance = null;

        public static SingleTon GetInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new SingleTon();

                return Instance;

            }
        }
       
        
    private SingleTon()
        {
            counter++;
            Console.WriteLine("Instantiated " + counter.ToString());
    
        }
        public void Display(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }
}
