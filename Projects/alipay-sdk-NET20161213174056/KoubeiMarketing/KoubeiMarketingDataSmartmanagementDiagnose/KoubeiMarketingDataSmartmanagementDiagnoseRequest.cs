using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.data.smartmanagement.diagnose
    /// </summary>
    public class KoubeiMarketingDataSmartmanagementDiagnoseRequest : IAopRequest<KoubeiMarketingDataSmartmanagementDiagnoseResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.smartmanagement.diagnose";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
