using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.boss.prod.arrangement.offline.query
    /// </summary>
    public class AlipayBossProdArrangementOfflineQueryRequest : IAopRequest<AlipayBossProdArrangementOfflineQueryResponse>
    {
        /// <summary>
        /// 签约销售方案的主站产品码，目前只支持ONLINE_TRADE_PAY（在线购买签约）和FACE_TO_FACE_PAYMENT（当面付）两个常量值，不允许传入其他值，否则报SYSTEM_ERROR异常。不传值时，默认查询FACE_TO_FACE_PAYM（当面付产品）。
        /// </summary>
        public string ProductCode { get; set; }

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
            return "alipay.boss.prod.arrangement.offline.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("product_code", this.ProductCode);
            return parameters;
        }

        #endregion
    }
}
