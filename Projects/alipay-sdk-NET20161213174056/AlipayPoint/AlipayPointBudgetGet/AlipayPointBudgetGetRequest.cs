using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.point.budget.get
    /// </summary>
    public class AlipayPointBudgetGetRequest : IAopRequest<AlipayPointBudgetGetResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.point.budget.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
