using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceFieldValue
{
    public uint ResourceId { get; set; }

    public byte[] FieldId { get; set; } = null!;

    public string FieldValue { get; set; } = null!;
}
