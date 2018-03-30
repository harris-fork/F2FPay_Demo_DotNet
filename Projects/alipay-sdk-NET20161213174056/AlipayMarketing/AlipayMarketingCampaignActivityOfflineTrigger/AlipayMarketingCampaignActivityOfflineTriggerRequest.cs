using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.campaign.activity.offline.trigger
    /// 商户创建活动后，需营销核心平台，来发奖。
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineTriggerRequest : BizAopRequest<AlipayMarketingCampaignActivityOfflineTriggerResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.activity.offline.trigger";
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
