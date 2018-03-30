using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.campaign.crowd.count
    /// 口碑商户人群组数目统计接口
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCountRequest : BizAopRequest<KoubeiMarketingCampaignCrowdCountResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.campaign.crowd.count";
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
