﻿using System;
using System.Collections.Generic;

namespace Ecommerce_Models.Model.Entity;

public  class Cart
{
    public string CartId { get; set; }

    public int? UserId { get; set; }

    public List<CartItem> Items { get; set; } = new List<CartItem>();
    
    public void clear()=> Items.Clear();
}
