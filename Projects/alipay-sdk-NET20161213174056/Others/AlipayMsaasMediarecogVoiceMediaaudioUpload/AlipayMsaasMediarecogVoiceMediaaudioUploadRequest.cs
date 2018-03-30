using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.msaas.mediarecog.voice.mediaaudio.upload
    /// 媒体实时上传音频流接口
    /// </summary>
    public class AlipayMsaasMediarecogVoiceMediaaudioUploadRequest : BizAopRequest<AlipayMsaasMediarecogVoiceMediaaudioUploadResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.msaas.mediarecog.voice.mediaaudio.upload";
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
