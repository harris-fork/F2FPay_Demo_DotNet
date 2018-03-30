using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.public.third.customer.service
    /// 服务窗第三方渠道商配置接口，用于记录服务窗商户授权的第三方渠道商
    /// </summary>
    public class AlipayOpenPublicThirdCustomerServiceRequest : BizAopRequest<AlipayOpenPublicThirdCustomerServiceResponse>
    {
        

        #region BizAopRequest Members

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
