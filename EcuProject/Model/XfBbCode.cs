using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBbCode
{
    public byte[] BbCodeId { get; set; } = null!;

    public string BbCodeMode { get; set; } = null!;

    public string HasOption { get; set; } = null!;

    public string ReplaceHtml { get; set; } = null!;

    public string ReplaceHtmlEmail { get; set; } = null!;

    public string ReplaceText { get; set; } = null!;

    public string CallbackClass { get; set; } = null!;

    public string CallbackMethod { get; set; } = null!;

    public string OptionRegex { get; set; } = null!;

    public byte TrimLinesAfter { get; set; }

    public byte PlainChildren { get; set; }

    public byte DisableSmilies { get; set; }

    public byte DisableNl2br { get; set; }

    public byte DisableAutolink { get; set; }

    public byte AllowEmpty { get; set; }

    public byte AllowSignature { get; set; }

    public string EditorIconType { get; set; } = null!;

    public string EditorIconValue { get; set; } = null!;

    public byte Active { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
