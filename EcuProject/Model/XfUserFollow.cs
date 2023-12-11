using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserFollow
{
    public uint UserId { get; set; }

    /// <summary>
    /// User being followed
    /// </summary>
    public uint FollowUserId { get; set; }

    public uint FollowDate { get; set; }
}
