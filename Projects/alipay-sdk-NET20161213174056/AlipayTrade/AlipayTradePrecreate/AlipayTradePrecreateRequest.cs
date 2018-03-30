using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trade.precreate
    /// </summary>
    public class AlipayTradePrecreateRequest : IAopRequest<AlipayTradePrecreateResponse>
    {
        /// <summary>
        /// 收银员通过收银台或商户后台调用支付宝接口，生成二维码后，展示给伤脑筋户，由用户扫描二维码完成订单支付。  修改路由策略到R
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trade.precreate";
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
