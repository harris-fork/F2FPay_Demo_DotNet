using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.prod.alipay.security.prod.test
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestRequest : IAopRequest<AlipaySecurityProdAlipaySecurityProdTestResponse>
    {
        /// <summary>
        /// 安全业务操作
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.prod.alipay.security.prod.test";
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
