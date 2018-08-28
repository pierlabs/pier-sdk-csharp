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
    public interface IGlobaltaggrupochagebackApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{codigo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <returns>PageCodigoChargebackResponse</returns>
        PageCodigoChargebackResponse ListarCodigosUsingGET (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null);
  
        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{codigo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <returns>ApiResponse of PageCodigoChargebackResponse</returns>
        ApiResponse<PageCodigoChargebackResponse> ListarCodigosUsingGETWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null);
        
        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageGrupoChargebackResponse</returns>
        PageGrupoChargebackResponse ListarUsingGET28 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        ApiResponse<PageGrupoChargebackResponse> ListarUsingGET28WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{codigo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <returns>Task of PageCodigoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageCodigoChargebackResponse> ListarCodigosUsingGETAsync (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null);

        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{codigo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCodigoChargebackResponse>> ListarCodigosUsingGETAsyncWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null);
        
        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageGrupoChargebackResponse> ListarUsingGET28Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{grupo_chargeback_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> ListarUsingGET28AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltaggrupochagebackApi : IGlobaltaggrupochagebackApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaggrupochagebackApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltaggrupochagebackApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaggrupochagebackApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltaggrupochagebackApi(Configuration configuration = null)
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
        /// {{{codigo_chargeback_resource_listar}}} {{{codigo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id"> (optional)</param> 
        /// <param name="descricao"> (optional)</param> 
        /// <param name="flagAtm"> (optional)</param> 
        /// <param name="grupoChargebackId2"> (optional)</param> 
        /// <returns>PageCodigoChargebackResponse</returns>
        public PageCodigoChargebackResponse ListarCodigosUsingGET (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null)
        {
             ApiResponse<PageCodigoChargebackResponse> localVarResponse = ListarCodigosUsingGETWithHttpInfo(grupoChargebackId, sort, page, limit, id, descricao, flagAtm, grupoChargebackId2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}} {{{codigo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id"> (optional)</param> 
        /// <param name="descricao"> (optional)</param> 
        /// <param name="flagAtm"> (optional)</param> 
        /// <param name="grupoChargebackId2"> (optional)</param> 
        /// <returns>ApiResponse of PageCodigoChargebackResponse</returns>
        public ApiResponse< PageCodigoChargebackResponse > ListarCodigosUsingGETWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null)
        {
            
            // verify the required parameter 'grupoChargebackId' is set
            if (grupoChargebackId == null)
                throw new ApiException(400, "Missing required parameter 'grupoChargebackId' when calling GlobaltaggrupochagebackApi->ListarCodigosUsingGET");
            
    
            var localVarPath = "/api/grupos-chargeback/{grupoChargebackId}/codigos";
    
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
            if (grupoChargebackId != null) localVarPathParams.Add("grupoChargebackId", Configuration.ApiClient.ParameterToString(grupoChargebackId)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtm != null) localVarQueryParams.Add("flagAtm", Configuration.ApiClient.ParameterToString(flagAtm)); // query parameter
            if (grupoChargebackId2 != null) localVarQueryParams.Add("grupoChargebackId", Configuration.ApiClient.ParameterToString(grupoChargebackId2)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCodigoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoChargebackResponse)));
            
        }

        
        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}} {{{codigo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <returns>Task of PageCodigoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageCodigoChargebackResponse> ListarCodigosUsingGETAsync (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null)
        {
             ApiResponse<PageCodigoChargebackResponse> localVarResponse = await ListarCodigosUsingGETAsyncWithHttpInfo(grupoChargebackId, sort, page, limit, id, descricao, flagAtm, grupoChargebackId2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{codigo_chargeback_resource_listar}}} {{{codigo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCodigoChargebackResponse>> ListarCodigosUsingGETAsyncWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null)
        {
            // verify the required parameter 'grupoChargebackId' is set
            if (grupoChargebackId == null) throw new ApiException(400, "Missing required parameter 'grupoChargebackId' when calling ListarCodigosUsingGET");
            
    
            var localVarPath = "/api/grupos-chargeback/{grupoChargebackId}/codigos";
    
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
            if (grupoChargebackId != null) localVarPathParams.Add("grupoChargebackId", Configuration.ApiClient.ParameterToString(grupoChargebackId)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtm != null) localVarQueryParams.Add("flagAtm", Configuration.ApiClient.ParameterToString(flagAtm)); // query parameter
            if (grupoChargebackId2 != null) localVarQueryParams.Add("grupoChargebackId", Configuration.ApiClient.ParameterToString(grupoChargebackId2)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCodigoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoChargebackResponse)));
            
        }
        
        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}} {{{grupo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageGrupoChargebackResponse</returns>
        public PageGrupoChargebackResponse ListarUsingGET28 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = ListarUsingGET28WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}} {{{grupo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        public ApiResponse< PageGrupoChargebackResponse > ListarUsingGET28WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/grupos-chargeback";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }

        
        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}} {{{grupo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoChargebackResponse> ListarUsingGET28Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = await ListarUsingGET28AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{grupo_chargeback_resource_listar}}} {{{grupo_chargeback_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> ListarUsingGET28AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/grupos-chargeback";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }
        
    }
    
}
