using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.trade.customs.declare
    /// 统一收单报关接口
    /// </summary>
    public class AlipayTradeCustomsDeclareRequest : BizAopRequest<AlipayTradeCustomsDeclareResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trade.customs.declare";
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
