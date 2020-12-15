using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace QueenbeeSDK
{
    public abstract class QueenbeeObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// The default value is set to "InvalidSchemaObject", which should be overridden in subclass' constructor.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public virtual string Type { get; protected internal set; } = "InvalidSchemaObject";

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
