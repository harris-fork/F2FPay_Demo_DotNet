using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.account.get
    /// </summary>
    public class AlipayUserAccountGetRequest : IAopRequest<AlipayUserAccountGetResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.account.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
