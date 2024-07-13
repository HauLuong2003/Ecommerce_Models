using System;
using System.Collections.Generic;

namespace Ecommerce_Models.Model.Entity;

public partial class OrderCancellationReason
{
    public int ReasonId { get; set; }

    public string Reason { get; set; } = null!;

    public virtual ICollection<Oder> Oders { get; set; } = new List<Oder>();
}
