using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.verify.query
    /// </summary>
    public class AlipayPassVerifyQueryRequest : IAopRequest<AlipayPassVerifyQueryResponse>
    {
        /// <summary>
        /// Alipass对应的核销码串
        /// </summary>
        public string VerifyCode { get; set; }

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
            return "alipay.pass.verify.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("verify_code", this.VerifyCode);
            return parameters;
        }

        #endregion
    }
}
