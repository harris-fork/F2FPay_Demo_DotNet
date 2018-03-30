using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// mybank.finance.yulibao.account.query
    /// 余利宝账户和收益查询
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryRequest : BizAopRequest<MybankFinanceYulibaoAccountQueryResponse>
    {
        

        #region BizAopRequest Members

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
