using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.public.follow.list
    /// 当nextUserId为空时,代表查询第一组,如果有值时以当前值为准查询下一组  <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7386797.0.0.eZqycg&treeId=53&articleId=103525&docType=1">详情请见</a>
    /// </summary>
    public class AlipayMobilePublicFollowListRequest : BizAopRequest<AlipayMobilePublicFollowListResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.follow.list";
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
