using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmCategoryWatch
{
    public uint UserId { get; set; }

    public uint ResourceCategoryId { get; set; }

    public string NotifyOn { get; set; } = null!;

    public byte SendAlert { get; set; }

    public byte SendEmail { get; set; }

    public byte IncludeChildren { get; set; }
}
