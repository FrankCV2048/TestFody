using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;



namespace TestDemo
{
    class Program
    {  
        public static void Main(string[] args)
        {
            Person a = new Person();
            a.FamilyName = "b";
            Console.WriteLine(a.FullName);
        }
       
    }
}
