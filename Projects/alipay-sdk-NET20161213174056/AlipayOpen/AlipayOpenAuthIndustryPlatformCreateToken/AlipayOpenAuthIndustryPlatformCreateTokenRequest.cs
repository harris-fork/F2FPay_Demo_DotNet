using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.auth.industry.platform.create.token
    /// 行业平台获取授权码
    /// </summary>
    public class AlipayOpenAuthIndustryPlatformCreateTokenRequest : BizAopRequest<AlipayOpenAuthIndustryPlatformCreateTokenResponse>
    {
        

        #region BizAopRequest Members

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
