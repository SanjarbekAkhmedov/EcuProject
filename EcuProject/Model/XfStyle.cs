using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfStyle
{
    public uint StyleId { get; set; }

    public uint ParentId { get; set; }

    /// <summary>
    /// IDs of ancestor styles in order, eg: this,parent,grandparent,root
    /// </summary>
    public byte[] ParentList { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    /// <summary>
    /// Serialized array of materialized style properties for this style
    /// </summary>
    public byte[] Properties { get; set; } = null!;

    public byte[] Assets { get; set; } = null!;

    public byte[] EffectiveAssets { get; set; } = null!;

    public uint LastModifiedDate { get; set; }

    /// <summary>
    /// Unselectable styles are unselectable by non-admin visitors
    /// </summary>
    public byte UserSelectable { get; set; }

    public byte[]? DesignerMode { get; set; }
}
