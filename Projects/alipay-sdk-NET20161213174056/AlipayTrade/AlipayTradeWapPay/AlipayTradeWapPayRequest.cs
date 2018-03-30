using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.trade.wap.pay
    /// 手机网站支付接口2.0
    /// </summary>
    public class AlipayTradeWapPayRequest : BizAopRequest<AlipayTradeWapPayResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trade.wap.pay";
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
