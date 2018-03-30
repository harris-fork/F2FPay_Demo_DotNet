using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.deposit.confirm
    /// 合作渠道可通过该接口补登单笔圈存确认扣款请求，以帮助支付宝将用户的资金结算给指定的渠道，不支持单笔拆分
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositConfirmRequest : BizAopRequest<AlipayCommerceCityfacilitatorDepositConfirmResponse>
    {
        

        #region BizAopRequest Members

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
