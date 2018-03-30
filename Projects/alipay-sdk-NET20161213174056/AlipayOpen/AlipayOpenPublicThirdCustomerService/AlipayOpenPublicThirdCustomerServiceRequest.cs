using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.third.customer.service
    /// </summary>
    public class AlipayOpenPublicThirdCustomerServiceRequest : IAopRequest<AlipayOpenPublicThirdCustomerServiceResponse>
    {
        /// <summary>
        /// 服务窗第三方渠道商配置接口，用于记录服务窗商户授权的第三方渠道商
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.third.customer.service";
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
