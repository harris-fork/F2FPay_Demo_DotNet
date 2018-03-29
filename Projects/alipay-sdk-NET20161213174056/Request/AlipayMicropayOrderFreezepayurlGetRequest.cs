using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.micropay.order.freezepayurl.get
    /// </summary>
    public class AlipayMicropayOrderFreezepayurlGetRequest : IAopRequest<AlipayMicropayOrderFreezepayurlGetResponse>
    {
        /// <summary>
        /// 冻结订单号,创建冻结订单时支付宝返回的
        /// </summary>
        public string AlipayOrderNo { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.micropay.order.freezepayurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            return parameters;
        }

        #endregion
    }
}
