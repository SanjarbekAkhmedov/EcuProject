using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgMediaItem
{
    public uint MediaId { get; set; }

    public string? MediaHash { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint MediaDate { get; set; }

    public uint LastEditDate { get; set; }

    public uint LastCommentDate { get; set; }

    public byte[] MediaType { get; set; } = null!;

    public string? MediaTag { get; set; }

    public string? MediaEmbedUrl { get; set; }

    public string MediaState { get; set; } = null!;

    public uint AlbumId { get; set; }

    public uint CategoryId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint IpId { get; set; }

    public int ReactionScore { get; set; }

    public byte[]? Reactions { get; set; }

    public byte[] ReactionUsers { get; set; } = null!;

    public uint CommentCount { get; set; }

    public uint ViewCount { get; set; }

    public uint RatingCount { get; set; }

    public uint RatingSum { get; set; }

    public float RatingAvg { get; set; }

    public float RatingWeighted { get; set; }

    public byte Watermarked { get; set; }

    public byte[] CustomFields { get; set; } = null!;

    public byte[] ExifData { get; set; } = null!;

    public uint WarningId { get; set; }

    public string WarningMessage { get; set; } = null!;

    public uint Position { get; set; }

    public uint Imported { get; set; }

    public uint ThumbnailDate { get; set; }

    public uint CustomThumbnailDate { get; set; }

    public uint PosterDate { get; set; }

    public uint LastCommentId { get; set; }

    public uint LastCommentUserId { get; set; }

    public string LastCommentUsername { get; set; } = null!;

    public byte[] Tags { get; set; } = null!;
}
