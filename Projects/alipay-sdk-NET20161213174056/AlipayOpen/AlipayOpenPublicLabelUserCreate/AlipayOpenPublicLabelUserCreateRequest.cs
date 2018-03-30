using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.label.user.create
    /// </summary>
    public class AlipayOpenPublicLabelUserCreateRequest : IAopRequest<AlipayOpenPublicLabelUserCreateResponse>
    {
        /// <summary>
        /// 用户增加标签接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.label.user.create";
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
