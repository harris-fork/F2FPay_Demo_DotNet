using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.bksigntoken.verify
    /// </summary>
    public class AlipayMobileBksigntokenVerifyRequest : IAopRequest<AlipayMobileBksigntokenVerifyResponse>
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        public string Deviceid { get; set; }

        /// <summary>
        /// 调用来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 查询token
        /// </summary>
        public string Token { get; set; }

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
            return "alipay.mobile.bksigntoken.verify";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("deviceid", this.Deviceid);
            parameters.Add("source", this.Source);
            parameters.Add("token", this.Token);
            return parameters;
        }

        #endregion
    }
}
