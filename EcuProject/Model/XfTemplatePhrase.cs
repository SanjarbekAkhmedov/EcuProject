using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTemplatePhrase
{
    public uint TemplateId { get; set; }

    public byte[] PhraseTitle { get; set; } = null!;
}
