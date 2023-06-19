/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.1
 * Contact: omnicoresupport@korewireless.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using OmniCore.Client;
using OmniCore.Model;

namespace OmniCore.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetricsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get metrics
        /// </remarks>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Metrics</returns>
        Metrics GetMetrics(string subscriptionId, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get metrics
        /// </remarks>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Metrics</returns>
        ApiResponse<Metrics> GetMetricsWithHttpInfo(string subscriptionId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetricsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get metrics
        /// </remarks>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Metrics</returns>
        System.Threading.Tasks.Task<Metrics> GetMetricsAsync(string subscriptionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get metrics
        /// </remarks>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Metrics)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metrics>> GetMetricsWithHttpInfoAsync(string subscriptionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetricsApi : IMetricsApiSync, IMetricsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetricsApi : IMetricsApi
    {
        private OmniCore.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetricsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetricsApi(string basePath)
        {
            this.Configuration = OmniCore.Client.Configuration.MergeConfigurations(
                OmniCore.Client.GlobalConfiguration.Instance,
                new OmniCore.Client.Configuration { BasePath = basePath }
            );
            this.Client = new OmniCore.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new OmniCore.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = OmniCore.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetricsApi(OmniCore.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = OmniCore.Client.Configuration.MergeConfigurations(
                OmniCore.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new OmniCore.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new OmniCore.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = OmniCore.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MetricsApi(OmniCore.Client.ISynchronousClient client, OmniCore.Client.IAsynchronousClient asyncClient, OmniCore.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = OmniCore.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public OmniCore.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public OmniCore.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public OmniCore.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public OmniCore.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  get metrics
        /// </summary>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Metrics</returns>
        public Metrics GetMetrics(string subscriptionId, int operationIndex = 0)
        {
            OmniCore.Client.ApiResponse<Metrics> localVarResponse = GetMetricsWithHttpInfo(subscriptionId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  get metrics
        /// </summary>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Metrics</returns>
        public OmniCore.Client.ApiResponse<Metrics> GetMetricsWithHttpInfo(string subscriptionId, int operationIndex = 0)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new OmniCore.Client.ApiException(400, "Missing required parameter 'subscriptionId' when calling MetricsApi->GetMetrics");
            }

            OmniCore.Client.RequestOptions localVarRequestOptions = new OmniCore.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = OmniCore.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = OmniCore.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("subscriptionId", OmniCore.Client.ClientUtils.ParameterToString(subscriptionId)); // path parameter

            localVarRequestOptions.Operation = "MetricsApi.GetMetrics";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Metrics>("/subscriptions/{subscriptionId}/metrics", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMetrics", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  get metrics
        /// </summary>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Metrics</returns>
        public async System.Threading.Tasks.Task<Metrics> GetMetricsAsync(string subscriptionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            OmniCore.Client.ApiResponse<Metrics> localVarResponse = await GetMetricsWithHttpInfoAsync(subscriptionId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  get metrics
        /// </summary>
        /// <exception cref="OmniCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Subscription ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Metrics)</returns>
        public async System.Threading.Tasks.Task<OmniCore.Client.ApiResponse<Metrics>> GetMetricsWithHttpInfoAsync(string subscriptionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new OmniCore.Client.ApiException(400, "Missing required parameter 'subscriptionId' when calling MetricsApi->GetMetrics");
            }


            OmniCore.Client.RequestOptions localVarRequestOptions = new OmniCore.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = OmniCore.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = OmniCore.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("subscriptionId", OmniCore.Client.ClientUtils.ParameterToString(subscriptionId)); // path parameter

            localVarRequestOptions.Operation = "MetricsApi.GetMetrics";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Metrics>("/subscriptions/{subscriptionId}/metrics", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMetrics", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
