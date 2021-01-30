using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulate
{
    interface ISellManagerService
    {

        void Buy(Gamer gamer);
        void Refund(Gamer gamer);
    }
}
