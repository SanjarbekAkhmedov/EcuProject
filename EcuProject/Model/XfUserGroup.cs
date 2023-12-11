using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserGroup
{
    public uint UserGroupId { get; set; }

    public string Title { get; set; } = null!;

    public uint DisplayStylePriority { get; set; }

    public string UsernameCss { get; set; } = null!;

    public string UserTitle { get; set; } = null!;

    public string BannerCssClass { get; set; } = null!;

    public string BannerText { get; set; } = null!;
}
