using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.riskidentify.get
    /// </summary>
    public class AlipayTrustUserRiskidentifyGetRequest : IAopRequest<AlipayTrustUserRiskidentifyGetResponse>
    {
        /// <summary>
        /// 行业关注名单类型，具体类型见对接文档或样例代码
        /// </summary>
        public string Type { get; set; }

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
            return "alipay.trust.user.riskidentify.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
