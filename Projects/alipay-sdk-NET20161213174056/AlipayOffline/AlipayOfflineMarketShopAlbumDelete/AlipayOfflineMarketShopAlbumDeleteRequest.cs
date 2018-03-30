using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.album.delete
    /// </summary>
    public class AlipayOfflineMarketShopAlbumDeleteRequest : IAopRequest<AlipayOfflineMarketShopAlbumDeleteResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.album.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
