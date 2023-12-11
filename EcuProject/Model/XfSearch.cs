using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSearch
{
    public uint SearchId { get; set; }

    public byte[] SearchResults { get; set; } = null!;

    public ushort ResultCount { get; set; }

    public string SearchType { get; set; } = null!;

    public string SearchQuery { get; set; } = null!;

    public byte[] SearchConstraints { get; set; } = null!;

    public string SearchOrder { get; set; } = null!;

    public byte SearchGrouping { get; set; }

    public byte[] UserResults { get; set; } = null!;

    public byte[] Warnings { get; set; } = null!;

    public uint UserId { get; set; }

    public uint SearchDate { get; set; }

    public string QueryHash { get; set; } = null!;
}
