/*
 * CoinMarketCap Cryptocurrency API Documentation
 *
 * # Introduction The CoinMarketCap API is a suite of high-performance RESTful JSON endpoints that are specifically designed to meet the mission-critical demands of application developers, data scientists, and enterprise business platforms.  This API reference includes all technical documentation developers need to integrate third-party applications and platforms. Additional answers to common questions can be found in the [CoinMarketCap API FAQ](https://coinmarketcap.com/api/faq).  # Quick Start Guide  For developers eager to hit the ground running with the CoinMarketCap API here are a few quick steps to make your first call with the API.  1. **Sign up for a free Developer Portal account.** You can sign up at [pro.coinmarketcap.com](https://pro.coinmarketcap.com) - This is our live production environment with the latest market data. Select the free `Basic` plan if it meets your needs or upgrade to a paid tier. 2. **Copy your API Key.** Once you sign up you'll land on your Developer Portal account dashboard. Copy your API from the `API Key` box in the top left panel. 3. **Make a test call using your key.** You may use the code examples provided below to make a test call with your programming language of choice. This example [fetches all active cryptocurrencies by market cap and return market values in USD](https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?start=1&limit=5000&convert=USD).     *Be sure to replace the API Key in sample code with your own and use API domain `pro-api.coinmarketcap.com` or use the test API Key `b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c` for `sandbox-api.coinmarketcap.com` testing with our sandbox.coinmarketcap.com environment. Please note that our sandbox api has mock data and should not be used in your application.*
 *
 * The version of the OpenAPI document: 1.26.0
 * Contact: api@coinmarketcap.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using devhl.CoinMarketCap.Api;
using devhl.CoinMarketCap.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
# 2. If you want to mock the server's response, use method AddApiHttpClients
     and provide your mock classes.

* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace devhl.CoinMarketCap.Test.Api
{
    /// <summary>
    ///  Class for testing ExchangeApi
    /// </summary>
    public sealed class ExchangeApiTests : ApiTestsBase
    {
        private readonly IExchangeApi _instance;

        public ExchangeApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IExchangeApi>();
        }


        /// <summary>
        /// Test GetV1ExchangeInfo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1ExchangeInfoAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? aux = default;
            var response = await _instance.GetV1ExchangeInfoAsync(id, slug, aux);
            Assert.IsType<ExchangesInfoResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1ExchangeListingsLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1ExchangeListingsLatestAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? sort = default;
            string? sortDir = default;
            string? marketType = default;
            string? category = default;
            string? aux = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1ExchangeListingsLatestAsync(start, limit, sort, sortDir, marketType, category, aux, convert, convertId);
            Assert.IsType<ExchangeListingsLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1ExchangeMap
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1ExchangeMapAsyncTest()
        {
            string? listingStatus = default;
            string? slug = default;
            int? start = default;
            int? limit = default;
            string? sort = default;
            string? aux = default;
            string? cryptoId = default;
            var response = await _instance.GetV1ExchangeMapAsync(listingStatus, slug, start, limit, sort, aux, cryptoId);
            Assert.IsType<ExchangeMapResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1ExchangeMarketpairsLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1ExchangeMarketpairsLatestAsyncTest()
        {
            string? id = default;
            string? slug = default;
            int? start = default;
            int? limit = default;
            string? aux = default;
            string? matchedId = default;
            string? matchedSymbol = default;
            string? category = default;
            string? feeType = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1ExchangeMarketpairsLatestAsync(id, slug, start, limit, aux, matchedId, matchedSymbol, category, feeType, convert, convertId);
            Assert.IsType<ExchangeMarketPairsLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1ExchangeQuotesHistorical
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1ExchangeQuotesHistoricalAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? timeStart = default;
            string? timeEnd = default;
            decimal? count = default;
            string? interval = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1ExchangeQuotesHistoricalAsync(id, slug, timeStart, timeEnd, count, interval, convert, convertId);
            Assert.IsType<ExchangeHistoricalQuotesResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1ExchangeQuotesLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1ExchangeQuotesLatestAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? convert = default;
            string? convertId = default;
            string? aux = default;
            var response = await _instance.GetV1ExchangeQuotesLatestAsync(id, slug, convert, convertId, aux);
            Assert.IsType<ExchangeQuotesLatestResponseModel>(response);
        }
    }
}
