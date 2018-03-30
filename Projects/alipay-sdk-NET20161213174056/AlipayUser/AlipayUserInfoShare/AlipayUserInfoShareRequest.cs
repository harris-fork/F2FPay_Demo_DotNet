using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.info.share
    /// </summary>
    public class AlipayUserInfoShareRequest : IAopRequest<AlipayUserInfoShareResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.info.share";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
