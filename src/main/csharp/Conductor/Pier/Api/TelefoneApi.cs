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
    public interface ITelefoneApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Telefone</returns>
        Telefone ConsultarUsingGET6 (long? idTelefone);
  
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>ApiResponse of Telefone</returns>
        ApiResponse<Telefone> ConsultarUsingGET6WithHttpInfo (long? idTelefone);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>PageTelefones</returns>
        PageTelefones ListarUsingGET7 (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of PageTelefones</returns>
        ApiResponse<PageTelefones> ListarUsingGET7WithHttpInfo (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Telefone</returns>
        Telefone SalvarUsingPOST1 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>ApiResponse of Telefone</returns>
        ApiResponse<Telefone> SalvarUsingPOST1WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of Telefone</returns>
        System.Threading.Tasks.Task<Telefone> ConsultarUsingGET6Async (long? idTelefone);

        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Telefone>> ConsultarUsingGET6AsyncWithHttpInfo (long? idTelefone);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageTelefones</returns>
        System.Threading.Tasks.Task<PageTelefones> ListarUsingGET7Async (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefones)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefones>> ListarUsingGET7AsyncWithHttpInfo (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of Telefone</returns>
        System.Threading.Tasks.Task<Telefone> SalvarUsingPOST1Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Telefone>> SalvarUsingPOST1AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TelefoneApi : ITelefoneApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelefoneApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelefoneApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <returns>Telefone</returns>
        public Telefone ConsultarUsingGET6 (long? idTelefone)
        {
             ApiResponse<Telefone> localVarResponse = ConsultarUsingGET6WithHttpInfo(idTelefone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <returns>ApiResponse of Telefone</returns>
        public ApiResponse< Telefone > ConsultarUsingGET6WithHttpInfo (long? idTelefone)
        {
            
            // verify the required parameter 'idTelefone' is set
            if (idTelefone == null)
                throw new ApiException(400, "Missing required parameter 'idTelefone' when calling TelefoneApi->ConsultarUsingGET6");
            
    
            var localVarPath = "/api/telefones/{id_telefone}";
    
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
            if (idTelefone != null) localVarPathParams.Add("id_telefone", Configuration.ApiClient.ParameterToString(idTelefone)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of Telefone</returns>
        public async System.Threading.Tasks.Task<Telefone> ConsultarUsingGET6Async (long? idTelefone)
        {
             ApiResponse<Telefone> localVarResponse = await ConsultarUsingGET6AsyncWithHttpInfo(idTelefone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Telefone>> ConsultarUsingGET6AsyncWithHttpInfo (long? idTelefone)
        {
            // verify the required parameter 'idTelefone' is set
            if (idTelefone == null) throw new ApiException(400, "Missing required parameter 'idTelefone' when calling ConsultarUsingGET6");
            
    
            var localVarPath = "/api/telefones/{id_telefone}";
    
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
            if (idTelefone != null) localVarPathParams.Add("id_telefone", Configuration.ApiClient.ParameterToString(idTelefone)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>PageTelefones</returns>
        public PageTelefones ListarUsingGET7 (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTelefones> localVarResponse = ListarUsingGET7WithHttpInfo(id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of PageTelefones</returns>
        public ApiResponse< PageTelefones > ListarUsingGET7WithHttpInfo (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefones>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefones) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefones)));
            
        }

        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageTelefones</returns>
        public async System.Threading.Tasks.Task<PageTelefones> ListarUsingGET7Async (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTelefones> localVarResponse = await ListarUsingGET7AsyncWithHttpInfo(id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefones)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefones>> ListarUsingGET7AsyncWithHttpInfo (long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefones>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefones) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefones)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>Telefone</returns>
        public Telefone SalvarUsingPOST1 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<Telefone> localVarResponse = SalvarUsingPOST1WithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>ApiResponse of Telefone</returns>
        public ApiResponse< Telefone > SalvarUsingPOST1WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of Telefone</returns>
        public async System.Threading.Tasks.Task<Telefone> SalvarUsingPOST1Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<Telefone> localVarResponse = await SalvarUsingPOST1AsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Telefone>> SalvarUsingPOST1AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }
        
    }
    
}
