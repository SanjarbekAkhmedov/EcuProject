using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserOption
{
    public uint UserId { get; set; }

    /// <summary>
    /// Show date of month year (thus: age)
    /// </summary>
    public byte ShowDobYear { get; set; }

    /// <summary>
    /// Show date of birth day and month
    /// </summary>
    public byte ShowDobDate { get; set; }

    /// <summary>
    /// Show user&apos;s signatures with content
    /// </summary>
    public byte ContentShowSignature { get; set; }

    public byte ReceiveAdminEmail { get; set; }

    /// <summary>
    /// Receive an email upon receiving a conversation message
    /// </summary>
    public byte EmailOnConversation { get; set; }

    public byte PushOnConversation { get; set; }

    /// <summary>
    /// If non-zero, this user will be subjected to annoying random system failures.
    /// </summary>
    public byte IsDiscouraged { get; set; }

    public string CreationWatchState { get; set; } = null!;

    public string InteractionWatchState { get; set; } = null!;

    /// <summary>
    /// Comma-separated list of alerts from which the user has opted out. Example: &apos;post_like,user_trophy&apos;
    /// </summary>
    public string AlertOptout { get; set; } = null!;

    /// <summary>
    /// Comma-separated list of alerts from which the user has opted out for push notifications. Example: &apos;post_like,user_trophy&apos;
    /// </summary>
    public string PushOptout { get; set; } = null!;

    public byte UseTfa { get; set; }
}
