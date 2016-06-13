﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.HelloWorldServiceReference;

namespace Client
{
  class Program
  {
    static void Main(string[] args)
    {
      HelloWorldClient client = new HelloWorldClient("WSHttpBinding_IHelloWorld");
      Name person = new Name();
      person.First = "John";
      person.Last = "MUtabazi";
      Console.WriteLine(client.SayHello(person));
      Console.ReadLine();
    }
  }
}
