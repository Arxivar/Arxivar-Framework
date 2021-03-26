/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Management.Client;
using IO.Swagger.Management.Model;

namespace IO.Swagger.Management.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFoldersManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This method allows to find folders by their name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>List&lt;FolderDTO&gt;</returns>
        List<FolderDTO> FoldersManagementFindByName (string name);

        /// <summary>
        /// This method allows to find folders by their name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>ApiResponse of List&lt;FolderDTO&gt;</returns>
        ApiResponse<List<FolderDTO>> FoldersManagementFindByNameWithHttpInfo (string name);
        /// <summary>
        /// This method return the folders contained in specified parent folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>List&lt;FolderDTO&gt;</returns>
        List<FolderDTO> FoldersManagementGetByParentId (int? parentId);

        /// <summary>
        /// This method return the folders contained in specified parent folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>ApiResponse of List&lt;FolderDTO&gt;</returns>
        ApiResponse<List<FolderDTO>> FoldersManagementGetByParentIdWithHttpInfo (int? parentId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This method allows to find folders by their name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>Task of List&lt;FolderDTO&gt;</returns>
        System.Threading.Tasks.Task<List<FolderDTO>> FoldersManagementFindByNameAsync (string name);

        /// <summary>
        /// This method allows to find folders by their name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>Task of ApiResponse (List&lt;FolderDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FolderDTO>>> FoldersManagementFindByNameAsyncWithHttpInfo (string name);
        /// <summary>
        /// This method return the folders contained in specified parent folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>Task of List&lt;FolderDTO&gt;</returns>
        System.Threading.Tasks.Task<List<FolderDTO>> FoldersManagementGetByParentIdAsync (int? parentId);

        /// <summary>
        /// This method return the folders contained in specified parent folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>Task of ApiResponse (List&lt;FolderDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FolderDTO>>> FoldersManagementGetByParentIdAsyncWithHttpInfo (int? parentId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FoldersManagementApi : IFoldersManagementApi
    {
        private IO.Swagger.Management.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FoldersManagementApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Management.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Management.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FoldersManagementApi(IO.Swagger.Management.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Management.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Management.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Management.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Management.Client.ExceptionFactory ExceptionFactory
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
        /// This method allows to find folders by their name 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>List&lt;FolderDTO&gt;</returns>
        public List<FolderDTO> FoldersManagementFindByName (string name)
        {
             ApiResponse<List<FolderDTO>> localVarResponse = FoldersManagementFindByNameWithHttpInfo(name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This method allows to find folders by their name 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>ApiResponse of List&lt;FolderDTO&gt;</returns>
        public ApiResponse< List<FolderDTO> > FoldersManagementFindByNameWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling FoldersManagementApi->FoldersManagementFindByName");

            var localVarPath = "/api/management/Folders/find";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FoldersManagementFindByName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FolderDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FolderDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FolderDTO>)));
        }

        /// <summary>
        /// This method allows to find folders by their name 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>Task of List&lt;FolderDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<FolderDTO>> FoldersManagementFindByNameAsync (string name)
        {
             ApiResponse<List<FolderDTO>> localVarResponse = await FoldersManagementFindByNameAsyncWithHttpInfo(name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This method allows to find folders by their name 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name to search</param>
        /// <returns>Task of ApiResponse (List&lt;FolderDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FolderDTO>>> FoldersManagementFindByNameAsyncWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling FoldersManagementApi->FoldersManagementFindByName");

            var localVarPath = "/api/management/Folders/find";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FoldersManagementFindByName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FolderDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FolderDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FolderDTO>)));
        }

        /// <summary>
        /// This method return the folders contained in specified parent folder 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>List&lt;FolderDTO&gt;</returns>
        public List<FolderDTO> FoldersManagementGetByParentId (int? parentId)
        {
             ApiResponse<List<FolderDTO>> localVarResponse = FoldersManagementGetByParentIdWithHttpInfo(parentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This method return the folders contained in specified parent folder 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>ApiResponse of List&lt;FolderDTO&gt;</returns>
        public ApiResponse< List<FolderDTO> > FoldersManagementGetByParentIdWithHttpInfo (int? parentId)
        {
            // verify the required parameter 'parentId' is set
            if (parentId == null)
                throw new ApiException(400, "Missing required parameter 'parentId' when calling FoldersManagementApi->FoldersManagementGetByParentId");

            var localVarPath = "/api/management/Folders/parent/{parentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (parentId != null) localVarPathParams.Add("parentId", this.Configuration.ApiClient.ParameterToString(parentId)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FoldersManagementGetByParentId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FolderDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FolderDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FolderDTO>)));
        }

        /// <summary>
        /// This method return the folders contained in specified parent folder 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>Task of List&lt;FolderDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<FolderDTO>> FoldersManagementGetByParentIdAsync (int? parentId)
        {
             ApiResponse<List<FolderDTO>> localVarResponse = await FoldersManagementGetByParentIdAsyncWithHttpInfo(parentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This method return the folders contained in specified parent folder 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentId">The identifier of the parent folder</param>
        /// <returns>Task of ApiResponse (List&lt;FolderDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FolderDTO>>> FoldersManagementGetByParentIdAsyncWithHttpInfo (int? parentId)
        {
            // verify the required parameter 'parentId' is set
            if (parentId == null)
                throw new ApiException(400, "Missing required parameter 'parentId' when calling FoldersManagementApi->FoldersManagementGetByParentId");

            var localVarPath = "/api/management/Folders/parent/{parentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (parentId != null) localVarPathParams.Add("parentId", this.Configuration.ApiClient.ParameterToString(parentId)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FoldersManagementGetByParentId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FolderDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FolderDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FolderDTO>)));
        }

    }
}