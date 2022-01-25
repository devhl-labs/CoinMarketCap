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
    public interface IToolsApi : IApi
    {
        /// <summary>
        /// Price Conversion
        /// </summary>
        /// <remarks>
        /// Convert an amount of one cryptocurrency or fiat currency into one or more different currencies utilizing the latest market rate for each currency. You may optionally pass a historical timestamp as &#x60;time&#x60; to convert values based on historical rates (as your API plan supports).     **Technical Notes** - Latest market rate conversions are accurate to 1 minute of specificity. Historical conversions are accurate to 1 minute of specificity outside of non-USD fiat conversions which have 5 minute specificity.  - You may reference a current list of all supported cryptocurrencies via the &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;cryptocurrency/map&lt;/a&gt; endpoint. This endpoint also returns the supported date ranges for historical conversions via the &#x60;first_historical_data&#x60; and &#x60;last_historical_data&#x60; properties.    - Conversions are supported in 93 different fiat currencies and 4 precious metals &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;as outlined here&lt;/a&gt;. Historical fiat conversions are supported as far back as 2013-04-28. - A &#x60;last_updated&#x60; timestamp is included for both your source currency and each conversion currency. This is the timestamp of the closest market rate record referenced for each currency during the conversion.    **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:** - Basic (Latest market price conversions) - Hobbyist (Latest market price conversions + 1 month historical) - Startup (Latest market price conversions + 1 month historical) - Standard (Latest market price conversions + 3 months historical) - Professional (Latest market price conversions + 12 months historical) - Enterprise (Latest market price conversions + up to 6 years historical)  **Cache / Update frequency:** Every 60 seconds for the lastest cryptocurrency and fiat currency rates.     **Plan credit use:** 1 call credit per call and 1 call credit per &#x60;convert&#x60; option beyond the first.   **CMC equivalent pages:** Our cryptocurrency conversion page at [coinmarketcap.com/converter/](https://coinmarketcap.com/converter/).  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="amount">An amount of currency to convert. Example: 10.43</param>
        /// <param name="id">The CoinMarketCap currency ID of the base cryptocurrency or fiat to convert from. Example: \&quot;1\&quot; (optional)</param>
        /// <param name="symbol">Alternatively the currency symbol of the base cryptocurrency or fiat to convert from. Example: \&quot;BTC\&quot;. One \&quot;id\&quot; *or* \&quot;symbol\&quot; is required. (optional)</param>
        /// <param name="time">Optional timestamp (Unix or ISO 8601) to reference historical pricing during conversion. If not passed, the current time will be used. If passed, we&#39;ll reference the closest historic values available for this conversion. (optional)</param>
        /// <param name="convert">Pass up to 120 comma-separated fiat or cryptocurrency symbols to convert the source amount to. (optional)</param>
        /// <param name="convertId">Optionally calculate market quotes by CoinMarketCap ID instead of symbol. This option is identical to &#x60;convert&#x60; outside of ID format. Ex: convert_id&#x3D;1,2781 would replace convert&#x3D;BTC,USD in your query. This parameter cannot be used when &#x60;convert&#x60; is used. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;ToolsPriceConversionResponseModel?&gt;&gt;</returns>
        Task<ApiResponse<ToolsPriceConversionResponseModel?>> GetV1ToolsPriceconversionWithHttpInfoAsync(decimal amount, string? id = null, string? symbol = null, string? time = null, string? convert = null, string? convertId = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Price Conversion
        /// </summary>
        /// <remarks>
        /// Convert an amount of one cryptocurrency or fiat currency into one or more different currencies utilizing the latest market rate for each currency. You may optionally pass a historical timestamp as &#x60;time&#x60; to convert values based on historical rates (as your API plan supports).     **Technical Notes** - Latest market rate conversions are accurate to 1 minute of specificity. Historical conversions are accurate to 1 minute of specificity outside of non-USD fiat conversions which have 5 minute specificity.  - You may reference a current list of all supported cryptocurrencies via the &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;cryptocurrency/map&lt;/a&gt; endpoint. This endpoint also returns the supported date ranges for historical conversions via the &#x60;first_historical_data&#x60; and &#x60;last_historical_data&#x60; properties.    - Conversions are supported in 93 different fiat currencies and 4 precious metals &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;as outlined here&lt;/a&gt;. Historical fiat conversions are supported as far back as 2013-04-28. - A &#x60;last_updated&#x60; timestamp is included for both your source currency and each conversion currency. This is the timestamp of the closest market rate record referenced for each currency during the conversion.    **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:** - Basic (Latest market price conversions) - Hobbyist (Latest market price conversions + 1 month historical) - Startup (Latest market price conversions + 1 month historical) - Standard (Latest market price conversions + 3 months historical) - Professional (Latest market price conversions + 12 months historical) - Enterprise (Latest market price conversions + up to 6 years historical)  **Cache / Update frequency:** Every 60 seconds for the lastest cryptocurrency and fiat currency rates.     **Plan credit use:** 1 call credit per call and 1 call credit per &#x60;convert&#x60; option beyond the first.   **CMC equivalent pages:** Our cryptocurrency conversion page at [coinmarketcap.com/converter/](https://coinmarketcap.com/converter/).  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="amount">An amount of currency to convert. Example: 10.43</param>
        /// <param name="id">The CoinMarketCap currency ID of the base cryptocurrency or fiat to convert from. Example: \&quot;1\&quot; (optional)</param>
        /// <param name="symbol">Alternatively the currency symbol of the base cryptocurrency or fiat to convert from. Example: \&quot;BTC\&quot;. One \&quot;id\&quot; *or* \&quot;symbol\&quot; is required. (optional)</param>
        /// <param name="time">Optional timestamp (Unix or ISO 8601) to reference historical pricing during conversion. If not passed, the current time will be used. If passed, we&#39;ll reference the closest historic values available for this conversion. (optional)</param>
        /// <param name="convert">Pass up to 120 comma-separated fiat or cryptocurrency symbols to convert the source amount to. (optional)</param>
        /// <param name="convertId">Optionally calculate market quotes by CoinMarketCap ID instead of symbol. This option is identical to &#x60;convert&#x60; outside of ID format. Ex: convert_id&#x3D;1,2781 would replace convert&#x3D;BTC,USD in your query. This parameter cannot be used when &#x60;convert&#x60; is used. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ToolsPriceConversionResponseModel&gt;</returns>
        Task<ToolsPriceConversionResponseModel?> GetV1ToolsPriceconversionAsync(decimal amount, string? id = null, string? symbol = null, string? time = null, string? convert = null, string? convertId = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Price Conversion
        /// </summary>
        /// <remarks>
        /// Convert an amount of one cryptocurrency or fiat currency into one or more different currencies utilizing the latest market rate for each currency. You may optionally pass a historical timestamp as &#x60;time&#x60; to convert values based on historical rates (as your API plan supports).     **Technical Notes** - Latest market rate conversions are accurate to 1 minute of specificity. Historical conversions are accurate to 1 minute of specificity outside of non-USD fiat conversions which have 5 minute specificity.  - You may reference a current list of all supported cryptocurrencies via the &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;cryptocurrency/map&lt;/a&gt; endpoint. This endpoint also returns the supported date ranges for historical conversions via the &#x60;first_historical_data&#x60; and &#x60;last_historical_data&#x60; properties.    - Conversions are supported in 93 different fiat currencies and 4 precious metals &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;as outlined here&lt;/a&gt;. Historical fiat conversions are supported as far back as 2013-04-28. - A &#x60;last_updated&#x60; timestamp is included for both your source currency and each conversion currency. This is the timestamp of the closest market rate record referenced for each currency during the conversion.    **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:** - Basic (Latest market price conversions) - Hobbyist (Latest market price conversions + 1 month historical) - Startup (Latest market price conversions + 1 month historical) - Standard (Latest market price conversions + 3 months historical) - Professional (Latest market price conversions + 12 months historical) - Enterprise (Latest market price conversions + up to 6 years historical)  **Cache / Update frequency:** Every 60 seconds for the lastest cryptocurrency and fiat currency rates.     **Plan credit use:** 1 call credit per call and 1 call credit per &#x60;convert&#x60; option beyond the first.   **CMC equivalent pages:** Our cryptocurrency conversion page at [coinmarketcap.com/converter/](https://coinmarketcap.com/converter/).  
        /// </remarks>
        /// <param name="amount">An amount of currency to convert. Example: 10.43</param>
        /// <param name="id">The CoinMarketCap currency ID of the base cryptocurrency or fiat to convert from. Example: \&quot;1\&quot; (optional)</param>
        /// <param name="symbol">Alternatively the currency symbol of the base cryptocurrency or fiat to convert from. Example: \&quot;BTC\&quot;. One \&quot;id\&quot; *or* \&quot;symbol\&quot; is required. (optional)</param>
        /// <param name="time">Optional timestamp (Unix or ISO 8601) to reference historical pricing during conversion. If not passed, the current time will be used. If passed, we&#39;ll reference the closest historic values available for this conversion. (optional)</param>
        /// <param name="convert">Pass up to 120 comma-separated fiat or cryptocurrency symbols to convert the source amount to. (optional)</param>
        /// <param name="convertId">Optionally calculate market quotes by CoinMarketCap ID instead of symbol. This option is identical to &#x60;convert&#x60; outside of ID format. Ex: convert_id&#x3D;1,2781 would replace convert&#x3D;BTC,USD in your query. This parameter cannot be used when &#x60;convert&#x60; is used. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ToolsPriceConversionResponseModel?&gt;</returns>
        Task<ToolsPriceConversionResponseModel?> GetV1ToolsPriceconversionOrDefaultAsync(decimal amount, string? id = null, string? symbol = null, string? time = null, string? convert = null, string? convertId = null, System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ToolsApi : IToolsApi
    {
        /// <summary>
        /// An event to track the health of the server. 
        /// If you store these event args, be sure to purge old event args to prevent a memory leak.
        /// </summary>
        public event ClientUtils.EventHandler<ApiResponseEventArgs>? ApiResponded;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ToolsApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ToolsApi(ILogger<ToolsApi> logger, HttpClient httpClient, 
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Price Conversion Convert an amount of one cryptocurrency or fiat currency into one or more different currencies utilizing the latest market rate for each currency. You may optionally pass a historical timestamp as &#x60;time&#x60; to convert values based on historical rates (as your API plan supports).     **Technical Notes** - Latest market rate conversions are accurate to 1 minute of specificity. Historical conversions are accurate to 1 minute of specificity outside of non-USD fiat conversions which have 5 minute specificity.  - You may reference a current list of all supported cryptocurrencies via the &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;cryptocurrency/map&lt;/a&gt; endpoint. This endpoint also returns the supported date ranges for historical conversions via the &#x60;first_historical_data&#x60; and &#x60;last_historical_data&#x60; properties.    - Conversions are supported in 93 different fiat currencies and 4 precious metals &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;as outlined here&lt;/a&gt;. Historical fiat conversions are supported as far back as 2013-04-28. - A &#x60;last_updated&#x60; timestamp is included for both your source currency and each conversion currency. This is the timestamp of the closest market rate record referenced for each currency during the conversion.    **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:** - Basic (Latest market price conversions) - Hobbyist (Latest market price conversions + 1 month historical) - Startup (Latest market price conversions + 1 month historical) - Standard (Latest market price conversions + 3 months historical) - Professional (Latest market price conversions + 12 months historical) - Enterprise (Latest market price conversions + up to 6 years historical)  **Cache / Update frequency:** Every 60 seconds for the lastest cryptocurrency and fiat currency rates.     **Plan credit use:** 1 call credit per call and 1 call credit per &#x60;convert&#x60; option beyond the first.   **CMC equivalent pages:** Our cryptocurrency conversion page at [coinmarketcap.com/converter/](https://coinmarketcap.com/converter/).  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="amount">An amount of currency to convert. Example: 10.43</param>
        /// <param name="id">The CoinMarketCap currency ID of the base cryptocurrency or fiat to convert from. Example: \&quot;1\&quot; (optional)</param>
        /// <param name="symbol">Alternatively the currency symbol of the base cryptocurrency or fiat to convert from. Example: \&quot;BTC\&quot;. One \&quot;id\&quot; *or* \&quot;symbol\&quot; is required. (optional)</param>
        /// <param name="time">Optional timestamp (Unix or ISO 8601) to reference historical pricing during conversion. If not passed, the current time will be used. If passed, we&#39;ll reference the closest historic values available for this conversion. (optional)</param>
        /// <param name="convert">Pass up to 120 comma-separated fiat or cryptocurrency symbols to convert the source amount to. (optional)</param>
        /// <param name="convertId">Optionally calculate market quotes by CoinMarketCap ID instead of symbol. This option is identical to &#x60;convert&#x60; outside of ID format. Ex: convert_id&#x3D;1,2781 would replace convert&#x3D;BTC,USD in your query. This parameter cannot be used when &#x60;convert&#x60; is used. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ToolsPriceConversionResponseModel"/>&gt;</returns>
        public async Task<ToolsPriceConversionResponseModel?> GetV1ToolsPriceconversionAsync(decimal amount, string? id = null, string? symbol = null, string? time = null, string? convert = null, string? convertId = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ToolsPriceConversionResponseModel?> result = await GetV1ToolsPriceconversionWithHttpInfoAsync(amount, id, symbol, time, convert, convertId, cancellationToken).ConfigureAwait(false);
            
            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Price Conversion Convert an amount of one cryptocurrency or fiat currency into one or more different currencies utilizing the latest market rate for each currency. You may optionally pass a historical timestamp as &#x60;time&#x60; to convert values based on historical rates (as your API plan supports).     **Technical Notes** - Latest market rate conversions are accurate to 1 minute of specificity. Historical conversions are accurate to 1 minute of specificity outside of non-USD fiat conversions which have 5 minute specificity.  - You may reference a current list of all supported cryptocurrencies via the &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;cryptocurrency/map&lt;/a&gt; endpoint. This endpoint also returns the supported date ranges for historical conversions via the &#x60;first_historical_data&#x60; and &#x60;last_historical_data&#x60; properties.    - Conversions are supported in 93 different fiat currencies and 4 precious metals &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;as outlined here&lt;/a&gt;. Historical fiat conversions are supported as far back as 2013-04-28. - A &#x60;last_updated&#x60; timestamp is included for both your source currency and each conversion currency. This is the timestamp of the closest market rate record referenced for each currency during the conversion.    **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:** - Basic (Latest market price conversions) - Hobbyist (Latest market price conversions + 1 month historical) - Startup (Latest market price conversions + 1 month historical) - Standard (Latest market price conversions + 3 months historical) - Professional (Latest market price conversions + 12 months historical) - Enterprise (Latest market price conversions + up to 6 years historical)  **Cache / Update frequency:** Every 60 seconds for the lastest cryptocurrency and fiat currency rates.     **Plan credit use:** 1 call credit per call and 1 call credit per &#x60;convert&#x60; option beyond the first.   **CMC equivalent pages:** Our cryptocurrency conversion page at [coinmarketcap.com/converter/](https://coinmarketcap.com/converter/).  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="amount">An amount of currency to convert. Example: 10.43</param>
        /// <param name="id">The CoinMarketCap currency ID of the base cryptocurrency or fiat to convert from. Example: \&quot;1\&quot; (optional)</param>
        /// <param name="symbol">Alternatively the currency symbol of the base cryptocurrency or fiat to convert from. Example: \&quot;BTC\&quot;. One \&quot;id\&quot; *or* \&quot;symbol\&quot; is required. (optional)</param>
        /// <param name="time">Optional timestamp (Unix or ISO 8601) to reference historical pricing during conversion. If not passed, the current time will be used. If passed, we&#39;ll reference the closest historic values available for this conversion. (optional)</param>
        /// <param name="convert">Pass up to 120 comma-separated fiat or cryptocurrency symbols to convert the source amount to. (optional)</param>
        /// <param name="convertId">Optionally calculate market quotes by CoinMarketCap ID instead of symbol. This option is identical to &#x60;convert&#x60; outside of ID format. Ex: convert_id&#x3D;1,2781 would replace convert&#x3D;BTC,USD in your query. This parameter cannot be used when &#x60;convert&#x60; is used. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ToolsPriceConversionResponseModel"/>&gt;</returns>
        public async Task<ToolsPriceConversionResponseModel?> GetV1ToolsPriceconversionOrDefaultAsync(decimal amount, string? id = null, string? symbol = null, string? time = null, string? convert = null, string? convertId = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ToolsPriceConversionResponseModel?>? result = null;
            try 
            {
                result = await GetV1ToolsPriceconversionWithHttpInfoAsync(amount, id, symbol, time, convert, convertId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Price Conversion Convert an amount of one cryptocurrency or fiat currency into one or more different currencies utilizing the latest market rate for each currency. You may optionally pass a historical timestamp as &#x60;time&#x60; to convert values based on historical rates (as your API plan supports).     **Technical Notes** - Latest market rate conversions are accurate to 1 minute of specificity. Historical conversions are accurate to 1 minute of specificity outside of non-USD fiat conversions which have 5 minute specificity.  - You may reference a current list of all supported cryptocurrencies via the &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;cryptocurrency/map&lt;/a&gt; endpoint. This endpoint also returns the supported date ranges for historical conversions via the &#x60;first_historical_data&#x60; and &#x60;last_historical_data&#x60; properties.    - Conversions are supported in 93 different fiat currencies and 4 precious metals &lt;a href&#x3D;\&quot;/api/v1/#section/Standards-and-Conventions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;as outlined here&lt;/a&gt;. Historical fiat conversions are supported as far back as 2013-04-28. - A &#x60;last_updated&#x60; timestamp is included for both your source currency and each conversion currency. This is the timestamp of the closest market rate record referenced for each currency during the conversion.    **This endpoint is available on the following &lt;a href&#x3D;\&quot;https://coinmarketcap.com/api/features\&quot; target&#x3D;\&quot;_blank\&quot;&gt;API plans&lt;/a&gt;:** - Basic (Latest market price conversions) - Hobbyist (Latest market price conversions + 1 month historical) - Startup (Latest market price conversions + 1 month historical) - Standard (Latest market price conversions + 3 months historical) - Professional (Latest market price conversions + 12 months historical) - Enterprise (Latest market price conversions + up to 6 years historical)  **Cache / Update frequency:** Every 60 seconds for the lastest cryptocurrency and fiat currency rates.     **Plan credit use:** 1 call credit per call and 1 call credit per &#x60;convert&#x60; option beyond the first.   **CMC equivalent pages:** Our cryptocurrency conversion page at [coinmarketcap.com/converter/](https://coinmarketcap.com/converter/).  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="amount">An amount of currency to convert. Example: 10.43</param>
        /// <param name="id">The CoinMarketCap currency ID of the base cryptocurrency or fiat to convert from. Example: \&quot;1\&quot; (optional)</param>
        /// <param name="symbol">Alternatively the currency symbol of the base cryptocurrency or fiat to convert from. Example: \&quot;BTC\&quot;. One \&quot;id\&quot; *or* \&quot;symbol\&quot; is required. (optional)</param>
        /// <param name="time">Optional timestamp (Unix or ISO 8601) to reference historical pricing during conversion. If not passed, the current time will be used. If passed, we&#39;ll reference the closest historic values available for this conversion. (optional)</param>
        /// <param name="convert">Pass up to 120 comma-separated fiat or cryptocurrency symbols to convert the source amount to. (optional)</param>
        /// <param name="convertId">Optionally calculate market quotes by CoinMarketCap ID instead of symbol. This option is identical to &#x60;convert&#x60; outside of ID format. Ex: convert_id&#x3D;1,2781 would replace convert&#x3D;BTC,USD in your query. This parameter cannot be used when &#x60;convert&#x60; is used. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ToolsPriceConversionResponseModel"/></returns>
        public async Task<ApiResponse<ToolsPriceConversionResponseModel?>> GetV1ToolsPriceconversionWithHttpInfoAsync(decimal amount, string? id = null, string? symbol = null, string? time = null, string? convert = null, string? convertId = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                if (amount == null)
                    throw new ArgumentNullException(nameof(amount));
                    
                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                
                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/v1/tools/price-conversion";

                    System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    parseQueryString["amount"] = Uri.EscapeDataString(amount.ToString()!);
                    
                    if (id != null)
                        parseQueryString["id"] = Uri.EscapeDataString(id.ToString()!);

                    if (symbol != null)
                        parseQueryString["symbol"] = Uri.EscapeDataString(symbol.ToString()!);

                    if (time != null)
                        parseQueryString["time"] = Uri.EscapeDataString(time.ToString()!);

                    if (convert != null)
                        parseQueryString["convert"] = Uri.EscapeDataString(convert.ToString()!);

                    if (convertId != null)
                        parseQueryString["convert_id"] = Uri.EscapeDataString(convertId.ToString()!);

                    uriBuilder.Query = parseQueryString.ToString();

                    List<TokenBase> tokens = new List<TokenBase>();
                    
                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    
                    tokens.Add(apiKey);
                    
                    apiKey.UseInQuery(request, uriBuilder, parseQueryString, "CMC_PRO_API_KEY");
                    
                    uriBuilder.Query = parseQueryString.ToString();

                    request.RequestUri = uriBuilder.Uri;
                    
                    string[] accepts = new string[] { 
                        "*/*" 
                    };
                    
                    string? accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                    
                    request.Method = HttpMethod.Get; 

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        if (ApiResponded != null)
                        {
                            try
                            {
                                ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/v1/tools/price-conversion"));
                            }
                            catch(Exception e)
                            {
                                Logger.LogError(e, "An error occured while invoking ApiResponded.");
                            }
                        }

                        ApiResponse<ToolsPriceConversionResponseModel?> apiResponse = new ApiResponse<ToolsPriceConversionResponseModel?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                            apiResponse.Content = Newtonsoft.Json.JsonConvert.DeserializeObject<ToolsPriceConversionResponseModel>(apiResponse.RawContent, ClientUtils.JsonSerializerSettings);
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }
    }
}
