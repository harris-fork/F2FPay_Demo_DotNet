using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.deposit.query
    /// 商户查询用户的充值转账记录
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryRequest : BizAopRequest<AlipayCommerceCityfacilitatorDepositQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.deposit.query";
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
