using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.get
    /// </summary>
    public class AlipayUserGetRequest : IAopRequest<AlipayUserGetResponse>
    {
        /// <summary>
        /// 需要返回的字段列表。alipay_user_id：支付宝用户userId,user_status：支付宝用户状态,user_type：支付宝用户类型,certified：是否通过实名认证,real_name：真实姓名,logon_id：支付宝登录号,sex：用户性别
        /// </summary>
        public string Fields { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("fields", this.Fields);
            return parameters;
        }

        #endregion
    }
}
