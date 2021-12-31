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
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using devhl.CoinMarketCap.Client;
using devhl.CoinMarketCap.Api;
using Xunit;

namespace devhl.CoinMarketCap.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient = 
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureCmc((context, options) =>
            {
                ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken);
                
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureCmc((context, options) =>
            {
                ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken);
                
                options.AddCmcHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddCmc(options =>
                {
                    ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken);
                    
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddCmc(options =>
                {
                    ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken);
                    
                    options.AddCmcHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var blockchainApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IBlockchainApi>();
            Assert.True(blockchainApi.HttpClient.BaseAddress != null);
            
            var cryptocurrencyApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ICryptocurrencyApi>();
            Assert.True(cryptocurrencyApi.HttpClient.BaseAddress != null);
            
            var exchangeApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IExchangeApi>();
            Assert.True(exchangeApi.HttpClient.BaseAddress != null);
            
            var fiatApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IFiatApi>();
            Assert.True(fiatApi.HttpClient.BaseAddress != null);
            
            var globalMetricsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IGlobalMetricsApi>();
            Assert.True(globalMetricsApi.HttpClient.BaseAddress != null);
            
            var keyApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IKeyApi>();
            Assert.True(keyApi.HttpClient.BaseAddress != null);
            
            var toolsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IToolsApi>();
            Assert.True(toolsApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var blockchainApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IBlockchainApi>();
            Assert.True(blockchainApi.HttpClient.BaseAddress != null);
            
            var cryptocurrencyApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ICryptocurrencyApi>();
            Assert.True(cryptocurrencyApi.HttpClient.BaseAddress != null);
            
            var exchangeApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IExchangeApi>();
            Assert.True(exchangeApi.HttpClient.BaseAddress != null);
            
            var fiatApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IFiatApi>();
            Assert.True(fiatApi.HttpClient.BaseAddress != null);
            
            var globalMetricsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IGlobalMetricsApi>();
            Assert.True(globalMetricsApi.HttpClient.BaseAddress != null);
            
            var keyApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IKeyApi>();
            Assert.True(keyApi.HttpClient.BaseAddress != null);
            
            var toolsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IToolsApi>();
            Assert.True(toolsApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var blockchainApi = _hostUsingAddWithAClient.Services.GetRequiredService<IBlockchainApi>();
            Assert.True(blockchainApi.HttpClient.BaseAddress != null);
            
            var cryptocurrencyApi = _hostUsingAddWithAClient.Services.GetRequiredService<ICryptocurrencyApi>();
            Assert.True(cryptocurrencyApi.HttpClient.BaseAddress != null);
            
            var exchangeApi = _hostUsingAddWithAClient.Services.GetRequiredService<IExchangeApi>();
            Assert.True(exchangeApi.HttpClient.BaseAddress != null);
            
            var fiatApi = _hostUsingAddWithAClient.Services.GetRequiredService<IFiatApi>();
            Assert.True(fiatApi.HttpClient.BaseAddress != null);
            
            var globalMetricsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IGlobalMetricsApi>();
            Assert.True(globalMetricsApi.HttpClient.BaseAddress != null);
            
            var keyApi = _hostUsingAddWithAClient.Services.GetRequiredService<IKeyApi>();
            Assert.True(keyApi.HttpClient.BaseAddress != null);
            
            var toolsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IToolsApi>();
            Assert.True(toolsApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var blockchainApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IBlockchainApi>();
            Assert.True(blockchainApi.HttpClient.BaseAddress != null);
            
            var cryptocurrencyApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ICryptocurrencyApi>();
            Assert.True(cryptocurrencyApi.HttpClient.BaseAddress != null);
            
            var exchangeApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IExchangeApi>();
            Assert.True(exchangeApi.HttpClient.BaseAddress != null);
            
            var fiatApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IFiatApi>();
            Assert.True(fiatApi.HttpClient.BaseAddress != null);
            
            var globalMetricsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IGlobalMetricsApi>();
            Assert.True(globalMetricsApi.HttpClient.BaseAddress != null);
            
            var keyApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IKeyApi>();
            Assert.True(keyApi.HttpClient.BaseAddress != null);
            
            var toolsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IToolsApi>();
            Assert.True(toolsApi.HttpClient.BaseAddress != null);
        }
    }
}
