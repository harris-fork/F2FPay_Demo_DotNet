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

        public override string GetApiName()
        {
            return "alipay.exsc.user.firstsign.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_id", this.AlipayId);
            return parameters;
        }

        #endregion
    }
}
