using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.member.card.deletecard
    /// </summary>
    public class AlipayMemberCardDeletecardRequest : IAopRequest<AlipayMemberCardDeletecardResponse>
    {
        /// <summary>
        /// 商户端删卡业务流水号
        /// </summary>
        public string BizSerialNo { get; set; }

        /// <summary>
        /// 发卡商户信息，json格式。  目前仅支持如下key：  &#61548; merchantUniId：商户唯一标识  &#61548; merchantUniIdType：支持以下3种取值。  LOGON_ID：商户登录ID，邮箱或者手机号格式；  UID：商户的支付宝用户号，以2088开头的16位纯数字组成；  BINDING_MOBILE：商户支付宝账号绑定的手机号。
        /// </summary>
        public string CardMerchantInfo { get; set; }

        /// <summary>
        /// 删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  newCardNo：新卡号  doneeUserId：受赠人userId
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员卡号
        /// </summary>
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// CANCEL：销户  PRESENT：转赠
        /// </summary>
        public string ReasonCode { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        public string RequestFrom { get; set; }

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
            return "alipay.member.card.deletecard";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_serial_no", this.BizSerialNo);
            parameters.Add("card_merchant_info", this.CardMerchantInfo);
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("external_card_no", this.ExternalCardNo);
            parameters.Add("reason_code", this.ReasonCode);
            parameters.Add("request_from", this.RequestFrom);
            return parameters;
        }

        #endregion
    }
}
