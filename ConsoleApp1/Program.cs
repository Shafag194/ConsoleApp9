using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cib cib = new Cib(new Azercell("0515141197"));
            cib.IncreaseBalance();
            Cib cib1 = new Cib(new Bakcell("0551233454"));
            cib1.IncreaseBalance();
            Cib cib2 = new Cib(new NarMobile("0773035412"));
            cib2.IncreaseBalance();
        }
    }

    interface IPay
    {
        void Pay();
    }
    class Azercell : IPay
    {
        public string numb;
        public Azercell(string Numb)
        {
            this.numb = Numb;
        }
        public void Pay()
        {
            if (numb.Length == 10 && (numb.LastIndexOf("050") == 0 || numb.LastIndexOf("051") == 0))
            {
                Console.WriteLine("Azercell service is called:)");
            }
            else
            {
                Console.WriteLine("Number isn't find!!");
            }
        }

    }
    class Bakcell : IPay
    {
        public string numb;
        public Bakcell(string Numb)
        {
            this.numb = Numb;
        }
        public void Pay()
        {
            if (numb.Length == 10 && (numb.LastIndexOf("055") == 0 ))
            {
            Console.WriteLine("Bakcell service is called:)");
            }
            else
            {
                Console.WriteLine("Number isn't find!!");
            }
        }
        
    }
    class NarMobile : IPay
    {
        public string numb;
        public NarMobile(string Numb)
        {
            this.numb = Numb;
        }
        public void Pay()
        {
            if(numb.Length == 10 && (numb.LastIndexOf("077") == 0))
            {
                Console.WriteLine("NarMobile service is called:)");
            }
            else
            {
                Console.WriteLine("Number isn't find!!");
            }
            
        }
       
    }
    class Cib
    {
        IPay pay;
        public Cib(IPay pay)
        {
            this.pay = pay;
        }

        public void IncreaseBalance()
        {
            pay.Pay();
        }
    }
}
