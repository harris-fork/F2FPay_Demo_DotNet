using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.tool.prizesend.auth
    /// </summary>
    public class KoubeiMarketingToolPrizesendAuthRequest : IAopRequest<KoubeiMarketingToolPrizesendAuthResponse>
    {
        /// <summary>
        /// 发券授权
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.tool.prizesend.auth";
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
