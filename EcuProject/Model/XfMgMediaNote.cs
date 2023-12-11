using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgMediaNote
{
    public uint NoteId { get; set; }

    public byte[] NoteType { get; set; } = null!;

    public uint MediaId { get; set; }

    public byte[]? NoteData { get; set; }

    public string? NoteText { get; set; }

    public uint NoteDate { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public string TagState { get; set; } = null!;

    public uint TagStateDate { get; set; }

    public uint TaggedUserId { get; set; }

    public string TaggedUsername { get; set; } = null!;
}
