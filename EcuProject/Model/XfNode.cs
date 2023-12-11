using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNode
{
    public uint NodeId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    /// <summary>
    /// Unique column used as string ID by some node types
    /// </summary>
    public string? NodeName { get; set; }

    public byte[] NodeTypeId { get; set; } = null!;

    public string TcCniIconType { get; set; } = null!;

    public string TcCniIconValue { get; set; } = null!;

    public string TcCniUnreadIconValue { get; set; } = null!;

    public uint ParentNodeId { get; set; }

    public uint DisplayOrder { get; set; }

    /// <summary>
    /// If 0, hidden from node list. Still counts for lft/rgt.
    /// </summary>
    public byte DisplayInList { get; set; }

    /// <summary>
    /// Nested set info &apos;left&apos; value
    /// </summary>
    public uint Lft { get; set; }

    /// <summary>
    /// Nested set info &apos;right&apos; value
    /// </summary>
    public uint Rgt { get; set; }

    /// <summary>
    /// Depth = 0: no parent
    /// </summary>
    public uint Depth { get; set; }

    /// <summary>
    /// Style override for specific node
    /// </summary>
    public uint StyleId { get; set; }

    /// <summary>
    /// Style override; pushed down tree
    /// </summary>
    public uint EffectiveStyleId { get; set; }

    public byte[]? BreadcrumbData { get; set; }

    public byte[] NavigationId { get; set; } = null!;

    public byte[] EffectiveNavigationId { get; set; } = null!;

    public byte XfaNitType { get; set; }

    public string? XfaNitParams { get; set; }
}
