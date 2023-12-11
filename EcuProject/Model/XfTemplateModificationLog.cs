using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTemplateModificationLog
{
    public uint TemplateId { get; set; }

    public uint ModificationId { get; set; }

    public string Status { get; set; } = null!;

    public uint ApplyCount { get; set; }
}
