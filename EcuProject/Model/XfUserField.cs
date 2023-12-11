using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserField
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

    public byte ShowRegistration { get; set; }

    public string UserEditable { get; set; } = null!;

    public byte ViewableProfile { get; set; }

    public byte ViewableMessage { get; set; }

    public string DisplayTemplate { get; set; } = null!;

    public string WrapperTemplate { get; set; } = null!;

    public byte ModeratorEditable { get; set; }
}
