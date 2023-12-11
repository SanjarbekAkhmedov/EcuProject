using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpDiscount
{
    public uint DiscountId { get; set; }

    public string Name { get; set; } = null!;

    public uint CreatorId { get; set; }

    public decimal DiscountAmount { get; set; }

    public byte IsFixed { get; set; }

    public byte ApplytoRenewal { get; set; }

    public string Type { get; set; } = null!;

    public string ResourceIds { get; set; } = null!;

    public uint FromDate { get; set; }

    public uint ToDate { get; set; }

    public byte Applied { get; set; }
}
