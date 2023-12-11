using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserGroupPromotion
{
    public uint PromotionId { get; set; }

    public string Title { get; set; } = null!;

    public byte Active { get; set; }

    public byte[] UserCriteria { get; set; } = null!;

    public byte[] ExtraUserGroupIds { get; set; } = null!;
}
