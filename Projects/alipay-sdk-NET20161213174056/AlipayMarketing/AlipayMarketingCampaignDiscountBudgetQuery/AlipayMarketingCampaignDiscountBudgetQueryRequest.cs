using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.campaign.discount.budget.query
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetQueryRequest : IAopRequest<AlipayMarketingCampaignDiscountBudgetQueryResponse>
    {
        /// <summary>
        /// 营销立减活动预算查询
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.discount.budget.query";
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
