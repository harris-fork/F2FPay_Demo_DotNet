using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pcredit.loan.apply.create
    /// </summary>
    public class AlipayPcreditLoanApplyCreateRequest : IAopRequest<AlipayPcreditLoanApplyCreateResponse>
    {
        /// <summary>
        /// 用户申贷
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.pcredit.loan.apply.create";
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
