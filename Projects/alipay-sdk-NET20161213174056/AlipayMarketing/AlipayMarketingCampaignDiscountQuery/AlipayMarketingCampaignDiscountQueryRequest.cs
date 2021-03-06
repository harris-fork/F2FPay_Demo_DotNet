using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.campaign.discount.query
    /// 优惠活动查看
    /// </summary>
    public class AlipayMarketingCampaignDiscountQueryRequest : BizAopRequest<AlipayMarketingCampaignDiscountQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.campaign.discount.query";
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
