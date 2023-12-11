using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPurchasable
{
    public string PurchasableTypeId { get; set; } = null!;

    public string PurchasableClass { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
