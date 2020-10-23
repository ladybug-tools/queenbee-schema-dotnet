
# QueenbeeSDK.Model.DAG

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Inputs** | [**List&lt;AnyType&gt;**](AnyType.md) | Place-holder. Overwrite this! | [optional] 
**Outputs** | [**List&lt;AnyType&gt;**](AnyType.md) | Place-holder. Overwrite this! | [optional] 
**Name** | **string** | A unique name for this dag. | 
**Tasks** | [**List&lt;DAGTask&gt;**](DAGTask.md) | Tasks are a list of DAG steps | 
**FailFast** | **bool** | Stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Default is True. | [optional] [default to true]
**Type** | **string** |  | [optional] [readonly] [default to "DAG"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

