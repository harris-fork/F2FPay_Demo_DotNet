using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.auth.industry.platform.create.token
    /// </summary>
    public class AlipayOpenAuthIndustryPlatformCreateTokenRequest : IAopRequest<AlipayOpenAuthIndustryPlatformCreateTokenResponse>
    {
        /// <summary>
        /// 行业平台获取授权码
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.auth.industry.platform.create.token";
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
