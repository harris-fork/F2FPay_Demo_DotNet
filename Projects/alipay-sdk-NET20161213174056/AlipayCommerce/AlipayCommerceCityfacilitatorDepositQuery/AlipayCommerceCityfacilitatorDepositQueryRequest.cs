using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.cityfacilitator.deposit.query
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryRequest : IAopRequest<AlipayCommerceCityfacilitatorDepositQueryResponse>
    {
        /// <summary>
        /// 商户查询用户的充值转账记录
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
