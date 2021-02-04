//using Newtonsoft.Json;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;

//namespace QueenbeeSDK.Test
//{
//    public class RecipeTests
//    {
//        private Recipe instance;

//        [SetUp]
//        public void Init()
//        {
//            var url = @"https://api.pollination.cloud/recipes/ladybug-tools/daylight-factor/tags/0.3.1";
//            using (var wc = new WebClient())
//            {
//                var json = wc.DownloadString(url);
//                var recipe = Recipe.FromJson(json);

//                this.instance = recipe;
//            }

//            //// load local yaml file
//            //var path = @"..\..\..\TestSource\daylight-factor.yaml";
//            //string yaml = System.IO.File.ReadAllText(path);
//            //var deserializer = new YamlDotNet.Serialization.Deserializer();
//            //var yamlObject = deserializer.Deserialize(new System.IO.StringReader(yaml));

//            //var json = Newtonsoft.Json.JsonConvert.SerializeObject(yamlObject);
//            //var recipe = Recipe.FromJson(json);
//            //this.instance = recipe;

//        }

//        [Test]
//        public void RecipeInstanceTest()
//        {
//            Assert.IsInstanceOf(typeof(Recipe), instance);
//        }

//        [Test]
//        public void FlowsTest()
//        {
//            // Detailed tests in DAGTests
//            Assert.IsTrue(this.instance.Flow.Count > 0);
//        }

//        [Test]
//        public void DependenciesTest()
//        {
//            var dependency = this.instance.Dependencies.First();
//            Assert.IsTrue(dependency.Name == "honeybee-radiance");
//        }

//        [Test]
//        public void MetadataTest()
//        {
//            var metaData = this.instance.Metadata;
//            Assert.IsTrue(metaData.Name == "daylight-factor");
//            Assert.IsTrue(metaData.Tag != "latest");
//        }

//        [Test]
//        public void Duplicate()
//        {
//            Assert.IsTrue(this.instance.Metadata.Equals(this.instance.Metadata.DuplicateMetaData()));


//            var recipeDup = this.instance.DuplicateRecipe();
      

//            var flowCount = recipeDup.Flow.Count();
//            for (int i = 0; i < flowCount; i++)
//            {
//                var flow = this.instance.Flow[i];
//                var flowDup = recipeDup.Flow[i];

//                var inputs = flow.Inputs;
//                var inputsDup = flowDup.Inputs;
//                for (int j = 0; j < inputs.Count; j++)
//                {
//                    var input = inputs[j];
//                    var inputDup = inputsDup[j];
//                    Assert.IsTrue(input.Equals(inputDup));
//                }
//                Assert.IsTrue(flow.Inputs.SequenceEqual(flowDup.Inputs));
//                Assert.IsTrue(flow.Outputs.SequenceEqual(flowDup.Outputs));
//                Assert.IsTrue(flow.Equals(flowDup));
//            }




//            var isSame = recipeDup.Flow.SequenceEqual(this.instance.Flow);
//            Assert.IsTrue(isSame);


//            var dup1 = this.instance.Duplicate();
//            Assert.IsTrue(dup1.Equals(this.instance));

//            var dup2 = this.instance.DuplicateOpenAPIGenBaseModel();
//            Assert.IsTrue(dup2.Equals(this.instance));

//            var dup3 = this.instance.DuplicateRecipe();
//            Assert.IsTrue(dup3.Equals(this.instance));

//        }
//    }
//}
