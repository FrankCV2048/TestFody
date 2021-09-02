using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo
{
    [FodyTestAttribute]
    public  class FodyTest
    {
        public string a = "aa";
        public string b = "aa";
        public void DoSomething()
        {
            Console.WriteLine("dd");
        }
    }
}
