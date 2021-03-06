using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.platform.openid.get
    /// 业务内容，其中包括商户partner_id和用户ID列表user_ids两块
    /// </summary>
    public class AlipayPlatformOpenidGetRequest : BizAopRequest<AlipayPlatformOpenidGetResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.platform.openid.get";
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
