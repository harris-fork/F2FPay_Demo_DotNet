using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.userinfo.share
    /// </summary>
    public class AlipayUserUserinfoShareRequest : IAopRequest<AlipayUserUserinfoShareResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.userinfo.share";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
