using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.report.get
    /// </summary>
    public class AlipayTrustUserReportGetRequest : IAopRequest<AlipayTrustUserReportGetResponse>
    {
        /// <summary>
        /// 指定该接口在商户端的使用场景。具体枚举值在样例代码中给出
        /// </summary>
        public string Scene { get; set; }

        /// <summary>
        /// FN_S（金融简版）
        /// </summary>
        public string Type { get; set; }

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
            return "alipay.trust.user.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("scene", this.Scene);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
