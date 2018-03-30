using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.servicemarket.commodity.shop.offline
    /// 下架商户门店
    /// </summary>
    public class AlipayOpenServicemarketCommodityShopOfflineRequest : BizAopRequest<AlipayOpenServicemarketCommodityShopOfflineResponse>
    {
        

        #region BizAopRequest Members

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
