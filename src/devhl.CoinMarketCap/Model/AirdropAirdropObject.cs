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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = devhl.CoinMarketCap.Client.OpenAPIDateConverter;

namespace devhl.CoinMarketCap.Model
{
    /// <summary>
    /// A results object for the airdrop requested.
    /// </summary>
    [DataContract(Name = "Airdrop - Airdrop object")]
    public partial class AirdropAirdropObject : IEquatable<AirdropAirdropObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AirdropAirdropObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirdropAirdropObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirdropAirdropObject" /> class.
        /// </summary>
        /// <param name="id">The unique ID of the airdrop (required).</param>
        /// <param name="projectName">The project name.</param>
        /// <param name="description">The description of the airdrop..</param>
        /// <param name="status">The current status of the airdrop..</param>
        /// <param name="coin">coin.</param>
        /// <param name="startDate">Timestamp (ISO 8601) of when this cryptocurrency was added to CoinMarketCap. (required).</param>
        /// <param name="endDate">Timestamp (ISO 8601) of when this cryptocurrency was added to CoinMarketCap. (required).</param>
        /// <param name="totalPrize">totalPrize.</param>
        /// <param name="winnerCount">winnerCount.</param>
        public AirdropAirdropObject(string id = default(string), string projectName = default(string), string description = default(string), string status = default(string), Coin coin = default(Coin), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), int totalPrize = default(int), int winnerCount = default(int))
        {
            this.Id = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ProjectName = projectName;
            this.Description = description;
            this.Status = status;
            this.Coin = coin;
            this.TotalPrize = totalPrize;
            this.WinnerCount = winnerCount;
        }

        /// <summary>
        /// The unique ID of the airdrop
        /// </summary>
        /// <value>The unique ID of the airdrop</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The project name
        /// </summary>
        /// <value>The project name</value>
        [DataMember(Name = "project_name", EmitDefaultValue = false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The description of the airdrop.
        /// </summary>
        /// <value>The description of the airdrop.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The current status of the airdrop.
        /// </summary>
        /// <value>The current status of the airdrop.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Coin
        /// </summary>
        [DataMember(Name = "coin", EmitDefaultValue = false)]
        public Coin Coin { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when this cryptocurrency was added to CoinMarketCap.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when this cryptocurrency was added to CoinMarketCap.</value>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when this cryptocurrency was added to CoinMarketCap.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when this cryptocurrency was added to CoinMarketCap.</value>
        [DataMember(Name = "end_date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalPrize
        /// </summary>
        [DataMember(Name = "total_prize", EmitDefaultValue = false)]
        public int TotalPrize { get; set; }

        /// <summary>
        /// Gets or Sets WinnerCount
        /// </summary>
        [DataMember(Name = "winner_count", EmitDefaultValue = false)]
        public int WinnerCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirdropAirdropObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Coin: ").Append(Coin).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalPrize: ").Append(TotalPrize).Append("\n");
            sb.Append("  WinnerCount: ").Append(WinnerCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AirdropAirdropObject);
        }

        /// <summary>
        /// Returns true if AirdropAirdropObject instances are equal
        /// </summary>
        /// <param name="input">Instance of AirdropAirdropObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirdropAirdropObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Coin == input.Coin ||
                    (this.Coin != null &&
                    this.Coin.Equals(input.Coin))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.TotalPrize == input.TotalPrize ||
                    this.TotalPrize.Equals(input.TotalPrize)
                ) && 
                (
                    this.WinnerCount == input.WinnerCount ||
                    this.WinnerCount.Equals(input.WinnerCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Coin != null)
                    hashCode = hashCode * 59 + this.Coin.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.TotalPrize.GetHashCode();
                hashCode = hashCode * 59 + this.WinnerCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
