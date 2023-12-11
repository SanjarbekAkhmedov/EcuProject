using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceReviewField
{
    public byte[] FieldId { get; set; } = null!;

    public string DisplayGroup { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] FieldType { get; set; } = null!;

    public byte[] FieldChoices { get; set; } = null!;

    public byte[] MatchType { get; set; } = null!;

    public byte[] MatchParams { get; set; } = null!;

    public uint MaxLength { get; set; }

    public byte Required { get; set; }

    public string DisplayTemplate { get; set; } = null!;

    public string WrapperTemplate { get; set; } = null!;
}
