using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.beacon.device.modify
    /// </summary>
    public class AlipayMobileBeaconDeviceModifyRequest : IAopRequest<AlipayMobileBeaconDeviceModifyResponse>
    {
        /// <summary>
        /// 设备信息，格式为JSON字符串
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.beacon.device.modify";
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
