using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.customer.certification.initialize
    /// </summary>
    public class ZhimaCustomerCertificationInitializeRequest : IAopRequest<ZhimaCustomerCertificationInitializeResponse>
    {
        /// <summary>
        /// 认证初始化
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "zhima.customer.certification.initialize";
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