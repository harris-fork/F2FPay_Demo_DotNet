using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.member.brandowner.name.query
    /// </summary>
    public class KoubeiMemberBrandownerNameQueryRequest : IAopRequest<KoubeiMemberBrandownerNameQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.member.brandowner.name.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
