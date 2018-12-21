using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.Pier.Client;
using Conductor.Pier.Model;

namespace Conductor.Pier.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBinApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Bin list
        /// </summary>
        /// <remarks>
        /// Bin list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Bin id (optional)</param>
        /// <param name="proximaConta">Bin next account (optional)</param>
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param>
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param>
        /// <param name="serviceCode">Bin service code (optional)</param>
        /// <returns>PageBinResponse</returns>
        PageBinResponse ListarBin (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null);
  
        /// <summary>
        /// Bin list
        /// </summary>
        /// <remarks>
        /// Bin list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Bin id (optional)</param>
        /// <param name="proximaConta">Bin next account (optional)</param>
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param>
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param>
        /// <param name="serviceCode">Bin service code (optional)</param>
        /// <returns>ApiResponse of PageBinResponse</returns>
        ApiResponse<PageBinResponse> ListarBinWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Bin list
        /// </summary>
        /// <remarks>
        /// Bin list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Bin id (optional)</param>
        /// <param name="proximaConta">Bin next account (optional)</param>
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param>
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param>
        /// <param name="serviceCode">Bin service code (optional)</param>
        /// <returns>Task of PageBinResponse</returns>
        System.Threading.Tasks.Task<PageBinResponse> ListarBinAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null);

        /// <summary>
        /// Bin list
        /// </summary>
        /// <remarks>
        /// Bin list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Bin id (optional)</param>
        /// <param name="proximaConta">Bin next account (optional)</param>
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param>
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param>
        /// <param name="serviceCode">Bin service code (optional)</param>
        /// <returns>Task of ApiResponse (PageBinResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBinResponse>> ListarBinAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BinApi : IBinApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BinApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BinApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BinApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Bin list Bin list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Bin id (optional)</param> 
        /// <param name="proximaConta">Bin next account (optional)</param> 
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param> 
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param> 
        /// <param name="serviceCode">Bin service code (optional)</param> 
        /// <returns>PageBinResponse</returns>
        public PageBinResponse ListarBin (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null)
        {
             ApiResponse<PageBinResponse> localVarResponse = ListarBinWithHttpInfo(sort, page, limit, id, proximaConta, flagCartaoVirtual, flagProvisorio, serviceCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bin list Bin list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Bin id (optional)</param> 
        /// <param name="proximaConta">Bin next account (optional)</param> 
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param> 
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param> 
        /// <param name="serviceCode">Bin service code (optional)</param> 
        /// <returns>ApiResponse of PageBinResponse</returns>
        public ApiResponse< PageBinResponse > ListarBinWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null)
        {
            
    
            var localVarPath = "/api/bins";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (proximaConta != null) localVarQueryParams.Add("proximaConta", Configuration.ApiClient.ParameterToString(proximaConta)); // query parameter
            if (flagCartaoVirtual != null) localVarQueryParams.Add("flagCartaoVirtual", Configuration.ApiClient.ParameterToString(flagCartaoVirtual)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flagProvisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (serviceCode != null) localVarQueryParams.Add("serviceCode", Configuration.ApiClient.ParameterToString(serviceCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarBin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarBin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBinResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBinResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBinResponse)));
            
        }

        
        /// <summary>
        /// Bin list Bin list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Bin id (optional)</param>
        /// <param name="proximaConta">Bin next account (optional)</param>
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param>
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param>
        /// <param name="serviceCode">Bin service code (optional)</param>
        /// <returns>Task of PageBinResponse</returns>
        public async System.Threading.Tasks.Task<PageBinResponse> ListarBinAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null)
        {
             ApiResponse<PageBinResponse> localVarResponse = await ListarBinAsyncWithHttpInfo(sort, page, limit, id, proximaConta, flagCartaoVirtual, flagProvisorio, serviceCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bin list Bin list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Bin id (optional)</param>
        /// <param name="proximaConta">Bin next account (optional)</param>
        /// <param name="flagCartaoVirtual">Bin flag virtual card (optional)</param>
        /// <param name="flagProvisorio">Provisional bin flag (optional)</param>
        /// <param name="serviceCode">Bin service code (optional)</param>
        /// <returns>Task of ApiResponse (PageBinResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBinResponse>> ListarBinAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? proximaConta = null, int? flagCartaoVirtual = null, int? flagProvisorio = null, int? serviceCode = null)
        {
            
    
            var localVarPath = "/api/bins";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (proximaConta != null) localVarQueryParams.Add("proximaConta", Configuration.ApiClient.ParameterToString(proximaConta)); // query parameter
            if (flagCartaoVirtual != null) localVarQueryParams.Add("flagCartaoVirtual", Configuration.ApiClient.ParameterToString(flagCartaoVirtual)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flagProvisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (serviceCode != null) localVarQueryParams.Add("serviceCode", Configuration.ApiClient.ParameterToString(serviceCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarBin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarBin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBinResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBinResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBinResponse)));
            
        }
        
    }
    
}
