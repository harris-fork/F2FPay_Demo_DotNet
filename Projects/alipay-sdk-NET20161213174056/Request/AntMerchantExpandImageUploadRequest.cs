using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ant.merchant.expand.image.upload
    /// </summary>
    public class AntMerchantExpandImageUploadRequest : IAopUploadRequest<AntMerchantExpandImageUploadResponse>
    {
        /// <summary>
        /// 图片二进制字节流
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图片格式
        /// </summary>
        public string ImageType { get; set; }

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
            return "ant.merchant.expand.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("image_type", this.ImageType);
            return parameters;
        }

        

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image_content", this.ImageContent);
            return parameters;
        }

        #endregion
    }
}
