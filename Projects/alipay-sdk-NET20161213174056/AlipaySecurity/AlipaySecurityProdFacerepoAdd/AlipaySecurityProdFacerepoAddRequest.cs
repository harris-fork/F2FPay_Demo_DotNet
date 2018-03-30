using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.prod.facerepo.add
    /// </summary>
    public class AlipaySecurityProdFacerepoAddRequest : IAopRequest<AlipaySecurityProdFacerepoAddResponse>
    {
        /// <summary>
        /// 人脸1:N服务入库接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.prod.facerepo.add";
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
