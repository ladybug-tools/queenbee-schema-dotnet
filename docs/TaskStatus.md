
# QueenbeeSDK.Model.TaskStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot; | 
**StartedAt** | **DateTime** | The time at which the task was started | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Message** | **string** | Any message produced by the task. Usually error/debugging hints. | [optional] 
**FinishedAt** | **DateTime** | The time at which the task was completed | [optional] 
**Id** | **string** | The task unique ID | 
**Name** | **string** | A human readable name for the task. Usually defined by the DAG task name but can be extended if the task is part of a loop for example. This name is unique within the boundary of the DAG/Workflow that generated it. | 
**StatusType** | **StatusType** | The type of task this status is for. Can be \&quot;Function\&quot;, \&quot;DAG\&quot; or \&quot;Loop\&quot; | 
**TemplateRef** | **string** | The name of the template that spawned this task | 
**Inputs** | [**AnyOfTaskArgumentTaskPathArgument**](AnyOfTaskArgumentTaskPathArgument.md) | The inputs used by this task | 
**Outputs** | [**AnyOfTaskReturnTaskPathReturn**](AnyOfTaskReturnTaskPathReturn.md) | The outputs produced by this task | 
**Children** | **List&lt;string&gt;** | A list of child task IDs | 
**OutboundTasks** | **List&lt;string&gt;** | A list of the last tasks to ran in the context of this task. In the case of a DAG or a workflow this will be the last task that has been executed. It will remain empty for functions. | 
**Command** | **string** | The command used to run this task. Only applies to Function tasks. | [optional] 
**BoundaryId** | **string** | This indicates the task ID of the associated template root             task in which this task belongs to. A DAG task will have the id of the             parent DAG for example. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "TaskStatus"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

