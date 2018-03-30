using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.shake.user.query
    /// </summary>
    public class AlipayMobileShakeUserQueryRequest : IAopRequest<AlipayMobileShakeUserQueryResponse>
    {
        /// <summary>
        /// 动态ID
        /// </summary>
        public string DynamicId { get; set; }

        /// <summary>
        /// 动态ID类型：  wave_code：声波  qr_code：二维码  bar_code：条码
        /// </summary>
        public string DynamicIdType { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.shake.user.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("dynamic_id", this.DynamicId);
            parameters.Add("dynamic_id_type", this.DynamicIdType);
            return parameters;
        }

        #endregion
    }
}
