using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserAlert
{
    public uint AlertId { get; set; }

    /// <summary>
    /// User being alerted
    /// </summary>
    public uint AlertedUserId { get; set; }

    /// <summary>
    /// User who did the action that caused the alert
    /// </summary>
    public uint UserId { get; set; }

    /// <summary>
    /// Corresponds to user_id
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// eg: trophy
    /// </summary>
    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    /// <summary>
    /// eg: edit
    /// </summary>
    public byte[] Action { get; set; } = null!;

    public uint EventDate { get; set; }

    /// <summary>
    /// Time when this was viewed by the alerted user
    /// </summary>
    public uint ViewDate { get; set; }

    /// <summary>
    /// Time when this was read by the alerted user
    /// </summary>
    public uint ReadDate { get; set; }

    public byte AutoRead { get; set; }

    /// <summary>
    /// Serialized. Stores any extra data relevant to the alert
    /// </summary>
    public byte[] ExtraData { get; set; } = null!;

    public byte[] DependsOnAddonId { get; set; } = null!;
}
