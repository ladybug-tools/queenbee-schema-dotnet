
# QueenbeeSDK.Model.Workflow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Recipe** | [**BakedRecipe**](BakedRecipe.md) | The baked recipe to be used by the execution engine to generate a workflow | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "Workflow"]
**Labels** | **Object** | Optional user data as a dictionary. User data is for user reference only and will not be used in the execution of the workflow. | [optional] 
**Arguments** | [**List&lt;AnyOfWorkflowArgumentWorkflowPathArgument&gt;**](AnyOfWorkflowArgumentWorkflowPathArgument.md) | Input arguments for this workflow | [optional] 
**Status** | [**WorkflowStatus**](WorkflowStatus.md) | The status of the workflow | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

