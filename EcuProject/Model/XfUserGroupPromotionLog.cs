using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserGroupPromotionLog
{
    public uint PromotionId { get; set; }

    public uint UserId { get; set; }

    public uint PromotionDate { get; set; }

    public string PromotionState { get; set; } = null!;
}
