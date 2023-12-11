using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdvertising
{
    public uint AdId { get; set; }

    public string Title { get; set; } = null!;

    public byte[] PositionId { get; set; } = null!;

    public string AdHtml { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] DisplayCriteria { get; set; } = null!;

    public byte Active { get; set; }
}
