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
    public interface IWebhookApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">Status (optional)</param>
        /// <returns>WebHookResponse</returns>
        WebHookResponse Alterar (long? id, WebHook webhook, string status = null);
  
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">Status (optional)</param>
        /// <returns>ApiResponse of WebHookResponse</returns>
        ApiResponse<WebHookResponse> AlterarWithHttpInfo (long? id, WebHook webhook, string status = null);
        
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param>
        /// <returns>WebHookResponse</returns>
        WebHookResponse Consultar (long? id);
  
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param>
        /// <returns>ApiResponse of WebHookResponse</returns>
        ApiResponse<WebHookResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>PageWebHookResponse</returns>
        PageWebHookResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);
  
        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>ApiResponse of PageWebHookResponse</returns>
        ApiResponse<PageWebHookResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);
        
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>WebHookResponse</returns>
        WebHookResponse Salvar (WebHook webhook);
  
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>ApiResponse of WebHookResponse</returns>
        ApiResponse<WebHookResponse> SalvarWithHttpInfo (WebHook webhook);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">Status (optional)</param>
        /// <returns>Task of WebHookResponse</returns>
        System.Threading.Tasks.Task<WebHookResponse> AlterarAsync (long? id, WebHook webhook, string status = null);

        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">Status (optional)</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> AlterarAsyncWithHttpInfo (long? id, WebHook webhook, string status = null);
        
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param>
        /// <returns>Task of WebHookResponse</returns>
        System.Threading.Tasks.Task<WebHookResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of PageWebHookResponse</returns>
        System.Threading.Tasks.Task<PageWebHookResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);

        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of ApiResponse (PageWebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageWebHookResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);
        
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of WebHookResponse</returns>
        System.Threading.Tasks.Task<WebHookResponse> SalvarAsync (WebHook webhook);

        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> SalvarAsyncWithHttpInfo (WebHook webhook);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhookApi : IWebhookApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhookApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebhookApi(Configuration configuration = null)
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
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param> 
        /// <param name="webhook">webhook</param> 
        /// <param name="status">Status (optional)</param> 
        /// <returns>WebHookResponse</returns>
        public WebHookResponse Alterar (long? id, WebHook webhook, string status = null)
        {
             ApiResponse<WebHookResponse> localVarResponse = AlterarWithHttpInfo(id, webhook, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param> 
        /// <param name="webhook">webhook</param> 
        /// <param name="status">Status (optional)</param> 
        /// <returns>ApiResponse of WebHookResponse</returns>
        public ApiResponse< WebHookResponse > AlterarWithHttpInfo (long? id, WebHook webhook, string status = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Alterar");
            
            // verify the required parameter 'webhook' is set
            if (webhook == null)
                throw new ApiException(400, "Missing required parameter 'webhook' when calling WebhookApi->Alterar");
            
    
            var localVarPath = "/api/webhooks/{id}";
    
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
            
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            if (webhook.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhook); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhook; // byte array
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
    
            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }

        
        /// <summary>
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">Status (optional)</param>
        /// <returns>Task of WebHookResponse</returns>
        public async System.Threading.Tasks.Task<WebHookResponse> AlterarAsync (long? id, WebHook webhook, string status = null)
        {
             ApiResponse<WebHookResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, webhook, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador do Webhook</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">Status (optional)</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> AlterarAsyncWithHttpInfo (long? id, WebHook webhook, string status = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'webhook' is set
            if (webhook == null) throw new ApiException(400, "Missing required parameter 'webhook' when calling Alterar");
            
    
            var localVarPath = "/api/webhooks/{id}";
    
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
            
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            if (webhook.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhook); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhook; // byte array
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

            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }
        
        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param> 
        /// <returns>WebHookResponse</returns>
        public WebHookResponse Consultar (long? id)
        {
             ApiResponse<WebHookResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param> 
        /// <returns>ApiResponse of WebHookResponse</returns>
        public ApiResponse< WebHookResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Consultar");
            
    
            var localVarPath = "/api/webhooks/{id}";
    
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
    
            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }

        
        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param>
        /// <returns>Task of WebHookResponse</returns>
        public async System.Threading.Tasks.Task<WebHookResponse> ConsultarAsync (long? id)
        {
             ApiResponse<WebHookResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Webhook (id)</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/webhooks/{id}";
    
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

            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }
        
        /// <summary>
        /// Lista os Webhooks Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id do WebHook (optional)</param> 
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param> 
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param> 
        /// <returns>PageWebHookResponse</returns>
        public PageWebHookResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
        {
             ApiResponse<PageWebHookResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, id, tipoEvento, metodo, url);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Webhooks Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id do WebHook (optional)</param> 
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param> 
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param> 
        /// <returns>ApiResponse of PageWebHookResponse</returns>
        public ApiResponse< PageWebHookResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
        {
            
    
            var localVarPath = "/api/webhooks";
    
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
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageWebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebHookResponse)));
            
        }

        
        /// <summary>
        /// Lista os Webhooks Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of PageWebHookResponse</returns>
        public async System.Threading.Tasks.Task<PageWebHookResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
        {
             ApiResponse<PageWebHookResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, id, tipoEvento, metodo, url);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Webhooks Este m\u00E9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="tipoEvento">TipoEvento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00E9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of ApiResponse (PageWebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageWebHookResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
        {
            
    
            var localVarPath = "/api/webhooks";
    
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
            if (tipoEvento != null) localVarQueryParams.Add("tipoEvento", Configuration.ApiClient.ParameterToString(tipoEvento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageWebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebHookResponse)));
            
        }
        
        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param> 
        /// <returns>WebHookResponse</returns>
        public WebHookResponse Salvar (WebHook webhook)
        {
             ApiResponse<WebHookResponse> localVarResponse = SalvarWithHttpInfo(webhook);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param> 
        /// <returns>ApiResponse of WebHookResponse</returns>
        public ApiResponse< WebHookResponse > SalvarWithHttpInfo (WebHook webhook)
        {
            
            // verify the required parameter 'webhook' is set
            if (webhook == null)
                throw new ApiException(400, "Missing required parameter 'webhook' when calling WebhookApi->Salvar");
            
    
            var localVarPath = "/api/webhooks";
    
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
            
            
            
            
            if (webhook.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhook); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhook; // byte array
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
    
            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }

        
        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of WebHookResponse</returns>
        public async System.Threading.Tasks.Task<WebHookResponse> SalvarAsync (WebHook webhook)
        {
             ApiResponse<WebHookResponse> localVarResponse = await SalvarAsyncWithHttpInfo(webhook);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> SalvarAsyncWithHttpInfo (WebHook webhook)
        {
            // verify the required parameter 'webhook' is set
            if (webhook == null) throw new ApiException(400, "Missing required parameter 'webhook' when calling Salvar");
            
    
            var localVarPath = "/api/webhooks";
    
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
            
            
            
            
            if (webhook.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhook); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhook; // byte array
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

            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }
        
    }
    
}
