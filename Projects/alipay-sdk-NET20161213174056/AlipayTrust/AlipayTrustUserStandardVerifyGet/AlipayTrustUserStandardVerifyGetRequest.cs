using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.standard.verify.get
    /// </summary>
    public class AlipayTrustUserStandardVerifyGetRequest : IAopRequest<AlipayTrustUserStandardVerifyGetResponse>
    {
        /// <summary>
        /// 详见说明文档和代码样例
        /// </summary>
        public string AliTrustUserInfo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trust.user.standard.verify.get";
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
