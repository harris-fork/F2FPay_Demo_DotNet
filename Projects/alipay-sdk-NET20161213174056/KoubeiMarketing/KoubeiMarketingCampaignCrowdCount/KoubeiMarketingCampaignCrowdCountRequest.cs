using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.campaign.crowd.count
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCountRequest : IAopRequest<KoubeiMarketingCampaignCrowdCountResponse>
    {
        /// <summary>
        /// 口碑商户人群组数目统计接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
