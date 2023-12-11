using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBbCodeMediaSite
{
    public byte[] MediaSiteId { get; set; } = null!;

    public string SiteTitle { get; set; } = null!;

    public string SiteUrl { get; set; } = null!;

    public string MatchUrls { get; set; } = null!;

    /// <summary>
    /// If 1, match_urls will be treated as regular expressions rather than simple URL matches.
    /// </summary>
    public byte MatchIsRegex { get; set; }

    public byte OembedEnabled { get; set; }

    public byte[] OembedApiEndpoint { get; set; } = null!;

    public byte[] OembedUrlScheme { get; set; } = null!;

    public byte OembedRetainScripts { get; set; }

    public string MatchCallbackClass { get; set; } = null!;

    public string MatchCallbackMethod { get; set; } = null!;

    public string EmbedHtmlCallbackClass { get; set; } = null!;

    public string EmbedHtmlCallbackMethod { get; set; } = null!;

    public string CookieThirdParties { get; set; } = null!;

    /// <summary>
    /// If 0, this media type will not be listed as available, but will still be usable.
    /// </summary>
    public byte Supported { get; set; }

    public byte Active { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
