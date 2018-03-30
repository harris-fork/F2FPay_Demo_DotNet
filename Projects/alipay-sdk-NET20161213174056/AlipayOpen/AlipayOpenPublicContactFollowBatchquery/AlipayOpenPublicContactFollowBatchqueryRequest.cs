using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.contact.follow.batchquery
    /// </summary>
    public class AlipayOpenPublicContactFollowBatchqueryRequest : IAopRequest<AlipayOpenPublicContactFollowBatchqueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.contact.follow.batchquery";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
