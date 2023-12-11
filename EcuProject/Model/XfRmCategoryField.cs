using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmCategoryField
{
    public byte[] FieldId { get; set; } = null!;

    public uint ResourceCategoryId { get; set; }
}
