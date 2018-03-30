using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.platform.userid.get
    /// 根据OpenId获取UserId
    /// </summary>
    public class AlipayPlatformUseridGetRequest : BizAopRequest<AlipayPlatformUseridGetResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.platform.userid.get";
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
