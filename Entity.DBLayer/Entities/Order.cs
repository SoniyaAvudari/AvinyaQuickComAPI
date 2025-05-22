using System;
using System.Collections.Generic;

namespace Entity.DBLayer.Entities;

public partial class Order
{
    public int Orderid { get; set; }

    public string? Orderdate { get; set; }

    public int? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShipperId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Shipper? Shipper { get; set; }
}
