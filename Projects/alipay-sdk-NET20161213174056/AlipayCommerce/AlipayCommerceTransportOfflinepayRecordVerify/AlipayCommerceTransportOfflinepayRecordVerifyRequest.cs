using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.transport.offlinepay.record.verify
    /// 支付宝脱机操作信息验证
    /// </summary>
    public class AlipayCommerceTransportOfflinepayRecordVerifyRequest : BizAopRequest<AlipayCommerceTransportOfflinepayRecordVerifyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.transport.offlinepay.record.verify";
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
