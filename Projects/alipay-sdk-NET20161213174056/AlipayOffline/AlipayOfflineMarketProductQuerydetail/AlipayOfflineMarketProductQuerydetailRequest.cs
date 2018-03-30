using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.product.querydetail
    /// </summary>
    public class AlipayOfflineMarketProductQuerydetailRequest : IAopRequest<AlipayOfflineMarketProductQuerydetailResponse>
    {
        /// <summary>
        /// 通过该接口可以查询商户录入的指定商品详细信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.product.querydetail";
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
