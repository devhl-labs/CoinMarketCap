$ErrorActionPreference = "Stop"
$jar = Resolve-Path -Path $PSScriptRoot\..\..\..\openapi-generator\modules\openapi-generator-cli\target\openapi-generator-cli.jar
$swagger = Resolve-Path -Path $PSScriptRoot\..\..\..\CoinMarketCap-Swagger\swagger.yaml
$output = Resolve-Path -Path $PSScriptRoot\..\..
# $templates = Resolve-Path -Path $PSScriptRoot\..\templates

$properties = @(
    "apiName=Cmc",
    "targetFramework=net5.0",
    "validatable=false",
    "nullableReferenceTypes=true",
    "hideGenerationTimestamp=false",
    "packageVersion=1.0.0-prerelease0.0.2",
    "packageAuthors=devhl",
    "packageDescription=A wrapper for the CoinMarketCap API",
    "packageTags=CoinMarketCap crypto currency api",
    "packageName=devhl.CoinMarketCap",
    "packageCompany=devhl",
    "packageCopyright=2021",
    "licenseId=MIT",
    "packageTitle=CoinMarketCap"
) -join ","

$global = @(
    'apiDocs=false',
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
    --git-host "github.com" `
    --git-repo-id "CoinMarketCap" `
    --git-user-id "devhl-labs" `
    --release-note "The CMC swagger file is scuffed. To get your endpoint working view this change as an example, then submit a PR. https://github.com/devhl-labs/CoinMarketCap-Swagger/commit/5f25dfd24c9ba792cace35111ee9ca9d35b07771#diff-8b1949772e223a1da6a2049ada2733fa506410975b241cf86cf44c7a8665bc62" `
    # -t $templates
    #--package-name 'devhl.CoinMarketCap' `
