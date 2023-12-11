using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserProfile
{
    public uint UserId { get; set; }

    public byte DobDay { get; set; }

    public byte DobMonth { get; set; }

    public ushort DobYear { get; set; }

    public string Signature { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string Location { get; set; } = null!;

    /// <summary>
    /// Comma-separated integers from xf_user_follow
    /// </summary>
    public string Following { get; set; } = null!;

    /// <summary>
    /// Comma-separated integers from xf_user_ignored
    /// </summary>
    public string Ignored { get; set; } = null!;

    /// <summary>
    /// X-Position from which to start the square crop on the m avatar
    /// </summary>
    public uint AvatarCropX { get; set; }

    /// <summary>
    /// Y-Position from which to start the square crop on the m avatar
    /// </summary>
    public uint AvatarCropY { get; set; }

    public uint BannerDate { get; set; }

    public byte? BannerPositionY { get; set; }

    public string About { get; set; } = null!;

    public byte[] CustomFields { get; set; } = null!;

    public byte[] ConnectedAccounts { get; set; } = null!;

    public uint PasswordDate { get; set; }
}
