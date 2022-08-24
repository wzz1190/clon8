
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SufeiNet
{

    public class WordCover
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList;

        [JsonProperty("uri")]
        public string Uri;
    }

    public class WordList
    {

        [JsonProperty("drift_info")]
        public object DriftInfo;

        [JsonProperty("hotlist_param")]
        public string HotlistParam;

        [JsonProperty("discuss_video_count")]
        public int DiscussVideoCount;

        [JsonProperty("hot_value")]
        public string HotValue;

        [JsonProperty("challenge_id")]
        public string ChallengeId;

        [JsonProperty("word_sub_board")]
        public IList<int> WordSubBoard;

        [JsonProperty("aweme_infos")]
        public object AwemeInfos;

        [JsonProperty("word")]
        public string Word;

        [JsonProperty("label")]
        public int Label;

        [JsonProperty("position")]
        public int Position;

        [JsonProperty("sentence_id")]
        public string SentenceId;

        [JsonProperty("event_time")]
        public int EventTime;

        [JsonProperty("related_words")]
        public object RelatedWords;

        [JsonProperty("sentence_tag")]
        public int SentenceTag;

        [JsonProperty("article_detail_count")]
        public int ArticleDetailCount;

        [JsonProperty("word_cover")]
        public WordCover WordCover;

        [JsonProperty("video_count")]
        public int VideoCount;

        [JsonProperty("group_id")]
        public string GroupId;

        [JsonProperty("word_type")]
        public int WordType;

        [JsonProperty("can_extend_detail")]
        public bool? CanExtendDetail;

        [JsonProperty("display_style")]
        public int? DisplayStyle;

        [JsonProperty("room_count")]
        public int? RoomCount;

        [JsonProperty("emo_label")]
        public int? EmoLabel;
    }

    public class ShareInfo
    {

        [JsonProperty("share_url")]
        public string ShareUrl;

        [JsonProperty("share_title")]
        public string ShareTitle;

        [JsonProperty("share_link_desc")]
        public string ShareLinkDesc;
    }

    public class WordCover2
    {

        [JsonProperty("url_list")]
        public IList<string> UrlList;

        [JsonProperty("uri")]
        public string Uri;
    }

    public class TrendingList
    {

        [JsonProperty("event_time")]
        public int EventTime;

        [JsonProperty("hotlist_param")]
        public string HotlistParam;

        [JsonProperty("aweme_infos")]
        public object AwemeInfos;

        [JsonProperty("hot_value")]
        public string HotValue;

        [JsonProperty("video_count")]
        public int VideoCount;

        [JsonProperty("word_type")]
        public int WordType;

        [JsonProperty("sentence_id")]
        public string SentenceId;

        [JsonProperty("discuss_video_count")]
        public int DiscussVideoCount;

        [JsonProperty("word")]
        public string Word;

        [JsonProperty("group_id")]
        public string GroupId;

        [JsonProperty("word_cover")]
        public WordCover2 WordCover;

        [JsonProperty("related_words")]
        public object RelatedWords;

        [JsonProperty("drift_info")]
        public object DriftInfo;

        [JsonProperty("sentence_tag")]
        public int SentenceTag;

        [JsonProperty("word_sub_board")]
        public object WordSubBoard;

        [JsonProperty("label")]
        public int Label;

        [JsonProperty("display_style")]
        public int? DisplayStyle;

        [JsonProperty("article_detail_count")]
        public int? ArticleDetailCount;

        [JsonProperty("room_count")]
        public int? RoomCount;
    }

    public class Data
    {

        [JsonProperty("trending_desc")]
        public string TrendingDesc;

        [JsonProperty("recommend_list")]
        public object RecommendList;

        [JsonProperty("word_list")]
        public IList<WordList> WordList;

        [JsonProperty("active_time")]
        public string ActiveTime;

        [JsonProperty("share_info")]
        public ShareInfo ShareInfo;

        [JsonProperty("trending_list")]
        public IList<TrendingList> TrendingList;
    }

    public class Extra
    {

        [JsonProperty("now")]
        public long Now;

        [JsonProperty("fatal_item_ids")]
        public IList<object> FatalItemIds;

        [JsonProperty("logid")]
        public string Logid;
    }

    public class LogPb
    {

        [JsonProperty("impr_id")]
        public string ImprId;
    }

    public class SufeiNet_Test
    {

        [JsonProperty("status_code")]
        public int StatusCode;

        [JsonProperty("data")]
        public Data Data;

        [JsonProperty("ad_search_list")]
        public object AdSearchList;

        [JsonProperty("board_tabs")]
        public object BoardTabs;

        [JsonProperty("extra")]
        public Extra Extra;

        [JsonProperty("log_pb")]
        public LogPb LogPb;
    }

}
