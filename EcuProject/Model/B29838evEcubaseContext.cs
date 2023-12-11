using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Model;

public partial class B29838evEcubaseContext : DbContext
{
    public B29838evEcubaseContext()
    {
    }

    public B29838evEcubaseContext(DbContextOptions<B29838evEcubaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppCarmaker> AppCarmakers { get; set; }

    public virtual DbSet<AppEcu> AppEcus { get; set; }

    public virtual DbSet<AppEcuAbit> AppEcuAbits { get; set; }

    public virtual DbSet<AppEcuAcdelco> AppEcuAcdelcos { get; set; }

    public virtual DbSet<AppEcuBosch> AppEcuBosches { get; set; }

    public virtual DbSet<AppEcuCpu1> AppEcuCpu1s { get; set; }

    public virtual DbSet<AppEcuDelphi> AppEcuDelphis { get; set; }

    public virtual DbSet<AppEcuDenso> AppEcuDensos { get; set; }

    public virtual DbSet<AppEcuHitachi> AppEcuHitachis { get; set; }

    public virtual DbSet<AppEcuKefico> AppEcuKeficos { get; set; }

    public virtual DbSet<AppEcuKeihin> AppEcuKeihins { get; set; }

    public virtual DbSet<AppEcuLuca> AppEcuLucas { get; set; }

    public virtual DbSet<AppEcuMagneti> AppEcuMagnetis { get; set; }

    public virtual DbSet<AppEcuProducer> AppEcuProducers { get; set; }

    public virtual DbSet<AppEcuSagem> AppEcuSagems { get; set; }

    public virtual DbSet<AppEcuSiemen> AppEcuSiemens { get; set; }

    public virtual DbSet<AppEcuTemic> AppEcuTemics { get; set; }

    public virtual DbSet<AppEcuTranstron> AppEcuTranstrons { get; set; }

    public virtual DbSet<AppEcuTrw> AppEcuTrws { get; set; }

    public virtual DbSet<AppEcuType> AppEcuTypes { get; set; }

    public virtual DbSet<AppEcuValeo> AppEcuValeos { get; set; }

    public virtual DbSet<AppEcuVisteon> AppEcuVisteons { get; set; }

    public virtual DbSet<AppEcuWeichai> AppEcuWeichais { get; set; }

    public virtual DbSet<XfActivitySummaryDefinition> XfActivitySummaryDefinitions { get; set; }

    public virtual DbSet<XfActivitySummarySection> XfActivitySummarySections { get; set; }

    public virtual DbSet<XfAddon> XfAddons { get; set; }

    public virtual DbSet<XfAddonInstallBatch> XfAddonInstallBatches { get; set; }

    public virtual DbSet<XfAdmin> XfAdmins { get; set; }

    public virtual DbSet<XfAdminLog> XfAdminLogs { get; set; }

    public virtual DbSet<XfAdminNavigation> XfAdminNavigations { get; set; }

    public virtual DbSet<XfAdminPermission> XfAdminPermissions { get; set; }

    public virtual DbSet<XfAdminPermissionEntry> XfAdminPermissionEntries { get; set; }

    public virtual DbSet<XfAdvertising> XfAdvertisings { get; set; }

    public virtual DbSet<XfAdvertisingPosition> XfAdvertisingPositions { get; set; }

    public virtual DbSet<XfApiAttachmentKey> XfApiAttachmentKeys { get; set; }

    public virtual DbSet<XfApiKey> XfApiKeys { get; set; }

    public virtual DbSet<XfApiKeyScope> XfApiKeyScopes { get; set; }

    public virtual DbSet<XfApiLoginToken> XfApiLoginTokens { get; set; }

    public virtual DbSet<XfApiScope> XfApiScopes { get; set; }

    public virtual DbSet<XfApprovalQueue> XfApprovalQueues { get; set; }

    public virtual DbSet<XfAttachment> XfAttachments { get; set; }

    public virtual DbSet<XfAttachmentDatum> XfAttachmentData { get; set; }

    public virtual DbSet<XfAttachmentView> XfAttachmentViews { get; set; }

    public virtual DbSet<XfBanEmail> XfBanEmails { get; set; }

    public virtual DbSet<XfBbCode> XfBbCodes { get; set; }

    public virtual DbSet<XfBbCodeMediaSite> XfBbCodeMediaSites { get; set; }

    public virtual DbSet<XfBookmarkItem> XfBookmarkItems { get; set; }

    public virtual DbSet<XfBookmarkLabel> XfBookmarkLabels { get; set; }

    public virtual DbSet<XfBookmarkLabelUse> XfBookmarkLabelUses { get; set; }

    public virtual DbSet<XfBriviumStyleRating> XfBriviumStyleRatings { get; set; }

    public virtual DbSet<XfBriviumThreadRating> XfBriviumThreadRatings { get; set; }

    public virtual DbSet<XfCaptchaLog> XfCaptchaLogs { get; set; }

    public virtual DbSet<XfCaptchaQuestion> XfCaptchaQuestions { get; set; }

    public virtual DbSet<XfCategory> XfCategories { get; set; }

    public virtual DbSet<XfChangeLog> XfChangeLogs { get; set; }

    public virtual DbSet<XfClassExtension> XfClassExtensions { get; set; }

    public virtual DbSet<XfCodeEvent> XfCodeEvents { get; set; }

    public virtual DbSet<XfCodeEventListener> XfCodeEventListeners { get; set; }

    public virtual DbSet<XfConnectedAccountProvider> XfConnectedAccountProviders { get; set; }

    public virtual DbSet<XfContentSpamCache> XfContentSpamCaches { get; set; }

    public virtual DbSet<XfContentTypeField> XfContentTypeFields { get; set; }

    public virtual DbSet<XfContentVote> XfContentVotes { get; set; }

    public virtual DbSet<XfConversationMaster> XfConversationMasters { get; set; }

    public virtual DbSet<XfConversationMessage> XfConversationMessages { get; set; }

    public virtual DbSet<XfConversationRecipient> XfConversationRecipients { get; set; }

    public virtual DbSet<XfConversationUser> XfConversationUsers { get; set; }

    public virtual DbSet<XfCookieConsentLog> XfCookieConsentLogs { get; set; }

    public virtual DbSet<XfCronEntry> XfCronEntries { get; set; }

    public virtual DbSet<XfCssCache> XfCssCaches { get; set; }

    public virtual DbSet<XfDataRegistry> XfDataRegistries { get; set; }

    public virtual DbSet<XfDbtechCreditsAdjustLog> XfDbtechCreditsAdjustLogs { get; set; }

    public virtual DbSet<XfDbtechCreditsCharge> XfDbtechCreditsCharges { get; set; }

    public virtual DbSet<XfDbtechCreditsChargePurchase> XfDbtechCreditsChargePurchases { get; set; }

    public virtual DbSet<XfDbtechCreditsCurrency> XfDbtechCreditsCurrencies { get; set; }

    public virtual DbSet<XfDbtechCreditsDonationLog> XfDbtechCreditsDonationLogs { get; set; }

    public virtual DbSet<XfDbtechCreditsEvent> XfDbtechCreditsEvents { get; set; }

    public virtual DbSet<XfDbtechCreditsEventTrigger> XfDbtechCreditsEventTriggers { get; set; }

    public virtual DbSet<XfDbtechCreditsPurchaseTransaction> XfDbtechCreditsPurchaseTransactions { get; set; }

    public virtual DbSet<XfDbtechCreditsRedeemLog> XfDbtechCreditsRedeemLogs { get; set; }

    public virtual DbSet<XfDbtechCreditsTransaction> XfDbtechCreditsTransactions { get; set; }

    public virtual DbSet<XfDbtechCreditsTransferLog> XfDbtechCreditsTransferLogs { get; set; }

    public virtual DbSet<XfDeletionLog> XfDeletionLogs { get; set; }

    public virtual DbSet<XfDraft> XfDrafts { get; set; }

    public virtual DbSet<XfEditHistory> XfEditHistories { get; set; }

    public virtual DbSet<XfEditorDropdown> XfEditorDropdowns { get; set; }

    public virtual DbSet<XfEmailBounceLog> XfEmailBounceLogs { get; set; }

    public virtual DbSet<XfEmailBounceSoft> XfEmailBounceSofts { get; set; }

    public virtual DbSet<XfErrorLog> XfErrorLogs { get; set; }

    public virtual DbSet<XfFeed> XfFeeds { get; set; }

    public virtual DbSet<XfFeedLog> XfFeedLogs { get; set; }

    public virtual DbSet<XfFileCheck> XfFileChecks { get; set; }

    public virtual DbSet<XfFindNew> XfFindNews { get; set; }

    public virtual DbSet<XfFindNewDefault> XfFindNewDefaults { get; set; }

    public virtual DbSet<XfFloodCheck> XfFloodChecks { get; set; }

    public virtual DbSet<XfForum> XfForums { get; set; }

    public virtual DbSet<XfForumField> XfForumFields { get; set; }

    public virtual DbSet<XfForumPrefix> XfForumPrefixes { get; set; }

    public virtual DbSet<XfForumPrompt> XfForumPrompts { get; set; }

    public virtual DbSet<XfForumRead> XfForumReads { get; set; }

    public virtual DbSet<XfForumType> XfForumTypes { get; set; }

    public virtual DbSet<XfForumWatch> XfForumWatches { get; set; }

    public virtual DbSet<XfHelpPage> XfHelpPages { get; set; }

    public virtual DbSet<XfImageProxy> XfImageProxies { get; set; }

    public virtual DbSet<XfImageProxyReferrer> XfImageProxyReferrers { get; set; }

    public virtual DbSet<XfIp> XfIps { get; set; }

    public virtual DbSet<XfIpMatch> XfIpMatches { get; set; }

    public virtual DbSet<XfJob> XfJobs { get; set; }

    public virtual DbSet<XfJsonConvertError> XfJsonConvertErrors { get; set; }

    public virtual DbSet<XfKnownbotsAgent> XfKnownbotsAgents { get; set; }

    public virtual DbSet<XfLanguage> XfLanguages { get; set; }

    public virtual DbSet<XfLinkForum> XfLinkForums { get; set; }

    public virtual DbSet<XfLinkProxy> XfLinkProxies { get; set; }

    public virtual DbSet<XfLinkProxyReferrer> XfLinkProxyReferrers { get; set; }

    public virtual DbSet<XfLoginAttempt> XfLoginAttempts { get; set; }

    public virtual DbSet<XfMadUserEvercookie> XfMadUserEvercookies { get; set; }

    public virtual DbSet<XfMadUserFingerprint> XfMadUserFingerprints { get; set; }

    public virtual DbSet<XfMadUserMultiAccount> XfMadUserMultiAccounts { get; set; }

    public virtual DbSet<XfMailQueue> XfMailQueues { get; set; }

    public virtual DbSet<XfMemberStat> XfMemberStats { get; set; }

    public virtual DbSet<XfMgAlbum> XfMgAlbums { get; set; }

    public virtual DbSet<XfMgAlbumCommentRead> XfMgAlbumCommentReads { get; set; }

    public virtual DbSet<XfMgAlbumView> XfMgAlbumViews { get; set; }

    public virtual DbSet<XfMgAlbumWatch> XfMgAlbumWatches { get; set; }

    public virtual DbSet<XfMgAttachmentExif> XfMgAttachmentExifs { get; set; }

    public virtual DbSet<XfMgCategory> XfMgCategories { get; set; }

    public virtual DbSet<XfMgCategoryField> XfMgCategoryFields { get; set; }

    public virtual DbSet<XfMgCategoryWatch> XfMgCategoryWatches { get; set; }

    public virtual DbSet<XfMgComment> XfMgComments { get; set; }

    public virtual DbSet<XfMgMediaCommentRead> XfMgMediaCommentReads { get; set; }

    public virtual DbSet<XfMgMediaField> XfMgMediaFields { get; set; }

    public virtual DbSet<XfMgMediaFieldValue> XfMgMediaFieldValues { get; set; }

    public virtual DbSet<XfMgMediaItem> XfMgMediaItems { get; set; }

    public virtual DbSet<XfMgMediaNote> XfMgMediaNotes { get; set; }

    public virtual DbSet<XfMgMediaTemp> XfMgMediaTemps { get; set; }

    public virtual DbSet<XfMgMediaUserView> XfMgMediaUserViews { get; set; }

    public virtual DbSet<XfMgMediaView> XfMgMediaViews { get; set; }

    public virtual DbSet<XfMgMediaWatch> XfMgMediaWatches { get; set; }

    public virtual DbSet<XfMgRating> XfMgRatings { get; set; }

    public virtual DbSet<XfMgSharedMapAdd> XfMgSharedMapAdds { get; set; }

    public virtual DbSet<XfMgSharedMapView> XfMgSharedMapViews { get; set; }

    public virtual DbSet<XfMgTranscodeQueue> XfMgTranscodeQueues { get; set; }

    public virtual DbSet<XfModerator> XfModerators { get; set; }

    public virtual DbSet<XfModeratorContent> XfModeratorContents { get; set; }

    public virtual DbSet<XfModeratorLog> XfModeratorLogs { get; set; }

    public virtual DbSet<XfNavigation> XfNavigations { get; set; }

    public virtual DbSet<XfNavigationType> XfNavigationTypes { get; set; }

    public virtual DbSet<XfNewsFeed> XfNewsFeeds { get; set; }

    public virtual DbSet<XfNode> XfNodes { get; set; }

    public virtual DbSet<XfNodeType> XfNodeTypes { get; set; }

    public virtual DbSet<XfNotice> XfNotices { get; set; }

    public virtual DbSet<XfNoticeDismissed> XfNoticeDismisseds { get; set; }

    public virtual DbSet<XfOembed> XfOembeds { get; set; }

    public virtual DbSet<XfOembedReferrer> XfOembedReferrers { get; set; }

    public virtual DbSet<XfOption> XfOptions { get; set; }

    public virtual DbSet<XfOptionGroup> XfOptionGroups { get; set; }

    public virtual DbSet<XfOptionGroupRelation> XfOptionGroupRelations { get; set; }

    public virtual DbSet<XfPage> XfPages { get; set; }

    public virtual DbSet<XfPaymentProfile> XfPaymentProfiles { get; set; }

    public virtual DbSet<XfPaymentProvider> XfPaymentProviders { get; set; }

    public virtual DbSet<XfPaymentProviderLog> XfPaymentProviderLogs { get; set; }

    public virtual DbSet<XfPermission> XfPermissions { get; set; }

    public virtual DbSet<XfPermissionCacheContent> XfPermissionCacheContents { get; set; }

    public virtual DbSet<XfPermissionCombination> XfPermissionCombinations { get; set; }

    public virtual DbSet<XfPermissionCombinationUserGroup> XfPermissionCombinationUserGroups { get; set; }

    public virtual DbSet<XfPermissionEntry> XfPermissionEntries { get; set; }

    public virtual DbSet<XfPermissionEntryContent> XfPermissionEntryContents { get; set; }

    public virtual DbSet<XfPermissionInterfaceGroup> XfPermissionInterfaceGroups { get; set; }

    public virtual DbSet<XfPhrase> XfPhrases { get; set; }

    public virtual DbSet<XfPhraseCompiled> XfPhraseCompileds { get; set; }

    public virtual DbSet<XfPhraseMap> XfPhraseMaps { get; set; }

    public virtual DbSet<XfPoll> XfPolls { get; set; }

    public virtual DbSet<XfPollResponse> XfPollResponses { get; set; }

    public virtual DbSet<XfPollVote> XfPollVotes { get; set; }

    public virtual DbSet<XfPost> XfPosts { get; set; }

    public virtual DbSet<XfPreRegAction> XfPreRegActions { get; set; }

    public virtual DbSet<XfProfilePost> XfProfilePosts { get; set; }

    public virtual DbSet<XfProfilePostComment> XfProfilePostComments { get; set; }

    public virtual DbSet<XfPurchasable> XfPurchasables { get; set; }

    public virtual DbSet<XfPurchaseRequest> XfPurchaseRequests { get; set; }

    public virtual DbSet<XfReaction> XfReactions { get; set; }

    public virtual DbSet<XfReactionContent> XfReactionContents { get; set; }

    public virtual DbSet<XfRegistrationSpamCache> XfRegistrationSpamCaches { get; set; }

    public virtual DbSet<XfReport> XfReports { get; set; }

    public virtual DbSet<XfReportComment> XfReportComments { get; set; }

    public virtual DbSet<XfRmCategory> XfRmCategories { get; set; }

    public virtual DbSet<XfRmCategoryField> XfRmCategoryFields { get; set; }

    public virtual DbSet<XfRmCategoryPrefix> XfRmCategoryPrefixes { get; set; }

    public virtual DbSet<XfRmCategoryReviewField> XfRmCategoryReviewFields { get; set; }

    public virtual DbSet<XfRmCategoryWatch> XfRmCategoryWatches { get; set; }

    public virtual DbSet<XfRmResource> XfRmResources { get; set; }

    public virtual DbSet<XfRmResourceDownload> XfRmResourceDownloads { get; set; }

    public virtual DbSet<XfRmResourceFeature> XfRmResourceFeatures { get; set; }

    public virtual DbSet<XfRmResourceField> XfRmResourceFields { get; set; }

    public virtual DbSet<XfRmResourceFieldValue> XfRmResourceFieldValues { get; set; }

    public virtual DbSet<XfRmResourcePrefix> XfRmResourcePrefixes { get; set; }

    public virtual DbSet<XfRmResourcePrefixGroup> XfRmResourcePrefixGroups { get; set; }

    public virtual DbSet<XfRmResourceRating> XfRmResourceRatings { get; set; }

    public virtual DbSet<XfRmResourceReviewField> XfRmResourceReviewFields { get; set; }

    public virtual DbSet<XfRmResourceReviewFieldValue> XfRmResourceReviewFieldValues { get; set; }

    public virtual DbSet<XfRmResourceTeamMember> XfRmResourceTeamMembers { get; set; }

    public virtual DbSet<XfRmResourceUpdate> XfRmResourceUpdates { get; set; }

    public virtual DbSet<XfRmResourceVersion> XfRmResourceVersions { get; set; }

    public virtual DbSet<XfRmResourceView> XfRmResourceViews { get; set; }

    public virtual DbSet<XfRmResourceWatch> XfRmResourceWatches { get; set; }

    public virtual DbSet<XfRoute> XfRoutes { get; set; }

    public virtual DbSet<XfRouteFilter> XfRouteFilters { get; set; }

    public virtual DbSet<XfSearch> XfSearches { get; set; }

    public virtual DbSet<XfSearchForum> XfSearchForums { get; set; }

    public virtual DbSet<XfSearchForumCache> XfSearchForumCaches { get; set; }

    public virtual DbSet<XfSearchForumCacheUser> XfSearchForumCacheUsers { get; set; }

    public virtual DbSet<XfSearchIndex> XfSearchIndices { get; set; }

    public virtual DbSet<XfSession> XfSessions { get; set; }

    public virtual DbSet<XfSessionActivity> XfSessionActivities { get; set; }

    public virtual DbSet<XfSessionAdmin> XfSessionAdmins { get; set; }

    public virtual DbSet<XfSessionInstall> XfSessionInstalls { get; set; }

    public virtual DbSet<XfSiropuReferralContestsContest> XfSiropuReferralContestsContests { get; set; }

    public virtual DbSet<XfSiropuReferralContestsInvitation> XfSiropuReferralContestsInvitations { get; set; }

    public virtual DbSet<XfSiropuReferralContestsReferralTool> XfSiropuReferralContestsReferralTools { get; set; }

    public virtual DbSet<XfSiropuReferralContestsReferrerLog> XfSiropuReferralContestsReferrerLogs { get; set; }

    public virtual DbSet<XfSiropuReferralContestsRewardType> XfSiropuReferralContestsRewardTypes { get; set; }

    public virtual DbSet<XfSiropuReferralContestsUnconfirmed> XfSiropuReferralContestsUnconfirmeds { get; set; }

    public virtual DbSet<XfSitemap> XfSitemaps { get; set; }

    public virtual DbSet<XfSmilie> XfSmilies { get; set; }

    public virtual DbSet<XfSmilieCategory> XfSmilieCategories { get; set; }

    public virtual DbSet<XfSpamCleanerLog> XfSpamCleanerLogs { get; set; }

    public virtual DbSet<XfSpamTriggerLog> XfSpamTriggerLogs { get; set; }

    public virtual DbSet<XfStatsDaily> XfStatsDailies { get; set; }

    public virtual DbSet<XfStyle> XfStyles { get; set; }

    public virtual DbSet<XfStyleProperty> XfStyleProperties { get; set; }

    public virtual DbSet<XfStylePropertyGroup> XfStylePropertyGroups { get; set; }

    public virtual DbSet<XfStylePropertyMap> XfStylePropertyMaps { get; set; }

    public virtual DbSet<XfSvDbtechShopItemPrefixLink> XfSvDbtechShopItemPrefixLinks { get; set; }

    public virtual DbSet<XfSvResourcePrefixLink> XfSvResourcePrefixLinks { get; set; }

    public virtual DbSet<XfSvThreadPrefixLink> XfSvThreadPrefixLinks { get; set; }

    public virtual DbSet<XfTag> XfTags { get; set; }

    public virtual DbSet<XfTagContent> XfTagContents { get; set; }

    public virtual DbSet<XfTagResultCache> XfTagResultCaches { get; set; }

    public virtual DbSet<XfTemplate> XfTemplates { get; set; }

    public virtual DbSet<XfTemplateHistory> XfTemplateHistories { get; set; }

    public virtual DbSet<XfTemplateMap> XfTemplateMaps { get; set; }

    public virtual DbSet<XfTemplateModification> XfTemplateModifications { get; set; }

    public virtual DbSet<XfTemplateModificationLog> XfTemplateModificationLogs { get; set; }

    public virtual DbSet<XfTemplatePhrase> XfTemplatePhrases { get; set; }

    public virtual DbSet<XfTfaAttempt> XfTfaAttempts { get; set; }

    public virtual DbSet<XfTfaProvider> XfTfaProviders { get; set; }

    public virtual DbSet<XfThDonateCampaign> XfThDonateCampaigns { get; set; }

    public virtual DbSet<XfThDonateCampaignUser> XfThDonateCampaignUsers { get; set; }

    public virtual DbSet<XfThDonateCampaignWatch> XfThDonateCampaignWatches { get; set; }

    public virtual DbSet<XfThDonateComment> XfThDonateComments { get; set; }

    public virtual DbSet<XfThDonateDonation> XfThDonateDonations { get; set; }

    public virtual DbSet<XfThDonateMilestone> XfThDonateMilestones { get; set; }

    public virtual DbSet<XfThread> XfThreads { get; set; }

    public virtual DbSet<XfThreadField> XfThreadFields { get; set; }

    public virtual DbSet<XfThreadFieldValue> XfThreadFieldValues { get; set; }

    public virtual DbSet<XfThreadPrefix> XfThreadPrefixes { get; set; }

    public virtual DbSet<XfThreadPrefixGroup> XfThreadPrefixGroups { get; set; }

    public virtual DbSet<XfThreadPrompt> XfThreadPrompts { get; set; }

    public virtual DbSet<XfThreadPromptGroup> XfThreadPromptGroups { get; set; }

    public virtual DbSet<XfThreadQuestion> XfThreadQuestions { get; set; }

    public virtual DbSet<XfThreadRead> XfThreadReads { get; set; }

    public virtual DbSet<XfThreadRedirect> XfThreadRedirects { get; set; }

    public virtual DbSet<XfThreadReplyBan> XfThreadReplyBans { get; set; }

    public virtual DbSet<XfThreadType> XfThreadTypes { get; set; }

    public virtual DbSet<XfThreadUserPost> XfThreadUserPosts { get; set; }

    public virtual DbSet<XfThreadView> XfThreadViews { get; set; }

    public virtual DbSet<XfThreadWatch> XfThreadWatches { get; set; }

    public virtual DbSet<XfTrophy> XfTrophies { get; set; }

    public virtual DbSet<XfUnfurlResult> XfUnfurlResults { get; set; }

    public virtual DbSet<XfUpgradeCheck> XfUpgradeChecks { get; set; }

    public virtual DbSet<XfUpgradeJob> XfUpgradeJobs { get; set; }

    public virtual DbSet<XfUpgradeLog> XfUpgradeLogs { get; set; }

    public virtual DbSet<XfUser> XfUsers { get; set; }

    public virtual DbSet<XfUserAlert> XfUserAlerts { get; set; }

    public virtual DbSet<XfUserAlertOptout> XfUserAlertOptouts { get; set; }

    public virtual DbSet<XfUserAuthenticate> XfUserAuthenticates { get; set; }

    public virtual DbSet<XfUserBan> XfUserBans { get; set; }

    public virtual DbSet<XfUserChangeTemp> XfUserChangeTemps { get; set; }

    public virtual DbSet<XfUserConfirmation> XfUserConfirmations { get; set; }

    public virtual DbSet<XfUserConnectedAccount> XfUserConnectedAccounts { get; set; }

    public virtual DbSet<XfUserField> XfUserFields { get; set; }

    public virtual DbSet<XfUserFieldValue> XfUserFieldValues { get; set; }

    public virtual DbSet<XfUserFollow> XfUserFollows { get; set; }

    public virtual DbSet<XfUserGroup> XfUserGroups { get; set; }

    public virtual DbSet<XfUserGroupChange> XfUserGroupChanges { get; set; }

    public virtual DbSet<XfUserGroupPromotion> XfUserGroupPromotions { get; set; }

    public virtual DbSet<XfUserGroupPromotionLog> XfUserGroupPromotionLogs { get; set; }

    public virtual DbSet<XfUserGroupRelation> XfUserGroupRelations { get; set; }

    public virtual DbSet<XfUserIgnored> XfUserIgnoreds { get; set; }

    public virtual DbSet<XfUserOption> XfUserOptions { get; set; }

    public virtual DbSet<XfUserPrivacy> XfUserPrivacies { get; set; }

    public virtual DbSet<XfUserProfile> XfUserProfiles { get; set; }

    public virtual DbSet<XfUserPushOptout> XfUserPushOptouts { get; set; }

    public virtual DbSet<XfUserPushSubscription> XfUserPushSubscriptions { get; set; }

    public virtual DbSet<XfUserReject> XfUserRejects { get; set; }

    public virtual DbSet<XfUserRemember> XfUserRemembers { get; set; }

    public virtual DbSet<XfUserTfa> XfUserTfas { get; set; }

    public virtual DbSet<XfUserTfaTrusted> XfUserTfaTrusteds { get; set; }

    public virtual DbSet<XfUserTitleLadder> XfUserTitleLadders { get; set; }

    public virtual DbSet<XfUserTrophy> XfUserTrophies { get; set; }

    public virtual DbSet<XfUserUpgrade> XfUserUpgrades { get; set; }

    public virtual DbSet<XfUserUpgradeActive> XfUserUpgradeActives { get; set; }

    public virtual DbSet<XfUserUpgradeExpired> XfUserUpgradeExpireds { get; set; }

    public virtual DbSet<XfUsernameChange> XfUsernameChanges { get; set; }

    public virtual DbSet<XfWarning> XfWarnings { get; set; }

    public virtual DbSet<XfWarningAction> XfWarningActions { get; set; }

    public virtual DbSet<XfWarningActionTrigger> XfWarningActionTriggers { get; set; }

    public virtual DbSet<XfWarningDefinition> XfWarningDefinitions { get; set; }

    public virtual DbSet<XfWidget> XfWidgets { get; set; }

    public virtual DbSet<XfWidgetDefinition> XfWidgetDefinitions { get; set; }

    public virtual DbSet<XfWidgetPosition> XfWidgetPositions { get; set; }

    public virtual DbSet<XfaRmmpDigitalProduct> XfaRmmpDigitalProducts { get; set; }

    public virtual DbSet<XfaRmmpDiscount> XfaRmmpDiscounts { get; set; }

    public virtual DbSet<XfaRmmpFeaturingDuration> XfaRmmpFeaturingDurations { get; set; }

    public virtual DbSet<XfaRmmpFeaturingPurchase> XfaRmmpFeaturingPurchases { get; set; }

    public virtual DbSet<XfaRmmpInvoice> XfaRmmpInvoices { get; set; }

    public virtual DbSet<XfaRmmpLicense> XfaRmmpLicenses { get; set; }

    public virtual DbSet<XfaRmmpPhysicalProduct> XfaRmmpPhysicalProducts { get; set; }

    public virtual DbSet<XfaRmmpPurchase> XfaRmmpPurchases { get; set; }

    public virtual DbSet<XfaRmmpPurchaseAddInfo> XfaRmmpPurchaseAddInfos { get; set; }

    public virtual DbSet<XfaRmmpSellerInfo> XfaRmmpSellerInfos { get; set; }

    public virtual DbSet<XfaRmmpTransaction> XfaRmmpTransactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=b29838ev.beget.tech;database=b29838ev_ecubase;user=b29838ev_ecubase;password=8T&DRs2f;connection timeout=1800;default command timeout=1800", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.21-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<AppCarmaker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_carmaker");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu");

            entity.HasIndex(e => e.Carmaker, "app_ecu_fk1");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AdblueCars)
                .HasMaxLength(255)
                .HasColumnName("adblue_cars");
            entity.Property(e => e.AdbluePrice)
                .HasMaxLength(255)
                .HasColumnName("adblue_price");
            entity.Property(e => e.AdblueUse)
                .HasColumnType("int(11)")
                .HasColumnName("adblue_use");
            entity.Property(e => e.Carmaker)
                .HasColumnType("int(11)")
                .HasColumnName("carmaker");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.Cpu1type)
                .HasColumnType("int(11)")
                .HasColumnName("cpu1type");
            entity.Property(e => e.DpfCars)
                .HasMaxLength(255)
                .HasColumnName("dpf_cars");
            entity.Property(e => e.DpfPrice)
                .HasMaxLength(255)
                .HasColumnName("dpf_price");
            entity.Property(e => e.DpfUse)
                .HasColumnType("int(11)")
                .HasColumnName("dpf_use");
            entity.Property(e => e.E2Cars)
                .HasMaxLength(255)
                .HasColumnName("e2_cars");
            entity.Property(e => e.E2Price)
                .HasMaxLength(255)
                .HasColumnName("e2_price");
            entity.Property(e => e.E2Use)
                .HasColumnType("int(11)")
                .HasColumnName("e2_use");
            entity.Property(e => e.EcuCpu1)
                .HasColumnType("int(11)")
                .HasColumnName("ecu_cpu1");
            entity.Property(e => e.EcuProducer)
                .HasColumnType("int(11)")
                .HasColumnName("ecu_producer");
            entity.Property(e => e.EcuType)
                .HasColumnType("int(11)")
                .HasColumnName("ecu_type");
            entity.Property(e => e.Ecumodel)
                .HasColumnType("int(11)")
                .HasColumnName("ecumodel");
            entity.Property(e => e.Eeprom)
                .HasColumnType("int(11)")
                .HasColumnName("eeprom");
            entity.Property(e => e.Eepromsize)
                .HasColumnType("int(11)")
                .HasColumnName("eepromsize");
            entity.Property(e => e.EgrCar)
                .HasMaxLength(255)
                .HasColumnName("egr_car");
            entity.Property(e => e.EgrPrice)
                .HasMaxLength(255)
                .HasColumnName("egr_price");
            entity.Property(e => e.EgrUse)
                .HasColumnType("int(11)")
                .HasColumnName("egr_use");
            entity.Property(e => e.FlapsCars)
                .HasMaxLength(255)
                .HasColumnName("flaps_cars");
            entity.Property(e => e.FlapsPrice)
                .HasMaxLength(255)
                .HasColumnName("flaps_price");
            entity.Property(e => e.FlapsUse)
                .HasColumnType("int(11)")
                .HasColumnName("flaps_use");
            entity.Property(e => e.Flash)
                .HasColumnType("int(11)")
                .HasColumnName("flash");
            entity.Property(e => e.Flashsizecal)
                .HasColumnType("int(11)")
                .HasColumnName("flashsizecal");
            entity.Property(e => e.Flashsizecal2)
                .HasColumnType("int(11)")
                .HasColumnName("flashsizecal2");
            entity.Property(e => e.Flashsizefull)
                .HasColumnType("int(11)")
                .HasColumnName("flashsizefull");
            entity.Property(e => e.Hw1)
                .HasColumnType("int(11)")
                .HasColumnName("hw1");
            entity.Property(e => e.Hw2)
                .HasColumnType("int(11)")
                .HasColumnName("hw2");
            entity.Property(e => e.Hw3)
                .HasColumnType("int(11)")
                .HasColumnName("hw3");
            entity.Property(e => e.ImmoLearnCars)
                .HasMaxLength(255)
                .HasColumnName("immo_learn_cars");
            entity.Property(e => e.ImmoLearnPrice)
                .HasMaxLength(255)
                .HasColumnName("immo_learn_price");
            entity.Property(e => e.ImmoLearnUse)
                .HasMaxLength(255)
                .HasColumnName("immo_learn_use");
            entity.Property(e => e.ImmoVirgCars)
                .HasMaxLength(255)
                .HasColumnName("immo_virg_cars");
            entity.Property(e => e.ImmoVirgPrice)
                .HasMaxLength(255)
                .HasColumnName("immo_virg_price");
            entity.Property(e => e.ImmoVirgUse)
                .HasMaxLength(255)
                .HasColumnName("immo_virg_use");
            entity.Property(e => e.Infolink)
                .HasMaxLength(255)
                .HasColumnName("infolink");
            entity.Property(e => e.LambdaCars)
                .HasMaxLength(255)
                .HasColumnName("lambda_cars");
            entity.Property(e => e.LambdaPrice)
                .HasMaxLength(255)
                .HasColumnName("lambda_price");
            entity.Property(e => e.LambdaUse)
                .HasColumnType("int(11)")
                .HasColumnName("lambda_use");
            entity.Property(e => e.MafCars)
                .HasMaxLength(255)
                .HasColumnName("maf_cars");
            entity.Property(e => e.MafPrice)
                .HasMaxLength(255)
                .HasColumnName("maf_price");
            entity.Property(e => e.MafUse)
                .HasColumnType("int(11)")
                .HasColumnName("maf_use");
            entity.Property(e => e.ReadinessCars)
                .HasMaxLength(255)
                .HasColumnName("readiness_cars");
            entity.Property(e => e.ReadinessPrice)
                .HasMaxLength(255)
                .HasColumnName("readiness_price");
            entity.Property(e => e.ReadinessUse)
                .HasMaxLength(255)
                .HasColumnName("readiness_use");
            entity.Property(e => e.StartstopCars)
                .HasMaxLength(255)
                .HasColumnName("startstop_cars");
            entity.Property(e => e.StartstopPrice)
                .HasMaxLength(255)
                .HasColumnName("startstop_price");
            entity.Property(e => e.StartstopUse)
                .HasColumnType("int(11)")
                .HasColumnName("startstop_use");
            entity.Property(e => e.Sw1)
                .HasColumnType("int(11)")
                .HasColumnName("sw1");
            entity.Property(e => e.Sw2)
                .HasColumnType("int(11)")
                .HasColumnName("sw2");
            entity.Property(e => e.Sw3)
                .HasColumnType("int(11)")
                .HasColumnName("sw3");
            entity.Property(e => e.Swver)
                .HasColumnType("int(11)")
                .HasColumnName("swver");
            entity.Property(e => e.Tprot)
                .HasColumnType("int(11)")
                .HasColumnName("tprot");
            entity.Property(e => e.Tune1Cars)
                .HasMaxLength(255)
                .HasColumnName("tune1_cars");
            entity.Property(e => e.Tune1Price)
                .HasColumnType("int(11)")
                .HasColumnName("tune1_price");
            entity.Property(e => e.Tune1Use)
                .HasColumnType("int(11)")
                .HasColumnName("tune1_use");
            entity.Property(e => e.TvaCars)
                .HasMaxLength(255)
                .HasColumnName("tva_cars");
            entity.Property(e => e.TvaPrice)
                .HasMaxLength(255)
                .HasColumnName("tva_price");
            entity.Property(e => e.TvaUse)
                .HasColumnType("int(11)")
                .HasColumnName("tva_use");
        });

        modelBuilder.Entity<AppEcuAbit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_abit");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuAcdelco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_acdelco");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuBosch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_bosch");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuCpu1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_cpu1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuDelphi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_delphi");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuDenso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_denso");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuHitachi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_hitachi");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuKefico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_kefico");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuKeihin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_keihin");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuLuca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_lucas");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuMagneti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_magneti");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuProducer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_producer");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Table)
                .HasMaxLength(255)
                .HasColumnName("table");
        });

        modelBuilder.Entity<AppEcuSagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_sagem");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuSiemen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_siemens");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuTemic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_temic");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ecutype)
                .HasMaxLength(255)
                .HasColumnName("ecutype");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuTranstron>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_transtron");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ecutype)
                .HasMaxLength(255)
                .HasColumnName("ecutype");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuTrw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_trw");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ecutype)
                .HasMaxLength(255)
                .HasColumnName("ecutype");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_type");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuValeo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_valeo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ecutype)
                .HasMaxLength(255)
                .HasColumnName("ecutype");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuVisteon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_visteon");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ecutype)
                .HasMaxLength(255)
                .HasColumnName("ecutype");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppEcuWeichai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_ecu_weichai");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ecutype)
                .HasMaxLength(255)
                .HasColumnName("ecutype");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<XfActivitySummaryDefinition>(entity =>
        {
            entity.HasKey(e => e.DefinitionId).HasName("PRIMARY");

            entity
                .ToTable("xf_activity_summary_definition")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.DefinitionId)
                .HasMaxLength(50)
                .HasColumnName("definition_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.DefinitionClass)
                .HasMaxLength(100)
                .HasColumnName("definition_class");
        });

        modelBuilder.Entity<XfActivitySummarySection>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PRIMARY");

            entity
                .ToTable("xf_activity_summary_section")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.SectionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("section_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.DefinitionId)
                .HasMaxLength(50)
                .HasColumnName("definition_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Options)
                .HasColumnType("blob")
                .HasColumnName("options");
            entity.Property(e => e.ShowValue)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("show_value");
        });

        modelBuilder.Entity<XfAddon>(entity =>
        {
            entity.HasKey(e => e.AddonId).HasName("PRIMARY");

            entity
                .ToTable("xf_addon")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Title, "title");

            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.IsLegacy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_legacy");
            entity.Property(e => e.IsProcessing)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_processing");
            entity.Property(e => e.JsonHash)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("json_hash");
            entity.Property(e => e.LastPendingAction)
                .HasMaxLength(50)
                .HasColumnName("last_pending_action");
            entity.Property(e => e.Title)
                .HasMaxLength(75)
                .HasColumnName("title");
            entity.Property(e => e.VersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("version_id");
            entity.Property(e => e.VersionString)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("version_string");
        });

        modelBuilder.Entity<XfAddonInstallBatch>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PRIMARY");

            entity
                .ToTable("xf_addon_install_batch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.BatchId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("batch_id");
            entity.Property(e => e.AddonIds)
                .HasColumnType("mediumblob")
                .HasColumnName("addon_ids");
            entity.Property(e => e.CompleteDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("complete_date");
            entity.Property(e => e.Results)
                .HasColumnType("blob")
                .HasColumnName("results");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<XfAdmin>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_admin")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.AdminLanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("admin_language_id");
            entity.Property(e => e.Advanced)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("advanced");
            entity.Property(e => e.ExtraUserGroupIds)
                .HasMaxLength(255)
                .HasColumnName("extra_user_group_ids");
            entity.Property(e => e.IsSuperAdmin)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_super_admin");
            entity.Property(e => e.LastLogin)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_login");
            entity.Property(e => e.PermissionCache)
                .HasColumnType("mediumblob")
                .HasColumnName("permission_cache");
        });

        modelBuilder.Entity<XfAdminLog>(entity =>
        {
            entity.HasKey(e => e.AdminLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_admin_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.RequestDate, "request_date");

            entity.HasIndex(e => new { e.UserId, e.RequestDate }, "user_id_request_date");

            entity.Property(e => e.AdminLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("admin_log_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.RequestData)
                .HasColumnType("mediumblob")
                .HasColumnName("request_data");
            entity.Property(e => e.RequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("request_date");
            entity.Property(e => e.RequestUrl)
                .HasColumnType("text")
                .HasColumnName("request_url");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfAdminNavigation>(entity =>
        {
            entity.HasKey(e => e.NavigationId).HasName("PRIMARY");

            entity
                .ToTable("xf_admin_navigation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ParentNavigationId, e.DisplayOrder }, "parent_navigation_id_display_order");

            entity.Property(e => e.NavigationId)
                .HasMaxLength(50)
                .HasColumnName("navigation_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.AdminPermissionId)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("admin_permission_id");
            entity.Property(e => e.DebugOnly)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("debug_only");
            entity.Property(e => e.DevelopmentOnly)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("development_only");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.HideNoChildren)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("hide_no_children");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("icon");
            entity.Property(e => e.Link)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("link");
            entity.Property(e => e.ParentNavigationId)
                .HasMaxLength(50)
                .HasColumnName("parent_navigation_id");
        });

        modelBuilder.Entity<XfAdminPermission>(entity =>
        {
            entity.HasKey(e => e.AdminPermissionId).HasName("PRIMARY");

            entity
                .ToTable("xf_admin_permission")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.AdminPermissionId)
                .HasMaxLength(25)
                .HasColumnName("admin_permission_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
        });

        modelBuilder.Entity<XfAdminPermissionEntry>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.AdminPermissionId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_admin_permission_entry")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.AdminPermissionId)
                .HasMaxLength(25)
                .HasColumnName("admin_permission_id");
        });

        modelBuilder.Entity<XfAdvertising>(entity =>
        {
            entity.HasKey(e => e.AdId).HasName("PRIMARY");

            entity
                .ToTable("xf_advertising")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.AdId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ad_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AdHtml)
                .HasColumnType("text")
                .HasColumnName("ad_html");
            entity.Property(e => e.DisplayCriteria)
                .HasColumnType("blob")
                .HasColumnName("display_criteria");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.PositionId)
                .HasMaxLength(50)
                .HasColumnName("position_id");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfAdvertisingPosition>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PRIMARY");

            entity
                .ToTable("xf_advertising_position")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PositionId)
                .HasMaxLength(50)
                .HasColumnName("position_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.Arguments)
                .HasColumnType("blob")
                .HasColumnName("arguments");
        });

        modelBuilder.Entity<XfApiAttachmentKey>(entity =>
        {
            entity.HasKey(e => e.AttachmentKey).HasName("PRIMARY");

            entity
                .ToTable("xf_api_attachment_key")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CreateDate, "create_date");

            entity.Property(e => e.AttachmentKey)
                .HasMaxLength(32)
                .HasColumnName("attachment_key");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.Context)
                .HasColumnType("blob")
                .HasColumnName("context");
            entity.Property(e => e.CreateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_date");
            entity.Property(e => e.TempHash)
                .HasMaxLength(32)
                .HasColumnName("temp_hash");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfApiKey>(entity =>
        {
            entity.HasKey(e => e.ApiKeyId).HasName("PRIMARY");

            entity
                .ToTable("xf_api_key")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ApiKeyHash, "api_key_hash").IsUnique();

            entity.Property(e => e.ApiKeyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("api_key_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AllowAllScopes)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_all_scopes");
            entity.Property(e => e.ApiKey)
                .HasMaxLength(32)
                .HasColumnName("api_key");
            entity.Property(e => e.ApiKeyHash)
                .HasMaxLength(20)
                .HasColumnName("api_key_hash");
            entity.Property(e => e.CreationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("creation_date");
            entity.Property(e => e.CreationUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("creation_user_id");
            entity.Property(e => e.IsSuperUser)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_super_user");
            entity.Property(e => e.LastUseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_use_date");
            entity.Property(e => e.Scopes)
                .HasColumnType("mediumblob")
                .HasColumnName("scopes");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfApiKeyScope>(entity =>
        {
            entity.HasKey(e => new { e.ApiKeyId, e.ApiScopeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_api_key_scope")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ApiKeyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("api_key_id");
            entity.Property(e => e.ApiScopeId)
                .HasMaxLength(50)
                .HasColumnName("api_scope_id");
        });

        modelBuilder.Entity<XfApiLoginToken>(entity =>
        {
            entity.HasKey(e => e.LoginTokenId).HasName("PRIMARY");

            entity
                .ToTable("xf_api_login_token")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.HasIndex(e => e.LoginToken, "login_token").IsUnique();

            entity.Property(e => e.LoginTokenId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("login_token_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.LimitIp)
                .HasMaxLength(16)
                .HasColumnName("limit_ip");
            entity.Property(e => e.LoginToken)
                .HasMaxLength(32)
                .HasColumnName("login_token");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfApiScope>(entity =>
        {
            entity.HasKey(e => e.ApiScopeId).HasName("PRIMARY");

            entity
                .ToTable("xf_api_scope")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ApiScopeId)
                .HasMaxLength(50)
                .HasColumnName("api_scope_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
        });

        modelBuilder.Entity<XfApprovalQueue>(entity =>
        {
            entity.HasKey(e => new { e.ContentType, e.ContentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_approval_queue")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ContentDate, "content_date");

            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_date");
        });

        modelBuilder.Entity<XfAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PRIMARY");

            entity
                .ToTable("xf_attachment")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AttachDate, "attach_date");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.AttachDate }, "content_type_id_date");

            entity.HasIndex(e => e.DataId, "data_id");

            entity.HasIndex(e => new { e.TempHash, e.AttachDate }, "temp_hash_attach_date");

            entity.HasIndex(e => new { e.Unassociated, e.AttachDate }, "unassociated_attach_date");

            entity.Property(e => e.AttachmentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attachment_id");
            entity.Property(e => e.AttachDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attach_date");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.DataId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("data_id");
            entity.Property(e => e.TempHash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("temp_hash");
            entity.Property(e => e.Unassociated)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("unassociated");
            entity.Property(e => e.ViewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_count");
            entity.Property(e => e.XfmgIsMirrorHandler)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfmg_is_mirror_handler");
        });

        modelBuilder.Entity<XfAttachmentDatum>(entity =>
        {
            entity.HasKey(e => e.DataId).HasName("PRIMARY");

            entity
                .ToTable("xf_attachment_data")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AttachCount, "attach_count");

            entity.HasIndex(e => e.FileSize, "file_size");

            entity.HasIndex(e => e.UploadDate, "upload_date");

            entity.HasIndex(e => new { e.UserId, e.UploadDate }, "user_id_upload_date");

            entity.Property(e => e.DataId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("data_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.FileHash)
                .HasMaxLength(32)
                .HasColumnName("file_hash");
            entity.Property(e => e.FilePath)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("file_path");
            entity.Property(e => e.FileSize)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("file_size");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasColumnName("filename");
            entity.Property(e => e.Height)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("height");
            entity.Property(e => e.ThumbnailHeight)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thumbnail_height");
            entity.Property(e => e.ThumbnailWidth)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thumbnail_width");
            entity.Property(e => e.UploadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("upload_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Width)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("width");
            entity.Property(e => e.XfaDo)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_do");
            entity.Property(e => e.XfaUrl)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("xfa_url");
            entity.Property(e => e.XfmgMirrorMediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfmg_mirror_media_id");
        });

        modelBuilder.Entity<XfAttachmentView>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PRIMARY");

            entity
                .ToTable("xf_attachment_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.AttachmentId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attachment_id");
            entity.Property(e => e.Total)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total");
        });

        modelBuilder.Entity<XfBanEmail>(entity =>
        {
            entity.HasKey(e => e.BannedEmail).HasName("PRIMARY");

            entity
                .ToTable("xf_ban_email")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CreateDate, "create_date");

            entity.Property(e => e.BannedEmail)
                .HasMaxLength(120)
                .HasColumnName("banned_email");
            entity.Property(e => e.CreateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_user_id");
            entity.Property(e => e.LastTriggeredDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_triggered_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reason");
        });

        modelBuilder.Entity<XfBbCode>(entity =>
        {
            entity.HasKey(e => e.BbCodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_bb_code")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.BbCodeId)
                .HasMaxLength(25)
                .HasColumnName("bb_code_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.AllowEmpty)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_empty");
            entity.Property(e => e.AllowSignature)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_signature");
            entity.Property(e => e.BbCodeMode)
                .HasMaxLength(25)
                .HasColumnName("bb_code_mode");
            entity.Property(e => e.CallbackClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_class");
            entity.Property(e => e.CallbackMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_method");
            entity.Property(e => e.DisableAutolink)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("disable_autolink");
            entity.Property(e => e.DisableNl2br)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("disable_nl2br");
            entity.Property(e => e.DisableSmilies)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("disable_smilies");
            entity.Property(e => e.EditorIconType)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("editor_icon_type");
            entity.Property(e => e.EditorIconValue)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("editor_icon_value");
            entity.Property(e => e.HasOption)
                .HasMaxLength(25)
                .HasColumnName("has_option");
            entity.Property(e => e.OptionRegex)
                .HasColumnType("text")
                .HasColumnName("option_regex");
            entity.Property(e => e.PlainChildren)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("plain_children");
            entity.Property(e => e.ReplaceHtml)
                .HasColumnType("text")
                .HasColumnName("replace_html");
            entity.Property(e => e.ReplaceHtmlEmail)
                .HasColumnType("text")
                .HasColumnName("replace_html_email");
            entity.Property(e => e.ReplaceText)
                .HasColumnType("text")
                .HasColumnName("replace_text");
            entity.Property(e => e.TrimLinesAfter)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("trim_lines_after");
        });

        modelBuilder.Entity<XfBbCodeMediaSite>(entity =>
        {
            entity.HasKey(e => e.MediaSiteId).HasName("PRIMARY");

            entity
                .ToTable("xf_bb_code_media_site")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.MediaSiteId)
                .HasMaxLength(25)
                .HasColumnName("media_site_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.CookieThirdParties)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("cookie_third_parties");
            entity.Property(e => e.EmbedHtmlCallbackClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("embed_html_callback_class");
            entity.Property(e => e.EmbedHtmlCallbackMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("embed_html_callback_method");
            entity.Property(e => e.MatchCallbackClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("match_callback_class");
            entity.Property(e => e.MatchCallbackMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("match_callback_method");
            entity.Property(e => e.MatchIsRegex)
                .HasComment("If 1, match_urls will be treated as regular expressions rather than simple URL matches.")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("match_is_regex");
            entity.Property(e => e.MatchUrls)
                .HasColumnType("text")
                .HasColumnName("match_urls");
            entity.Property(e => e.OembedApiEndpoint)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("oembed_api_endpoint");
            entity.Property(e => e.OembedEnabled)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("oembed_enabled");
            entity.Property(e => e.OembedRetainScripts)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("oembed_retain_scripts");
            entity.Property(e => e.OembedUrlScheme)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("oembed_url_scheme");
            entity.Property(e => e.SiteTitle)
                .HasMaxLength(50)
                .HasColumnName("site_title");
            entity.Property(e => e.SiteUrl)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("site_url");
            entity.Property(e => e.Supported)
                .HasDefaultValueSql("'1'")
                .HasComment("If 0, this media type will not be listed as available, but will still be usable.")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("supported");
        });

        modelBuilder.Entity<XfBookmarkItem>(entity =>
        {
            entity.HasKey(e => e.BookmarkId).HasName("PRIMARY");

            entity
                .ToTable("xf_bookmark_item")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_content_id");

            entity.HasIndex(e => new { e.UserId, e.ContentType, e.ContentId }, "user_id_content_type_content_id").IsUnique();

            entity.Property(e => e.BookmarkId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bookmark_id");
            entity.Property(e => e.BookmarkDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bookmark_date");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.Labels)
                .HasColumnType("mediumblob")
                .HasColumnName("labels");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfBookmarkLabel>(entity =>
        {
            entity.HasKey(e => e.LabelId).HasName("PRIMARY");

            entity
                .ToTable("xf_bookmark_label")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.LabelUrl, e.UserId }, "label_url_user_id").IsUnique();

            entity.HasIndex(e => new { e.Label, e.UserId }, "label_user_id").IsUnique();

            entity.HasIndex(e => e.UseCount, "use_count");

            entity.Property(e => e.LabelId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("label_id");
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .HasColumnName("label");
            entity.Property(e => e.LabelUrl)
                .HasMaxLength(100)
                .HasColumnName("label_url");
            entity.Property(e => e.LastUseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_use_date");
            entity.Property(e => e.UseCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("use_count");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfBookmarkLabelUse>(entity =>
        {
            entity.HasKey(e => new { e.LabelId, e.BookmarkId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_bookmark_label_use")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.LabelId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("label_id");
            entity.Property(e => e.BookmarkId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bookmark_id");
            entity.Property(e => e.UseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("use_date");
        });

        modelBuilder.Entity<XfBriviumStyleRating>(entity =>
        {
            entity.HasKey(e => e.StyleRatingId).HasName("PRIMARY");

            entity
                .ToTable("xf_brivium_style_rating")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => e.StyleDate, "style_date");

            entity.Property(e => e.StyleRatingId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_rating_id");
            entity.Property(e => e.IconHeight)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("icon_height");
            entity.Property(e => e.IconSecondPosition)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("icon_second_position");
            entity.Property(e => e.IconWidth)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("icon_width");
            entity.Property(e => e.ImageHeight)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("image_height");
            entity.Property(e => e.ImageWidth)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("image_width");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("status");
            entity.Property(e => e.StyleDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_date");
        });

        modelBuilder.Entity<XfBriviumThreadRating>(entity =>
        {
            entity.HasKey(e => e.ThreadRatingId).HasName("PRIMARY");

            entity
                .ToTable("xf_brivium_thread_rating")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.RatingDate, "rating_date");

            entity.HasIndex(e => e.ThreadId, "thread_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => e.Username, "username");

            entity.Property(e => e.ThreadRatingId)
                .HasColumnType("int(11)")
                .HasColumnName("thread_rating_id");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.Encode)
                .HasMaxLength(36)
                .HasColumnName("encode");
            entity.Property(e => e.IsAnonymous)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_anonymous");
            entity.Property(e => e.LikeUsers)
                .HasColumnType("blob")
                .HasColumnName("like_users");
            entity.Property(e => e.Likes)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("likes");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.Rating)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rating");
            entity.Property(e => e.RatingDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_date");
            entity.Property(e => e.RatingStatus)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rating_status");
            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfCaptchaLog>(entity =>
        {
            entity.HasKey(e => e.Hash).HasName("PRIMARY");

            entity
                .ToTable("xf_captcha_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CaptchaDate, "captcha_date");

            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasColumnName("hash");
            entity.Property(e => e.CaptchaData)
                .HasMaxLength(250)
                .HasColumnName("captcha_data");
            entity.Property(e => e.CaptchaDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("captcha_date");
            entity.Property(e => e.CaptchaType)
                .HasMaxLength(250)
                .HasColumnName("captcha_type");
        });

        modelBuilder.Entity<XfCaptchaQuestion>(entity =>
        {
            entity.HasKey(e => e.CaptchaQuestionId).HasName("PRIMARY");

            entity
                .ToTable("xf_captcha_question")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Active, "active");

            entity.Property(e => e.CaptchaQuestionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("captcha_question_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.Answers)
                .HasComment("Serialized array of possible correct answers.")
                .HasColumnType("blob")
                .HasColumnName("answers");
            entity.Property(e => e.Question)
                .HasMaxLength(250)
                .HasColumnName("question");
        });

        modelBuilder.Entity<XfCategory>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_category")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
        });

        modelBuilder.Entity<XfChangeLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity
                .ToTable("xf_change_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.EditDate }, "content_type_content_id_date");

            entity.HasIndex(e => new { e.ContentType, e.EditDate }, "content_type_date");

            entity.HasIndex(e => e.EditDate, "edit_date");

            entity.Property(e => e.LogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.EditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_date");
            entity.Property(e => e.EditUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_user_id");
            entity.Property(e => e.Field)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("field");
            entity.Property(e => e.NewValue)
                .HasColumnType("text")
                .HasColumnName("new_value");
            entity.Property(e => e.OldValue)
                .HasColumnType("text")
                .HasColumnName("old_value");
            entity.Property(e => e.Protected)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("protected");
        });

        modelBuilder.Entity<XfClassExtension>(entity =>
        {
            entity.HasKey(e => e.ExtensionId).HasName("PRIMARY");

            entity
                .ToTable("xf_class_extension")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.FromClass, e.ToClass }, "from_class").IsUnique();

            entity.Property(e => e.ExtensionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("extension_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.ExecuteOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("execute_order");
            entity.Property(e => e.FromClass)
                .HasMaxLength(100)
                .HasColumnName("from_class");
            entity.Property(e => e.ToClass)
                .HasMaxLength(100)
                .HasColumnName("to_class");
        });

        modelBuilder.Entity<XfCodeEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity
                .ToTable("xf_code_event")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.EventId)
                .HasMaxLength(50)
                .HasColumnName("event_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
        });

        modelBuilder.Entity<XfCodeEventListener>(entity =>
        {
            entity.HasKey(e => e.EventListenerId).HasName("PRIMARY");

            entity
                .ToTable("xf_code_event_listener")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.AddonId, e.EventId }, "addon_id_event_id");

            entity.HasIndex(e => new { e.EventId, e.ExecuteOrder }, "event_id_execute_order");

            entity.Property(e => e.EventListenerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_listener_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.CallbackClass)
                .HasMaxLength(100)
                .HasColumnName("callback_class");
            entity.Property(e => e.CallbackMethod)
                .HasMaxLength(75)
                .HasColumnName("callback_method");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EventId)
                .HasMaxLength(50)
                .HasColumnName("event_id");
            entity.Property(e => e.ExecuteOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("execute_order");
            entity.Property(e => e.Hint)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hint");
        });

        modelBuilder.Entity<XfConnectedAccountProvider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PRIMARY");

            entity
                .ToTable("xf_connected_account_provider")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Options)
                .HasColumnType("mediumblob")
                .HasColumnName("options");
            entity.Property(e => e.ProviderClass)
                .HasMaxLength(100)
                .HasColumnName("provider_class");
        });

        modelBuilder.Entity<XfContentSpamCache>(entity =>
        {
            entity.HasKey(e => e.SpamCacheId).HasName("PRIMARY");

            entity
                .ToTable("xf_content_spam_cache")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type").IsUnique();

            entity.HasIndex(e => e.InsertDate, "insert_date");

            entity.Property(e => e.SpamCacheId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("spam_cache_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.InsertDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("insert_date");
            entity.Property(e => e.SpamParams)
                .HasColumnType("mediumblob")
                .HasColumnName("spam_params");
        });

        modelBuilder.Entity<XfContentTypeField>(entity =>
        {
            entity.HasKey(e => new { e.ContentType, e.FieldName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_content_type_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldName, "field_name");

            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .HasColumnName("field_name");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.FieldValue)
                .HasMaxLength(75)
                .HasColumnName("field_value");
        });

        modelBuilder.Entity<XfContentVote>(entity =>
        {
            entity.HasKey(e => e.VoteId).HasName("PRIMARY");

            entity
                .ToTable("xf_content_vote")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.VoteUserId }, "content_type_id_user").IsUnique();

            entity.HasIndex(e => e.ContentUserId, "content_user_id");

            entity.HasIndex(e => e.VoteUserId, "vote_user_id");

            entity.Property(e => e.VoteId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_user_id");
            entity.Property(e => e.IsContentUserCounted)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_content_user_counted");
            entity.Property(e => e.Score)
                .HasColumnType("int(11)")
                .HasColumnName("score");
            entity.Property(e => e.VoteDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_date");
            entity.Property(e => e.VoteUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_user_id");
        });

        modelBuilder.Entity<XfConversationMaster>(entity =>
        {
            entity.HasKey(e => e.ConversationId).HasName("PRIMARY");

            entity
                .ToTable("xf_conversation_master")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastMessageUserId, "last_message_user_id");

            entity.HasIndex(e => e.StartDate, "start_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ConversationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("conversation_id");
            entity.Property(e => e.ConversationOpen)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("conversation_open");
            entity.Property(e => e.FirstMessageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_message_id");
            entity.Property(e => e.LastMessageDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_message_date");
            entity.Property(e => e.LastMessageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_message_id");
            entity.Property(e => e.LastMessageUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_message_user_id");
            entity.Property(e => e.LastMessageUsername)
                .HasMaxLength(50)
                .HasColumnName("last_message_username");
            entity.Property(e => e.OpenInvite)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("open_invite");
            entity.Property(e => e.RecipientCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("recipient_count");
            entity.Property(e => e.Recipients)
                .HasColumnType("mediumblob")
                .HasColumnName("recipients");
            entity.Property(e => e.ReplyCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reply_count");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfConversationMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PRIMARY");

            entity
                .ToTable("xf_conversation_message")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ConversationId, e.MessageDate }, "conversation_id_message_date");

            entity.HasIndex(e => e.MessageDate, "message_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.MessageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("message_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.ConversationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("conversation_id");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.MessageDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("message_date");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfConversationRecipient>(entity =>
        {
            entity.HasKey(e => new { e.ConversationId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_conversation_recipient")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ConversationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("conversation_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.LastReadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_read_date");
            entity.Property(e => e.RecipientState)
                .HasColumnType("enum('active','deleted','deleted_ignored')")
                .HasColumnName("recipient_state");
        });

        modelBuilder.Entity<XfConversationUser>(entity =>
        {
            entity.HasKey(e => new { e.ConversationId, e.OwnerUserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_conversation_user")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastMessageUserId, "last_message_user_id");

            entity.HasIndex(e => new { e.OwnerUserId, e.IsStarred, e.LastMessageDate }, "owner_starred_date");

            entity.HasIndex(e => new { e.OwnerUserId, e.IsUnread }, "owner_user_id_is_unread");

            entity.HasIndex(e => new { e.OwnerUserId, e.LastMessageDate }, "owner_user_id_last_message_date");

            entity.Property(e => e.ConversationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("conversation_id");
            entity.Property(e => e.OwnerUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("owner_user_id");
            entity.Property(e => e.IsStarred)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_starred");
            entity.Property(e => e.IsUnread)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_unread");
            entity.Property(e => e.LastMessageDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_message_date");
            entity.Property(e => e.LastMessageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_message_id");
            entity.Property(e => e.LastMessageUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_message_user_id");
            entity.Property(e => e.LastMessageUsername)
                .HasMaxLength(50)
                .HasColumnName("last_message_username");
            entity.Property(e => e.ReplyCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reply_count");
        });

        modelBuilder.Entity<XfCookieConsentLog>(entity =>
        {
            entity.HasKey(e => e.CookieConsentLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_cookie_consent_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.IpAddress, e.LogDate }, "ip_address_log_date");

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.HasIndex(e => new { e.UserId, e.LogDate }, "user_id_log_date");

            entity.Property(e => e.CookieConsentLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cookie_consent_log_id");
            entity.Property(e => e.ConsentedGroups)
                .HasColumnType("blob")
                .HasColumnName("consented_groups");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfCronEntry>(entity =>
        {
            entity.HasKey(e => e.EntryId).HasName("PRIMARY");

            entity
                .ToTable("xf_cron_entry")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Active, e.NextRun }, "active_next_run");

            entity.Property(e => e.EntryId)
                .HasMaxLength(25)
                .HasColumnName("entry_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.CronClass)
                .HasMaxLength(100)
                .HasColumnName("cron_class");
            entity.Property(e => e.CronMethod)
                .HasMaxLength(75)
                .HasColumnName("cron_method");
            entity.Property(e => e.NextRun)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("next_run");
            entity.Property(e => e.RunRules)
                .HasColumnType("mediumblob")
                .HasColumnName("run_rules");
        });

        modelBuilder.Entity<XfCssCache>(entity =>
        {
            entity.HasKey(e => e.CacheId).HasName("PRIMARY");

            entity
                .ToTable("xf_css_cache")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.StyleId, e.LanguageId, e.Title, e.ModifierKey }, "style_language_title_modifier").IsUnique();

            entity.Property(e => e.CacheId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_id");
            entity.Property(e => e.CacheDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_date");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.ModifierKey)
                .HasMaxLength(32)
                .HasColumnName("modifier_key");
            entity.Property(e => e.Output)
                .HasColumnType("mediumblob")
                .HasColumnName("output");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfDataRegistry>(entity =>
        {
            entity.HasKey(e => e.DataKey).HasName("PRIMARY");

            entity
                .ToTable("xf_data_registry")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.DataKey)
                .HasMaxLength(25)
                .HasColumnName("data_key");
            entity.Property(e => e.DataValue)
                .HasColumnType("mediumblob")
                .HasColumnName("data_value");
        });

        modelBuilder.Entity<XfDbtechCreditsAdjustLog>(entity =>
        {
            entity.HasKey(e => e.AdjustLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_adjust_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.AdjustDate, e.UserId }, "adjust_date");

            entity.HasIndex(e => e.AdjustUserId, "adjust_user_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.AdjustLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("adjust_log_id");
            entity.Property(e => e.AdjustDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("adjust_date");
            entity.Property(e => e.AdjustUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("adjust_user_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDbtechCreditsCharge>(entity =>
        {
            entity.HasKey(e => new { e.ContentType, e.ContentId, e.ContentHash })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("xf_dbtech_credits_charge")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentHash)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("content_hash");
            entity.Property(e => e.Cost).HasColumnName("cost");
        });

        modelBuilder.Entity<XfDbtechCreditsChargePurchase>(entity =>
        {
            entity.HasKey(e => new { e.ContentType, e.ContentId, e.ContentHash, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity
                .ToTable("xf_dbtech_credits_charge_purchase")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentHash)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("content_hash");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDbtechCreditsCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_currency")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Active, "active");

            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.Blacklist)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("blacklist");
            entity.Property(e => e.Column)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("column");
            entity.Property(e => e.Decimals)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("decimals");
            entity.Property(e => e.Description)
                .HasColumnType("blob")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Earnmax)
                .HasColumnType("double unsigned")
                .HasColumnName("earnmax");
            entity.Property(e => e.Inbound)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("inbound");
            entity.Property(e => e.IsDisplayCurrency)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_display_currency");
            entity.Property(e => e.Maxtime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("maxtime");
            entity.Property(e => e.MemberDropdown)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("member_dropdown");
            entity.Property(e => e.Negative)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("negative");
            entity.Property(e => e.Outbound)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("outbound");
            entity.Property(e => e.Postbit)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("postbit");
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("prefix");
            entity.Property(e => e.Privacy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("privacy");
            entity.Property(e => e.ShowAmounts)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("show_amounts");
            entity.Property(e => e.Sidebar)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("sidebar");
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("suffix");
            entity.Property(e => e.Table)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("table");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.UseTablePrefix)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("use_table_prefix");
            entity.Property(e => e.UseUserId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("use_user_id");
            entity.Property(e => e.UserIdColumn)
                .HasMaxLength(255)
                .HasDefaultValueSql("'user_id'")
                .HasColumnName("user_id_column");
            entity.Property(e => e.Value)
                .HasDefaultValueSql("'1'")
                .HasColumnName("value");
        });

        modelBuilder.Entity<XfDbtechCreditsDonationLog>(entity =>
        {
            entity.HasKey(e => e.DonationLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_donation_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DonationDate, e.UserId }, "donation_date");

            entity.HasIndex(e => e.DonationUserId, "donation_user_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.DonationLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("donation_log_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.DonationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("donation_date");
            entity.Property(e => e.DonationUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("donation_user_id");
            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDbtechCreditsEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_event")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Active, e.Display }, "transaction_display");

            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.Alert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("alert");
            entity.Property(e => e.Applymax)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("applymax");
            entity.Property(e => e.ApplymaxPeruser)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("applymax_peruser");
            entity.Property(e => e.Charge)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("charge");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.Curtarget)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("curtarget");
            entity.Property(e => e.Delay)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("delay");
            entity.Property(e => e.Display)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("display");
            entity.Property(e => e.EventTriggerId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("event_trigger_id");
            entity.Property(e => e.Frequency)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("frequency");
            entity.Property(e => e.MainAdd).HasColumnName("main_add");
            entity.Property(e => e.MainSub).HasColumnName("main_sub");
            entity.Property(e => e.Maxtime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("maxtime");
            entity.Property(e => e.Minaction)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("minaction");
            entity.Property(e => e.Moderate)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("moderate");
            entity.Property(e => e.MultAdd).HasColumnName("mult_add");
            entity.Property(e => e.MultSub).HasColumnName("mult_sub");
            entity.Property(e => e.Multmax).HasColumnName("multmax");
            entity.Property(e => e.Multmin).HasColumnName("multmin");
            entity.Property(e => e.NodeIds)
                .HasColumnType("blob")
                .HasColumnName("node_ids");
            entity.Property(e => e.Owner)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("owner");
            entity.Property(e => e.Settings)
                .HasColumnType("mediumblob")
                .HasColumnName("settings");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Upperrand).HasColumnName("upperrand");
            entity.Property(e => e.UserGroupIds)
                .HasColumnType("blob")
                .HasColumnName("user_group_ids");
        });

        modelBuilder.Entity<XfDbtechCreditsEventTrigger>(entity =>
        {
            entity.HasKey(e => e.EventTriggerId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_event_trigger")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.EventTriggerId)
                .HasMaxLength(100)
                .HasColumnName("event_trigger_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.CallbackClass)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_class");
            entity.Property(e => e.Cancel)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("cancel");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("category");
            entity.Property(e => e.Charge)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("charge");
            entity.Property(e => e.Currency)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("currency");
            entity.Property(e => e.Description)
                .HasColumnType("blob")
                .HasColumnName("description");
            entity.Property(e => e.Global)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("global");
            entity.Property(e => e.Inbound)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("inbound");
            entity.Property(e => e.Multiplier)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("multiplier");
            entity.Property(e => e.MultiplierLabel)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("multiplier_label");
            entity.Property(e => e.MultiplierPopup)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("multiplier_popup");
            entity.Property(e => e.Outbound)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("outbound");
            entity.Property(e => e.Parent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("parent");
            entity.Property(e => e.Rebuild)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rebuild");
            entity.Property(e => e.Referformat)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("referformat");
            entity.Property(e => e.Revert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("revert");
            entity.Property(e => e.Settings)
                .HasColumnType("mediumblob")
                .HasColumnName("settings");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Usergroups)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("usergroups");
            entity.Property(e => e.Value)
                .HasDefaultValueSql("'1'")
                .HasColumnName("value");
        });

        modelBuilder.Entity<XfDbtechCreditsPurchaseTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_purchase_transaction")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FromUserId, "from_user_id");

            entity.HasIndex(e => new { e.TransactionDate, e.UserId }, "transaction_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.TransactionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transaction_id");
            entity.Property(e => e.Amount)
                .HasColumnType("double(10,2) unsigned")
                .HasColumnName("amount");
            entity.Property(e => e.Cost)
                .HasColumnType("double(10,2) unsigned")
                .HasColumnName("cost");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("currency_id");
            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.FromUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("from_user_id");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transaction_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDbtechCreditsRedeemLog>(entity =>
        {
            entity.HasKey(e => e.RedeemLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_redeem_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.RedeemDate, e.UserId }, "redeem_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.RedeemLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("redeem_log_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.RedeemCode)
                .HasMaxLength(255)
                .HasColumnName("redeem_code");
            entity.Property(e => e.RedeemDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("redeem_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDbtechCreditsTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_transaction")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Dateline, e.UserId, e.TransactionState }, "dateline");

            entity.HasIndex(e => new { e.Dateline, e.TransactionId }, "transaction_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => new { e.UserId, e.EventId, e.TransactionState, e.Negate, e.Dateline }, "user_id_stats");

            entity.Property(e => e.TransactionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("transaction_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.Dateline)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dateline");
            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.EventTriggerId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("event_trigger_id");
            entity.Property(e => e.IsDisputed)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_disputed");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.Multiplier).HasColumnName("multiplier");
            entity.Property(e => e.Negate)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("negate");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.OwnerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("owner_id");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(255)
                .HasColumnName("reference_id");
            entity.Property(e => e.SourceUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("source_user_id");
            entity.Property(e => e.TransactionState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','skipped','skipped_maximum')")
                .HasColumnName("transaction_state");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDbtechCreditsTransferLog>(entity =>
        {
            entity.HasKey(e => e.TransferLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_dbtech_credits_transfer_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.TransferDate, e.UserId }, "transfer_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.TransferLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transfer_log_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("currency_id");
            entity.Property(e => e.EventId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_id");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.TransferDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transfer_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfDeletionLog>(entity =>
        {
            entity.HasKey(e => new { e.ContentType, e.ContentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_deletion_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DeleteUserId, e.DeleteDate }, "delete_user_id_date");

            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("delete_date");
            entity.Property(e => e.DeleteReason)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("delete_reason");
            entity.Property(e => e.DeleteUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("delete_user_id");
            entity.Property(e => e.DeleteUsername)
                .HasMaxLength(50)
                .HasColumnName("delete_username");
        });

        modelBuilder.Entity<XfDraft>(entity =>
        {
            entity.HasKey(e => e.DraftId).HasName("PRIMARY");

            entity
                .ToTable("xf_draft")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DraftKey, e.UserId }, "draft_key_user").IsUnique();

            entity.HasIndex(e => e.LastUpdate, "last_update");

            entity.Property(e => e.DraftId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("draft_id");
            entity.Property(e => e.DraftKey)
                .HasMaxLength(75)
                .HasColumnName("draft_key");
            entity.Property(e => e.ExtraData)
                .HasColumnType("mediumblob")
                .HasColumnName("extra_data");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_update");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfEditHistory>(entity =>
        {
            entity.HasKey(e => e.EditHistoryId).HasName("PRIMARY");

            entity
                .ToTable("xf_edit_history")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.EditDate }, "content_type");

            entity.HasIndex(e => e.EditDate, "edit_date");

            entity.HasIndex(e => e.EditUserId, "edit_user_id");

            entity.Property(e => e.EditHistoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_history_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.EditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_date");
            entity.Property(e => e.EditUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_user_id");
            entity.Property(e => e.OldText)
                .HasColumnType("mediumtext")
                .HasColumnName("old_text");
        });

        modelBuilder.Entity<XfEditorDropdown>(entity =>
        {
            entity.HasKey(e => e.Cmd).HasName("PRIMARY");

            entity
                .ToTable("xf_editor_dropdown")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Cmd)
                .HasMaxLength(50)
                .HasColumnName("cmd");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.Buttons)
                .HasColumnType("blob")
                .HasColumnName("buttons");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasComment("Optional icon")
                .HasColumnName("icon");
        });

        modelBuilder.Entity<XfEmailBounceLog>(entity =>
        {
            entity.HasKey(e => e.BounceId).HasName("PRIMARY");

            entity
                .ToTable("xf_email_bounce_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.Property(e => e.BounceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bounce_id");
            entity.Property(e => e.ActionTaken)
                .HasMaxLength(25)
                .HasColumnName("action_taken");
            entity.Property(e => e.DiagnosticInfo)
                .HasColumnType("text")
                .HasColumnName("diagnostic_info");
            entity.Property(e => e.EmailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("email_date");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.MessageType)
                .HasMaxLength(25)
                .HasColumnName("message_type");
            entity.Property(e => e.RawMessage)
                .HasColumnType("mediumblob")
                .HasColumnName("raw_message");
            entity.Property(e => e.Recipient)
                .HasMaxLength(255)
                .HasColumnName("recipient");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(25)
                .HasColumnName("status_code");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfEmailBounceSoft>(entity =>
        {
            entity.HasKey(e => e.BounceSoftId).HasName("PRIMARY");

            entity
                .ToTable("xf_email_bounce_soft")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.BounceDate, "bounce_date");

            entity.HasIndex(e => new { e.UserId, e.BounceDate }, "user_id").IsUnique();

            entity.Property(e => e.BounceSoftId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bounce_soft_id");
            entity.Property(e => e.BounceDate).HasColumnName("bounce_date");
            entity.Property(e => e.BounceTotal)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("bounce_total");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorId).HasName("PRIMARY");

            entity
                .ToTable("xf_error_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExceptionDate, "exception_date");

            entity.Property(e => e.ErrorId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("error_id");
            entity.Property(e => e.ExceptionDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("exception_date");
            entity.Property(e => e.ExceptionType)
                .HasMaxLength(75)
                .HasColumnName("exception_type");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.Line)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("line");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.RequestState)
                .HasColumnType("mediumblob")
                .HasColumnName("request_state");
            entity.Property(e => e.TraceString)
                .HasColumnType("mediumtext")
                .HasColumnName("trace_string");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfFeed>(entity =>
        {
            entity.HasKey(e => e.FeedId).HasName("PRIMARY");

            entity
                .ToTable("xf_feed")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Active, "active");

            entity.Property(e => e.FeedId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("feed_id");
            entity.Property(e => e.Active)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.DiscussionOpen)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("discussion_open");
            entity.Property(e => e.DiscussionSticky)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("discussion_sticky");
            entity.Property(e => e.DiscussionVisible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("discussion_visible");
            entity.Property(e => e.Frequency)
                .HasDefaultValueSql("'1800'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("frequency");
            entity.Property(e => e.LastFetch)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_fetch");
            entity.Property(e => e.MessageTemplate)
                .HasColumnType("mediumtext")
                .HasColumnName("message_template");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
            entity.Property(e => e.SvPrefixIds)
                .HasColumnType("mediumblob")
                .HasColumnName("sv_prefix_ids");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.TitleTemplate)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("title_template");
            entity.Property(e => e.Url)
                .HasMaxLength(2083)
                .HasColumnName("url");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfFeedLog>(entity =>
        {
            entity.HasKey(e => new { e.FeedId, e.UniqueId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_feed_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.FeedId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("feed_id");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(250)
                .HasColumnName("unique_id");
            entity.Property(e => e.Hash)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasComment("MD5(title + content)")
                .HasColumnName("hash");
            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
        });

        modelBuilder.Entity<XfFileCheck>(entity =>
        {
            entity.HasKey(e => e.CheckId).HasName("PRIMARY");

            entity
                .ToTable("xf_file_check")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.CheckId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("check_id");
            entity.Property(e => e.CheckDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("check_date");
            entity.Property(e => e.CheckHash)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("check_hash");
            entity.Property(e => e.CheckState)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','success','failure')")
                .HasColumnName("check_state");
            entity.Property(e => e.TotalChecked)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total_checked");
            entity.Property(e => e.TotalInconsistent)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total_inconsistent");
            entity.Property(e => e.TotalMissing)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total_missing");
        });

        modelBuilder.Entity<XfFindNew>(entity =>
        {
            entity.HasKey(e => e.FindNewId).HasName("PRIMARY");

            entity
                .ToTable("xf_find_new")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CacheDate, "cache_date");

            entity.HasIndex(e => new { e.ContentType, e.UserId, e.CacheDate }, "type_user_date");

            entity.Property(e => e.FindNewId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("find_new_id");
            entity.Property(e => e.CacheDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_date");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.FilterHash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter_hash");
            entity.Property(e => e.Filters)
                .HasColumnType("mediumblob")
                .HasColumnName("filters");
            entity.Property(e => e.Results)
                .HasColumnType("mediumblob")
                .HasColumnName("results");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfFindNewDefault>(entity =>
        {
            entity.HasKey(e => e.FindNewDefaultId).HasName("PRIMARY");

            entity
                .ToTable("xf_find_new_default")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserId, e.ContentType }, "user_content").IsUnique();

            entity.Property(e => e.FindNewDefaultId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("find_new_default_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.Filters)
                .HasColumnType("blob")
                .HasColumnName("filters");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfFloodCheck>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FloodAction })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_flood_check")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FloodTime, "flood_time");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.FloodAction)
                .HasMaxLength(25)
                .HasColumnName("flood_action");
            entity.Property(e => e.FloodTime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("flood_time");
        });

        modelBuilder.Entity<XfForum>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_forum")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.AllowIndex)
                .HasDefaultValueSql("'allow'")
                .HasColumnType("enum('allow','deny','criteria')")
                .HasColumnName("allow_index");
            entity.Property(e => e.AllowPosting)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_posting");
            entity.Property(e => e.AllowedWatchNotifications)
                .HasMaxLength(10)
                .HasDefaultValueSql("'all'")
                .HasColumnName("allowed_watch_notifications");
            entity.Property(e => e.CountMessages)
                .HasDefaultValueSql("'1'")
                .HasComment("If not set, messages posted (directly) within this forum will not contribute to user message totals.")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("count_messages");
            entity.Property(e => e.DefaultPrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("default_prefix_id");
            entity.Property(e => e.DefaultSortDirection)
                .HasMaxLength(5)
                .HasDefaultValueSql("'desc'")
                .HasColumnName("default_sort_direction");
            entity.Property(e => e.DefaultSortOrder)
                .HasMaxLength(25)
                .HasDefaultValueSql("'last_post_date'")
                .HasColumnName("default_sort_order");
            entity.Property(e => e.DiscussionCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("discussion_count");
            entity.Property(e => e.FieldCache)
                .HasComment("Serialized data from xf_thread_field")
                .HasColumnType("mediumblob")
                .HasColumnName("field_cache");
            entity.Property(e => e.FindNew)
                .HasDefaultValueSql("'1'")
                .HasComment("Include posts from this forum when running /find-new/threads")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("find_new");
            entity.Property(e => e.ForumTypeId)
                .HasMaxLength(50)
                .HasDefaultValueSql("'discussion'")
                .HasColumnName("forum_type_id");
            entity.Property(e => e.IndexCriteria)
                .HasColumnType("blob")
                .HasColumnName("index_criteria");
            entity.Property(e => e.LastPostDate)
                .HasComment("Date of most recent post")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_date");
            entity.Property(e => e.LastPostId)
                .HasComment("Most recent post_id")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_id");
            entity.Property(e => e.LastPostUserId)
                .HasComment("User_id of user posting most recently")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_user_id");
            entity.Property(e => e.LastPostUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasComment("Username of most recently-posting user")
                .HasColumnName("last_post_username");
            entity.Property(e => e.LastThreadId)
                .HasComment("Most recent thread_id")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_thread_id");
            entity.Property(e => e.LastThreadPrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_thread_prefix_id");
            entity.Property(e => e.LastThreadTitle)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasComment("Title of thread most recent post is in")
                .HasColumnName("last_thread_title");
            entity.Property(e => e.ListDateLimitDays)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("list_date_limit_days");
            entity.Property(e => e.MessageCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("message_count");
            entity.Property(e => e.MinTags)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_tags");
            entity.Property(e => e.ModerateReplies)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("moderate_replies");
            entity.Property(e => e.ModerateThreads)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("moderate_threads");
            entity.Property(e => e.PrefixCache)
                .HasComment("Serialized data from xf_forum_prefix, [group_id][prefix_id] => prefix_id")
                .HasColumnType("mediumblob")
                .HasColumnName("prefix_cache");
            entity.Property(e => e.PromptCache)
                .HasComment("JSON data from xf_forum_prompt")
                .HasColumnType("mediumblob")
                .HasColumnName("prompt_cache");
            entity.Property(e => e.RequirePrefix)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("require_prefix");
            entity.Property(e => e.SvDefaultPrefixIds)
                .HasColumnType("mediumblob")
                .HasColumnName("sv_default_prefix_ids");
            entity.Property(e => e.SvMaxPrefixes)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sv_max_prefixes");
            entity.Property(e => e.SvMinPrefixes)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sv_min_prefixes");
            entity.Property(e => e.TypeConfig)
                .HasColumnType("mediumblob")
                .HasColumnName("type_config");
            entity.Property(e => e.XfmgMediaMirrorCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfmg_media_mirror_category_id");
        });

        modelBuilder.Entity<XfForumField>(entity =>
        {
            entity.HasKey(e => new { e.NodeId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_forum_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldId, "field_id");

            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
        });

        modelBuilder.Entity<XfForumPrefix>(entity =>
        {
            entity.HasKey(e => new { e.NodeId, e.PrefixId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_forum_prefix")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PrefixId, "prefix_id");

            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
        });

        modelBuilder.Entity<XfForumPrompt>(entity =>
        {
            entity.HasKey(e => new { e.NodeId, e.PromptId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_forum_prompt")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.PromptId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prompt_id");
        });

        modelBuilder.Entity<XfForumRead>(entity =>
        {
            entity.HasKey(e => e.ForumReadId).HasName("PRIMARY");

            entity
                .ToTable("xf_forum_read")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ForumReadDate, "forum_read_date");

            entity.HasIndex(e => e.NodeId, "node_id");

            entity.HasIndex(e => new { e.UserId, e.NodeId }, "user_id_node_id").IsUnique();

            entity.Property(e => e.ForumReadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("forum_read_id");
            entity.Property(e => e.ForumReadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("forum_read_date");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfForumType>(entity =>
        {
            entity.HasKey(e => e.ForumTypeId).HasName("PRIMARY");

            entity
                .ToTable("xf_forum_type")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ForumTypeId)
                .HasMaxLength(50)
                .HasColumnName("forum_type_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.HandlerClass)
                .HasMaxLength(100)
                .HasColumnName("handler_class");
        });

        modelBuilder.Entity<XfForumWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.NodeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_forum_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.NodeId, e.NotifyOn }, "node_id_notify_on");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.NotifyOn)
                .HasColumnType("enum('','thread','message')")
                .HasColumnName("notify_on");
            entity.Property(e => e.SendAlert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_alert");
            entity.Property(e => e.SendEmail)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_email");
        });

        modelBuilder.Entity<XfHelpPage>(entity =>
        {
            entity.HasKey(e => e.PageId).HasName("PRIMARY");

            entity
                .ToTable("xf_help_page")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.HasIndex(e => e.PageName, "page_name").IsUnique();

            entity.Property(e => e.PageId)
                .HasMaxLength(50)
                .HasColumnName("page_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.AdvancedMode)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("advanced_mode");
            entity.Property(e => e.CallbackClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_class");
            entity.Property(e => e.CallbackMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_method");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .HasColumnName("page_name");
        });

        modelBuilder.Entity<XfImageProxy>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PRIMARY");

            entity
                .ToTable("xf_image_proxy")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IsProcessing, "is_processing");

            entity.HasIndex(e => e.LastRequestDate, "last_request_date");

            entity.HasIndex(e => new { e.Pruned, e.FetchDate }, "pruned_fetch_date");

            entity.HasIndex(e => e.UrlHash, "url_hash").IsUnique();

            entity.Property(e => e.ImageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("image_id");
            entity.Property(e => e.FailCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fail_count");
            entity.Property(e => e.FailedDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("failed_date");
            entity.Property(e => e.FetchDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fetch_date");
            entity.Property(e => e.FileHash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("file_hash");
            entity.Property(e => e.FileName)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("file_name");
            entity.Property(e => e.FileSize)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("file_size");
            entity.Property(e => e.FirstRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_request_date");
            entity.Property(e => e.IsProcessing)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("is_processing");
            entity.Property(e => e.LastRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_request_date");
            entity.Property(e => e.MimeType)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("mime_type");
            entity.Property(e => e.Pruned)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("pruned");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.UrlHash)
                .HasMaxLength(32)
                .HasColumnName("url_hash");
            entity.Property(e => e.Views)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("views");
        });

        modelBuilder.Entity<XfImageProxyReferrer>(entity =>
        {
            entity.HasKey(e => e.ReferrerId).HasName("PRIMARY");

            entity
                .ToTable("xf_image_proxy_referrer")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ImageId, e.ReferrerHash }, "image_id_hash").IsUnique();

            entity.HasIndex(e => e.LastDate, "last_date");

            entity.Property(e => e.ReferrerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("referrer_id");
            entity.Property(e => e.FirstDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_date");
            entity.Property(e => e.Hits)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("hits");
            entity.Property(e => e.ImageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("image_id");
            entity.Property(e => e.LastDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_date");
            entity.Property(e => e.ReferrerHash)
                .HasMaxLength(32)
                .HasColumnName("referrer_hash");
            entity.Property(e => e.ReferrerUrl)
                .HasColumnType("text")
                .HasColumnName("referrer_url");
        });

        modelBuilder.Entity<XfIp>(entity =>
        {
            entity.HasKey(e => e.IpId).HasName("PRIMARY");

            entity
                .ToTable("xf_ip")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_content_id");

            entity.HasIndex(e => new { e.Ip, e.LogDate }, "ip_log_date");

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.HasIndex(e => new { e.UserId, e.Ip, e.LogDate }, "user_id_ip_log_date");

            entity.HasIndex(e => new { e.UserId, e.LogDate }, "user_id_log_date");

            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .HasColumnName("ip");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfIpMatch>(entity =>
        {
            entity.HasKey(e => new { e.Ip, e.MatchType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_ip_match")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CreateDate, "create_date");

            entity.HasIndex(e => e.StartRange, "start_range");

            entity.Property(e => e.Ip)
                .HasMaxLength(43)
                .HasColumnName("ip");
            entity.Property(e => e.MatchType)
                .HasDefaultValueSql("'banned'")
                .HasColumnType("enum('banned','discouraged')")
                .HasColumnName("match_type");
            entity.Property(e => e.CreateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_user_id");
            entity.Property(e => e.EndRange)
                .HasMaxLength(16)
                .HasColumnName("end_range");
            entity.Property(e => e.FirstByte)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("first_byte");
            entity.Property(e => e.LastTriggeredDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_triggered_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reason");
            entity.Property(e => e.StartRange)
                .HasMaxLength(16)
                .HasColumnName("start_range");
        });

        modelBuilder.Entity<XfJob>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PRIMARY");

            entity
                .ToTable("xf_job")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ManualExecute, e.TriggerDate }, "manual_execute_date");

            entity.HasIndex(e => e.TriggerDate, "trigger_date");

            entity.HasIndex(e => e.UniqueKey, "unique_key").IsUnique();

            entity.Property(e => e.JobId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("job_id");
            entity.Property(e => e.ExecuteClass)
                .HasMaxLength(100)
                .HasColumnName("execute_class");
            entity.Property(e => e.ExecuteData)
                .HasColumnType("mediumblob")
                .HasColumnName("execute_data");
            entity.Property(e => e.LastRunDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_run_date");
            entity.Property(e => e.ManualExecute)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("manual_execute");
            entity.Property(e => e.TriggerDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trigger_date");
            entity.Property(e => e.UniqueKey)
                .HasMaxLength(50)
                .HasColumnName("unique_key");
        });

        modelBuilder.Entity<XfJsonConvertError>(entity =>
        {
            entity.HasKey(e => e.ErrorId).HasName("PRIMARY");

            entity
                .ToTable("xf_json_convert_error")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.TableName, e.ColumnName, e.PkId }, "table_column_pk").IsUnique();

            entity.Property(e => e.ErrorId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("error_id");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(100)
                .HasColumnName("column_name");
            entity.Property(e => e.OriginalValue)
                .HasColumnType("mediumblob")
                .HasColumnName("original_value");
            entity.Property(e => e.PkId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("pk_id");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .HasColumnName("table_name");
        });

        modelBuilder.Entity<XfKnownbotsAgent>(entity =>
        {
            entity.HasKey(e => e.UserAgent).HasName("PRIMARY");

            entity
                .ToTable("xf_knownbots_agent")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastUpdated, "last_updated");

            entity.Property(e => e.UserAgent)
                .HasMaxLength(512)
                .HasColumnName("user_agent");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_updated");
            entity.Property(e => e.RobotKey)
                .HasMaxLength(25)
                .HasColumnName("robot_key");
            entity.Property(e => e.Sent)
                .HasColumnType("tinyint(4)")
                .HasColumnName("sent");
        });

        modelBuilder.Entity<XfLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PRIMARY");

            entity
                .ToTable("xf_language")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.LanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.CommaSeparator)
                .HasMaxLength(15)
                .HasDefaultValueSql("', '")
                .HasColumnName("comma_separator");
            entity.Property(e => e.CurrencyFormat)
                .HasMaxLength(30)
                .HasColumnName("currency_format");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(30)
                .HasColumnName("date_format");
            entity.Property(e => e.DecimalPoint)
                .HasMaxLength(1)
                .HasColumnName("decimal_point");
            entity.Property(e => e.Ellipsis)
                .HasMaxLength(15)
                .HasDefaultValueSql("'...'")
                .HasColumnName("ellipsis");
            entity.Property(e => e.LabelSeparator)
                .HasMaxLength(15)
                .HasDefaultValueSql("':'")
                .HasColumnName("label_separator");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("language_code");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentList)
                .HasMaxLength(100)
                .HasColumnName("parent_list");
            entity.Property(e => e.ParenthesisClose)
                .HasMaxLength(15)
                .HasDefaultValueSql("')'")
                .HasColumnName("parenthesis_close");
            entity.Property(e => e.ParenthesisOpen)
                .HasMaxLength(15)
                .HasDefaultValueSql("'('")
                .HasColumnName("parenthesis_open");
            entity.Property(e => e.PhraseCache)
                .HasColumnType("mediumblob")
                .HasColumnName("phrase_cache");
            entity.Property(e => e.TextDirection)
                .HasDefaultValueSql("'LTR'")
                .HasColumnType("enum('LTR','RTL')")
                .HasColumnName("text_direction");
            entity.Property(e => e.ThousandsSeparator)
                .HasMaxLength(1)
                .HasColumnName("thousands_separator");
            entity.Property(e => e.TimeFormat)
                .HasMaxLength(15)
                .HasColumnName("time_format");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.UserSelectable)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("user_selectable");
            entity.Property(e => e.WeekStart)
                .HasComment("Week start day. 0 = Sunday, 6 = Saturday")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("week_start");
        });

        modelBuilder.Entity<XfLinkForum>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_link_forum")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(150)
                .HasColumnName("link_url");
            entity.Property(e => e.RedirectCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("redirect_count");
        });

        modelBuilder.Entity<XfLinkProxy>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("PRIMARY");

            entity
                .ToTable("xf_link_proxy")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastRequestDate, "last_request_date");

            entity.HasIndex(e => e.UrlHash, "url_hash").IsUnique();

            entity.Property(e => e.LinkId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("link_id");
            entity.Property(e => e.FirstRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_request_date");
            entity.Property(e => e.Hits)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("hits");
            entity.Property(e => e.LastRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_request_date");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.UrlHash)
                .HasMaxLength(32)
                .HasColumnName("url_hash");
        });

        modelBuilder.Entity<XfLinkProxyReferrer>(entity =>
        {
            entity.HasKey(e => e.ReferrerId).HasName("PRIMARY");

            entity
                .ToTable("xf_link_proxy_referrer")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastDate, "last_date");

            entity.HasIndex(e => new { e.LinkId, e.ReferrerHash }, "link_id_hash").IsUnique();

            entity.Property(e => e.ReferrerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("referrer_id");
            entity.Property(e => e.FirstDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_date");
            entity.Property(e => e.Hits)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("hits");
            entity.Property(e => e.LastDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_date");
            entity.Property(e => e.LinkId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("link_id");
            entity.Property(e => e.ReferrerHash)
                .HasMaxLength(32)
                .HasColumnName("referrer_hash");
            entity.Property(e => e.ReferrerUrl)
                .HasColumnType("text")
                .HasColumnName("referrer_url");
        });

        modelBuilder.Entity<XfLoginAttempt>(entity =>
        {
            entity.HasKey(e => e.AttemptId).HasName("PRIMARY");

            entity
                .ToTable("xf_login_attempt")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AttemptDate, "attempt_date");

            entity.HasIndex(e => new { e.IpAddress, e.AttemptDate }, "ip_address_attempt_date");

            entity.HasIndex(e => new { e.Login, e.IpAddress, e.AttemptDate }, "login_check");

            entity.Property(e => e.AttemptId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attempt_id");
            entity.Property(e => e.AttemptDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attempt_date");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasColumnName("ip_address");
            entity.Property(e => e.Login)
                .HasMaxLength(60)
                .HasColumnName("login");
        });

        modelBuilder.Entity<XfMadUserEvercookie>(entity =>
        {
            entity.HasKey(e => e.EvercookieId).HasName("PRIMARY");

            entity
                .ToTable("xf_mad_user_evercookie")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Evercookie, "evercookie");

            entity.HasIndex(e => e.EvercookieDate, "evercookie_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.EvercookieId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("evercookie_id");
            entity.Property(e => e.Evercookie)
                .HasMaxLength(32)
                .HasColumnName("evercookie");
            entity.Property(e => e.EvercookieDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("evercookie_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMadUserFingerprint>(entity =>
        {
            entity.HasKey(e => e.FingerprintId).HasName("PRIMARY");

            entity
                .ToTable("xf_mad_user_fingerprint")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Fingerprint, "fingerprint");

            entity.HasIndex(e => e.FingerprintDate, "fingerprint_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.FingerprintId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fingerprint_id");
            entity.Property(e => e.Fingerprint)
                .HasMaxLength(40)
                .HasColumnName("fingerprint");
            entity.Property(e => e.FingerprintDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fingerprint_date");
            entity.Property(e => e.IsPro)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_pro");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMadUserMultiAccount>(entity =>
        {
            entity.HasKey(e => e.MultiAccountId).HasName("PRIMARY");

            entity
                .ToTable("xf_mad_user_multi_account")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IsClosed, "is_closed");

            entity.HasIndex(e => e.MultiAccountDate, "multi_account_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.MultiAccountId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("multi_account_id");
            entity.Property(e => e.CloseReason)
                .HasColumnType("text")
                .HasColumnName("close_reason");
            entity.Property(e => e.IsClosed)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_closed");
            entity.Property(e => e.MultiAccountDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("multi_account_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMailQueue>(entity =>
        {
            entity.HasKey(e => e.MailQueueId).HasName("PRIMARY");

            entity
                .ToTable("xf_mail_queue")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.SendDate, e.QueueDate }, "send_date_queue_date");

            entity.Property(e => e.MailQueueId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mail_queue_id");
            entity.Property(e => e.FailCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fail_count");
            entity.Property(e => e.FailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fail_date");
            entity.Property(e => e.MailData)
                .HasColumnType("mediumblob")
                .HasColumnName("mail_data");
            entity.Property(e => e.QueueDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("queue_date");
            entity.Property(e => e.SendDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("send_date");
        });

        modelBuilder.Entity<XfMemberStat>(entity =>
        {
            entity.HasKey(e => e.MemberStatId).HasName("PRIMARY");

            entity
                .ToTable("xf_member_stat")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.HasIndex(e => e.MemberStatKey, "member_stat_key").IsUnique();

            entity.Property(e => e.MemberStatId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("member_stat_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.CacheExpiry)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_expiry");
            entity.Property(e => e.CacheLifetime)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_lifetime");
            entity.Property(e => e.CacheResults)
                .HasColumnType("blob")
                .HasColumnName("cache_results");
            entity.Property(e => e.CallbackClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_class");
            entity.Property(e => e.CallbackMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_method");
            entity.Property(e => e.Criteria)
                .HasColumnType("blob")
                .HasColumnName("criteria");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.MemberStatKey)
                .HasMaxLength(50)
                .HasColumnName("member_stat_key");
            entity.Property(e => e.OverviewDisplay)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("overview_display");
            entity.Property(e => e.PermissionLimit)
                .HasMaxLength(51)
                .HasDefaultValueSql("''")
                .HasColumnName("permission_limit");
            entity.Property(e => e.ShowValue)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("show_value");
            entity.Property(e => e.SortDirection)
                .HasMaxLength(5)
                .HasDefaultValueSql("'desc'")
                .HasColumnName("sort_direction");
            entity.Property(e => e.SortOrder)
                .HasMaxLength(50)
                .HasDefaultValueSql("'message_count'")
                .HasColumnName("sort_order");
            entity.Property(e => e.UserLimit)
                .HasDefaultValueSql("'20'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_limit");
            entity.Property(e => e.VisibilityClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("visibility_class");
            entity.Property(e => e.VisibilityMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("visibility_method");
        });

        modelBuilder.Entity<XfMgAlbum>(entity =>
        {
            entity.HasKey(e => e.AlbumId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_album")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CreateDate, "album_create_date");

            entity.HasIndex(e => new { e.UserId, e.CreateDate }, "album_user_id_album_create_date");

            entity.HasIndex(e => e.LastCommentDate, "last_comment_date");

            entity.HasIndex(e => e.LastCommentUserId, "last_comment_user_id");

            entity.Property(e => e.AlbumId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.AddPrivacy)
                .HasDefaultValueSql("'private'")
                .HasColumnType("enum('public','members','private','shared','inherit')")
                .HasColumnName("add_privacy");
            entity.Property(e => e.AddUsers)
                .HasColumnType("mediumblob")
                .HasColumnName("add_users");
            entity.Property(e => e.AlbumHash)
                .HasMaxLength(32)
                .HasColumnName("album_hash");
            entity.Property(e => e.AlbumState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("album_state");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.CreateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_date");
            entity.Property(e => e.CustomThumbnailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("custom_thumbnail_date");
            entity.Property(e => e.DefaultOrder)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','custom')")
                .HasColumnName("default_order");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastCommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_date");
            entity.Property(e => e.LastCommentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_id");
            entity.Property(e => e.LastCommentUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_user_id");
            entity.Property(e => e.LastCommentUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("last_comment_username");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MediaCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_count");
            entity.Property(e => e.MediaItemCache)
                .HasColumnType("mediumblob")
                .HasColumnName("media_item_cache");
            entity.Property(e => e.RatingAvg)
                .HasColumnType("float unsigned")
                .HasColumnName("rating_avg");
            entity.Property(e => e.RatingCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_count");
            entity.Property(e => e.RatingSum)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_sum");
            entity.Property(e => e.RatingWeighted)
                .HasColumnType("float unsigned")
                .HasColumnName("rating_weighted");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.ThumbnailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thumbnail_date");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.ViewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_count");
            entity.Property(e => e.ViewPrivacy)
                .HasDefaultValueSql("'private'")
                .HasColumnType("enum('public','members','private','shared','inherit')")
                .HasColumnName("view_privacy");
            entity.Property(e => e.ViewUsers)
                .HasColumnType("mediumblob")
                .HasColumnName("view_users");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfMgAlbumCommentRead>(entity =>
        {
            entity.HasKey(e => e.CommentReadId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_album_comment_read")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AlbumId, "album_id");

            entity.HasIndex(e => e.CommentReadDate, "comment_read_date");

            entity.HasIndex(e => new { e.UserId, e.AlbumId }, "user_id_album_id").IsUnique();

            entity.Property(e => e.CommentReadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_read_id");
            entity.Property(e => e.AlbumId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.CommentReadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_read_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMgAlbumView>(entity =>
        {
            entity.HasKey(e => e.AlbumId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_album_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.AlbumId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.Total)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total");
        });

        modelBuilder.Entity<XfMgAlbumWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.AlbumId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_album_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.AlbumId, e.NotifyOn }, "album_id_notify_on");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.AlbumId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.NotifyOn)
                .HasColumnType("enum('','media','comment','media_comment')")
                .HasColumnName("notify_on");
            entity.Property(e => e.SendAlert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_alert");
            entity.Property(e => e.SendEmail)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_email");
        });

        modelBuilder.Entity<XfMgAttachmentExif>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_attachment_exif")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.AttachmentId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attachment_id");
            entity.Property(e => e.AttachDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attach_date");
            entity.Property(e => e.ExifData)
                .HasColumnType("mediumblob")
                .HasColumnName("exif_data");
        });

        modelBuilder.Entity<XfMgCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_category")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "lft_rgt");

            entity.HasIndex(e => new { e.ParentCategoryId, e.Lft }, "parent_category_id_lft");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.AlbumCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_count");
            entity.Property(e => e.AllowedTypes)
                .HasColumnType("blob")
                .HasColumnName("allowed_types");
            entity.Property(e => e.BreadcrumbData)
                .HasColumnType("blob")
                .HasColumnName("breadcrumb_data");
            entity.Property(e => e.CategoryIndexLimit)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("category_index_limit");
            entity.Property(e => e.CategoryType)
                .HasDefaultValueSql("'media'")
                .HasColumnType("enum('media','album','container')")
                .HasColumnName("category_type");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.Depth)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("depth");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.FieldCache)
                .HasColumnType("mediumblob")
                .HasColumnName("field_cache");
            entity.Property(e => e.Lft)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("lft");
            entity.Property(e => e.MediaCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_count");
            entity.Property(e => e.MinTags)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_tags");
            entity.Property(e => e.ParentCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("parent_category_id");
            entity.Property(e => e.Rgt)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rgt");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfMgCategoryField>(entity =>
        {
            entity.HasKey(e => new { e.FieldId, e.CategoryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_category_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<XfMgCategoryWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CategoryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_category_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.CategoryId, e.NotifyOn }, "category_id_notify_on");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.IncludeChildren)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("include_children");
            entity.Property(e => e.NotifyOn)
                .HasColumnType("enum('','media')")
                .HasColumnName("notify_on");
            entity.Property(e => e.SendAlert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_alert");
            entity.Property(e => e.SendEmail)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_email");
        });

        modelBuilder.Entity<XfMgComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_comment")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CommentDate, "comment_date");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.CommentDate }, "content_type_content_id_comment_date");

            entity.HasIndex(e => e.RatingId, "rating_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.CommentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_id");
            entity.Property(e => e.CommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_date");
            entity.Property(e => e.CommentState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("comment_state");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.EditCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_count");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastEditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_date");
            entity.Property(e => e.LastEditUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_user_id");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.RatingId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_id");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfMgMediaCommentRead>(entity =>
        {
            entity.HasKey(e => e.CommentReadId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_comment_read")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CommentReadDate, "comment_read_date");

            entity.HasIndex(e => e.MediaId, "media_id");

            entity.HasIndex(e => new { e.UserId, e.MediaId }, "user_id_media_id").IsUnique();

            entity.Property(e => e.CommentReadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_read_id");
            entity.Property(e => e.CommentReadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_read_date");
            entity.Property(e => e.MediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMgMediaField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DisplayGroup, e.DisplayOrder }, "display_group_order");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.AlbumUse)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("album_use");
            entity.Property(e => e.DisplayAddMedia)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("display_add_media");
            entity.Property(e => e.DisplayGroup)
                .HasMaxLength(25)
                .HasDefaultValueSql("'below_media'")
                .HasColumnName("display_group");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DisplayTemplate)
                .HasColumnType("text")
                .HasColumnName("display_template");
            entity.Property(e => e.FieldChoices)
                .HasColumnType("blob")
                .HasColumnName("field_choices");
            entity.Property(e => e.FieldType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'textbox'")
                .HasColumnName("field_type");
            entity.Property(e => e.MatchParams)
                .HasColumnType("blob")
                .HasColumnName("match_params");
            entity.Property(e => e.MatchType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'none'")
                .HasColumnName("match_type");
            entity.Property(e => e.MaxLength)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.Required)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("required");
            entity.Property(e => e.WrapperTemplate)
                .HasColumnType("text")
                .HasColumnName("wrapper_template");
        });

        modelBuilder.Entity<XfMgMediaFieldValue>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_media_field_value")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldId, "field_id");

            entity.Property(e => e.MediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.FieldValue)
                .HasColumnType("mediumtext")
                .HasColumnName("field_value");
        });

        modelBuilder.Entity<XfMgMediaItem>(entity =>
        {
            entity.HasKey(e => e.MediaId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_item")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.AlbumId, e.MediaDate }, "album_id_media_date");

            entity.HasIndex(e => new { e.CategoryId, e.MediaDate }, "category_id_media_date");

            entity.HasIndex(e => e.LastCommentDate, "last_comment_date");

            entity.HasIndex(e => e.LastCommentUserId, "last_comment_user_id");

            entity.HasIndex(e => e.MediaDate, "media_date");

            entity.HasIndex(e => e.MediaHash, "media_hash").IsUnique();

            entity.HasIndex(e => e.Position, "position");

            entity.HasIndex(e => new { e.UserId, e.MediaDate }, "user_id_media_date");

            entity.Property(e => e.MediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.AlbumId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.CustomFields)
                .HasColumnType("mediumblob")
                .HasColumnName("custom_fields");
            entity.Property(e => e.CustomThumbnailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("custom_thumbnail_date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ExifData)
                .HasColumnType("mediumblob")
                .HasColumnName("exif_data");
            entity.Property(e => e.Imported)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("imported");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastCommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_date");
            entity.Property(e => e.LastCommentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_id");
            entity.Property(e => e.LastCommentUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_user_id");
            entity.Property(e => e.LastCommentUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("last_comment_username");
            entity.Property(e => e.LastEditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_date");
            entity.Property(e => e.MediaDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_date");
            entity.Property(e => e.MediaEmbedUrl)
                .HasColumnType("text")
                .HasColumnName("media_embed_url");
            entity.Property(e => e.MediaHash)
                .HasMaxLength(32)
                .HasColumnName("media_hash");
            entity.Property(e => e.MediaState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("media_state");
            entity.Property(e => e.MediaTag)
                .HasColumnType("text")
                .HasColumnName("media_tag");
            entity.Property(e => e.MediaType)
                .HasMaxLength(25)
                .HasColumnName("media_type");
            entity.Property(e => e.Position)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("position");
            entity.Property(e => e.PosterDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poster_date");
            entity.Property(e => e.RatingAvg)
                .HasColumnType("float unsigned")
                .HasColumnName("rating_avg");
            entity.Property(e => e.RatingCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_count");
            entity.Property(e => e.RatingSum)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_sum");
            entity.Property(e => e.RatingWeighted)
                .HasColumnType("float unsigned")
                .HasColumnName("rating_weighted");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.Tags)
                .HasColumnType("mediumblob")
                .HasColumnName("tags");
            entity.Property(e => e.ThumbnailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thumbnail_date");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.ViewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_count");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
            entity.Property(e => e.Watermarked)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("watermarked");
        });

        modelBuilder.Entity<XfMgMediaNote>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_note")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.MediaId, "media_id");

            entity.Property(e => e.NoteId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("note_id");
            entity.Property(e => e.MediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.NoteData)
                .HasColumnType("blob")
                .HasColumnName("note_data");
            entity.Property(e => e.NoteDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("note_date");
            entity.Property(e => e.NoteText)
                .HasColumnType("text")
                .HasColumnName("note_text");
            entity.Property(e => e.NoteType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'user_tag'")
                .HasColumnName("note_type");
            entity.Property(e => e.TagState)
                .HasDefaultValueSql("'approved'")
                .HasColumnType("enum('approved','pending','rejected')")
                .HasColumnName("tag_state");
            entity.Property(e => e.TagStateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tag_state_date");
            entity.Property(e => e.TaggedUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tagged_user_id");
            entity.Property(e => e.TaggedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("tagged_username");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfMgMediaTemp>(entity =>
        {
            entity.HasKey(e => e.TempMediaId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_temp")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AttachmentId, "attachment_id").IsUnique();

            entity.HasIndex(e => e.MediaHash, "media_hash").IsUnique();

            entity.Property(e => e.TempMediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("temp_media_id");
            entity.Property(e => e.AttachmentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attachment_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ExifData)
                .HasColumnType("mediumblob")
                .HasColumnName("exif_data");
            entity.Property(e => e.MediaHash)
                .HasMaxLength(32)
                .HasColumnName("media_hash");
            entity.Property(e => e.MediaType)
                .HasMaxLength(25)
                .HasColumnName("media_type");
            entity.Property(e => e.PosterDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poster_date");
            entity.Property(e => e.RequiresTranscoding)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("requires_transcoding");
            entity.Property(e => e.TempMediaDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("temp_media_date");
            entity.Property(e => e.ThumbnailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thumbnail_date");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMgMediaUserView>(entity =>
        {
            entity.HasKey(e => e.MediaViewId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_user_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.MediaId, "media_id");

            entity.HasIndex(e => e.MediaViewDate, "media_view_date");

            entity.HasIndex(e => new { e.UserId, e.MediaId }, "user_id_media_id").IsUnique();

            entity.Property(e => e.MediaViewId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_view_id");
            entity.Property(e => e.MediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.MediaViewDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_view_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMgMediaView>(entity =>
        {
            entity.HasKey(e => e.MediaId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_media_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.MediaId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.Total)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total");
        });

        modelBuilder.Entity<XfMgMediaWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.MediaId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_media_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.MediaId, e.NotifyOn }, "media_id_notify_on");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.MediaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("media_id");
            entity.Property(e => e.NotifyOn)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','comment')")
                .HasColumnName("notify_on");
            entity.Property(e => e.SendAlert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_alert");
            entity.Property(e => e.SendEmail)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_email");
        });

        modelBuilder.Entity<XfMgRating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_rating")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.UserId }, "content_type_id_user_id").IsUnique();

            entity.Property(e => e.RatingId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.Rating)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rating");
            entity.Property(e => e.RatingDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfMgSharedMapAdd>(entity =>
        {
            entity.HasKey(e => new { e.AlbumId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_shared_map_add")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.AlbumId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMgSharedMapView>(entity =>
        {
            entity.HasKey(e => new { e.AlbumId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_mg_shared_map_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.AlbumId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("album_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfMgTranscodeQueue>(entity =>
        {
            entity.HasKey(e => e.TranscodeQueueId).HasName("PRIMARY");

            entity
                .ToTable("xf_mg_transcode_queue")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.QueueDate, "queue_date");

            entity.Property(e => e.TranscodeQueueId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transcode_queue_id");
            entity.Property(e => e.QueueData)
                .HasColumnType("mediumblob")
                .HasColumnName("queue_data");
            entity.Property(e => e.QueueDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("queue_date");
            entity.Property(e => e.QueueState)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','processing')")
                .HasColumnName("queue_state");
        });

        modelBuilder.Entity<XfModerator>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_moderator")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ExtraUserGroupIds)
                .HasMaxLength(255)
                .HasColumnName("extra_user_group_ids");
            entity.Property(e => e.IsSuperModerator)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_super_moderator");
        });

        modelBuilder.Entity<XfModeratorContent>(entity =>
        {
            entity.HasKey(e => e.ModeratorId).HasName("PRIMARY");

            entity
                .ToTable("xf_moderator_content")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.UserId }, "content_user_id").IsUnique();

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ModeratorId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("moderator_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfModeratorLog>(entity =>
        {
            entity.HasKey(e => e.ModeratorLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_moderator_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_id");

            entity.HasIndex(e => e.ContentUserId, "content_user_id");

            entity.HasIndex(e => new { e.DiscussionContentType, e.DiscussionContentId }, "discussion_content_type_id");

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.HasIndex(e => new { e.UserId, e.LogDate }, "user_id_log_date");

            entity.Property(e => e.ModeratorLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("moderator_log_id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasColumnName("action");
            entity.Property(e => e.ActionParams)
                .HasColumnType("mediumblob")
                .HasColumnName("action_params");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentTitle)
                .HasMaxLength(150)
                .HasColumnName("content_title");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentUrl)
                .HasColumnType("text")
                .HasColumnName("content_url");
            entity.Property(e => e.ContentUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_user_id");
            entity.Property(e => e.ContentUsername)
                .HasMaxLength(50)
                .HasColumnName("content_username");
            entity.Property(e => e.DiscussionContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("discussion_content_id");
            entity.Property(e => e.DiscussionContentType)
                .HasMaxLength(25)
                .HasColumnName("discussion_content_type");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfNavigation>(entity =>
        {
            entity.HasKey(e => e.NavigationId).HasName("PRIMARY");

            entity
                .ToTable("xf_navigation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ParentNavigationId, e.DisplayOrder }, "parent_navigation_id_display_order");

            entity.Property(e => e.NavigationId)
                .HasMaxLength(50)
                .HasColumnName("navigation_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.ConditionExpression)
                .HasColumnType("mediumblob")
                .HasColumnName("condition_expression");
            entity.Property(e => e.ConditionSetup)
                .HasColumnType("mediumblob")
                .HasColumnName("condition_setup");
            entity.Property(e => e.DataExpression)
                .HasColumnType("mediumblob")
                .HasColumnName("data_expression");
            entity.Property(e => e.DataSetup)
                .HasColumnType("mediumblob")
                .HasColumnName("data_setup");
            entity.Property(e => e.DefaultValue)
                .HasColumnType("mediumblob")
                .HasColumnName("default_value");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Enabled)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enabled");
            entity.Property(e => e.GlobalSetup)
                .HasColumnType("mediumblob")
                .HasColumnName("global_setup");
            entity.Property(e => e.IsCustomized)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_customized");
            entity.Property(e => e.NavigationTypeId)
                .HasMaxLength(25)
                .HasColumnName("navigation_type_id");
            entity.Property(e => e.ParentNavigationId)
                .HasMaxLength(50)
                .HasColumnName("parent_navigation_id");
            entity.Property(e => e.TypeConfig)
                .HasColumnType("mediumtext")
                .HasColumnName("type_config");
        });

        modelBuilder.Entity<XfNavigationType>(entity =>
        {
            entity.HasKey(e => e.NavigationTypeId).HasName("PRIMARY");

            entity
                .ToTable("xf_navigation_type")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NavigationTypeId)
                .HasMaxLength(25)
                .HasColumnName("navigation_type_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.HandlerClass)
                .HasMaxLength(100)
                .HasColumnName("handler_class");
        });

        modelBuilder.Entity<XfNewsFeed>(entity =>
        {
            entity.HasKey(e => e.NewsFeedId).HasName("PRIMARY");

            entity
                .ToTable("xf_news_feed")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "contentType_contentId");

            entity.HasIndex(e => e.EventDate, "event_date");

            entity.HasIndex(e => new { e.UserId, e.EventDate }, "userId_eventDate");

            entity.Property(e => e.NewsFeedId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("news_feed_id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasComment("eg: edit")
                .HasColumnName("action");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasComment("eg: thread")
                .HasColumnName("content_type");
            entity.Property(e => e.EventDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_date");
            entity.Property(e => e.ExtraData)
                .HasComment("Serialized. Stores any extra data relevant to the action")
                .HasColumnType("mediumblob")
                .HasColumnName("extra_data");
            entity.Property(e => e.UserId)
                .HasComment("The user who performed the action")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasComment("Corresponds to user_id")
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfNode>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_node")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DisplayInList, e.Lft }, "display_in_list");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.HasIndex(e => e.Lft, "lft");

            entity.HasIndex(e => new { e.NodeName, e.NodeTypeId }, "node_name_unique").IsUnique();

            entity.HasIndex(e => e.ParentNodeId, "parent_node_id");

            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.BreadcrumbData)
                .HasColumnType("blob")
                .HasColumnName("breadcrumb_data");
            entity.Property(e => e.Depth)
                .HasComment("Depth = 0: no parent")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("depth");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayInList)
                .HasDefaultValueSql("'1'")
                .HasComment("If 0, hidden from node list. Still counts for lft/rgt.")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("display_in_list");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.EffectiveNavigationId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("effective_navigation_id");
            entity.Property(e => e.EffectiveStyleId)
                .HasComment("Style override; pushed down tree")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("effective_style_id");
            entity.Property(e => e.Lft)
                .HasComment("Nested set info 'left' value")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("lft");
            entity.Property(e => e.NavigationId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("navigation_id");
            entity.Property(e => e.NodeName)
                .HasMaxLength(50)
                .HasComment("Unique column used as string ID by some node types")
                .HasColumnName("node_name");
            entity.Property(e => e.NodeTypeId)
                .HasMaxLength(25)
                .HasColumnName("node_type_id");
            entity.Property(e => e.ParentNodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("parent_node_id");
            entity.Property(e => e.Rgt)
                .HasComment("Nested set info 'right' value")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rgt");
            entity.Property(e => e.StyleId)
                .HasComment("Style override for specific node")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.TcCniIconType)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','fa','img')")
                .HasColumnName("tc_cni_icon_type");
            entity.Property(e => e.TcCniIconValue)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("tc_cni_icon_value");
            entity.Property(e => e.TcCniUnreadIconValue)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("tc_cni_unread_icon_value");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.XfaNitParams)
                .HasColumnType("text")
                .HasColumnName("xfa_nit_params");
            entity.Property(e => e.XfaNitType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_nit_type");
        });

        modelBuilder.Entity<XfNodeType>(entity =>
        {
            entity.HasKey(e => e.NodeTypeId).HasName("PRIMARY");

            entity
                .ToTable("xf_node_type")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeTypeId)
                .HasMaxLength(25)
                .HasColumnName("node_type_id");
            entity.Property(e => e.AdminRoute)
                .HasMaxLength(75)
                .HasColumnName("admin_route");
            entity.Property(e => e.EntityIdentifier)
                .HasMaxLength(75)
                .HasColumnName("entity_identifier");
            entity.Property(e => e.HandlerClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("handler_class");
            entity.Property(e => e.PermissionGroupId)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("permission_group_id");
            entity.Property(e => e.PublicRoute)
                .HasMaxLength(75)
                .HasColumnName("public_route");
        });

        modelBuilder.Entity<XfNotice>(entity =>
        {
            entity.HasKey(e => e.NoticeId).HasName("PRIMARY");

            entity
                .ToTable("xf_notice")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NoticeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("notice_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AutoDismiss)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("auto_dismiss");
            entity.Property(e => e.CssClass)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("css_class");
            entity.Property(e => e.DelayDuration)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("delay_duration");
            entity.Property(e => e.Dismissible)
                .HasDefaultValueSql("'1'")
                .HasComment("Notice may be hidden when read by users")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dismissible");
            entity.Property(e => e.DisplayDuration)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_duration");
            entity.Property(e => e.DisplayImage)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','avatar','image')")
                .HasColumnName("display_image");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DisplayStyle)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("display_style");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("image_url");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.NoticeType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'block'")
                .HasColumnName("notice_type");
            entity.Property(e => e.PageCriteria)
                .HasColumnType("mediumblob")
                .HasColumnName("page_criteria");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.UserCriteria)
                .HasColumnType("mediumblob")
                .HasColumnName("user_criteria");
            entity.Property(e => e.Visibility)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','wide','medium','narrow')")
                .HasColumnName("visibility");
        });

        modelBuilder.Entity<XfNoticeDismissed>(entity =>
        {
            entity.HasKey(e => new { e.NoticeId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_notice_dismissed")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.NoticeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("notice_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.DismissDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dismiss_date");
        });

        modelBuilder.Entity<XfOembed>(entity =>
        {
            entity.HasKey(e => e.OembedId).HasName("PRIMARY");

            entity
                .ToTable("xf_oembed")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IsProcessing, "is_processing");

            entity.HasIndex(e => e.LastRequestDate, "last_request_date");

            entity.HasIndex(e => e.MediaHash, "media_hash").IsUnique();

            entity.HasIndex(e => new { e.Pruned, e.FetchDate }, "pruned_fetch_date");

            entity.Property(e => e.OembedId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("oembed_id");
            entity.Property(e => e.FailCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fail_count");
            entity.Property(e => e.FailedDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("failed_date");
            entity.Property(e => e.FetchDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fetch_date");
            entity.Property(e => e.FirstRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_request_date");
            entity.Property(e => e.IsProcessing)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("is_processing");
            entity.Property(e => e.LastRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_request_date");
            entity.Property(e => e.MediaHash)
                .HasMaxLength(32)
                .HasColumnName("media_hash");
            entity.Property(e => e.MediaId)
                .HasMaxLength(250)
                .HasColumnName("media_id");
            entity.Property(e => e.MediaSiteId)
                .HasMaxLength(25)
                .HasColumnName("media_site_id");
            entity.Property(e => e.Pruned)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("pruned");
            entity.Property(e => e.Title)
                .HasColumnType("mediumtext")
                .HasColumnName("title");
            entity.Property(e => e.Views)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("views");
        });

        modelBuilder.Entity<XfOembedReferrer>(entity =>
        {
            entity.HasKey(e => e.ReferrerId).HasName("PRIMARY");

            entity
                .ToTable("xf_oembed_referrer")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastDate, "last_date");

            entity.HasIndex(e => new { e.OembedId, e.ReferrerHash }, "oembed_id_hash").IsUnique();

            entity.Property(e => e.ReferrerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("referrer_id");
            entity.Property(e => e.FirstDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_date");
            entity.Property(e => e.Hits)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("hits");
            entity.Property(e => e.LastDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_date");
            entity.Property(e => e.OembedId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("oembed_id");
            entity.Property(e => e.ReferrerHash)
                .HasMaxLength(32)
                .HasColumnName("referrer_hash");
            entity.Property(e => e.ReferrerUrl)
                .HasColumnType("text")
                .HasColumnName("referrer_url");
        });

        modelBuilder.Entity<XfOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PRIMARY");

            entity
                .ToTable("xf_option")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.OptionId)
                .HasMaxLength(50)
                .HasColumnName("option_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.Advanced)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("advanced");
            entity.Property(e => e.DefaultValue)
                .HasColumnType("mediumblob")
                .HasColumnName("default_value");
            entity.Property(e => e.EditFormat)
                .HasColumnType("enum('textbox','spinbox','onoff','radio','select','checkbox','template','callback','onofftextbox','username')")
                .HasColumnName("edit_format");
            entity.Property(e => e.EditFormatParams)
                .HasColumnType("mediumtext")
                .HasColumnName("edit_format_params");
            entity.Property(e => e.OptionValue)
                .HasColumnType("mediumblob")
                .HasColumnName("option_value");
            entity.Property(e => e.SubOptions)
                .HasColumnType("mediumtext")
                .HasColumnName("sub_options");
            entity.Property(e => e.ValidationClass)
                .HasMaxLength(100)
                .HasColumnName("validation_class");
            entity.Property(e => e.ValidationMethod)
                .HasMaxLength(75)
                .HasColumnName("validation_method");
        });

        modelBuilder.Entity<XfOptionGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_option_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .HasColumnName("group_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.Advanced)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("advanced");
            entity.Property(e => e.DebugOnly)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("debug_only");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasComment("Optional icon")
                .HasColumnName("icon");
        });

        modelBuilder.Entity<XfOptionGroupRelation>(entity =>
        {
            entity.HasKey(e => new { e.OptionId, e.GroupId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_option_group_relation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.GroupId, e.DisplayOrder }, "group_id_display_order");

            entity.Property(e => e.OptionId)
                .HasMaxLength(50)
                .HasColumnName("option_id");
            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .HasColumnName("group_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
        });

        modelBuilder.Entity<XfPage>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_page")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.AdvancedMode)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("advanced_mode");
            entity.Property(e => e.CallbackClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_class");
            entity.Property(e => e.CallbackMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("callback_method");
            entity.Property(e => e.ListChildren)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("list_children");
            entity.Property(e => e.ListSiblings)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("list_siblings");
            entity.Property(e => e.LogVisits)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("log_visits");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("modified_date");
            entity.Property(e => e.PublishDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("publish_date");
            entity.Property(e => e.ViewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_count");
        });

        modelBuilder.Entity<XfPaymentProfile>(entity =>
        {
            entity.HasKey(e => e.PaymentProfileId).HasName("PRIMARY");

            entity
                .ToTable("xf_payment_profile")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PaymentProfileId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("payment_profile_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.DisplayTitle)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("display_title");
            entity.Property(e => e.Options)
                .HasColumnType("blob")
                .HasColumnName("options");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.XfaRmmpActive)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_active");
            entity.Property(e => e.XfaRmmpUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_user_id");
        });

        modelBuilder.Entity<XfPaymentProvider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PRIMARY");

            entity
                .ToTable("xf_payment_provider")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.ProviderClass)
                .HasMaxLength(100)
                .HasColumnName("provider_class");
        });

        modelBuilder.Entity<XfPaymentProviderLog>(entity =>
        {
            entity.HasKey(e => e.ProviderLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_payment_provider_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.HasIndex(e => e.SubscriberId, "subscriber_id");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.Property(e => e.ProviderLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("provider_log_id");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.LogDetails)
                .HasColumnType("mediumblob")
                .HasColumnName("log_details");
            entity.Property(e => e.LogMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("log_message");
            entity.Property(e => e.LogType)
                .HasColumnType("enum('payment','cancel','info','error')")
                .HasColumnName("log_type");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.PurchaseRequestKey)
                .HasMaxLength(32)
                .HasColumnName("purchase_request_key");
            entity.Property(e => e.SubscriberId)
                .HasMaxLength(100)
                .HasColumnName("subscriber_id");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .HasColumnName("transaction_id");
        });

        modelBuilder.Entity<XfPermission>(entity =>
        {
            entity.HasKey(e => new { e.PermissionId, e.PermissionGroupId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_permission")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.PermissionId)
                .HasMaxLength(25)
                .HasColumnName("permission_id");
            entity.Property(e => e.PermissionGroupId)
                .HasMaxLength(25)
                .HasColumnName("permission_group_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.DependPermissionId)
                .HasMaxLength(25)
                .HasColumnName("depend_permission_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.InterfaceGroupId)
                .HasMaxLength(50)
                .HasColumnName("interface_group_id");
            entity.Property(e => e.PermissionType)
                .HasColumnType("enum('flag','integer')")
                .HasColumnName("permission_type");
        });

        modelBuilder.Entity<XfPermissionCacheContent>(entity =>
        {
            entity.HasKey(e => new { e.PermissionCombinationId, e.ContentType, e.ContentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("xf_permission_cache_content")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PermissionCombinationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("permission_combination_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.CacheValue)
                .HasColumnType("mediumblob")
                .HasColumnName("cache_value");
        });

        modelBuilder.Entity<XfPermissionCombination>(entity =>
        {
            entity.HasKey(e => e.PermissionCombinationId).HasName("PRIMARY");

            entity
                .ToTable("xf_permission_combination")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.PermissionCombinationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("permission_combination_id");
            entity.Property(e => e.CacheValue)
                .HasColumnType("mediumblob")
                .HasColumnName("cache_value");
            entity.Property(e => e.UserGroupList)
                .HasColumnType("mediumblob")
                .HasColumnName("user_group_list");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfPermissionCombinationUserGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserGroupId, e.PermissionCombinationId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_permission_combination_user_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PermissionCombinationId, "permission_combination_id");

            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_group_id");
            entity.Property(e => e.PermissionCombinationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("permission_combination_id");
        });

        modelBuilder.Entity<XfPermissionEntry>(entity =>
        {
            entity.HasKey(e => e.PermissionEntryId).HasName("PRIMARY");

            entity
                .ToTable("xf_permission_entry")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserGroupId, e.UserId, e.PermissionGroupId, e.PermissionId }, "unique_permission").IsUnique();

            entity.Property(e => e.PermissionEntryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("permission_entry_id");
            entity.Property(e => e.PermissionGroupId)
                .HasMaxLength(25)
                .HasColumnName("permission_group_id");
            entity.Property(e => e.PermissionId)
                .HasMaxLength(25)
                .HasColumnName("permission_id");
            entity.Property(e => e.PermissionValue)
                .HasColumnType("enum('unset','allow','deny','use_int')")
                .HasColumnName("permission_value");
            entity.Property(e => e.PermissionValueInt)
                .HasColumnType("int(11)")
                .HasColumnName("permission_value_int");
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_group_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfPermissionEntryContent>(entity =>
        {
            entity.HasKey(e => e.PermissionEntryId).HasName("PRIMARY");

            entity
                .ToTable("xf_permission_entry_content")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_content_id");

            entity.HasIndex(e => new { e.UserGroupId, e.UserId, e.ContentType, e.ContentId, e.PermissionGroupId, e.PermissionId }, "user_group_id_unique").IsUnique();

            entity.Property(e => e.PermissionEntryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("permission_entry_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.PermissionGroupId)
                .HasMaxLength(25)
                .HasColumnName("permission_group_id");
            entity.Property(e => e.PermissionId)
                .HasMaxLength(25)
                .HasColumnName("permission_id");
            entity.Property(e => e.PermissionValue)
                .HasColumnType("enum('unset','reset','content_allow','deny','use_int')")
                .HasColumnName("permission_value");
            entity.Property(e => e.PermissionValueInt)
                .HasColumnType("int(11)")
                .HasColumnName("permission_value_int");
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_group_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfPermissionInterfaceGroup>(entity =>
        {
            entity.HasKey(e => e.InterfaceGroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_permission_interface_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.InterfaceGroupId)
                .HasMaxLength(50)
                .HasColumnName("interface_group_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.IsModerator)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_moderator");
        });

        modelBuilder.Entity<XfPhrase>(entity =>
        {
            entity.HasKey(e => e.PhraseId).HasName("PRIMARY");

            entity
                .ToTable("xf_phrase")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.LanguageId, e.GlobalCache }, "language_id_global_cache");

            entity.HasIndex(e => new { e.Title, e.LanguageId }, "title").IsUnique();

            entity.Property(e => e.PhraseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("phrase_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.GlobalCache)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("global_cache");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.PhraseText)
                .HasColumnType("mediumtext")
                .HasColumnName("phrase_text");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.VersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("version_id");
            entity.Property(e => e.VersionString)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("version_string");
        });

        modelBuilder.Entity<XfPhraseCompiled>(entity =>
        {
            entity.HasKey(e => new { e.LanguageId, e.Title })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_phrase_compiled")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.LanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.PhraseText)
                .HasColumnType("mediumtext")
                .HasColumnName("phrase_text");
        });

        modelBuilder.Entity<XfPhraseMap>(entity =>
        {
            entity.HasKey(e => e.PhraseMapId).HasName("PRIMARY");

            entity
                .ToTable("xf_phrase_map")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.PhraseGroup, e.LanguageId }, "group_language");

            entity.HasIndex(e => new { e.LanguageId, e.Title }, "language_id_title").IsUnique();

            entity.HasIndex(e => e.PhraseId, "phrase_id");

            entity.HasIndex(e => e.Title, "title");

            entity.Property(e => e.PhraseMapId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("phrase_map_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.PhraseGroup)
                .HasMaxLength(50)
                .HasColumnName("phrase_group");
            entity.Property(e => e.PhraseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("phrase_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfPoll>(entity =>
        {
            entity.HasKey(e => e.PollId).HasName("PRIMARY");

            entity
                .ToTable("xf_poll")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_content_id").IsUnique();

            entity.Property(e => e.PollId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poll_id");
            entity.Property(e => e.ChangeVote)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("change_vote");
            entity.Property(e => e.CloseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("close_date");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.MaxVotes)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("max_votes");
            entity.Property(e => e.PublicVotes)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("public_votes");
            entity.Property(e => e.Question)
                .HasMaxLength(100)
                .HasColumnName("question");
            entity.Property(e => e.Responses)
                .HasColumnType("mediumblob")
                .HasColumnName("responses");
            entity.Property(e => e.ViewResultsUnvoted)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("view_results_unvoted");
            entity.Property(e => e.VoterCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("voter_count");
        });

        modelBuilder.Entity<XfPollResponse>(entity =>
        {
            entity.HasKey(e => e.PollResponseId).HasName("PRIMARY");

            entity
                .ToTable("xf_poll_response")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.PollId, e.PollResponseId }, "poll_id_response_id");

            entity.Property(e => e.PollResponseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poll_response_id");
            entity.Property(e => e.PollId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poll_id");
            entity.Property(e => e.Response)
                .HasMaxLength(100)
                .HasColumnName("response");
            entity.Property(e => e.ResponseVoteCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("response_vote_count");
            entity.Property(e => e.Voters)
                .HasColumnType("mediumblob")
                .HasColumnName("voters");
        });

        modelBuilder.Entity<XfPollVote>(entity =>
        {
            entity.HasKey(e => new { e.PollResponseId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_poll_vote")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.PollId, e.UserId }, "poll_id_user_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.PollResponseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poll_response_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.PollId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poll_id");
            entity.Property(e => e.VoteDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_date");
        });

        modelBuilder.Entity<XfPost>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PRIMARY");

            entity
                .ToTable("xf_post")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PostDate, "post_date");

            entity.HasIndex(e => new { e.ThreadId, e.Position }, "thread_id_position");

            entity.HasIndex(e => new { e.ThreadId, e.PostDate }, "thread_id_post_date");

            entity.HasIndex(e => new { e.ThreadId, e.VoteScore, e.PostDate }, "thread_id_score_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.PostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.BratrStar)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("bratr_star");
            entity.Property(e => e.EditCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_count");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastEditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_date");
            entity.Property(e => e.LastEditUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_user_id");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.MessageState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("message_state");
            entity.Property(e => e.Position)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("position");
            entity.Property(e => e.PostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_date");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.ThreadRatingId)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("thread_rating_id");
            entity.Property(e => e.TypeData)
                .HasColumnType("mediumblob")
                .HasColumnName("type_data");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.VoteCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_count");
            entity.Property(e => e.VoteScore)
                .HasColumnType("int(11)")
                .HasColumnName("vote_score");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfPreRegAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity
                .ToTable("xf_pre_reg_action")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.GuestKey, "guest_key").IsUnique();

            entity.HasIndex(e => e.LastUpdate, "last_update");

            entity.HasIndex(e => e.UserId, "user_id").IsUnique();

            entity.Property(e => e.ActionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("action_id");
            entity.Property(e => e.ActionClass)
                .HasMaxLength(100)
                .HasColumnName("action_class");
            entity.Property(e => e.ActionData)
                .HasColumnType("mediumblob")
                .HasColumnName("action_data");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.GuestKey)
                .HasMaxLength(75)
                .HasColumnName("guest_key");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_update");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfProfilePost>(entity =>
        {
            entity.HasKey(e => e.ProfilePostId).HasName("PRIMARY");

            entity
                .ToTable("xf_profile_post")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PostDate, "post_date");

            entity.HasIndex(e => new { e.ProfileUserId, e.PostDate }, "profile_user_id_post_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ProfilePostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("profile_post_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.FirstCommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_comment_date");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastCommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_date");
            entity.Property(e => e.LatestCommentIds)
                .HasColumnType("blob")
                .HasColumnName("latest_comment_ids");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.MessageState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("message_state");
            entity.Property(e => e.PostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_date");
            entity.Property(e => e.ProfileUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("profile_user_id");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfProfilePostComment>(entity =>
        {
            entity.HasKey(e => e.ProfilePostCommentId).HasName("PRIMARY");

            entity
                .ToTable("xf_profile_post_comment")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CommentDate, "comment_date");

            entity.HasIndex(e => new { e.ProfilePostId, e.CommentDate }, "profile_post_id_comment_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ProfilePostCommentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("profile_post_comment_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.CommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_date");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.MessageState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("message_state");
            entity.Property(e => e.ProfilePostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("profile_post_id");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfPurchasable>(entity =>
        {
            entity.HasKey(e => e.PurchasableTypeId).HasName("PRIMARY");

            entity
                .ToTable("xf_purchasable")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PurchasableTypeId)
                .HasMaxLength(50)
                .HasColumnName("purchasable_type_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.PurchasableClass)
                .HasMaxLength(100)
                .HasColumnName("purchasable_class");
        });

        modelBuilder.Entity<XfPurchaseRequest>(entity =>
        {
            entity.HasKey(e => e.PurchaseRequestId).HasName("PRIMARY");

            entity
                .ToTable("xf_purchase_request")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ProviderId, e.ProviderMetadata }, "provider_id_metadata");

            entity.HasIndex(e => e.RequestKey, "request_key").IsUnique();

            entity.Property(e => e.PurchaseRequestId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_request_id");
            entity.Property(e => e.CostAmount)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("cost_amount");
            entity.Property(e => e.CostCurrency)
                .HasMaxLength(3)
                .HasColumnName("cost_currency");
            entity.Property(e => e.ExtraData)
                .HasColumnType("blob")
                .HasColumnName("extra_data");
            entity.Property(e => e.PaymentProfileId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("payment_profile_id");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.ProviderMetadata)
                .HasMaxLength(100)
                .HasColumnName("provider_metadata");
            entity.Property(e => e.PurchasableTypeId)
                .HasMaxLength(50)
                .HasColumnName("purchasable_type_id");
            entity.Property(e => e.RequestKey)
                .HasMaxLength(32)
                .HasColumnName("request_key");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfReaction>(entity =>
        {
            entity.HasKey(e => e.ReactionId).HasName("PRIMARY");

            entity
                .ToTable("xf_reaction")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.ReactionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reaction_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(200)
                .HasColumnName("image_url");
            entity.Property(e => e.ImageUrl2x)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("image_url_2x");
            entity.Property(e => e.ReactionScore)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.SpriteMode)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("sprite_mode");
            entity.Property(e => e.SpriteParams)
                .HasColumnType("blob")
                .HasColumnName("sprite_params");
            entity.Property(e => e.TextColor)
                .HasMaxLength(100)
                .HasColumnName("text_color");
        });

        modelBuilder.Entity<XfReactionContent>(entity =>
        {
            entity.HasKey(e => e.ReactionContentId).HasName("PRIMARY");

            entity
                .ToTable("xf_reaction_content")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.ReactionDate }, "content_type_id_reaction_date");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.ReactionUserId }, "content_type_id_user_id").IsUnique();

            entity.HasIndex(e => new { e.ContentUserId, e.IsCounted, e.ReactionId, e.ReactionDate }, "content_user_id_is_counted_reaction_id_reaction_date");

            entity.HasIndex(e => new { e.ContentUserId, e.ReactionDate }, "content_user_id_reaction_date");

            entity.HasIndex(e => e.ReactionDate, "reaction_date");

            entity.HasIndex(e => e.ReactionUserId, "reaction_user_id");

            entity.Property(e => e.ReactionContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reaction_content_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_user_id");
            entity.Property(e => e.IsCounted)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_counted");
            entity.Property(e => e.ReactionDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reaction_date");
            entity.Property(e => e.ReactionId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reaction_id");
            entity.Property(e => e.ReactionUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reaction_user_id");
        });

        modelBuilder.Entity<XfRegistrationSpamCache>(entity =>
        {
            entity.HasKey(e => e.CacheKey).HasName("PRIMARY");

            entity
                .ToTable("xf_registration_spam_cache")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Timeout, "timeout");

            entity.Property(e => e.CacheKey)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("cache_key");
            entity.Property(e => e.Result)
                .HasColumnType("mediumblob")
                .HasColumnName("result");
            entity.Property(e => e.Timeout)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("timeout");
        });

        modelBuilder.Entity<XfReport>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PRIMARY");

            entity
                .ToTable("xf_report")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.AssignedUserId, e.ReportState }, "assigned_user_id_state");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_content_id").IsUnique();

            entity.HasIndex(e => new { e.ContentUserId, e.LastModifiedDate }, "content_user_id_modified");

            entity.HasIndex(e => e.LastModifiedDate, "last_modified_date");

            entity.HasIndex(e => e.LastModifiedUserId, "last_modified_user_id");

            entity.HasIndex(e => e.ReportState, "report_state");

            entity.Property(e => e.ReportId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("report_id");
            entity.Property(e => e.AssignedUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("assigned_user_id");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentInfo)
                .HasColumnType("mediumblob")
                .HasColumnName("content_info");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_user_id");
            entity.Property(e => e.FirstReportDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_report_date");
            entity.Property(e => e.LastModifiedDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_modified_date");
            entity.Property(e => e.LastModifiedUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_modified_user_id");
            entity.Property(e => e.LastModifiedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("last_modified_username");
            entity.Property(e => e.ReportCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("report_count");
            entity.Property(e => e.ReportState)
                .HasColumnType("enum('open','assigned','resolved','rejected')")
                .HasColumnName("report_state");
        });

        modelBuilder.Entity<XfReportComment>(entity =>
        {
            entity.HasKey(e => e.ReportCommentId).HasName("PRIMARY");

            entity
                .ToTable("xf_report_comment")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ReportId, e.CommentDate }, "report_id_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ReportCommentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("report_comment_id");
            entity.Property(e => e.CommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_date");
            entity.Property(e => e.IsReport)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_report");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.ReportId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("report_id");
            entity.Property(e => e.StateChange)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','open','assigned','resolved','rejected')")
                .HasColumnName("state_change");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfRmCategory>(entity =>
        {
            entity.HasKey(e => e.ResourceCategoryId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_category")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Lft, e.Rgt }, "lft_rgt");

            entity.HasIndex(e => new { e.ParentCategoryId, e.Lft }, "parent_category_id_lft");

            entity.Property(e => e.ResourceCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_category_id");
            entity.Property(e => e.AllowCommercialExternal)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_commercial_external");
            entity.Property(e => e.AllowExternal)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_external");
            entity.Property(e => e.AllowFileless)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_fileless");
            entity.Property(e => e.AllowLocal)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_local");
            entity.Property(e => e.AlwaysModerateCreate)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("always_moderate_create");
            entity.Property(e => e.AlwaysModerateUpdate)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("always_moderate_update");
            entity.Property(e => e.BreadcrumbData)
                .HasColumnType("blob")
                .HasColumnName("breadcrumb_data");
            entity.Property(e => e.Depth)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("depth");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.EnableSupportUrl)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enable_support_url");
            entity.Property(e => e.EnableVersioning)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enable_versioning");
            entity.Property(e => e.FeaturedCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("featured_count");
            entity.Property(e => e.FieldCache)
                .HasColumnType("mediumblob")
                .HasColumnName("field_cache");
            entity.Property(e => e.LastResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_resource_id");
            entity.Property(e => e.LastResourceTitle)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("last_resource_title");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_update");
            entity.Property(e => e.Lft)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("lft");
            entity.Property(e => e.MinTags)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_tags");
            entity.Property(e => e.ParentCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("parent_category_id");
            entity.Property(e => e.PrefixCache)
                .HasColumnType("mediumblob")
                .HasColumnName("prefix_cache");
            entity.Property(e => e.RequirePrefix)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("require_prefix");
            entity.Property(e => e.ResourceCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_count");
            entity.Property(e => e.ReviewFieldCache)
                .HasColumnType("mediumblob")
                .HasColumnName("review_field_cache");
            entity.Property(e => e.Rgt)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rgt");
            entity.Property(e => e.SvMaxPrefixes)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sv_max_prefixes");
            entity.Property(e => e.SvMinPrefixes)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sv_min_prefixes");
            entity.Property(e => e.SvThreadPrefixIds)
                .HasColumnType("mediumblob")
                .HasColumnName("sv_thread_prefix_ids");
            entity.Property(e => e.ThreadNodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_node_id");
            entity.Property(e => e.ThreadPrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_prefix_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.XfaRmmpAltDisplay)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_rmmp_alt_display");
            entity.Property(e => e.XfaRmmpConf)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_rmmp_conf");
            entity.Property(e => e.XfaRmmpPaymentData)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("xfa_rmmp_payment_data");
            entity.Property(e => e.XfaRmmpRestrictSupport)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_rmmp_restrict_support");
            entity.Property(e => e.XfaRmmpSalePercentage)
                .HasPrecision(10, 2)
                .HasColumnName("xfa_rmmp_sale_percentage");
            entity.Property(e => e.XfaRmmpSalePercentagePaypal)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("xfa_rmmp_sale_percentage_paypal");
            entity.Property(e => e.XfaRmmpTypes)
                .HasMaxLength(255)
                .HasDefaultValueSql("'a:4:{s:4:\"free\";s:1:\"1\";s:7:\"digital\";a:4:{s:6:\"active\";s:1:\"1\";s:7:\"renewal\";s:1:\"1\";s:11:\"restriction\";s:1:\"1\";s:12:\"url_required\";s:1:\"1\";}s:8:\"physical\";s:1:\"1\";s:7:\"service\";s:1:\"1\";}'")
                .HasColumnName("xfa_rmmp_types");
        });

        modelBuilder.Entity<XfRmCategoryField>(entity =>
        {
            entity.HasKey(e => new { e.FieldId, e.ResourceCategoryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_category_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ResourceCategoryId, "resource_category_id");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.ResourceCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_category_id");
        });

        modelBuilder.Entity<XfRmCategoryPrefix>(entity =>
        {
            entity.HasKey(e => new { e.ResourceCategoryId, e.PrefixId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_category_prefix")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PrefixId, "prefix_id");

            entity.Property(e => e.ResourceCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_category_id");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
        });

        modelBuilder.Entity<XfRmCategoryReviewField>(entity =>
        {
            entity.HasKey(e => new { e.FieldId, e.ResourceCategoryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_category_review_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ResourceCategoryId, "resource_category_id");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.ResourceCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_category_id");
        });

        modelBuilder.Entity<XfRmCategoryWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ResourceCategoryId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_category_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ResourceCategoryId, e.NotifyOn }, "node_id_notify_on");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ResourceCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_category_id");
            entity.Property(e => e.IncludeChildren)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("include_children");
            entity.Property(e => e.NotifyOn)
                .HasColumnType("enum('','resource','update')")
                .HasColumnName("notify_on");
            entity.Property(e => e.SendAlert)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_alert");
            entity.Property(e => e.SendEmail)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("send_email");
        });

        modelBuilder.Entity<XfRmResource>(entity =>
        {
            entity.HasKey(e => e.ResourceId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ResourceCategoryId, e.LastUpdate }, "category_last_update");

            entity.HasIndex(e => new { e.ResourceCategoryId, e.RatingWeighted }, "category_rating_weighted");

            entity.HasIndex(e => e.DiscussionThreadId, "discussion_thread_id");

            entity.HasIndex(e => e.LastUpdate, "last_update");

            entity.HasIndex(e => e.PrefixId, "prefix_id");

            entity.HasIndex(e => e.RatingWeighted, "rating_weighted");

            entity.HasIndex(e => new { e.UserId, e.LastUpdate }, "user_id_last_update");

            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.AltSupportUrl)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("alt_support_url");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("currency");
            entity.Property(e => e.CurrentVersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("current_version_id");
            entity.Property(e => e.CustomFields)
                .HasColumnType("mediumblob")
                .HasColumnName("custom_fields");
            entity.Property(e => e.DescriptionUpdateId)
                .HasComment("Points to the resource update that acts as the description for this resource")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("description_update_id");
            entity.Property(e => e.DiscussionThreadId)
                .HasComment("Points to an automatically-created thread for this resource")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("discussion_thread_id");
            entity.Property(e => e.DownloadCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("download_count");
            entity.Property(e => e.ExternalPurchaseUrl)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("external_purchase_url");
            entity.Property(e => e.ExternalUrl)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("external_url");
            entity.Property(e => e.IconDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("icon_date");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_update");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("price");
            entity.Property(e => e.RatingAvg)
                .HasColumnType("float unsigned")
                .HasColumnName("rating_avg");
            entity.Property(e => e.RatingCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_count");
            entity.Property(e => e.RatingSum)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_sum");
            entity.Property(e => e.RatingWeighted)
                .HasColumnType("float unsigned")
                .HasColumnName("rating_weighted");
            entity.Property(e => e.ResourceCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_category_id");
            entity.Property(e => e.ResourceDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_date");
            entity.Property(e => e.ResourceState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("resource_state");
            entity.Property(e => e.ResourceType)
                .HasMaxLength(25)
                .HasColumnName("resource_type");
            entity.Property(e => e.ReviewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("review_count");
            entity.Property(e => e.SvPrefixIds)
                .HasColumnType("mediumblob")
                .HasColumnName("sv_prefix_ids");
            entity.Property(e => e.TagLine)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("tag_line");
            entity.Property(e => e.Tags)
                .HasColumnType("mediumblob")
                .HasColumnName("tags");
            entity.Property(e => e.TeamMemberUserIds)
                .HasColumnType("blob")
                .HasColumnName("team_member_user_ids");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.UpdateCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("update_count");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.ViewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_count");
            entity.Property(e => e.XfaRmmpAcceptOther)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_rmmp_accept_other");
            entity.Property(e => e.XfaRmmpAmount)
                .HasPrecision(10, 2)
                .HasColumnName("xfa_rmmp_amount");
            entity.Property(e => e.XfaRmmpBaseAmount)
                .HasPrecision(10, 2)
                .HasColumnName("xfa_rmmp_base_amount");
            entity.Property(e => e.XfaRmmpCgv)
                .HasColumnType("mediumtext")
                .HasColumnName("xfa_rmmp_cgv");
            entity.Property(e => e.XfaRmmpCurrency)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("xfa_rmmp_currency");
            entity.Property(e => e.XfaRmmpDiscountId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_discount_id");
            entity.Property(e => e.XfaRmmpImgDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_img_date");
            entity.Property(e => e.XfaRmmpMaxQty)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_max_qty");
            entity.Property(e => e.XfaRmmpPaypal)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("xfa_rmmp_paypal");
            entity.Property(e => e.XfaRmmpPurchases)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_purchases");
            entity.Property(e => e.XfaRmmpSalesDisabled)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_rmmp_sales_disabled");
            entity.Property(e => e.XfaRmmpType)
                .HasDefaultValueSql("'none'")
                .HasColumnType("enum('none','digital','physical','service')")
                .HasColumnName("xfa_rmmp_type");
        });

        modelBuilder.Entity<XfRmResourceDownload>(entity =>
        {
            entity.HasKey(e => e.ResourceDownloadId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_download")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserId, e.ResourceId }, "user_resource");

            entity.HasIndex(e => new { e.ResourceVersionId, e.UserId }, "version_user").IsUnique();

            entity.Property(e => e.ResourceDownloadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_download_id");
            entity.Property(e => e.LastDownloadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_download_date");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.ResourceVersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_version_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfRmResourceFeature>(entity =>
        {
            entity.HasKey(e => e.ResourceId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_feature")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FeatureDate, "feature_date");

            entity.Property(e => e.ResourceId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.FeatureDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("feature_date");
        });

        modelBuilder.Entity<XfRmResourceField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DisplayGroup, e.DisplayOrder }, "display_group_order");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.DisplayGroup)
                .HasMaxLength(25)
                .HasDefaultValueSql("'above_info'")
                .HasColumnName("display_group");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DisplayTemplate)
                .HasColumnType("text")
                .HasColumnName("display_template");
            entity.Property(e => e.FieldChoices)
                .HasColumnType("blob")
                .HasColumnName("field_choices");
            entity.Property(e => e.FieldType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'textbox'")
                .HasColumnName("field_type");
            entity.Property(e => e.MatchParams)
                .HasColumnType("blob")
                .HasColumnName("match_params");
            entity.Property(e => e.MatchType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'none'")
                .HasColumnName("match_type");
            entity.Property(e => e.MaxLength)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.Required)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("required");
            entity.Property(e => e.WrapperTemplate)
                .HasColumnType("text")
                .HasColumnName("wrapper_template");
        });

        modelBuilder.Entity<XfRmResourceFieldValue>(entity =>
        {
            entity.HasKey(e => new { e.ResourceId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_resource_field_value")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldId, "field_id");

            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.FieldValue)
                .HasColumnType("mediumtext")
                .HasColumnName("field_value");
        });

        modelBuilder.Entity<XfRmResourcePrefix>(entity =>
        {
            entity.HasKey(e => e.PrefixId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_prefix")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.MaterializedOrder, "materialized_order");

            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
            entity.Property(e => e.AllowedUserGroupIds)
                .HasColumnType("blob")
                .HasColumnName("allowed_user_group_ids");
            entity.Property(e => e.CssClass)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("css_class");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.MaterializedOrder)
                .HasComment("Internally-set order, based on prefix_group.display_order, prefix.display_order")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("materialized_order");
            entity.Property(e => e.PrefixGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_group_id");
        });

        modelBuilder.Entity<XfRmResourcePrefixGroup>(entity =>
        {
            entity.HasKey(e => e.PrefixGroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_prefix_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PrefixGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_group_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
        });

        modelBuilder.Entity<XfRmResourceRating>(entity =>
        {
            entity.HasKey(e => e.ResourceRatingId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_rating")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AuthorResponseTeamUserId, "author_response_team_user_id");

            entity.HasIndex(e => new { e.CountRating, e.ResourceId }, "count_rating_resource_id");

            entity.HasIndex(e => e.RatingDate, "rating_date");

            entity.HasIndex(e => new { e.ResourceId, e.RatingDate }, "resource_id_rating_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => new { e.ResourceVersionId, e.UserId }, "version_user_id").IsUnique();

            entity.Property(e => e.ResourceRatingId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_rating_id");
            entity.Property(e => e.AuthorResponse)
                .HasColumnType("mediumtext")
                .HasColumnName("author_response");
            entity.Property(e => e.AuthorResponseTeamUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("author_response_team_user_id");
            entity.Property(e => e.AuthorResponseTeamUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("author_response_team_username");
            entity.Property(e => e.CountRating)
                .HasDefaultValueSql("'1'")
                .HasComment("Whether this counts towards the global resource rating.")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("count_rating");
            entity.Property(e => e.CustomFields)
                .HasColumnType("mediumblob")
                .HasColumnName("custom_fields");
            entity.Property(e => e.IsAnonymous)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_anonymous");
            entity.Property(e => e.IsReview)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_review");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.Rating)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rating");
            entity.Property(e => e.RatingDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_date");
            entity.Property(e => e.RatingState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','deleted')")
                .HasColumnName("rating_state");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.ResourceVersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_version_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.VersionString)
                .HasMaxLength(50)
                .HasColumnName("version_string");
            entity.Property(e => e.VoteCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_count");
            entity.Property(e => e.VoteScore)
                .HasColumnType("int(11)")
                .HasColumnName("vote_score");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
        });

        modelBuilder.Entity<XfRmResourceReviewField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_review_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DisplayGroup, e.DisplayOrder }, "display_group_order");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.DisplayGroup)
                .HasMaxLength(25)
                .HasDefaultValueSql("'above_info'")
                .HasColumnName("display_group");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DisplayTemplate)
                .HasColumnType("text")
                .HasColumnName("display_template");
            entity.Property(e => e.FieldChoices)
                .HasColumnType("blob")
                .HasColumnName("field_choices");
            entity.Property(e => e.FieldType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'textbox'")
                .HasColumnName("field_type");
            entity.Property(e => e.MatchParams)
                .HasColumnType("blob")
                .HasColumnName("match_params");
            entity.Property(e => e.MatchType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'none'")
                .HasColumnName("match_type");
            entity.Property(e => e.MaxLength)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.Required)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("required");
            entity.Property(e => e.WrapperTemplate)
                .HasColumnType("text")
                .HasColumnName("wrapper_template");
        });

        modelBuilder.Entity<XfRmResourceReviewFieldValue>(entity =>
        {
            entity.HasKey(e => new { e.ResourceRatingId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_resource_review_field_value")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldId, "field_id");

            entity.Property(e => e.ResourceRatingId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_rating_id");
            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.FieldValue)
                .HasColumnType("mediumtext")
                .HasColumnName("field_value");
        });

        modelBuilder.Entity<XfRmResourceTeamMember>(entity =>
        {
            entity.HasKey(e => new { e.ResourceId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_resource_team_member")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfRmResourceUpdate>(entity =>
        {
            entity.HasKey(e => e.ResourceUpdateId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_update")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ResourceId, e.PostDate }, "resource_id_post_date");

            entity.HasIndex(e => e.TeamUserId, "team_user_id");

            entity.Property(e => e.ResourceUpdateId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_update_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.EditCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_count");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastEditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_date");
            entity.Property(e => e.LastEditUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_user_id");
            entity.Property(e => e.Message)
                .HasComment("Supports BB code")
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.MessageState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("message_state");
            entity.Property(e => e.PostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_date");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.TeamUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("team_user_id");
            entity.Property(e => e.TeamUsername)
                .HasMaxLength(50)
                .HasColumnName("team_username");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasComment("Title field is optional, and is not used in the first post.")
                .HasColumnName("title");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfRmResourceVersion>(entity =>
        {
            entity.HasKey(e => e.ResourceVersionId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_version")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ResourceId, e.ReleaseDate }, "resource_id_release_date");

            entity.HasIndex(e => e.TeamUserId, "team_user_id");

            entity.Property(e => e.ResourceVersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_version_id");
            entity.Property(e => e.DownloadCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("download_count");
            entity.Property(e => e.DownloadUrl)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("download_url");
            entity.Property(e => e.FileCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("file_count");
            entity.Property(e => e.RatingCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_count");
            entity.Property(e => e.RatingSum)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rating_sum");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("release_date");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.TeamUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("team_user_id");
            entity.Property(e => e.TeamUsername)
                .HasMaxLength(50)
                .HasColumnName("team_username");
            entity.Property(e => e.VersionState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("version_state");
            entity.Property(e => e.VersionString)
                .HasMaxLength(50)
                .HasColumnName("version_string");
        });

        modelBuilder.Entity<XfRmResourceView>(entity =>
        {
            entity.HasKey(e => e.ResourceId).HasName("PRIMARY");

            entity
                .ToTable("xf_rm_resource_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ResourceId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.Total)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total");
        });

        modelBuilder.Entity<XfRmResourceWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ResourceId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_rm_resource_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ResourceId, e.EmailSubscribe }, "resource_id_email_subscribe");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.EmailSubscribe)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("email_subscribe");
        });

        modelBuilder.Entity<XfRoute>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PRIMARY");

            entity
                .ToTable("xf_route")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.RouteType, e.RoutePrefix, e.SubName }, "route_type").IsUnique();

            entity.Property(e => e.RouteId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("route_id");
            entity.Property(e => e.ActionPrefix)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("action_prefix");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.BuildClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("build_class");
            entity.Property(e => e.BuildMethod)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("build_method");
            entity.Property(e => e.Context)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("context");
            entity.Property(e => e.Controller)
                .HasMaxLength(255)
                .HasColumnName("controller");
            entity.Property(e => e.Format)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("format");
            entity.Property(e => e.RoutePrefix)
                .HasMaxLength(50)
                .HasColumnName("route_prefix");
            entity.Property(e => e.RouteType)
                .HasMaxLength(25)
                .HasColumnName("route_type");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .HasColumnName("sub_name");
        });

        modelBuilder.Entity<XfRouteFilter>(entity =>
        {
            entity.HasKey(e => e.RouteFilterId).HasName("PRIMARY");

            entity
                .ToTable("xf_route_filter")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Prefix, "route_type_prefix");

            entity.Property(e => e.RouteFilterId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("route_filter_id");
            entity.Property(e => e.Enabled)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enabled");
            entity.Property(e => e.FindRoute)
                .HasMaxLength(255)
                .HasColumnName("find_route");
            entity.Property(e => e.Prefix)
                .HasMaxLength(25)
                .HasColumnName("prefix");
            entity.Property(e => e.ReplaceRoute)
                .HasMaxLength(255)
                .HasColumnName("replace_route");
            entity.Property(e => e.UrlToRouteOnly)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("url_to_route_only");
        });

        modelBuilder.Entity<XfSearch>(entity =>
        {
            entity.HasKey(e => e.SearchId).HasName("PRIMARY");

            entity
                .ToTable("xf_search")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.QueryHash, "query_hash");

            entity.HasIndex(e => e.SearchDate, "search_date");

            entity.Property(e => e.SearchId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("search_id");
            entity.Property(e => e.QueryHash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("query_hash");
            entity.Property(e => e.ResultCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("result_count");
            entity.Property(e => e.SearchConstraints)
                .HasColumnType("mediumblob")
                .HasColumnName("search_constraints");
            entity.Property(e => e.SearchDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("search_date");
            entity.Property(e => e.SearchGrouping)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("search_grouping");
            entity.Property(e => e.SearchOrder)
                .HasMaxLength(50)
                .HasColumnName("search_order");
            entity.Property(e => e.SearchQuery)
                .HasMaxLength(200)
                .HasColumnName("search_query");
            entity.Property(e => e.SearchResults)
                .HasColumnType("mediumblob")
                .HasColumnName("search_results");
            entity.Property(e => e.SearchType)
                .HasMaxLength(25)
                .HasColumnName("search_type");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UserResults)
                .HasColumnType("mediumblob")
                .HasColumnName("user_results");
            entity.Property(e => e.Warnings)
                .HasColumnType("mediumblob")
                .HasColumnName("warnings");
        });

        modelBuilder.Entity<XfSearchForum>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_search_forum")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.CacheTtl)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_ttl");
            entity.Property(e => e.DiscussionCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("discussion_count");
            entity.Property(e => e.LastPostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_date");
            entity.Property(e => e.LastPostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_id");
            entity.Property(e => e.LastPostUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_user_id");
            entity.Property(e => e.LastPostUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("last_post_username");
            entity.Property(e => e.LastThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_thread_id");
            entity.Property(e => e.LastThreadPrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_thread_prefix_id");
            entity.Property(e => e.LastThreadTitle)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("last_thread_title");
            entity.Property(e => e.MaxResults)
                .HasDefaultValueSql("'200'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("max_results");
            entity.Property(e => e.MessageCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("message_count");
            entity.Property(e => e.SearchCriteria)
                .HasColumnType("mediumblob")
                .HasColumnName("search_criteria");
            entity.Property(e => e.SortDirection)
                .HasMaxLength(5)
                .HasDefaultValueSql("'desc'")
                .HasColumnName("sort_direction");
            entity.Property(e => e.SortOrder)
                .HasMaxLength(25)
                .HasDefaultValueSql("'last_post_date'")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<XfSearchForumCache>(entity =>
        {
            entity.HasKey(e => e.NodeId).HasName("PRIMARY");

            entity
                .ToTable("xf_search_forum_cache")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.CacheDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_date");
            entity.Property(e => e.Results)
                .HasColumnType("mediumblob")
                .HasColumnName("results");
        });

        modelBuilder.Entity<XfSearchForumCacheUser>(entity =>
        {
            entity.HasKey(e => new { e.NodeId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_search_forum_cache_user")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.CacheDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_date");
            entity.Property(e => e.Results)
                .HasColumnType("mediumblob")
                .HasColumnName("results");
        });

        modelBuilder.Entity<XfSearchIndex>(entity =>
        {
            entity.HasKey(e => new { e.ContentType, e.ContentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_search_index")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Title, e.Message, e.Metadata }, "title_message_metadata").HasAnnotation("MySql:FullTextIndex", true);

            entity.HasIndex(e => new { e.Title, e.Metadata }, "title_metadata").HasAnnotation("MySql:FullTextIndex", true);

            entity.HasIndex(e => new { e.UserId, e.ItemDate }, "user_id_item_date");

            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.DiscussionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("discussion_id");
            entity.Property(e => e.ItemDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("item_date");
            entity.Property(e => e.Message)
                .HasColumnType("mediumtext")
                .HasColumnName("message");
            entity.Property(e => e.Metadata)
                .HasColumnType("mediumtext")
                .HasColumnName("metadata");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity
                .ToTable("xf_session")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.SessionData)
                .HasColumnType("mediumblob")
                .HasColumnName("session_data");
        });

        modelBuilder.Entity<XfSessionActivity>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.UniqueKey })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_session_activity")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ViewDate, "view_date");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UniqueKey)
                .HasMaxLength(16)
                .HasColumnName("unique_key");
            entity.Property(e => e.ControllerAction)
                .HasMaxLength(75)
                .HasColumnName("controller_action");
            entity.Property(e => e.ControllerName)
                .HasMaxLength(100)
                .HasColumnName("controller_name");
            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Params)
                .HasMaxLength(100)
                .HasColumnName("params");
            entity.Property(e => e.RobotKey)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("robot_key");
            entity.Property(e => e.ViewDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_date");
            entity.Property(e => e.ViewState)
                .HasColumnType("enum('valid','error')")
                .HasColumnName("view_state");
        });

        modelBuilder.Entity<XfSessionAdmin>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity
                .ToTable("xf_session_admin")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.SessionData)
                .HasColumnType("mediumblob")
                .HasColumnName("session_data");
        });

        modelBuilder.Entity<XfSessionInstall>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity
                .ToTable("xf_session_install")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.SessionData)
                .HasColumnType("mediumblob")
                .HasColumnName("session_data");
        });

        modelBuilder.Entity<XfSiropuReferralContestsContest>(entity =>
        {
            entity.HasKey(e => e.ContestId).HasName("PRIMARY");

            entity
                .ToTable("xf_siropu_referral_contests_contest")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Enabled, "enabled");

            entity.HasIndex(e => e.EndDate, "end_date");

            entity.HasIndex(e => e.StartDate, "start_date");

            entity.HasIndex(e => e.WinnerUserId, "winner_user_id");

            entity.Property(e => e.ContestId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("contest_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enabled");
            entity.Property(e => e.EndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("end_date");
            entity.Property(e => e.MinimumPosts)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("minimum_posts");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Prizes)
                .HasColumnType("blob")
                .HasColumnName("prizes");
            entity.Property(e => e.ReferralCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("referral_count");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.WinnerUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("winner_user_id");
        });

        modelBuilder.Entity<XfSiropuReferralContestsInvitation>(entity =>
        {
            entity.HasKey(e => e.InvitationCode).HasName("PRIMARY");

            entity
                .ToTable("xf_siropu_referral_contests_invitation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpirationDate, "expiration_date");

            entity.HasIndex(e => e.RegisteredUserId, "registered_user_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.InvitationCode)
                .HasMaxLength(40)
                .HasColumnName("invitation_code");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiration_date");
            entity.Property(e => e.InvitationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("invitation_date");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Recipient)
                .HasMaxLength(60)
                .HasColumnName("recipient");
            entity.Property(e => e.RegisteredUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("registered_user_id");
            entity.Property(e => e.UserGroupIds)
                .HasColumnType("blob")
                .HasColumnName("user_group_ids");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfSiropuReferralContestsReferralTool>(entity =>
        {
            entity.HasKey(e => e.ToolId).HasName("PRIMARY");

            entity
                .ToTable("xf_siropu_referral_contests_referral_tool")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ToolId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tool_id");
            entity.Property(e => e.ClickCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("click_count");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Size)
                .HasMaxLength(10)
                .HasColumnName("size");
            entity.Property(e => e.TargetUrl)
                .HasMaxLength(255)
                .HasColumnName("target_url");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<XfSiropuReferralContestsReferrerLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity
                .ToTable("xf_siropu_referral_contests_referrer_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.LogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_id");
            entity.Property(e => e.Date)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfSiropuReferralContestsRewardType>(entity =>
        {
            entity.HasKey(e => e.RewardTypeId).HasName("PRIMARY");

            entity
                .ToTable("xf_siropu_referral_contests_reward_type")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.RewardTypeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reward_type_id");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .HasColumnName("currency");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<XfSiropuReferralContestsUnconfirmed>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_siropu_referral_contests_unconfirmed")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.InvitationCode, "invitation_code");

            entity.HasIndex(e => e.ReferrerId, "referrer_id");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.InvitationCode)
                .HasMaxLength(40)
                .HasColumnName("invitation_code");
            entity.Property(e => e.ReferrerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("referrer_id");
        });

        modelBuilder.Entity<XfSitemap>(entity =>
        {
            entity.HasKey(e => e.SitemapId).HasName("PRIMARY");

            entity
                .ToTable("xf_sitemap")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IsActive, "is_active");

            entity.Property(e => e.SitemapId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sitemap_id");
            entity.Property(e => e.CompleteDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("complete_date");
            entity.Property(e => e.EntryCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("entry_count");
            entity.Property(e => e.FileCount)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("file_count");
            entity.Property(e => e.IsActive)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_active");
            entity.Property(e => e.IsCompressed)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_compressed");
        });

        modelBuilder.Entity<XfSmilie>(entity =>
        {
            entity.HasKey(e => e.SmilieId).HasName("PRIMARY");

            entity
                .ToTable("xf_smilie")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.SmilieId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("smilie_id");
            entity.Property(e => e.DisplayInEditor)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("display_in_editor");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(200)
                .HasColumnName("image_url");
            entity.Property(e => e.ImageUrl2x)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("image_url_2x");
            entity.Property(e => e.SmilieCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("smilie_category_id");
            entity.Property(e => e.SmilieText)
                .HasColumnType("text")
                .HasColumnName("smilie_text");
            entity.Property(e => e.SpriteMode)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("sprite_mode");
            entity.Property(e => e.SpriteParams)
                .HasColumnType("blob")
                .HasColumnName("sprite_params");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfSmilieCategory>(entity =>
        {
            entity.HasKey(e => e.SmilieCategoryId).HasName("PRIMARY");

            entity
                .ToTable("xf_smilie_category")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.SmilieCategoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("smilie_category_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
        });

        modelBuilder.Entity<XfSpamCleanerLog>(entity =>
        {
            entity.HasKey(e => e.SpamCleanerLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_spam_cleaner_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ApplicationDate, "application_date");

            entity.HasIndex(e => e.ApplyingUserId, "applying_user_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.SpamCleanerLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("spam_cleaner_log_id");
            entity.Property(e => e.ApplicationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("application_date");
            entity.Property(e => e.ApplyingUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("applying_user_id");
            entity.Property(e => e.ApplyingUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("applying_username");
            entity.Property(e => e.Data)
                .HasComment("Serialized array containing log data for undo purposes")
                .HasColumnType("mediumblob")
                .HasColumnName("data");
            entity.Property(e => e.RestoredDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("restored_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<XfSpamTriggerLog>(entity =>
        {
            entity.HasKey(e => e.TriggerLogId).HasName("PRIMARY");

            entity
                .ToTable("xf_spam_trigger_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type").IsUnique();

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.Property(e => e.TriggerLogId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trigger_log_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.Details)
                .HasColumnType("mediumblob")
                .HasColumnName("details");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasColumnName("ip_address");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.RequestState)
                .HasColumnType("mediumblob")
                .HasColumnName("request_state");
            entity.Property(e => e.Result)
                .HasMaxLength(25)
                .HasColumnName("result");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfStatsDaily>(entity =>
        {
            entity.HasKey(e => new { e.StatsDate, e.StatsType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_stats_daily")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.StatsDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("stats_date");
            entity.Property(e => e.StatsType)
                .HasMaxLength(50)
                .HasColumnName("stats_type");
            entity.Property(e => e.Counter)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("counter");
        });

        modelBuilder.Entity<XfStyle>(entity =>
        {
            entity.HasKey(e => e.StyleId).HasName("PRIMARY");

            entity
                .ToTable("xf_style")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DesignerMode, "designer_mode").IsUnique();

            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.Assets)
                .HasColumnType("mediumblob")
                .HasColumnName("assets");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DesignerMode)
                .HasMaxLength(50)
                .HasColumnName("designer_mode");
            entity.Property(e => e.EffectiveAssets)
                .HasColumnType("mediumblob")
                .HasColumnName("effective_assets");
            entity.Property(e => e.LastModifiedDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_modified_date");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentList)
                .HasMaxLength(100)
                .HasComment("IDs of ancestor styles in order, eg: this,parent,grandparent,root")
                .HasColumnName("parent_list");
            entity.Property(e => e.Properties)
                .HasComment("Serialized array of materialized style properties for this style")
                .HasColumnType("mediumblob")
                .HasColumnName("properties");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.UserSelectable)
                .HasDefaultValueSql("'1'")
                .HasComment("Unselectable styles are unselectable by non-admin visitors")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("user_selectable");
        });

        modelBuilder.Entity<XfStyleProperty>(entity =>
        {
            entity.HasKey(e => e.PropertyId).HasName("PRIMARY");

            entity
                .ToTable("xf_style_property")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.StyleId, e.PropertyName }, "style_id_property_name").IsUnique();

            entity.Property(e => e.PropertyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("property_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.CssComponents)
                .HasColumnType("blob")
                .HasColumnName("css_components");
            entity.Property(e => e.DependsOn)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("depends_on");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .HasColumnName("group_name");
            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .HasColumnName("property_name");
            entity.Property(e => e.PropertyType)
                .HasMaxLength(25)
                .HasColumnName("property_type");
            entity.Property(e => e.PropertyValue)
                .HasColumnType("mediumblob")
                .HasColumnName("property_value");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.ValueGroup)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("value_group");
            entity.Property(e => e.ValueParameters)
                .HasColumnType("text")
                .HasColumnName("value_parameters");
            entity.Property(e => e.ValueType)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("value_type");
        });

        modelBuilder.Entity<XfStylePropertyGroup>(entity =>
        {
            entity.HasKey(e => e.PropertyGroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_style_property_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.GroupName, e.StyleId }, "group_name_style_id").IsUnique();

            entity.Property(e => e.PropertyGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("property_group_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .HasColumnName("group_name");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfStylePropertyMap>(entity =>
        {
            entity.HasKey(e => e.PropertyMapId).HasName("PRIMARY");

            entity
                .ToTable("xf_style_property_map")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ParentPropertyId, "parent_property_id");

            entity.HasIndex(e => new { e.StyleId, e.PropertyName }, "style_id").IsUnique();

            entity.Property(e => e.PropertyMapId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("property_map_id");
            entity.Property(e => e.ParentPropertyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("parent_property_id");
            entity.Property(e => e.PropertyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("property_id");
            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .HasColumnName("property_name");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
        });

        modelBuilder.Entity<XfSvDbtechShopItemPrefixLink>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.PrefixId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_sv_dbtech_shop_item_prefix_link")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ItemId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("item_id");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
        });

        modelBuilder.Entity<XfSvResourcePrefixLink>(entity =>
        {
            entity.HasKey(e => new { e.ResourceId, e.PrefixId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_sv_resource_prefix_link")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
        });

        modelBuilder.Entity<XfSvThreadPrefixLink>(entity =>
        {
            entity.HasKey(e => new { e.ThreadId, e.PrefixId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_sv_thread_prefix_link")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
        });

        modelBuilder.Entity<XfTag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PRIMARY");

            entity
                .ToTable("xf_tag")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Tag, "tag").IsUnique();

            entity.HasIndex(e => e.TagUrl, "tag_url").IsUnique();

            entity.HasIndex(e => e.UseCount, "use_count");

            entity.Property(e => e.TagId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tag_id");
            entity.Property(e => e.LastUseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_use_date");
            entity.Property(e => e.Permanent)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("permanent");
            entity.Property(e => e.Tag)
                .HasMaxLength(100)
                .HasColumnName("tag");
            entity.Property(e => e.TagUrl)
                .HasMaxLength(100)
                .HasColumnName("tag_url");
            entity.Property(e => e.UseCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("use_count");
        });

        modelBuilder.Entity<XfTagContent>(entity =>
        {
            entity.HasKey(e => e.TagContentId).HasName("PRIMARY");

            entity
                .ToTable("xf_tag_content")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.TagId }, "content_type_id_tag").IsUnique();

            entity.HasIndex(e => new { e.TagId, e.ContentDate }, "tag_id_content_date");

            entity.Property(e => e.TagContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tag_content_id");
            entity.Property(e => e.AddDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("add_date");
            entity.Property(e => e.AddUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("add_user_id");
            entity.Property(e => e.ContentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_date");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.TagId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tag_id");
            entity.Property(e => e.Visible)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<XfTagResultCache>(entity =>
        {
            entity.HasKey(e => e.ResultCacheId).HasName("PRIMARY");

            entity
                .ToTable("xf_tag_result_cache")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiration_date");

            entity.HasIndex(e => new { e.TagId, e.UserId }, "tag_id_user_id").IsUnique();

            entity.Property(e => e.ResultCacheId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("result_cache_id");
            entity.Property(e => e.CacheDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cache_date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.Results)
                .HasColumnType("mediumblob")
                .HasColumnName("results");
            entity.Property(e => e.TagId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tag_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity
                .ToTable("xf_template")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Type, e.Title, e.StyleId }, "type_title_style_id").IsUnique();

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("template_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.LastEditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_date");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.Template)
                .HasComment("User-editable HTML and template syntax")
                .HasColumnType("mediumtext")
                .HasColumnName("template");
            entity.Property(e => e.TemplateParsed)
                .HasColumnType("mediumblob")
                .HasColumnName("template_parsed");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
            entity.Property(e => e.VersionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("version_id");
            entity.Property(e => e.VersionString)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("version_string");
        });

        modelBuilder.Entity<XfTemplateHistory>(entity =>
        {
            entity.HasKey(e => e.TemplateHistoryId).HasName("PRIMARY");

            entity
                .ToTable("xf_template_history")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LogDate, "log_date");

            entity.HasIndex(e => e.Title, "title");

            entity.HasIndex(e => new { e.Type, e.Title, e.StyleId }, "type_title_style_id");

            entity.Property(e => e.TemplateHistoryId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("template_history_id");
            entity.Property(e => e.EditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_date");
            entity.Property(e => e.LogDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("log_date");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.Template)
                .HasColumnType("mediumtext")
                .HasColumnName("template");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<XfTemplateMap>(entity =>
        {
            entity.HasKey(e => e.TemplateMapId).HasName("PRIMARY");

            entity
                .ToTable("xf_template_map")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.StyleId, e.Type, e.Title }, "style_id_type_title").IsUnique();

            entity.HasIndex(e => e.TemplateId, "template_id");

            entity.HasIndex(e => new { e.Type, e.Title }, "type_title");

            entity.Property(e => e.TemplateMapId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("template_map_id");
            entity.Property(e => e.StyleId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.TemplateId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("template_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<XfTemplateModification>(entity =>
        {
            entity.HasKey(e => e.ModificationId).HasName("PRIMARY");

            entity
                .ToTable("xf_template_modification")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AddonId, "addon_id");

            entity.HasIndex(e => e.ModificationKey, "modification_key").IsUnique();

            entity.HasIndex(e => new { e.Template, e.ExecutionOrder }, "template_order");

            entity.Property(e => e.ModificationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("modification_id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasColumnName("action");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Enabled)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("enabled");
            entity.Property(e => e.ExecutionOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("execution_order");
            entity.Property(e => e.Find)
                .HasColumnType("text")
                .HasColumnName("find");
            entity.Property(e => e.ModificationKey)
                .HasMaxLength(50)
                .HasColumnName("modification_key");
            entity.Property(e => e.Replace)
                .HasColumnType("text")
                .HasColumnName("replace");
            entity.Property(e => e.Template)
                .HasMaxLength(100)
                .HasColumnName("template");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<XfTemplateModificationLog>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.ModificationId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_template_modification_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ModificationId, "modification_id");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("template_id");
            entity.Property(e => e.ModificationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("modification_id");
            entity.Property(e => e.ApplyCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("apply_count");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasColumnName("status");
        });

        modelBuilder.Entity<XfTemplatePhrase>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.PhraseTitle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_template_phrase")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PhraseTitle, "phrase_title");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("template_id");
            entity.Property(e => e.PhraseTitle)
                .HasMaxLength(100)
                .HasColumnName("phrase_title");
        });

        modelBuilder.Entity<XfTfaAttempt>(entity =>
        {
            entity.HasKey(e => e.AttemptId).HasName("PRIMARY");

            entity
                .ToTable("xf_tfa_attempt")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.AttemptDate, "attempt_date");

            entity.HasIndex(e => new { e.UserId, e.AttemptDate }, "user_id_attempt_date");

            entity.Property(e => e.AttemptId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attempt_id");
            entity.Property(e => e.AttemptDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attempt_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfTfaProvider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PRIMARY");

            entity
                .ToTable("xf_tfa_provider")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.Options)
                .HasColumnType("blob")
                .HasColumnName("options");
            entity.Property(e => e.Priority)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("priority");
            entity.Property(e => e.ProviderClass)
                .HasMaxLength(100)
                .HasColumnName("provider_class");
        });

        modelBuilder.Entity<XfThDonateCampaign>(entity =>
        {
            entity.HasKey(e => e.CampaignId).HasName("PRIMARY");

            entity
                .ToTable("xf_th_donate_campaign")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.CampaignId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("active");
            entity.Property(e => e.AllowAnonymous)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("allow_anonymous");
            entity.Property(e => e.AllowComments)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("allow_comments");
            entity.Property(e => e.AllowCustom)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("allow_custom");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.CoverDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cover_date");
            entity.Property(e => e.Currency)
                .HasMaxLength(20)
                .HasColumnName("currency");
            entity.Property(e => e.CurrentProgress)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("current_progress");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DonationHideAge)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("donation_hide_age");
            entity.Property(e => e.DonationsRecur)
                .HasColumnType("tinyint(4)")
                .HasColumnName("donations_recur");
            entity.Property(e => e.DonationsRecurByDefault)
                .HasColumnType("tinyint(4)")
                .HasColumnName("donations_recur_by_default");
            entity.Property(e => e.EndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("end_date");
            entity.Property(e => e.FreeComment)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("free_comment");
            entity.Property(e => e.Goal)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("goal");
            entity.Property(e => e.HideAmounts)
                .HasColumnType("tinyint(4)")
                .HasColumnName("hide_amounts");
            entity.Property(e => e.IconDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("icon_date");
            entity.Property(e => e.LastCommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_date");
            entity.Property(e => e.LimitToGoal)
                .HasColumnType("tinyint(4)")
                .HasColumnName("limit_to_goal");
            entity.Property(e => e.LockWhenComplete)
                .HasColumnType("tinyint(4)")
                .HasColumnName("lock_when_complete");
            entity.Property(e => e.MilestoneId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("milestone_id");
            entity.Property(e => e.MinDonation)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("min_donation");
            entity.Property(e => e.PaymentProfileIds)
                .HasMaxLength(255)
                .HasColumnName("payment_profile_ids");
            entity.Property(e => e.PresetAmounts)
                .HasColumnType("blob")
                .HasColumnName("preset_amounts");
            entity.Property(e => e.ProgressResetDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("progress_reset_date");
            entity.Property(e => e.ProgressStartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("progress_start_date");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.Reset)
                .HasColumnType("blob")
                .HasColumnName("reset");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.TagLine)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("tag_line");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.TotalProgress)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("total_progress");
        });

        modelBuilder.Entity<XfThDonateCampaignUser>(entity =>
        {
            entity.HasKey(e => e.CampaignUserId).HasName("PRIMARY");

            entity
                .ToTable("xf_th_donate_campaign_user")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.CampaignId, e.UserId }, "campaign_id_user_id");

            entity.Property(e => e.CampaignUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_user_id");
            entity.Property(e => e.CampaignId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_id");
            entity.Property(e => e.TotalAnonymousDonation)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("total_anonymous_donation");
            entity.Property(e => e.TotalDonation)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("total_donation");
            entity.Property(e => e.TotalPublicDonation)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("total_public_donation");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfThDonateCampaignWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CampaignId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_th_donate_campaign_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.CampaignId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_id");
        });

        modelBuilder.Entity<XfThDonateComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity
                .ToTable("xf_th_donate_comment")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.CommentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_id");
            entity.Property(e => e.AttachCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("attach_count");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(50)
                .HasColumnName("content_type");
            entity.Property(e => e.EditCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("edit_count");
            entity.Property(e => e.EmbedMetadata)
                .HasColumnType("blob")
                .HasColumnName("embed_metadata");
            entity.Property(e => e.IpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.LastEditDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_date");
            entity.Property(e => e.LastEditUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_edit_user_id");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.MessageState)
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("message_state");
            entity.Property(e => e.Position)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("position");
            entity.Property(e => e.PostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_date");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.WarningMessage)
                .HasColumnType("text")
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<XfThDonateDonation>(entity =>
        {
            entity.HasKey(e => e.DonationId).HasName("PRIMARY");

            entity
                .ToTable("xf_th_donate_donation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Anonymous, "anonymous");

            entity.HasIndex(e => e.DiscloseAmount, "disclose_amount");

            entity.HasIndex(e => e.DonationDate, "donation_date");

            entity.Property(e => e.DonationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("donation_id");
            entity.Property(e => e.Amount)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("amount");
            entity.Property(e => e.Anonymous)
                .HasColumnType("tinyint(4)")
                .HasColumnName("anonymous");
            entity.Property(e => e.CampaignId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_id");
            entity.Property(e => e.CommentCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("comment_count");
            entity.Property(e => e.DiscloseAmount)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("disclose_amount");
            entity.Property(e => e.DonationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("donation_date");
            entity.Property(e => e.LastCommentDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_comment_date");
            entity.Property(e => e.LatestCommentIds)
                .HasColumnType("blob")
                .HasColumnName("latest_comment_ids");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Position)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("position");
            entity.Property(e => e.PurchaseRequestKey)
                .HasMaxLength(32)
                .HasColumnName("purchase_request_key");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.ReactionUsers)
                .HasColumnType("blob")
                .HasColumnName("reaction_users");
            entity.Property(e => e.Reactions)
                .HasColumnType("blob")
                .HasColumnName("reactions");
            entity.Property(e => e.Recurring)
                .HasColumnType("tinyint(4)")
                .HasColumnName("recurring");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfThDonateMilestone>(entity =>
        {
            entity.HasKey(e => e.MilestoneId).HasName("PRIMARY");

            entity
                .ToTable("xf_th_donate_milestone")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.MilestoneId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("milestone_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("active");
            entity.Property(e => e.AlertAdministrators)
                .HasColumnType("tinyint(4)")
                .HasColumnName("alert_administrators");
            entity.Property(e => e.AlertSent)
                .HasColumnType("tinyint(4)")
                .HasColumnName("alert_sent");
            entity.Property(e => e.Amount)
                .HasColumnType("float(20,2) unsigned")
                .HasColumnName("amount");
            entity.Property(e => e.CampaignId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Percent)
                .HasColumnType("tinyint(4)")
                .HasColumnName("percent");
            entity.Property(e => e.ProgressBarColor)
                .HasMaxLength(250)
                .HasColumnName("progress_bar_color");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfThread>(entity =>
        {
            entity.HasKey(e => e.ThreadId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastPostDate, "last_post_date");

            entity.HasIndex(e => e.LastPostUserId, "last_post_user_id");

            entity.HasIndex(e => new { e.NodeId, e.LastPostDate }, "node_id_last_post_date");

            entity.HasIndex(e => new { e.NodeId, e.Sticky, e.DiscussionState, e.LastPostDate }, "node_id_sticky_state_last_post");

            entity.HasIndex(e => new { e.NodeId, e.Sticky, e.DiscussionState, e.VoteScore }, "node_id_sticky_state_vote_score");

            entity.HasIndex(e => e.PostDate, "post_date");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.BriviumRatingCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("brivium_rating_count");
            entity.Property(e => e.BriviumRatingSum)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("brivium_rating_sum");
            entity.Property(e => e.BriviumRatingWeighted).HasColumnName("brivium_rating_weighted");
            entity.Property(e => e.BriviumReviewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("brivium_review_count");
            entity.Property(e => e.CustomFields)
                .HasColumnType("mediumblob")
                .HasColumnName("custom_fields");
            entity.Property(e => e.DiscussionOpen)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("discussion_open");
            entity.Property(e => e.DiscussionState)
                .HasDefaultValueSql("'visible'")
                .HasColumnType("enum('visible','moderated','deleted')")
                .HasColumnName("discussion_state");
            entity.Property(e => e.DiscussionType)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("discussion_type");
            entity.Property(e => e.FirstPostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("first_post_id");
            entity.Property(e => e.FirstPostReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("first_post_reaction_score");
            entity.Property(e => e.FirstPostReactions)
                .HasColumnType("blob")
                .HasColumnName("first_post_reactions");
            entity.Property(e => e.LastPostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_date");
            entity.Property(e => e.LastPostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_id");
            entity.Property(e => e.LastPostUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_post_user_id");
            entity.Property(e => e.LastPostUsername)
                .HasMaxLength(50)
                .HasColumnName("last_post_username");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("node_id");
            entity.Property(e => e.PostDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_date");
            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
            entity.Property(e => e.ReplyCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reply_count");
            entity.Property(e => e.Sticky)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("sticky");
            entity.Property(e => e.SvPrefixIds)
                .HasColumnType("mediumblob")
                .HasColumnName("sv_prefix_ids");
            entity.Property(e => e.Tags)
                .HasColumnType("mediumblob")
                .HasColumnName("tags");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.TypeData)
                .HasColumnType("mediumblob")
                .HasColumnName("type_data");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.ViewCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_count");
            entity.Property(e => e.VoteCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("vote_count");
            entity.Property(e => e.VoteScore)
                .HasColumnType("int(11)")
                .HasColumnName("vote_score");
        });

        modelBuilder.Entity<XfThreadField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DisplayGroup, e.DisplayOrder }, "display_group_order");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.DisplayGroup)
                .HasMaxLength(25)
                .HasDefaultValueSql("'before'")
                .HasColumnName("display_group");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DisplayTemplate)
                .HasColumnType("text")
                .HasColumnName("display_template");
            entity.Property(e => e.EditableUserGroupIds)
                .HasColumnType("blob")
                .HasColumnName("editable_user_group_ids");
            entity.Property(e => e.FieldChoices)
                .HasColumnType("blob")
                .HasColumnName("field_choices");
            entity.Property(e => e.FieldType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'textbox'")
                .HasColumnName("field_type");
            entity.Property(e => e.MatchParams)
                .HasColumnType("blob")
                .HasColumnName("match_params");
            entity.Property(e => e.MatchType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'none'")
                .HasColumnName("match_type");
            entity.Property(e => e.MaxLength)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.Required)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("required");
            entity.Property(e => e.WrapperTemplate)
                .HasColumnType("text")
                .HasColumnName("wrapper_template");
        });

        modelBuilder.Entity<XfThreadFieldValue>(entity =>
        {
            entity.HasKey(e => new { e.ThreadId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_thread_field_value")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldId, "field_id");

            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.FieldValue)
                .HasColumnType("mediumtext")
                .HasColumnName("field_value");
        });

        modelBuilder.Entity<XfThreadPrefix>(entity =>
        {
            entity.HasKey(e => e.PrefixId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_prefix")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.MaterializedOrder, "materialized_order");

            entity.Property(e => e.PrefixId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_id");
            entity.Property(e => e.AllowedUserGroupIds)
                .HasColumnType("blob")
                .HasColumnName("allowed_user_group_ids");
            entity.Property(e => e.CssClass)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("css_class");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.MaterializedOrder)
                .HasComment("Internally-set order, based on prefix_group.display_order, prefix.display_order")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("materialized_order");
            entity.Property(e => e.PrefixGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_group_id");
        });

        modelBuilder.Entity<XfThreadPrefixGroup>(entity =>
        {
            entity.HasKey(e => e.PrefixGroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_prefix_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PrefixGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prefix_group_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
        });

        modelBuilder.Entity<XfThreadPrompt>(entity =>
        {
            entity.HasKey(e => e.PromptId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_prompt")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.MaterializedOrder, "materialized_order");

            entity.Property(e => e.PromptId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prompt_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.MaterializedOrder)
                .HasComment("Internally-set order, based on prompt_group.display_order, prompt.display_order")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("materialized_order");
            entity.Property(e => e.PromptGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prompt_group_id");
        });

        modelBuilder.Entity<XfThreadPromptGroup>(entity =>
        {
            entity.HasKey(e => e.PromptGroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_prompt_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PromptGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prompt_group_id");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
        });

        modelBuilder.Entity<XfThreadQuestion>(entity =>
        {
            entity.HasKey(e => e.ThreadId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_question")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ThreadId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.SolutionPostId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("solution_post_id");
            entity.Property(e => e.SolutionUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("solution_user_id");
        });

        modelBuilder.Entity<XfThreadRead>(entity =>
        {
            entity.HasKey(e => e.ThreadReadId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_read")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ThreadId, "thread_id");

            entity.HasIndex(e => e.ThreadReadDate, "thread_read_date");

            entity.HasIndex(e => new { e.UserId, e.ThreadId }, "user_id_thread_id").IsUnique();

            entity.Property(e => e.ThreadReadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_read_id");
            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.ThreadReadDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_read_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfThreadRedirect>(entity =>
        {
            entity.HasKey(e => e.ThreadId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_redirect")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.RedirectKey, e.ExpiryDate }, "redirect_key_expiry_date");

            entity.Property(e => e.ThreadId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.RedirectKey)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("redirect_key");
            entity.Property(e => e.TargetUrl)
                .HasColumnType("text")
                .HasColumnName("target_url");
        });

        modelBuilder.Entity<XfThreadReplyBan>(entity =>
        {
            entity.HasKey(e => e.ThreadReplyBanId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_reply_ban")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.HasIndex(e => new { e.ThreadId, e.UserId }, "thread_id").IsUnique();

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ThreadReplyBanId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_reply_ban_id");
            entity.Property(e => e.BanDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ban_date");
            entity.Property(e => e.BanUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ban_user_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("reason");
            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfThreadType>(entity =>
        {
            entity.HasKey(e => e.ThreadTypeId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_type")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ThreadTypeId)
                .HasMaxLength(50)
                .HasColumnName("thread_type_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.HandlerClass)
                .HasMaxLength(100)
                .HasColumnName("handler_class");
        });

        modelBuilder.Entity<XfThreadUserPost>(entity =>
        {
            entity.HasKey(e => new { e.ThreadId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_thread_user_post")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.PostCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("post_count");
        });

        modelBuilder.Entity<XfThreadView>(entity =>
        {
            entity.HasKey(e => e.ThreadId).HasName("PRIMARY");

            entity
                .ToTable("xf_thread_view")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.ThreadId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.Total)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total");
        });

        modelBuilder.Entity<XfThreadWatch>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ThreadId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_thread_watch")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ThreadId, e.EmailSubscribe }, "thread_id_email_subscribe");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ThreadId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thread_id");
            entity.Property(e => e.EmailSubscribe)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("email_subscribe");
        });

        modelBuilder.Entity<XfTrophy>(entity =>
        {
            entity.HasKey(e => e.TrophyId).HasName("PRIMARY");

            entity
                .ToTable("xf_trophy")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.TrophyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trophy_id");
            entity.Property(e => e.TrophyPoints)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trophy_points");
            entity.Property(e => e.UserCriteria)
                .HasColumnType("mediumblob")
                .HasColumnName("user_criteria");
        });

        modelBuilder.Entity<XfUnfurlResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PRIMARY");

            entity
                .ToTable("xf_unfurl_result")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.LastRequestDate, "last_request_date");

            entity.HasIndex(e => e.UrlHash, "url_hash").IsUnique();

            entity.Property(e => e.ResultId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("result_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ErrorCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("error_count");
            entity.Property(e => e.FaviconUrl)
                .HasColumnType("text")
                .HasColumnName("favicon_url");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("text")
                .HasColumnName("image_url");
            entity.Property(e => e.LastRequestDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_request_date");
            entity.Property(e => e.Pending)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pending");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.UrlHash)
                .HasMaxLength(32)
                .HasColumnName("url_hash");
        });

        modelBuilder.Entity<XfUpgradeCheck>(entity =>
        {
            entity.HasKey(e => e.CheckId).HasName("PRIMARY");

            entity
                .ToTable("xf_upgrade_check")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CheckDate, "check_date");

            entity.Property(e => e.CheckId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("check_id");
            entity.Property(e => e.AvailableUpdates)
                .HasColumnType("blob")
                .HasColumnName("available_updates");
            entity.Property(e => e.BoardUrlValid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("board_url_valid");
            entity.Property(e => e.BrandingValid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("branding_valid");
            entity.Property(e => e.CheckDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("check_date");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(50)
                .HasColumnName("error_code");
            entity.Property(e => e.InstallableAddOns)
                .HasColumnType("blob")
                .HasColumnName("installable_add_ons");
            entity.Property(e => e.InvalidAddOns)
                .HasColumnType("blob")
                .HasColumnName("invalid_add_ons");
            entity.Property(e => e.LastAgreementDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_agreement_date");
            entity.Property(e => e.LastAgreementUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_agreement_update");
            entity.Property(e => e.LicenseExpired)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("license_expired");
            entity.Property(e => e.ResponseData)
                .HasColumnType("mediumblob")
                .HasColumnName("response_data");
        });

        modelBuilder.Entity<XfUpgradeJob>(entity =>
        {
            entity.HasKey(e => e.UniqueKey).HasName("PRIMARY");

            entity
                .ToTable("xf_upgrade_job")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Immediate, "immediate");

            entity.Property(e => e.UniqueKey)
                .HasMaxLength(50)
                .HasColumnName("unique_key");
            entity.Property(e => e.ExecuteClass)
                .HasMaxLength(100)
                .HasColumnName("execute_class");
            entity.Property(e => e.ExecuteData)
                .HasColumnType("mediumblob")
                .HasColumnName("execute_data");
            entity.Property(e => e.Immediate)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("immediate");
        });

        modelBuilder.Entity<XfUpgradeLog>(entity =>
        {
            entity.HasKey(e => e.VersionId).HasName("PRIMARY");

            entity
                .ToTable("xf_upgrade_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.VersionId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("version_id");
            entity.Property(e => e.CompletionDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("completion_date");
            entity.Property(e => e.LastStep)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("last_step");
            entity.Property(e => e.LogType)
                .HasDefaultValueSql("'upgrade'")
                .HasColumnType("enum('install','upgrade')")
                .HasColumnName("log_type");
        });

        modelBuilder.Entity<XfUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.LastActivity, "last_activity");

            entity.HasIndex(e => e.LastSummaryEmailDate, "last_summary_email_date");

            entity.HasIndex(e => e.MessageCount, "message_count");

            entity.HasIndex(e => e.PermissionCombinationId, "permission_combination_id");

            entity.HasIndex(e => e.QuestionSolutionCount, "question_solution_count");

            entity.HasIndex(e => e.ReactionScore, "reaction_score");

            entity.HasIndex(e => e.SiropuReferralCount, "referral_count");

            entity.HasIndex(e => e.SiropuReferrerId, "referrer_id");

            entity.HasIndex(e => e.RegisterDate, "register_date");

            entity.HasIndex(e => e.XfrmResourceCount, "resource_count");

            entity.HasIndex(e => new { e.IsStaff, e.Username }, "staff_username");

            entity.HasIndex(e => e.TrophyPoints, "trophy_points");

            entity.HasIndex(e => e.UserState, "user_state");

            entity.HasIndex(e => e.Username, "username").IsUnique();

            entity.HasIndex(e => e.VoteScore, "vote_score");

            entity.HasIndex(e => e.XfmgAlbumCount, "xengallery_album_count");

            entity.HasIndex(e => e.XfmgMediaCount, "xengallery_media_count");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ActivityVisible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("activity_visible");
            entity.Property(e => e.AlertsUnread)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("alerts_unread");
            entity.Property(e => e.AlertsUnviewed)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("alerts_unviewed");
            entity.Property(e => e.AvatarDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("avatar_date");
            entity.Property(e => e.AvatarHeight)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("avatar_height");
            entity.Property(e => e.AvatarHighdpi)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("avatar_highdpi");
            entity.Property(e => e.AvatarWidth)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("avatar_width");
            entity.Property(e => e.BratrBeDonatedRatings)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bratr_be_donated_ratings");
            entity.Property(e => e.BratrRatings)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bratr_ratings");
            entity.Property(e => e.BratrReceiveRatingCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bratr_receive_rating_count");
            entity.Property(e => e.BratrReceiveRatings)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bratr_receive_ratings");
            entity.Property(e => e.ConversationsUnread)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("conversations_unread");
            entity.Property(e => e.CustomTitle)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("custom_title");
            entity.Property(e => e.DbtechCreditsByn).HasColumnName("dbtech_credits_byn");
            entity.Property(e => e.DbtechCreditsLastdaily)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dbtech_credits_lastdaily");
            entity.Property(e => e.DbtechCreditsLastinterest)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dbtech_credits_lastinterest");
            entity.Property(e => e.DbtechCreditsLastpaycheck)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dbtech_credits_lastpaycheck");
            entity.Property(e => e.DbtechCreditsLasttaxation)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dbtech_credits_lasttaxation");
            entity.Property(e => e.DbtechCreditsRub).HasColumnName("dbtech_credits_rub");
            entity.Property(e => e.DbtechCreditsUsd).HasColumnName("dbtech_credits_usd");
            entity.Property(e => e.DisplayStyleGroupId)
                .HasComment("User group ID that provides user styling")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_style_group_id");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.Gravatar)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasComment("If specified, this is an email address corresponding to the user's 'Gravatar'")
                .HasColumnName("gravatar");
            entity.Property(e => e.IsAdmin)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_admin");
            entity.Property(e => e.IsBanned)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_banned");
            entity.Property(e => e.IsModerator)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_moderator");
            entity.Property(e => e.IsStaff)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_staff");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.LastActivity)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_activity");
            entity.Property(e => e.LastSummaryEmailDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_summary_email_date");
            entity.Property(e => e.MadLastCheck)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mad_last_check");
            entity.Property(e => e.MessageCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("message_count");
            entity.Property(e => e.PermissionCombinationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("permission_combination_id");
            entity.Property(e => e.PrivacyPolicyAccepted)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("privacy_policy_accepted");
            entity.Property(e => e.QuestionSolutionCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("question_solution_count");
            entity.Property(e => e.ReactionScore)
                .HasColumnType("int(11)")
                .HasColumnName("reaction_score");
            entity.Property(e => e.RegisterDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("register_date");
            entity.Property(e => e.SecondaryGroupIds)
                .HasMaxLength(255)
                .HasColumnName("secondary_group_ids");
            entity.Property(e => e.SecretKey)
                .HasMaxLength(32)
                .HasColumnName("secret_key");
            entity.Property(e => e.SecurityLock)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','change','reset')")
                .HasColumnName("security_lock");
            entity.Property(e => e.SiropuReferralCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("siropu_referral_count");
            entity.Property(e => e.SiropuReferrerCredit)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("siropu_referrer_credit");
            entity.Property(e => e.SiropuReferrerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("siropu_referrer_id");
            entity.Property(e => e.StyleId)
                .HasComment("0 = use system default")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("style_id");
            entity.Property(e => e.TermsAccepted)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("terms_accepted");
            entity.Property(e => e.ThdonateNumAnonymousDonation)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thdonate_num_anonymous_donation");
            entity.Property(e => e.ThdonateNumDonation)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thdonate_num_donation");
            entity.Property(e => e.ThdonateNumPublicDonation)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("thdonate_num_public_donation");
            entity.Property(e => e.ThdonateTotalAnonymousDonation)
                .HasColumnType("float(20,2)")
                .HasColumnName("thdonate_total_anonymous_donation");
            entity.Property(e => e.ThdonateTotalDonation)
                .HasColumnType("float(20,2)")
                .HasColumnName("thdonate_total_donation");
            entity.Property(e => e.ThdonateTotalPublicDonation)
                .HasColumnType("float(20,2)")
                .HasColumnName("thdonate_total_public_donation");
            entity.Property(e => e.Timezone)
                .HasMaxLength(50)
                .HasComment("Example: 'Europe/London'")
                .HasColumnName("timezone");
            entity.Property(e => e.TrophyPoints)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trophy_points");
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_group_id");
            entity.Property(e => e.UserState)
                .HasDefaultValueSql("'valid'")
                .HasColumnType("enum('valid','email_confirm','email_confirm_edit','moderated','email_bounce','rejected','disabled')")
                .HasColumnName("user_state");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.UsernameDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("username_date");
            entity.Property(e => e.UsernameDateVisible)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("username_date_visible");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasComment("Show browsing activity to others")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("visible");
            entity.Property(e => e.VoteScore)
                .HasColumnType("int(11)")
                .HasColumnName("vote_score");
            entity.Property(e => e.WarningPoints)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_points");
            entity.Property(e => e.XfaRmmpUserBlocked)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("xfa_rmmp_user_blocked");
            entity.Property(e => e.XfaRmmpUserCgv)
                .HasColumnType("mediumtext")
                .HasColumnName("xfa_rmmp_user_cgv");
            entity.Property(e => e.XfaRmmpUserPaypal)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("xfa_rmmp_user_paypal");
            entity.Property(e => e.XfaRmmpUserPurchases)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_user_purchases");
            entity.Property(e => e.XfaRmmpUserSales)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfa_rmmp_user_sales");
            entity.Property(e => e.XfaRmmpUserSalesAmount)
                .HasPrecision(10, 2)
                .HasColumnName("xfa_rmmp_user_sales_amount");
            entity.Property(e => e.XfmgAlbumCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfmg_album_count");
            entity.Property(e => e.XfmgMediaCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfmg_media_count");
            entity.Property(e => e.XfmgMediaQuota)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfmg_media_quota");
            entity.Property(e => e.XfrmResourceCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("xfrm_resource_count");
        });

        modelBuilder.Entity<XfUserAlert>(entity =>
        {
            entity.HasKey(e => e.AlertId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_alert")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.AlertedUserId, e.EventDate }, "alertedUserId_eventDate");

            entity.HasIndex(e => new { e.AlertedUserId, e.ContentType, e.ContentId }, "alerted_user_id_content_type_content_id");

            entity.HasIndex(e => new { e.AlertedUserId, e.ReadDate }, "alerted_user_id_read_date");

            entity.HasIndex(e => new { e.AlertedUserId, e.ViewDate }, "alerted_user_id_view_date");

            entity.HasIndex(e => new { e.ContentType, e.ContentId, e.UserId }, "content_type_content_id_user_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.HasIndex(e => new { e.ViewDate, e.EventDate }, "viewDate_eventDate");

            entity.Property(e => e.AlertId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("alert_id");
            entity.Property(e => e.Action)
                .HasMaxLength(30)
                .HasComment("eg: edit")
                .HasColumnName("action");
            entity.Property(e => e.AlertedUserId)
                .HasComment("User being alerted")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("alerted_user_id");
            entity.Property(e => e.AutoRead)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("auto_read");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasComment("eg: trophy")
                .HasColumnName("content_type");
            entity.Property(e => e.DependsOnAddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("depends_on_addon_id");
            entity.Property(e => e.EventDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("event_date");
            entity.Property(e => e.ExtraData)
                .HasComment("Serialized. Stores any extra data relevant to the alert")
                .HasColumnType("mediumblob")
                .HasColumnName("extra_data");
            entity.Property(e => e.ReadDate)
                .HasComment("Time when this was read by the alerted user")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("read_date");
            entity.Property(e => e.UserId)
                .HasComment("User who did the action that caused the alert")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasComment("Corresponds to user_id")
                .HasColumnName("username");
            entity.Property(e => e.ViewDate)
                .HasComment("Time when this was viewed by the alerted user")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("view_date");
        });

        modelBuilder.Entity<XfUserAlertOptout>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Alert })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_alert_optout")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Alert)
                .HasMaxLength(50)
                .HasColumnName("alert");
        });

        modelBuilder.Entity<XfUserAuthenticate>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_authenticate")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Data)
                .HasColumnType("mediumblob")
                .HasColumnName("data");
            entity.Property(e => e.SchemeClass)
                .HasMaxLength(100)
                .HasColumnName("scheme_class");
        });

        modelBuilder.Entity<XfUserBan>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_ban")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.BanDate, "ban_date");

            entity.HasIndex(e => e.EndDate, "end_date");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.BanDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ban_date");
            entity.Property(e => e.BanUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ban_user_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("end_date");
            entity.Property(e => e.Triggered)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("triggered");
            entity.Property(e => e.UserReason)
                .HasMaxLength(255)
                .HasColumnName("user_reason");
        });

        modelBuilder.Entity<XfUserChangeTemp>(entity =>
        {
            entity.HasKey(e => e.UserChangeTempId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_change_temp")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ChangeKey, "change_key");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.HasIndex(e => new { e.UserId, e.ChangeKey }, "user_id").IsUnique();

            entity.Property(e => e.UserChangeTempId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_change_temp_id");
            entity.Property(e => e.ActionModifier)
                .HasMaxLength(255)
                .HasColumnName("action_modifier");
            entity.Property(e => e.ActionType)
                .HasMaxLength(50)
                .HasColumnName("action_type");
            entity.Property(e => e.ChangeKey)
                .HasMaxLength(50)
                .HasColumnName("change_key");
            entity.Property(e => e.CreateDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("create_date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.NewValue)
                .HasColumnType("mediumblob")
                .HasColumnName("new_value");
            entity.Property(e => e.OldValue)
                .HasColumnType("mediumblob")
                .HasColumnName("old_value");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfUserConfirmation>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ConfirmationType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_confirmation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ConfirmationDate, "confirmation_date");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ConfirmationType)
                .HasMaxLength(25)
                .HasColumnName("confirmation_type");
            entity.Property(e => e.ConfirmationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("confirmation_date");
            entity.Property(e => e.ConfirmationKey)
                .HasMaxLength(16)
                .HasColumnName("confirmation_key");
        });

        modelBuilder.Entity<XfUserConnectedAccount>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Provider })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_connected_account")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.Provider, e.ProviderKey }, "provider").IsUnique();

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Provider)
                .HasMaxLength(25)
                .HasColumnName("provider");
            entity.Property(e => e.ExtraData)
                .HasColumnType("mediumblob")
                .HasColumnName("extra_data");
            entity.Property(e => e.ProviderKey)
                .HasMaxLength(150)
                .HasColumnName("provider_key");
        });

        modelBuilder.Entity<XfUserField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_field")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DisplayGroup, e.DisplayOrder }, "display_group_order");

            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.DisplayGroup)
                .HasDefaultValueSql("'personal'")
                .HasColumnType("enum('personal','contact','preferences')")
                .HasColumnName("display_group");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.DisplayTemplate)
                .HasColumnType("text")
                .HasColumnName("display_template");
            entity.Property(e => e.FieldChoices)
                .HasColumnType("blob")
                .HasColumnName("field_choices");
            entity.Property(e => e.FieldType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'textbox'")
                .HasColumnName("field_type");
            entity.Property(e => e.MatchParams)
                .HasColumnType("blob")
                .HasColumnName("match_params");
            entity.Property(e => e.MatchType)
                .HasMaxLength(25)
                .HasDefaultValueSql("'none'")
                .HasColumnName("match_type");
            entity.Property(e => e.MaxLength)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.ModeratorEditable)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("moderator_editable");
            entity.Property(e => e.Required)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("required");
            entity.Property(e => e.ShowRegistration)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("show_registration");
            entity.Property(e => e.UserEditable)
                .HasDefaultValueSql("'yes'")
                .HasColumnType("enum('yes','once','never')")
                .HasColumnName("user_editable");
            entity.Property(e => e.ViewableMessage)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("viewable_message");
            entity.Property(e => e.ViewableProfile)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("viewable_profile");
            entity.Property(e => e.WrapperTemplate)
                .HasColumnType("text")
                .HasColumnName("wrapper_template");
        });

        modelBuilder.Entity<XfUserFieldValue>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FieldId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_field_value")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FieldId, "field_id");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.FieldId)
                .HasMaxLength(25)
                .HasColumnName("field_id");
            entity.Property(e => e.FieldValue)
                .HasColumnType("mediumtext")
                .HasColumnName("field_value");
        });

        modelBuilder.Entity<XfUserFollow>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FollowUserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_follow")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.FollowUserId, "follow_user_id");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.FollowUserId)
                .HasComment("User being followed")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("follow_user_id");
            entity.Property(e => e.FollowDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("follow_date");
        });

        modelBuilder.Entity<XfUserGroup>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_group")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Title, "title");

            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_group_id");
            entity.Property(e => e.BannerCssClass)
                .HasMaxLength(75)
                .HasDefaultValueSql("''")
                .HasColumnName("banner_css_class");
            entity.Property(e => e.BannerText)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("banner_text");
            entity.Property(e => e.DisplayStylePriority)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_style_priority");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.UserTitle)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("user_title");
            entity.Property(e => e.UsernameCss)
                .HasColumnType("text")
                .HasColumnName("username_css");
        });

        modelBuilder.Entity<XfUserGroupChange>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ChangeKey })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_group_change")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ChangeKey, "change_key");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.ChangeKey)
                .HasMaxLength(50)
                .HasColumnName("change_key");
            entity.Property(e => e.GroupIds)
                .HasMaxLength(255)
                .HasColumnName("group_ids");
        });

        modelBuilder.Entity<XfUserGroupPromotion>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_group_promotion")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Title, "title");

            entity.Property(e => e.PromotionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("promotion_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.ExtraUserGroupIds)
                .HasMaxLength(255)
                .HasColumnName("extra_user_group_ids");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.UserCriteria)
                .HasColumnType("mediumblob")
                .HasColumnName("user_criteria");
        });

        modelBuilder.Entity<XfUserGroupPromotionLog>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_group_promotion_log")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PromotionDate, "promotion_date");

            entity.HasIndex(e => new { e.UserId, e.PromotionDate }, "user_id_date");

            entity.Property(e => e.PromotionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("promotion_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.PromotionDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("promotion_date");
            entity.Property(e => e.PromotionState)
                .HasDefaultValueSql("'automatic'")
                .HasColumnType("enum('automatic','manual','disabled')")
                .HasColumnName("promotion_state");
        });

        modelBuilder.Entity<XfUserGroupRelation>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.UserGroupId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_group_relation")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserGroupId, e.IsPrimary }, "user_group_id_is_primary");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_group_id");
            entity.Property(e => e.IsPrimary)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_primary");
        });

        modelBuilder.Entity<XfUserIgnored>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.IgnoredUserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_ignored")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IgnoredUserId, "ignored_user_id");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.IgnoredUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ignored_user_id");
        });

        modelBuilder.Entity<XfUserOption>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_option")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.AlertOptout)
                .HasComment("Comma-separated list of alerts from which the user has opted out. Example: 'post_like,user_trophy'")
                .HasColumnType("text")
                .HasColumnName("alert_optout");
            entity.Property(e => e.ContentShowSignature)
                .HasDefaultValueSql("'1'")
                .HasComment("Show user's signatures with content")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("content_show_signature");
            entity.Property(e => e.CreationWatchState)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','watch_no_email','watch_email')")
                .HasColumnName("creation_watch_state");
            entity.Property(e => e.EmailOnConversation)
                .HasDefaultValueSql("'1'")
                .HasComment("Receive an email upon receiving a conversation message")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("email_on_conversation");
            entity.Property(e => e.InteractionWatchState)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','watch_no_email','watch_email')")
                .HasColumnName("interaction_watch_state");
            entity.Property(e => e.IsDiscouraged)
                .HasComment("If non-zero, this user will be subjected to annoying random system failures.")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_discouraged");
            entity.Property(e => e.PushOnConversation)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("push_on_conversation");
            entity.Property(e => e.PushOptout)
                .HasComment("Comma-separated list of alerts from which the user has opted out for push notifications. Example: 'post_like,user_trophy'")
                .HasColumnType("text")
                .HasColumnName("push_optout");
            entity.Property(e => e.ReceiveAdminEmail)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("receive_admin_email");
            entity.Property(e => e.ShowDobDate)
                .HasDefaultValueSql("'1'")
                .HasComment("Show date of birth day and month")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("show_dob_date");
            entity.Property(e => e.ShowDobYear)
                .HasDefaultValueSql("'1'")
                .HasComment("Show date of month year (thus: age)")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("show_dob_year");
            entity.Property(e => e.UseTfa)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("use_tfa");
        });

        modelBuilder.Entity<XfUserPrivacy>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_privacy")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.AllowPostProfile)
                .HasDefaultValueSql("'members'")
                .HasColumnType("enum('members','followed','none')")
                .HasColumnName("allow_post_profile");
            entity.Property(e => e.AllowReceiveNewsFeed)
                .HasDefaultValueSql("'everyone'")
                .HasColumnType("enum('everyone','members','followed','none')")
                .HasColumnName("allow_receive_news_feed");
            entity.Property(e => e.AllowSendPersonalConversation)
                .HasDefaultValueSql("'members'")
                .HasColumnType("enum('members','followed','none')")
                .HasColumnName("allow_send_personal_conversation");
            entity.Property(e => e.AllowViewIdentities)
                .HasDefaultValueSql("'everyone'")
                .HasColumnType("enum('everyone','members','followed','none')")
                .HasColumnName("allow_view_identities");
            entity.Property(e => e.AllowViewProfile)
                .HasDefaultValueSql("'everyone'")
                .HasColumnType("enum('everyone','members','followed','none')")
                .HasColumnName("allow_view_profile");
            entity.Property(e => e.ThdonateAllowViewDonationStats)
                .HasDefaultValueSql("'everyone'")
                .HasColumnType("enum('everyone','members','followed','none')")
                .HasColumnName("thdonate_allow_view_donation_stats");
        });

        modelBuilder.Entity<XfUserProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_profile")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DobMonth, e.DobDay, e.DobYear }, "dob");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.About)
                .HasColumnType("text")
                .HasColumnName("about");
            entity.Property(e => e.AvatarCropX)
                .HasComment("X-Position from which to start the square crop on the m avatar")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("avatar_crop_x");
            entity.Property(e => e.AvatarCropY)
                .HasComment("Y-Position from which to start the square crop on the m avatar")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("avatar_crop_y");
            entity.Property(e => e.BannerDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("banner_date");
            entity.Property(e => e.BannerPositionY)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("banner_position_y");
            entity.Property(e => e.ConnectedAccounts)
                .HasColumnType("mediumblob")
                .HasColumnName("connected_accounts");
            entity.Property(e => e.CustomFields)
                .HasColumnType("mediumblob")
                .HasColumnName("custom_fields");
            entity.Property(e => e.DobDay)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dob_day");
            entity.Property(e => e.DobMonth)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dob_month");
            entity.Property(e => e.DobYear)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("dob_year");
            entity.Property(e => e.Following)
                .HasComment("Comma-separated integers from xf_user_follow")
                .HasColumnType("text")
                .HasColumnName("following");
            entity.Property(e => e.Ignored)
                .HasComment("Comma-separated integers from xf_user_ignored")
                .HasColumnType("text")
                .HasColumnName("ignored");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("location");
            entity.Property(e => e.PasswordDate)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("password_date");
            entity.Property(e => e.Signature)
                .HasColumnType("text")
                .HasColumnName("signature");
            entity.Property(e => e.Website)
                .HasColumnType("text")
                .HasColumnName("website");
        });

        modelBuilder.Entity<XfUserPushOptout>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Push })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_push_optout")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Push)
                .HasMaxLength(50)
                .HasColumnName("push");
        });

        modelBuilder.Entity<XfUserPushSubscription>(entity =>
        {
            entity.HasKey(e => e.EndpointId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_push_subscription")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.EndpointHash, "endpoint_hash").IsUnique();

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.EndpointId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("endpoint_id");
            entity.Property(e => e.Data)
                .HasColumnType("mediumblob")
                .HasColumnName("data");
            entity.Property(e => e.Endpoint)
                .HasColumnType("text")
                .HasColumnName("endpoint");
            entity.Property(e => e.EndpointHash)
                .HasMaxLength(32)
                .HasColumnName("endpoint_hash");
            entity.Property(e => e.ErrorCount)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("error_count");
            entity.Property(e => e.LastSeen)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_seen");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfUserReject>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_reject")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.RejectDate, "reject_date");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.RejectDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reject_date");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("reject_reason");
            entity.Property(e => e.RejectUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reject_user_id");
        });

        modelBuilder.Entity<XfUserRemember>(entity =>
        {
            entity.HasKey(e => e.RememberId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_remember")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ExpiryDate, "expiry_date");

            entity.HasIndex(e => new { e.UserId, e.RememberKey }, "user_id_remember_key").IsUnique();

            entity.Property(e => e.RememberId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("remember_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.RememberKey)
                .HasMaxLength(32)
                .HasColumnName("remember_key");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfUserTfa>(entity =>
        {
            entity.HasKey(e => e.UserTfaId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_tfa")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserId, e.ProviderId }, "user_id").IsUnique();

            entity.Property(e => e.UserTfaId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_tfa_id");
            entity.Property(e => e.LastUsedDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("last_used_date");
            entity.Property(e => e.ProviderData)
                .HasColumnType("mediumblob")
                .HasColumnName("provider_data");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(25)
                .HasColumnName("provider_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfUserTfaTrusted>(entity =>
        {
            entity.HasKey(e => e.TfaTrustedId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_tfa_trusted")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.TrustedUntil, "trusted_until");

            entity.HasIndex(e => new { e.UserId, e.TrustedKey }, "user_id").IsUnique();

            entity.Property(e => e.TfaTrustedId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tfa_trusted_id");
            entity.Property(e => e.TrustedKey)
                .HasMaxLength(32)
                .HasColumnName("trusted_key");
            entity.Property(e => e.TrustedUntil)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trusted_until");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfUserTitleLadder>(entity =>
        {
            entity.HasKey(e => e.MinimumLevel).HasName("PRIMARY");

            entity
                .ToTable("xf_user_title_ladder")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.MinimumLevel)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("minimum_level");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfUserTrophy>(entity =>
        {
            entity.HasKey(e => new { e.TrophyId, e.UserId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("xf_user_trophy")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserId, e.AwardDate }, "user_id_award_date");

            entity.Property(e => e.TrophyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trophy_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.AwardDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("award_date");
        });

        modelBuilder.Entity<XfUserUpgrade>(entity =>
        {
            entity.HasKey(e => e.UserUpgradeId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_upgrade")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.DisplayOrder, "display_order");

            entity.Property(e => e.UserUpgradeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_upgrade_id");
            entity.Property(e => e.CanPurchase)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("can_purchase");
            entity.Property(e => e.CostAmount)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("cost_amount");
            entity.Property(e => e.CostCurrency)
                .HasMaxLength(3)
                .HasColumnName("cost_currency");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisabledUpgradeIds)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("disabled_upgrade_ids");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.ExtraGroupIds)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_group_ids");
            entity.Property(e => e.LengthAmount)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("length_amount");
            entity.Property(e => e.LengthUnit)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('day','month','year','')")
                .HasColumnName("length_unit");
            entity.Property(e => e.PaymentProfileIds)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("payment_profile_ids");
            entity.Property(e => e.Recurring)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("recurring");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<XfUserUpgradeActive>(entity =>
        {
            entity.HasKey(e => e.UserUpgradeRecordId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_upgrade_active")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.EndDate, "end_date");

            entity.HasIndex(e => e.PurchaseRequestKey, "purchase_request_key");

            entity.HasIndex(e => e.StartDate, "start_date");

            entity.HasIndex(e => new { e.UserId, e.UserUpgradeId }, "user_id_upgrade_id").IsUnique();

            entity.Property(e => e.UserUpgradeRecordId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_upgrade_record_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("end_date");
            entity.Property(e => e.Extra)
                .HasColumnType("mediumblob")
                .HasColumnName("extra");
            entity.Property(e => e.PurchaseRequestKey)
                .HasMaxLength(32)
                .HasColumnName("purchase_request_key");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UserUpgradeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_upgrade_id");
        });

        modelBuilder.Entity<XfUserUpgradeExpired>(entity =>
        {
            entity.HasKey(e => e.UserUpgradeRecordId).HasName("PRIMARY");

            entity
                .ToTable("xf_user_upgrade_expired")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.EndDate, "end_date");

            entity.HasIndex(e => e.PurchaseRequestKey, "purchase_request_key");

            entity.HasIndex(e => e.StartDate, "start_date");

            entity.Property(e => e.UserUpgradeRecordId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_upgrade_record_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("end_date");
            entity.Property(e => e.Extra)
                .HasColumnType("mediumblob")
                .HasColumnName("extra");
            entity.Property(e => e.OriginalEndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("original_end_date");
            entity.Property(e => e.PurchaseRequestKey)
                .HasMaxLength(32)
                .HasColumnName("purchase_request_key");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UserUpgradeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_upgrade_id");
        });

        modelBuilder.Entity<XfUsernameChange>(entity =>
        {
            entity.HasKey(e => e.ChangeId).HasName("PRIMARY");

            entity
                .ToTable("xf_username_change")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ChangeDate, "change_date");

            entity.HasIndex(e => new { e.NewUsername, e.ChangeState }, "new_username_state");

            entity.HasIndex(e => new { e.OldUsername, e.ChangeState, e.ChangeDate }, "old_username_state_date");

            entity.HasIndex(e => new { e.UserId, e.ChangeState, e.ChangeDate }, "user_id_state_date");

            entity.Property(e => e.ChangeId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("change_id");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("change_date");
            entity.Property(e => e.ChangeReason)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("change_reason");
            entity.Property(e => e.ChangeState)
                .HasDefaultValueSql("'approved'")
                .HasColumnType("enum('moderated','approved','rejected')")
                .HasColumnName("change_state");
            entity.Property(e => e.ChangeUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("change_user_id");
            entity.Property(e => e.ModeratorUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("moderator_user_id");
            entity.Property(e => e.NewUsername)
                .HasMaxLength(50)
                .HasColumnName("new_username");
            entity.Property(e => e.OldUsername)
                .HasMaxLength(50)
                .HasColumnName("old_username");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("reject_reason");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<XfWarning>(entity =>
        {
            entity.HasKey(e => e.WarningId).HasName("PRIMARY");

            entity
                .ToTable("xf_warning")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.ContentType, e.ContentId }, "content_type_id");

            entity.HasIndex(e => new { e.IsExpired, e.ExpiryDate }, "is_expired_expiry");

            entity.HasIndex(e => new { e.UserId, e.WarningDate }, "user_id_date");

            entity.HasIndex(e => e.WarningUserId, "warning_user_id");

            entity.Property(e => e.WarningId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_id");
            entity.Property(e => e.ContentId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("content_id");
            entity.Property(e => e.ContentTitle)
                .HasMaxLength(255)
                .HasColumnName("content_title");
            entity.Property(e => e.ContentType)
                .HasMaxLength(25)
                .HasColumnName("content_type");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("expiry_date");
            entity.Property(e => e.ExtraUserGroupIds)
                .HasMaxLength(255)
                .HasColumnName("extra_user_group_ids");
            entity.Property(e => e.IsExpired)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_expired");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Points)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("points");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.WarningDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_date");
            entity.Property(e => e.WarningDefinitionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_definition_id");
            entity.Property(e => e.WarningUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_user_id");
        });

        modelBuilder.Entity<XfWarningAction>(entity =>
        {
            entity.HasKey(e => e.WarningActionId).HasName("PRIMARY");

            entity
                .ToTable("xf_warning_action")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Points, "points");

            entity.Property(e => e.WarningActionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_action_id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasColumnName("action");
            entity.Property(e => e.ActionLength)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("action_length");
            entity.Property(e => e.ActionLengthType)
                .HasMaxLength(25)
                .HasColumnName("action_length_type");
            entity.Property(e => e.ExtraUserGroupIds)
                .HasMaxLength(255)
                .HasColumnName("extra_user_group_ids");
            entity.Property(e => e.Points)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("points");
        });

        modelBuilder.Entity<XfWarningActionTrigger>(entity =>
        {
            entity.HasKey(e => e.ActionTriggerId).HasName("PRIMARY");

            entity
                .ToTable("xf_warning_action_trigger")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.UserId, e.TriggerPoints }, "user_id_points");

            entity.Property(e => e.ActionTriggerId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("action_trigger_id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasColumnName("action");
            entity.Property(e => e.ActionDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("action_date");
            entity.Property(e => e.MinUnbanDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("min_unban_date");
            entity.Property(e => e.TriggerPoints)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("trigger_points");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.WarningActionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_action_id");
        });

        modelBuilder.Entity<XfWarningDefinition>(entity =>
        {
            entity.HasKey(e => e.WarningDefinitionId).HasName("PRIMARY");

            entity
                .ToTable("xf_warning_definition")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.PointsDefault, "points_default");

            entity.Property(e => e.WarningDefinitionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("warning_definition_id");
            entity.Property(e => e.ExpiryDefault)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("expiry_default");
            entity.Property(e => e.ExpiryType)
                .HasColumnType("enum('never','days','weeks','months','years')")
                .HasColumnName("expiry_type");
            entity.Property(e => e.ExtraUserGroupIds)
                .HasMaxLength(255)
                .HasColumnName("extra_user_group_ids");
            entity.Property(e => e.IsEditable)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_editable");
            entity.Property(e => e.PointsDefault)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("points_default");
        });

        modelBuilder.Entity<XfWidget>(entity =>
        {
            entity.HasKey(e => e.WidgetId).HasName("PRIMARY");

            entity
                .ToTable("xf_widget")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.WidgetKey, "widget_key").IsUnique();

            entity.Property(e => e.WidgetId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("widget_id");
            entity.Property(e => e.ConditionExpression)
                .HasColumnType("mediumblob")
                .HasColumnName("condition_expression");
            entity.Property(e => e.DefinitionId)
                .HasMaxLength(25)
                .HasColumnName("definition_id");
            entity.Property(e => e.DisplayCondition)
                .HasColumnType("mediumtext")
                .HasColumnName("display_condition");
            entity.Property(e => e.Options)
                .HasColumnType("blob")
                .HasColumnName("options");
            entity.Property(e => e.Positions)
                .HasColumnType("blob")
                .HasColumnName("positions");
            entity.Property(e => e.WidgetKey)
                .HasMaxLength(50)
                .HasColumnName("widget_key");
        });

        modelBuilder.Entity<XfWidgetDefinition>(entity =>
        {
            entity.HasKey(e => e.DefinitionId).HasName("PRIMARY");

            entity
                .ToTable("xf_widget_definition")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.DefinitionId)
                .HasMaxLength(25)
                .HasColumnName("definition_id");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("addon_id");
            entity.Property(e => e.DefinitionClass)
                .HasMaxLength(100)
                .HasColumnName("definition_class");
        });

        modelBuilder.Entity<XfWidgetPosition>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PRIMARY");

            entity
                .ToTable("xf_widget_position")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PositionId)
                .HasMaxLength(50)
                .HasColumnName("position_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.AddonId)
                .HasMaxLength(50)
                .HasColumnName("addon_id");
        });

        modelBuilder.Entity<XfaRmmpDigitalProduct>(entity =>
        {
            entity.HasKey(e => e.DigitalpId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_digital_product")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.DigitalpId, e.ResourceId }, "digitalp_resource");

            entity.Property(e => e.DigitalpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("digitalp_id");
            entity.Property(e => e.AllowExpiredRenewal)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("allow_expired_renewal");
            entity.Property(e => e.BaseRenewalPrice)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("base_renewal_price");
            entity.Property(e => e.DelayRenewal)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("delay_renewal");
            entity.Property(e => e.Duration)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("duration");
            entity.Property(e => e.DurationType)
                .HasDefaultValueSql("'day'")
                .HasColumnType("enum('day','week','month','year')")
                .HasColumnName("duration_type");
            entity.Property(e => e.HasRestriction)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("has_restriction");
            entity.Property(e => e.LicKeyFormat)
                .HasColumnType("mediumtext")
                .HasColumnName("lic_key_format");
            entity.Property(e => e.RenewalPrice)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("renewal_price");
            entity.Property(e => e.RequireUrl)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("require_url");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
        });

        modelBuilder.Entity<XfaRmmpDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_discount")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.DiscountId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("discount_id");
            entity.Property(e => e.Applied)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("applied");
            entity.Property(e => e.ApplytoRenewal)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("applyto_renewal");
            entity.Property(e => e.CreatorId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("creator_id");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("discount_amount");
            entity.Property(e => e.FromDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("from_date");
            entity.Property(e => e.IsFixed)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("is_fixed");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.ResourceIds)
                .HasColumnType("mediumtext")
                .HasColumnName("resource_ids");
            entity.Property(e => e.ToDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("to_date");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'all_own'")
                .HasColumnType("enum('all','all_own','specifics')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<XfaRmmpFeaturingDuration>(entity =>
        {
            entity.HasKey(e => e.DurationId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_featuring_duration")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.DurationId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("duration_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("amount");
            entity.Property(e => e.DisplayOrder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("display_order");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("value");
        });

        modelBuilder.Entity<XfaRmmpFeaturingPurchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_featuring_purchase")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PurchaseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_id");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("currency");
            entity.Property(e => e.Duration)
                .HasMaxLength(100)
                .HasColumnName("duration");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("price");
            entity.Property(e => e.PurchaseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_date");
            entity.Property(e => e.RefundTxnId)
                .HasMaxLength(30)
                .HasColumnName("refund_txn_id");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','validated','refunded','expired')")
                .HasColumnName("status");
            entity.Property(e => e.TransactionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transaction_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Validated)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("validated");
            entity.Property(e => e.ValidationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("validation_date");
        });

        modelBuilder.Entity<XfaRmmpInvoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_invoices")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.InvoiceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("invoice_id");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("currency");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("invoice_date");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("price");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','validated','refunded','expired')")
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Warned)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("warned");
        });

        modelBuilder.Entity<XfaRmmpLicense>(entity =>
        {
            entity.HasKey(e => e.LicenseId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_license")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.LicenseId, e.ResourceId }, "license_resource");

            entity.HasIndex(e => new { e.LicenseId, e.UserId }, "license_user");

            entity.Property(e => e.LicenseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("license_id");
            entity.Property(e => e.Active)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("active");
            entity.Property(e => e.EndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("end_date");
            entity.Property(e => e.ExpirationSent)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("expiration_sent");
            entity.Property(e => e.LicKey)
                .HasColumnType("mediumtext")
                .HasColumnName("lic_key");
            entity.Property(e => e.PreviousEndDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("previous_end_date");
            entity.Property(e => e.PurchaseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_id");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.Siteurl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("siteurl");
            entity.Property(e => e.StartDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("start_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Validated)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("validated");
        });

        modelBuilder.Entity<XfaRmmpPhysicalProduct>(entity =>
        {
            entity.HasKey(e => e.PhysicalpId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_physical_product")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.PhysicalpId, e.ResourceId }, "physicalp_resource");

            entity.Property(e => e.PhysicalpId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("physicalp_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("quantity");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.SellOnStockout)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("sell_on_stockout");
            entity.Property(e => e.Shipping)
                .HasColumnType("text")
                .HasColumnName("shipping");
        });

        modelBuilder.Entity<XfaRmmpPurchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_purchase")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => new { e.PurchaseId, e.LicenseId }, "purchase_license");

            entity.HasIndex(e => new { e.PurchaseId, e.ResourceId }, "purchase_resource");

            entity.HasIndex(e => new { e.PurchaseId, e.TransactionId }, "purchase_transaction");

            entity.HasIndex(e => new { e.PurchaseId, e.UserId }, "purchase_user");

            entity.Property(e => e.PurchaseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_id");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("currency");
            entity.Property(e => e.ForUserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("for_user_id");
            entity.Property(e => e.ForUsername)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("for_username");
            entity.Property(e => e.LicenseId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("license_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("price");
            entity.Property(e => e.PurchaseDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_date");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("quantity");
            entity.Property(e => e.ResourceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resource_id");
            entity.Property(e => e.ShipmentData)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("shipment_data");
            entity.Property(e => e.ShipmentStatus)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','in_preparation','sent','delivered')")
                .HasColumnName("shipment_status");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','validated','refunded')")
                .HasColumnName("status");
            entity.Property(e => e.TransactionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transaction_id");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'purchase'")
                .HasColumnType("enum('purchase','renewal')")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.ValidationDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("validation_date");
        });

        modelBuilder.Entity<XfaRmmpPurchaseAddInfo>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_purchase_add_info")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.PurchaseId)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("purchase_id");
            entity.Property(e => e.AdditionalInfo)
                .HasColumnType("text")
                .HasColumnName("additional_info");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
        });

        modelBuilder.Entity<XfaRmmpSellerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xfa_rmmp_seller_info")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.UserId, "user_id").IsUnique();

            entity.Property(e => e.ActivateInvoicing)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("activate_invoicing");
            entity.Property(e => e.AdditionalInfo)
                .HasColumnType("mediumtext")
                .HasColumnName("additional_info");
            entity.Property(e => e.Address)
                .HasColumnType("mediumtext")
                .HasColumnName("address");
            entity.Property(e => e.CommTextPurchase)
                .HasColumnType("mediumtext")
                .HasColumnName("comm_text_purchase");
            entity.Property(e => e.CommTextPurchaseRefund)
                .HasColumnType("mediumtext")
                .HasColumnName("comm_text_purchase_refund");
            entity.Property(e => e.CommTextRenewal)
                .HasColumnType("mediumtext")
                .HasColumnName("comm_text_renewal");
            entity.Property(e => e.CommTextRenewalRefund)
                .HasColumnType("mediumtext")
                .HasColumnName("comm_text_renewal_refund");
            entity.Property(e => e.CommTitlePurchase)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("comm_title_purchase");
            entity.Property(e => e.CommTitlePurchaseRefund)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("comm_title_purchase_refund");
            entity.Property(e => e.CommTitleRenewal)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("comm_title_renewal");
            entity.Property(e => e.CommTitleRenewalRefund)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("comm_title_renewal_refund");
            entity.Property(e => e.CommType)
                .HasDefaultValueSql("'email'")
                .HasColumnType("enum('email','pm','both')")
                .HasColumnName("comm_type");
            entity.Property(e => e.InvoicePrefix)
                .HasMaxLength(5)
                .HasDefaultValueSql("''")
                .HasColumnName("invoice_prefix");
            entity.Property(e => e.LogoDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("logo_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.UserId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<XfaRmmpTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity
                .ToTable("xfa_rmmp_transaction")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.TransactionId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transaction_id");
            entity.Property(e => e.Business)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("business");
            entity.Property(e => e.Fees)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("fees");
            entity.Property(e => e.Pos)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("pos");
            entity.Property(e => e.PosInvoiceId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("pos_invoice_id");
            entity.Property(e => e.PosPaid)
                .HasDefaultValueSql("'na'")
                .HasColumnType("enum('na','pending','completed')")
                .HasColumnName("pos_paid");
            entity.Property(e => e.Shipping)
                .HasColumnType("decimal(10,2) unsigned")
                .HasColumnName("shipping");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'completed'")
                .HasColumnType("enum('initialized','pending','completed','expired','pending_manual')")
                .HasColumnName("status");
            entity.Property(e => e.Token)
                .HasMaxLength(20)
                .HasColumnName("token");
            entity.Property(e => e.TxnId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("txn_id");
            entity.Property(e => e.TxnIdPos)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("txn_id_pos");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
