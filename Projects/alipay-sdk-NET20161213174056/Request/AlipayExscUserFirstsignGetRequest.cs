using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.exsc.user.firstsign.get
    /// </summary>
    public class AlipayExscUserFirstsignGetRequest : IAopRequest<AlipayExscUserFirstsignGetResponse>
    {
        /// <summary>
        /// 支付宝 cif的accountNo 格式：支付宝userId+0156
        /// </summary>
        public string AlipayId { get; set; }

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
            return "alipay.exsc.user.firstsign.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_id", this.AlipayId);
            return parameters;
        }

        #endregion
    }
}
