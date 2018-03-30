using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.public.menu.update
    /// json串，<a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7386797.0.0.1l7WMo&treeId=53&articleId=103481&docType=1">详情请见</a>
    /// </summary>
    public class AlipayMobilePublicMenuUpdateRequest : BizAopRequest<AlipayMobilePublicMenuUpdateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.menu.update";
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
