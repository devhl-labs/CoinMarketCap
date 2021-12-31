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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using devhl.CoinMarketCap.Api;

namespace devhl.CoinMarketCap.Client
{
    /// <summary>
    /// Provides hosting configuration for devhl.CoinMarketCap
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            services.AddSingleton<IBlockchainApi, BlockchainApi>();
            services.AddSingleton<ICryptocurrencyApi, CryptocurrencyApi>();
            services.AddSingleton<IExchangeApi, ExchangeApi>();
            services.AddSingleton<IFiatApi, FiatApi>();
            services.AddSingleton<IGlobalMetricsApi, GlobalMetricsApi>();
            services.AddSingleton<IKeyApi, KeyApi>();
            services.AddSingleton<IToolsApi, ToolsApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients<TBlockchainApi, TCryptocurrencyApi, TExchangeApi, TFiatApi, TGlobalMetricsApi, TKeyApi, TToolsApi>
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
            where TBlockchainApi : class, IBlockchainApi
            where TCryptocurrencyApi : class, ICryptocurrencyApi
            where TExchangeApi : class, IExchangeApi
            where TFiatApi : class, IFiatApi
            where TGlobalMetricsApi : class, IGlobalMetricsApi
            where TKeyApi : class, IKeyApi
            where TToolsApi : class, IToolsApi
        {
            client ??= c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);
            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();
            
            builders.Add(_services.AddHttpClient<IBlockchainApi, TBlockchainApi>(client));
            builders.Add(_services.AddHttpClient<ICryptocurrencyApi, TCryptocurrencyApi>(client));
            builders.Add(_services.AddHttpClient<IExchangeApi, TExchangeApi>(client));
            builders.Add(_services.AddHttpClient<IFiatApi, TFiatApi>(client));
            builders.Add(_services.AddHttpClient<IGlobalMetricsApi, TGlobalMetricsApi>(client));
            builders.Add(_services.AddHttpClient<IKeyApi, TKeyApi>(client));
            builders.Add(_services.AddHttpClient<IToolsApi, TToolsApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients(
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            AddApiHttpClients<BlockchainApi, CryptocurrencyApi, ExchangeApi, FiatApi, GlobalMetricsApi, KeyApi, ToolsApi>(client, builder);

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<Newtonsoft.Json.JsonSerializerSettings> options)
        {
            options(Client.ClientUtils.JsonSerializerSettings);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
