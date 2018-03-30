using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.campaign.recruit.apply.query
    /// </summary>
    public class KoubeiMarketingCampaignRecruitApplyQueryRequest : IAopRequest<KoubeiMarketingCampaignRecruitApplyQueryResponse>
    {
        /// <summary>
        /// 招商商家报名分页查询接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.campaign.recruit.apply.query";
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
