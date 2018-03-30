using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: mybank.finance.yulibao.account.query
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryRequest : IAopRequest<MybankFinanceYulibaoAccountQueryResponse>
    {
        /// <summary>
        /// 余利宝账户和收益查询
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "mybank.finance.yulibao.account.query";
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
