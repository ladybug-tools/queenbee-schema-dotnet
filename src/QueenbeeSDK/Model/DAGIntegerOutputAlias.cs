/* 
 * Queenbee Schema with Inheritance
 *
 * Documentation for Queenbee schema.
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK
{
    /// <summary>
    /// DAG alias integer output.  This output loads the content from a file as an integer.
    /// </summary>
    [DataContract(Name = "DAGIntegerOutputAlias")]
    public partial class DAGIntegerOutputAlias : GenericOutput, IEquatable<DAGIntegerOutputAlias>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGIntegerOutputAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGIntegerOutputAlias() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGIntegerOutputAlias";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGIntegerOutputAlias" /> class.
        /// </summary>
        /// <param name="from">Reference to a file or a task output. Task output must be file. (required).</param>
        /// <param name="platform">Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe. (required).</param>
        /// <param name="handler">List of process actions to process the input or output value. (required).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        public DAGIntegerOutputAlias
        (
            string name, AnyOf<TaskReference,FileReference> from, List<string> platform, List<IOAliasHandler> handler, // Required parameters
            Dictionary<string, string> annotations= default, string description= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description)// BaseClass
        {
            // to ensure "from" is required (not null)
            this.From = from ?? throw new ArgumentNullException("from is a required property for DAGIntegerOutputAlias and cannot be null");
            // to ensure "platform" is required (not null)
            this.Platform = platform ?? throw new ArgumentNullException("platform is a required property for DAGIntegerOutputAlias and cannot be null");
            // to ensure "handler" is required (not null)
            this.Handler = handler ?? throw new ArgumentNullException("handler is a required property for DAGIntegerOutputAlias and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGIntegerOutputAlias";
        }

        /// <summary>
        /// Reference to a file or a task output. Task output must be file.
        /// </summary>
        /// <value>Reference to a file or a task output. Task output must be file.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<TaskReference,FileReference> From { get; set; } 
        /// <summary>
        /// Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.
        /// </summary>
        /// <value>Name of the client platform (e.g. Grasshopper, Revit, etc). The value can be any strings as long as it has been agreed between client-side developer and author of the recipe.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Platform { get; set; } 
        /// <summary>
        /// List of process actions to process the input or output value.
        /// </summary>
        /// <value>List of process actions to process the input or output value.</value>
        [DataMember(Name = "handler", IsRequired = true, EmitDefaultValue = false)]
        public List<IOAliasHandler> Handler { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGIntegerOutputAlias";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("DAGIntegerOutputAlias:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGIntegerOutputAlias object</returns>
        public static DAGIntegerOutputAlias FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGIntegerOutputAlias>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGIntegerOutputAlias object</returns>
        public virtual DAGIntegerOutputAlias DuplicateDAGIntegerOutputAlias()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGIntegerOutputAlias();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericOutput DuplicateGenericOutput()
        {
            return DuplicateDAGIntegerOutputAlias();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DAGIntegerOutputAlias);
        }

        /// <summary>
        /// Returns true if DAGIntegerOutputAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGIntegerOutputAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGIntegerOutputAlias input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform != null &&
                    input.Platform != null &&
                    this.Platform.SequenceEqual(input.Platform)
                ) && base.Equals(input) && 
                (
                    this.Handler == input.Handler ||
                    this.Handler != null &&
                    input.Handler != null &&
                    this.Handler.SequenceEqual(input.Handler)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^DAGIntegerOutputAlias$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
