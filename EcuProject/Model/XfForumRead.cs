using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfForumRead
{
    public uint ForumReadId { get; set; }

    public uint UserId { get; set; }

    public uint NodeId { get; set; }

    public uint ForumReadDate { get; set; }
}
