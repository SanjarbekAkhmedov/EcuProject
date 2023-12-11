using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfOptionGroupRelation
{
    public byte[] OptionId { get; set; } = null!;

    public byte[] GroupId { get; set; } = null!;

    public uint DisplayOrder { get; set; }
}
