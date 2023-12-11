using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTfaAttempt
{
    public uint AttemptId { get; set; }

    public uint UserId { get; set; }

    public uint AttemptDate { get; set; }
}
