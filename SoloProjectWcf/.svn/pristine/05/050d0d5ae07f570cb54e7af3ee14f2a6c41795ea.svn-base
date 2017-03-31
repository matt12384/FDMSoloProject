using ModelPoco;
using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    class BasketService : IBasketService
    {
        BasketRepository repository;

        public BasketService()
        {
            repository = new BasketRepository();
        }

        public void AddBasketToUser(int userId, Basket basket)
        {
            repository.AddBasketToUser(userId, basket);
        }
    }
}
