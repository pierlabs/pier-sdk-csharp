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
    public interface ITravelNotificationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be searched an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse Consultar (long? id);
  
        /// <summary>
        /// Search a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be searched an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be disabled an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse Desabilitar (long? id);
  
        /// <summary>
        /// Disable a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be disabled an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> DesabilitarWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitate a travel notice accordding to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse Habilitar (long? id);
  
        /// <summary>
        /// Habilitate a travel notice accordding to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> HabilitarWithHttpInfo (long? id);
        
        /// <summary>
        /// List of travel notices created by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent travel notices in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param>
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param>
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param>
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param>
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param>
        /// <returns>PageAvisoViagemResponse</returns>
        PageAvisoViagemResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);
  
        /// <summary>
        /// List of travel notices created by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent travel notices in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param>
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param>
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param>
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param>
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param>
        /// <returns>ApiResponse of PageAvisoViagemResponse</returns>
        ApiResponse<PageAvisoViagemResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);
        
        /// <summary>
        /// Create the register of a new Travel Notice
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new Travel Notice in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param>
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param>
        /// <param name="dataInicio">Beginning date of the travel notification</param>
        /// <param name="dataFim">Travel Notification Ending date</param>
        /// <returns>AvisoViagemResponse</returns>
        AvisoViagemResponse Salvar (long? idCartao, string codigoPais, string dataInicio, string dataFim);
  
        /// <summary>
        /// Create the register of a new Travel Notice
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new Travel Notice in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param>
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param>
        /// <param name="dataInicio">Beginning date of the travel notification</param>
        /// <param name="dataFim">Travel Notification Ending date</param>
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        ApiResponse<AvisoViagemResponse> SalvarWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be searched an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Search a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be searched an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be disabled an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> DesabilitarAsync (long? id);

        /// <summary>
        /// Disable a travel notice according to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be disabled an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> DesabilitarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitate a travel notice accordding to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> HabilitarAsync (long? id);

        /// <summary>
        /// Habilitate a travel notice accordding to the last ID
        /// </summary>
        /// <remarks>
        /// This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> HabilitarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List of travel notices created by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent travel notices in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param>
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param>
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param>
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param>
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param>
        /// <returns>Task of PageAvisoViagemResponse</returns>
        System.Threading.Tasks.Task<PageAvisoViagemResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);

        /// <summary>
        /// List of travel notices created by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent travel notices in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param>
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param>
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param>
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param>
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param>
        /// <returns>Task of ApiResponse (PageAvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAvisoViagemResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null);
        
        /// <summary>
        /// Create the register of a new Travel Notice
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new Travel Notice in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param>
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param>
        /// <param name="dataInicio">Beginning date of the travel notification</param>
        /// <param name="dataFim">Travel Notification Ending date</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        System.Threading.Tasks.Task<AvisoViagemResponse> SalvarAsync (long? idCartao, string codigoPais, string dataInicio, string dataFim);

        /// <summary>
        /// Create the register of a new Travel Notice
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new Travel Notice in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param>
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param>
        /// <param name="dataInicio">Beginning date of the travel notification</param>
        /// <param name="dataFim">Travel Notification Ending date</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> SalvarAsyncWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TravelNotificationApi : ITravelNotificationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelNotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TravelNotificationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelNotificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TravelNotificationApi(Configuration configuration = null)
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
        /// Search a travel notice according to the last ID This method allows to be searched an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse Consultar (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search a travel notice according to the last ID This method allows to be searched an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TravelNotificationApi->Consultar");
            
    
            var localVarPath = "/api/avisos-viagens/{id}";
    
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
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Search a travel notice according to the last ID This method allows to be searched an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> ConsultarAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search a travel notice according to the last ID This method allows to be searched an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of travel notification (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/avisos-viagens/{id}";
    
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

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Disable a travel notice according to the last ID This method allows to be disabled an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse Desabilitar (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = DesabilitarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable a travel notice according to the last ID This method allows to be disabled an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > DesabilitarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TravelNotificationApi->Desabilitar");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/desabilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desabilitar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desabilitar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Disable a travel notice according to the last ID This method allows to be disabled an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> DesabilitarAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await DesabilitarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable a travel notice according to the last ID This method allows to be disabled an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> DesabilitarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Desabilitar");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/desabilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desabilitar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desabilitar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Habilitate a travel notice accordding to the last ID This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse Habilitar (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = HabilitarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitate a travel notice accordding to the last ID This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > HabilitarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TravelNotificationApi->Habilitar");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/habilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Habilitar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Habilitar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Habilitate a travel notice accordding to the last ID This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> HabilitarAsync (long? id)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await HabilitarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitate a travel notice accordding to the last ID This method allows to be habilitated an existent travel notice in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Travel Notification (id)</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> HabilitarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Habilitar");
            
    
            var localVarPath = "/api/avisos-viagens/{id}/habilitar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Habilitar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Habilitar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// List of travel notices created by the Issuer This method allows to be listed the existent travel notices in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param> 
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param> 
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param> 
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param> 
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param> 
        /// <returns>PageAvisoViagemResponse</returns>
        public PageAvisoViagemResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
        {
             ApiResponse<PageAvisoViagemResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idCartao, codigoPais, dataInicio, dataFim, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of travel notices created by the Issuer This method allows to be listed the existent travel notices in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param> 
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param> 
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param> 
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param> 
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param> 
        /// <returns>ApiResponse of PageAvisoViagemResponse</returns>
        public ApiResponse< PageAvisoViagemResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// List of travel notices created by the Issuer This method allows to be listed the existent travel notices in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param>
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param>
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param>
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param>
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param>
        /// <returns>Task of PageAvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<PageAvisoViagemResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
        {
             ApiResponse<PageAvisoViagemResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idCartao, codigoPais, dataInicio, dataFim, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of travel notices created by the Issuer This method allows to be listed the existent travel notices in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCartao">Identifier Code of the card in the base (id) (optional)</param>
        /// <param name="codigoPais">Identifier Code of the country in the base (id) (optional)</param>
        /// <param name="dataInicio">Beginning date of the travel notification (optional)</param>
        /// <param name="dataFim">]Ending Date of the travel notification (optional)</param>
        /// <param name="flagAtivo">Identify if the travel notification is active or not (optional)</param>
        /// <returns>Task of ApiResponse (PageAvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAvisoViagemResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idCartao = null, string codigoPais = null, string dataInicio = null, string dataFim = null, int? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAvisoViagemResponse)));
            
        }
        
        /// <summary>
        /// Create the register of a new Travel Notice This method allows to be created a new Travel Notice in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param> 
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param> 
        /// <param name="dataInicio">Beginning date of the travel notification</param> 
        /// <param name="dataFim">Travel Notification Ending date</param> 
        /// <returns>AvisoViagemResponse</returns>
        public AvisoViagemResponse Salvar (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = SalvarWithHttpInfo(idCartao, codigoPais, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the register of a new Travel Notice This method allows to be created a new Travel Notice in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param> 
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param> 
        /// <param name="dataInicio">Beginning date of the travel notification</param> 
        /// <param name="dataFim">Travel Notification Ending date</param> 
        /// <returns>ApiResponse of AvisoViagemResponse</returns>
        public ApiResponse< AvisoViagemResponse > SalvarWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling TravelNotificationApi->Salvar");
            
            // verify the required parameter 'codigoPais' is set
            if (codigoPais == null)
                throw new ApiException(400, "Missing required parameter 'codigoPais' when calling TravelNotificationApi->Salvar");
            
            // verify the required parameter 'dataInicio' is set
            if (dataInicio == null)
                throw new ApiException(400, "Missing required parameter 'dataInicio' when calling TravelNotificationApi->Salvar");
            
            // verify the required parameter 'dataFim' is set
            if (dataFim == null)
                throw new ApiException(400, "Missing required parameter 'dataFim' when calling TravelNotificationApi->Salvar");
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }

        
        /// <summary>
        /// Create the register of a new Travel Notice This method allows to be created a new Travel Notice in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param>
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param>
        /// <param name="dataInicio">Beginning date of the travel notification</param>
        /// <param name="dataFim">Travel Notification Ending date</param>
        /// <returns>Task of AvisoViagemResponse</returns>
        public async System.Threading.Tasks.Task<AvisoViagemResponse> SalvarAsync (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
             ApiResponse<AvisoViagemResponse> localVarResponse = await SalvarAsyncWithHttpInfo(idCartao, codigoPais, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the register of a new Travel Notice This method allows to be created a new Travel Notice in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identifier Code of the card base (id)</param>
        /// <param name="codigoPais">Identifier Code of the Country in the base (id)</param>
        /// <param name="dataInicio">Beginning date of the travel notification</param>
        /// <param name="dataFim">Travel Notification Ending date</param>
        /// <returns>Task of ApiResponse (AvisoViagemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvisoViagemResponse>> SalvarAsyncWithHttpInfo (long? idCartao, string codigoPais, string dataInicio, string dataFim)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling Salvar");
            // verify the required parameter 'codigoPais' is set
            if (codigoPais == null) throw new ApiException(400, "Missing required parameter 'codigoPais' when calling Salvar");
            // verify the required parameter 'dataInicio' is set
            if (dataInicio == null) throw new ApiException(400, "Missing required parameter 'dataInicio' when calling Salvar");
            // verify the required parameter 'dataFim' is set
            if (dataFim == null) throw new ApiException(400, "Missing required parameter 'dataFim' when calling Salvar");
            
    
            var localVarPath = "/api/avisos-viagens";
    
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
            
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (codigoPais != null) localVarQueryParams.Add("codigoPais", Configuration.ApiClient.ParameterToString(codigoPais)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvisoViagemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvisoViagemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvisoViagemResponse)));
            
        }
        
    }
    
}
