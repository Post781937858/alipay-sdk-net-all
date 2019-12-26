using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FenceEvent Data Structure.
    /// </summary>
    [Serializable]
    public class FenceEvent : AopObject
    {
        /// <summary>
        /// 语音事件列表. 可以是多条语音. 进入围栏后,会依次触发列表中的语音播报, 适合于既有营销语音,又有到站语音的场景
        /// </summary>
        [XmlArray("audio_events")]
        [XmlArrayItem("audio_event")]
        public List<AudioEvent> AudioEvents { get; set; }

        /// <summary>
        /// 地理围栏时间编码. 在相同route_code下,需要唯一
        /// </summary>
        [XmlElement("fence_code")]
        public string FenceCode { get; set; }

        /// <summary>
        /// 纬度,最多允许6位小数.目前只支持国内的经纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度,最多允许6位小数. 目前只支持国内的经纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 如果进入围栏后有多条语音,此参数用于设置多条语音之间的时间间隔.单位为秒. 不传默认为0, 也就是多条语音连续播报
        /// </summary>
        [XmlElement("multi_audio_interval")]
        public string MultiAudioInterval { get; set; }

        /// <summary>
        /// 围栏圆的半径,单位为米,只允许整数
        /// </summary>
        [XmlElement("radius")]
        public string Radius { get; set; }
    }
}
