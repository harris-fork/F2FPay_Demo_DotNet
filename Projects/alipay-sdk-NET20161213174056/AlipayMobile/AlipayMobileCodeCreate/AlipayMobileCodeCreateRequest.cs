using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.code.create
    /// </summary>
    public class AlipayMobileCodeCreateRequest : IAopRequest<AlipayMobileCodeCreateResponse>
    {
        /// <summary>
        /// 业务关联ID。比如订单号,userId，业务连接等
        /// </summary>
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 类似产品名称，根据该值决定码存储类型；新接业务需要找码平台技术配置
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 业务自定义,码平台不用理解。一定要传json字符串。
        /// </summary>
        public string ContextStr { get; set; }

        /// <summary>
        /// 如果是true，则扫一扫下发跳转地址直接取自bizLinkedId  否则，从路由信息里取跳转地址
        /// </summary>
        public Nullable<bool> IsDirect { get; set; }

        /// <summary>
        /// 备注信息字段
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 发码来源，业务自定
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// 编码启动时间（yyy-MM-dd hh:mm:ss），为空表示立即启用
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        /// <summary>
        /// 超时时间,单位秒；若不传则为永久。发码超时时间需要找码平台技术评估
        /// </summary>
        public Nullable<long> Timeout { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.code.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_linked_id", this.BizLinkedId);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("context_str", this.ContextStr);
            parameters.Add("is_direct", this.IsDirect);
            parameters.Add("memo", this.Memo);
            parameters.Add("source_id", this.SourceId);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("timeout", this.Timeout);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
