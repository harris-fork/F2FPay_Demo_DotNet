using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.album.unbind
    /// </summary>
    public class AlipayOfflineMarketShopAlbumUnbindRequest : IAopRequest<AlipayOfflineMarketShopAlbumUnbindResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.album.unbind";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
