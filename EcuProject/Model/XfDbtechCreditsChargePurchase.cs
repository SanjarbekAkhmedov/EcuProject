using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsChargePurchase
{
    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public string ContentHash { get; set; } = null!;

    public uint UserId { get; set; }
}
