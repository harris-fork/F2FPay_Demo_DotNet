using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.medical.instcard.bind
    /// </summary>
    public class AlipayCommerceMedicalInstcardBindRequest : IAopRequest<AlipayCommerceMedicalInstcardBindResponse>
    {
        /// <summary>
        /// 用于支付宝用户通过医院服务窗绑定当地社保卡
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.medical.instcard.bind";
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
