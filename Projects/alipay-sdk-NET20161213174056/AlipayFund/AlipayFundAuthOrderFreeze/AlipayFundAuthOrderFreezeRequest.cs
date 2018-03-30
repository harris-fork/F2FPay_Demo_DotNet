using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.fund.auth.order.freeze
    /// 资金预授权冻结接口
    /// </summary>
    public class AlipayFundAuthOrderFreezeRequest : BizAopRequest<AlipayFundAuthOrderFreezeResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.fund.auth.order.freeze";
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
