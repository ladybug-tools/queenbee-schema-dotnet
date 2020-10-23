#!/bin/bash

python .openapi-generator/pre_gen_script.py 
npx @openapitools/openapi-generator-cli generate -i "openapi/recipe_inheritance.json"  -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-generator/config.json 
python .openapi-generator/post_gen_script.py "openapi/recipe_inheritance.json" 
# python .openapi-generator/update_assembly_version.py



npx @openapitools/openapi-generator-cli generate -i "openapi/recipe_inheritance.json"  -g csharp-netcore -o . -c .openapi-generator/config.json --skip-validate-spec

npx @openapitools/openapi-generator-cli generate -i "openapi/recipe_inheritance.json" -t ".openapi-generator/templates/csharp" -g csharp -o . -c .openapi-generator/config.json --skip-validate-spec

