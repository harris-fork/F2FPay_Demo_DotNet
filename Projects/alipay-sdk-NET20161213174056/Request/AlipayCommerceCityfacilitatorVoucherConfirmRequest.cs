using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.voucher.confirm
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherConfirmRequest : IAopRequest<AlipayCommerceCityfacilitatorVoucherConfirmResponse>
    {
        /// <summary>
        /// 钱包中地铁票购票，获得核销码，线下地铁自助购票机上凭核销码取票,购票确认
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.voucher.confirm";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
