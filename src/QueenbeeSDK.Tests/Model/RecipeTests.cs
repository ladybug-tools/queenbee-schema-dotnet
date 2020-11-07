using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueenbeeSDK.Test
{
    public class RecipeTests
    {
        private Recipe instance;

        [SetUp]
        public void Init()
        {
            // load local yaml file
            var path = @"..\..\..\TestSource\daylight-factor.yaml";
            string yaml = System.IO.File.ReadAllText(path);
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            var yamlObject = deserializer.Deserialize(new System.IO.StringReader(yaml));

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(yamlObject);
            var recipe = Recipe.FromJson(json);
            this.instance = recipe;

        }

        [Test]
        public void RecipeInstanceTest()
        {
            Assert.IsInstanceOf(typeof(Recipe), instance);
        }

        [Test]
        public void FlowsTest()
        {
            // Detailed tests in DAGTests
            Assert.IsTrue(this.instance.Flow.Count > 0);
        }

        [Test]
        public void DependenciesTest()
        {
            var dependency = this.instance.Dependencies.First();
            Assert.IsTrue(dependency.Name == "honeybee-radiance");
        }

        [Test]
        public void MetadataTest()
        {
            var metaData = this.instance.Metadata;
            Assert.IsTrue(metaData.Name == "daylight-factor");
            Assert.IsTrue(metaData.Tag != "latest");
        }
    }
}
