using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.drawcamp.trigger
    /// </summary>
    public class AlipayMarketingCampaignDrawcampTriggerRequest : IAopRequest<AlipayMarketingCampaignDrawcampTriggerResponse>
    {
        /// <summary>
        /// 营销抽奖活动触发
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
