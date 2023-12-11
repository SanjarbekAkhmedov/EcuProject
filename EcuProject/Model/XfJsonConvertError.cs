using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfJsonConvertError
{
    public uint ErrorId { get; set; }

    public byte[] TableName { get; set; } = null!;

    public byte[] ColumnName { get; set; } = null!;

    public uint PkId { get; set; }

    public byte[] OriginalValue { get; set; } = null!;
}
