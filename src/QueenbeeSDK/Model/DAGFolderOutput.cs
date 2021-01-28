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
    /// DAG folder output.
    /// </summary>
    [DataContract(Name = "DAGFolderOutput")]
    public partial class DAGFolderOutput : GenericOutput, IEquatable<DAGFolderOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGFolderOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGFolderOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAGFolderOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGFolderOutput" /> class.
        /// </summary>
        /// <param name="from">Reference to a folder or a task output. Task output must be folder. (required).</param>
        /// <param name="alias">A list of additional processes for loading this output on different platforms..</param>
        /// <param name="required">A boolean to indicate if an artifact output is required. A False value makes the artifact optional. (default to true).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        public DAGFolderOutput
        (
            string name, AnyOf<TaskReference,FolderReference> from, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, List<AnyOf<DAGGenericOutputAlias,DAGStringOutputAlias,DAGIntegerOutputAlias,DAGNumberOutputAlias,DAGBooleanOutputAlias,DAGFolderOutputAlias,DAGFileOutputAlias,DAGPathOutputAlias,DAGArrayOutputAlias,DAGJSONObjectOutputAlias,DAGLinkedOutputAlias>> alias= default, bool required = true // Optional parameters
        ) : base(name: name, annotations: annotations, description: description)// BaseClass
        {
            // to ensure "from" is required (not null)
            this.From = from ?? throw new ArgumentNullException("from is a required property for DAGFolderOutput and cannot be null");
            this.Alias = alias;
            this.Required = required;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAGFolderOutput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "DAGFolderOutput";

        /// <summary>
        /// Reference to a folder or a task output. Task output must be folder.
        /// </summary>
        /// <value>Reference to a folder or a task output. Task output must be folder.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<TaskReference,FolderReference> From { get; set; } 
        /// <summary>
        /// A list of additional processes for loading this output on different platforms.
        /// </summary>
        /// <value>A list of additional processes for loading this output on different platforms.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public List<AnyOf<DAGGenericOutputAlias,DAGStringOutputAlias,DAGIntegerOutputAlias,DAGNumberOutputAlias,DAGBooleanOutputAlias,DAGFolderOutputAlias,DAGFileOutputAlias,DAGPathOutputAlias,DAGArrayOutputAlias,DAGJSONObjectOutputAlias,DAGLinkedOutputAlias>> Alias { get; set; } 
        /// <summary>
        /// A boolean to indicate if an artifact output is required. A False value makes the artifact optional.
        /// </summary>
        /// <value>A boolean to indicate if an artifact output is required. A False value makes the artifact optional.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }  = true;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAGFolderOutput";
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
            sb.Append("DAGFolderOutput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGFolderOutput object</returns>
        public static DAGFolderOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGFolderOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGFolderOutput object</returns>
        public virtual DAGFolderOutput DuplicateDAGFolderOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAGFolderOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override GenericOutput DuplicateGenericOutput()
        {
            return DuplicateDAGFolderOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAGFolderOutput);
        }

        /// <summary>
        /// Returns true if DAGFolderOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGFolderOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGFolderOutput input)
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
                    this.Alias == input.Alias ||
                    this.Alias != null &&
                    input.Alias != null &&
                    this.Alias.SequenceEqual(input.Alias)
                ) && base.Equals(input) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
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
            Regex regexType = new Regex(@"^DAGFolderOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
