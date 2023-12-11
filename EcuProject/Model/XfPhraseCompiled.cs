using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPhraseCompiled
{
    public uint LanguageId { get; set; }

    public byte[] Title { get; set; } = null!;

    public string PhraseText { get; set; } = null!;
}
