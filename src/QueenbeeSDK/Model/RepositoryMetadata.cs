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
    /// BaseModel with functionality to return the object as a yaml string.
    /// </summary>
    [DataContract(Name = "RepositoryMetadata")]
    public partial class RepositoryMetadata : OpenAPIGenBaseModel, IEquatable<RepositoryMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryMetadata" /> class.
        /// </summary>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="name">The name of the repository.</param>
        /// <param name="description">A short description of the repository (default to &quot;A Queenbee package repository&quot;).</param>
        /// <param name="source">The source path (url or local) to the repository.</param>
        /// <param name="pluginCount">The number of plugins hosted by the repository (default to 0).</param>
        /// <param name="recipeCount">The number of recipes hosted by the repository (default to 0).</param>
        public RepositoryMetadata
        (
             // Required parameters
            Dictionary<string, string> annotations= default, string name= default, string description = "A Queenbee package repository", string source= default, int pluginCount = 0, int recipeCount = 0// Optional parameters
        ) : base()// BaseClass
        {
            this.Annotations = annotations;
            this.Name = name;
            // use default value if no "description" provided
            this.Description = description ?? "A Queenbee package repository";
            this.Source = source;
            this.PluginCount = pluginCount;
            this.RecipeCount = recipeCount;

            // Set non-required readonly properties with defaultValue
            this.Type = "RepositoryMetadata";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "RepositoryMetadata";

        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// The name of the repository
        /// </summary>
        /// <value>The name of the repository</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// A short description of the repository
        /// </summary>
        /// <value>A short description of the repository</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }  = "A Queenbee package repository";
        /// <summary>
        /// The source path (url or local) to the repository
        /// </summary>
        /// <value>The source path (url or local) to the repository</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; } 
        /// <summary>
        /// The number of plugins hosted by the repository
        /// </summary>
        /// <value>The number of plugins hosted by the repository</value>
        [DataMember(Name = "plugin_count", EmitDefaultValue = true)]
        public int PluginCount { get; set; }  = 0;
        /// <summary>
        /// The number of recipes hosted by the repository
        /// </summary>
        /// <value>The number of recipes hosted by the repository</value>
        [DataMember(Name = "recipe_count", EmitDefaultValue = true)]
        public int RecipeCount { get; set; }  = 0;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RepositoryMetadata";
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
            sb.Append("RepositoryMetadata:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  PluginCount: ").Append(PluginCount).Append("\n");
            sb.Append("  RecipeCount: ").Append(RecipeCount).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RepositoryMetadata object</returns>
        public static RepositoryMetadata FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepositoryMetadata>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepositoryMetadata object</returns>
        public virtual RepositoryMetadata DuplicateRepositoryMetadata()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateRepositoryMetadata();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRepositoryMetadata();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RepositoryMetadata);
        }

        /// <summary>
        /// Returns true if RepositoryMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of RepositoryMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryMetadata input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && base.Equals(input) && 
                (
                    this.PluginCount == input.PluginCount ||
                    (this.PluginCount != null &&
                    this.PluginCount.Equals(input.PluginCount))
                ) && base.Equals(input) && 
                (
                    this.RecipeCount == input.RecipeCount ||
                    (this.RecipeCount != null &&
                    this.RecipeCount.Equals(input.RecipeCount))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.PluginCount != null)
                    hashCode = hashCode * 59 + this.PluginCount.GetHashCode();
                if (this.RecipeCount != null)
                    hashCode = hashCode * 59 + this.RecipeCount.GetHashCode();
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
            Regex regexType = new Regex(@"^RepositoryMetadata$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
