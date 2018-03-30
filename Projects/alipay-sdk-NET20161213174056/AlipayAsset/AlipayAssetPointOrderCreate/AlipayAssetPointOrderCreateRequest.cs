using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.point.order.create
    /// </summary>
    public class AlipayAssetPointOrderCreateRequest : IAopRequest<AlipayAssetPointOrderCreateResponse>
    {
        /// <summary>
        /// 商户在采购完集分宝后可以通过此接口发放集分宝
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.asset.point.order.create";
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
