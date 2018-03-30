using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.dataservice.code.reco
    /// </summary>
    public class AlipayDataDataserviceCodeRecoRequest : IAopRequest<AlipayDataDataserviceCodeRecoResponse>
    {
        /// <summary>
        /// 改api为数立提供验证码识别服务。isv可以通过该接口，使用我们的图片识别能力。
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.dataservice.code.reco";
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
