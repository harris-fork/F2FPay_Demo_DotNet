using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.voucher.upload
    /// 钱包中地铁票购票，获得核销码，线下地铁自助购票机上凭核销码取票，票号上传接口
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherUploadRequest : BizAopRequest<AlipayCommerceCityfacilitatorVoucherUploadResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.voucher.upload";
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
