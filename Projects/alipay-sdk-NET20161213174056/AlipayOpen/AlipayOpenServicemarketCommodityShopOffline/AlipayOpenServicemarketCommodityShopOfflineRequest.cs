using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.servicemarket.commodity.shop.offline
    /// </summary>
    public class AlipayOpenServicemarketCommodityShopOfflineRequest : IAopRequest<AlipayOpenServicemarketCommodityShopOfflineResponse>
    {
        /// <summary>
        /// 下架商户门店
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.commodity.shop.offline";
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
