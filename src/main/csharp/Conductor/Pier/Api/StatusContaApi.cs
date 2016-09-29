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
    public interface IStatusContaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>StatusConta</returns>
        StatusConta ConsultarUsingGET2 (long? idStatusConta);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>ApiResponse of StatusConta</returns>
        ApiResponse<StatusConta> ConsultarUsingGET2WithHttpInfo (long? idStatusConta);
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>PageStatusContas</returns>
        PageStatusContas ListarUsingGET2 (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of PageStatusContas</returns>
        ApiResponse<PageStatusContas> ListarUsingGET2WithHttpInfo (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of StatusConta</returns>
        System.Threading.Tasks.Task<StatusConta> ConsultarUsingGET2Async (long? idStatusConta);

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of ApiResponse (StatusConta)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusConta>> ConsultarUsingGET2AsyncWithHttpInfo (long? idStatusConta);
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageStatusContas</returns>
        System.Threading.Tasks.Task<PageStatusContas> ListarUsingGET2Async (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContas)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContas>> ListarUsingGET2AsyncWithHttpInfo (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatusContaApi : IStatusContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusContaApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param> 
        /// <returns>StatusConta</returns>
        public StatusConta ConsultarUsingGET2 (long? idStatusConta)
        {
             ApiResponse<StatusConta> localVarResponse = ConsultarUsingGET2WithHttpInfo(idStatusConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param> 
        /// <returns>ApiResponse of StatusConta</returns>
        public ApiResponse< StatusConta > ConsultarUsingGET2WithHttpInfo (long? idStatusConta)
        {
            
            // verify the required parameter 'idStatusConta' is set
            if (idStatusConta == null)
                throw new ApiException(400, "Missing required parameter 'idStatusConta' when calling StatusContaApi->ConsultarUsingGET2");
            
    
            var localVarPath = "/api/status-contas/{id_status_conta}";
    
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
            if (idStatusConta != null) localVarPathParams.Add("id_status_conta", Configuration.ApiClient.ParameterToString(idStatusConta)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusConta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusConta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusConta)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of StatusConta</returns>
        public async System.Threading.Tasks.Task<StatusConta> ConsultarUsingGET2Async (long? idStatusConta)
        {
             ApiResponse<StatusConta> localVarResponse = await ConsultarUsingGET2AsyncWithHttpInfo(idStatusConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Conta Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status Conta a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</param>
        /// <returns>Task of ApiResponse (StatusConta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusConta>> ConsultarUsingGET2AsyncWithHttpInfo (long? idStatusConta)
        {
            // verify the required parameter 'idStatusConta' is set
            if (idStatusConta == null) throw new ApiException(400, "Missing required parameter 'idStatusConta' when calling ConsultarUsingGET2");
            
    
            var localVarPath = "/api/status-contas/{id_status_conta}";
    
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
            if (idStatusConta != null) localVarPathParams.Add("id_status_conta", Configuration.ApiClient.ParameterToString(idStatusConta)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusConta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusConta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusConta)));
            
        }
        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param> 
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>PageStatusContas</returns>
        public PageStatusContas ListarUsingGET2 (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageStatusContas> localVarResponse = ListarUsingGET2WithHttpInfo(id, nome, flagAlteraLimite, mensagemConsultaNegada, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param> 
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param> 
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of PageStatusContas</returns>
        public ApiResponse< PageStatusContas > ListarUsingGET2WithHttpInfo (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraLimite != null) localVarQueryParams.Add("flagAlteraLimite", Configuration.ApiClient.ParameterToString(flagAlteraLimite)); // query parameter
            if (mensagemConsultaNegada != null) localVarQueryParams.Add("mensagemConsultaNegada", Configuration.ApiClient.ParameterToString(mensagemConsultaNegada)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContas)));
            
        }

        
        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of PageStatusContas</returns>
        public async System.Threading.Tasks.Task<PageStatusContas> ListarUsingGET2Async (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageStatusContas> localVarResponse = await ListarUsingGET2AsyncWithHttpInfo(id, nome, flagAlteraLimite, mensagemConsultaNegada, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Status Contas cadastrados para o Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Status Contas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (optional)</param>
        /// <param name="flagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (optional)</param>
        /// <param name="mensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContas)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContas>> ListarUsingGET2AsyncWithHttpInfo (long? id = null, string nome = null, int? flagAlteraLimite = null, string mensagemConsultaNegada = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraLimite != null) localVarQueryParams.Add("flagAlteraLimite", Configuration.ApiClient.ParameterToString(flagAlteraLimite)); // query parameter
            if (mensagemConsultaNegada != null) localVarQueryParams.Add("mensagemConsultaNegada", Configuration.ApiClient.ParameterToString(mensagemConsultaNegada)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContas)));
            
        }
        
    }
    
}
