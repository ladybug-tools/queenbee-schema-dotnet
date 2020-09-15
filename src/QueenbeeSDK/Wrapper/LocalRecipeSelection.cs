
using Newtonsoft.Json;
using System;
using System.IO;

namespace QueenbeeSDK.Model
{
    public class LocalRecipeSelection: RecipeSelection
    {

        [JsonProperty("path")]
        public string Path { get; set; }     
        public LocalRecipeSelection(string recipeOwner, string recipeName, string recipeTag, string localRecipeYmlPath):base(recipeOwner, recipeName, recipeTag)
        {
            if (!File.Exists(localRecipeYmlPath)) throw new FileNotFoundException($"LocalRecipeSelection: localRecipeYmlPath[{localRecipeYmlPath}] doesn't exist");
            this.Path = localRecipeYmlPath;
        }


    }
}
