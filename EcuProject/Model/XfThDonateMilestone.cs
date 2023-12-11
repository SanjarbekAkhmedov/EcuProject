using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThDonateMilestone
{
    public uint MilestoneId { get; set; }

    public uint CampaignId { get; set; }

    public string Title { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public float Amount { get; set; }

    public sbyte Percent { get; set; }

    public string ProgressBarColor { get; set; } = null!;

    public sbyte AlertAdministrators { get; set; }

    public sbyte Active { get; set; }

    public sbyte AlertSent { get; set; }

    public string? Description { get; set; }
}
