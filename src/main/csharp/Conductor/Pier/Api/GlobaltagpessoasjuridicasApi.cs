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
    public interface IGlobaltagpessoasjuridicasApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse AlterarUsingPUT15 (long? id, PessoaJuridicaUpdate request, string login = null);
  
        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> AlterarUsingPUT15WithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null);
        
        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse ConsultarUsingGET30 (long? id);
  
        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> ConsultarUsingGET30WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param>
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param>
        /// <returns>PagePessoaJuridicaResponse</returns>
        PagePessoaJuridicaResponse ListarUsingGET34 (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
  
        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param>
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        ApiResponse<PagePessoaJuridicaResponse> ListarUsingGET34WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
        
        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse SalvarUsingPOST23 (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
  
        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> SalvarUsingPOST23WithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> AlterarUsingPUT15Async (long? id, PessoaJuridicaUpdate request, string login = null);

        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null);
        
        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> ConsultarUsingGET30Async (long? id);

        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> ConsultarUsingGET30AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param>
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarUsingGET34Async (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);

        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param>
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarUsingGET34AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
        
        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> SalvarUsingPOST23Async (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);

        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_juridica_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> SalvarUsingPOST23AsyncWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagpessoasjuridicasApi : IGlobaltagpessoasjuridicasApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagpessoasjuridicasApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagpessoasjuridicasApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagpessoasjuridicasApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagpessoasjuridicasApi(Configuration configuration = null)
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
        /// {{{pessoa_juridica_resource_alterar}}} {{{pessoa_juridica_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse AlterarUsingPUT15 (long? id, PessoaJuridicaUpdate request, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = AlterarUsingPUT15WithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}} {{{pessoa_juridica_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > AlterarUsingPUT15WithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpessoasjuridicasApi->AlterarUsingPUT15");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagpessoasjuridicasApi->AlterarUsingPUT15");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}} {{{pessoa_juridica_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> AlterarUsingPUT15Async (long? id, PessoaJuridicaUpdate request, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await AlterarUsingPUT15AsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_juridica_resource_alterar}}} {{{pessoa_juridica_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT15");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarUsingPUT15");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}} {{{pessoa_juridica_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse ConsultarUsingGET30 (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = ConsultarUsingGET30WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}} {{{pessoa_juridica_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > ConsultarUsingGET30WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpessoasjuridicasApi->ConsultarUsingGET30");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}} {{{pessoa_juridica_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> ConsultarUsingGET30Async (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await ConsultarUsingGET30AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_juridica_resource_consultar}}} {{{pessoa_juridica_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_juridica_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> ConsultarUsingGET30AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET30");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET30: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}} {{{pessoa_juridica_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param> 
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param> 
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param> 
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param> 
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param> 
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param> 
        /// <returns>PagePessoaJuridicaResponse</returns>
        public PagePessoaJuridicaResponse ListarUsingGET34 (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = ListarUsingGET34WithHttpInfo(sort, page, limit, contato, razaoSocial, numeroReceitaFederal, inscricaoEstadual, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}} {{{pessoa_juridica_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param> 
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param> 
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param> 
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param> 
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param> 
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        public ApiResponse< PagePessoaJuridicaResponse > ListarUsingGET34WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}} {{{pessoa_juridica_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param>
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarUsingGET34Async (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = await ListarUsingGET34AsyncWithHttpInfo(sort, page, limit, contato, razaoSocial, numeroReceitaFederal, inscricaoEstadual, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_juridica_resource_listar}}} {{{pessoa_juridica_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="contato">{{{pessoa_juridica_request_contato_value}}} (optional)</param>
        /// <param name="razaoSocial">{{{pessoa_juridica_request_razao_social_value}}} (optional)</param>
        /// <param name="numeroReceitaFederal">{{{pessoa_juridica_request_CGC_value}}} (optional)</param>
        /// <param name="inscricaoEstadual">{{{pessoa_juridica_request_inscricao_estadual_value}}} (optional)</param>
        /// <param name="banco">{{{pessoa_juridica_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{pessoa_juridica_request_agencia_value}}} (optional)</param>
        /// <param name="digitoAgencia">{{{pessoa_juridica_request_digito_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{pessoa_juridica_request_conta_corrente_value}}} (optional)</param>
        /// <param name="digitoContaCorrente">{{{pessoa_juridica_request_digito_conta_corrente_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarUsingGET34AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}} {{{pessoa_juridica_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse SalvarUsingPOST23 (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = SalvarUsingPOST23WithHttpInfo(pessoaJuridicaPersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}} {{{pessoa_juridica_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > SalvarUsingPOST23WithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
            
            // verify the required parameter 'pessoaJuridicaPersist' is set
            if (pessoaJuridicaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaJuridicaPersist' when calling GlobaltagpessoasjuridicasApi->SalvarUsingPOST23");
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            
            
            if (pessoaJuridicaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaJuridicaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaJuridicaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}} {{{pessoa_juridica_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> SalvarUsingPOST23Async (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await SalvarUsingPOST23AsyncWithHttpInfo(pessoaJuridicaPersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_juridica_resource_salvar}}} {{{pessoa_juridica_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> SalvarUsingPOST23AsyncWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
            // verify the required parameter 'pessoaJuridicaPersist' is set
            if (pessoaJuridicaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaJuridicaPersist' when calling SalvarUsingPOST23");
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            
            
            if (pessoaJuridicaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaJuridicaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaJuridicaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
    }
    
}
