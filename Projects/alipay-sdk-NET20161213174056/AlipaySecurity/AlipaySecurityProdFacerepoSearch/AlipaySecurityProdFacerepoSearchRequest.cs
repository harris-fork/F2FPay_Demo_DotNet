using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.prod.facerepo.search
    /// </summary>
    public class AlipaySecurityProdFacerepoSearchRequest : IAopRequest<AlipaySecurityProdFacerepoSearchResponse>
    {
        /// <summary>
        /// 人脸1:N服务搜索接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.prod.facerepo.search";
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
