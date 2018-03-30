using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.discount.whitelist.update
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistUpdateRequest : IAopRequest<AlipayMarketingCampaignDiscountWhitelistUpdateResponse>
    {
        /// <summary>
        /// 优惠活动白名单设置
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.discount.whitelist.update";
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
