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
    public interface IAdjustmentFinancingApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Throw an adjust for the account informed
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the accont of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="idConta">Identifier Code of the Account</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse AjustarConta (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Throw an adjust for the account informed
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the accont of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="idConta">Identifier Code of the Account</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> AjustarContaWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Present dates of a determined finacial adjustment
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse Consultar (long? id);
  
        /// <summary>
        /// Present dates of a determined finacial adjustment
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// List of existent adjustments in the database of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param>
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Adjustment Value (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idConta">Identifier Code of the Account (optional)</param>
        /// <returns>PageAjusteResponse</returns>
        PageAjusteResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
  
        /// <summary>
        /// List of existent adjustments in the database of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param>
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Adjustment Value (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idConta">Identifier Code of the Account (optional)</param>
        /// <returns>ApiResponse of PageAjusteResponse</returns>
        ApiResponse<PageAjusteResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Throw an adjust for the account informed
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the accont of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="idConta">Identifier Code of the Account</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaAsync (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);

        /// <summary>
        /// Throw an adjust for the account informed
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the accont of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="idConta">Identifier Code of the Account</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaAsyncWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Present dates of a determined finacial adjustment
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Present dates of a determined finacial adjustment
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List of existent adjustments in the database of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param>
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Adjustment Value (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idConta">Identifier Code of the Account (optional)</param>
        /// <returns>Task of PageAjusteResponse</returns>
        System.Threading.Tasks.Task<PageAjusteResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);

        /// <summary>
        /// List of existent adjustments in the database of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param>
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Adjustment Value (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idConta">Identifier Code of the Account (optional)</param>
        /// <returns>Task of ApiResponse (PageAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAjusteResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdjustmentFinancingApi : IAdjustmentFinancingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustmentFinancingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdjustmentFinancingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustmentFinancingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdjustmentFinancingApi(Configuration configuration = null)
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
        /// Throw an adjust for the account informed This resource insert an adjust for the accont of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param> 
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Value of the adjustment</param> 
        /// <param name="idConta">Identifier Code of the Account</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param> 
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param> 
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse AjustarConta (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = AjustarContaWithHttpInfo(idTipoAjuste, dataAjuste, valorAjuste, idConta, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Throw an adjust for the account informed This resource insert an adjust for the accont of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param> 
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Value of the adjustment</param> 
        /// <param name="idConta">Identifier Code of the Account</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param> 
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param> 
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > AjustarContaWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AdjustmentFinancingApi->AjustarConta");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AdjustmentFinancingApi->AjustarConta");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AdjustmentFinancingApi->AjustarConta");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AdjustmentFinancingApi->AjustarConta");
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Throw an adjust for the account informed This resource insert an adjust for the accont of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="idConta">Identifier Code of the Account</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaAsync (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await AjustarContaAsyncWithHttpInfo(idTipoAjuste, dataAjuste, valorAjuste, idConta, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Throw an adjust for the account informed This resource insert an adjust for the accont of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="idConta">Identifier Code of the Account</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idTransacaoOriginal">Identifier of the original transaction (reversal) (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaAsyncWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarConta");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarConta");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarConta");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AjustarConta");
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// Present dates of a determined finacial adjustment This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse Consultar (long? id)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Present dates of a determined finacial adjustment This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AdjustmentFinancingApi->Consultar");
            
    
            var localVarPath = "/api/ajustes-financeiros/{id}";
    
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
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Present dates of a determined finacial adjustment This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> ConsultarAsync (long? id)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Present dates of a determined finacial adjustment This method allows searching dates of a determined adjustment starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the adjustment (id)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/ajustes-financeiros/{id}";
    
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

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// List of existent adjustments in the database of the issuer This resource allows to list existent adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param> 
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param> 
        /// <param name="valorAjuste">Adjustment Value (optional)</param> 
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param> 
        /// <param name="idConta">Identifier Code of the Account (optional)</param> 
        /// <returns>PageAjusteResponse</returns>
        public PageAjusteResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
             ApiResponse<PageAjusteResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of existent adjustments in the database of the issuer This resource allows to list existent adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param> 
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param> 
        /// <param name="valorAjuste">Adjustment Value (optional)</param> 
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param> 
        /// <param name="idConta">Identifier Code of the Account (optional)</param> 
        /// <returns>ApiResponse of PageAjusteResponse</returns>
        public ApiResponse< PageAjusteResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAjusteResponse)));
            
        }

        
        /// <summary>
        /// List of existent adjustments in the database of the issuer This resource allows to list existent adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param>
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Adjustment Value (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idConta">Identifier Code of the Account (optional)</param>
        /// <returns>Task of PageAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageAjusteResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
             ApiResponse<PageAjusteResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of existent adjustments in the database of the issuer This resource allows to list existent adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">Identifier Code of the Adjustment Type (optional)</param>
        /// <param name="dataAjuste">Adjustment date in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Adjustment Value (optional)</param>
        /// <param name="identificadorExterno">Hexadecimal Code (optional)</param>
        /// <param name="idConta">Identifier Code of the Account (optional)</param>
        /// <returns>Task of ApiResponse (PageAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAjusteResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAjusteResponse)));
            
        }
        
    }
    
}
