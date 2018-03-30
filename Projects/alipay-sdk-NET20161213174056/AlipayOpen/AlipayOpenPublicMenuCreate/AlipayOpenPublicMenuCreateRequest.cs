using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.menu.create
    /// </summary>
    public class AlipayOpenPublicMenuCreateRequest : IAopRequest<AlipayOpenPublicMenuCreateResponse>
    {
        /// <summary>
        /// 创建菜单
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.menu.create";
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
