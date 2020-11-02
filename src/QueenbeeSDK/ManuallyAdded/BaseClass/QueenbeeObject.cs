using Newtonsoft.Json;

namespace QueenbeeSDK
{
    public abstract class QueenbeeObject
    {
        /// <summary>
        /// This is the base class for all queenbee schema objects.
        /// </summary>
        protected internal QueenbeeObject()
        {
        }


        public abstract string ToString(bool detailed);

        public abstract OpenAPIGenBaseModel Duplicate();
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }
    }
}
