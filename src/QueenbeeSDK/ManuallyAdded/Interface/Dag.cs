using System.Collections.Generic;

namespace QueenbeeSDK.Interface.Io.Inputs
{
	public partial interface IDag : IoBase
	{
		List<AnyOf<DAGGenericInputAlias, DAGStringInputAlias, DAGIntegerInputAlias, DAGNumberInputAlias, DAGBooleanInputAlias, DAGFolderInputAlias, DAGFileInputAlias, DAGPathInputAlias, DAGArrayInputAlias, DAGJSONObjectInputAlias, DAGLinkedInputAlias>> Alias { get; set; }

	}
}

namespace QueenbeeSDK.Interface.Io.Outputs
{
	public partial interface IDag : IoBase
	{
		List<AnyOf<DAGGenericOutputAlias, DAGStringOutputAlias, DAGIntegerOutputAlias, DAGNumberOutputAlias, DAGBooleanOutputAlias, DAGFolderOutputAlias, DAGFileOutputAlias, DAGPathOutputAlias, DAGArrayOutputAlias, DAGJSONObjectOutputAlias, DAGLinkedOutputAlias>> Alias { get; set; }

	}
}