using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.risk.summary.get
    /// </summary>
    public class AlipayTrustUserRiskSummaryGetRequest : IAopRequest<AlipayTrustUserRiskSummaryGetResponse>
    {
        /// <summary>
        /// 描述用户信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trust.user.risk.summary.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
