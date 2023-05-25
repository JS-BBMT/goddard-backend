/*
 * Goddard.AuthorizationApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FranchiseePortal.AuthorizationWebApiClient.Client;
using FranchiseePortal.AuthorizationWebApiClient.Model;

namespace FranchiseePortal.AuthorizationWebApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizedSchoolsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <returns>List&lt;AuthorizedSchool&gt;</returns>
        List<AuthorizedSchool> ApiV1AuthorizedSchoolsGet(string user = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <returns>ApiResponse of List&lt;AuthorizedSchool&gt;</returns>
        ApiResponse<List<AuthorizedSchool>> ApiV1AuthorizedSchoolsGetWithHttpInfo(string user = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizedSchoolsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AuthorizedSchool&gt;</returns>
        System.Threading.Tasks.Task<List<AuthorizedSchool>> ApiV1AuthorizedSchoolsGetAsync(string user = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AuthorizedSchool&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AuthorizedSchool>>> ApiV1AuthorizedSchoolsGetWithHttpInfoAsync(string user = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizedSchoolsApi : IAuthorizedSchoolsApiSync, IAuthorizedSchoolsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizedSchoolsApi : IAuthorizedSchoolsApi
    {
        private FranchiseePortal.AuthorizationWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedSchoolsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizedSchoolsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedSchoolsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizedSchoolsApi(String basePath)
        {
            this.Configuration = FranchiseePortal.AuthorizationWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.AuthorizationWebApiClient.Client.GlobalConfiguration.Instance,
                new FranchiseePortal.AuthorizationWebApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FranchiseePortal.AuthorizationWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.AuthorizationWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FranchiseePortal.AuthorizationWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedSchoolsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizedSchoolsApi(FranchiseePortal.AuthorizationWebApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FranchiseePortal.AuthorizationWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.AuthorizationWebApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FranchiseePortal.AuthorizationWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.AuthorizationWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FranchiseePortal.AuthorizationWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedSchoolsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthorizedSchoolsApi(FranchiseePortal.AuthorizationWebApiClient.Client.ISynchronousClient client, FranchiseePortal.AuthorizationWebApiClient.Client.IAsynchronousClient asyncClient, FranchiseePortal.AuthorizationWebApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FranchiseePortal.AuthorizationWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FranchiseePortal.AuthorizationWebApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FranchiseePortal.AuthorizationWebApiClient.Client.ISynchronousClient Client { get; set; }

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
        public FranchiseePortal.AuthorizationWebApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FranchiseePortal.AuthorizationWebApiClient.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <returns>List&lt;AuthorizedSchool&gt;</returns>
        public List<AuthorizedSchool> ApiV1AuthorizedSchoolsGet(string user = default(string))
        {
            FranchiseePortal.AuthorizationWebApiClient.Client.ApiResponse<List<AuthorizedSchool>> localVarResponse = ApiV1AuthorizedSchoolsGetWithHttpInfo(user);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <returns>ApiResponse of List&lt;AuthorizedSchool&gt;</returns>
        public FranchiseePortal.AuthorizationWebApiClient.Client.ApiResponse<List<AuthorizedSchool>> ApiV1AuthorizedSchoolsGetWithHttpInfo(string user = default(string))
        {
            FranchiseePortal.AuthorizationWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.AuthorizationWebApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = FranchiseePortal.AuthorizationWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FranchiseePortal.AuthorizationWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (user != null)
            {
                localVarRequestOptions.QueryParameters.Add(FranchiseePortal.AuthorizationWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "user", user));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AuthorizedSchool>>("/api/v1/authorized-schools", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1AuthorizedSchoolsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AuthorizedSchool&gt;</returns>
        public async System.Threading.Tasks.Task<List<AuthorizedSchool>> ApiV1AuthorizedSchoolsGetAsync(string user = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FranchiseePortal.AuthorizationWebApiClient.Client.ApiResponse<List<AuthorizedSchool>> localVarResponse = await ApiV1AuthorizedSchoolsGetWithHttpInfoAsync(user, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="FranchiseePortal.AuthorizationWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AuthorizedSchool&gt;)</returns>
        public async System.Threading.Tasks.Task<FranchiseePortal.AuthorizationWebApiClient.Client.ApiResponse<List<AuthorizedSchool>>> ApiV1AuthorizedSchoolsGetWithHttpInfoAsync(string user = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FranchiseePortal.AuthorizationWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.AuthorizationWebApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = FranchiseePortal.AuthorizationWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FranchiseePortal.AuthorizationWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (user != null)
            {
                localVarRequestOptions.QueryParameters.Add(FranchiseePortal.AuthorizationWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "user", user));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AuthorizedSchool>>("/api/v1/authorized-schools", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1AuthorizedSchoolsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}