using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: mybank.finance.yulibao.capital.purchase
    /// </summary>
    public class MybankFinanceYulibaoCapitalPurchaseRequest : IAopRequest<MybankFinanceYulibaoCapitalPurchaseResponse>
    {
        /// <summary>
        /// 网商银行余利宝签约
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "mybank.finance.yulibao.capital.purchase";
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
