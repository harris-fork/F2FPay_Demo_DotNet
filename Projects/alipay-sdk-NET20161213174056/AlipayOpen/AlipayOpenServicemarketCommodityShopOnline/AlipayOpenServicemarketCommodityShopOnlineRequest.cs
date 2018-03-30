using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.servicemarket.commodity.shop.online
    /// </summary>
    public class AlipayOpenServicemarketCommodityShopOnlineRequest : IAopRequest<AlipayOpenServicemarketCommodityShopOnlineResponse>
    {
        /// <summary>
        /// 门店上架处理
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.commodity.shop.online";
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
