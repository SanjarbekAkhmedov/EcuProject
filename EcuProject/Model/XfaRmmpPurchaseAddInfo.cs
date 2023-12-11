using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpPurchaseAddInfo
{
    public uint PurchaseId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string AdditionalInfo { get; set; } = null!;
}
