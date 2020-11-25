
# QueenbeeSDK.Model.WorkflowStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot; | 
**StartedAt** | **DateTime** | The time at which the task was started | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Message** | **string** | Any message produced by the task. Usually error/debugging hints. | [optional] 
**FinishedAt** | **DateTime** | The time at which the task was completed | [optional] 
**Id** | **string** | The ID of the individual workflow run. | 
**Entrypoint** | **string** | The ID of the first task in the workflow | [optional] 
**Tasks** | [**Dictionary&lt;string, TaskStatus&gt;**](TaskStatus.md) |  | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "WorkflowStatus"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

