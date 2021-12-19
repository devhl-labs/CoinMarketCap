$ErrorActionPreference = "Stop"
$jar = Resolve-Path -Path $PSScriptRoot\..\..\..\openapi-generator\modules\openapi-generator-cli\target\openapi-generator-cli.jar
$swagger = Resolve-Path -Path $PSScriptRoot\..\swagger.yml
New-Item -Path $PSScriptRoot\..\..\generated-src -ItemType Directory -Force
$output = Resolve-Path -Path $PSScriptRoot\..\..\generated-src
$templates = Resolve-Path -Path $PSScriptRoot\..\templates

$properties = @(
    'projectName=Cmc'
    'packageName=Cmc',
    'targetFramework=net5.0'
    'validatable=false',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=false',
    'packageVersion=1.0.0'
) -join ","

$global = @(
    'apiDocs=false'
    'modelDocs=false',
    'apiTests=true',
    'modelTests=false'
) -join ","

java -jar $jar generate `
    -g csharp-netcore `
    -i $swagger `
    -o $output `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    -t $templates

$readme = Resolve-Path -Path $PSScriptRoot\..\..\generated-src\README.md
$src = Resolve-Path -Path $PSScriptRoot\..\..
Copy-Item -Path $readme -Destination $src -Force