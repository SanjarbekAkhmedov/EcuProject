using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfLanguage
{
    public uint LanguageId { get; set; }

    public uint ParentId { get; set; }

    public byte[] ParentList { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string DateFormat { get; set; } = null!;

    public string TimeFormat { get; set; } = null!;

    public string CurrencyFormat { get; set; } = null!;

    public string DecimalPoint { get; set; } = null!;

    public string ThousandsSeparator { get; set; } = null!;

    public byte[] PhraseCache { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string TextDirection { get; set; } = null!;

    /// <summary>
    /// Week start day. 0 = Sunday, 6 = Saturday
    /// </summary>
    public byte WeekStart { get; set; }

    public string LabelSeparator { get; set; } = null!;

    public string CommaSeparator { get; set; } = null!;

    public string Ellipsis { get; set; } = null!;

    public string ParenthesisOpen { get; set; } = null!;

    public string ParenthesisClose { get; set; } = null!;

    public sbyte UserSelectable { get; set; }
}
