using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Hoşgeldiniz, " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", e-Devlet hesabınız doğrulanmadı!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " hesabınız silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Bilgileriniz güncellendi");
        }
    }
}
