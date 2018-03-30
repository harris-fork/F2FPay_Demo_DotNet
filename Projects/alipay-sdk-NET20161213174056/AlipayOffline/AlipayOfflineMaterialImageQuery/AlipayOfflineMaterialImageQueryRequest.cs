using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.material.image.query
    /// </summary>
    public class AlipayOfflineMaterialImageQueryRequest : IAopRequest<AlipayOfflineMaterialImageQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.material.image.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
