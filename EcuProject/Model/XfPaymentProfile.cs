using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPaymentProfile
{
    public uint PaymentProfileId { get; set; }

    public byte[] ProviderId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string DisplayTitle { get; set; } = null!;

    public byte[]? Options { get; set; }

    public byte Active { get; set; }

    public uint XfaRmmpUserId { get; set; }

    public uint XfaRmmpActive { get; set; }
}
