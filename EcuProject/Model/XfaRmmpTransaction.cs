using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpTransaction
{
    public uint TransactionId { get; set; }

    public string Business { get; set; } = null!;

    public string TxnId { get; set; } = null!;

    public string TxnIdPos { get; set; } = null!;

    public string? Token { get; set; }

    public decimal Fees { get; set; }

    public decimal Pos { get; set; }

    public decimal Shipping { get; set; }

    public string Status { get; set; } = null!;

    public string PosPaid { get; set; } = null!;

    public uint PosInvoiceId { get; set; }
}
