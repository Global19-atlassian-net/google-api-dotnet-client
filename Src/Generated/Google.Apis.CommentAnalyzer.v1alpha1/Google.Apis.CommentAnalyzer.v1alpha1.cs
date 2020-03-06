// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.44.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Perspective Comment Analyzer API Version v1alpha1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://github.com/conversationai/perspectiveapi/blob/master/README.md'>Perspective Comment Analyzer API</a>
 *      <tr><th>API Version<td>v1alpha1
 *      <tr><th>API Rev<td>20200301 (1886)
 *      <tr><th>API Docs
 *          <td><a href='https://github.com/conversationai/perspectiveapi/blob/master/README.md'>
 *              https://github.com/conversationai/perspectiveapi/blob/master/README.md</a>
 *      <tr><th>Discovery Name<td>commentanalyzer
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Perspective Comment Analyzer API can be found at
 * <a href='https://github.com/conversationai/perspectiveapi/blob/master/README.md'>https://github.com/conversationai/perspectiveapi/blob/master/README.md</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.CommentAnalyzer.v1alpha1
{
    /// <summary>The CommentAnalyzer Service.</summary>
    public class CommentAnalyzerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CommentAnalyzerService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CommentAnalyzerService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            comments = new CommentsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "commentanalyzer"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://commentanalyzer.googleapis.com/"; }
        #else
            get { return "https://commentanalyzer.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://commentanalyzer.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Perspective Comment Analyzer API.</summary>
        public class Scope
        {
            /// <summary>View your email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Perspective Comment Analyzer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View your email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

        }



        private readonly CommentsResource comments;

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments
        {
            get { return comments; }
        }
    }

    ///<summary>A base abstract class for CommentAnalyzer requests.</summary>
    public abstract class CommentAnalyzerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CommentAnalyzerBaseServiceRequest instance.</summary>
        protected CommentAnalyzerBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CommentAnalyzer parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "comments" collection of methods.</summary>
    public class CommentsResource
    {
        private const string Resource = "comments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CommentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Analyzes the provided text and returns scores for requested attributes.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeRequest Analyze(Google.Apis.CommentAnalyzer.v1alpha1.Data.AnalyzeCommentRequest body)
        {
            return new AnalyzeRequest(service, body);
        }

        /// <summary>Analyzes the provided text and returns scores for requested attributes.</summary>
        public class AnalyzeRequest : CommentAnalyzerBaseServiceRequest<Google.Apis.CommentAnalyzer.v1alpha1.Data.AnalyzeCommentResponse>
        {
            /// <summary>Constructs a new Analyze request.</summary>
            public AnalyzeRequest(Google.Apis.Services.IClientService service, Google.Apis.CommentAnalyzer.v1alpha1.Data.AnalyzeCommentRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CommentAnalyzer.v1alpha1.Data.AnalyzeCommentRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "analyze"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1alpha1/comments:analyze"; }
            }

            /// <summary>Initializes Analyze parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Suggest comment scores as training data.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SuggestscoreRequest Suggestscore(Google.Apis.CommentAnalyzer.v1alpha1.Data.SuggestCommentScoreRequest body)
        {
            return new SuggestscoreRequest(service, body);
        }

        /// <summary>Suggest comment scores as training data.</summary>
        public class SuggestscoreRequest : CommentAnalyzerBaseServiceRequest<Google.Apis.CommentAnalyzer.v1alpha1.Data.SuggestCommentScoreResponse>
        {
            /// <summary>Constructs a new Suggestscore request.</summary>
            public SuggestscoreRequest(Google.Apis.Services.IClientService service, Google.Apis.CommentAnalyzer.v1alpha1.Data.SuggestCommentScoreRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CommentAnalyzer.v1alpha1.Data.SuggestCommentScoreRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "suggestscore"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1alpha1/comments:suggestscore"; }
            }

            /// <summary>Initializes Suggestscore parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.CommentAnalyzer.v1alpha1.Data
{    

    /// <summary>The comment analysis request message. LINT.IfChange</summary>
    public class AnalyzeCommentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Opaque token that is echoed from the request to the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientToken")]
        public virtual string ClientToken { get; set; } 

        /// <summary>The comment to analyze.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual TextEntry Comment { get; set; } 

        /// <summary>Optional identifier associating this AnalyzeCommentRequest with a particular client's community.
        /// Different communities may have different norms and rules. Specifying this value enables us to explore
        /// building community-specific models for clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("communityId")]
        public virtual string CommunityId { get; set; } 

        /// <summary>The context of the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual Context Context { get; set; } 

        /// <summary>Do not store the comment or context sent in this request. By default, the service may store
        /// comments/context for debugging purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doNotStore")]
        public virtual System.Nullable<bool> DoNotStore { get; set; } 

        /// <summary>The language(s) of the comment and context. If none are specified, we attempt to automatically
        /// detect the language. Specifying multiple languages means the text contains multiple lanugages. Both ISO and
        /// BCP-47 language codes are accepted.
        ///
        /// The server returns an error if no language was specified and language detection fails. The server also
        /// returns an error if the languages (either specified by the caller, or auto-detected) are not *all* supported
        /// by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; } 

        /// <summary>Specification of requested attributes. The AttributeParameters serve as configuration for each
        /// associated attribute. The map keys are attribute names. The available attributes may be different on each
        /// RFE installation, and can be seen by calling ListAttributes (see above). For the prod installation, known as
        /// Perspective API, at blade:commentanalyzer-esf and commentanalyzer.googleapis.com, see go/checker-models
        /// (internal) and https://github.com/conversationai/perspectiveapi/blob/master/2-api/models.md#all-attribute-
        /// types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedAttributes")]
        public virtual System.Collections.Generic.IDictionary<string,AttributeParameters> RequestedAttributes { get; set; } 

        /// <summary>Session ID. Used to join related RPCs into a single session. For example, an interactive tool that
        /// calls both the AnalyzeComment and SuggestCommentScore RPCs should set all invocations of both RPCs to the
        /// same Session ID, typically a random 64-bit integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; } 

        /// <summary>An advisory parameter that will return span annotations if the model is capable of providing scores
        /// with sub-comment resolution. This will likely increase the size of the returned message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanAnnotations")]
        public virtual System.Nullable<bool> SpanAnnotations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The comment analysis response message.</summary>
    public class AnalyzeCommentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Scores for the requested attributes. The map keys are attribute names (same as the
        /// requested_attribute field in AnalyzeCommentRequest, for example "ATTACK_ON_AUTHOR", "INFLAMMATORY",
        /// etc).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeScores")]
        public virtual System.Collections.Generic.IDictionary<string,AttributeScores> AttributeScores { get; set; } 

        /// <summary>Same token from the original AnalyzeCommentRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientToken")]
        public virtual string ClientToken { get; set; } 

        /// <summary>Contains the languages detected from the text content, sorted in order of likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<string> DetectedLanguages { get; set; } 

        /// <summary>The language(s) used by CommentAnalyzer service to choose which Model to use when analyzing the
        /// comment. Might better be called "effective_languages". The logic used to make the choice is as follows: if
        /// !Request.languages.empty() effective_languages = Request.languages else effective_languages =
        /// detected_languages[0]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A type of context specific to a comment left on a single-threaded comment message board, where comments
    /// are either a top level comment or the child of a top level comment.</summary>
    public class ArticleAndParentComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source content about which the comment was made (article text, article summary, video
        /// transcript, etc).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("article")]
        public virtual TextEntry Article { get; set; } 

        /// <summary>Refers to text that is a direct parent of the source comment, such as in a one-deep threaded
        /// message board. This field will only be present for comments that are replies to other comments and will not
        /// be populated for direct comments on the article_text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentComment")]
        public virtual TextEntry ParentComment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configurable parameters for attribute scoring.</summary>
    public class AttributeParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Don't return scores for this attribute that are below this threshold. If unset, a default threshold
        /// will be applied. A FloatValue wrapper is used to distinguish between 0 vs. default/unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreThreshold")]
        public virtual System.Nullable<float> ScoreThreshold { get; set; } 

        /// <summary>What type of scores to return. If unset, defaults to probability scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreType")]
        public virtual string ScoreType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This holds score values for a single attribute. It contains both per-span scores as well as an overall
    /// summary score..</summary>
    public class AttributeScores : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Per-span scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanScores")]
        public virtual System.Collections.Generic.IList<SpanScore> SpanScores { get; set; } 

        /// <summary>Overall score for comment as a whole.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryScore")]
        public virtual Score SummaryScore { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Context is typically something that a Comment is referencing or replying to (such as an article, or
    /// previous comment). Note: Populate only ONE OF the following fields. The oneof syntax cannot be used because that
    /// would require nesting entries inside another message and breaking backwards compatibility. The server will
    /// return an error if more than one of the following fields is present.</summary>
    public class Context : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the source for which the original comment was made, and any parent comment
        /// info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("articleAndParentComment")]
        public virtual ArticleAndParentComment ArticleAndParentComment { get; set; } 

        /// <summary>A list of messages. For example, a linear comments section or forum thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<TextEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Analysis scores are described by a value and a ScoreType.</summary>
    public class Score : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the above value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Score value. Semantics described by type below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This is a single score for a given span of text.</summary>
    public class SpanScore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>"begin" and "end" describe the span of the original text that the attribute score applies to. The
        /// values are the UTF-16 codepoint range. "end" is exclusive. For example, with the text "Hi there", the
        /// begin/end pair (0,2) describes the text "Hi".
        ///
        /// If "begin" and "end" are unset, the score applies to the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("begin")]
        public virtual System.Nullable<int> Begin { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; } 

        /// <summary>The score value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual Score Score { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The comment score suggestion request message.</summary>
    public class SuggestCommentScoreRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attribute scores for the comment. The map keys are attribute names, same as the requested_attribute
        /// field in AnalyzeCommentRequest (for example "ATTACK_ON_AUTHOR", "INFLAMMATORY", etc.). This field has the
        /// same type as the `attribute_scores` field in AnalyzeCommentResponse.
        ///
        /// To specify an overall attribute score for the entire comment as a whole, use the `summary_score` field of
        /// the mapped AttributeScores object. To specify scores on specific subparts of the comment, use the
        /// `span_scores` field. All SpanScore objects must have begin and end fields set.
        ///
        /// All Score objects must be explicitly set (for binary classification, use the score values 0 and 1). If Score
        /// objects don't include a ScoreType, `PROBABILITY` is assumed.
        ///
        /// `attribute_scores` must not be empty. The mapped AttributeScores objects also must not be empty. An
        /// `INVALID_ARGUMENT` error is returned for all malformed requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeScores")]
        public virtual System.Collections.Generic.IDictionary<string,AttributeScores> AttributeScores { get; set; } 

        /// <summary>Opaque token that is echoed from the request to the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientToken")]
        public virtual string ClientToken { get; set; } 

        /// <summary>The comment being scored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual TextEntry Comment { get; set; } 

        /// <summary>Optional identifier associating this comment score suggestion with a particular sub-community.
        /// Different communities may have different norms and rules. Specifying this value enables training community-
        /// specific models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("communityId")]
        public virtual string CommunityId { get; set; } 

        /// <summary>The context of the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual Context Context { get; set; } 

        /// <summary>The language(s) of the comment and context. If none are specified, we attempt to automatically
        /// detect the language. Both ISO and BCP-47 language codes are accepted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; } 

        /// <summary>Session ID. Used to join related RPCs into a single session. For example, an interactive tool that
        /// calls both the AnalyzeComment and SuggestCommentScore RPCs should set all invocations of both RPCs to the
        /// same Session ID, typically a random 64-bit integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The comment score suggestion response message.</summary>
    public class SuggestCommentScoreResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Same token from the original SuggestCommentScoreRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientToken")]
        public virtual string ClientToken { get; set; } 

        /// <summary>The list of languages detected from the comment text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<string> DetectedLanguages { get; set; } 

        /// <summary>The list of languages provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedLanguages")]
        public virtual System.Collections.Generic.IList<string> RequestedLanguages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a body of text.</summary>
    public class TextEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>UTF-8 encoded text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>Type of the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
