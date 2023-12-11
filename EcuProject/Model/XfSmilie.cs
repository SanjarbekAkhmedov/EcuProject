using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSmilie
{
    public uint SmilieId { get; set; }

    public string Title { get; set; } = null!;

    public string SmilieText { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string ImageUrl2x { get; set; } = null!;

    public byte SpriteMode { get; set; }

    public byte[] SpriteParams { get; set; } = null!;

    public uint SmilieCategoryId { get; set; }

    public uint DisplayOrder { get; set; }

    public byte DisplayInEditor { get; set; }
}
