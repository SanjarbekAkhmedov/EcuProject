using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsPurchaseTransaction
{
    public uint TransactionId { get; set; }

    public uint UserId { get; set; }

    public uint FromUserId { get; set; }

    public uint TransactionDate { get; set; }

    public double Amount { get; set; }

    public double Cost { get; set; }

    public uint EventId { get; set; }

    public string CurrencyId { get; set; } = null!;

    public byte[]? Message { get; set; }

    public uint IpId { get; set; }
}
