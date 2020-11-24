using System.Collections.Generic;

namespace QueenbeeSDK.Interface.Io
{
	public partial interface IDag 
	{
		string Name { get; set; }
		Dictionary<string, string> Annotations { get; set; }
		string Description { get; set; }
		bool Required { get; set; }
		object Spec { get; set; }

		List<AnyOf<DAGGenericInputAlias, DAGStringInputAlias, DAGIntegerInputAlias, DAGNumberInputAlias, DAGBooleanInputAlias, DAGFolderInputAlias, DAGFileInputAlias, DAGPathInputAlias, DAGArrayInputAlias, DAGJSONObjectInputAlias, DAGLinkModelInputAlias>> Alias { get; set; }
	}
}

