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
    public interface IFaturaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PagePlanoParcelamentoResponse</returns>
        PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFaturaUsingGET1 (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        ApiResponse<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaUsingGET1WithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaUsingGET1Async (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaUsingGET1AsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FaturaApi : IFaturaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FaturaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FaturaApi(Configuration configuration = null)
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
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PagePlanoParcelamentoResponse</returns>
        public PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFaturaUsingGET1 (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = ConsultarLancamentosFuturosFaturaUsingGET1WithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        public ApiResponse< PagePlanoParcelamentoResponse > ConsultarLancamentosFuturosFaturaUsingGET1WithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->ConsultarLancamentosFuturosFaturaUsingGET1");
            
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling FaturaApi->ConsultarLancamentosFuturosFaturaUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }

        
        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        public async System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaUsingGET1Async (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = await ConsultarLancamentosFuturosFaturaUsingGET1AsyncWithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00C3\u00A3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaUsingGET1AsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLancamentosFuturosFaturaUsingGET1");
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null) throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling ConsultarLancamentosFuturosFaturaUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }
        
    }
    
}
