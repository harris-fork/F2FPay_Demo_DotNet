using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.member.retailer.query
    /// </summary>
    public class KoubeiMemberRetailerQueryRequest : IAopRequest<KoubeiMemberRetailerQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.member.retailer.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
