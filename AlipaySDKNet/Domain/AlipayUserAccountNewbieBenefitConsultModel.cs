using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountNewbieBenefitConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountNewbieBenefitConsultModel : AopObject
    {
        /// <summary>
        /// 扩展信息，json格式字符串。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 手机号码。和user_id二选一必填。
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 模式，用于决策当前请求包含哪些人君。
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 商户支付宝ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID。和mobile二选一必填。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
