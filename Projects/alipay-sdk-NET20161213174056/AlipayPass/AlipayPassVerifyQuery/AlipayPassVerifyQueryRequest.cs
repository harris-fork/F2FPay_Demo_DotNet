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

        public override string GetApiName()
        {
            return "alipay.pass.verify.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("verify_code", this.VerifyCode);
            return parameters;
        }

        #endregion
    }
}
