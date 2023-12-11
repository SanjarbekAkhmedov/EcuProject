using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgCategory
{
    public uint CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint ParentCategoryId { get; set; }

    public uint DisplayOrder { get; set; }

    public uint Lft { get; set; }

    public uint Rgt { get; set; }

    public ushort Depth { get; set; }

    public byte[] BreadcrumbData { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public byte[] AllowedTypes { get; set; } = null!;

    public uint MediaCount { get; set; }

    public uint AlbumCount { get; set; }

    public uint CommentCount { get; set; }

    public byte[] FieldCache { get; set; } = null!;

    public ushort MinTags { get; set; }

    public uint? CategoryIndexLimit { get; set; }
}
