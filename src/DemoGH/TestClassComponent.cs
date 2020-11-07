using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using QueenbeeSDK;


namespace DemoGH
{
    public class TestClassComponent : GH_Component
    {
        public TestClassComponent()
          : base("TestClassComponent", "Nickname",
              "Description",
              "Category", "Subcategory")
        {
        }

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("m", "m", "model", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            var obj = new Model();
            DA.SetData(0, obj);
        }

        protected override System.Drawing.Bitmap Icon => null;

        public override Guid ComponentGuid => new Guid("CFC35090-B3D9-4C58-A417-4C5EFDD518ED");

        
    }

    public class Model
    {
        public Model()
        {
        }

        public string ModelToString()
        {
            return "ModelToString from csharp is called";
        }
    }

    public static class Handler
    {
        public static string ModelToString(Model model)
        {
            return model.ModelToString();
        }
    }

}
