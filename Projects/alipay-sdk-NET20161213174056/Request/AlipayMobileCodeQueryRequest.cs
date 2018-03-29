using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.code.query
    /// </summary>
    public class AlipayMobileCodeQueryRequest : IAopRequest<AlipayMobileCodeQueryResponse>
    {
        /// <summary>
        /// 二维码的码值或者包含业务信息的二维码
        /// </summary>
        public string QrToken { get; set; }

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
            return "alipay.mobile.code.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("qr_token", this.QrToken);
            return parameters;
        }

        #endregion
    }
}
