
using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using QueenbeeSDK;

using System.Reflection;
using Newtonsoft.Json;
using System.Net;

namespace QueenbeeSDK.Test
{
    public class DAGTests
    {
        private DAG instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // load from url
            var url = @"https://raw.githubusercontent.com/pollination/queenbee/master/tests/assets/recipes/valid/daylight-factor.yaml";
            using (var wc = new WebClient())
            {
                var yaml = wc.DownloadString(url);
                var deserializer = new YamlDotNet.Serialization.Deserializer();
                var yamlObject = deserializer.Deserialize(new StringReader(yaml));

                var json = JsonConvert.SerializeObject(yamlObject);
                var recipe = Recipe.FromJson(json);

                this.instance = recipe.Flow.First();
            }


            //// load local yaml file
            //var path = @"..\..\..\TestSource\daylight-factor.yaml";
            //string yaml = System.IO.File.ReadAllText(path);
            //var deserializer = new YamlDotNet.Serialization.Deserializer();
            //var yamlObject = deserializer.Deserialize(new StringReader(yaml));

            //var json = JsonConvert.SerializeObject(yamlObject);
            //var recipe = Recipe.FromJson(json);
            //this.instance = recipe.Flow.First();


            // load local json file
            //var path = @"..\..\..\TestSource\daylight-factor.json";
            //string text = System.IO.File.ReadAllText(path);
            //var recipe = Recipe.FromJson(text);
            //this.instance = recipe.Flow.First();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DAG
        /// </summary>
        [Test]
        public void DAGInstanceTest()
        {
            Assert.IsInstanceOf(typeof(DAG), instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            var value = this.instance.Name;
            var target = "main";

            Assert.IsTrue(value.EndsWith(target));
        }

        [Test]
        public void InputsTest()
        {
            var value = this.instance.Inputs.Count;
            //var target = 4;

            Assert.IsTrue(value > 0);

            var input = this.instance.Inputs.OfType<DAGFileInput>().First(_ => _.Name.Contains("model"));
            Assert.IsTrue(input != null);
            Assert.IsTrue(input.Type == "DAGFileInput");
        }

        [Test]
        public void InputAliasTest()
        {
            var input = this.instance.Inputs.OfType<DAGFileInput>().First(_=>_.Name.Contains("model"));
            Assert.IsTrue(input != null);

            var alias = input.Alias.OfType<DAGGenericInputAlias>().First();
            Assert.IsTrue(alias.Name == "model");
            Assert.IsTrue(alias.Platform.First() == "grasshopper");

            var pythonHandler = alias.Handler.OfType<IOAliasHandler>().First(_ => _.Language == "python");
            Assert.IsTrue(pythonHandler.Function == "hb_model_to_hbjson");

        }

        [Test]
        public void OutputsTest()
        {
            var value = this.instance.Outputs.Count;
            //var target = 2;

            Assert.IsTrue(value > 0);

            var input = this.instance.Outputs.OfType<DAGFolderOutput>().First(_ => _.Name == "data");
            Assert.IsTrue(input != null);

            Assert.IsTrue(input.From.Obj is TaskReference);
        }
        /// <summary>
        /// Test the property 'Tasks'
        /// </summary>
        [Test]
        public void TasksTest()
        {
            var value = this.instance.Tasks.Count;
            //var target = 4;

            Assert.IsTrue(value > 0);

            var input = this.instance.Tasks.OfType<DAGTask>().First(_=>_.Name == "generate-sky");
            Assert.IsTrue(input != null);
            Assert.IsTrue(input.Type == "DAGTask");
            Assert.IsTrue(input.Name == "generate-sky");
            Assert.IsTrue((input.Returns.OfType<TaskPathReturn>().First()).Name == "sky");
        }
        /// <summary>
        /// Test the property 'FailFast'
        /// </summary>
        [Test]
        public void FailFastTest()
        {
            var value = this.instance.FailFast;
            var target = true;

            Assert.IsTrue(value == target);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            var value = this.instance.Type;
            var target = "DAG";

            Assert.IsTrue(value == target);
        }



    }

}
