using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfStylePropertyGroup
{
    public uint PropertyGroupId { get; set; }

    public byte[] GroupName { get; set; } = null!;

    public uint StyleId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
