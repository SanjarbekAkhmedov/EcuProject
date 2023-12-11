using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsRedeemLog
{
    public uint RedeemLogId { get; set; }

    public uint UserId { get; set; }

    public uint RedeemDate { get; set; }

    public string RedeemCode { get; set; } = null!;

    public uint EventId { get; set; }

    public uint CurrencyId { get; set; }

    public decimal Amount { get; set; }

    public byte[]? Message { get; set; }
}
