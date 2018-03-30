using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.account.exrate.advice.accept
    /// 标准的兑换交易受理接口
    /// </summary>
    public class AlipayAccountExrateAdviceAcceptRequest : BizAopRequest<AlipayAccountExrateAdviceAcceptResponse>
    {
        

        #region BizAopRequest Members

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
