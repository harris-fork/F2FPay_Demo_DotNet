using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.security.info.analysis
    /// </summary>
    public class AlipaySecurityInfoAnalysisRequest : IAopRequest<AlipaySecurityInfoAnalysisResponse>
    {
        /// <summary>
        /// 客户端的基带版本
        /// </summary>
        public string EnvClientBaseBand { get; set; }

        /// <summary>
        /// 客户端连接的基站信息
        /// </summary>
        public string EnvClientBaseStation { get; set; }

        /// <summary>
        /// 客户端的经纬度坐标
        /// </summary>
        public string EnvClientCoordinates { get; set; }

        /// <summary>
        /// 操作的客户端的imei
        /// </summary>
        public string EnvClientImei { get; set; }

        /// <summary>
        /// 操作的客户端的imsi
        /// </summary>
        public string EnvClientImsi { get; set; }

        /// <summary>
        /// IOS设备的UDID
        /// </summary>
        public string EnvClientIosUdid { get; set; }

        /// <summary>
        /// 操作的客户端ip
        /// </summary>
        public string EnvClientIp { get; set; }

        /// <summary>
        /// 操作的客户端mac
        /// </summary>
        public string EnvClientMac { get; set; }

        /// <summary>
        /// 操作的客户端分辨率，格式为：水平像素^垂直像素；如：800^600
        /// </summary>
        public string EnvClientScreen { get; set; }

        /// <summary>
        /// 客户端设备的统一识别码UUID
        /// </summary>
        public string EnvClientUuid { get; set; }

        /// <summary>
        /// JS SDK生成的 tokenID
        /// </summary>
        public string JsTokenId { get; set; }

        /// <summary>
        /// 签约的支付宝账号对应的支付宝唯一用户号
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家账户ID
        /// </summary>
        public string UserAccountNo { get; set; }

        /// <summary>
        /// 用户绑定银行卡号
        /// </summary>
        public string UserBindBankcard { get; set; }

        /// <summary>
        /// 用户绑定银行卡的卡类型
        /// </summary>
        public string UserBindBankcardType { get; set; }

        /// <summary>
        /// 用户绑定手机号
        /// </summary>
        public string UserBindMobile { get; set; }

        /// <summary>
        /// 用户证件类型
        /// </summary>
        public string UserIdentityType { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserRealName { get; set; }

        /// <summary>
        /// 用户注册时间
        /// </summary>
        public string UserRegDate { get; set; }

        /// <summary>
        /// 用户注册Email
        /// </summary>
        public string UserRegEmail { get; set; }

        /// <summary>
        /// 用户注册手机号
        /// </summary>
        public string UserRegMobile { get; set; }

        /// <summary>
        /// 用户证件号码
        /// </summary>
        public string UserrIdentityNo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.info.analysis";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("env_client_base_band", this.EnvClientBaseBand);
            parameters.Add("env_client_base_station", this.EnvClientBaseStation);
            parameters.Add("env_client_coordinates", this.EnvClientCoordinates);
            parameters.Add("env_client_imei", this.EnvClientImei);
            parameters.Add("env_client_imsi", this.EnvClientImsi);
            parameters.Add("env_client_ios_udid", this.EnvClientIosUdid);
            parameters.Add("env_client_ip", this.EnvClientIp);
            parameters.Add("env_client_mac", this.EnvClientMac);
            parameters.Add("env_client_screen", this.EnvClientScreen);
            parameters.Add("env_client_uuid", this.EnvClientUuid);
            parameters.Add("js_token_id", this.JsTokenId);
            parameters.Add("partner_id", this.PartnerId);
            parameters.Add("scene_code", this.SceneCode);
            parameters.Add("user_account_no", this.UserAccountNo);
            parameters.Add("user_bind_bankcard", this.UserBindBankcard);
            parameters.Add("user_bind_bankcard_type", this.UserBindBankcardType);
            parameters.Add("user_bind_mobile", this.UserBindMobile);
            parameters.Add("user_identity_type", this.UserIdentityType);
            parameters.Add("user_real_name", this.UserRealName);
            parameters.Add("user_reg_date", this.UserRegDate);
            parameters.Add("user_reg_email", this.UserRegEmail);
            parameters.Add("user_reg_mobile", this.UserRegMobile);
            parameters.Add("userr_identity_no", this.UserrIdentityNo);
            return parameters;
        }

        #endregion
    }
}
