using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueenbeeSDK.Test
{
    public class TypeTests
    {

        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void RecipeInstanceTest()
        {
            //var objt = License.FromJson("{}");
            var assembly = typeof(License).Assembly;
            var alltypes = assembly.GetTypes().Where(_=>_.IsClass && !_.IsAbstract && _.IsSubclassOf(typeof(OpenAPIGenBaseModel)));
            //foreach (var item in alltypes)
            //{
            //    var obj = Activator.CreateInstance(item);
            //    if (obj == null) continue;
            //    //  as OpenAPIGenBaseModel
            //    var t = obj.GetType().Name;
            //    //Assert.AreEqual(t, obj.Type);
            //}
            
        }

      
    }
}
