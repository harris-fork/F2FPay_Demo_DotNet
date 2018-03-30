using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.city.query
    /// </summary>
    public class AlipayCommerceCityfacilitatorCityQueryRequest : IAopRequest<AlipayCommerceCityfacilitatorCityQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.city.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
