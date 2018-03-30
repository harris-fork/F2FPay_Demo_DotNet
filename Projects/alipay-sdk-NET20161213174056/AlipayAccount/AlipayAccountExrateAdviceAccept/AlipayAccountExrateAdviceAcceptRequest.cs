using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.account.exrate.advice.accept
    /// </summary>
    public class AlipayAccountExrateAdviceAcceptRequest : IAopRequest<AlipayAccountExrateAdviceAcceptResponse>
    {
        /// <summary>
        /// 标准的兑换交易受理接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.account.exrate.advice.accept";
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
