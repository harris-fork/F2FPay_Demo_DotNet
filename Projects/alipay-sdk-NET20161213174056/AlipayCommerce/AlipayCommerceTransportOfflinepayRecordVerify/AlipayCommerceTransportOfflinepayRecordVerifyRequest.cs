using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.transport.offlinepay.record.verify
    /// </summary>
    public class AlipayCommerceTransportOfflinepayRecordVerifyRequest : IAopRequest<AlipayCommerceTransportOfflinepayRecordVerifyResponse>
    {
        /// <summary>
        /// 支付宝脱机操作信息验证
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
