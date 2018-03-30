using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.sign.cancel
    /// </summary>
    public class AlipayEbppPdeductSignCancelRequest : IAopRequest<AlipayEbppPdeductSignCancelResponse>
    {
        /// <summary>
        /// 此值只是供代扣中心做最后的渠道统计用，并不做值是什么的强校验，只要不为空就可以
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 标识发起方的ID，从服务窗发起则为appId的值，appId即开放平台分配给接入ISV的id，此处也可以随便真其它值，只要能标识唯一即可
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 需要用户首先处于登陆态，然后访问https://ebppprod.alipay.com/deduct/enterMobileicPayPassword.htm?cb=自己指定的回跳连接地址,访问页面后会进到独立密码校验页，用户输入密码校验成功后，会生成token回调到指定的回跳地址，如果设置cb=www.baidu.com则最后回调的内容是www.baidu.com?token=312314ADFDSFAS,然后签约时直接取得地址后token的值即可
        /// </summary>
        public string PayPasswordToken { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ebpp.pdeduct.sign.cancel";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("agent_channel", this.AgentChannel);
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("pay_password_token", this.PayPasswordToken);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}