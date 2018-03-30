using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.beacon.device.modify
    /// 设备信息，格式为JSON字符串
    /// </summary>
    public class AlipayMobileBeaconDeviceModifyRequest : BizAopRequest<AlipayMobileBeaconDeviceModifyResponse>
    {
        

        #region BizAopRequest Members

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
