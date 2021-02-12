using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TC == "1234567890" && gamer.FirstName == "BARIŞ" && gamer.LastName == "ASLAN" && gamer.BirthYear == "2000")
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
