using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.album.create
    /// </summary>
    public class AlipayOfflineMarketShopAlbumCreateRequest : IAopRequest<AlipayOfflineMarketShopAlbumCreateResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.album.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
