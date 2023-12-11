using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfContentTypeField
{
    public byte[] ContentType { get; set; } = null!;

    public byte[] FieldName { get; set; } = null!;

    public string FieldValue { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
