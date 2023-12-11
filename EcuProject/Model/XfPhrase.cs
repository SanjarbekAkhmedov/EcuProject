using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPhrase
{
    public uint PhraseId { get; set; }

    public uint LanguageId { get; set; }

    public byte[] Title { get; set; } = null!;

    public string PhraseText { get; set; } = null!;

    public byte GlobalCache { get; set; }

    public byte[] AddonId { get; set; } = null!;

    public uint VersionId { get; set; }

    public string VersionString { get; set; } = null!;
}
