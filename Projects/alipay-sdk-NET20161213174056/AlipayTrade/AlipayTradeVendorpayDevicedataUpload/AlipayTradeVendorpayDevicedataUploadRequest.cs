using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trade.vendorpay.devicedata.upload
    /// </summary>
    public class AlipayTradeVendorpayDevicedataUploadRequest : IAopRequest<AlipayTradeVendorpayDevicedataUploadResponse>
    {
        /// <summary>
        /// 厂商支付授权时上传设备数据接口，目前主要包含三星支付。com
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trade.vendorpay.devicedata.upload";
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
