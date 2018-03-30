using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.score.get
    /// </summary>
    public class AlipayTrustUserScoreGetRequest : IAopRequest<AlipayTrustUserScoreGetResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trust.user.score.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
