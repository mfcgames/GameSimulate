using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulate
{
    class NewEStateUserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
