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
    /// A file or a folder output.
    /// </summary>
    [DataContract(Name = "StepPathOutput")]
    public partial class StepPathOutput : FunctionPathOutput, IEquatable<StepPathOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepPathOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepPathOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "StepPathOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StepPathOutput" /> class.
        /// </summary>
        /// <param name="source">The path to source the file from. (required).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="path">Path to the output artifact relative to where the function command is executed. (required).</param>
        public StepPathOutput
        (
            string name, string path, AnyOf<HTTP,S3,ProjectFolder> source, // Required parameters
            Dictionary<string, string> annotations= default, string description= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description, path: path)// BaseClass
        {
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for StepPathOutput and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "StepPathOutput";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "StepPathOutput";

        /// <summary>
        /// The path to source the file from.
        /// </summary>
        /// <value>The path to source the file from.</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public AnyOf<HTTP,S3,ProjectFolder> Source { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StepPathOutput";
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
            sb.Append("StepPathOutput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StepPathOutput object</returns>
        public static StepPathOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepPathOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepPathOutput object</returns>
        public virtual StepPathOutput DuplicateStepPathOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateStepPathOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override FunctionPathOutput DuplicateFunctionPathOutput()
        {
            return DuplicateStepPathOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepPathOutput);
        }

        /// <summary>
        /// Returns true if StepPathOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepPathOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepPathOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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
            Regex regexType = new Regex(@"^StepPathOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
