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

        public override string GetApiName()
        {
            return "alipay.mobile.bksigntoken.verify";
        }

        public override IDictionary<string, string> GetParameters()
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
