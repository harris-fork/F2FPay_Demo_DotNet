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

        public override string GetApiName()
        {
            return "alipay.ebpp.pdeduct.bill.pay.status";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("out_order_no", this.OutOrderNo);
            return parameters;
        }

        #endregion
    }
}
