using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.trust.user.risk.summary.get
    /// 描述用户信息
    /// </summary>
    public class AlipayTrustUserRiskSummaryGetRequest : BizAopRequest<AlipayTrustUserRiskSummaryGetResponse>
    {
        

        #region BizAopRequest Members

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
