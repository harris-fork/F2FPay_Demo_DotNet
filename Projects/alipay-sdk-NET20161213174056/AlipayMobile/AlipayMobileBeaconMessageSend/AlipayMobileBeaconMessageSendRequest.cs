using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.beacon.message.send
    /// </summary>
    public class AlipayMobileBeaconMessageSendRequest : IAopRequest<AlipayMobileBeaconMessageSendResponse>
    {
        /// <summary>
        /// 设备关联数据
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.beacon.message.send";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
