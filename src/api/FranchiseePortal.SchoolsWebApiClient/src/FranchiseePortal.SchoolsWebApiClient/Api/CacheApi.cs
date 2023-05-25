/*
 * Goddard iPaaS Schools API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FranchiseePortal.SchoolsWebApiClient.Client;

namespace FranchiseePortal.SchoolsWebApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICacheApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void ApiCacheDelete();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiCacheDeleteWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICacheApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiCacheDeleteAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiCacheDeleteWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICacheApi : ICacheApiSync, ICacheApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CacheApi : ICacheApi
    {
        private FranchiseePortal.SchoolsWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CacheApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CacheApi(String basePath)
        {
            this.Configuration = FranchiseePortal.SchoolsWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.SchoolsWebApiClient.Client.GlobalConfiguration.Instance,
                new FranchiseePortal.SchoolsWebApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FranchiseePortal.SchoolsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.SchoolsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FranchiseePortal.SchoolsWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CacheApi(FranchiseePortal.SchoolsWebApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FranchiseePortal.SchoolsWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.SchoolsWebApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FranchiseePortal.SchoolsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.SchoolsWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FranchiseePortal.SchoolsWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CacheApi(FranchiseePortal.SchoolsWebApiClient.Client.ISynchronousClient client, FranchiseePortal.SchoolsWebApiClient.Client.IAsynchronousClient asyncClient, FranchiseePortal.SchoolsWebApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FranchiseePortal.SchoolsWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FranchiseePortal.SchoolsWebApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FranchiseePortal.SchoolsWebApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FranchiseePortal.SchoolsWebApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FranchiseePortal.SchoolsWebApiClient.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void ApiCacheDelete()
        {
            ApiCacheDeleteWithHttpInfo();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public FranchiseePortal.SchoolsWebApiClient.Client.ApiResponse<Object> ApiCacheDeleteWithHttpInfo()
        {
            FranchiseePortal.SchoolsWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.SchoolsWebApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = FranchiseePortal.SchoolsWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FranchiseePortal.SchoolsWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("Ocp-Apim-Subscription-Key", this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/cache", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiCacheDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiCacheDeleteAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiCacheDeleteWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.SchoolsWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<FranchiseePortal.SchoolsWebApiClient.Client.ApiResponse<Object>> ApiCacheDeleteWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FranchiseePortal.SchoolsWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.SchoolsWebApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };


            var localVarContentType = FranchiseePortal.SchoolsWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FranchiseePortal.SchoolsWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("Ocp-Apim-Subscription-Key", this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/cache", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiCacheDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
