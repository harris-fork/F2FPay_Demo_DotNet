using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.public.unbind
    /// </summary>
    public class AlipayOfflineMarketShopPublicUnbindRequest : IAopRequest<AlipayOfflineMarketShopPublicUnbindResponse>
    {
        /// <summary>
        /// 是否解绑所有门店，T表示解绑所有门店，F表示解绑指定shop_ids的门店列表
        /// </summary>
        public string IsAll { get; set; }

        /// <summary>
        /// 解除绑定门店的ID列表，一次最多解绑100个门店，is_all为T时表示解除绑定本商家下所有门店，即门店列表无需通过本参数shop_ids传入，由系统自动查询;is_all为F时该参数必填
        /// </summary>
        public string ShopIds { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.offline.market.shop.public.unbind";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("is_all", this.IsAll);
            parameters.Add("shop_ids", this.ShopIds);
            return parameters;
        }

        #endregion
    }
}
