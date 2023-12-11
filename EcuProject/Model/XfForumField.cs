using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfForumField
{
    public uint NodeId { get; set; }

    public byte[] FieldId { get; set; } = null!;
}
