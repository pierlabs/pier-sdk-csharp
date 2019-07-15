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
    public interface IAvisoViagemApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse ConsultarAvisoViagem (long? id);
  
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> ConsultarAvisoViagemWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse DesabilitarAvisoViagem (long? id);
  
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> DesabilitarAvisoViagemWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse HabilitarAvisoViagem (long? id);
  
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> HabilitarAvisoViagemWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param>
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param>
        /// <returns>PageAvisoViagemResponse</returns>
        PageAvisoViagemResponse ListarAvisosViagem (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null);
  
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param>
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param>
        /// <returns>ApiResponse of PageAvisoViagemResponse</returns>
        ApiResponse<PageAvisoViagemResponse> ListarAvisosViagemWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse SalvarAvisoViagem (long? idCartao, string codigoPais, string dataInicio, string dataFim);
  
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> SalvarAvisoViagemWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> ConsultarAvisoViagemAsync (long? id);

        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> ConsultarAvisoViagemAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> DesabilitarAvisoViagemAsync (long? id);

        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> DesabilitarAvisoViagemAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> HabilitarAvisoViagemAsync (long? id);

        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> HabilitarAvisoViagemAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param>
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param>
        /// <returns>Task of PageAvisoViagemResponse</returns>
        System.Threading.Tasks.Task<PageAvisoViagemResponse> ListarAvisosViagemAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null);

        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param>
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param>
        /// <returns>Task of ApiResponse (PageAvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAvisoViagemResponse>> ListarAvisosViagemAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> SalvarAvisoViagemAsync (long? idCartao, string codigoPais, string dataInicio, string dataFim);

        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> SalvarAvisoViagemAsyncWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AvisoViagemApi : IAvisoViagemApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvisoViagemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvisoViagemApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AvisoViagemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AvisoViagemApi(Configuration configuration = null)
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
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse ConsultarAvisoViagem (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = ConsultarAvisoViagemWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > ConsultarAvisoViagemWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AvisoViagemApi->ConsultarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> ConsultarAvisoViagemAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await ConsultarAvisoViagemAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja consultado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> ConsultarAvisoViagemAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse DesabilitarAvisoViagem (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = DesabilitarAvisoViagemWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > DesabilitarAvisoViagemWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AvisoViagemApi->DesabilitarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/desabilitar";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> DesabilitarAvisoViagemAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await DesabilitarAvisoViagemAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja desabilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> DesabilitarAvisoViagemAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/desabilitar";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse HabilitarAvisoViagem (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = HabilitarAvisoViagemWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > HabilitarAvisoViagemWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AvisoViagemApi->HabilitarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/habilitar";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> HabilitarAvisoViagemAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await HabilitarAvisoViagemAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00E9todo permite que seja habilitado um aviso viagen existente na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Aviso Viagem (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> HabilitarAvisoViagemAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/habilitar";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param> 
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param> 
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param> 
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param> 
        /// <returns>PageAvisoViagemResponse</returns>
        public PageAvisoViagemResponse ListarAvisosViagem (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null)
        {
             ApiResponse<PageAvisoViagemResponse> localVarResponse = ListarAvisosViagemWithHttpInfo(sort, page, limit, idCartao, codigoPais, dataInicio, dataFim, flagAtivo, paisDescricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param> 
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param> 
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param> 
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param> 
        /// <returns>ApiResponse of PageAvisoViagemResponse</returns>
        public ApiResponse< PageAvisoViagemResponse > ListarAvisosViagemWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null)
        {
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (paisDescricao != null) localVarQueryParams.Add("paisDescricao", Configuration.ApiClient.ParameterToString(paisDescricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAvisosViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAvisosViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param>
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param>
        /// <returns>Task of PageAvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<PageAvisoViagemResponse> ListarAvisosViagemAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null)
        {
             ApiResponse<PageAvisoViagemResponse> localVarResponse = await ListarAvisosViagemAsyncWithHttpInfo(sort, page, limit, idCartao, codigoPais, dataInicio, dataFim, flagAtivo, paisDescricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00E9todo permite que sejam listados os avisos viagens existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00E3o (optional)</param>
        /// <param name="paisDescricao">Descri\u00E7\u00E3o do pa\u00EDs (optional)</param>
        /// <returns>Task of ApiResponse (PageAvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAvisoViagemResponse>> ListarAvisosViagemAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null, string paisDescricao = null)
        {
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (paisDescricao != null) localVarQueryParams.Add("paisDescricao", Configuration.ApiClient.ParameterToString(paisDescricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAvisosViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAvisosViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem</param> 
        /// <param name="dataFim">Data fim do aviso viagem</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse SalvarAvisoViagem (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = SalvarAvisoViagemWithHttpInfo(idCartao, codigoPais, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem</param> 
        /// <param name="dataFim">Data fim do aviso viagem</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > SalvarAvisoViagemWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling AvisoViagemApi->SalvarAvisoViagem");
            
            // verify the required parameter 'codigoPais' is set
            if (codigoPais == null)
                throw new ApiException(400, "Missing required parameter 'codigoPais' when calling AvisoViagemApi->SalvarAvisoViagem");
            
            // verify the required parameter 'dataInicio' is set
            if (dataInicio == null)
                throw new ApiException(400, "Missing required parameter 'dataInicio' when calling AvisoViagemApi->SalvarAvisoViagem");
            
            // verify the required parameter 'dataFim' is set
            if (dataFim == null)
                throw new ApiException(400, "Missing required parameter 'dataFim' when calling AvisoViagemApi->SalvarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> SalvarAvisoViagemAsync (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await SalvarAvisoViagemAsyncWithHttpInfo(idCartao, codigoPais, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00E9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo Identificador do cart\u00E3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00EDs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> SalvarAvisoViagemAsyncWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling SalvarAvisoViagem");
            // verify the required parameter 'codigoPais' is set
            if (codigoPais == null) throw new ApiException(400, "Missing required parameter 'codigoPais' when calling SalvarAvisoViagem");
            // verify the required parameter 'dataInicio' is set
            if (dataInicio == null) throw new ApiException(400, "Missing required parameter 'dataInicio' when calling SalvarAvisoViagem");
            // verify the required parameter 'dataFim' is set
            if (dataFim == null) throw new ApiException(400, "Missing required parameter 'dataFim' when calling SalvarAvisoViagem");
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAvisoViagem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAvisoViagem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
    }
    
}
