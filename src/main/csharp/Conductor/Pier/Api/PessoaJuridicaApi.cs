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
    public interface IPessoaJuridicaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Alterar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse AlterarPessoaJuridica (long? id, PessoaJuridicaUpdate request, string login = null);
  
        /// <summary>
        /// Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Alterar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> AlterarPessoaJuridicaWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null);
        
        /// <summary>
        /// Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Consultar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse ConsultarPessoaJuridica (long? id);
  
        /// <summary>
        /// Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Consultar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> ConsultarPessoaJuridicaWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <remarks>
        /// Listar pessoas jur\u00EDdicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param>
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param>
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param>
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param>
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param>
        /// <returns>PagePessoaJuridicaResponse</returns>
        PagePessoaJuridicaResponse ListarPessoasJuridicas (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
  
        /// <summary>
        /// Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <remarks>
        /// Listar pessoas jur\u00EDdicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param>
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param>
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param>
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param>
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param>
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        ApiResponse<PagePessoaJuridicaResponse> ListarPessoasJuridicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
        
        /// <summary>
        /// Salva uma pessoa Juridica 
        /// </summary>
        /// <remarks>
        /// Salva uma pessoa Juridica 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse SalvarPessoaJuridica (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
  
        /// <summary>
        /// Salva uma pessoa Juridica 
        /// </summary>
        /// <remarks>
        /// Salva uma pessoa Juridica 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> SalvarPessoaJuridicaWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Alterar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> AlterarPessoaJuridicaAsync (long? id, PessoaJuridicaUpdate request, string login = null);

        /// <summary>
        /// Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Alterar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> AlterarPessoaJuridicaAsyncWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null);
        
        /// <summary>
        /// Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Consultar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> ConsultarPessoaJuridicaAsync (long? id);

        /// <summary>
        /// Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Consultar pessoa jur\u00EDdica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> ConsultarPessoaJuridicaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <remarks>
        /// Listar pessoas jur\u00EDdicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param>
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param>
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param>
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param>
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarPessoasJuridicasAsync (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);

        /// <summary>
        /// Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <remarks>
        /// Listar pessoas jur\u00EDdicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param>
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param>
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param>
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param>
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarPessoasJuridicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
        
        /// <summary>
        /// Salva uma pessoa Juridica 
        /// </summary>
        /// <remarks>
        /// Salva uma pessoa Juridica 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> SalvarPessoaJuridicaAsync (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);

        /// <summary>
        /// Salva uma pessoa Juridica 
        /// </summary>
        /// <remarks>
        /// Salva uma pessoa Juridica 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> SalvarPessoaJuridicaAsyncWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PessoaJuridicaApi : IPessoaJuridicaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PessoaJuridicaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PessoaJuridicaApi(Configuration configuration = null)
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
        /// Alterar pessoa jur\u00EDdica Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse AlterarPessoaJuridica (long? id, PessoaJuridicaUpdate request, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = AlterarPessoaJuridicaWithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar pessoa jur\u00EDdica Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > AlterarPessoaJuridicaWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PessoaJuridicaApi->AlterarPessoaJuridica");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PessoaJuridicaApi->AlterarPessoaJuridica");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaJuridica: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaJuridica: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Alterar pessoa jur\u00EDdica Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> AlterarPessoaJuridicaAsync (long? id, PessoaJuridicaUpdate request, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await AlterarPessoaJuridicaAsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar pessoa jur\u00EDdica Alterar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> AlterarPessoaJuridicaAsyncWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarPessoaJuridica");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarPessoaJuridica");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaJuridica: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaJuridica: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// Consultar pessoa jur\u00EDdica Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse ConsultarPessoaJuridica (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = ConsultarPessoaJuridicaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar pessoa jur\u00EDdica Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > ConsultarPessoaJuridicaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PessoaJuridicaApi->ConsultarPessoaJuridica");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaJuridica: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaJuridica: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Consultar pessoa jur\u00EDdica Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> ConsultarPessoaJuridicaAsync (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await ConsultarPessoaJuridicaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar pessoa jur\u00EDdica Consultar pessoa jur\u00EDdica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pessoa Juridica id</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> ConsultarPessoaJuridicaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPessoaJuridica");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaJuridica: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaJuridica: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// Listar pessoas jur\u00EDdicas Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param> 
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param> 
        /// <returns>PagePessoaJuridicaResponse</returns>
        public PagePessoaJuridicaResponse ListarPessoasJuridicas (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = ListarPessoasJuridicasWithHttpInfo(sort, page, limit, contato, razaoSocial, numeroReceitaFederal, inscricaoEstadual, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar pessoas jur\u00EDdicas Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param> 
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param> 
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        public ApiResponse< PagePessoaJuridicaResponse > ListarPessoasJuridicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasJuridicas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasJuridicas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Listar pessoas jur\u00EDdicas Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param>
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param>
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param>
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param>
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarPessoasJuridicasAsync (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = await ListarPessoasJuridicasAsyncWithHttpInfo(sort, page, limit, contato, razaoSocial, numeroReceitaFederal, inscricaoEstadual, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar pessoas jur\u00EDdicas Listar pessoas jur\u00EDdicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Contato da pessoa jur\u00EDdica (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social (optional)</param>
        /// <param name="numeroReceitaFederal">CGC(CNPJ) da pessoa jur\u00EDdica (optional)</param>
        /// <param name="inscricaoEstadual">Inscri\u00E7\u00E3o estadual da pessoa jur\u00EDdica (optional)</param>
        /// <param name="banco">Banco da pessoa jur\u00EDdica (optional)</param>
        /// <param name="agencia">Ag\u00EAncia da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito conta da conta corrente (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarPessoasJuridicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasJuridicas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasJuridicas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// Salva uma pessoa Juridica  Salva uma pessoa Juridica 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse SalvarPessoaJuridica (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = SalvarPessoaJuridicaWithHttpInfo(pessoaJuridicaPersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva uma pessoa Juridica  Salva uma pessoa Juridica 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > SalvarPessoaJuridicaWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
            
            // verify the required parameter 'pessoaJuridicaPersist' is set
            if (pessoaJuridicaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaJuridicaPersist' when calling PessoaJuridicaApi->SalvarPessoaJuridica");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridica: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridica: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Salva uma pessoa Juridica  Salva uma pessoa Juridica 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> SalvarPessoaJuridicaAsync (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await SalvarPessoaJuridicaAsyncWithHttpInfo(pessoaJuridicaPersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva uma pessoa Juridica  Salva uma pessoa Juridica 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> SalvarPessoaJuridicaAsyncWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
            // verify the required parameter 'pessoaJuridicaPersist' is set
            if (pessoaJuridicaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaJuridicaPersist' when calling SalvarPessoaJuridica");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridica: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridica: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
    }
    
}
