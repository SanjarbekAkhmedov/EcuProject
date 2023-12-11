using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNotice
{
    public uint NoticeId { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public byte Active { get; set; }

    public uint DisplayOrder { get; set; }

    /// <summary>
    /// Notice may be hidden when read by users
    /// </summary>
    public byte Dismissible { get; set; }

    public byte[] UserCriteria { get; set; } = null!;

    public byte[] PageCriteria { get; set; } = null!;

    public string DisplayImage { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string Visibility { get; set; } = null!;

    public string NoticeType { get; set; } = null!;

    public string DisplayStyle { get; set; } = null!;

    public string CssClass { get; set; } = null!;

    public uint DisplayDuration { get; set; }

    public uint DelayDuration { get; set; }

    public byte AutoDismiss { get; set; }
}
