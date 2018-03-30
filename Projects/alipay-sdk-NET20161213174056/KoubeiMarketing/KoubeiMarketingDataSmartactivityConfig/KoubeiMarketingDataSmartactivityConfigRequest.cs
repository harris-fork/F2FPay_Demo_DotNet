using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.smartactivity.config
    /// 商户智能活动配置方案接口
    /// </summary>
    public class KoubeiMarketingDataSmartactivityConfigRequest : BizAopRequest<KoubeiMarketingDataSmartactivityConfigResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.smartactivity.config";
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
