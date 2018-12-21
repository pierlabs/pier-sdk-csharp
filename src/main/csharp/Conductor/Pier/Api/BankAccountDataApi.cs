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
    public interface IBankAccountDataApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update a bank account data
        /// </summary>
        /// <remarks>
        /// This feature allows you to change bank details for an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>DadosBancariosContaResponse</returns>
        DadosBancariosContaResponse Alterar (long? id, DadosBancariosContaUpdate update);
  
        /// <summary>
        /// Update a bank account data
        /// </summary>
        /// <remarks>
        /// This feature allows you to change bank details for an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        ApiResponse<DadosBancariosContaResponse> AlterarWithHttpInfo (long? id, DadosBancariosContaUpdate update);
        
        /// <summary>
        /// Displays data for a particular type of bank account
        /// </summary>
        /// <remarks>
        /// This method allows you to query data of a certain type of bank account from its id (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param>
        /// <returns>CdtTipoContaBancaria</returns>
        CdtTipoContaBancaria Consultar (long? id);
  
        /// <summary>
        /// Displays data for a particular type of bank account
        /// </summary>
        /// <remarks>
        /// This method allows you to query data of a certain type of bank account from its id (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param>
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        ApiResponse<CdtTipoContaBancaria> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Show bank data of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param>
        /// <returns>DadosBancariosContaResponse</returns>
        DadosBancariosContaResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Show bank data of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param>
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        ApiResponse<DadosBancariosContaResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Show bank data using the reported filters
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data using the reported filters
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="codigoBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Account number (optional)</param>
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param>
        /// <returns>PageDadosBancariosContaResponse</returns>
        PageDadosBancariosContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);
  
        /// <summary>
        /// Show bank data using the reported filters
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data using the reported filters
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="codigoBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Account number (optional)</param>
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param>
        /// <returns>ApiResponse of PageDadosBancariosContaResponse</returns>
        ApiResponse<PageDadosBancariosContaResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);
        
        /// <summary>
        /// Lists the types of bank accounts
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of bank accounts available
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of bank account type (optional)</param>
        /// <returns>CdtTipoContaBancaria</returns>
        CdtTipoContaBancaria Listar_0 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
  
        /// <summary>
        /// Lists the types of bank accounts
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of bank accounts available
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of bank account type (optional)</param>
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        ApiResponse<CdtTipoContaBancaria> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Creates a bank account data
        /// </summary>
        /// <remarks>
        /// This resource allows associating bank data to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>DadosBancariosContaResponse</returns>
        DadosBancariosContaResponse Salvar (DadosBancariosContaPersist dadosBancariosContaPersist);
  
        /// <summary>
        /// Creates a bank account data
        /// </summary>
        /// <remarks>
        /// This resource allows associating bank data to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        ApiResponse<DadosBancariosContaResponse> SalvarWithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update a bank account data
        /// </summary>
        /// <remarks>
        /// This feature allows you to change bank details for an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<DadosBancariosContaResponse> AlterarAsync (long? id, DadosBancariosContaUpdate update);

        /// <summary>
        /// Update a bank account data
        /// </summary>
        /// <remarks>
        /// This feature allows you to change bank details for an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> AlterarAsyncWithHttpInfo (long? id, DadosBancariosContaUpdate update);
        
        /// <summary>
        /// Displays data for a particular type of bank account
        /// </summary>
        /// <remarks>
        /// This method allows you to query data of a certain type of bank account from its id (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        System.Threading.Tasks.Task<CdtTipoContaBancaria> ConsultarAsync (long? id);

        /// <summary>
        /// Displays data for a particular type of bank account
        /// </summary>
        /// <remarks>
        /// This method allows you to query data of a certain type of bank account from its id (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Show bank data of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<DadosBancariosContaResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Show bank data of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Show bank data using the reported filters
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data using the reported filters
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="codigoBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Account number (optional)</param>
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param>
        /// <returns>Task of PageDadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<PageDadosBancariosContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);

        /// <summary>
        /// Show bank data using the reported filters
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve bank data using the reported filters
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="codigoBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Account number (optional)</param>
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param>
        /// <returns>Task of ApiResponse (PageDadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDadosBancariosContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);
        
        /// <summary>
        /// Lists the types of bank accounts
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of bank accounts available
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of bank account type (optional)</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        System.Threading.Tasks.Task<CdtTipoContaBancaria> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);

        /// <summary>
        /// Lists the types of bank accounts
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of bank accounts available
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of bank account type (optional)</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Creates a bank account data
        /// </summary>
        /// <remarks>
        /// This resource allows associating bank data to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<DadosBancariosContaResponse> SalvarAsync (DadosBancariosContaPersist dadosBancariosContaPersist);

        /// <summary>
        /// Creates a bank account data
        /// </summary>
        /// <remarks>
        /// This resource allows associating bank data to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> SalvarAsyncWithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BankAccountDataApi : IBankAccountDataApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BankAccountDataApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountDataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BankAccountDataApi(Configuration configuration = null)
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
        /// Update a bank account data This feature allows you to change bank details for an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="update">update</param> 
        /// <returns>DadosBancariosContaResponse</returns>
        public DadosBancariosContaResponse Alterar (long? id, DadosBancariosContaUpdate update)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = AlterarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a bank account data This feature allows you to change bank details for an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        public ApiResponse< DadosBancariosContaResponse > AlterarWithHttpInfo (long? id, DadosBancariosContaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BankAccountDataApi->Alterar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling BankAccountDataApi->Alterar");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// Update a bank account data This feature allows you to change bank details for an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<DadosBancariosContaResponse> AlterarAsync (long? id, DadosBancariosContaUpdate update)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a bank account data This feature allows you to change bank details for an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> AlterarAsyncWithHttpInfo (long? id, DadosBancariosContaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Alterar");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }
        
        /// <summary>
        /// Displays data for a particular type of bank account This method allows you to query data of a certain type of bank account from its id (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param> 
        /// <returns>CdtTipoContaBancaria</returns>
        public CdtTipoContaBancaria Consultar (long? id)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Displays data for a particular type of bank account This method allows you to query data of a certain type of bank account from its id (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param> 
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        public ApiResponse< CdtTipoContaBancaria > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BankAccountDataApi->Consultar");
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }

        
        /// <summary>
        /// Displays data for a particular type of bank account This method allows you to query data of a certain type of bank account from its id (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        public async System.Threading.Tasks.Task<CdtTipoContaBancaria> ConsultarAsync (long? id)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Displays data for a particular type of bank account This method allows you to query data of a certain type of bank account from its id (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account type (id)</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }
        
        /// <summary>
        /// Show bank data of a determined account This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param> 
        /// <returns>DadosBancariosContaResponse</returns>
        public DadosBancariosContaResponse Consultar_0 (long? id)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show bank data of a determined account This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param> 
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        public ApiResponse< DadosBancariosContaResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BankAccountDataApi->Consultar_0");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// Show bank data of a determined account This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<DadosBancariosContaResponse> Consultar_0Async (long? id)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show bank data of a determined account This method allows to retrieve bank data of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the register bank account data (id)</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }
        
        /// <summary>
        /// Show bank data using the reported filters This method allows to retrieve bank data using the reported filters
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param> 
        /// <param name="idConta">Identification Code of the account (id) (optional)</param> 
        /// <param name="codigoBanco">Bank number (optional)</param> 
        /// <param name="numeroAgencia">Agency number (optional)</param> 
        /// <param name="numeroContaCorrente">Account number (optional)</param> 
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param> 
        /// <returns>PageDadosBancariosContaResponse</returns>
        public PageDadosBancariosContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
             ApiResponse<PageDadosBancariosContaResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, id, idConta, codigoBanco, numeroAgencia, numeroContaCorrente, idTipoContaBancaria);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show bank data using the reported filters This method allows to retrieve bank data using the reported filters
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param> 
        /// <param name="idConta">Identification Code of the account (id) (optional)</param> 
        /// <param name="codigoBanco">Bank number (optional)</param> 
        /// <param name="numeroAgencia">Agency number (optional)</param> 
        /// <param name="numeroContaCorrente">Account number (optional)</param> 
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param> 
        /// <returns>ApiResponse of PageDadosBancariosContaResponse</returns>
        public ApiResponse< PageDadosBancariosContaResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (codigoBanco != null) localVarQueryParams.Add("codigoBanco", Configuration.ApiClient.ParameterToString(codigoBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (idTipoContaBancaria != null) localVarQueryParams.Add("idTipoContaBancaria", Configuration.ApiClient.ParameterToString(idTipoContaBancaria)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// Show bank data using the reported filters This method allows to retrieve bank data using the reported filters
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="codigoBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Account number (optional)</param>
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param>
        /// <returns>Task of PageDadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<PageDadosBancariosContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
             ApiResponse<PageDadosBancariosContaResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, id, idConta, codigoBanco, numeroAgencia, numeroContaCorrente, idTipoContaBancaria);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show bank data using the reported filters This method allows to retrieve bank data using the reported filters
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the register bank data (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="codigoBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Account number (optional)</param>
        /// <param name="idTipoContaBancaria">Identification Code of the register bank account type (id).  (optional)</param>
        /// <returns>Task of ApiResponse (PageDadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDadosBancariosContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (codigoBanco != null) localVarQueryParams.Add("codigoBanco", Configuration.ApiClient.ParameterToString(codigoBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (idTipoContaBancaria != null) localVarQueryParams.Add("idTipoContaBancaria", Configuration.ApiClient.ParameterToString(idTipoContaBancaria)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDadosBancariosContaResponse)));
            
        }
        
        /// <summary>
        /// Lists the types of bank accounts This feature allows you to list the types of bank accounts available
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Description of bank account type (optional)</param> 
        /// <returns>CdtTipoContaBancaria</returns>
        public CdtTipoContaBancaria Listar_0 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists the types of bank accounts This feature allows you to list the types of bank accounts available
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Description of bank account type (optional)</param> 
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        public ApiResponse< CdtTipoContaBancaria > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }

        
        /// <summary>
        /// Lists the types of bank accounts This feature allows you to list the types of bank accounts available
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of bank account type (optional)</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        public async System.Threading.Tasks.Task<CdtTipoContaBancaria> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists the types of bank accounts This feature allows you to list the types of bank accounts available
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of bank account type (optional)</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }
        
        /// <summary>
        /// Creates a bank account data This resource allows associating bank data to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param> 
        /// <returns>DadosBancariosContaResponse</returns>
        public DadosBancariosContaResponse Salvar (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = SalvarWithHttpInfo(dadosBancariosContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a bank account data This resource allows associating bank data to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param> 
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        public ApiResponse< DadosBancariosContaResponse > SalvarWithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
            
            // verify the required parameter 'dadosBancariosContaPersist' is set
            if (dadosBancariosContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'dadosBancariosContaPersist' when calling BankAccountDataApi->Salvar");
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            
            
            
            
            if (dadosBancariosContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dadosBancariosContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dadosBancariosContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// Creates a bank account data This resource allows associating bank data to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<DadosBancariosContaResponse> SalvarAsync (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = await SalvarAsyncWithHttpInfo(dadosBancariosContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a bank account data This resource allows associating bank data to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> SalvarAsyncWithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
            // verify the required parameter 'dadosBancariosContaPersist' is set
            if (dadosBancariosContaPersist == null) throw new ApiException(400, "Missing required parameter 'dadosBancariosContaPersist' when calling Salvar");
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            
            
            
            
            if (dadosBancariosContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dadosBancariosContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dadosBancariosContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }
        
    }
    
}
