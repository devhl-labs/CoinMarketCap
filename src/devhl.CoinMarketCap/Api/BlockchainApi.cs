// <auto-generated>
/*
 * CoinMarketCap Cryptocurrency API Documentation
 *
 * # Introduction The CoinMarketCap API is a suite of high-performance RESTful JSON endpoints that are specifically designed to meet the mission-critical demands of application developers, data scientists, and enterprise business platforms.  This API reference includes all technical documentation developers need to integrate third-party applications and platforms. Additional answers to common questions can be found in the [CoinMarketCap API FAQ](https://coinmarketcap.com/api/faq).  # Quick Start Guide  For developers eager to hit the ground running with the CoinMarketCap API here are a few quick steps to make your first call with the API.  1. **Sign up for a free Developer Portal account.** You can sign up at [pro.coinmarketcap.com](https://pro.coinmarketcap.com) - This is our live production environment with the latest market data. Select the free `Basic` plan if it meets your needs or upgrade to a paid tier. 2. **Copy your API Key.** Once you sign up you'll land on your Developer Portal account dashboard. Copy your API from the `API Key` box in the top left panel. 3. **Make a test call using your key.** You may use the code examples provided below to make a test call with your programming language of choice. This example [fetches all active cryptocurrencies by market cap and return market values in USD](https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?start=1&limit=5000&convert=USD).     *Be sure to replace the API Key in sample code with your own and use API domain `pro-api.coinmarketcap.com` or use the test API Key `b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c` for `sandbox-api.coinmarketcap.com` testing with our sandbox.coinmarketcap.com environment. Please note that our sandbox api has mock data and should not be used in your application.*
 *
 * The version of the OpenAPI document: 1.26.0
 * Contact: api@coinmarketcap.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using devhl.CoinMarketCap.Client;
using devhl.CoinMarketCap.Model;

namespace devhl.CoinMarketCap.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBlockchainApi : IApi
    {
        /// <summary>
        /// Statistics Latest
        /// </summary>
        /// <remarks>
        /// Returns the latest blockchain statistics data for 1 or more blockchains. Bitcoin, Litecoin, and Ethereum are currently supported. Additional blockchains will be made available on a regular basis.         **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:**   - ~~Basic~~   - ~~Hobbyist~~   - ~~Startup~~   - ~~Standard~~   - ~~Professional~~   - Enterprise  **Cache / Update frequency:** Every 15 seconds.   **Plan credit use:** 1 call credit per request.   **CMC equivalent pages:** Our blockchain explorer pages like [blockchain.coinmarketcap.com/](https://blockchain.coinmarketcap.com/).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">One or more comma-separated cryptocurrency CoinMarketCap IDs to return blockchain data for. Pass &#x60;1,2,1027&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="symbol">Alternatively pass one or more comma-separated cryptocurrency symbols. Pass &#x60;BTC,LTC,ETH&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="slug">Alternatively pass a comma-separated list of cryptocurrency slugs. Pass &#x60;bitcoin,litecoin,ethereum&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;BlockchainStatisticsLatestResponseModel?&gt;&gt;</returns>
        Task<ApiResponse<BlockchainStatisticsLatestResponseModel?>> GetV1BlockchainStatisticsLatestWithHttpInfoAsync(string? id = null, string? symbol = null, string? slug = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Statistics Latest
        /// </summary>
        /// <remarks>
        /// Returns the latest blockchain statistics data for 1 or more blockchains. Bitcoin, Litecoin, and Ethereum are currently supported. Additional blockchains will be made available on a regular basis.         **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:**   - ~~Basic~~   - ~~Hobbyist~~   - ~~Startup~~   - ~~Standard~~   - ~~Professional~~   - Enterprise  **Cache / Update frequency:** Every 15 seconds.   **Plan credit use:** 1 call credit per request.   **CMC equivalent pages:** Our blockchain explorer pages like [blockchain.coinmarketcap.com/](https://blockchain.coinmarketcap.com/).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">One or more comma-separated cryptocurrency CoinMarketCap IDs to return blockchain data for. Pass &#x60;1,2,1027&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="symbol">Alternatively pass one or more comma-separated cryptocurrency symbols. Pass &#x60;BTC,LTC,ETH&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="slug">Alternatively pass a comma-separated list of cryptocurrency slugs. Pass &#x60;bitcoin,litecoin,ethereum&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;BlockchainStatisticsLatestResponseModel&gt;</returns>
        Task<BlockchainStatisticsLatestResponseModel?> GetV1BlockchainStatisticsLatestAsync(string? id = null, string? symbol = null, string? slug = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Statistics Latest
        /// </summary>
        /// <remarks>
        /// Returns the latest blockchain statistics data for 1 or more blockchains. Bitcoin, Litecoin, and Ethereum are currently supported. Additional blockchains will be made available on a regular basis.         **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:**   - ~~Basic~~   - ~~Hobbyist~~   - ~~Startup~~   - ~~Standard~~   - ~~Professional~~   - Enterprise  **Cache / Update frequency:** Every 15 seconds.   **Plan credit use:** 1 call credit per request.   **CMC equivalent pages:** Our blockchain explorer pages like [blockchain.coinmarketcap.com/](https://blockchain.coinmarketcap.com/).
        /// </remarks>
        /// <param name="id">One or more comma-separated cryptocurrency CoinMarketCap IDs to return blockchain data for. Pass &#x60;1,2,1027&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="symbol">Alternatively pass one or more comma-separated cryptocurrency symbols. Pass &#x60;BTC,LTC,ETH&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="slug">Alternatively pass a comma-separated list of cryptocurrency slugs. Pass &#x60;bitcoin,litecoin,ethereum&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;BlockchainStatisticsLatestResponseModel?&gt;</returns>
        Task<BlockchainStatisticsLatestResponseModel?> GetV1BlockchainStatisticsLatestOrDefaultAsync(string? id = null, string? symbol = null, string? slug = null, System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BlockchainApi : IBlockchainApi
    {
        /// <summary>
        /// An event to track the health of the server. 
        /// If you store these event args, be sure to purge old event args to prevent a memory leak.
        /// </summary>
        public event ClientUtils.EventHandler<ApiResponseEventArgs>? ApiResponded;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<BlockchainApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockchainApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlockchainApi(ILogger<BlockchainApi> logger, HttpClient httpClient, 
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Statistics Latest Returns the latest blockchain statistics data for 1 or more blockchains. Bitcoin, Litecoin, and Ethereum are currently supported. Additional blockchains will be made available on a regular basis.         **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:**   - ~~Basic~~   - ~~Hobbyist~~   - ~~Startup~~   - ~~Standard~~   - ~~Professional~~   - Enterprise  **Cache / Update frequency:** Every 15 seconds.   **Plan credit use:** 1 call credit per request.   **CMC equivalent pages:** Our blockchain explorer pages like [blockchain.coinmarketcap.com/](https://blockchain.coinmarketcap.com/).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">One or more comma-separated cryptocurrency CoinMarketCap IDs to return blockchain data for. Pass &#x60;1,2,1027&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="symbol">Alternatively pass one or more comma-separated cryptocurrency symbols. Pass &#x60;BTC,LTC,ETH&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="slug">Alternatively pass a comma-separated list of cryptocurrency slugs. Pass &#x60;bitcoin,litecoin,ethereum&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="BlockchainStatisticsLatestResponseModel"/>&gt;</returns>
        public async Task<BlockchainStatisticsLatestResponseModel?> GetV1BlockchainStatisticsLatestAsync(string? id = null, string? symbol = null, string? slug = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<BlockchainStatisticsLatestResponseModel?> result = await GetV1BlockchainStatisticsLatestWithHttpInfoAsync(id, symbol, slug, cancellationToken).ConfigureAwait(false);
            
            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Statistics Latest Returns the latest blockchain statistics data for 1 or more blockchains. Bitcoin, Litecoin, and Ethereum are currently supported. Additional blockchains will be made available on a regular basis.         **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:**   - ~~Basic~~   - ~~Hobbyist~~   - ~~Startup~~   - ~~Standard~~   - ~~Professional~~   - Enterprise  **Cache / Update frequency:** Every 15 seconds.   **Plan credit use:** 1 call credit per request.   **CMC equivalent pages:** Our blockchain explorer pages like [blockchain.coinmarketcap.com/](https://blockchain.coinmarketcap.com/).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">One or more comma-separated cryptocurrency CoinMarketCap IDs to return blockchain data for. Pass &#x60;1,2,1027&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="symbol">Alternatively pass one or more comma-separated cryptocurrency symbols. Pass &#x60;BTC,LTC,ETH&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="slug">Alternatively pass a comma-separated list of cryptocurrency slugs. Pass &#x60;bitcoin,litecoin,ethereum&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="BlockchainStatisticsLatestResponseModel"/>&gt;</returns>
        public async Task<BlockchainStatisticsLatestResponseModel?> GetV1BlockchainStatisticsLatestOrDefaultAsync(string? id = null, string? symbol = null, string? slug = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<BlockchainStatisticsLatestResponseModel?>? result = null;
            try 
            {
                result = await GetV1BlockchainStatisticsLatestWithHttpInfoAsync(id, symbol, slug, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Statistics Latest Returns the latest blockchain statistics data for 1 or more blockchains. Bitcoin, Litecoin, and Ethereum are currently supported. Additional blockchains will be made available on a regular basis.         **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:**   - ~~Basic~~   - ~~Hobbyist~~   - ~~Startup~~   - ~~Standard~~   - ~~Professional~~   - Enterprise  **Cache / Update frequency:** Every 15 seconds.   **Plan credit use:** 1 call credit per request.   **CMC equivalent pages:** Our blockchain explorer pages like [blockchain.coinmarketcap.com/](https://blockchain.coinmarketcap.com/).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">One or more comma-separated cryptocurrency CoinMarketCap IDs to return blockchain data for. Pass &#x60;1,2,1027&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="symbol">Alternatively pass one or more comma-separated cryptocurrency symbols. Pass &#x60;BTC,LTC,ETH&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="slug">Alternatively pass a comma-separated list of cryptocurrency slugs. Pass &#x60;bitcoin,litecoin,ethereum&#x60; to request all currently supported blockchains. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="BlockchainStatisticsLatestResponseModel"/></returns>
        public async Task<ApiResponse<BlockchainStatisticsLatestResponseModel?>> GetV1BlockchainStatisticsLatestWithHttpInfoAsync(string? id = null, string? symbol = null, string? slug = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                using HttpRequestMessage request = new HttpRequestMessage();

                UriBuilder uriBuilder = new UriBuilder();
                uriBuilder.Host = HttpClient.BaseAddress!.Host;
                uriBuilder.Scheme = ClientUtils.SCHEME;
                uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/v1/blockchain/statistics/latest";

                System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                if (id != null)
                    parseQueryString["id"] = Uri.EscapeDataString(id.ToString()!);

                if (symbol != null)
                    parseQueryString["symbol"] = Uri.EscapeDataString(symbol.ToString()!);

                if (slug != null)
                    parseQueryString["slug"] = Uri.EscapeDataString(slug.ToString()!);

                uriBuilder.Query = parseQueryString.ToString();

                MultipartContent multipartContent = new MultipartContent();

                request.Content = multipartContent;

                List<TokenBase> tokens = new List<TokenBase>();
                    
                ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                
                tokens.Add(apiKey);
                
                apiKey.UseInHeader(request, "X-CMC_PRO_API_KEY");
                
                request.RequestUri = uriBuilder.Uri;
                
                string[] accepts = new string[] { 
                    "*/*" 
                };
                
                string? accept = ClientUtils.SelectHeaderAccept(accepts);

                if (accept != null)
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                
                request.Method = HttpMethod.Get;
                
                using HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                DateTime requestedAt = DateTime.UtcNow;

                string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                if (ApiResponded != null)
                {
                    try
                    {
                        ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/v1/blockchain/statistics/latest"));
                    }
                    catch(Exception e)
                    {
                        Logger.LogError(e, "An error occured while invoking ApiResponded.");
                    }
                }

                ApiResponse<BlockchainStatisticsLatestResponseModel?> apiResponse = new ApiResponse<BlockchainStatisticsLatestResponseModel?>(responseMessage, responseContent);

                if (apiResponse.IsSuccessStatusCode)
                    apiResponse.Content = Newtonsoft.Json.JsonConvert.DeserializeObject<BlockchainStatisticsLatestResponseModel>(apiResponse.RawContent, ClientUtils.JsonSerializerSettings);
                else if (apiResponse.StatusCode == HttpStatusCode.TooManyRequests)
                    foreach(TokenBase token in tokens)
                        token.BeginRateLimit();

                return apiResponse;
            } 
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }
    }
}