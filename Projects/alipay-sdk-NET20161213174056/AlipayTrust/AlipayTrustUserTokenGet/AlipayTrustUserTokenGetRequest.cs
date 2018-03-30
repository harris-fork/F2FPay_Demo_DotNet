using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.token.get
    /// </summary>
    public class AlipayTrustUserTokenGetRequest : IAopRequest<AlipayTrustUserTokenGetResponse>
    {
        /// <summary>
        /// 入参json串
        /// </summary>
        public string AliTrustUserInfo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trust.user.token.get";
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
