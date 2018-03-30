using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.contact.follow.list
    /// </summary>
    public class AlipayMobilePublicContactFollowListRequest : IAopRequest<AlipayMobilePublicContactFollowListResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.contact.follow.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
