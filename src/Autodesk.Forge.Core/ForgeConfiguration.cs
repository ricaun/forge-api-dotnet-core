/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Autodesk.Forge.Core
{
#if NETSTANDARD
    /// <summary>
    /// Represents a key in the options for an HTTP request.
    /// </summary>
    /// <typeparam name="TValue">The type of the value of the option.</typeparam>
    public readonly struct HttpRequestOptionsKey<TValue>
    {
        /// <summary>
        /// Gets the name of the option.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Initializes a new instance of the HttpRequestOptionsKey using the supplied key name.
        /// </summary>
        /// <param name="key">Name of the HTTP request option.</param>
        public HttpRequestOptionsKey(string key)
        {
            Key = key;
        }
    }
#endif

    /// <summary>
    /// Represents the configuration settings for the Forge SDK.
    /// </summary>
    public class ForgeConfiguration
    {
        /// <summary>
        /// Represents the key for the Forge agent in the HTTP request options.
        /// </summary>
        public static readonly HttpRequestOptionsKey<string> AgentKey = new HttpRequestOptionsKey<string>("Autodesk.Forge.Agent");
        /// <summary>
        /// Represents the key for the Forge scope in the HTTP request options.
        /// </summary>
        public static readonly HttpRequestOptionsKey<string> ScopeKey = new HttpRequestOptionsKey<string>("Autodesk.Forge.Scope");
        /// <summary>
        /// Represents the key for the Forge timeout in the HTTP request options.
        /// </summary>
        public static readonly HttpRequestOptionsKey<int> TimeoutKey = new HttpRequestOptionsKey<int>("Autodesk.Forge.Timeout");

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgeConfiguration"/> class.
        /// </summary>
        public ForgeConfiguration()
        {
            this.AuthenticationAddress = new Uri("https://developer.api.autodesk.com/authentication/v2/token");
        }

        /// <summary>
        /// Gets or sets the client ID.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of Forge agent configurations.
        /// </summary>
        public IDictionary<string, ForgeAgentConfiguration> Agents { get; set; }

        /// <summary>
        /// Gets or sets the authentication address.
        /// </summary>
        public Uri AuthenticationAddress { get; set; }
    }
}
