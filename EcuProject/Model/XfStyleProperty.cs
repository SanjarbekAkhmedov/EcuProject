using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfStyleProperty
{
    public uint PropertyId { get; set; }

    public byte[] PropertyName { get; set; } = null!;

    public uint StyleId { get; set; }

    public byte[]? GroupName { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string PropertyType { get; set; } = null!;

    public byte[] CssComponents { get; set; } = null!;

    public string ValueType { get; set; } = null!;

    public string ValueParameters { get; set; } = null!;

    public byte[] DependsOn { get; set; } = null!;

    public byte[] ValueGroup { get; set; } = null!;

    public byte[] PropertyValue { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
