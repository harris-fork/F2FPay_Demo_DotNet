using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.album.bind
    /// </summary>
    public class AlipayOfflineMarketShopAlbumBindRequest : IAopRequest<AlipayOfflineMarketShopAlbumBindResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.album.bind";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
