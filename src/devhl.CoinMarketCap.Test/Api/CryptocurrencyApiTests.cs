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
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
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
    ///  Class for testing CryptocurrencyApi
    /// </summary>
    public sealed class CryptocurrencyApiTests : ApiTestsBase
    {
        private readonly ICryptocurrencyApi _instance;

        public CryptocurrencyApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ICryptocurrencyApi>();
        }


        /// <summary>
        /// Test GetV1CryptocurrencyAirdrop
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyAirdropAsyncTest()
        {
            string id = default;
            var response = await _instance.GetV1CryptocurrencyAirdropAsync(id);
            Assert.IsType<AirdropResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyAirdrops
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyAirdropsAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? status = default;
            string? id = default;
            string? slug = default;
            string? symbol = default;
            var response = await _instance.GetV1CryptocurrencyAirdropsAsync(start, limit, status, id, slug, symbol);
            Assert.IsType<AirdropsResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyCategories
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyCategoriesAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? id = default;
            string? slug = default;
            string? symbol = default;
            var response = await _instance.GetV1CryptocurrencyCategoriesAsync(start, limit, id, slug, symbol);
            Assert.IsType<CategoriesResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyCategory
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyCategoryAsyncTest()
        {
            string id = default;
            int? start = default;
            int? limit = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1CryptocurrencyCategoryAsync(id, start, limit, convert, convertId);
            Assert.IsType<CategoryResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyInfo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyInfoAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? symbol = default;
            string? address = default;
            string? aux = default;
            var response = await _instance.GetV1CryptocurrencyInfoAsync(id, slug, symbol, address, aux);
            Assert.IsType<CryptocurrenciesInfoResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyListingsHistorical
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyListingsHistoricalAsyncTest()
        {
            string date = default;
            int? start = default;
            int? limit = default;
            string? convert = default;
            string? convertId = default;
            string? sort = default;
            string? sortDir = default;
            string? cryptocurrencyType = default;
            string? aux = default;
            var response = await _instance.GetV1CryptocurrencyListingsHistoricalAsync(date, start, limit, convert, convertId, sort, sortDir, cryptocurrencyType, aux);
            Assert.IsType<CryptocurrencyListingsLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyListingsLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyListingsLatestAsyncTest()
        {
            int? start = default;
            int? limit = default;
            decimal? priceMin = default;
            decimal? priceMax = default;
            decimal? marketCapMin = default;
            decimal? marketCapMax = default;
            decimal? volume24hMin = default;
            decimal? volume24hMax = default;
            decimal? circulatingSupplyMin = default;
            decimal? circulatingSupplyMax = default;
            decimal? percentChange24hMin = default;
            decimal? percentChange24hMax = default;
            string? convert = default;
            string? convertId = default;
            string? sort = default;
            string? sortDir = default;
            string? cryptocurrencyType = default;
            string? tag = default;
            string? aux = default;
            var response = await _instance.GetV1CryptocurrencyListingsLatestAsync(start, limit, priceMin, priceMax, marketCapMin, marketCapMax, volume24hMin, volume24hMax, circulatingSupplyMin, circulatingSupplyMax, percentChange24hMin, percentChange24hMax, convert, convertId, sort, sortDir, cryptocurrencyType, tag, aux);
            Assert.IsType<CryptocurrencyListingsLatestResponseModel1>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyListingsNew
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyListingsNewAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? convert = default;
            string? convertId = default;
            string? sortDir = default;
            var response = await _instance.GetV1CryptocurrencyListingsNewAsync(start, limit, convert, convertId, sortDir);
            Assert.IsType<CryptocurrencyListingsLatestResponseModel1>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyMap
        /// </summary>
        [Fact]
        public async Task GetV1CryptocurrencyMapAsyncTest()
        {
            string? listingStatus = default;
            int? start = default;
            int? limit = default;
            string? sort = default;
            string? symbol = default;
            string? aux = default;
            var response = await _instance.GetV1CryptocurrencyMapAsync(listingStatus, start, limit, sort, symbol, aux);
            Assert.IsType<CryptocurrencyMapResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyMarketpairsLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyMarketpairsLatestAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? symbol = default;
            int? start = default;
            int? limit = default;
            string? sortDir = default;
            string? sort = default;
            string? aux = default;
            string? matchedId = default;
            string? matchedSymbol = default;
            string? category = default;
            string? feeType = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1CryptocurrencyMarketpairsLatestAsync(id, slug, symbol, start, limit, sortDir, sort, aux, matchedId, matchedSymbol, category, feeType, convert, convertId);
            Assert.IsType<CryptocurrencyMarketPairsLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyOhlcvHistorical
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyOhlcvHistoricalAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? symbol = default;
            string? timePeriod = default;
            string? timeStart = default;
            string? timeEnd = default;
            decimal? count = default;
            string? interval = default;
            string? convert = default;
            string? convertId = default;
            bool? skipInvalid = default;
            var response = await _instance.GetV1CryptocurrencyOhlcvHistoricalAsync(id, slug, symbol, timePeriod, timeStart, timeEnd, count, interval, convert, convertId, skipInvalid);
            Assert.IsType<CryptocurrencyOHLCVHistoricalResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyOhlcvLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyOhlcvLatestAsyncTest()
        {
            string? id = default;
            string? symbol = default;
            string? convert = default;
            string? convertId = default;
            bool? skipInvalid = default;
            var response = await _instance.GetV1CryptocurrencyOhlcvLatestAsync(id, symbol, convert, convertId, skipInvalid);
            Assert.IsType<CryptocurrencyOHLCVLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyPriceperformancestatsLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyPriceperformancestatsLatestAsyncTest()
        {
            string? id = default;
            string? slug = default;
            string? symbol = default;
            string? timePeriod = default;
            string? convert = default;
            string? convertId = default;
            bool? skipInvalid = default;
            var response = await _instance.GetV1CryptocurrencyPriceperformancestatsLatestAsync(id, slug, symbol, timePeriod, convert, convertId, skipInvalid);
            Assert.IsType<CryptocurrencyPricePerformanceStatsLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyQuotesHistorical
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyQuotesHistoricalAsyncTest()
        {
            string? id = default;
            string? symbol = default;
            string? timeStart = default;
            string? timeEnd = default;
            decimal? count = default;
            string? interval = default;
            string? convert = default;
            string? convertId = default;
            string? aux = default;
            bool? skipInvalid = default;
            var response = await _instance.GetV1CryptocurrencyQuotesHistoricalAsync(id, symbol, timeStart, timeEnd, count, interval, convert, convertId, aux, skipInvalid);
            Assert.IsType<CryptocurrencyQuotesHistoricalResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyQuotesLatest
        /// </summary>
        [Fact]
        public async Task GetV1CryptocurrencyQuotesLatestAsyncTest()
        {
            string? id = "1";
            string? slug = default;
            string? symbol = default;
            string? convert = default;
            string? convertId = default;
            string? aux = default;
            bool? skipInvalid = default;
            var response = await _instance.GetV1CryptocurrencyQuotesLatestAsync(id, slug, symbol, convert, convertId, aux, skipInvalid);
            Assert.IsType<CryptocurrencyQuotesLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyTrendingGainerslosers
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyTrendingGainerslosersAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? timePeriod = default;
            string? convert = default;
            string? convertId = default;
            string? sort = default;
            string? sortDir = default;
            var response = await _instance.GetV1CryptocurrencyTrendingGainerslosersAsync(start, limit, timePeriod, convert, convertId, sort, sortDir);
            Assert.IsType<CryptocurrencyTrendingGainersLosersResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyTrendingLatest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyTrendingLatestAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? timePeriod = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1CryptocurrencyTrendingLatestAsync(start, limit, timePeriod, convert, convertId);
            Assert.IsType<CryptocurrencyTrendingLatestResponseModel>(response);
        }

        /// <summary>
        /// Test GetV1CryptocurrencyTrendingMostvisited
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetV1CryptocurrencyTrendingMostvisitedAsyncTest()
        {
            int? start = default;
            int? limit = default;
            string? timePeriod = default;
            string? convert = default;
            string? convertId = default;
            var response = await _instance.GetV1CryptocurrencyTrendingMostvisitedAsync(start, limit, timePeriod, convert, convertId);
            Assert.IsType<CryptocurrencyTrendingMostVisitedResponseModel>(response);
        }
    }
}
