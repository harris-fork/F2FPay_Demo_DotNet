using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.educate.studentinfo.share
    /// </summary>
    public class AlipayCommerceEducateStudentinfoShareRequest : IAopRequest<AlipayCommerceEducateStudentinfoShareResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.educate.studentinfo.share";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
