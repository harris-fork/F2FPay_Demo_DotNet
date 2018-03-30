using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.account.exrate.allclientrate.query
    /// 查询客户的所有币种对最新有效汇率
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryRequest : BizAopRequest<AlipayAccountExrateAllclientrateQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.account.exrate.allclientrate.query";
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
