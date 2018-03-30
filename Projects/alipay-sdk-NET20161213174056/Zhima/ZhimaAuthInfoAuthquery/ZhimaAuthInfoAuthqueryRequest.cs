using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.auth.info.authquery
    /// 查询是否授权的接口
    /// </summary>
    public class ZhimaAuthInfoAuthqueryRequest : BizAopRequest<ZhimaAuthInfoAuthqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "zhima.auth.info.authquery";
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
