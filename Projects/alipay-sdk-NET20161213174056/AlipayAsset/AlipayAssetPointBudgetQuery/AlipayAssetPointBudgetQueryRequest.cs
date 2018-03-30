using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.point.budget.query
    /// </summary>
    public class AlipayAssetPointBudgetQueryRequest : IAopRequest<AlipayAssetPointBudgetQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.asset.point.budget.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
