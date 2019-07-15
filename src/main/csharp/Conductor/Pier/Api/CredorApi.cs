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
    public interface ICredorApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar credor
        /// </summary>
        /// <remarks>
        /// Permite a altera\u00E7\u00E3o de dados de um credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse AlterarCredor (long? id, CredorUpdate request, string login = null);
  
        /// <summary>
        /// Alterar credor
        /// </summary>
        /// <remarks>
        /// Permite a altera\u00E7\u00E3o de dados de um credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> AlterarCredorWithHttpInfo (long? id, CredorUpdate request, string login = null);
        
        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Permite a consulta de um credor a partir de seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>CredorResponse</returns>
        CredorResponse ConsultarCredor (long? id);
  
        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Permite a consulta de um credor a partir de seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> ConsultarCredorWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Permite listar, filtrar ou ordenar credores
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do credor (optional)</param>
        /// <param name="nomeCredor">Nome do redor (optional)</param>
        /// <param name="banco">Banco do credor (optional)</param>
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param>
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param>
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param>
        /// <param name="credorBanco">Flag de controle interno (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param>
        /// <returns>PageCredorResponse</returns>
        PageCredorResponse ListarCredores (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
  
        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Permite listar, filtrar ou ordenar credores
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do credor (optional)</param>
        /// <param name="nomeCredor">Nome do redor (optional)</param>
        /// <param name="banco">Banco do credor (optional)</param>
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param>
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param>
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param>
        /// <param name="credorBanco">Flag de controle interno (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param>
        /// <returns>ApiResponse of PageCredorResponse</returns>
        ApiResponse<PageCredorResponse> ListarCredoresWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
        
        /// <summary>
        /// Salvar credor
        /// </summary>
        /// <remarks>
        /// Permite a persist\u00EAncias de um novo credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse SalvarCredor (CredorPersist credorPersist, string login = null);
  
        /// <summary>
        /// Salvar credor
        /// </summary>
        /// <remarks>
        /// Permite a persist\u00EAncias de um novo credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> SalvarCredorWithHttpInfo (CredorPersist credorPersist, string login = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar credor
        /// </summary>
        /// <remarks>
        /// Permite a altera\u00E7\u00E3o de dados de um credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> AlterarCredorAsync (long? id, CredorUpdate request, string login = null);

        /// <summary>
        /// Alterar credor
        /// </summary>
        /// <remarks>
        /// Permite a altera\u00E7\u00E3o de dados de um credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarCredorAsyncWithHttpInfo (long? id, CredorUpdate request, string login = null);
        
        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Permite a consulta de um credor a partir de seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> ConsultarCredorAsync (long? id);

        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Permite a consulta de um credor a partir de seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarCredorAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Permite listar, filtrar ou ordenar credores
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do credor (optional)</param>
        /// <param name="nomeCredor">Nome do redor (optional)</param>
        /// <param name="banco">Banco do credor (optional)</param>
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param>
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param>
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param>
        /// <param name="credorBanco">Flag de controle interno (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param>
        /// <returns>Task of PageCredorResponse</returns>
        System.Threading.Tasks.Task<PageCredorResponse> ListarCredoresAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);

        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Permite listar, filtrar ou ordenar credores
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do credor (optional)</param>
        /// <param name="nomeCredor">Nome do redor (optional)</param>
        /// <param name="banco">Banco do credor (optional)</param>
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param>
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param>
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param>
        /// <param name="credorBanco">Flag de controle interno (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param>
        /// <returns>Task of ApiResponse (PageCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCredorResponse>> ListarCredoresAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
        
        /// <summary>
        /// Salvar credor
        /// </summary>
        /// <remarks>
        /// Permite a persist\u00EAncias de um novo credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> SalvarCredorAsync (CredorPersist credorPersist, string login = null);

        /// <summary>
        /// Salvar credor
        /// </summary>
        /// <remarks>
        /// Permite a persist\u00EAncias de um novo credor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> SalvarCredorAsyncWithHttpInfo (CredorPersist credorPersist, string login = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CredorApi : ICredorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CredorApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CredorApi(Configuration configuration = null)
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
        /// Alterar credor Permite a altera\u00E7\u00E3o de dados de um credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse AlterarCredor (long? id, CredorUpdate request, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = AlterarCredorWithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar credor Permite a altera\u00E7\u00E3o de dados de um credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > AlterarCredorWithHttpInfo (long? id, CredorUpdate request, string login = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CredorApi->AlterarCredor");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling CredorApi->AlterarCredor");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// Alterar credor Permite a altera\u00E7\u00E3o de dados de um credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> AlterarCredorAsync (long? id, CredorUpdate request, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await AlterarCredorAsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar credor Permite a altera\u00E7\u00E3o de dados de um credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarCredorAsyncWithHttpInfo (long? id, CredorUpdate request, string login = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarCredor");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarCredor");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Consultar credor Permite a consulta de um credor a partir de seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse ConsultarCredor (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = ConsultarCredorWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar credor Permite a consulta de um credor a partir de seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > ConsultarCredorWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CredorApi->ConsultarCredor");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// Consultar credor Permite a consulta de um credor a partir de seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> ConsultarCredorAsync (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = await ConsultarCredorAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar credor Permite a consulta de um credor a partir de seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarCredorAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCredor");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Listar credores Permite listar, filtrar ou ordenar credores
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identificador do credor (optional)</param> 
        /// <param name="nomeCredor">Nome do redor (optional)</param> 
        /// <param name="banco">Banco do credor (optional)</param> 
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param> 
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param> 
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param> 
        /// <param name="credorBanco">Flag de controle interno (optional)</param> 
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param> 
        /// <returns>PageCredorResponse</returns>
        public PageCredorResponse ListarCredores (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
             ApiResponse<PageCredorResponse> localVarResponse = ListarCredoresWithHttpInfo(sort, page, limit, id, nomeCredor, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, credorBanco, idPessoaJuridica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar credores Permite listar, filtrar ou ordenar credores
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identificador do credor (optional)</param> 
        /// <param name="nomeCredor">Nome do redor (optional)</param> 
        /// <param name="banco">Banco do credor (optional)</param> 
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param> 
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param> 
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param> 
        /// <param name="credorBanco">Flag de controle interno (optional)</param> 
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param> 
        /// <returns>ApiResponse of PageCredorResponse</returns>
        public ApiResponse< PageCredorResponse > ListarCredoresWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
            
    
            var localVarPath = "/api/credores";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (credorBanco != null) localVarQueryParams.Add("credorBanco", Configuration.ApiClient.ParameterToString(credorBanco)); // query parameter
            if (idPessoaJuridica != null) localVarQueryParams.Add("idPessoaJuridica", Configuration.ApiClient.ParameterToString(idPessoaJuridica)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredores: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredores: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCredorResponse)));
            
        }

        
        /// <summary>
        /// Listar credores Permite listar, filtrar ou ordenar credores
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do credor (optional)</param>
        /// <param name="nomeCredor">Nome do redor (optional)</param>
        /// <param name="banco">Banco do credor (optional)</param>
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param>
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param>
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param>
        /// <param name="credorBanco">Flag de controle interno (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param>
        /// <returns>Task of PageCredorResponse</returns>
        public async System.Threading.Tasks.Task<PageCredorResponse> ListarCredoresAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
             ApiResponse<PageCredorResponse> localVarResponse = await ListarCredoresAsyncWithHttpInfo(sort, page, limit, id, nomeCredor, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, credorBanco, idPessoaJuridica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar credores Permite listar, filtrar ou ordenar credores
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do credor (optional)</param>
        /// <param name="nomeCredor">Nome do redor (optional)</param>
        /// <param name="banco">Banco do credor (optional)</param>
        /// <param name="agencia">Ag\u00EAncia do credor (optional)</param>
        /// <param name="digitoAgencia">Digito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente do credor (optional)</param>
        /// <param name="digitoContaCorrente">Digito da conta corrente (optional)</param>
        /// <param name="credorBanco">Flag de controle interno (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (optional)</param>
        /// <returns>Task of ApiResponse (PageCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCredorResponse>> ListarCredoresAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
            
    
            var localVarPath = "/api/credores";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (credorBanco != null) localVarQueryParams.Add("credorBanco", Configuration.ApiClient.ParameterToString(credorBanco)); // query parameter
            if (idPessoaJuridica != null) localVarQueryParams.Add("idPessoaJuridica", Configuration.ApiClient.ParameterToString(idPessoaJuridica)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredores: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredores: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCredorResponse)));
            
        }
        
        /// <summary>
        /// Salvar credor Permite a persist\u00EAncias de um novo credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse SalvarCredor (CredorPersist credorPersist, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = SalvarCredorWithHttpInfo(credorPersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar credor Permite a persist\u00EAncias de um novo credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > SalvarCredorWithHttpInfo (CredorPersist credorPersist, string login = null)
        {
            
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null)
                throw new ApiException(400, "Missing required parameter 'credorPersist' when calling CredorApi->SalvarCredor");
            
    
            var localVarPath = "/api/credores";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (credorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// Salvar credor Permite a persist\u00EAncias de um novo credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> SalvarCredorAsync (CredorPersist credorPersist, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await SalvarCredorAsyncWithHttpInfo(credorPersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar credor Permite a persist\u00EAncias de um novo credor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> SalvarCredorAsyncWithHttpInfo (CredorPersist credorPersist, string login = null)
        {
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null) throw new ApiException(400, "Missing required parameter 'credorPersist' when calling SalvarCredor");
            
    
            var localVarPath = "/api/credores";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (credorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
    }
    
}
