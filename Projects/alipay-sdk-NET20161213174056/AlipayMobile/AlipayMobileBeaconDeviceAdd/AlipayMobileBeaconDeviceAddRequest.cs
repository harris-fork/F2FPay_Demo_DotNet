using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.beacon.device.add
    /// </summary>
    public class AlipayMobileBeaconDeviceAddRequest : IAopRequest<AlipayMobileBeaconDeviceAddResponse>
    {
        /// <summary>
        /// 蓝牙设备信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.beacon.device.add";
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
