using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.campaign.crowd.detail.query
    /// 口碑商户人群组详情查询接口
    /// </summary>
    public class KoubeiMarketingCampaignCrowdDetailQueryRequest : BizAopRequest<KoubeiMarketingCampaignCrowdDetailQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.campaign.crowd.detail.query";
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
