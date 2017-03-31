using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class BasketItem
    {
        public int BasketItemId { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Range(1, 100, ErrorMessage = "Please enter a value greater than 0.")]
        [Required]
        public int Quantity { get; set; }



    }
}
