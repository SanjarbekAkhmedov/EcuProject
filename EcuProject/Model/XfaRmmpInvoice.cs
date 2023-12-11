using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpInvoice
{
    public uint InvoiceId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public decimal Price { get; set; }

    public string Currency { get; set; } = null!;

    public string Status { get; set; } = null!;

    public uint InvoiceDate { get; set; }

    public byte Warned { get; set; }
}
