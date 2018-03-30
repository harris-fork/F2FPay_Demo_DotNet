using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.public.bind
    /// </summary>
    public class AlipayOfflineMarketShopPublicBindRequest : IAopRequest<AlipayOfflineMarketShopPublicBindResponse>
    {
        /// <summary>
        /// 是否绑定所有门店，T表示绑定所有门店，F表示绑定指定shop_ids的门店
        /// </summary>
        public string IsAll { get; set; }

        /// <summary>
        /// 门店ID列表，一次最多绑定500个门店，is_all为T时表示绑定本商家下所有门店，即门店列表无需通过本参数shop_ids传入，由系统自动查询;is_all为F时该参数为必填
        /// </summary>
        public string ShopIds { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.public.bind";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("is_all", this.IsAll);
            parameters.Add("shop_ids", this.ShopIds);
            return parameters;
        }

        #endregion
    }
}
