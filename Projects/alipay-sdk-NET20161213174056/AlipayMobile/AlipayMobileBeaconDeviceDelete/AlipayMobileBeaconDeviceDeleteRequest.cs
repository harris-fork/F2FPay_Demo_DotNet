using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.beacon.device.delete
    /// </summary>
    public class AlipayMobileBeaconDeviceDeleteRequest : IAopRequest<AlipayMobileBeaconDeviceDeleteResponse>
    {
        /// <summary>
        /// 删除的设备的UUID
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.beacon.device.delete";
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
