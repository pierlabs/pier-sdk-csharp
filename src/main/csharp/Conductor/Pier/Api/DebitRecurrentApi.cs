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
    public interface IDebitRecurrentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Join to the recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        ContaDebitoRecorrenteResponse AderirDebitoRecorrente (DebitAccountRecurrent contaDebitoRecorrentePersist);
  
        /// <summary>
        /// Join to the recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        ApiResponse<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteWithHttpInfo (DebitAccountRecurrent contaDebitoRecorrentePersist);
        
        /// <summary>
        /// Cancel recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows to calcel a recurrent debitt type of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        ContaDebitoRecorrenteResponse CancelarDebitoRecorrente (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist);
  
        /// <summary>
        /// Cancel recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows to calcel a recurrent debitt type of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        ApiResponse<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteWithHttpInfo (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist);
        
        /// <summary>
        /// List the debits recurrent of an account
        /// </summary>
        /// <remarks>
        /// The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>PageContaDebitoRecorrenteResponse</returns>
        PageContaDebitoRecorrenteResponse Listar (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
  
        /// <summary>
        /// List the debits recurrent of an account
        /// </summary>
        /// <remarks>
        /// The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>ApiResponse of PageContaDebitoRecorrenteResponse</returns>
        ApiResponse<PageContaDebitoRecorrenteResponse> ListarWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// List the types of Recurring Debits
        /// </summary>
        /// <remarks>
        /// For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param>
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param>
        /// <param name="valor">Value of the type of recurrent debit (optional)</param>
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param>
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        PageTipoDebitoRecorrenteResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
  
        /// <summary>
        /// List the types of Recurring Debits
        /// </summary>
        /// <remarks>
        /// For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param>
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param>
        /// <param name="valor">Value of the type of recurrent debit (optional)</param>
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param>
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        ApiResponse<PageTipoDebitoRecorrenteResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Join to the recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteAsync (DebitAccountRecurrent contaDebitoRecorrentePersist);

        /// <summary>
        /// Join to the recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> AderirDebitoRecorrenteAsyncWithHttpInfo (DebitAccountRecurrent contaDebitoRecorrentePersist);
        
        /// <summary>
        /// Cancel recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows to calcel a recurrent debitt type of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteAsync (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist);

        /// <summary>
        /// Cancel recurrent debit
        /// </summary>
        /// <remarks>
        /// This method allows to calcel a recurrent debitt type of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> CancelarDebitoRecorrenteAsyncWithHttpInfo (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist);
        
        /// <summary>
        /// List the debits recurrent of an account
        /// </summary>
        /// <remarks>
        /// The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of PageContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageContaDebitoRecorrenteResponse> ListarAsync (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);

        /// <summary>
        /// List the debits recurrent of an account
        /// </summary>
        /// <remarks>
        /// The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDebitoRecorrenteResponse>> ListarAsyncWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// List the types of Recurring Debits
        /// </summary>
        /// <remarks>
        /// For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param>
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param>
        /// <param name="valor">Value of the type of recurrent debit (optional)</param>
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);

        /// <summary>
        /// List the types of Recurring Debits
        /// </summary>
        /// <remarks>
        /// For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param>
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param>
        /// <param name="valor">Value of the type of recurrent debit (optional)</param>
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DebitRecurrentApi : IDebitRecurrentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitRecurrentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DebitRecurrentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitRecurrentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DebitRecurrentApi(Configuration configuration = null)
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
        /// Join to the recurrent debit This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        public ContaDebitoRecorrenteResponse AderirDebitoRecorrente (DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = AderirDebitoRecorrenteWithHttpInfo(contaDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join to the recurrent debit This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        public ApiResponse< ContaDebitoRecorrenteResponse > AderirDebitoRecorrenteWithHttpInfo (DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling DebitRecurrentApi->AderirDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Join to the recurrent debit This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteAsync (DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = await AderirDebitoRecorrenteAsyncWithHttpInfo(contaDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join to the recurrent debit This method allows that a determined recurrent debit type be added to a determined account, in order for the same to be charged in the invoice of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> AderirDebitoRecorrenteAsyncWithHttpInfo (DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling AderirDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// Cancel recurrent debit This method allows to calcel a recurrent debitt type of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param> 
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        public ContaDebitoRecorrenteResponse CancelarDebitoRecorrente (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = CancelarDebitoRecorrenteWithHttpInfo(id, contaDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel recurrent debit This method allows to calcel a recurrent debitt type of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param> 
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        public ApiResponse< ContaDebitoRecorrenteResponse > CancelarDebitoRecorrenteWithHttpInfo (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebitRecurrentApi->CancelarDebitoRecorrente");
            
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling DebitRecurrentApi->CancelarDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes/{id}/cancelar";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// Cancel recurrent debit This method allows to calcel a recurrent debitt type of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteAsync (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = await CancelarDebitoRecorrenteAsyncWithHttpInfo(id, contaDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel recurrent debit This method allows to calcel a recurrent debitt type of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Indentification Code of the Recurrent Debit (id)</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> CancelarDebitoRecorrenteAsyncWithHttpInfo (long? id, DebitAccountRecurrent contaDebitoRecorrentePersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarDebitoRecorrente");
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling CancelarDebitoRecorrente");
            
    
            var localVarPath = "/api/debitos-recorrentes/{id}/cancelar";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// List the debits recurrent of an account The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param> 
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <returns>PageContaDebitoRecorrenteResponse</returns>
        public PageContaDebitoRecorrenteResponse Listar (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageContaDebitoRecorrenteResponse> localVarResponse = ListarWithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the debits recurrent of an account The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param> 
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param> 
        /// <returns>ApiResponse of PageContaDebitoRecorrenteResponse</returns>
        public ApiResponse< PageContaDebitoRecorrenteResponse > ListarWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// List the debits recurrent of an account The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of PageContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDebitoRecorrenteResponse> ListarAsync (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageContaDebitoRecorrenteResponse> localVarResponse = await ListarAsyncWithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the debits recurrent of an account The entity Recurrent Debit lead with the hired registers for a determined client (idAccount) where the collection it&#39;s continuos, consisting in a signature ou payment of monthly debts. it means that, hile the service keep working, the client must continue doing the payments. The determination of how long it will last it&#39;s done in contract. Most part of the time, it exists a minimum period and, in case of the service be cancelled or the payment was not done, the status of the Recurrent Debit will have the ActiveFlag with a false value. Thus, this method lists all the operations of the Recurrent Debits of a determined idAccount, it is active or not
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idTipoDebitoRecorrente">Identification Code of the type recurrent debit (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataHoraInicio">Date and local time the beginning of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="dataHoraFim">Date and local time the eding of the recurrent debit yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <param name="ativo">Identify if the recurrent debit is active (optional)</param>
        /// <param name="dataHoraUltimoPagamento">Date and local time the last effected payment yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDebitoRecorrenteResponse>> ListarAsyncWithHttpInfo (long? idConta = null, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// List the types of Recurring Debits For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param> 
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param> 
        /// <param name="valor">Value of the type of recurrent debit (optional)</param> 
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param> 
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        public PageTipoDebitoRecorrenteResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the types of Recurring Debits For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param> 
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param> 
        /// <param name="valor">Value of the type of recurrent debit (optional)</param> 
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param> 
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        public ApiResponse< PageTipoDebitoRecorrenteResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// List the types of Recurring Debits For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param>
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param>
        /// <param name="valor">Value of the type of recurrent debit (optional)</param>
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the types of Recurring Debits For the Issuers that use the entity Recurring Debits need previously to resquest to Conductor a register of which types they can be able to commercialize.  For this, this resource has as an aim to present all the Types of Recurring Debits that are registered for a determined Issuer, independently of its status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the type of recurrent debit (id) (optional)</param>
        /// <param name="descricao">Description of the type of recurrent debit (optional)</param>
        /// <param name="valor">Value of the type of recurrent debit (optional)</param>
        /// <param name="flagAtivo">Flag that identifies if the type of recurrent debit is active (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }
        
    }
    
}
