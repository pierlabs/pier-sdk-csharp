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
    public interface IGlobaltagtiporesolucaocontestacaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param>
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param>
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param>
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param>
        /// <returns>PageStatusContestacaoResponse</returns>
        PageStatusContestacaoResponse ListarStatusContestacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
  
        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param>
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param>
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param>
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param>
        /// <returns>ApiResponse of PageStatusContestacaoResponse</returns>
        ApiResponse<PageStatusContestacaoResponse> ListarStatusContestacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
        
        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param>
        /// <returns>PageTipoResolucaoContestacaoResponse</returns>
        PageTipoResolucaoContestacaoResponse ListarTipoResolucaoContestacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
  
        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoResolucaoContestacaoResponse</returns>
        ApiResponse<PageTipoResolucaoContestacaoResponse> ListarTipoResolucaoContestacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param>
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param>
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param>
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param>
        /// <returns>Task of PageStatusContestacaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusContestacaoResponse> ListarStatusContestacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);

        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param>
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param>
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param>
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContestacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContestacaoResponse>> ListarStatusContestacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
        
        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoResolucaoContestacaoResponse</returns>
        System.Threading.Tasks.Task<PageTipoResolucaoContestacaoResponse> ListarTipoResolucaoContestacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);

        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoResolucaoContestacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoResolucaoContestacaoResponse>> ListarTipoResolucaoContestacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagtiporesolucaocontestacaoApi : IGlobaltagtiporesolucaocontestacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagtiporesolucaocontestacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagtiporesolucaocontestacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagtiporesolucaocontestacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagtiporesolucaocontestacaoApi(Configuration configuration = null)
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
        /// {{{status_contestacao_resource_listar_status_contestacao}}} {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param> 
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param> 
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param> 
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param> 
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param> 
        /// <returns>PageStatusContestacaoResponse</returns>
        public PageStatusContestacaoResponse ListarStatusContestacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
             ApiResponse<PageStatusContestacaoResponse> localVarResponse = ListarStatusContestacaoUsingGETWithHttpInfo(sort, page, limit, idStatusContestacao, idStatusContestacaoOrigem, descricao, flagPermiteAlteracao, flagSistema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}} {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param> 
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param> 
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param> 
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param> 
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageStatusContestacaoResponse</returns>
        public ApiResponse< PageStatusContestacaoResponse > ListarStatusContestacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContestacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}} {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param>
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param>
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param>
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param>
        /// <returns>Task of PageStatusContestacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContestacaoResponse> ListarStatusContestacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
             ApiResponse<PageStatusContestacaoResponse> localVarResponse = await ListarStatusContestacaoUsingGETAsyncWithHttpInfo(sort, page, limit, idStatusContestacao, idStatusContestacaoOrigem, descricao, flagPermiteAlteracao, flagSistema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{status_contestacao_resource_listar_status_contestacao}}} {{{status_contestacao_resource_listar_status_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}} (optional)</param>
        /// <param name="idStatusContestacaoOrigem">{{{status_contestacao_request_idstatuscontestacaoOrigem_value}}} (optional)</param>
        /// <param name="descricao">{{{status_contestacao_request_descricao_value}}} (optional)</param>
        /// <param name="flagPermiteAlteracao">{{{status_contestacao_request_flagpermitealteracao_value}}} (optional)</param>
        /// <param name="flagSistema">{{{status_contestacao_request_flagsistema_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContestacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContestacaoResponse>> ListarStatusContestacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContestacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}} {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param> 
        /// <returns>PageTipoResolucaoContestacaoResponse</returns>
        public PageTipoResolucaoContestacaoResponse ListarTipoResolucaoContestacaoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
             ApiResponse<PageTipoResolucaoContestacaoResponse> localVarResponse = ListarTipoResolucaoContestacaoUsingGETWithHttpInfo(sort, page, limit, idTipoResolucaoContestacao, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}} {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoResolucaoContestacaoResponse</returns>
        public ApiResponse< PageTipoResolucaoContestacaoResponse > ListarTipoResolucaoContestacaoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoResolucaoContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoResolucaoContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoResolucaoContestacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}} {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoResolucaoContestacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoResolucaoContestacaoResponse> ListarTipoResolucaoContestacaoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
             ApiResponse<PageTipoResolucaoContestacaoResponse> localVarResponse = await ListarTipoResolucaoContestacaoUsingGETAsyncWithHttpInfo(sort, page, limit, idTipoResolucaoContestacao, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_resolucao_contestacao_resource_listar_tipo_contestacao}}} {{{tipo_resolucao_contestacao_resource_listar_tipo_resolucao_contestacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoResolucaoContestacao">{{{tipo_resolucao_contestacao_request_idTipoResolucaoContestacao_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_resolucao_contestacao_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoResolucaoContestacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoResolucaoContestacaoResponse>> ListarTipoResolucaoContestacaoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoResolucaoContestacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoResolucaoContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoResolucaoContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoResolucaoContestacaoResponse)));
            
        }
        
    }
    
}
