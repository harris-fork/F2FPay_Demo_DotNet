using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.campaign.activity.batchquery
    /// 口碑营销活动列表查询
    /// </summary>
    public class KoubeiMarketingCampaignActivityBatchqueryRequest : BizAopRequest<KoubeiMarketingCampaignActivityBatchqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.campaign.activity.batchquery";
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
