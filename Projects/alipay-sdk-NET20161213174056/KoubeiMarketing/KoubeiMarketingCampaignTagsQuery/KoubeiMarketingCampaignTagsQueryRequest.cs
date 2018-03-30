using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.campaign.tags.query
    /// </summary>
    public class KoubeiMarketingCampaignTagsQueryRequest : IAopRequest<KoubeiMarketingCampaignTagsQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.campaign.tags.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
