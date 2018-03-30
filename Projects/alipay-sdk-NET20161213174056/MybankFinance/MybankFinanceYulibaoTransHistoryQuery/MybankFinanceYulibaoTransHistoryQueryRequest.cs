using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// mybank.finance.yulibao.trans.history.query
    /// 余利宝历史交易查询
    /// </summary>
    public class MybankFinanceYulibaoTransHistoryQueryRequest : BizAopRequest<MybankFinanceYulibaoTransHistoryQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "mybank.finance.yulibao.trans.history.query";
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
