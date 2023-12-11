using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBriviumStyleRating
{
    public uint StyleRatingId { get; set; }

    public uint ImageWidth { get; set; }

    public uint ImageHeight { get; set; }

    public uint IconWidth { get; set; }

    public uint IconHeight { get; set; }

    public uint IconSecondPosition { get; set; }

    public uint StyleDate { get; set; }

    public byte Status { get; set; }
}
