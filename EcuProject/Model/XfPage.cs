using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPage
{
    public uint NodeId { get; set; }

    public uint PublishDate { get; set; }

    public uint ModifiedDate { get; set; }

    public uint ViewCount { get; set; }

    public byte LogVisits { get; set; }

    public byte ListSiblings { get; set; }

    public byte ListChildren { get; set; }

    public string CallbackClass { get; set; } = null!;

    public string CallbackMethod { get; set; } = null!;

    public byte AdvancedMode { get; set; }
}
