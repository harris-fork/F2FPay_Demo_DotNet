using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.voucher.query
    /// 钱包中地铁票购票，获得核销码，线下地铁自助购票机上凭核销码取票，渠道商凭用户输入的核销码调接口查询核销码的有效性。
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherQueryRequest : BizAopRequest<AlipayCommerceCityfacilitatorVoucherQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.voucher.query";
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
