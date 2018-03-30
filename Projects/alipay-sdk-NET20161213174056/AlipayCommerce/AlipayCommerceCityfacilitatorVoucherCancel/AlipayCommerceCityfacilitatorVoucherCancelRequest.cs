using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.voucher.cancel
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherCancelRequest : IAopRequest<AlipayCommerceCityfacilitatorVoucherCancelResponse>
    {
        /// <summary>
        /// 钱包中地铁票购票，获得核销码，线下渠道商凭核销码撤销该笔交易
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.voucher.cancel";
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
