using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNavigation
{
    public byte[] NavigationId { get; set; } = null!;

    public byte[] ParentNavigationId { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] NavigationTypeId { get; set; } = null!;

    public string TypeConfig { get; set; } = null!;

    public byte[] ConditionExpression { get; set; } = null!;

    public byte[] ConditionSetup { get; set; } = null!;

    public byte[] DataExpression { get; set; } = null!;

    public byte[] DataSetup { get; set; } = null!;

    public byte[] GlobalSetup { get; set; } = null!;

    public byte Enabled { get; set; }

    public byte IsCustomized { get; set; }

    public byte[] DefaultValue { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
