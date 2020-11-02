
using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using QueenbeeSDK;

using System.Reflection;
using Newtonsoft.Json;

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
            var path = @"..\..\..\TestSource\daylight-factor.json";
            string text = System.IO.File.ReadAllText(path);
            instance = DAG.FromJson(text);
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

            Assert.IsTrue(value == target);
        }

        [Test]
        public void InputsTest()
        {
            var value = this.instance.Inputs.Count;
            var target = 4;

            Assert.IsTrue(value == target);

            var input = this.instance.Inputs.First().Obj as DAGArrayInput;
            Assert.IsTrue(input != null);
            Assert.IsTrue(input.Type == "DAGArrayInput");
            Assert.IsTrue(input.Name == "sensor-grids");
        }

        [Test]
        public void OutputsTest()
        {
            var value = this.instance.Outputs.Count;
            var target = 1;

            Assert.IsTrue(value == target);

            var input = this.instance.Outputs.First().Obj as DAGFolderOutput;
            Assert.IsTrue(input != null);
            Assert.IsTrue(input.Name == "results");

            Assert.IsTrue(input.From.Obj as FolderReference != null);
        }
        /// <summary>
        /// Test the property 'Tasks'
        /// </summary>
        [Test]
        public void TasksTest()
        {
            var value = this.instance.Tasks.Count;
            var target = 4;

            Assert.IsTrue(value == target);

            var input = this.instance.Tasks.First() as DAGTask;
            Assert.IsTrue(input != null);
            Assert.IsTrue(input.Type == "DAGTask");
            Assert.IsTrue(input.Name == "generate-sky");
            Assert.IsTrue((input.Returns.First().Obj as TaskPathReturn).Name == "sky");
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
