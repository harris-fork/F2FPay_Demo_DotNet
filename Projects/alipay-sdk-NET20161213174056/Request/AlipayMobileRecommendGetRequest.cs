using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.recommend.get
    /// </summary>
    public class AlipayMobileRecommendGetRequest : IAopRequest<AlipayMobileRecommendGetResponse>
    {
        /// <summary>
        /// 请求上下文扩展信息，需要与接口负责人约定。格式为json对象。
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 期望获取的最多推荐数量, 默认获取一个推荐内容, 0表示获取所有推荐内容
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// 所使用的场景id，请向接口负责人申请
        /// </summary>
        public string SceneId { get; set; }

        /// <summary>
        /// 获取推荐信息的开始位置, 默认从0开始
        /// </summary>
        public string StartIdx { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.mobile.recommend.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("limit", this.Limit);
            parameters.Add("scene_id", this.SceneId);
            parameters.Add("start_idx", this.StartIdx);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
