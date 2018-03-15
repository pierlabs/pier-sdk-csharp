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
    public interface IRiscoFraudeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        RiscoFraudeDetalhadoResponse ConsultarUsingGET27 (long? id);
  
        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        ApiResponse<RiscoFraudeDetalhadoResponse> ConsultarUsingGET27WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>TipoResolucaoResponse</returns>
        TipoResolucaoResponse ListarTiposResolucaoUsingGET (int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of TipoResolucaoResponse</returns>
        ApiResponse<TipoResolucaoResponse> ListarTiposResolucaoUsingGETWithHttpInfo (int? page = null, int? limit = null);
        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Object</returns>
        Object NegarUsingPOST (long? id);
  
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> NegarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Object</returns>
        Object ReconhecerUsingPOST (long? id);
  
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReconhecerUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object ValidarDadosPortadorUsingPOST (DadosPortadorRequest request);
  
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarDadosPortadorUsingPOSTWithHttpInfo (DadosPortadorRequest request);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> ConsultarUsingGET27Async (long? id);

        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> ConsultarUsingGET27AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of TipoResolucaoResponse</returns>
        System.Threading.Tasks.Task<TipoResolucaoResponse> ListarTiposResolucaoUsingGETAsync (int? page = null, int? limit = null);

        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (TipoResolucaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoResolucaoResponse>> ListarTiposResolucaoUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null);
        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> NegarUsingPOSTAsync (long? id);

        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> NegarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReconhecerUsingPOSTAsync (long? id);

        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReconhecerUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarDadosPortadorUsingPOSTAsync (DadosPortadorRequest request);

        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor
        /// </summary>
        /// <remarks>
        /// Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarDadosPortadorUsingPOSTAsyncWithHttpInfo (DadosPortadorRequest request);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RiscoFraudeApi : IRiscoFraudeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RiscoFraudeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RiscoFraudeApi(Configuration configuration = null)
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
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        public RiscoFraudeDetalhadoResponse ConsultarUsingGET27 (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = ConsultarUsingGET27WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        public ApiResponse< RiscoFraudeDetalhadoResponse > ConsultarUsingGET27WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RiscoFraudeApi->ConsultarUsingGET27");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> ConsultarUsingGET27Async (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = await ConsultarUsingGET27AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar uma transa\u00E7\u00E3o classificada com risco de fraude Consulta os detalhes de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> ConsultarUsingGET27AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET27");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>TipoResolucaoResponse</returns>
        public TipoResolucaoResponse ListarTiposResolucaoUsingGET (int? page = null, int? limit = null)
        {
             ApiResponse<TipoResolucaoResponse> localVarResponse = ListarTiposResolucaoUsingGETWithHttpInfo(page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of TipoResolucaoResponse</returns>
        public ApiResponse< TipoResolucaoResponse > ListarTiposResolucaoUsingGETWithHttpInfo (int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-resolucao";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoResolucaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoResolucaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoResolucaoResponse)));
            
        }

        
        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of TipoResolucaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoResolucaoResponse> ListarTiposResolucaoUsingGETAsync (int? page = null, int? limit = null)
        {
             ApiResponse<TipoResolucaoResponse> localVarResponse = await ListarTiposResolucaoUsingGETAsyncWithHttpInfo(page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar os tipos de resolu\u00E7\u00E3o de fraude Este recurso permite que sejam listados os tipos de resolu\u00E7\u00E3o de fraude, cadastrados para um emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (TipoResolucaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoResolucaoResponse>> ListarTiposResolucaoUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-resolucao";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposResolucaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoResolucaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoResolucaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoResolucaoResponse)));
            
        }
        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>Object</returns>
        public Object NegarUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = NegarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > NegarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RiscoFraudeApi->NegarUsingPOST");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/negar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling NegarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NegarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> NegarUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await NegarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Negar autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Nega a realiza\u00E7\u00E3o de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> NegarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling NegarUsingPOST");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/negar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling NegarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NegarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>Object</returns>
        public Object ReconhecerUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = ReconhecerUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReconhecerUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RiscoFraudeApi->ReconhecerUsingPOST");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/reconhecer";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReconhecerUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReconhecerUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reconhecer autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude Confirma a autenticidade de uma transa\u00E7\u00E3o classificada como risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReconhecerUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReconhecerUsingPOST");
            
    
            var localVarPath = "/api/riscos-fraudes/{id}/reconhecer";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReconhecerUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object ValidarDadosPortadorUsingPOST (DadosPortadorRequest request)
        {
             ApiResponse<Object> localVarResponse = ValidarDadosPortadorUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarDadosPortadorUsingPOSTWithHttpInfo (DadosPortadorRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling RiscoFraudeApi->ValidarDadosPortadorUsingPOST");
            
    
            var localVarPath = "/api/riscos-fraudes/validar-dados-portador";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosPortadorUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosPortadorUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarDadosPortadorUsingPOSTAsync (DadosPortadorRequest request)
        {
             ApiResponse<Object> localVarResponse = await ValidarDadosPortadorUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Val\u00EDda os dados informados, consultando as informa\u00E7\u00F5es na base do emissor Verif\u00EDca a exist\u00EAncias das informa\u00E7\u00F5es na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarDadosPortadorUsingPOSTAsyncWithHttpInfo (DadosPortadorRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ValidarDadosPortadorUsingPOST");
            
    
            var localVarPath = "/api/riscos-fraudes/validar-dados-portador";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosPortadorUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosPortadorUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
