using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgCategoryField
{
    public byte[] FieldId { get; set; } = null!;

    public uint CategoryId { get; set; }
}
