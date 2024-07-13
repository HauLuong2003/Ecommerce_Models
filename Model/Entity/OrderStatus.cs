using System;
using System.Collections.Generic;

namespace Ecommerce_Models.Model.Entity;

public partial class OrderStatus
{
    public int OrderSatatusId { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Oder> Oders { get; set; } = new List<Oder>();
}
