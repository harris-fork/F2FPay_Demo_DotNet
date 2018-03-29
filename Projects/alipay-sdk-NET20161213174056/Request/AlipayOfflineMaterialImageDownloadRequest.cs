using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.material.image.download
    /// </summary>
    public class AlipayOfflineMaterialImageDownloadRequest : IAopRequest<AlipayOfflineMaterialImageDownloadResponse>
    {
        /// <summary>
        /// 图片id列表
        /// </summary>
        public List<string> ImageIds { get; set; }

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
            return "alipay.offline.material.image.download";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("image_ids", this.ImageIds);
            return parameters;
        }

        #endregion
    }
}
