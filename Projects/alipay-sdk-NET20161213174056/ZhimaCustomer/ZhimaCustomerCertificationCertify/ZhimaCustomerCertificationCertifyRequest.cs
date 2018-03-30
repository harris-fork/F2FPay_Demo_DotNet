using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.customer.certification.certify
    /// </summary>
    public class ZhimaCustomerCertificationCertifyRequest : IAopRequest<ZhimaCustomerCertificationCertifyResponse>
    {
        /// <summary>
        /// 芝麻认证开始认证
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "zhima.customer.certification.certify";
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
