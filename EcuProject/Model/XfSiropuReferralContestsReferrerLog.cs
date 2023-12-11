using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSiropuReferralContestsReferrerLog
{
    public uint LogId { get; set; }

    public uint UserId { get; set; }

    public string Url { get; set; } = null!;

    public uint Date { get; set; }
}
