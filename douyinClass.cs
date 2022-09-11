// http://tool.sufeinet.com/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SufeiNet2
{

    public class Avatar300x300
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class Avatar168x168
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class CoverUrl
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AvatarMedium
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class AvatarLarger
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AvatarThumb
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class VideoIcon
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<object> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class ShareQrcodeUrl
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ShareInfo
    {

        [JsonProperty("share_title_myself")]
        public string ShareTitleMyself { get; set; }

        [JsonProperty("share_title_other")]
        public string ShareTitleOther { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("share_weibo_desc")]
        public string ShareWeiboDesc { get; set; }

        [JsonProperty("share_desc")]
        public string ShareDesc { get; set; }

        [JsonProperty("share_desc_info")]
        public string ShareDescInfo { get; set; }

        [JsonProperty("share_qrcode_url")]
        public ShareQrcodeUrl ShareQrcodeUrl { get; set; }

        [JsonProperty("share_title")]
        public string ShareTitle { get; set; }
    }

    public class AwemeControl
    {

        [JsonProperty("can_comment")]
        public bool CanComment { get; set; }

        [JsonProperty("can_forward")]
        public bool CanForward { get; set; }

        [JsonProperty("can_share")]
        public bool CanShare { get; set; }

        [JsonProperty("can_show_comment")]
        public bool CanShowComment { get; set; }
    }

    public class SearchImpr
    {

        [JsonProperty("entity_id")]
        public string EntityId { get; set; }
    }

    public class Author
    {

        [JsonProperty("download_prompt_ts")]
        public int DownloadPromptTs { get; set; }

        [JsonProperty("follower_request_status")]
        public int FollowerRequestStatus { get; set; }

        [JsonProperty("live_verify")]
        public int LiveVerify { get; set; }

        [JsonProperty("signature_extra")]
        public object SignatureExtra { get; set; }

        [JsonProperty("is_ad_fake")]
        public bool IsAdFake { get; set; }

        [JsonProperty("total_favorited")]
        public int TotalFavorited { get; set; }

        [JsonProperty("type_label")]
        public object TypeLabel { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("has_youtube_token")]
        public bool HasYoutubeToken { get; set; }

        [JsonProperty("homepage_bottom_toast")]
        public object HomepageBottomToast { get; set; }

        [JsonProperty("is_cf")]
        public int IsCf { get; set; }

        [JsonProperty("is_phone_binded")]
        public bool IsPhoneBinded { get; set; }

        [JsonProperty("youtube_channel_id")]
        public string YoutubeChannelId { get; set; }

        [JsonProperty("aweme_count")]
        public int AwemeCount { get; set; }

        [JsonProperty("cha_list")]
        public object ChaList { get; set; }

        [JsonProperty("show_nearby_active")]
        public bool ShowNearbyActive { get; set; }

        [JsonProperty("user_canceled")]
        public bool UserCanceled { get; set; }

        [JsonProperty("user_period")]
        public int UserPeriod { get; set; }

        [JsonProperty("live_commerce")]
        public bool LiveCommerce { get; set; }

        [JsonProperty("user_tags")]
        public object UserTags { get; set; }

        [JsonProperty("ad_cover_url")]
        public object AdCoverUrl { get; set; }

        [JsonProperty("commerce_user_level")]
        public int CommerceUserLevel { get; set; }

        [JsonProperty("follow_status")]
        public int FollowStatus { get; set; }

        [JsonProperty("has_email")]
        public bool HasEmail { get; set; }

        [JsonProperty("interest_tags")]
        public object InterestTags { get; set; }

        [JsonProperty("is_blocking_v2")]
        public bool IsBlockingV2 { get; set; }

        [JsonProperty("youtube_channel_title")]
        public string YoutubeChannelTitle { get; set; }

        [JsonProperty("weibo_verify")]
        public string WeiboVerify { get; set; }

        [JsonProperty("avatar_300x300")]
        public Avatar300x300 Avatar300x300 { get; set; }

        [JsonProperty("contacts_status")]
        public int ContactsStatus { get; set; }

        [JsonProperty("im_role_ids")]
        public object ImRoleIds { get; set; }

        [JsonProperty("is_block")]
        public bool IsBlock { get; set; }

        [JsonProperty("is_mix_user")]
        public bool IsMixUser { get; set; }

        [JsonProperty("weibo_url")]
        public string WeiboUrl { get; set; }

        [JsonProperty("favoriting_count")]
        public int FavoritingCount { get; set; }

        [JsonProperty("follower_status")]
        public int FollowerStatus { get; set; }

        [JsonProperty("tw_expire_time")]
        public int TwExpireTime { get; set; }

        [JsonProperty("with_commerce_entry")]
        public bool WithCommerceEntry { get; set; }

        [JsonProperty("shield_digg_notice")]
        public int ShieldDiggNotice { get; set; }

        [JsonProperty("shield_follow_notice")]
        public int ShieldFollowNotice { get; set; }

        [JsonProperty("card_entries")]
        public object CardEntries { get; set; }

        [JsonProperty("cf_list")]
        public object CfList { get; set; }

        [JsonProperty("has_unread_story")]
        public bool HasUnreadStory { get; set; }

        [JsonProperty("hide_location")]
        public bool HideLocation { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("school_category")]
        public int SchoolCategory { get; set; }

        [JsonProperty("twitter_name")]
        public string TwitterName { get; set; }

        [JsonProperty("constellation")]
        public int Constellation { get; set; }

        [JsonProperty("display_info")]
        public object DisplayInfo { get; set; }

        [JsonProperty("need_points")]
        public object NeedPoints { get; set; }

        [JsonProperty("avatar_168x168")]
        public Avatar168x168 Avatar168x168 { get; set; }

        [JsonProperty("followers_detail")]
        public object FollowersDetail { get; set; }

        [JsonProperty("has_facebook_token")]
        public bool HasFacebookToken { get; set; }

        [JsonProperty("school_id")]
        public string SchoolId { get; set; }

        [JsonProperty("show_image_bubble")]
        public bool ShowImageBubble { get; set; }

        [JsonProperty("accept_private_policy")]
        public bool AcceptPrivatePolicy { get; set; }

        [JsonProperty("ban_user_functions")]
        public object BanUserFunctions { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("download_setting")]
        public int DownloadSetting { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("comment_setting")]
        public int CommentSetting { get; set; }

        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        [JsonProperty("is_gov_media_vip")]
        public bool IsGovMediaVip { get; set; }

        [JsonProperty("new_story_cover")]
        public object NewStoryCover { get; set; }

        [JsonProperty("relative_users")]
        public object RelativeUsers { get; set; }

        [JsonProperty("secret")]
        public int Secret { get; set; }

        [JsonProperty("link_item_list")]
        public object LinkItemList { get; set; }

        [JsonProperty("shield_comment_notice")]
        public int ShieldCommentNotice { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("need_recommend")]
        public int NeedRecommend { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("user_age")]
        public int UserAge { get; set; }

        [JsonProperty("cover_url")]
        public IList<CoverUrl> CoverUrl { get; set; }

        [JsonProperty("cv_level")]
        public string CvLevel { get; set; }

        [JsonProperty("weibo_schema")]
        public string WeiboSchema { get; set; }

        [JsonProperty("account_region")]
        public string AccountRegion { get; set; }

        [JsonProperty("avatar_medium")]
        public AvatarMedium AvatarMedium { get; set; }

        [JsonProperty("card_entries_not_display")]
        public object CardEntriesNotDisplay { get; set; }

        [JsonProperty("enable_nearby_visible")]
        public bool EnableNearbyVisible { get; set; }

        [JsonProperty("enterprise_verify_reason")]
        public string EnterpriseVerifyReason { get; set; }

        [JsonProperty("reflow_page_gid")]
        public int ReflowPageGid { get; set; }

        [JsonProperty("google_account")]
        public string GoogleAccount { get; set; }

        [JsonProperty("with_dou_entry")]
        public bool WithDouEntry { get; set; }

        [JsonProperty("avatar_larger")]
        public AvatarLarger AvatarLarger { get; set; }

        [JsonProperty("avatar_thumb")]
        public AvatarThumb AvatarThumb { get; set; }

        [JsonProperty("share_qrcode_uri")]
        public string ShareQrcodeUri { get; set; }

        [JsonProperty("verification_type")]
        public int VerificationType { get; set; }

        [JsonProperty("video_icon")]
        public VideoIcon VideoIcon { get; set; }

        [JsonProperty("youtube_expire_time")]
        public int YoutubeExpireTime { get; set; }

        [JsonProperty("live_status")]
        public int LiveStatus { get; set; }

        [JsonProperty("not_seen_item_id_list")]
        public object NotSeenItemIdList { get; set; }

        [JsonProperty("offline_info_list")]
        public object OfflineInfoList { get; set; }

        [JsonProperty("special_lock")]
        public int SpecialLock { get; set; }

        [JsonProperty("user_permissions")]
        public object UserPermissions { get; set; }

        [JsonProperty("bind_phone")]
        public string BindPhone { get; set; }

        [JsonProperty("is_binded_weibo")]
        public bool IsBindedWeibo { get; set; }

        [JsonProperty("school_poi_id")]
        public string SchoolPoiId { get; set; }

        [JsonProperty("share_info")]
        public ShareInfo ShareInfo { get; set; }

        [JsonProperty("verify_info")]
        public string VerifyInfo { get; set; }

        [JsonProperty("white_cover_url")]
        public object WhiteCoverUrl { get; set; }

        [JsonProperty("live_agreement_time")]
        public int LiveAgreementTime { get; set; }

        [JsonProperty("prevent_download")]
        public bool PreventDownload { get; set; }

        [JsonProperty("react_setting")]
        public int ReactSetting { get; set; }

        [JsonProperty("story_count")]
        public int StoryCount { get; set; }

        [JsonProperty("user_mode")]
        public int UserMode { get; set; }

        [JsonProperty("apple_account")]
        public int AppleAccount { get; set; }

        [JsonProperty("avatar_uri")]
        public string AvatarUri { get; set; }

        [JsonProperty("custom_verify")]
        public string CustomVerify { get; set; }

        [JsonProperty("is_discipline_member")]
        public bool IsDisciplineMember { get; set; }

        [JsonProperty("sec_uid")]
        public string SecUid { get; set; }

        [JsonProperty("signature_display_lines")]
        public int SignatureDisplayLines { get; set; }

        [JsonProperty("follower_count")]
        public int FollowerCount { get; set; }

        [JsonProperty("has_insights")]
        public bool HasInsights { get; set; }

        [JsonProperty("ky_only_predict")]
        public int KyOnlyPredict { get; set; }

        [JsonProperty("max_follower_count")]
        public int MaxFollowerCount { get; set; }

        [JsonProperty("user_not_show")]
        public int UserNotShow { get; set; }

        [JsonProperty("stitch_setting")]
        public int StitchSetting { get; set; }

        [JsonProperty("user_rate")]
        public int UserRate { get; set; }

        [JsonProperty("ins_id")]
        public string InsId { get; set; }

        [JsonProperty("is_not_show")]
        public bool IsNotShow { get; set; }

        [JsonProperty("is_star")]
        public bool IsStar { get; set; }

        [JsonProperty("item_list")]
        public object ItemList { get; set; }

        [JsonProperty("neiguang_shield")]
        public int NeiguangShield { get; set; }

        [JsonProperty("school_type")]
        public int SchoolType { get; set; }

        [JsonProperty("school_name")]
        public string SchoolName { get; set; }

        [JsonProperty("weibo_name")]
        public string WeiboName { get; set; }

        [JsonProperty("duet_setting")]
        public int DuetSetting { get; set; }

        [JsonProperty("geofencing")]
        public IList<object> Geofencing { get; set; }

        [JsonProperty("has_twitter_token")]
        public bool HasTwitterToken { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("live_agreement")]
        public int LiveAgreement { get; set; }

        [JsonProperty("platform_sync_info")]
        public object PlatformSyncInfo { get; set; }

        [JsonProperty("room_id")]
        public int RoomId { get; set; }

        [JsonProperty("sync_to_toutiao")]
        public int SyncToToutiao { get; set; }

        [JsonProperty("aweme_control")]
        public AwemeControl AwemeControl { get; set; }

        [JsonProperty("comment_filter_status")]
        public int CommentFilterStatus { get; set; }

        [JsonProperty("has_orders")]
        public bool HasOrders { get; set; }

        [JsonProperty("user_not_see")]
        public int UserNotSee { get; set; }

        [JsonProperty("authority_status")]
        public int AuthorityStatus { get; set; }

        [JsonProperty("aweme_hotsoon_auth")]
        public int AwemeHotsoonAuth { get; set; }

        [JsonProperty("fb_expire_time")]
        public int FbExpireTime { get; set; }

        [JsonProperty("unique_id_modify_time")]
        public int UniqueIdModifyTime { get; set; }

        [JsonProperty("with_shop_entry")]
        public bool WithShopEntry { get; set; }

        [JsonProperty("can_set_geofencing")]
        public object CanSetGeofencing { get; set; }

        [JsonProperty("following_count")]
        public int FollowingCount { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("story_open")]
        public bool StoryOpen { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("card_sort_priority")]
        public object CardSortPriority { get; set; }

        [JsonProperty("close_friend_type")]
        public int CloseFriendType { get; set; }

        [JsonProperty("search_impr")]
        public SearchImpr SearchImpr { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("hide_search")]
        public bool HideSearch { get; set; }

        [JsonProperty("is_blocked_v2")]
        public bool IsBlockedV2 { get; set; }

        [JsonProperty("personal_tag_list")]
        public object PersonalTagList { get; set; }

        [JsonProperty("reflow_page_uid")]
        public int ReflowPageUid { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }

        [JsonProperty("with_fusion_shop_entry")]
        public bool WithFusionShopEntry { get; set; }
    }

    public class VideoControl
    {

        [JsonProperty("allow_duet")]
        public bool AllowDuet { get; set; }

        [JsonProperty("allow_music")]
        public bool AllowMusic { get; set; }

        [JsonProperty("allow_share")]
        public bool AllowShare { get; set; }

        [JsonProperty("duet_ignore_visibility")]
        public bool DuetIgnoreVisibility { get; set; }

        [JsonProperty("share_type")]
        public int ShareType { get; set; }

        [JsonProperty("allow_douplus")]
        public bool AllowDouplus { get; set; }

        [JsonProperty("allow_download")]
        public bool AllowDownload { get; set; }

        [JsonProperty("allow_dynamic_wallpaper")]
        public bool AllowDynamicWallpaper { get; set; }

        [JsonProperty("allow_react")]
        public bool AllowReact { get; set; }

        [JsonProperty("allow_stitch")]
        public bool AllowStitch { get; set; }

        [JsonProperty("prevent_download_type")]
        public int PreventDownloadType { get; set; }

        [JsonProperty("download_ignore_visibility")]
        public bool DownloadIgnoreVisibility { get; set; }

        [JsonProperty("draft_progress_bar")]
        public int DraftProgressBar { get; set; }

        [JsonProperty("show_progress_bar")]
        public int ShowProgressBar { get; set; }

        [JsonProperty("timer_status")]
        public int TimerStatus { get; set; }

        [JsonProperty("share_grayed")]
        public bool ShareGrayed { get; set; }

        [JsonProperty("share_ignore_visibility")]
        public bool ShareIgnoreVisibility { get; set; }
    }

    public class Descendants
    {

        [JsonProperty("notify_msg")]
        public string NotifyMsg { get; set; }

        [JsonProperty("platforms")]
        public IList<string> Platforms { get; set; }
    }

    public class ReviewResult
    {

        [JsonProperty("review_status")]
        public int ReviewStatus { get; set; }
    }

    public class AwemeEditInfo
    {

        [JsonProperty("button_status")]
        public int ButtonStatus { get; set; }

        [JsonProperty("button_toast")]
        public string ButtonToast { get; set; }
    }

    public class Status
    {

        [JsonProperty("allow_share")]
        public bool AllowShare { get; set; }

        [JsonProperty("aweme_id")]
        public string AwemeId { get; set; }

        [JsonProperty("download_status")]
        public int DownloadStatus { get; set; }

        [JsonProperty("review_result")]
        public ReviewResult ReviewResult { get; set; }

        [JsonProperty("dont_share_status")]
        public int DontShareStatus { get; set; }

        [JsonProperty("reviewed")]
        public int Reviewed { get; set; }

        [JsonProperty("self_see")]
        public bool SelfSee { get; set; }

        [JsonProperty("aweme_edit_info")]
        public AwemeEditInfo AwemeEditInfo { get; set; }

        [JsonProperty("in_reviewing")]
        public bool InReviewing { get; set; }

        [JsonProperty("is_delete")]
        public bool IsDelete { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("listen_video_status")]
        public int ListenVideoStatus { get; set; }

        [JsonProperty("video_hide_search")]
        public int VideoHideSearch { get; set; }

        [JsonProperty("with_goods")]
        public bool WithGoods { get; set; }

        [JsonProperty("allow_comment")]
        public bool AllowComment { get; set; }

        [JsonProperty("is_prohibited")]
        public bool IsProhibited { get; set; }

        [JsonProperty("part_see")]
        public int PartSee { get; set; }

        [JsonProperty("private_status")]
        public int PrivateStatus { get; set; }

        [JsonProperty("with_fusion_goods")]
        public bool WithFusionGoods { get; set; }
    }

    public class ShareInfo2
    {

        [JsonProperty("share_signature_url")]
        public string ShareSignatureUrl { get; set; }

        [JsonProperty("share_title")]
        public string ShareTitle { get; set; }

        [JsonProperty("share_weibo_desc")]
        public string ShareWeiboDesc { get; set; }

        [JsonProperty("share_title_myself")]
        public string ShareTitleMyself { get; set; }

        [JsonProperty("share_title_other")]
        public string ShareTitleOther { get; set; }

        [JsonProperty("bool_persist")]
        public int BoolPersist { get; set; }

        [JsonProperty("share_desc")]
        public string ShareDesc { get; set; }

        [JsonProperty("share_desc_info")]
        public string ShareDescInfo { get; set; }

        [JsonProperty("share_link_desc")]
        public string ShareLinkDesc { get; set; }

        [JsonProperty("share_quote")]
        public string ShareQuote { get; set; }

        [JsonProperty("share_signature_desc")]
        public string ShareSignatureDesc { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }
    }

    public class VideoTag
    {

        [JsonProperty("tag_id")]
        public int TagId { get; set; }

        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
    }

    public class ImageAlbumMusicInfo
    {

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("begin_time")]
        public int BeginTime { get; set; }

        [JsonProperty("end_time")]
        public int EndTime { get; set; }
    }

    public class ImpressionData
    {

        [JsonProperty("similar_id_list_b")]
        public IList<long> SimilarIdListB { get; set; }

        [JsonProperty("group_id_list_a")]
        public IList<object> GroupIdListA { get; set; }

        [JsonProperty("group_id_list_b")]
        public IList<object> GroupIdListB { get; set; }

        [JsonProperty("similar_id_list_a")]
        public IList<object> SimilarIdListA { get; set; }
    }

    public class ShowFollowButton
    {
    }

    public class SearchImpr2
    {

        [JsonProperty("entity_id")]
        public string EntityId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }
    }

    public class PoiPatchInfo
    {

        [JsonProperty("extra")]
        public string Extra { get; set; }

        [JsonProperty("item_patch_poi_prompt_mark")]
        public int ItemPatchPoiPromptMark { get; set; }
    }

    public class AvatarMedium2
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class PlayUrl
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_key")]
        public string UrlKey { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class CoverThumb
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class StrongBeatUrl
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class CoverMedium
    {

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class SearchImpr3
    {

        [JsonProperty("entity_id")]
        public string EntityId { get; set; }
    }

    public class CoverHd
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AvatarLarge
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class CoverLarge
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class LunaInfo
    {

        [JsonProperty("is_luna_user")]
        public bool IsLunaUser { get; set; }
    }

    public class AvatarThumb2
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Music
    {

        [JsonProperty("binded_challenge_id")]
        public int BindedChallengeId { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("prevent_download")]
        public bool PreventDownload { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("is_matched_metadata")]
        public bool IsMatchedMetadata { get; set; }

        [JsonProperty("redirect")]
        public bool Redirect { get; set; }

        [JsonProperty("avatar_medium")]
        public AvatarMedium2 AvatarMedium { get; set; }

        [JsonProperty("is_audio_url_with_cookie")]
        public bool IsAudioUrlWithCookie { get; set; }

        [JsonProperty("mid")]
        public string Mid { get; set; }

        [JsonProperty("play_url")]
        public PlayUrl PlayUrl { get; set; }

        [JsonProperty("preview_end_time")]
        public int PreviewEndTime { get; set; }

        [JsonProperty("artist_user_infos")]
        public object ArtistUserInfos { get; set; }

        [JsonProperty("pgc_music_type")]
        public int PgcMusicType { get; set; }

        [JsonProperty("prevent_item_download_status")]
        public int PreventItemDownloadStatus { get; set; }

        [JsonProperty("author_deleted")]
        public bool AuthorDeleted { get; set; }

        [JsonProperty("author_status")]
        public int AuthorStatus { get; set; }

        [JsonProperty("cover_thumb")]
        public CoverThumb CoverThumb { get; set; }

        [JsonProperty("musician_user_infos")]
        public object MusicianUserInfos { get; set; }

        [JsonProperty("shoot_duration")]
        public int ShootDuration { get; set; }

        [JsonProperty("unshelve_countries")]
        public object UnshelveCountries { get; set; }

        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("author_position")]
        public object AuthorPosition { get; set; }

        [JsonProperty("can_background_play")]
        public bool CanBackgroundPlay { get; set; }

        [JsonProperty("is_original")]
        public bool IsOriginal { get; set; }

        [JsonProperty("offline_desc")]
        public string OfflineDesc { get; set; }

        [JsonProperty("owner_nickname")]
        public string OwnerNickname { get; set; }

        [JsonProperty("strong_beat_url")]
        public StrongBeatUrl StrongBeatUrl { get; set; }

        [JsonProperty("is_del_video")]
        public bool IsDelVideo { get; set; }

        [JsonProperty("tag_list")]
        public object TagList { get; set; }

        [JsonProperty("user_count")]
        public int UserCount { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("music_status")]
        public int MusicStatus { get; set; }

        [JsonProperty("mute_share")]
        public bool MuteShare { get; set; }

        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        [JsonProperty("end_time")]
        public int EndTime { get; set; }

        [JsonProperty("is_video_self_see")]
        public bool IsVideoSelfSee { get; set; }

        [JsonProperty("source_platform")]
        public int SourcePlatform { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("extra")]
        public string Extra { get; set; }

        [JsonProperty("is_original_sound")]
        public bool IsOriginalSound { get; set; }

        [JsonProperty("lyric_short_position")]
        public object LyricShortPosition { get; set; }

        [JsonProperty("music_chart_ranks")]
        public object MusicChartRanks { get; set; }

        [JsonProperty("sec_uid")]
        public string SecUid { get; set; }

        [JsonProperty("video_duration")]
        public int VideoDuration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("artists")]
        public IList<object> Artists { get; set; }

        [JsonProperty("audition_duration")]
        public int AuditionDuration { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("collect_stat")]
        public int CollectStat { get; set; }

        [JsonProperty("cover_medium")]
        public CoverMedium CoverMedium { get; set; }

        [JsonProperty("is_pgc")]
        public bool IsPgc { get; set; }

        [JsonProperty("owner_handle")]
        public string OwnerHandle { get; set; }

        [JsonProperty("search_impr")]
        public SearchImpr3 SearchImpr { get; set; }

        [JsonProperty("cover_hd")]
        public CoverHd CoverHd { get; set; }

        [JsonProperty("dmv_auto_show")]
        public bool DmvAutoShow { get; set; }

        [JsonProperty("dsp_status")]
        public int DspStatus { get; set; }

        [JsonProperty("external_song_info")]
        public IList<object> ExternalSongInfo { get; set; }

        [JsonProperty("position")]
        public object Position { get; set; }

        [JsonProperty("schema_url")]
        public string SchemaUrl { get; set; }

        [JsonProperty("avatar_large")]
        public AvatarLarge AvatarLarge { get; set; }

        [JsonProperty("cover_large")]
        public CoverLarge CoverLarge { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("is_commerce_music")]
        public bool IsCommerceMusic { get; set; }

        [JsonProperty("is_restricted")]
        public bool IsRestricted { get; set; }

        [JsonProperty("luna_info")]
        public LunaInfo LunaInfo { get; set; }

        [JsonProperty("preview_start_time")]
        public int PreviewStartTime { get; set; }

        [JsonProperty("avatar_thumb")]
        public AvatarThumb2 AvatarThumb { get; set; }

        [JsonProperty("reason_type")]
        public int ReasonType { get; set; }
    }

    public class PhotoSearchEntrance
    {

        [JsonProperty("ecom_type")]
        public int EcomType { get; set; }
    }

    public class HotsearchInfo
    {

        [JsonProperty("log_extra")]
        public string LogExtra { get; set; }

        [JsonProperty("ailab_extra")]
        public string AilabExtra { get; set; }

        [JsonProperty("biz_extra")]
        public string BizExtra { get; set; }
    }

    public class PoiBiz
    {
    }

    public class HotList
    {

        [JsonProperty("extra")]
        public string Extra { get; set; }

        [JsonProperty("pattern_type")]
        public int PatternType { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("hot_score")]
        public int HotScore { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("sentence_id")]
        public int SentenceId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("view_count")]
        public int ViewCount { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("i18n_title")]
        public string I18nTitle { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("label")]
        public int Label { get; set; }
    }

    public class RiskInfos
    {

        [JsonProperty("vote")]
        public bool Vote { get; set; }

        [JsonProperty("warn")]
        public bool Warn { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("risk_sink")]
        public bool RiskSink { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }

    public class PlayAddr
    {

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_key")]
        public string UrlKey { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("data_size")]
        public int DataSize { get; set; }

        [JsonProperty("file_cs")]
        public string FileCs { get; set; }

        [JsonProperty("file_hash")]
        public string FileHash { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class DynamicCover
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class DownloadAddr
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("data_size")]
        public int DataSize { get; set; }
    }

    public class PlayAddrLowbr
    {

        [JsonProperty("url_key")]
        public string UrlKey { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("data_size")]
        public int DataSize { get; set; }

        [JsonProperty("file_cs")]
        public string FileCs { get; set; }

        [JsonProperty("file_hash")]
        public string FileHash { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Cover
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class OriginCover
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class PlayAddr2
    {

        [JsonProperty("data_size")]
        public int DataSize { get; set; }

        [JsonProperty("file_cs")]
        public string FileCs { get; set; }

        [JsonProperty("file_hash")]
        public string FileHash { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("url_key")]
        public string UrlKey { get; set; }

        [JsonProperty("url_list")]
        public IList<string> UrlList { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class BitRate
    {

        [JsonProperty("is_bytevc1")]
        public int IsBytevc1 { get; set; }

        [JsonProperty("play_addr")]
        public PlayAddr2 PlayAddr { get; set; }

        [JsonProperty("FPS")]
        public int FPS { get; set; }

        [JsonProperty("HDR_bit")]
        public string HDRBit { get; set; }

        [JsonProperty("gear_name")]
        public string GearName { get; set; }

        [JsonProperty("quality_type")]
        public int QualityType { get; set; }

        [JsonProperty("HDR_type")]
        public string HDRType { get; set; }

        [JsonProperty("bit_rate")]
        public int BitRates { get; set; }

        [JsonProperty("is_h265")]
        public int IsH265 { get; set; }
    }

    public class Video
    {

        [JsonProperty("is_source_HDR")]
        public int IsSourceHDR { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }

        [JsonProperty("play_addr")]
        public PlayAddr PlayAddr { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("use_static_cover")]
        public bool UseStaticCover { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("dynamic_cover")]
        public DynamicCover DynamicCover { get; set; }

        [JsonProperty("download_addr")]
        public DownloadAddr DownloadAddr { get; set; }

        [JsonProperty("has_watermark")]
        public bool HasWatermark { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("is_bytevc1")]
        public int IsBytevc1 { get; set; }

        [JsonProperty("misc_download_addrs")]
        public string MiscDownloadAddrs { get; set; }

        [JsonProperty("need_set_token")]
        public bool NeedSetToken { get; set; }

        [JsonProperty("tags")]
        public object Tags { get; set; }

        [JsonProperty("big_thumbs")]
        public object BigThumbs { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("is_callback")]
        public bool IsCallback { get; set; }

        [JsonProperty("play_addr_lowbr")]
        public PlayAddrLowbr PlayAddrLowbr { get; set; }

        [JsonProperty("cover")]
        public Cover Cover { get; set; }

        [JsonProperty("cdn_url_expired")]
        public int CdnUrlExpired { get; set; }

        [JsonProperty("is_h265")]
        public int IsH265 { get; set; }

        [JsonProperty("origin_cover")]
        public OriginCover OriginCover { get; set; }

        [JsonProperty("bit_rate")]
        public IList<BitRate> BitRate { get; set; }

        [JsonProperty("is_long_video")]
        public int? IsLongVideo { get; set; }

        [JsonProperty("video_model")]
        public string VideoModel { get; set; }
    }

    public class XiguaTask
    {

        [JsonProperty("is_xigua_task")]
        public bool IsXiguaTask { get; set; }
    }

    public class CommentPermissionInfo
    {

        [JsonProperty("toast_guide")]
        public bool ToastGuide { get; set; }

        [JsonProperty("can_comment")]
        public bool CanComment { get; set; }

        [JsonProperty("comment_permission_status")]
        public int CommentPermissionStatus { get; set; }

        [JsonProperty("item_detail_entry")]
        public bool ItemDetailEntry { get; set; }

        [JsonProperty("press_entry")]
        public bool PressEntry { get; set; }
    }

    public class CommerceInfo
    {
    }

    public class AwemeControl2
    {

        [JsonProperty("can_comment")]
        public bool CanComment { get; set; }

        [JsonProperty("can_forward")]
        public bool CanForward { get; set; }

        [JsonProperty("can_share")]
        public bool CanShare { get; set; }

        [JsonProperty("can_show_comment")]
        public bool CanShowComment { get; set; }
    }

    public class TextExtra
    {

        [JsonProperty("is_commerce")]
        public bool IsCommerce { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("hashtag_id")]
        public string HashtagId { get; set; }

        [JsonProperty("hashtag_name")]
        public string HashtagName { get; set; }
    }

    public class DiggLottie
    {

        [JsonProperty("can_bomb")]
        public int CanBomb { get; set; }

        [JsonProperty("lottie_id")]
        public string LottieId { get; set; }
    }

    public class SeriesPaidInfo
    {

        [JsonProperty("item_price")]
        public int ItemPrice { get; set; }

        [JsonProperty("series_paid_status")]
        public int SeriesPaidStatus { get; set; }
    }

    public class ShareInfo3
    {

        [JsonProperty("share_quote")]
        public string ShareQuote { get; set; }

        [JsonProperty("share_signature_url")]
        public string ShareSignatureUrl { get; set; }

        [JsonProperty("share_title_other")]
        public string ShareTitleOther { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("share_weibo_desc")]
        public string ShareWeiboDesc { get; set; }

        [JsonProperty("bool_persist")]
        public int BoolPersist { get; set; }

        [JsonProperty("share_desc")]
        public string ShareDesc { get; set; }

        [JsonProperty("share_desc_info")]
        public string ShareDescInfo { get; set; }

        [JsonProperty("share_signature_desc")]
        public string ShareSignatureDesc { get; set; }

        [JsonProperty("share_title")]
        public string ShareTitle { get; set; }

        [JsonProperty("share_title_myself")]
        public string ShareTitleMyself { get; set; }
    }

    public class Author2
    {

        [JsonProperty("geofencing")]
        public object Geofencing { get; set; }

        [JsonProperty("homepage_bottom_toast")]
        public object HomepageBottomToast { get; set; }

        [JsonProperty("new_story_cover")]
        public object NewStoryCover { get; set; }

        [JsonProperty("offline_info_list")]
        public object OfflineInfoList { get; set; }

        [JsonProperty("can_set_geofencing")]
        public object CanSetGeofencing { get; set; }

        [JsonProperty("im_role_ids")]
        public object ImRoleIds { get; set; }

        [JsonProperty("interest_tags")]
        public object InterestTags { get; set; }

        [JsonProperty("card_entries_not_display")]
        public object CardEntriesNotDisplay { get; set; }

        [JsonProperty("item_list")]
        public object ItemList { get; set; }

        [JsonProperty("user_tags")]
        public object UserTags { get; set; }

        [JsonProperty("card_entries")]
        public object CardEntries { get; set; }

        [JsonProperty("signature_extra")]
        public object SignatureExtra { get; set; }

        [JsonProperty("type_label")]
        public object TypeLabel { get; set; }

        [JsonProperty("ban_user_functions")]
        public object BanUserFunctions { get; set; }

        [JsonProperty("cha_list")]
        public object ChaList { get; set; }

        [JsonProperty("platform_sync_info")]
        public object PlatformSyncInfo { get; set; }

        [JsonProperty("need_points")]
        public object NeedPoints { get; set; }

        [JsonProperty("personal_tag_list")]
        public object PersonalTagList { get; set; }

        [JsonProperty("relative_users")]
        public object RelativeUsers { get; set; }

        [JsonProperty("user_permissions")]
        public object UserPermissions { get; set; }

        [JsonProperty("ad_cover_url")]
        public object AdCoverUrl { get; set; }

        [JsonProperty("card_sort_priority")]
        public object CardSortPriority { get; set; }

        [JsonProperty("cover_url")]
        public object CoverUrl { get; set; }

        [JsonProperty("link_item_list")]
        public object LinkItemList { get; set; }

        [JsonProperty("not_seen_item_id_list")]
        public object NotSeenItemIdList { get; set; }

        [JsonProperty("white_cover_url")]
        public object WhiteCoverUrl { get; set; }

        [JsonProperty("cf_list")]
        public object CfList { get; set; }

        [JsonProperty("display_info")]
        public object DisplayInfo { get; set; }

        [JsonProperty("followers_detail")]
        public object FollowersDetail { get; set; }
    }

    public class ExtraAttr
    {

        [JsonProperty("is_live")]
        public bool IsLive { get; set; }
    }

    public class SearchImpr4
    {

        [JsonProperty("entity_id")]
        public string EntityId { get; set; }
    }

    public class ChaList
    {

        [JsonProperty("is_pgcshow")]
        public bool IsPgcshow { get; set; }

        [JsonProperty("show_items")]
        public object ShowItems { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("user_count")]
        public int UserCount { get; set; }

        [JsonProperty("view_count")]
        public int ViewCount { get; set; }

        [JsonProperty("connect_music")]
        public IList<object> ConnectMusic { get; set; }

        [JsonProperty("banner_list")]
        public object BannerList { get; set; }

        [JsonProperty("hashtag_profile")]
        public string HashtagProfile { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }

        [JsonProperty("share_info")]
        public ShareInfo3 ShareInfo { get; set; }

        [JsonProperty("author")]
        public Author2 Author { get; set; }

        [JsonProperty("is_commerce")]
        public bool IsCommerce { get; set; }

        [JsonProperty("sub_type")]
        public int SubType { get; set; }

        [JsonProperty("extra_attr")]
        public ExtraAttr ExtraAttr { get; set; }

        [JsonProperty("cha_name")]
        public string ChaName { get; set; }

        [JsonProperty("cid")]
        public string Cid { get; set; }

        [JsonProperty("collect_stat")]
        public int CollectStat { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("is_challenge")]
        public int IsChallenge { get; set; }

        [JsonProperty("search_impr")]
        public SearchImpr4 SearchImpr { get; set; }

        [JsonProperty("cha_attrs")]
        public object ChaAttrs { get; set; }
    }

    public class Statistics
    {

        [JsonProperty("collect_count")]
        public int CollectCount { get; set; }

        [JsonProperty("lose_count")]
        public int LoseCount { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("share_count")]
        public int ShareCount { get; set; }

        [JsonProperty("download_count")]
        public int DownloadCount { get; set; }

        [JsonProperty("whatsapp_share_count")]
        public int WhatsappShareCount { get; set; }

        [JsonProperty("digest")]
        public string Digest { get; set; }

        [JsonProperty("live_watch_count")]
        public int LiveWatchCount { get; set; }

        [JsonProperty("forward_count")]
        public int ForwardCount { get; set; }

        [JsonProperty("lose_comment_count")]
        public int LoseCommentCount { get; set; }

        [JsonProperty("aweme_id")]
        public string AwemeId { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("digg_count")]
        public int DiggCount { get; set; }

        [JsonProperty("exposure_count")]
        public int ExposureCount { get; set; }
    }

    public class RelationLabel
    {

        [JsonProperty("label_info")]
        public string LabelInfo { get; set; }

        [JsonProperty("show_type")]
        public int ShowType { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }

    public class FakeHorizontalInfo
    {

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("bottom")]
        public double Bottom { get; set; }

        [JsonProperty("left")]
        public int Left { get; set; }

        [JsonProperty("right")]
        public int Right { get; set; }
    }

    public class AwemeList
    {

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("image_infos")]
        public object ImageInfos { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("relation_labels")]
        public object RelationLabels { get; set; }

        [JsonProperty("social_tag_list")]
        public object SocialTagList { get; set; }

        [JsonProperty("is_fantasy")]
        public bool IsFantasy { get; set; }

        [JsonProperty("is_karaoke")]
        public bool IsKaraoke { get; set; }

        [JsonProperty("is_top")]
        public int IsTop { get; set; }

        [JsonProperty("item_share")]
        public int ItemShare { get; set; }

        [JsonProperty("standard_bar_info_list")]
        public object StandardBarInfoList { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("commerce_config_data")]
        public object CommerceConfigData { get; set; }

        [JsonProperty("duet_aggregate_in_music_tab")]
        public bool DuetAggregateInMusicTab { get; set; }

        [JsonProperty("without_watermark")]
        public bool WithoutWatermark { get; set; }

        [JsonProperty("item_react")]
        public int ItemReact { get; set; }

        [JsonProperty("video_labels")]
        public object VideoLabels { get; set; }

        [JsonProperty("is_collects_selected")]
        public int IsCollectsSelected { get; set; }

        [JsonProperty("is_pgcshow")]
        public bool IsPgcshow { get; set; }

        [JsonProperty("item_comment_settings")]
        public int ItemCommentSettings { get; set; }

        [JsonProperty("label_top_text")]
        public object LabelTopText { get; set; }

        [JsonProperty("report_action")]
        public bool ReportAction { get; set; }

        [JsonProperty("video_control")]
        public VideoControl VideoControl { get; set; }

        [JsonProperty("distribute_type")]
        public int DistributeType { get; set; }

        [JsonProperty("has_vs_entry")]
        public bool HasVsEntry { get; set; }

        [JsonProperty("images")]
        public object Images { get; set; }

        [JsonProperty("interaction_stickers")]
        public object InteractionStickers { get; set; }

        [JsonProperty("is_story")]
        public int IsStory { get; set; }

        [JsonProperty("descendants")]
        public Descendants Descendants { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("cmt_swt")]
        public bool CmtSwt { get; set; }

        [JsonProperty("share_info")]
        public ShareInfo2 ShareInfo { get; set; }

        [JsonProperty("video_tag")]
        public IList<VideoTag> VideoTag { get; set; }

        [JsonProperty("with_promotional_music")]
        public bool WithPromotionalMusic { get; set; }

        [JsonProperty("comment_gid")]
        public object CommentGid { get; set; }

        [JsonProperty("img_bitrate")]
        public object ImgBitrate { get; set; }

        [JsonProperty("need_vs_entry")]
        public bool NeedVsEntry { get; set; }

        [JsonProperty("prevent_download")]
        public bool PreventDownload { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("author_user_id")]
        public object AuthorUserId { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("image_album_music_info")]
        public ImageAlbumMusicInfo ImageAlbumMusicInfo { get; set; }

        [JsonProperty("geofencing")]
        public IList<object> Geofencing { get; set; }

        [JsonProperty("hybrid_label")]
        public object HybridLabel { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("impression_data")]
        public ImpressionData ImpressionData { get; set; }

        [JsonProperty("is_preview")]
        public int IsPreview { get; set; }

        [JsonProperty("sort_label")]
        public string SortLabel { get; set; }

        [JsonProperty("is_life_item")]
        public bool IsLifeItem { get; set; }

        [JsonProperty("nearby_level")]
        public int NearbyLevel { get; set; }

        [JsonProperty("is_first_video")]
        public bool IsFirstVideo { get; set; }

        [JsonProperty("long_video")]
        public object LongVideo { get; set; }

        [JsonProperty("show_follow_button")]
        public ShowFollowButton ShowFollowButton { get; set; }

        [JsonProperty("vr_type")]
        public int VrType { get; set; }

        [JsonProperty("guide_btn_type")]
        public int GuideBtnType { get; set; }

        [JsonProperty("search_impr")]
        public SearchImpr2 SearchImpr { get; set; }

        [JsonProperty("poi_patch_info")]
        public PoiPatchInfo PoiPatchInfo { get; set; }

        [JsonProperty("item_stitch")]
        public int ItemStitch { get; set; }

        [JsonProperty("music")]
        public Music Music { get; set; }

        [JsonProperty("photo_search_entrance")]
        public PhotoSearchEntrance PhotoSearchEntrance { get; set; }

        [JsonProperty("collect_stat")]
        public int CollectStat { get; set; }

        [JsonProperty("cover_labels")]
        public object CoverLabels { get; set; }

        [JsonProperty("desc_language")]
        public string DescLanguage { get; set; }

        [JsonProperty("hotsearch_info")]
        public HotsearchInfo HotsearchInfo { get; set; }

        [JsonProperty("is_duet_sing")]
        public bool IsDuetSing { get; set; }

        [JsonProperty("aweme_type")]
        public int AwemeType { get; set; }

        [JsonProperty("have_dashboard")]
        public bool HaveDashboard { get; set; }

        [JsonProperty("story_ttl")]
        public int StoryTtl { get; set; }

        [JsonProperty("nickname_position")]
        public object NicknamePosition { get; set; }

        [JsonProperty("poi_biz")]
        public PoiBiz PoiBiz { get; set; }

        [JsonProperty("promotions")]
        public IList<object> Promotions { get; set; }

        [JsonProperty("uniqid_position")]
        public object UniqidPosition { get; set; }

        [JsonProperty("challenge_position")]
        public object ChallengePosition { get; set; }

        [JsonProperty("comment_list")]
        public object CommentList { get; set; }

        [JsonProperty("hot_list")]
        public HotList HotList { get; set; }

        [JsonProperty("origin_comment_ids")]
        public object OriginCommentIds { get; set; }

        [JsonProperty("position")]
        public object Position { get; set; }

        [JsonProperty("dislike_dimension_list")]
        public object DislikeDimensionList { get; set; }

        [JsonProperty("is_hash_tag")]
        public int IsHashTag { get; set; }

        [JsonProperty("is_vr")]
        public bool IsVr { get; set; }

        [JsonProperty("risk_infos")]
        public RiskInfos RiskInfos { get; set; }

        [JsonProperty("bodydance_score")]
        public int BodydanceScore { get; set; }

        [JsonProperty("anchors")]
        public object Anchors { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("xigua_task")]
        public XiguaTask XiguaTask { get; set; }

        [JsonProperty("comment_permission_info")]
        public CommentPermissionInfo CommentPermissionInfo { get; set; }

        [JsonProperty("commerce_info")]
        public CommerceInfo CommerceInfo { get; set; }

        [JsonProperty("is_relieve")]
        public bool IsRelieve { get; set; }

        [JsonProperty("original_images")]
        public object OriginalImages { get; set; }

        [JsonProperty("should_open_ad_report")]
        public bool ShouldOpenAdReport { get; set; }

        [JsonProperty("aweme_control")]
        public AwemeControl2 AwemeControl { get; set; }

        [JsonProperty("chapter_list")]
        public object ChapterList { get; set; }

        [JsonProperty("geofencing_regions")]
        public object GeofencingRegions { get; set; }

        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        [JsonProperty("is_image_beat")]
        public bool IsImageBeat { get; set; }

        [JsonProperty("is_in_scope")]
        public bool IsInScope { get; set; }

        [JsonProperty("text_extra")]
        public IList<TextExtra> TextExtra { get; set; }

        [JsonProperty("user_digged")]
        public int UserDigged { get; set; }

        [JsonProperty("aweme_id")]
        public string AwemeId { get; set; }

        [JsonProperty("digg_lottie")]
        public DiggLottie DiggLottie { get; set; }

        [JsonProperty("series_paid_info")]
        public SeriesPaidInfo SeriesPaidInfo { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("item_duet")]
        public int ItemDuet { get; set; }

        [JsonProperty("misc_info")]
        public string MiscInfo { get; set; }

        [JsonProperty("cha_list")]
        public IList<ChaList> ChaList { get; set; }

        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }

        [JsonProperty("video_text")]
        public IList<object> VideoText { get; set; }

        [JsonProperty("relation_label")]
        public RelationLabel RelationLabel { get; set; }

        [JsonProperty("fake_horizontal_info")]
        public FakeHorizontalInfo FakeHorizontalInfo { get; set; }
    }

    public class HotspotBottomBarInfo
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class LogPb
    {

        [JsonProperty("impr_id")]
        public string ImprId { get; set; }
    }

    public class Extra
    {

        [JsonProperty("now")]
        public long Now { get; set; }

        [JsonProperty("fatal_item_ids")]
        public IList<object> FatalItemIds { get; set; }

        [JsonProperty("logid")]
        public string Logid { get; set; }
    }

    public class SufeiNet_Test3
    {

        [JsonProperty("aweme_list")]
        public IList<AwemeList> AwemeList { get; set; }

        [JsonProperty("comment_list")]
        public IList<object> CommentList { get; set; }

        [JsonProperty("hotspot_bottom_bar_info")]
        public HotspotBottomBarInfo HotspotBottomBarInfo { get; set; }

        [JsonProperty("has_more")]
        public int HasMore { get; set; }

        [JsonProperty("hidden_video_info")]
        public string HiddenVideoInfo { get; set; }

        [JsonProperty("log_pb")]
        public LogPb LogPb { get; set; }

        [JsonProperty("status_msg")]
        public object StatusMsg { get; set; }

        [JsonProperty("word_info")]
        public object WordInfo { get; set; }

        [JsonProperty("cursor")]
        public int Cursor { get; set; }

        [JsonProperty("extra")]
        public Extra Extra { get; set; }

        [JsonProperty("hotspot_feed_bottom_bar_type")]
        public int HotspotFeedBottomBarType { get; set; }

        [JsonProperty("micro_article_list")]
        public IList<object> MicroArticleList { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

}
