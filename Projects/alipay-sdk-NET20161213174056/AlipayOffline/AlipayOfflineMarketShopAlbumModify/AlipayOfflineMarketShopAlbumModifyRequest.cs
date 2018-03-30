using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.album.modify
    /// </summary>
    public class AlipayOfflineMarketShopAlbumModifyRequest : IAopRequest<AlipayOfflineMarketShopAlbumModifyResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.album.modify";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
