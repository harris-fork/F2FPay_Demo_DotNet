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

        public override string GetApiName()
        {
            return "alipay.offline.material.image.download";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("image_ids", this.ImageIds);
            return parameters;
        }

        #endregion
    }
}
