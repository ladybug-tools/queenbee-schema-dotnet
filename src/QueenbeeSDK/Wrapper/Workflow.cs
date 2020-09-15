using System;
using System.Linq;
using Newtonsoft.Json;
using QueenbeeSDK.Model;

namespace QueenbeeSDK.Model.Wrapper
{
    /// <summary>
    /// A Wrapper for SubmitSimulationDto, which overrides the ToString() to provide a human readable format.
    /// </summary>
    public class Workflow
    {
        public LocalRecipeSelection Recipe { get; set; }
        public DAGTaskArgument Inputs { get; set; }

        public Workflow(LocalRecipeSelection recipe, DAGTaskArgument args)
        {
            this.Recipe = recipe;
            this.Inputs = args;
        }

        public override string ToString()
        {
            var headerString = $"{this.Recipe.Owner}/{this.Recipe.Name}/{this.Recipe.Tag}";

            var inputParams = this.Inputs.Parameters.Select(_ => $"    {_.Name}: {_.Value}").ToList();
            inputParams.AddRange(this.Inputs.Artifacts.Select(_ => $"    {_.Name}: {_.From}"));
            var inputParamsString = string.Join(Environment.NewLine, inputParams);

            return $"{headerString}:{Environment.NewLine}{inputParamsString}";
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

    }
}
