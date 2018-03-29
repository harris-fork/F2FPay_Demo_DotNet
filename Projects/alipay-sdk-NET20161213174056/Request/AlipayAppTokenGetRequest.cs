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
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.app.token.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("secret", this.Secret);
            return parameters;
        }

        #endregion
    }
}
