using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserConfirmation
{
    public uint UserId { get; set; }

    public string ConfirmationType { get; set; } = null!;

    public string ConfirmationKey { get; set; } = null!;

    public uint ConfirmationDate { get; set; }
}
