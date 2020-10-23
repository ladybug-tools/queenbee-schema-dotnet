#!/bin/bash

# install 
npm install @openapitools/openapi-generator-cli

# check version
# npx @openapitools/openapi-generator-cli version-manager list
# use 5.0.0

# check version, clean up
python .openapi-generator/pre_gen_script.py 

# generate
npx @openapitools/openapi-generator-cli generate -i "openapi/recipe_inheritance.json" -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-generator/config.json 

# fix anyof, clean up
python .openapi-generator/post_gen_script.py "openapi/recipe_inheritance.json" 

# build, test, pack
dotnet build -c Release /nowarn:CS0472,CS0108,CS1591
dotnet test -c Release
dotnet pack .\\src\\QueenbeeSDK\\QueenbeeSDK.csproj -o ../../output -c Release --no-build