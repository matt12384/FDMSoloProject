using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    interface IBasketItemsRepository
    {
        void PopulateBasketAndProductKeys(int basketId, int productId, BasketItem basketItem);

        void RemoveBasketItem(int basketId);
    }
}
