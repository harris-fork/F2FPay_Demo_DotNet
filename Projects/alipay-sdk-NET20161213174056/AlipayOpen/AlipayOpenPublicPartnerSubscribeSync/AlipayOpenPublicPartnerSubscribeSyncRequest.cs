using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.partner.subscribe.sync
    /// </summary>
    public class AlipayOpenPublicPartnerSubscribeSyncRequest : IAopRequest<AlipayOpenPublicPartnerSubscribeSyncResponse>
    {
        /// <summary>
        /// 用于为服务窗合作伙伴（如YunOS），提供订阅关系（关注与取消关注）同步功能
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.partner.subscribe.sync";
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
