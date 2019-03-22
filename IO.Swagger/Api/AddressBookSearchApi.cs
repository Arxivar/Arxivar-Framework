/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressBookSearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns a searchDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AddressBookSearchConcreteDTO</returns>
        AddressBookSearchConcreteDTO AddressBookSearchGetSearch ();

        /// <summary>
        /// This call returns a searchDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AddressBookSearchConcreteDTO</returns>
        ApiResponse<AddressBookSearchConcreteDTO> AddressBookSearchGetSearchWithHttpInfo ();
        /// <summary>
        /// This call returns a selectDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SelectDTO</returns>
        SelectDTO AddressBookSearchGetSelect ();

        /// <summary>
        /// This call returns a selectDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SelectDTO</returns>
        ApiResponse<SelectDTO> AddressBookSearchGetSelectWithHttpInfo ();
        /// <summary>
        /// This call searches in address book with search and select DTO system
        /// </summary>
        /// <remarks>
        /// This method is deprecated. Use api/v2/AddressBookSearches
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>List&lt;RowSearchResult&gt;</returns>
        List<RowSearchResult> AddressBookSearchPostSearch (AddressBookSearchConcreteCriteriaDTO searchCriteria);

        /// <summary>
        /// This call searches in address book with search and select DTO system
        /// </summary>
        /// <remarks>
        /// This method is deprecated. Use api/v2/AddressBookSearches
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>ApiResponse of List&lt;RowSearchResult&gt;</returns>
        ApiResponse<List<RowSearchResult>> AddressBookSearchPostSearchWithHttpInfo (AddressBookSearchConcreteCriteriaDTO searchCriteria);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns a searchDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AddressBookSearchConcreteDTO</returns>
        System.Threading.Tasks.Task<AddressBookSearchConcreteDTO> AddressBookSearchGetSearchAsync ();

        /// <summary>
        /// This call returns a searchDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AddressBookSearchConcreteDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressBookSearchConcreteDTO>> AddressBookSearchGetSearchAsyncWithHttpInfo ();
        /// <summary>
        /// This call returns a selectDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SelectDTO</returns>
        System.Threading.Tasks.Task<SelectDTO> AddressBookSearchGetSelectAsync ();

        /// <summary>
        /// This call returns a selectDTO object for search in addressbook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SelectDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<SelectDTO>> AddressBookSearchGetSelectAsyncWithHttpInfo ();
        /// <summary>
        /// This call searches in address book with search and select DTO system
        /// </summary>
        /// <remarks>
        /// This method is deprecated. Use api/v2/AddressBookSearches
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>Task of List&lt;RowSearchResult&gt;</returns>
        System.Threading.Tasks.Task<List<RowSearchResult>> AddressBookSearchPostSearchAsync (AddressBookSearchConcreteCriteriaDTO searchCriteria);

        /// <summary>
        /// This call searches in address book with search and select DTO system
        /// </summary>
        /// <remarks>
        /// This method is deprecated. Use api/v2/AddressBookSearches
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>Task of ApiResponse (List&lt;RowSearchResult&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RowSearchResult>>> AddressBookSearchPostSearchAsyncWithHttpInfo (AddressBookSearchConcreteCriteriaDTO searchCriteria);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressBookSearchApi : IAddressBookSearchApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookSearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressBookSearchApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookSearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressBookSearchApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This call returns a searchDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AddressBookSearchConcreteDTO</returns>
        public AddressBookSearchConcreteDTO AddressBookSearchGetSearch ()
        {
             ApiResponse<AddressBookSearchConcreteDTO> localVarResponse = AddressBookSearchGetSearchWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns a searchDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AddressBookSearchConcreteDTO</returns>
        public ApiResponse< AddressBookSearchConcreteDTO > AddressBookSearchGetSearchWithHttpInfo ()
        {

            var localVarPath = "/api/AddressBookSearches/Search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressBookSearchGetSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressBookSearchConcreteDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressBookSearchConcreteDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressBookSearchConcreteDTO)));
        }

        /// <summary>
        /// This call returns a searchDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AddressBookSearchConcreteDTO</returns>
        public async System.Threading.Tasks.Task<AddressBookSearchConcreteDTO> AddressBookSearchGetSearchAsync ()
        {
             ApiResponse<AddressBookSearchConcreteDTO> localVarResponse = await AddressBookSearchGetSearchAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns a searchDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AddressBookSearchConcreteDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressBookSearchConcreteDTO>> AddressBookSearchGetSearchAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/AddressBookSearches/Search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressBookSearchGetSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressBookSearchConcreteDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressBookSearchConcreteDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressBookSearchConcreteDTO)));
        }

        /// <summary>
        /// This call returns a selectDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SelectDTO</returns>
        public SelectDTO AddressBookSearchGetSelect ()
        {
             ApiResponse<SelectDTO> localVarResponse = AddressBookSearchGetSelectWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns a selectDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SelectDTO</returns>
        public ApiResponse< SelectDTO > AddressBookSearchGetSelectWithHttpInfo ()
        {

            var localVarPath = "/api/AddressBookSearches/Select";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressBookSearchGetSelect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SelectDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SelectDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelectDTO)));
        }

        /// <summary>
        /// This call returns a selectDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SelectDTO</returns>
        public async System.Threading.Tasks.Task<SelectDTO> AddressBookSearchGetSelectAsync ()
        {
             ApiResponse<SelectDTO> localVarResponse = await AddressBookSearchGetSelectAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns a selectDTO object for search in addressbook 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SelectDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SelectDTO>> AddressBookSearchGetSelectAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/AddressBookSearches/Select";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressBookSearchGetSelect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SelectDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SelectDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelectDTO)));
        }

        /// <summary>
        /// This call searches in address book with search and select DTO system This method is deprecated. Use api/v2/AddressBookSearches
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>List&lt;RowSearchResult&gt;</returns>
        public List<RowSearchResult> AddressBookSearchPostSearch (AddressBookSearchConcreteCriteriaDTO searchCriteria)
        {
             ApiResponse<List<RowSearchResult>> localVarResponse = AddressBookSearchPostSearchWithHttpInfo(searchCriteria);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call searches in address book with search and select DTO system This method is deprecated. Use api/v2/AddressBookSearches
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>ApiResponse of List&lt;RowSearchResult&gt;</returns>
        public ApiResponse< List<RowSearchResult> > AddressBookSearchPostSearchWithHttpInfo (AddressBookSearchConcreteCriteriaDTO searchCriteria)
        {
            // verify the required parameter 'searchCriteria' is set
            if (searchCriteria == null)
                throw new ApiException(400, "Missing required parameter 'searchCriteria' when calling AddressBookSearchApi->AddressBookSearchPostSearch");

            var localVarPath = "/api/AddressBookSearches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchCriteria != null && searchCriteria.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(searchCriteria); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchCriteria; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressBookSearchPostSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RowSearchResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RowSearchResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RowSearchResult>)));
        }

        /// <summary>
        /// This call searches in address book with search and select DTO system This method is deprecated. Use api/v2/AddressBookSearches
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>Task of List&lt;RowSearchResult&gt;</returns>
        public async System.Threading.Tasks.Task<List<RowSearchResult>> AddressBookSearchPostSearchAsync (AddressBookSearchConcreteCriteriaDTO searchCriteria)
        {
             ApiResponse<List<RowSearchResult>> localVarResponse = await AddressBookSearchPostSearchAsyncWithHttpInfo(searchCriteria);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call searches in address book with search and select DTO system This method is deprecated. Use api/v2/AddressBookSearches
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchCriteria"></param>
        /// <returns>Task of ApiResponse (List&lt;RowSearchResult&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RowSearchResult>>> AddressBookSearchPostSearchAsyncWithHttpInfo (AddressBookSearchConcreteCriteriaDTO searchCriteria)
        {
            // verify the required parameter 'searchCriteria' is set
            if (searchCriteria == null)
                throw new ApiException(400, "Missing required parameter 'searchCriteria' when calling AddressBookSearchApi->AddressBookSearchPostSearch");

            var localVarPath = "/api/AddressBookSearches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchCriteria != null && searchCriteria.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(searchCriteria); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchCriteria; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressBookSearchPostSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RowSearchResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RowSearchResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RowSearchResult>)));
        }

    }
}
