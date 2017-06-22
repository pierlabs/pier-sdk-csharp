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
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        RiscoFraudeDetalhadoResponse ConsultarUsingGET12 (long? id);
  
        /// <summary>
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        ApiResponse<RiscoFraudeDetalhadoResponse> ConsultarUsingGET12WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>RiscoFraudeResponsePage</returns>
        RiscoFraudeResponsePage ListarUsingGET19 (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of RiscoFraudeResponsePage</returns>
        ApiResponse<RiscoFraudeResponsePage> ListarUsingGET19WithHttpInfo (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null);
        
        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        RiscoFraudeDetalhadoResponse NegarUsingPOST (long? id);
  
        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        ApiResponse<RiscoFraudeDetalhadoResponse> NegarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        RiscoFraudeDetalhadoResponse ReconhecerUsingPOST (long? id);
  
        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        ApiResponse<RiscoFraudeDetalhadoResponse> ReconhecerUsingPOSTWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> ConsultarUsingGET12Async (long? id);

        /// <summary>
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> ConsultarUsingGET12AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of RiscoFraudeResponsePage</returns>
        System.Threading.Tasks.Task<RiscoFraudeResponsePage> ListarUsingGET19Async (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null);

        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (RiscoFraudeResponsePage)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiscoFraudeResponsePage>> ListarUsingGET19AsyncWithHttpInfo (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null);
        
        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> NegarUsingPOSTAsync (long? id);

        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> NegarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> ReconhecerUsingPOSTAsync (long? id);

        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude
        /// </summary>
        /// <remarks>
        /// Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> ReconhecerUsingPOSTAsyncWithHttpInfo (long? id);
        
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
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param> 
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        public RiscoFraudeDetalhadoResponse ConsultarUsingGET12 (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = ConsultarUsingGET12WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param> 
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        public ApiResponse< RiscoFraudeDetalhadoResponse > ConsultarUsingGET12WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RiscoFraudeApi->ConsultarUsingGET12");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> ConsultarUsingGET12Async (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = await ConsultarUsingGET12AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude Consulta os detalhes de uma transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> ConsultarUsingGET12AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET12");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param> 
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>RiscoFraudeResponsePage</returns>
        public RiscoFraudeResponsePage ListarUsingGET19 (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null)
        {
             ApiResponse<RiscoFraudeResponsePage> localVarResponse = ListarUsingGET19WithHttpInfo(idConta, confirmacaoFraude, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param> 
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of RiscoFraudeResponsePage</returns>
        public ApiResponse< RiscoFraudeResponsePage > ListarUsingGET19WithHttpInfo (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling RiscoFraudeApi->ListarUsingGET19");
            
            // verify the required parameter 'confirmacaoFraude' is set
            if (confirmacaoFraude == null)
                throw new ApiException(400, "Missing required parameter 'confirmacaoFraude' when calling RiscoFraudeApi->ListarUsingGET19");
            
    
            var localVarPath = "/api/riscos-fraudes";
    
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
            
            if (idConta != null) localVarQueryParams.Add("id_conta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (confirmacaoFraude != null) localVarQueryParams.Add("confirmacao_fraude", Configuration.ApiClient.ParameterToString(confirmacaoFraude)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RiscoFraudeResponsePage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeResponsePage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeResponsePage)));
            
        }

        
        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of RiscoFraudeResponsePage</returns>
        public async System.Threading.Tasks.Task<RiscoFraudeResponsePage> ListarUsingGET19Async (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null)
        {
             ApiResponse<RiscoFraudeResponsePage> localVarResponse = await ListarUsingGET19AsyncWithHttpInfo(idConta, confirmacaoFraude, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as transa\u00C3\u00A7\u00C3\u00B5es com resolu\u00C3\u00A7\u00C3\u00A3o de risco fraude pendente Este recurso permite que sejam listados os riscos de fraudes existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Id Conta</param>
        /// <param name="confirmacaoFraude">Confirma\u00C3\u00A7\u00C3\u00A3o da fraude</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (RiscoFraudeResponsePage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiscoFraudeResponsePage>> ListarUsingGET19AsyncWithHttpInfo (long? idConta, string confirmacaoFraude, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarUsingGET19");
            // verify the required parameter 'confirmacaoFraude' is set
            if (confirmacaoFraude == null) throw new ApiException(400, "Missing required parameter 'confirmacaoFraude' when calling ListarUsingGET19");
            
    
            var localVarPath = "/api/riscos-fraudes";
    
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
            
            if (idConta != null) localVarQueryParams.Add("id_conta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (confirmacaoFraude != null) localVarQueryParams.Add("confirmacao_fraude", Configuration.ApiClient.ParameterToString(confirmacaoFraude)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RiscoFraudeResponsePage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeResponsePage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeResponsePage)));
            
        }
        
        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param> 
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        public RiscoFraudeDetalhadoResponse NegarUsingPOST (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = NegarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param> 
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        public ApiResponse< RiscoFraudeDetalhadoResponse > NegarUsingPOSTWithHttpInfo (long? id)
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
    
            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> NegarUsingPOSTAsync (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = await NegarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Negar autenticidade da transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Nega a realiza\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> NegarUsingPOSTAsyncWithHttpInfo (long? id)
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

            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param> 
        /// <returns>RiscoFraudeDetalhadoResponse</returns>
        public RiscoFraudeDetalhadoResponse ReconhecerUsingPOST (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = ReconhecerUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param> 
        /// <returns>ApiResponse of RiscoFraudeDetalhadoResponse</returns>
        public ApiResponse< RiscoFraudeDetalhadoResponse > ReconhecerUsingPOSTWithHttpInfo (long? id)
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
    
            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of RiscoFraudeDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<RiscoFraudeDetalhadoResponse> ReconhecerUsingPOSTAsync (long? id)
        {
             ApiResponse<RiscoFraudeDetalhadoResponse> localVarResponse = await ReconhecerUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reconhecer a transa\u00C3\u00A7\u00C3\u00A3o com risco de fraude Confirma a autenticidade da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude</param>
        /// <returns>Task of ApiResponse (RiscoFraudeDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiscoFraudeDetalhadoResponse>> ReconhecerUsingPOSTAsyncWithHttpInfo (long? id)
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

            return new ApiResponse<RiscoFraudeDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiscoFraudeDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiscoFraudeDetalhadoResponse)));
            
        }
        
    }
    
}
