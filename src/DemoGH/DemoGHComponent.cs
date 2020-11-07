using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using QueenbeeSDK;
using System.Reflection;

namespace DemoGH
{
    public class DemoGHComponent : GH_Component
    {
        public DemoGHComponent()
          : base("DemoGH", "Nickname",
              "Description",
              "Category", "Subcategory")
        {
        }

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("Queenbee input object", "qb_input", "a CSharp model obj, or python object", GH_ParamAccess.item);
            pManager.AddTextParameter("function", "function", "a function to call with above object", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("result", "result", "function output from csharp object", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Grasshopper.Kernel.Types.GH_ObjectWrapper inputObj = null;
            DA.GetData(0, ref inputObj);

            var nameSpace = "DemoGH.Handler";
            var methodName = "ModelToString";
            DA.GetData(1, ref methodName);

            object inputParam = inputObj.Value;
            object result = null;
            if (inputParam is Model model)
            {
                // csharp object
                result = InvokeFunction(methodName, model);
            }
            else
            {
                result = InvokePythonFunction(methodName, inputParam);
            }

            DA.SetData(0, result);
        }

        public object InvokeFunction(string function, object param)
        {
            var handlerType = typeof(Handler);

            var methodFound = handlerType.GetMethod(function, BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            object resultValue = methodFound.Invoke(null, new[] { param });
            return resultValue;
        }

        public object InvokePythonFunction(string function, object param)
        {
            if (param == null) return null;

            var pyRun = Rhino.Runtime.PythonScript.Create();
            pyRun.SetVariable("param", param);

            string pyScript = $"import scriptcontext as rs; Handler = rs.sticky['handler'];result=Handler.{function}(param)";
            pyRun.ExecuteScript(pyScript);

            var PyObject = pyRun.GetVariable("result");

            return PyObject;
        }

        protected override System.Drawing.Bitmap Icon => null;

        public override Guid ComponentGuid => new Guid("c53fe6bf-6238-4a34-aef9-68b261502bba");

        //public DAG GetRecipeSample()
        //{
        //    //var recipe = new QueenbeeSDK.Recipe(null);
        //    var dag = new QueenbeeSDK.DAG("dag", null);
        //    var input = new QueenbeeSDK.DAGFileInput("model_json");
        //    input.Default = "model json path";
        //    var alias = new DAGFileInputAlias(
        //        "hbModel", 
        //        new List<string> { "grasshopper" },
        //        new List<IOAliasHandler> { new IOAliasHandler("csharp", "DemoGH.Handler", "ModelToString") }
        //        );

        //    input.Alias = new List<AnyOf<DAGGenericInputAlias, DAGStringInputAlias, DAGIntegerInputAlias, DAGNumberInputAlias, DAGBooleanInputAlias, DAGFolderInputAlias, DAGFileInputAlias, DAGPathInputAlias, DAGArrayInputAlias, DAGObjectInputAlias>>();
        //    input.Alias.Add(alias);

        //    return dag;
        //}
    }

    
}
