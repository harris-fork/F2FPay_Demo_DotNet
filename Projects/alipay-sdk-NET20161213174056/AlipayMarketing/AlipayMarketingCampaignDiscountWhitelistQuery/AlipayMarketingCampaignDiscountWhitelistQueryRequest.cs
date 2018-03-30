using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.campaign.discount.whitelist.query
    /// 优惠活动白名单查询
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistQueryRequest : BizAopRequest<AlipayMarketingCampaignDiscountWhitelistQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.discount.whitelist.query";
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
