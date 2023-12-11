using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPhraseMap
{
    public uint PhraseMapId { get; set; }

    public uint LanguageId { get; set; }

    public byte[] Title { get; set; } = null!;

    public uint PhraseId { get; set; }

    public byte[]? PhraseGroup { get; set; }
}
