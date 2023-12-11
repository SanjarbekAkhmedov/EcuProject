using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpPhysicalProduct
{
    public uint PhysicalpId { get; set; }

    public uint ResourceId { get; set; }

    public uint Quantity { get; set; }

    public byte SellOnStockout { get; set; }

    public string? Shipping { get; set; }
}
