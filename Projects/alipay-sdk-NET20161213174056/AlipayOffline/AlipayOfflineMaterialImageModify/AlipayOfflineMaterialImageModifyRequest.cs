using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.material.image.modify
    /// </summary>
    public class AlipayOfflineMaterialImageModifyRequest : IAopRequest<AlipayOfflineMaterialImageModifyResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.material.image.modify";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
