using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.deposit.cancel
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositCancelRequest : IAopRequest<AlipayCommerceCityfacilitatorDepositCancelResponse>
    {
        /// <summary>
        /// 合作渠道可通过该接口补登扣款取消请求，以帮助支付宝将用户的资金退给用户
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.deposit.cancel";
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
