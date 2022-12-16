using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class AutoTranslateSettings : Payload
    {
        ///<summary>
        ///自动或自动翻译
        ///</summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        ///<summary>
        ///如果设置是autoTranslate，则为Boolean;如果设置是autotranslatellanguage，则为字符串(语言)。
        ///</summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("defaultLanguage")]
        public string DefaultLanguage { get; set; }
    }
}
