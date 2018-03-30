using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.deposit.cancel
    /// 合作渠道可通过该接口补登扣款取消请求，以帮助支付宝将用户的资金退给用户
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositCancelRequest : BizAopRequest<AlipayCommerceCityfacilitatorDepositCancelResponse>
    {
        

        #region BizAopRequest Members

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
