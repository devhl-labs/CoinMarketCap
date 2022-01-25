# Created with Openapi Generator

<a name="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Cmc',
    'targetFramework=net5.0',
    'validatable=false',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=false',
    'packageVersion=1.0.0-prerelease0.0.3',
    'packageAuthors=devhl',
    'packageCompany=devhl',
    'packageCopyright=2021',
    'packageDescription=A wrapper for the CoinMarketCap API',
    'licenseId=MIT',
    'packageName=devhl.CoinMarketCap',
    'packageTags=CoinMarketCap crypto currency api',
    'packageTitle=CoinMarketCap'
) -join ","

$global = @(
    'apiDocs=false',
    'modelDocs=false',
    'apiTests=true',
    'modelTests=false'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "CoinMarketCap" `
    --git-user-id "devhl-labs" `
    --release-note "The CMC swagger file is scuffed. To get your endpoint working view this change as an example, then submit a PR. https://github.com/devhl-labs/CoinMarketCap-Swagger/commit/5f25dfd24c9ba792cace35111ee9ca9d35b07771#diff-8b1949772e223a1da6a2049ada2733fa506410975b241cf86cf44c7a8665bc62"
    # -t templates
```

<a name="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using devhl.CoinMarketCap.Api;
using devhl.CoinMarketCap.Client;
using devhl.CoinMarketCap.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IBlockchainApi>();
            ApiResponse<BlockchainStatisticsLatestResponseModel?> foo = await api.GetV1BlockchainStatisticsLatestWithHttpInfoAsync("todo");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureCmc((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>");
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddCmcHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a name="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.

<a name="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [Polly](https://www.nuget.org/packages/Polly/) - 7.2.2 or later
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.7.0 or later

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

Authentication schemes defined for the API:

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: CMC_PRO_API_KEY
- **Location**: URL query string

## Build
- SDK version: 1.0.0-prerelease0.0.3
- Build date: 2022-01-24T22:50:40.816-05:00[America/New_York]
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

## Api Information
- appName: CoinMarketCap Cryptocurrency API Documentation
- appVersion: 1.26.0
- appDescription: # Introduction The CoinMarketCap API is a suite of high-performance RESTful JSON endpoints that are specifically designed to meet the mission-critical demands of application developers, data scientists, and enterprise business platforms.  This API reference includes all technical documentation developers need to integrate third-party applications and platforms. Additional answers to common questions can be found in the [CoinMarketCap API FAQ](https://coinmarketcap.com/api/faq).  # Quick Start Guide  For developers eager to hit the ground running with the CoinMarketCap API here are a few quick steps to make your first call with the API.  1. **Sign up for a free Developer Portal account.** You can sign up at [pro.coinmarketcap.com](https://pro.coinmarketcap.com) - This is our live production environment with the latest market data. Select the free &#x60;Basic&#x60; plan if it meets your needs or upgrade to a paid tier. 2. **Copy your API Key.** Once you sign up you&#39;ll land on your Developer Portal account dashboard. Copy your API from the &#x60;API Key&#x60; box in the top left panel. 3. **Make a test call using your key.** You may use the code examples provided below to make a test call with your programming language of choice. This example [fetches all active cryptocurrencies by market cap and return market values in USD](https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?start&#x3D;1&amp;limit&#x3D;5000&amp;convert&#x3D;USD).     *Be sure to replace the API Key in sample code with your own and use API domain &#x60;pro-api.coinmarketcap.com&#x60; or use the test API Key &#x60;b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c&#x60; for &#x60;sandbox-api.coinmarketcap.com&#x60; testing with our sandbox.coinmarketcap.com environment. Please note that our sandbox api has mock data and should not be used in your application.*

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: false
- modelDocs: false
- apiTests: true
- modelTests: false
- withXml: 

## [OpenApi Generator Parameteres](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Cmc
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: false
- disallowAdditionalPropertiesIfNotPresent: 
- gitHost: github.com
- gitRepoId: CoinMarketCap
- gitUserId: devhl-labs
- hideGenerationTimestamp: false
- interfacePrefix: I
- library: generichost
- licenseId: MIT
- modelPropertyNaming: 
- netCoreProjectFile: false
- nonPublicApi: false
- nullableReferenceTypes: true
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: devhl
- packageCompany: devhl
- packageCopyright: 2021
- packageDescription: A wrapper for the CoinMarketCap API
- packageGuid: {D18C1D8D-0478-41BF-BF36-3C2CC0B2811A}
- packageName: devhl.CoinMarketCap
- packageTags: CoinMarketCap crypto currency api
- packageTitle: CoinMarketCap
- packageVersion: 1.0.0-prerelease0.0.3
- releaseNote: The CMC swagger file is scuffed. To get your endpoint working view this change as an example, then submit a PR. https://github.com/devhl-labs/CoinMarketCap-Swagger/commit/5f25dfd24c9ba792cace35111ee9ca9d35b07771#diff-8b1949772e223a1da6a2049ada2733fa506410975b241cf86cf44c7a8665bc62
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: net5.0
- useCollection: false
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: false

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.