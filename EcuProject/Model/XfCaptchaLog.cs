using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCaptchaLog
{
    public byte[] Hash { get; set; } = null!;

    public string CaptchaType { get; set; } = null!;

    public string CaptchaData { get; set; } = null!;

    public uint CaptchaDate { get; set; }
}
