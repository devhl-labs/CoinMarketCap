$jar = Resolve-Path -Path $PSScriptRoot\..\..\..\openapi-generator\modules\openapi-generator-cli\target\openapi-generator-cli.jar
$swagger = Resolve-Path -Path $PSScriptRoot\..\swagger.yml
$output = Resolve-Path -Path $PSScriptRoot\..\..\
# $models = Resolve-Path -Path $PSScriptRoot\..\Models

java -jar $jar generate `
    -g csharp-netcore `
    -i $swagger `
    -o $output `
    --library generichost `
    --additional-properties=projectName=Cmc,packageName=Cmc,targetFramework=net5.0,validatable=false,nullableReferenceTypes=true,hideGenerationTimestamp=false `
    --global-property=modelDocs=false,modelTests=false,apiDocs=false
