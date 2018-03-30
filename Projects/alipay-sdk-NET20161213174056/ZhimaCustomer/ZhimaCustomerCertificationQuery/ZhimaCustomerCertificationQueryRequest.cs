using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.customer.certification.query
    /// 芝麻认证查询
    /// </summary>
    public class ZhimaCustomerCertificationQueryRequest : BizAopRequest<ZhimaCustomerCertificationQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "zhima.customer.certification.query";
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
