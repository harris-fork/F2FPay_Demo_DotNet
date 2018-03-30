using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.point.order.query
    /// </summary>
    public class AlipayAssetPointOrderQueryRequest : IAopRequest<AlipayAssetPointOrderQueryResponse>
    {
        /// <summary>
        /// 商户在调用集分宝发放接口后可以通过此接口查询发放情况
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.asset.point.order.query";
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
