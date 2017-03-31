using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    public class BasketRepository : IBasketRepository
    {
        SoloProjectEntities context;

        public BasketRepository()
        {
            context = new SoloProjectEntities();
        }

        public BasketRepository(SoloProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }

        public void AddBasketToUser(int userId, Basket basket)
        {
            User user = context.Users.Find(userId);

            if (user.Baskets == null)
            {
                user.Baskets = new List<Basket>();
            }

            user.Baskets.Add(basket);

            context.SaveChanges();
        }
    }
}
