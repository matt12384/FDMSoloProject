using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    class BasketItemsService : IBasketItemsService
    {
        BasketItemsRepository repository;

        public BasketItemsService()
        {
            repository = new BasketItemsRepository();
        }

        public void PopulateBasketAndProductKeys(int basketId, int productId, ModelPoco.BasketItem basketItem)
        {
            repository.PopulateBasketAndProductKeys(basketId, productId, basketItem);
        }
    }
}
