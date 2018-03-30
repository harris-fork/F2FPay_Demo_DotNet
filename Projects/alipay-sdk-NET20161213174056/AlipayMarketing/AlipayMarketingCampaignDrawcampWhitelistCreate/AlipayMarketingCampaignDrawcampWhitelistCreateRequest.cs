using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.drawcamp.whitelist.create
    /// </summary>
    public class AlipayMarketingCampaignDrawcampWhitelistCreateRequest : IAopRequest<AlipayMarketingCampaignDrawcampWhitelistCreateResponse>
    {
        /// <summary>
        /// 营销抽奖活动白名单创建
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.drawcamp.whitelist.create";
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
