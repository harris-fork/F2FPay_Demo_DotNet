using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.smartactivity.forecast
    /// 商户智能活动效果预测接口
    /// </summary>
    public class KoubeiMarketingDataSmartactivityForecastRequest : BizAopRequest<KoubeiMarketingDataSmartactivityForecastResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.smartactivity.forecast";
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
