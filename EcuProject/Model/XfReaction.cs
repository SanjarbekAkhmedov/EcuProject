using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfReaction
{
    public uint ReactionId { get; set; }

    public string TextColor { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string ImageUrl2x { get; set; } = null!;

    public byte SpriteMode { get; set; }

    public byte[] SpriteParams { get; set; } = null!;

    public int ReactionScore { get; set; }

    public uint DisplayOrder { get; set; }

    public byte Active { get; set; }
}
