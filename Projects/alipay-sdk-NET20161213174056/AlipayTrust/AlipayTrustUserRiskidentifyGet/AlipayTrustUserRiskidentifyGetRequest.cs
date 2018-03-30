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

        public override string GetApiName()
        {
            return "alipay.trust.user.riskidentify.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
