using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.cplife.roominfo.delete
    /// 删除物业小区房屋信息
    /// </summary>
    public class AlipayEcoCplifeRoominfoDeleteRequest : BizAopRequest<AlipayEcoCplifeRoominfoDeleteResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.roominfo.delete";
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
