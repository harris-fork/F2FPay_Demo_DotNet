using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.point.balance.query
    /// </summary>
    public class AlipayAssetPointBalanceQueryRequest : IAopRequest<AlipayAssetPointBalanceQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.asset.point.balance.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
