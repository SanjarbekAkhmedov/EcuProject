using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPaymentProvider
{
    public byte[] ProviderId { get; set; } = null!;

    public string ProviderClass { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
