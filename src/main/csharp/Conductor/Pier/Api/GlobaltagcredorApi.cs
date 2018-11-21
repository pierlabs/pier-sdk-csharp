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
    public interface IGlobaltagcredorApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{credor_resource_alterar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_alterar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse AlterarUsingPUT4 (long? id, CredorUpdate request, string login = null);
  
        /// <summary>
        /// {{{credor_resource_alterar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_alterar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> AlterarUsingPUT4WithHttpInfo (long? id, CredorUpdate request, string login = null);
        
        /// <summary>
        /// {{{credor_resource_consultar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_consultar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>CredorResponse</returns>
        CredorResponse ConsultarUsingGET14 (long? id);
  
        /// <summary>
        /// {{{credor_resource_consultar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_consultar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> ConsultarUsingGET14WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{credor_resource_listar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_listar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param>
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param>
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse ListarCredorUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
  
        /// <summary>
        /// {{{credor_resource_listar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_listar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param>
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param>
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> ListarCredorUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
        
        /// <summary>
        /// {{{credor_resource_salvar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_salvar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse SalvarUsingPOST9 (CredorPersist credorPersist, string login = null);
  
        /// <summary>
        /// {{{credor_resource_salvar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_salvar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> SalvarUsingPOST9WithHttpInfo (CredorPersist credorPersist, string login = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{credor_resource_alterar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_alterar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> AlterarUsingPUT4Async (long? id, CredorUpdate request, string login = null);

        /// <summary>
        /// {{{credor_resource_alterar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_alterar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, CredorUpdate request, string login = null);
        
        /// <summary>
        /// {{{credor_resource_consultar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_consultar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> ConsultarUsingGET14Async (long? id);

        /// <summary>
        /// {{{credor_resource_consultar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_consultar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarUsingGET14AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{credor_resource_listar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_listar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param>
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param>
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> ListarCredorUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);

        /// <summary>
        /// {{{credor_resource_listar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_listar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param>
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param>
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ListarCredorUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
        
        /// <summary>
        /// {{{credor_resource_salvar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_salvar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> SalvarUsingPOST9Async (CredorPersist credorPersist, string login = null);

        /// <summary>
        /// {{{credor_resource_salvar_credor}}}
        /// </summary>
        /// <remarks>
        /// {{{credor_resource_salvar_credor_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> SalvarUsingPOST9AsyncWithHttpInfo (CredorPersist credorPersist, string login = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagcredorApi : IGlobaltagcredorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcredorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagcredorApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcredorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagcredorApi(Configuration configuration = null)
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
        /// {{{credor_resource_alterar_credor}}} {{{credor_resource_alterar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse AlterarUsingPUT4 (long? id, CredorUpdate request, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = AlterarUsingPUT4WithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{credor_resource_alterar_credor}}} {{{credor_resource_alterar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > AlterarUsingPUT4WithHttpInfo (long? id, CredorUpdate request, string login = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcredorApi->AlterarUsingPUT4");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagcredorApi->AlterarUsingPUT4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// {{{credor_resource_alterar_credor}}} {{{credor_resource_alterar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> AlterarUsingPUT4Async (long? id, CredorUpdate request, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await AlterarUsingPUT4AsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{credor_resource_alterar_credor}}} {{{credor_resource_alterar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, CredorUpdate request, string login = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT4");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarUsingPUT4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// {{{credor_resource_consultar_credor}}} {{{credor_resource_consultar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse ConsultarUsingGET14 (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = ConsultarUsingGET14WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{credor_resource_consultar_credor}}} {{{credor_resource_consultar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > ConsultarUsingGET14WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcredorApi->ConsultarUsingGET14");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// {{{credor_resource_consultar_credor}}} {{{credor_resource_consultar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> ConsultarUsingGET14Async (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = await ConsultarUsingGET14AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{credor_resource_consultar_credor}}} {{{credor_resource_consultar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarUsingGET14AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET14");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// {{{credor_resource_listar_credor}}} {{{credor_resource_listar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param> 
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param> 
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param> 
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param> 
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param> 
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse ListarCredorUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
             ApiResponse<CredorResponse> localVarResponse = ListarCredorUsingGETWithHttpInfo(sort, page, limit, id, nomeCredor, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, credorBanco, idPessoaJuridica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{credor_resource_listar_credor}}} {{{credor_resource_listar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param> 
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param> 
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param> 
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param> 
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param> 
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > ListarCredorUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarCredorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// {{{credor_resource_listar_credor}}} {{{credor_resource_listar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param>
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param>
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> ListarCredorUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await ListarCredorUsingGETAsyncWithHttpInfo(sort, page, limit, id, nomeCredor, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, credorBanco, idPessoaJuridica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{credor_resource_listar_credor}}} {{{credor_resource_listar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{credor_request_id_value}}} (optional)</param>
        /// <param name="nomeCredor">{{{credor_request_nome_credor_value}}} (optional)</param>
        /// <param name="banco">{{{credor_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{credor_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{credor_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{credor_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{credor_request_digito_conta_corrente_value}}} (optional)</param>
        /// <param name="credorBanco">{{{credor_request_credor_banco_value}}} (optional)</param>
        /// <param name="idPessoaJuridica">{{{credor_request_id_pessoa_juridica_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ListarCredorUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarCredorUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredorUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// {{{credor_resource_salvar_credor}}} {{{credor_resource_salvar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse SalvarUsingPOST9 (CredorPersist credorPersist, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = SalvarUsingPOST9WithHttpInfo(credorPersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{credor_resource_salvar_credor}}} {{{credor_resource_salvar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > SalvarUsingPOST9WithHttpInfo (CredorPersist credorPersist, string login = null)
        {
            
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null)
                throw new ApiException(400, "Missing required parameter 'credorPersist' when calling GlobaltagcredorApi->SalvarUsingPOST9");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// {{{credor_resource_salvar_credor}}} {{{credor_resource_salvar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> SalvarUsingPOST9Async (CredorPersist credorPersist, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await SalvarUsingPOST9AsyncWithHttpInfo(credorPersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{credor_resource_salvar_credor}}} {{{credor_resource_salvar_credor_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> SalvarUsingPOST9AsyncWithHttpInfo (CredorPersist credorPersist, string login = null)
        {
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null) throw new ApiException(400, "Missing required parameter 'credorPersist' when calling SalvarUsingPOST9");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
    }
    
}
