using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.voucher.generate
    /// 地铁购票核销码发码
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherGenerateRequest : BizAopRequest<AlipayCommerceCityfacilitatorVoucherGenerateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.voucher.generate";
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
