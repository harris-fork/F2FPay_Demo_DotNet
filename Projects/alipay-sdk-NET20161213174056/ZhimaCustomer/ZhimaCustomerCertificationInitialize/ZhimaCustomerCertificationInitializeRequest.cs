using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.customer.certification.initialize
    /// 认证初始化
    /// </summary>
    public class ZhimaCustomerCertificationInitializeRequest : BizAopRequest<ZhimaCustomerCertificationInitializeResponse>
    {
        

        #region BizAopRequest Members

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
