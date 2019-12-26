using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampuscardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampuscardQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
