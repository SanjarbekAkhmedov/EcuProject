using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCaptchaQuestion
{
    public uint CaptchaQuestionId { get; set; }

    public string Question { get; set; } = null!;

    /// <summary>
    /// Serialized array of possible correct answers.
    /// </summary>
    public byte[] Answers { get; set; } = null!;

    public byte Active { get; set; }
}
