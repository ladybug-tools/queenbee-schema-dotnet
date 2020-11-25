
# QueenbeeSDK.Model.WorkflowPathArgument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Argument name. The name must match one of the input names from Workflow&#39;s template which can be a function or DAG. | 
**Source** | [**AnyOfHTTPS3ProjectFolder**](AnyOfHTTPS3ProjectFolder.md) | The path to source the file from. | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "WorkflowPathArgument"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

