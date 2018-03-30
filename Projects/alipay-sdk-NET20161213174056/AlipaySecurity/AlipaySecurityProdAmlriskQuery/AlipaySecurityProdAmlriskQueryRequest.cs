using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.prod.amlrisk.query
    /// </summary>
    public class AlipaySecurityProdAmlriskQueryRequest : IAopRequest<AlipaySecurityProdAmlriskQueryResponse>
    {
        /// <summary>
        /// 该API用于外部商户准入时的反洗钱风险分析。
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.prod.amlrisk.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
