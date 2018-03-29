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
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public bool NeedEncrypt { get; set; }
        public AopObject BizModel { get; set; }

        public string GetApiName()
        {
            return "alipay.mobile.public.multimedia.download";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
