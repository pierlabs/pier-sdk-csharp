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
        /// Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse ConsultarUsingGET4 (long? id);
  
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> ConsultarUsingGET4WithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse DesabilitarUsingPOST (long? id);
  
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> DesabilitarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse HabilitarUsingPOST (long? id);
  
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> HabilitarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param>
        /// <returns>PageAvisoViagemResponse</returns>
        PageAvisoViagemResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);
  
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PageAvisoViagemResponse</returns>
        ApiResponse<PageAvisoViagemResponse> ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse SalvarUsingPOST3 (long? idCartao, string codigoPais, string dataInicio, string dataFim);
  
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> SalvarUsingPOST3WithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> ConsultarUsingGET4Async (long? id);

        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> ConsultarUsingGET4AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> DesabilitarUsingPOSTAsync (long? id);

        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> DesabilitarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> HabilitarUsingPOSTAsync (long? id);

        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> HabilitarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageAvisoViagemResponse</returns>
        System.Threading.Tasks.Task<PageAvisoViagemResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);

        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageAvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAvisoViagemResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> SalvarUsingPOST3Async (long? idCartao, string codigoPais, string dataInicio, string dataFim);

        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> SalvarUsingPOST3AsyncWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim);
        
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
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse ConsultarUsingGET4 (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = ConsultarUsingGET4WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > ConsultarUsingGET4WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AvisoViagemApi->ConsultarUsingGET4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> ConsultarUsingGET4Async (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await ConsultarUsingGET4AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja consultado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> ConsultarUsingGET4AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse DesabilitarUsingPOST (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = DesabilitarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > DesabilitarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AvisoViagemApi->DesabilitarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> DesabilitarUsingPOSTAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await DesabilitarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desabilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja desabilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> DesabilitarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse HabilitarUsingPOST (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = HabilitarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > HabilitarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AvisoViagemApi->HabilitarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling HabilitarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> HabilitarUsingPOSTAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await HabilitarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitar um aviso viagem de acordo com o id passado Este m\u00C3\u00A9todo permite que seja habilitado um aviso viagen existente na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Aviso Viagem (id).</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> HabilitarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling HabilitarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param> 
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param> 
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param> 
        /// <returns>PageAvisoViagemResponse</returns>
        public PageAvisoViagemResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
        {
             ApiResponse<PageAvisoViagemResponse> localVarResponse = ListarUsingGET6WithHttpInfo(sort, page, limit, idCartao, codigoPais, dataInicio, dataFim, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param> 
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param> 
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PageAvisoViagemResponse</returns>
        public ApiResponse< PageAvisoViagemResponse > ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PageAvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<PageAvisoViagemResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
        {
             ApiResponse<PageAvisoViagemResponse> localVarResponse = await ListarUsingGET6AsyncWithHttpInfo(sort, page, limit, idCartao, codigoPais, dataInicio, dataFim, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os avisos viagens gerados pelo Emissor Este m\u00C3\u00A9todo permite que sejam listados os avisos viagens existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id) (optional)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id) (optional)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem (optional)</param>
        /// <param name="dataFim">Data fim do aviso viagem (optional)</param>
        /// <param name="flagAtivo">Identifica se o aviso viagem esta ativo ou n\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PageAvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAvisoViagemResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem</param> 
        /// <param name="dataFim">Data fim do aviso viagem</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse SalvarUsingPOST3 (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = SalvarUsingPOST3WithHttpInfo(idCartao, codigoPais, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param> 
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param> 
        /// <param name="dataInicio">Data inicio do aviso viagem</param> 
        /// <param name="dataFim">Data fim do aviso viagem</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > SalvarUsingPOST3WithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling AvisoViagemApi->SalvarUsingPOST3");
            
            // verify the required parameter 'codigoPais' is set
            if (codigoPais == null)
                throw new ApiException(400, "Missing required parameter 'codigoPais' when calling AvisoViagemApi->SalvarUsingPOST3");
            
            // verify the required parameter 'dataInicio' is set
            if (dataInicio == null)
                throw new ApiException(400, "Missing required parameter 'dataInicio' when calling AvisoViagemApi->SalvarUsingPOST3");
            
            // verify the required parameter 'dataFim' is set
            if (dataFim == null)
                throw new ApiException(400, "Missing required parameter 'dataFim' when calling AvisoViagemApi->SalvarUsingPOST3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> SalvarUsingPOST3Async (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await SalvarUsingPOST3AsyncWithHttpInfo(idCartao, codigoPais, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Aviso Viagem Este m\u00C3\u00A9todo permite que seja cadastrado um novo Aviso Viagem na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00C3\u00B3digo Identificador do cart\u00C3\u00A3o na base (id)</param>
        /// <param name="codigoPais">Codigo identificador do pa\u00C3\u00ADs na base (id)</param>
        /// <param name="dataInicio">Data inicio do aviso viagem</param>
        /// <param name="dataFim">Data fim do aviso viagem</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> SalvarUsingPOST3AsyncWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling SalvarUsingPOST3");
            // verify the required parameter 'codigoPais' is set
            if (codigoPais == null) throw new ApiException(400, "Missing required parameter 'codigoPais' when calling SalvarUsingPOST3");
            // verify the required parameter 'dataInicio' is set
            if (dataInicio == null) throw new ApiException(400, "Missing required parameter 'dataInicio' when calling SalvarUsingPOST3");
            // verify the required parameter 'dataFim' is set
            if (dataFim == null) throw new ApiException(400, "Missing required parameter 'dataFim' when calling SalvarUsingPOST3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
    }
    
}
