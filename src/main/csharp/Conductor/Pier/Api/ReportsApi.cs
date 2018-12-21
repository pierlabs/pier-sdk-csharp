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
    public interface IReportsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Report with history of controls processes updated by the batch
        /// </summary>
        /// <remarks>
        /// Generates a Report with history of controls updated by the batch
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento"> (optional)</param>
        /// <param name="dataVencimentoFim"> (optional)</param>
        /// <returns>PageRelatorioMovimentosControleProcessos</returns>
        PageRelatorioMovimentosControleProcessos MovimentosControleProcessos (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
  
        /// <summary>
        /// Report with history of controls processes updated by the batch
        /// </summary>
        /// <remarks>
        /// Generates a Report with history of controls updated by the batch
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento"> (optional)</param>
        /// <param name="dataVencimentoFim"> (optional)</param>
        /// <returns>ApiResponse of PageRelatorioMovimentosControleProcessos</returns>
        ApiResponse<PageRelatorioMovimentosControleProcessos> MovimentosControleProcessosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Report with history of controls processes updated by the batch
        /// </summary>
        /// <remarks>
        /// Generates a Report with history of controls updated by the batch
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento"> (optional)</param>
        /// <param name="dataVencimentoFim"> (optional)</param>
        /// <returns>Task of PageRelatorioMovimentosControleProcessos</returns>
        System.Threading.Tasks.Task<PageRelatorioMovimentosControleProcessos> MovimentosControleProcessosAsync (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);

        /// <summary>
        /// Report with history of controls processes updated by the batch
        /// </summary>
        /// <remarks>
        /// Generates a Report with history of controls updated by the batch
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento"> (optional)</param>
        /// <param name="dataVencimentoFim"> (optional)</param>
        /// <returns>Task of ApiResponse (PageRelatorioMovimentosControleProcessos)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageRelatorioMovimentosControleProcessos>> MovimentosControleProcessosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportsApi : IReportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportsApi(Configuration configuration = null)
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
        /// Report with history of controls processes updated by the batch Generates a Report with history of controls updated by the batch
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento"> (optional)</param> 
        /// <param name="dataVencimentoFim"> (optional)</param> 
        /// <returns>PageRelatorioMovimentosControleProcessos</returns>
        public PageRelatorioMovimentosControleProcessos MovimentosControleProcessos (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageRelatorioMovimentosControleProcessos> localVarResponse = MovimentosControleProcessosWithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Report with history of controls processes updated by the batch Generates a Report with history of controls updated by the batch
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento"> (optional)</param> 
        /// <param name="dataVencimentoFim"> (optional)</param> 
        /// <returns>ApiResponse of PageRelatorioMovimentosControleProcessos</returns>
        public ApiResponse< PageRelatorioMovimentosControleProcessos > MovimentosControleProcessosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
            
    
            var localVarPath = "/api/relatorios/movimentos-controle-processos";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataVencimentoFim != null) localVarQueryParams.Add("dataVencimentoFim", Configuration.ApiClient.ParameterToString(dataVencimentoFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling MovimentosControleProcessos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling MovimentosControleProcessos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageRelatorioMovimentosControleProcessos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageRelatorioMovimentosControleProcessos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageRelatorioMovimentosControleProcessos)));
            
        }

        
        /// <summary>
        /// Report with history of controls processes updated by the batch Generates a Report with history of controls updated by the batch
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento"> (optional)</param>
        /// <param name="dataVencimentoFim"> (optional)</param>
        /// <returns>Task of PageRelatorioMovimentosControleProcessos</returns>
        public async System.Threading.Tasks.Task<PageRelatorioMovimentosControleProcessos> MovimentosControleProcessosAsync (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageRelatorioMovimentosControleProcessos> localVarResponse = await MovimentosControleProcessosAsyncWithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Report with history of controls processes updated by the batch Generates a Report with history of controls updated by the batch
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento"> (optional)</param>
        /// <param name="dataVencimentoFim"> (optional)</param>
        /// <returns>Task of ApiResponse (PageRelatorioMovimentosControleProcessos)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageRelatorioMovimentosControleProcessos>> MovimentosControleProcessosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
            
    
            var localVarPath = "/api/relatorios/movimentos-controle-processos";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataVencimentoFim != null) localVarQueryParams.Add("dataVencimentoFim", Configuration.ApiClient.ParameterToString(dataVencimentoFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling MovimentosControleProcessos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling MovimentosControleProcessos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageRelatorioMovimentosControleProcessos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageRelatorioMovimentosControleProcessos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageRelatorioMovimentosControleProcessos)));
            
        }
        
    }
    
}
