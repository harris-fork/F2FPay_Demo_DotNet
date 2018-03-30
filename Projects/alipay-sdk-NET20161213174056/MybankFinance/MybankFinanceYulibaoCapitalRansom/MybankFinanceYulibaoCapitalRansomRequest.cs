using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// mybank.finance.yulibao.capital.ransom
    /// 网商银行余利宝赎回
    /// </summary>
    public class MybankFinanceYulibaoCapitalRansomRequest : BizAopRequest<MybankFinanceYulibaoCapitalRansomResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "mybank.finance.yulibao.capital.ransom";
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
