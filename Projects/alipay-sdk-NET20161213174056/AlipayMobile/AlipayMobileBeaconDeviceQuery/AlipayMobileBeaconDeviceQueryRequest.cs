using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.beacon.device.query
    /// </summary>
    public class AlipayMobileBeaconDeviceQueryRequest : IAopRequest<AlipayMobileBeaconDeviceQueryResponse>
    {
        /// <summary>
        /// 设备的UUID
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.beacon.device.query";
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
