using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulate
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1994 && gamer.FirstName=="Fethi"&&gamer.LastName=="Çalışkan"&&gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
