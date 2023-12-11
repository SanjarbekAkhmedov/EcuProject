using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSearchIndex
{
    public string ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Metadata { get; set; } = null!;

    public uint UserId { get; set; }

    public uint ItemDate { get; set; }

    public uint DiscussionId { get; set; }
}
