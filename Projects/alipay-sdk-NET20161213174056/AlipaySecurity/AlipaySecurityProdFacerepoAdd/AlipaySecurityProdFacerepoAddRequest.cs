using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.security.prod.facerepo.add
    /// 人脸1:N服务入库接口
    /// </summary>
    public class AlipaySecurityProdFacerepoAddRequest : BizAopRequest<AlipaySecurityProdFacerepoAddResponse>
    {
        

        #region BizAopRequest Members

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
