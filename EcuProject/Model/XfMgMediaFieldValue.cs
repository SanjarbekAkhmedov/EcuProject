using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgMediaFieldValue
{
    public uint MediaId { get; set; }

    public byte[] FieldId { get; set; } = null!;

    public string FieldValue { get; set; } = null!;
}
