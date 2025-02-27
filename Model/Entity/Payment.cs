﻿using System;
using System.Collections.Generic;

namespace Ecommerce_Models.Model.Entity;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string Method { get; set; } = null!;

    public int? UserId { get; set; }

    public virtual ICollection<Oder> Oders { get; set; } = new List<Oder>();
}
