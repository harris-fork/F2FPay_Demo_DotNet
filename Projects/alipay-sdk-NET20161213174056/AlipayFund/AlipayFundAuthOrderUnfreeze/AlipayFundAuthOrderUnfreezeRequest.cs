using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.fund.auth.order.unfreeze
    /// </summary>
    public class AlipayFundAuthOrderUnfreezeRequest : IAopRequest<AlipayFundAuthOrderUnfreezeResponse>
    {
        /// <summary>
        /// 预授权资金解冻接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.fund.auth.order.unfreeze";
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