using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.voucher.refund
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherRefundRequest : IAopRequest<AlipayCommerceCityfacilitatorVoucherRefundResponse>
    {
        /// <summary>
        /// 地铁购票发码退款
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.voucher.refund";
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
