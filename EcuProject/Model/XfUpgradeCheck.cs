using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUpgradeCheck
{
    public uint CheckId { get; set; }

    public string? ErrorCode { get; set; }

    public uint? CheckDate { get; set; }

    public byte? BoardUrlValid { get; set; }

    public byte? BrandingValid { get; set; }

    public byte? LicenseExpired { get; set; }

    public uint? LastAgreementDate { get; set; }

    public uint? LastAgreementUpdate { get; set; }

    public byte[]? InvalidAddOns { get; set; }

    public byte[]? InstallableAddOns { get; set; }

    public byte[]? AvailableUpdates { get; set; }

    public byte[]? ResponseData { get; set; }
}
