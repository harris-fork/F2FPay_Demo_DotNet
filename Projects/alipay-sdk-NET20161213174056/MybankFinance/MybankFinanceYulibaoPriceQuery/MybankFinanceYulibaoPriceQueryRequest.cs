using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// mybank.finance.yulibao.price.query
    /// 查询余利宝行情信息（七日年化收益率、万份收益金额）
    /// </summary>
    public class MybankFinanceYulibaoPriceQueryRequest : BizAopRequest<MybankFinanceYulibaoPriceQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "mybank.finance.yulibao.price.query";
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
