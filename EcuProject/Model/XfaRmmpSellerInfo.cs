using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpSellerInfo
{
    public uint UserId { get; set; }

    public byte ActivateInvoicing { get; set; }

    public string Name { get; set; } = null!;

    public string InvoicePrefix { get; set; } = null!;

    public string? Address { get; set; }

    public string? AdditionalInfo { get; set; }

    public uint LogoDate { get; set; }

    public string CommType { get; set; } = null!;

    public string CommTitlePurchase { get; set; } = null!;

    public string CommTextPurchase { get; set; } = null!;

    public string CommTitleRenewal { get; set; } = null!;

    public string CommTextRenewal { get; set; } = null!;

    public string CommTitlePurchaseRefund { get; set; } = null!;

    public string CommTextPurchaseRefund { get; set; } = null!;

    public string CommTitleRenewalRefund { get; set; } = null!;

    public string CommTextRenewalRefund { get; set; } = null!;
}
