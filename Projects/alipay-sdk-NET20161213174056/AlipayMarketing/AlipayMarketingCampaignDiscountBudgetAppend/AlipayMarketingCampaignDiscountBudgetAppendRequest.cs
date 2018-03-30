using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.discount.budget.append
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetAppendRequest : IAopRequest<AlipayMarketingCampaignDiscountBudgetAppendResponse>
    {
        /// <summary>
        /// 营销立减活动预算追加
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.discount.budget.append";
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
