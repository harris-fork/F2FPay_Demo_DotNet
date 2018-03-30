using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.deposit.confirm
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositConfirmRequest : IAopRequest<AlipayCommerceCityfacilitatorDepositConfirmResponse>
    {
        /// <summary>
        /// 合作渠道可通过该接口补登单笔圈存确认扣款请求，以帮助支付宝将用户的资金结算给指定的渠道，不支持单笔拆分
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.deposit.confirm";
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
