using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.data.customtag.batchquery
    /// </summary>
    public class KoubeiMarketingDataCustomtagBatchqueryRequest : IAopRequest<KoubeiMarketingDataCustomtagBatchqueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.customtag.batchquery";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
