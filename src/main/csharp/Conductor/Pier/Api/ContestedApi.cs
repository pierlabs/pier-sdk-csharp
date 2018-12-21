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
    public interface IContestedApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// List status of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the status of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param>
        /// <param name="descricao">Description of the contestation (optional)</param>
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param>
        /// <param name="flagSistema">System flag (optional)</param>
        /// <returns>PageStatusContestacaoResponse</returns>
        PageStatusContestacaoResponse ListarStatusContestacao (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
  
        /// <summary>
        /// List status of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the status of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param>
        /// <param name="descricao">Description of the contestation (optional)</param>
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param>
        /// <param name="flagSistema">System flag (optional)</param>
        /// <returns>ApiResponse of PageStatusContestacaoResponse</returns>
        ApiResponse<PageStatusContestacaoResponse> ListarStatusContestacaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
        
        /// <summary>
        /// List type of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param>
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param>
        /// <returns>PageTipoResolucaoContestacaoResponse</returns>
        PageTipoResolucaoContestacaoResponse ListarTipoResolucaoContestacao (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
  
        /// <summary>
        /// List type of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param>
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param>
        /// <returns>ApiResponse of PageTipoResolucaoContestacaoResponse</returns>
        ApiResponse<PageTipoResolucaoContestacaoResponse> ListarTipoResolucaoContestacaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// List status of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the status of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param>
        /// <param name="descricao">Description of the contestation (optional)</param>
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param>
        /// <param name="flagSistema">System flag (optional)</param>
        /// <returns>Task of PageStatusContestacaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusContestacaoResponse> ListarStatusContestacaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);

        /// <summary>
        /// List status of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the status of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param>
        /// <param name="descricao">Description of the contestation (optional)</param>
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param>
        /// <param name="flagSistema">System flag (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContestacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContestacaoResponse>> ListarStatusContestacaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
        
        /// <summary>
        /// List type of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param>
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param>
        /// <returns>Task of PageTipoResolucaoContestacaoResponse</returns>
        System.Threading.Tasks.Task<PageTipoResolucaoContestacaoResponse> ListarTipoResolucaoContestacaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);

        /// <summary>
        /// List type of contestation
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of contestation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param>
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoResolucaoContestacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoResolucaoContestacaoResponse>> ListarTipoResolucaoContestacaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContestedApi : IContestedApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContestedApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestedApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContestedApi(Configuration configuration = null)
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
        /// List status of contestation This feature allows you to list the status of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param> 
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param> 
        /// <param name="descricao">Description of the contestation (optional)</param> 
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param> 
        /// <param name="flagSistema">System flag (optional)</param> 
        /// <returns>PageStatusContestacaoResponse</returns>
        public PageStatusContestacaoResponse ListarStatusContestacao (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
             ApiResponse<PageStatusContestacaoResponse> localVarResponse = ListarStatusContestacaoWithHttpInfo(sort, page, limit, idStatusContestacao, idStatusContestacaoOrigem, descricao, flagPermiteAlteracao, flagSistema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List status of contestation This feature allows you to list the status of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param> 
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param> 
        /// <param name="descricao">Description of the contestation (optional)</param> 
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param> 
        /// <param name="flagSistema">System flag (optional)</param> 
        /// <returns>ApiResponse of PageStatusContestacaoResponse</returns>
        public ApiResponse< PageStatusContestacaoResponse > ListarStatusContestacaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
            
    
            var localVarPath = "/api/status-contestacoes";
    
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
            if (idStatusContestacao != null) localVarQueryParams.Add("idStatusContestacao", Configuration.ApiClient.ParameterToString(idStatusContestacao)); // query parameter
            if (idStatusContestacaoOrigem != null) localVarQueryParams.Add("idStatusContestacaoOrigem", Configuration.ApiClient.ParameterToString(idStatusContestacaoOrigem)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagPermiteAlteracao != null) localVarQueryParams.Add("flagPermiteAlteracao", Configuration.ApiClient.ParameterToString(flagPermiteAlteracao)); // query parameter
            if (flagSistema != null) localVarQueryParams.Add("flagSistema", Configuration.ApiClient.ParameterToString(flagSistema)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContestacaoResponse)));
            
        }

        
        /// <summary>
        /// List status of contestation This feature allows you to list the status of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param>
        /// <param name="descricao">Description of the contestation (optional)</param>
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param>
        /// <param name="flagSistema">System flag (optional)</param>
        /// <returns>Task of PageStatusContestacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContestacaoResponse> ListarStatusContestacaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
             ApiResponse<PageStatusContestacaoResponse> localVarResponse = await ListarStatusContestacaoAsyncWithHttpInfo(sort, page, limit, idStatusContestacao, idStatusContestacaoOrigem, descricao, flagPermiteAlteracao, flagSistema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List status of contestation This feature allows you to list the status of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id of status contestation (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id origin contestation status (optional)</param>
        /// <param name="descricao">Description of the contestation (optional)</param>
        /// <param name="flagPermiteAlteracao">Permit verification flag for change (optional)</param>
        /// <param name="flagSistema">System flag (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContestacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContestacaoResponse>> ListarStatusContestacaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
            
    
            var localVarPath = "/api/status-contestacoes";
    
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
            if (idStatusContestacao != null) localVarQueryParams.Add("idStatusContestacao", Configuration.ApiClient.ParameterToString(idStatusContestacao)); // query parameter
            if (idStatusContestacaoOrigem != null) localVarQueryParams.Add("idStatusContestacaoOrigem", Configuration.ApiClient.ParameterToString(idStatusContestacaoOrigem)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagPermiteAlteracao != null) localVarQueryParams.Add("flagPermiteAlteracao", Configuration.ApiClient.ParameterToString(flagPermiteAlteracao)); // query parameter
            if (flagSistema != null) localVarQueryParams.Add("flagSistema", Configuration.ApiClient.ParameterToString(flagSistema)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContestacaoResponse)));
            
        }
        
        /// <summary>
        /// List type of contestation This feature allows you to list the types of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param> 
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param> 
        /// <returns>PageTipoResolucaoContestacaoResponse</returns>
        public PageTipoResolucaoContestacaoResponse ListarTipoResolucaoContestacao (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
             ApiResponse<PageTipoResolucaoContestacaoResponse> localVarResponse = ListarTipoResolucaoContestacaoWithHttpInfo(sort, page, limit, idTipoResolucaoContestacao, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List type of contestation This feature allows you to list the types of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param> 
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param> 
        /// <returns>ApiResponse of PageTipoResolucaoContestacaoResponse</returns>
        public ApiResponse< PageTipoResolucaoContestacaoResponse > ListarTipoResolucaoContestacaoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-resolucoes-contestacoes";
    
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
            if (idTipoResolucaoContestacao != null) localVarQueryParams.Add("idTipoResolucaoContestacao", Configuration.ApiClient.ParameterToString(idTipoResolucaoContestacao)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoResolucaoContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoResolucaoContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoResolucaoContestacaoResponse)));
            
        }

        
        /// <summary>
        /// List type of contestation This feature allows you to list the types of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param>
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param>
        /// <returns>Task of PageTipoResolucaoContestacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoResolucaoContestacaoResponse> ListarTipoResolucaoContestacaoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
             ApiResponse<PageTipoResolucaoContestacaoResponse> localVarResponse = await ListarTipoResolucaoContestacaoAsyncWithHttpInfo(sort, page, limit, idTipoResolucaoContestacao, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List type of contestation This feature allows you to list the types of contestation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id type resolutions of contestation (optional)</param>
        /// <param name="descricao">Description of the type resolutions contestation (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoResolucaoContestacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoResolucaoContestacaoResponse>> ListarTipoResolucaoContestacaoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-resolucoes-contestacoes";
    
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
            if (idTipoResolucaoContestacao != null) localVarQueryParams.Add("idTipoResolucaoContestacao", Configuration.ApiClient.ParameterToString(idTipoResolucaoContestacao)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoResolucaoContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoResolucaoContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoResolucaoContestacaoResponse)));
            
        }
        
    }
    
}
