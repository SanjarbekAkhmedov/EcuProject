using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpDigitalProduct
{
    public uint DigitalpId { get; set; }

    public uint ResourceId { get; set; }

    public uint Duration { get; set; }

    public string DurationType { get; set; } = null!;

    public byte HasRestriction { get; set; }

    public byte RequireUrl { get; set; }

    public decimal RenewalPrice { get; set; }

    public decimal BaseRenewalPrice { get; set; }

    public uint DelayRenewal { get; set; }

    public byte AllowExpiredRenewal { get; set; }

    public string? LicKeyFormat { get; set; }
}
