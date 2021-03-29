using System;

namespace Estudo
{
  class Program
  {
    static void Main(string[] args)
    {

      double h, m, hd, md = 0;
      
      
      Console.WriteLine("Digite a hora ex : [1,2,13,14..] : ");
      h = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Digite os minutos ex : [21,30,40...] : ");
      m = Convert.ToInt32(Console.ReadLine());
     
      
      while (true)
      {   
          DateTime now = DateTime.Now;

          hd = now.Hour;
          md = now.Minute;
            
          if (h == hd & m == md)
          {
              break;
          }
      }     

    }
  }
}