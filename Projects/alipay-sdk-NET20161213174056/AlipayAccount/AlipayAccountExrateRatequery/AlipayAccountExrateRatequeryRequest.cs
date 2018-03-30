using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.account.exrate.ratequery
    /// </summary>
    public class AlipayAccountExrateRatequeryRequest : IAopRequest<AlipayAccountExrateRatequeryResponse>
    {
        /// <summary>
        /// 对于部分签约境内当面付的商家，为了能够在境外进行推广，因此需要汇率进行币种之间的转换，本接口提供此业务场景下的汇率查询服务
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.account.exrate.ratequery";
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
