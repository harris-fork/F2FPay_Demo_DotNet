using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zmscore.zrank.get
    /// </summary>
    public class AlipayZmscoreZrankGetRequest : IAopRequest<AlipayZmscoreZrankGetResponse>
    {
        /// <summary>
        /// 用户ID
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
            return "alipay.zmscore.zrank.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
