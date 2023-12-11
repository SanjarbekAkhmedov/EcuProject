using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserGroupRelation
{
    public uint UserId { get; set; }

    public uint UserGroupId { get; set; }

    public byte IsPrimary { get; set; }
}
