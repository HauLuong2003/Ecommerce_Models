using System;
using System.Collections.Generic;

namespace Ecommerce_Models.Model.Entity;

public  class CartItem
{
    public int PId { get; set; }
    public string cartId { get; set; }
    public int Quantity { get; set; }
    public float Price {  get; set; }
    public float totalPrice => Quantity*Price;
}
