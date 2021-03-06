using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.trade.query
    /// 统一收单线下交易查询  修改路由策略到R
    /// </summary>
    public class AlipayTradeQueryRequest : BizAopRequest<AlipayTradeQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trade.query";
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
