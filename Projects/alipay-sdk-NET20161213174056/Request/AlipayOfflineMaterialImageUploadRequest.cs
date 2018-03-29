using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.material.image.upload
    /// </summary>
    public class AlipayOfflineMaterialImageUploadRequest : IAopUploadRequest<AlipayOfflineMaterialImageUploadResponse>
    {
        /// <summary>
        /// 图片/视频二进制内容，图片/视频大小不能超过5M
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图片/视频名称
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 用于显示指定图片/视频所属的partnerId（支付宝内部使用，外部商户无需填写此字段）
        /// </summary>
        public string ImagePid { get; set; }

        /// <summary>
        /// 图片/视频格式
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
            return "alipay.offline.material.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("image_name", this.ImageName);
            parameters.Add("image_pid", this.ImagePid);
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
