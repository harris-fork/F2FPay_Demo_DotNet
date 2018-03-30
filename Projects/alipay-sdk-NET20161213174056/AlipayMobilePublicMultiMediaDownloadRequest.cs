using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    public class AlipayMobilePublicMultiMediaDownloadRequest : IAopRequest<AlipayMobilePublicMultiMediaDownloadResponse>
    {

        public string BizContent { get; set; }
        public Stream stream { set; get; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.multimedia.download";
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
