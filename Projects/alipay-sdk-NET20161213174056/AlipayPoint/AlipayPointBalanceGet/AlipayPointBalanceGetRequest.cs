using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.point.balance.get
    /// </summary>
    public class AlipayPointBalanceGetRequest : IAopRequest<AlipayPointBalanceGetResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.point.balance.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
