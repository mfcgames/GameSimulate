using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulate
{
    class SellProductManager : ISellManagerService
    {
      

        public void Buy(Gamer gamer)
        {
            if (gamer.FirstName=="Fethi")
            {
                Console.WriteLine("Satın Alındı");
            }
            else
            {
                Console.WriteLine("Satın alma işlemi Gerçekleştirilemedi");
            }
           
        }

        public void Refund(Gamer gamer)
        {
            Console.WriteLine("İade Yapıldı");
        }
    }
}
