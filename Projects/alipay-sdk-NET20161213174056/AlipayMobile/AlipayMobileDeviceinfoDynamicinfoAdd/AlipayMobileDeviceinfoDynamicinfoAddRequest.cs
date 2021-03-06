using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.deviceinfo.dynamicinfo.add
    /// </summary>
    public class AlipayMobileDeviceinfoDynamicinfoAddRequest : IAopRequest<AlipayMobileDeviceinfoDynamicinfoAddResponse>
    {
        /// <summary>
        /// 蚂蚁金服集团生成的设备id
        /// </summary>
        public string Apdid { get; set; }

        /// <summary>
        /// 客户端采集的设备动态信息，格式为json串
        /// </summary>
        public string Dynamicinfo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.deviceinfo.dynamicinfo.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("apdid", this.Apdid);
            parameters.Add("dynamicinfo", this.Dynamicinfo);
            return parameters;
        }

        #endregion
    }
}
