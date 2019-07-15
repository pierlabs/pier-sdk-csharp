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
    public interface IContestaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param>
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagSistema">Flag do sistema (optional)</param>
        /// <returns>PageStatusContestacaoResponse</returns>
        PageStatusContestacaoResponse ListarStatusContestacoes (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
  
        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param>
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagSistema">Flag do sistema (optional)</param>
        /// <returns>ApiResponse of PageStatusContestacaoResponse</returns>
        ApiResponse<PageStatusContestacaoResponse> ListarStatusContestacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
        
        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <returns>PageTipoResolucaoContestacaoResponse</returns>
        PageTipoResolucaoContestacaoResponse ListarTiposResolucoesContestacoes (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
  
        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageTipoResolucaoContestacaoResponse</returns>
        ApiResponse<PageTipoResolucaoContestacaoResponse> ListarTiposResolucoesContestacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param>
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagSistema">Flag do sistema (optional)</param>
        /// <returns>Task of PageStatusContestacaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusContestacaoResponse> ListarStatusContestacoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);

        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param>
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagSistema">Flag do sistema (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContestacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContestacaoResponse>> ListarStatusContestacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null);
        
        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageTipoResolucaoContestacaoResponse</returns>
        System.Threading.Tasks.Task<PageTipoResolucaoContestacaoResponse> ListarTiposResolucoesContestacoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);

        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoResolucaoContestacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoResolucaoContestacaoResponse>> ListarTiposResolucoesContestacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContestaoApi : IContestaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContestaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContestaoApi(Configuration configuration = null)
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
        /// Lista status das contesta\u00E7\u00F5es Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param> 
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param> 
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param> 
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param> 
        /// <param name="flagSistema">Flag do sistema (optional)</param> 
        /// <returns>PageStatusContestacaoResponse</returns>
        public PageStatusContestacaoResponse ListarStatusContestacoes (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
             ApiResponse<PageStatusContestacaoResponse> localVarResponse = ListarStatusContestacoesWithHttpInfo(sort, page, limit, idStatusContestacao, idStatusContestacaoOrigem, descricao, flagPermiteAlteracao, flagSistema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param> 
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param> 
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param> 
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param> 
        /// <param name="flagSistema">Flag do sistema (optional)</param> 
        /// <returns>ApiResponse of PageStatusContestacaoResponse</returns>
        public ApiResponse< PageStatusContestacaoResponse > ListarStatusContestacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContestacaoResponse)));
            
        }

        
        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param>
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagSistema">Flag do sistema (optional)</param>
        /// <returns>Task of PageStatusContestacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContestacaoResponse> ListarStatusContestacoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
        {
             ApiResponse<PageStatusContestacaoResponse> localVarResponse = await ListarStatusContestacoesAsyncWithHttpInfo(sort, page, limit, idStatusContestacao, idStatusContestacaoOrigem, descricao, flagPermiteAlteracao, flagSistema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista status das contesta\u00E7\u00F5es Este recurso permite a listagem do status das contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusContestacao">Id status da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="idStatusContestacaoOrigem">Id status da contesta\u00E7\u00E3o origem (optional)</param>
        /// <param name="descricao">Decri\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="flagPermiteAlteracao">Flag de verifica\u00E7\u00E3o de permiss\u00E3o para altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagSistema">Flag do sistema (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContestacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContestacaoResponse>> ListarStatusContestacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusContestacao = null, long? idStatusContestacaoOrigem = null, string descricao = null, int? flagPermiteAlteracao = null, int? flagSistema = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusContestacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContestacaoResponse)));
            
        }
        
        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param> 
        /// <returns>PageTipoResolucaoContestacaoResponse</returns>
        public PageTipoResolucaoContestacaoResponse ListarTiposResolucoesContestacoes (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
             ApiResponse<PageTipoResolucaoContestacaoResponse> localVarResponse = ListarTiposResolucoesContestacoesWithHttpInfo(sort, page, limit, idTipoResolucaoContestacao, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageTipoResolucaoContestacaoResponse</returns>
        public ApiResponse< PageTipoResolucaoContestacaoResponse > ListarTiposResolucoesContestacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucoesContestacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucoesContestacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoResolucaoContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoResolucaoContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoResolucaoContestacaoResponse)));
            
        }

        
        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageTipoResolucaoContestacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoResolucaoContestacaoResponse> ListarTiposResolucoesContestacoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
        {
             ApiResponse<PageTipoResolucaoContestacaoResponse> localVarResponse = await ListarTiposResolucoesContestacoesAsyncWithHttpInfo(sort, page, limit, idTipoResolucaoContestacao, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar tipo da contesta\u00E7\u00E3o Este recurso permite a listagem dos tipos de contesta\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoResolucaoContestacao">Id tipo da resolucao da contesta\u00E7\u00E3o (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de resolu\u00E7\u00E3o da contesta\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoResolucaoContestacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoResolucaoContestacaoResponse>> ListarTiposResolucoesContestacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoResolucaoContestacao = null, string descricao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucoesContestacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucoesContestacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoResolucaoContestacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoResolucaoContestacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoResolucaoContestacaoResponse)));
            
        }
        
    }
    
}
