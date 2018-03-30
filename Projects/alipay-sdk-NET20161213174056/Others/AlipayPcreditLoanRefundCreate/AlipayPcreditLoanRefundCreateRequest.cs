using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pcredit.loan.refund.create
    /// </summary>
    public class AlipayPcreditLoanRefundCreateRequest : IAopRequest<AlipayPcreditLoanRefundCreateResponse>
    {
        /// <summary>
        /// 商户还款
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.pcredit.loan.refund.create";
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
