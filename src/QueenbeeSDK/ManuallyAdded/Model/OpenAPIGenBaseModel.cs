using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace QueenbeeSDK
{
    public partial class OpenAPIGenBaseModel: QueenbeeObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// The default value is set to "InvalidSchemaObject", which should be overridden in subclass' constructor.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public virtual string Type { get; protected internal set; } = "InvalidSchemaObject";

        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public virtual string ApiVersion { get; protected internal set; } = "";
    }
}