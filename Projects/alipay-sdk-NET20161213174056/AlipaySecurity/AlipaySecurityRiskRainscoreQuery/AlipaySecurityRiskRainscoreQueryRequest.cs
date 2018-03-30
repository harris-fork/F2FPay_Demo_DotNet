using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.risk.rainscore.query
    /// </summary>
    public class AlipaySecurityRiskRainscoreQueryRequest : IAopRequest<AlipaySecurityRiskRainscoreQueryResponse>
    {
        /// <summary>
        /// RAIN （Risk of Activity, Identity and Network）是蚁盾旗下产品，专业提供风险评分服务，是一套能够对手机号进行风险预测、风险解释的评分体系。
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.risk.rainscore.query";
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
