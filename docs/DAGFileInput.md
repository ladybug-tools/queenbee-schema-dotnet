
# QueenbeeSDK.Model.DAGFileInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Input name. | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Description** | **string** | Optional description for input. | [optional] 
**Default** | [**AnyOfHTTPS3ProjectFolder**](AnyOfHTTPS3ProjectFolder.md) | The default source for file if the value is not provided. | [optional] 
**Spec** | [**Object**](.md) | An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec. | [optional] 
**Extensions** | **List&lt;string&gt;** | Optional list of extensions for file. The check for extension is case-insensitive. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "DAGFileInput"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

