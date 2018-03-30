using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.auth.send
    /// </summary>
    public class AlipayTrustUserAuthSendRequest : IAopRequest<AlipayTrustUserAuthSendResponse>
    {
        /// <summary>
        /// 申请授权的用户信息
        /// </summary>
        public string AliTrustUserInfo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trust.user.auth.send";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("ali_trust_user_info", this.AliTrustUserInfo);
            return parameters;
        }

        #endregion
    }
}
