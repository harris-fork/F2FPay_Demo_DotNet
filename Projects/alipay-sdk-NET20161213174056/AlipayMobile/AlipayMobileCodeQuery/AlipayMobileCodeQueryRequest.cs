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

        public override string GetApiName()
        {
            return "alipay.mobile.code.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("qr_token", this.QrToken);
            return parameters;
        }

        #endregion
    }
}
