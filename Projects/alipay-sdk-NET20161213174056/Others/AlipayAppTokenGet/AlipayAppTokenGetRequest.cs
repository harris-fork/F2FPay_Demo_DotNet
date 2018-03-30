using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.app.token.get
    /// </summary>
    public class AlipayAppTokenGetRequest : IAopRequest<AlipayAppTokenGetResponse>
    {
        /// <summary>
        /// 应用安全码
        /// </summary>
        public string Secret { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.app.token.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("secret", this.Secret);
            return parameters;
        }

        #endregion
    }
}
