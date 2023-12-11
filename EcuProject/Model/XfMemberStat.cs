using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMemberStat
{
    public uint MemberStatId { get; set; }

    public byte[] MemberStatKey { get; set; } = null!;

    public byte[]? Criteria { get; set; }

    public string CallbackClass { get; set; } = null!;

    public string CallbackMethod { get; set; } = null!;

    public string VisibilityClass { get; set; } = null!;

    public string VisibilityMethod { get; set; } = null!;

    public string SortOrder { get; set; } = null!;

    public string SortDirection { get; set; } = null!;

    public byte[] PermissionLimit { get; set; } = null!;

    public byte ShowValue { get; set; }

    public uint UserLimit { get; set; }

    public uint DisplayOrder { get; set; }

    public byte[] AddonId { get; set; } = null!;

    public byte OverviewDisplay { get; set; }

    public byte Active { get; set; }

    public uint CacheLifetime { get; set; }

    public uint CacheExpiry { get; set; }

    public byte[]? CacheResults { get; set; }
}
