using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.trade.vendorpay.devicedata.upload
    /// 厂商支付授权时上传设备数据接口，目前主要包含三星支付。com
    /// </summary>
    public class AlipayTradeVendorpayDevicedataUploadRequest : BizAopRequest<AlipayTradeVendorpayDevicedataUploadResponse>
    {
        

        #region BizAopRequest Members

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
