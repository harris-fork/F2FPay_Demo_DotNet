using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.bill.pay.status
    /// </summary>
    public class AlipayEbppPdeductBillPayStatusRequest : IAopRequest<AlipayEbppPdeductBillPayStatusResponse>
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 商户代扣业务流水
        /// </summary>
        public string OutOrderNo { get; set; }

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
            return "alipay.ebpp.pdeduct.bill.pay.status";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("out_order_no", this.OutOrderNo);
            return parameters;
        }

        #endregion
    }
}
