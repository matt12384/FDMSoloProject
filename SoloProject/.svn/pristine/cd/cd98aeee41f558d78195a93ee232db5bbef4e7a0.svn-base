using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class AddressType
    {
        public int AddressTypeId { get; set; }
        [Required]
        public string Type { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
