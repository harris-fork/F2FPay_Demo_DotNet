using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.micropay.order.get
    /// </summary>
    public class AlipayMicropayOrderGetRequest : IAopRequest<AlipayMicropayOrderGetResponse>
    {
        /// <summary>
        /// 支付宝订单号，冻结流水号(创建冻结订单返回)
        /// </summary>
        public string AlipayOrderNo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.micropay.order.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            return parameters;
        }

        #endregion
    }
}
