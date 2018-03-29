using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecard.edu.public.bind
    /// </summary>
    public class AlipayEcardEduPublicBindRequest : IAopRequest<AlipayEcardEduPublicBindResponse>
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 公众账号协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 一卡通姓名
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 一卡通卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 公众账号id
        /// </summary>
        public string PublicId { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.ecard.edu.public.bind";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("alipay_user_id", this.AlipayUserId);
            parameters.Add("card_name", this.CardName);
            parameters.Add("card_no", this.CardNo);
            parameters.Add("public_id", this.PublicId);
            return parameters;
        }

        #endregion
    }
}
