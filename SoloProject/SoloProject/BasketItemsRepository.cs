using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    public class BasketItemsRepository : IBasketItemsRepository
    {
        SoloProjectEntities context;

        public BasketItemsRepository()
        {
            context = new SoloProjectEntities();
        }

        public BasketItemsRepository(SoloProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }

        public void PopulateBasketAndProductKeys(int basketId, int productId, BasketItem basketItem)
        {
            Basket basket = context.Baskets.Find(basketId);
            Product product = context.Products.Find(productId);

            if (product.BasketItems == null && basket.BasketItems == null)
            {
                basket.BasketItems = new List<BasketItem>();
                product.BasketItems = new List<BasketItem>();  
            }

            basket.BasketItems.Add(basketItem);
            product.BasketItems.Add(basketItem);

            context.SaveChanges();
        }

        public void RemoveBasketItem(int basketId)
        {
            BasketItem basketItem = context.BasketItems.Find(basketId);

            context.BasketItems.Remove(basketItem);

            context.SaveChanges();
        }
    }
}
