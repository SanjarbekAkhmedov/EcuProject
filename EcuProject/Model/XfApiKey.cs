using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfApiKey
{
    public uint ApiKeyId { get; set; }

    public byte[] ApiKey { get; set; } = null!;

    public byte[] ApiKeyHash { get; set; } = null!;

    public string Title { get; set; } = null!;

    public byte IsSuperUser { get; set; }

    public uint UserId { get; set; }

    public byte AllowAllScopes { get; set; }

    public byte[] Scopes { get; set; } = null!;

    public byte Active { get; set; }

    public uint CreationUserId { get; set; }

    public uint CreationDate { get; set; }

    public uint LastUseDate { get; set; }
}
