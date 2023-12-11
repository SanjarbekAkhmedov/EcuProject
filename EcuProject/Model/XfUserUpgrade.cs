using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserUpgrade
{
    public uint UserUpgradeId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] ExtraGroupIds { get; set; } = null!;

    public byte Recurring { get; set; }

    public decimal CostAmount { get; set; }

    public string CostCurrency { get; set; } = null!;

    public byte LengthAmount { get; set; }

    public string LengthUnit { get; set; } = null!;

    public byte[] DisabledUpgradeIds { get; set; } = null!;

    public byte CanPurchase { get; set; }

    public byte[] PaymentProfileIds { get; set; } = null!;
}
