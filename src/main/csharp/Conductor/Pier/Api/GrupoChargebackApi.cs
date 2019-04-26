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
    public interface IGrupoChargebackApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Listar grupos de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os grupos de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageGrupoChargebackResponse</returns>
        PageGrupoChargebackResponse Listar (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar grupos de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os grupos de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        ApiResponse<PageGrupoChargebackResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar c\u00F3digo de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os c\u00F3digo de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <param name="bandeiraId"> (optional)</param>
        /// <returns>PageCodigoChargebackResponse</returns>
        PageCodigoChargebackResponse ListarCodigos (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null);
  
        /// <summary>
        /// Listar c\u00F3digo de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os c\u00F3digo de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <param name="bandeiraId"> (optional)</param>
        /// <returns>ApiResponse of PageCodigoChargebackResponse</returns>
        ApiResponse<PageCodigoChargebackResponse> ListarCodigosWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Listar grupos de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os grupos de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageGrupoChargebackResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar grupos de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os grupos de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar c\u00F3digo de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os c\u00F3digo de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <param name="bandeiraId"> (optional)</param>
        /// <returns>Task of PageCodigoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageCodigoChargebackResponse> ListarCodigosAsync (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null);

        /// <summary>
        /// Listar c\u00F3digo de chargeback
        /// </summary>
        /// <remarks>
        /// Lista os c\u00F3digo de chargeback
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <param name="bandeiraId"> (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCodigoChargebackResponse>> ListarCodigosAsyncWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GrupoChargebackApi : IGrupoChargebackApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoChargebackApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GrupoChargebackApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoChargebackApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GrupoChargebackApi(Configuration configuration = null)
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
        /// Listar grupos de chargeback Lista os grupos de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageGrupoChargebackResponse</returns>
        public PageGrupoChargebackResponse Listar (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar grupos de chargeback Lista os grupos de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        public ApiResponse< PageGrupoChargebackResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }

        
        /// <summary>
        /// Listar grupos de chargeback Lista os grupos de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoChargebackResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar grupos de chargeback Lista os grupos de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }
        
        /// <summary>
        /// Listar c\u00F3digo de chargeback Lista os c\u00F3digo de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id"> (optional)</param> 
        /// <param name="descricao"> (optional)</param> 
        /// <param name="flagAtm"> (optional)</param> 
        /// <param name="grupoChargebackId2"> (optional)</param> 
        /// <param name="bandeiraId"> (optional)</param> 
        /// <returns>PageCodigoChargebackResponse</returns>
        public PageCodigoChargebackResponse ListarCodigos (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null)
        {
             ApiResponse<PageCodigoChargebackResponse> localVarResponse = ListarCodigosWithHttpInfo(grupoChargebackId, sort, page, limit, id, descricao, flagAtm, grupoChargebackId2, bandeiraId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar c\u00F3digo de chargeback Lista os c\u00F3digo de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id"> (optional)</param> 
        /// <param name="descricao"> (optional)</param> 
        /// <param name="flagAtm"> (optional)</param> 
        /// <param name="grupoChargebackId2"> (optional)</param> 
        /// <param name="bandeiraId"> (optional)</param> 
        /// <returns>ApiResponse of PageCodigoChargebackResponse</returns>
        public ApiResponse< PageCodigoChargebackResponse > ListarCodigosWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null)
        {
            
            // verify the required parameter 'grupoChargebackId' is set
            if (grupoChargebackId == null)
                throw new ApiException(400, "Missing required parameter 'grupoChargebackId' when calling GrupoChargebackApi->ListarCodigos");
            
    
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
            if (bandeiraId != null) localVarQueryParams.Add("bandeiraId", Configuration.ApiClient.ParameterToString(bandeiraId)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCodigoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoChargebackResponse)));
            
        }

        
        /// <summary>
        /// Listar c\u00F3digo de chargeback Lista os c\u00F3digo de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <param name="bandeiraId"> (optional)</param>
        /// <returns>Task of PageCodigoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageCodigoChargebackResponse> ListarCodigosAsync (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null)
        {
             ApiResponse<PageCodigoChargebackResponse> localVarResponse = await ListarCodigosAsyncWithHttpInfo(grupoChargebackId, sort, page, limit, id, descricao, flagAtm, grupoChargebackId2, bandeiraId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar c\u00F3digo de chargeback Lista os c\u00F3digo de chargeback
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoChargebackId">grupoChargebackId</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="descricao"> (optional)</param>
        /// <param name="flagAtm"> (optional)</param>
        /// <param name="grupoChargebackId2"> (optional)</param>
        /// <param name="bandeiraId"> (optional)</param>
        /// <returns>Task of ApiResponse (PageCodigoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCodigoChargebackResponse>> ListarCodigosAsyncWithHttpInfo (long? grupoChargebackId, List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagAtm = null, long? grupoChargebackId2 = null, long? bandeiraId = null)
        {
            // verify the required parameter 'grupoChargebackId' is set
            if (grupoChargebackId == null) throw new ApiException(400, "Missing required parameter 'grupoChargebackId' when calling ListarCodigos");
            
    
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
            if (bandeiraId != null) localVarQueryParams.Add("bandeiraId", Configuration.ApiClient.ParameterToString(bandeiraId)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCodigoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCodigoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCodigoChargebackResponse)));
            
        }
        
    }
    
}
