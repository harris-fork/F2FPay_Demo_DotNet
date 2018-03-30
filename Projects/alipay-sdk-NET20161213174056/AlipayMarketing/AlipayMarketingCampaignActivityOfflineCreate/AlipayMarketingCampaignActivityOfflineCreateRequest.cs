using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.activity.offline.create
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateRequest : IAopRequest<AlipayMarketingCampaignActivityOfflineCreateResponse>
    {
        /// <summary>
        /// 能够创商户建领券活动,后续支持
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.activity.offline.create";
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
