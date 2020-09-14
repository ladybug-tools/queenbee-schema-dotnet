#!/bin/bash

python .openapi-generator/pre_gen_script.py 
npx @openapitools/openapi-generator-cli generate -i "https://www.ladybug.tools/queenbee/_static/schemas/recipe-openapi.json"  -t ".openapi-generator/templates/csharp" -g csharp -o . --skip-validate-spec -c .openapi-generator/config.json 
python .openapi-generator/post_gen_script.py "https://www.ladybug.tools/queenbee/_static/schemas/recipe-openapi.json" 
# python .openapi-generator/update_assembly_version.py



