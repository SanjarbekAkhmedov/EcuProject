using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgAlbum
{
    public uint AlbumId { get; set; }

    public uint CategoryId { get; set; }

    public string? AlbumHash { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint CreateDate { get; set; }

    public uint LastUpdateDate { get; set; }

    public byte[]? MediaItemCache { get; set; }

    public string? ViewPrivacy { get; set; }

    public byte[]? ViewUsers { get; set; }

    public string? AddPrivacy { get; set; }

    public byte[]? AddUsers { get; set; }

    public string AlbumState { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint IpId { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public uint MediaCount { get; set; }

    public uint ViewCount { get; set; }

    public uint RatingCount { get; set; }

    public uint RatingSum { get; set; }

    public float RatingAvg { get; set; }

    public float RatingWeighted { get; set; }

    public uint CommentCount { get; set; }

    public uint LastCommentDate { get; set; }

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public string DefaultOrder { get; set; } = null!;

    public uint ThumbnailDate { get; set; }

    public uint CustomThumbnailDate { get; set; }

    public uint LastCommentId { get; set; }

    public uint LastCommentUserId { get; set; }

    public string LastCommentUsername { get; set; } = null!;
}
