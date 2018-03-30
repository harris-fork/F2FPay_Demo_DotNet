using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.marketing.voucher.code.upload
    /// </summary>
    public class AlipayOfflineMarketingVoucherCodeUploadRequest : IAopUploadRequest<AlipayOfflineMarketingVoucherCodeUploadResponse>
    {
        /// <summary>
        /// 约定的扩展参数
        /// </summary>
        public string ExtendParams { get; set; }

        /// <summary>
        /// 文件编码
        /// </summary>
        public string FileCharset { get; set; }

        /// <summary>
        /// 文件二进制内容
        /// </summary>
        public FileItem FileContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.marketing.voucher.code.upload";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("extend_params", this.ExtendParams);
            parameters.Add("file_charset", this.FileCharset);
            return parameters;
        }

        #endregion

        #region IAopUploadRequest Members

        public override IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file_content", this.FileContent);
            return parameters;
        }

        #endregion
    }
}
