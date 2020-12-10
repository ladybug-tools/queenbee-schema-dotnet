[![Build](https://github.com/ladybug-tools/queenbee-dotnet/workflows/CD/badge.svg)](https://github.com/ladybug-tools/queenbee-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/QueenbeeSDK?dWidth=50)](https://www.nuget.org/packages/QueenbeeSDK)

# QueenbeeSDK - the C# library for the Queenbee Schema with Inheritance

Documentation for Queenbee schema.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.1.dev1+g326b731
- SDK version: 0.1.dev1+g326b731
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/queenbee](https://github.com/ladybug-tools/queenbee)

## Frameworks supported


- .NET Core >=1.0
- .NET Framework >=4.5

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using QueenbeeSDK.Api;
using QueenbeeSDK.Client;
using QueenbeeSDK.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out QueenbeeSDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using QueenbeeSDK.Api;
using QueenbeeSDK.Client;
using QueenbeeSDK.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


## Documentation for Models

 - [Model.ArtifactSource](docs/ArtifactSource.md)
 - [Model.ArtifactSourceAllOf](docs/ArtifactSourceAllOf.md)
 - [Model.BaseReference](docs/BaseReference.md)
 - [Model.BaseReferenceAllOf](docs/BaseReferenceAllOf.md)
 - [Model.DAG](docs/DAG.md)
 - [Model.DAGAllOf](docs/DAGAllOf.md)
 - [Model.DAGArrayInput](docs/DAGArrayInput.md)
 - [Model.DAGArrayInputAlias](docs/DAGArrayInputAlias.md)
 - [Model.DAGArrayInputAliasAllOf](docs/DAGArrayInputAliasAllOf.md)
 - [Model.DAGArrayInputAllOf](docs/DAGArrayInputAllOf.md)
 - [Model.DAGArrayOutput](docs/DAGArrayOutput.md)
 - [Model.DAGArrayOutputAlias](docs/DAGArrayOutputAlias.md)
 - [Model.DAGArrayOutputAliasAllOf](docs/DAGArrayOutputAliasAllOf.md)
 - [Model.DAGArrayOutputAllOf](docs/DAGArrayOutputAllOf.md)
 - [Model.DAGBooleanInput](docs/DAGBooleanInput.md)
 - [Model.DAGBooleanInputAlias](docs/DAGBooleanInputAlias.md)
 - [Model.DAGBooleanInputAliasAllOf](docs/DAGBooleanInputAliasAllOf.md)
 - [Model.DAGBooleanInputAllOf](docs/DAGBooleanInputAllOf.md)
 - [Model.DAGBooleanOutput](docs/DAGBooleanOutput.md)
 - [Model.DAGBooleanOutputAlias](docs/DAGBooleanOutputAlias.md)
 - [Model.DAGBooleanOutputAliasAllOf](docs/DAGBooleanOutputAliasAllOf.md)
 - [Model.DAGBooleanOutputAllOf](docs/DAGBooleanOutputAllOf.md)
 - [Model.DAGFileInput](docs/DAGFileInput.md)
 - [Model.DAGFileInputAlias](docs/DAGFileInputAlias.md)
 - [Model.DAGFileInputAliasAllOf](docs/DAGFileInputAliasAllOf.md)
 - [Model.DAGFileInputAllOf](docs/DAGFileInputAllOf.md)
 - [Model.DAGFileOutput](docs/DAGFileOutput.md)
 - [Model.DAGFileOutputAlias](docs/DAGFileOutputAlias.md)
 - [Model.DAGFileOutputAliasAllOf](docs/DAGFileOutputAliasAllOf.md)
 - [Model.DAGFileOutputAllOf](docs/DAGFileOutputAllOf.md)
 - [Model.DAGFolderInput](docs/DAGFolderInput.md)
 - [Model.DAGFolderInputAlias](docs/DAGFolderInputAlias.md)
 - [Model.DAGFolderInputAliasAllOf](docs/DAGFolderInputAliasAllOf.md)
 - [Model.DAGFolderInputAllOf](docs/DAGFolderInputAllOf.md)
 - [Model.DAGFolderOutput](docs/DAGFolderOutput.md)
 - [Model.DAGFolderOutputAlias](docs/DAGFolderOutputAlias.md)
 - [Model.DAGFolderOutputAliasAllOf](docs/DAGFolderOutputAliasAllOf.md)
 - [Model.DAGFolderOutputAllOf](docs/DAGFolderOutputAllOf.md)
 - [Model.DAGGenericInput](docs/DAGGenericInput.md)
 - [Model.DAGGenericInputAlias](docs/DAGGenericInputAlias.md)
 - [Model.DAGGenericInputAliasAllOf](docs/DAGGenericInputAliasAllOf.md)
 - [Model.DAGGenericInputAllOf](docs/DAGGenericInputAllOf.md)
 - [Model.DAGGenericOutput](docs/DAGGenericOutput.md)
 - [Model.DAGGenericOutputAlias](docs/DAGGenericOutputAlias.md)
 - [Model.DAGGenericOutputAliasAllOf](docs/DAGGenericOutputAliasAllOf.md)
 - [Model.DAGGenericOutputAllOf](docs/DAGGenericOutputAllOf.md)
 - [Model.DAGIntegerInput](docs/DAGIntegerInput.md)
 - [Model.DAGIntegerInputAlias](docs/DAGIntegerInputAlias.md)
 - [Model.DAGIntegerInputAliasAllOf](docs/DAGIntegerInputAliasAllOf.md)
 - [Model.DAGIntegerInputAllOf](docs/DAGIntegerInputAllOf.md)
 - [Model.DAGIntegerOutput](docs/DAGIntegerOutput.md)
 - [Model.DAGIntegerOutputAlias](docs/DAGIntegerOutputAlias.md)
 - [Model.DAGIntegerOutputAliasAllOf](docs/DAGIntegerOutputAliasAllOf.md)
 - [Model.DAGIntegerOutputAllOf](docs/DAGIntegerOutputAllOf.md)
 - [Model.DAGJSONObjectInput](docs/DAGJSONObjectInput.md)
 - [Model.DAGJSONObjectInputAlias](docs/DAGJSONObjectInputAlias.md)
 - [Model.DAGJSONObjectInputAliasAllOf](docs/DAGJSONObjectInputAliasAllOf.md)
 - [Model.DAGJSONObjectInputAllOf](docs/DAGJSONObjectInputAllOf.md)
 - [Model.DAGJSONObjectOutput](docs/DAGJSONObjectOutput.md)
 - [Model.DAGJSONObjectOutputAlias](docs/DAGJSONObjectOutputAlias.md)
 - [Model.DAGJSONObjectOutputAliasAllOf](docs/DAGJSONObjectOutputAliasAllOf.md)
 - [Model.DAGJSONObjectOutputAllOf](docs/DAGJSONObjectOutputAllOf.md)
 - [Model.DAGLinkedInputAlias](docs/DAGLinkedInputAlias.md)
 - [Model.DAGLinkedInputAliasAllOf](docs/DAGLinkedInputAliasAllOf.md)
 - [Model.DAGLinkedOutputAlias](docs/DAGLinkedOutputAlias.md)
 - [Model.DAGLinkedOutputAliasAllOf](docs/DAGLinkedOutputAliasAllOf.md)
 - [Model.DAGNumberInput](docs/DAGNumberInput.md)
 - [Model.DAGNumberInputAlias](docs/DAGNumberInputAlias.md)
 - [Model.DAGNumberInputAliasAllOf](docs/DAGNumberInputAliasAllOf.md)
 - [Model.DAGNumberInputAllOf](docs/DAGNumberInputAllOf.md)
 - [Model.DAGNumberOutput](docs/DAGNumberOutput.md)
 - [Model.DAGNumberOutputAlias](docs/DAGNumberOutputAlias.md)
 - [Model.DAGNumberOutputAliasAllOf](docs/DAGNumberOutputAliasAllOf.md)
 - [Model.DAGNumberOutputAllOf](docs/DAGNumberOutputAllOf.md)
 - [Model.DAGPathInput](docs/DAGPathInput.md)
 - [Model.DAGPathInputAlias](docs/DAGPathInputAlias.md)
 - [Model.DAGPathInputAliasAllOf](docs/DAGPathInputAliasAllOf.md)
 - [Model.DAGPathInputAllOf](docs/DAGPathInputAllOf.md)
 - [Model.DAGPathOutput](docs/DAGPathOutput.md)
 - [Model.DAGPathOutputAlias](docs/DAGPathOutputAlias.md)
 - [Model.DAGPathOutputAliasAllOf](docs/DAGPathOutputAliasAllOf.md)
 - [Model.DAGPathOutputAllOf](docs/DAGPathOutputAllOf.md)
 - [Model.DAGStringInput](docs/DAGStringInput.md)
 - [Model.DAGStringInputAlias](docs/DAGStringInputAlias.md)
 - [Model.DAGStringInputAliasAllOf](docs/DAGStringInputAliasAllOf.md)
 - [Model.DAGStringInputAllOf](docs/DAGStringInputAllOf.md)
 - [Model.DAGStringOutput](docs/DAGStringOutput.md)
 - [Model.DAGStringOutputAlias](docs/DAGStringOutputAlias.md)
 - [Model.DAGStringOutputAliasAllOf](docs/DAGStringOutputAliasAllOf.md)
 - [Model.DAGStringOutputAllOf](docs/DAGStringOutputAllOf.md)
 - [Model.DAGTask](docs/DAGTask.md)
 - [Model.DAGTaskAllOf](docs/DAGTaskAllOf.md)
 - [Model.DAGTaskLoop](docs/DAGTaskLoop.md)
 - [Model.DAGTaskLoopAllOf](docs/DAGTaskLoopAllOf.md)
 - [Model.Dependency](docs/Dependency.md)
 - [Model.DependencyAllOf](docs/DependencyAllOf.md)
 - [Model.DependencyKind](docs/DependencyKind.md)
 - [Model.DockerConfig](docs/DockerConfig.md)
 - [Model.DockerConfigAllOf](docs/DockerConfigAllOf.md)
 - [Model.FileReference](docs/FileReference.md)
 - [Model.FileReferenceAllOf](docs/FileReferenceAllOf.md)
 - [Model.FolderReference](docs/FolderReference.md)
 - [Model.FolderReferenceAllOf](docs/FolderReferenceAllOf.md)
 - [Model.FromOutput](docs/FromOutput.md)
 - [Model.FromOutputAllOf](docs/FromOutputAllOf.md)
 - [Model.Function](docs/Function.md)
 - [Model.FunctionAllOf](docs/FunctionAllOf.md)
 - [Model.FunctionArrayInput](docs/FunctionArrayInput.md)
 - [Model.FunctionArrayInputAllOf](docs/FunctionArrayInputAllOf.md)
 - [Model.FunctionArrayOutput](docs/FunctionArrayOutput.md)
 - [Model.FunctionArrayOutputAllOf](docs/FunctionArrayOutputAllOf.md)
 - [Model.FunctionBooleanInput](docs/FunctionBooleanInput.md)
 - [Model.FunctionBooleanInputAllOf](docs/FunctionBooleanInputAllOf.md)
 - [Model.FunctionBooleanOutput](docs/FunctionBooleanOutput.md)
 - [Model.FunctionBooleanOutputAllOf](docs/FunctionBooleanOutputAllOf.md)
 - [Model.FunctionFileInput](docs/FunctionFileInput.md)
 - [Model.FunctionFileInputAllOf](docs/FunctionFileInputAllOf.md)
 - [Model.FunctionFileOutput](docs/FunctionFileOutput.md)
 - [Model.FunctionFileOutputAllOf](docs/FunctionFileOutputAllOf.md)
 - [Model.FunctionFolderInput](docs/FunctionFolderInput.md)
 - [Model.FunctionFolderInputAllOf](docs/FunctionFolderInputAllOf.md)
 - [Model.FunctionFolderOutput](docs/FunctionFolderOutput.md)
 - [Model.FunctionFolderOutputAllOf](docs/FunctionFolderOutputAllOf.md)
 - [Model.FunctionIntegerInput](docs/FunctionIntegerInput.md)
 - [Model.FunctionIntegerInputAllOf](docs/FunctionIntegerInputAllOf.md)
 - [Model.FunctionIntegerOutput](docs/FunctionIntegerOutput.md)
 - [Model.FunctionIntegerOutputAllOf](docs/FunctionIntegerOutputAllOf.md)
 - [Model.FunctionJSONObjectInput](docs/FunctionJSONObjectInput.md)
 - [Model.FunctionJSONObjectInputAllOf](docs/FunctionJSONObjectInputAllOf.md)
 - [Model.FunctionJSONObjectOutput](docs/FunctionJSONObjectOutput.md)
 - [Model.FunctionJSONObjectOutputAllOf](docs/FunctionJSONObjectOutputAllOf.md)
 - [Model.FunctionNumberInput](docs/FunctionNumberInput.md)
 - [Model.FunctionNumberInputAllOf](docs/FunctionNumberInputAllOf.md)
 - [Model.FunctionNumberOutput](docs/FunctionNumberOutput.md)
 - [Model.FunctionNumberOutputAllOf](docs/FunctionNumberOutputAllOf.md)
 - [Model.FunctionPathInput](docs/FunctionPathInput.md)
 - [Model.FunctionPathInputAllOf](docs/FunctionPathInputAllOf.md)
 - [Model.FunctionPathOutput](docs/FunctionPathOutput.md)
 - [Model.FunctionPathOutputAllOf](docs/FunctionPathOutputAllOf.md)
 - [Model.FunctionStringInput](docs/FunctionStringInput.md)
 - [Model.FunctionStringInputAllOf](docs/FunctionStringInputAllOf.md)
 - [Model.FunctionStringOutput](docs/FunctionStringOutput.md)
 - [Model.FunctionStringOutputAllOf](docs/FunctionStringOutputAllOf.md)
 - [Model.GenericInput](docs/GenericInput.md)
 - [Model.GenericInputAllOf](docs/GenericInputAllOf.md)
 - [Model.GenericOutput](docs/GenericOutput.md)
 - [Model.GenericOutputAllOf](docs/GenericOutputAllOf.md)
 - [Model.HTTP](docs/HTTP.md)
 - [Model.HTTPAllOf](docs/HTTPAllOf.md)
 - [Model.IOAliasHandler](docs/IOAliasHandler.md)
 - [Model.IOAliasHandlerAllOf](docs/IOAliasHandlerAllOf.md)
 - [Model.IOBase](docs/IOBase.md)
 - [Model.IOBaseAllOf](docs/IOBaseAllOf.md)
 - [Model.InputFileReference](docs/InputFileReference.md)
 - [Model.InputFileReferenceAllOf](docs/InputFileReferenceAllOf.md)
 - [Model.InputFolderReference](docs/InputFolderReference.md)
 - [Model.InputFolderReferenceAllOf](docs/InputFolderReferenceAllOf.md)
 - [Model.InputPathReference](docs/InputPathReference.md)
 - [Model.InputPathReferenceAllOf](docs/InputPathReferenceAllOf.md)
 - [Model.InputReference](docs/InputReference.md)
 - [Model.InputReferenceAllOf](docs/InputReferenceAllOf.md)
 - [Model.InputReferenceBase](docs/InputReferenceBase.md)
 - [Model.InputReferenceBaseAllOf](docs/InputReferenceBaseAllOf.md)
 - [Model.ItemReference](docs/ItemReference.md)
 - [Model.ItemReferenceAllOf](docs/ItemReferenceAllOf.md)
 - [Model.ItemType](docs/ItemType.md)
 - [Model.Job](docs/Job.md)
 - [Model.JobAllOf](docs/JobAllOf.md)
 - [Model.JobArgument](docs/JobArgument.md)
 - [Model.JobArgumentAllOf](docs/JobArgumentAllOf.md)
 - [Model.JobPathArgument](docs/JobPathArgument.md)
 - [Model.JobPathArgumentAllOf](docs/JobPathArgumentAllOf.md)
 - [Model.License](docs/License.md)
 - [Model.LicenseAllOf](docs/LicenseAllOf.md)
 - [Model.LocalConfig](docs/LocalConfig.md)
 - [Model.LocalConfigAllOf](docs/LocalConfigAllOf.md)
 - [Model.Maintainer](docs/Maintainer.md)
 - [Model.MaintainerAllOf](docs/MaintainerAllOf.md)
 - [Model.MetaData](docs/MetaData.md)
 - [Model.MetaDataAllOf](docs/MetaDataAllOf.md)
 - [Model.OpenAPIGenBaseModel](docs/OpenAPIGenBaseModel.md)
 - [Model.PathOutput](docs/PathOutput.md)
 - [Model.PathOutputAllOf](docs/PathOutputAllOf.md)
 - [Model.Plugin](docs/Plugin.md)
 - [Model.PluginAllOf](docs/PluginAllOf.md)
 - [Model.PluginConfig](docs/PluginConfig.md)
 - [Model.PluginConfigAllOf](docs/PluginConfigAllOf.md)
 - [Model.ProjectFolder](docs/ProjectFolder.md)
 - [Model.ProjectFolderAllOf](docs/ProjectFolderAllOf.md)
 - [Model.Recipe](docs/Recipe.md)
 - [Model.RecipeAllOf](docs/RecipeAllOf.md)
 - [Model.S3](docs/S3.md)
 - [Model.S3AllOf](docs/S3AllOf.md)
 - [Model.TaskArgument](docs/TaskArgument.md)
 - [Model.TaskArgumentAllOf](docs/TaskArgumentAllOf.md)
 - [Model.TaskFileReference](docs/TaskFileReference.md)
 - [Model.TaskFileReferenceAllOf](docs/TaskFileReferenceAllOf.md)
 - [Model.TaskFolderReference](docs/TaskFolderReference.md)
 - [Model.TaskFolderReferenceAllOf](docs/TaskFolderReferenceAllOf.md)
 - [Model.TaskPathArgument](docs/TaskPathArgument.md)
 - [Model.TaskPathArgumentAllOf](docs/TaskPathArgumentAllOf.md)
 - [Model.TaskPathReference](docs/TaskPathReference.md)
 - [Model.TaskPathReferenceAllOf](docs/TaskPathReferenceAllOf.md)
 - [Model.TaskPathReturn](docs/TaskPathReturn.md)
 - [Model.TaskPathReturnAllOf](docs/TaskPathReturnAllOf.md)
 - [Model.TaskReference](docs/TaskReference.md)
 - [Model.TaskReferenceAllOf](docs/TaskReferenceAllOf.md)
 - [Model.TaskReferenceBase](docs/TaskReferenceBase.md)
 - [Model.TaskReferenceBaseAllOf](docs/TaskReferenceBaseAllOf.md)
 - [Model.TaskReturn](docs/TaskReturn.md)
 - [Model.TaskReturnAllOf](docs/TaskReturnAllOf.md)
 - [Model.ValueFileReference](docs/ValueFileReference.md)
 - [Model.ValueFileReferenceAllOf](docs/ValueFileReferenceAllOf.md)
 - [Model.ValueFolderReference](docs/ValueFolderReference.md)
 - [Model.ValueFolderReferenceAllOf](docs/ValueFolderReferenceAllOf.md)
 - [Model.ValueListReference](docs/ValueListReference.md)
 - [Model.ValueListReferenceAllOf](docs/ValueListReferenceAllOf.md)
 - [Model.ValueReference](docs/ValueReference.md)
 - [Model.ValueReferenceAllOf](docs/ValueReferenceAllOf.md)


## Documentation for Authorization

All endpoints do not require authorization.
