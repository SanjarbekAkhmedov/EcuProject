using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadRedirect
{
    public uint ThreadId { get; set; }

    public string TargetUrl { get; set; } = null!;

    public string RedirectKey { get; set; } = null!;

    public uint ExpiryDate { get; set; }
}
