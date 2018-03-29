using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.tpl.content.add
    /// </summary>
    public class AlipayPassTplContentAddRequest : IAopRequest<AlipayPassTplContentAddResponse>
    {
        /// <summary>
        /// 支付宝用户识别信息：  当 recognition_type=1时， recognition_info={“partner_id”:”2088102114633762”,“out_trade_no”:”1234567”}；  当recognition_type=3时，recognition_info={“mobile”:”136XXXXXXXX“}  当recognition_type=4时， recognition_info={“open_id”:”afbd8d9bb12fc02c5094d8ea89d1fae8“}
        /// </summary>
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// Alipass添加对象识别类型【1--订单信息;3--支付宝用户绑定手机号；4--支付宝OpenId;】
        /// </summary>
        public string RecognitionType { get; set; }

        /// <summary>
        /// 支付宝pass模版ID
        /// </summary>
        public string TplId { get; set; }

        /// <summary>
        /// 模版动态参数信息【支付宝pass模版参数键值对JSON字符串】
        /// </summary>
        public string TplParams { get; set; }

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
            return "alipay.pass.tpl.content.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("recognition_info", this.RecognitionInfo);
            parameters.Add("recognition_type", this.RecognitionType);
            parameters.Add("tpl_id", this.TplId);
            parameters.Add("tpl_params", this.TplParams);
            return parameters;
        }

        #endregion
    }
}
