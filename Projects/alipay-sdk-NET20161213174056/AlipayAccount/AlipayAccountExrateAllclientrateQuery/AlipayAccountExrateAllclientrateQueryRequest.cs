using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.account.exrate.allclientrate.query
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryRequest : IAopRequest<AlipayAccountExrateAllclientrateQueryResponse>
    {
        /// <summary>
        /// 查询客户的所有币种对最新有效汇率
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
