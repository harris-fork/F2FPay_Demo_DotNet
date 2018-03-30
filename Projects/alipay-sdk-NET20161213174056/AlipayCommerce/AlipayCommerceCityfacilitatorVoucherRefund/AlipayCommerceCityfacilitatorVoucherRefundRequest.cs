using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.voucher.refund
    /// 地铁购票发码退款
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherRefundRequest : BizAopRequest<AlipayCommerceCityfacilitatorVoucherRefundResponse>
    {
        

        #region BizAopRequest Members

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
