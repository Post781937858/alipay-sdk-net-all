using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillDingBizOrder Data Structure.
    /// </summary>
    [Serializable]
    public class BillDingBizOrder : AopObject
    {
        /// <summary>
        /// 收支金额,收入为正,支出为负
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 钉钉业务单据号
        /// </summary>
        [XmlElement("biz_trans_id")]
        public string BizTransId { get; set; }

        /// <summary>
        /// 业务类型标识。支持类型有：0000-充值到零钱，0100-群收款，0101-报销，0102-支付，0103-收款，0104-转账，0105-工资，0106-发红包，0107-领红包，0201-提现，0301-红包退款
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 类型中文
        /// </summary>
        [XmlElement("biz_type_desc")]
        public string BizTypeDesc { get; set; }

        /// <summary>
        /// 账单详情状态
        /// </summary>
        [XmlElement("detail_state_desc")]
        public string DetailStateDesc { get; set; }

        /// <summary>
        /// 账单详情显示的头部内容
        /// </summary>
        [XmlElement("detail_title")]
        public string DetailTitle { get; set; }

        /// <summary>
        /// 资金流向。S表示收入，B表示支出
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 付款完成时间
        /// </summary>
        [XmlElement("gmt_finish")]
        public string GmtFinish { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 账单列表页显示的缩略内容
        /// </summary>
        [XmlElement("list_title")]
        public string ListTitle { get; set; }

        /// <summary>
        /// 脱敏后的当前用户的支付宝账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 脱敏后的对方支付宝账号
        /// </summary>
        [XmlElement("opp_login_id")]
        public string OppLoginId { get; set; }

        /// <summary>
        /// 对方昵称
        /// </summary>
        [XmlElement("opp_nick_name")]
        public string OppNickName { get; set; }

        /// <summary>
        /// 对方姓名
        /// </summary>
        [XmlElement("opp_user_name")]
        public string OppUserName { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// (Deprecated)非标准字段，不建议使用。业务类型, 有合作伙伴进行业务处理是传入,这里再透传回去
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 脱敏后的姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
