using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QueenbeeSDK.Model;
using QueenbeeSDK.Model.Wrapper;

namespace QueenbeeSDK.Test
{
    public class WorkflowTests
    {
        private Workflow instance;
        [SetUp]
        public void Init()
        {
            var recipePath = @"C:\Users\mingo\ladybug_tools\resources\recipes\honeybee_radiance_recipe\annual_daylight.yaml";
            var recipe = new LocalRecipeSelection("ladybug-tools", "annual-daylight", "a99fe012a53d7259168e7c4183a7e479621b4a5010de050c0bd95bcb771333e8", recipePath);

            var paramArgs = new List<DAGTaskParameterArgument>()
            {
                new DAGTaskParameterArgument("wea", new InputParameterReference("wea"), "BostonLoganIntLArpt.wea"),
                new DAGTaskParameterArgument("sensor-grids", new InputParameterReference("wea"), "TestRoom_1"),
                new DAGTaskParameterArgument("sensor-count", new InputParameterReference("wea"), "60"),
            };
            var artifactArgs = new List<DAGTaskArtifactArgument>() {  };
            var args = new DAGTaskArgument(paramArgs);

            this.instance = new Workflow(recipe, args);
        }

        [TearDown]
        public void Cleanup()
        {

        }

        [Test]
        public void ToJsonTest()
        {
            var json = this.instance.ToJson();
        }
    }
}
