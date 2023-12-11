using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceDownload
{
    public uint ResourceDownloadId { get; set; }

    public uint ResourceVersionId { get; set; }

    public uint UserId { get; set; }

    public uint ResourceId { get; set; }

    public uint LastDownloadDate { get; set; }
}
