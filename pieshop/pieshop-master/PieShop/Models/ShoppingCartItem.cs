using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PieShop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public Guid ShoppingCartItemId { get; set; }
        public StockItem stockitem { get; set; }
        public int Amount { get; set; }
        public String ShoppingCartId { get; set; }
    }
}
