using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.campaign.drawcamp.trigger
    /// 营销抽奖活动触发
    /// </summary>
    public class AlipayMarketingCampaignDrawcampTriggerRequest : BizAopRequest<AlipayMarketingCampaignDrawcampTriggerResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.drawcamp.trigger";
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
