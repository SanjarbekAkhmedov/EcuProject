using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgAttachmentExif
{
    public uint AttachmentId { get; set; }

    public uint AttachDate { get; set; }

    public byte[]? ExifData { get; set; }
}
