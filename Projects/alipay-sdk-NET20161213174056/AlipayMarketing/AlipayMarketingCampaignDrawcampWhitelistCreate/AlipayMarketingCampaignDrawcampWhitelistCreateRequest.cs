using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.campaign.drawcamp.whitelist.create
    /// 营销抽奖活动白名单创建
    /// </summary>
    public class AlipayMarketingCampaignDrawcampWhitelistCreateRequest : BizAopRequest<AlipayMarketingCampaignDrawcampWhitelistCreateResponse>
    {
        

        #region BizAopRequest Members

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
