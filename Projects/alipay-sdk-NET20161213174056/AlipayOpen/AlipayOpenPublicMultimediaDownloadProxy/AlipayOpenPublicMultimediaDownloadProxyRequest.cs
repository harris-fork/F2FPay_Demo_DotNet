using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.multimedia.download.proxy
    /// </summary>
    public class AlipayOpenPublicMultimediaDownloadProxyRequest : IAopRequest<AlipayOpenPublicMultimediaDownloadProxyResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.multimedia.download.proxy";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
