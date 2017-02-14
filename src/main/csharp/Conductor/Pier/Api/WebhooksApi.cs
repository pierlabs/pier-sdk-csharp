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
    public interface IWebhooksApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>WebHook</returns>
        WebHook AlterarUsingPUT3 (long? id, string evento, string metodo, string url);
  
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>ApiResponse of WebHook</returns>
        ApiResponse<WebHook> AlterarUsingPUT3WithHttpInfo (long? id, string evento, string metodo, string url);
        
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param>
        /// <returns>WebHook</returns>
        WebHook ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param>
        /// <returns>ApiResponse of WebHook</returns>
        ApiResponse<WebHook> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>PageWebHooks</returns>
        PageWebHooks ListarUsingGET11 (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null);
  
        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>ApiResponse of PageWebHooks</returns>
        ApiResponse<PageWebHooks> ListarUsingGET11WithHttpInfo (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null);
        
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>WebHook</returns>
        WebHook SalvarUsingPOST4 (string evento, string metodo, string url);
  
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>ApiResponse of WebHook</returns>
        ApiResponse<WebHook> SalvarUsingPOST4WithHttpInfo (string evento, string metodo, string url);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of WebHook</returns>
        System.Threading.Tasks.Task<WebHook> AlterarUsingPUT3Async (long? id, string evento, string metodo, string url);

        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of ApiResponse (WebHook)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHook>> AlterarUsingPUT3AsyncWithHttpInfo (long? id, string evento, string metodo, string url);
        
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param>
        /// <returns>Task of WebHook</returns>
        System.Threading.Tasks.Task<WebHook> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param>
        /// <returns>Task of ApiResponse (WebHook)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHook>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of PageWebHooks</returns>
        System.Threading.Tasks.Task<PageWebHooks> ListarUsingGET11Async (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null);

        /// <summary>
        /// Lista os Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of ApiResponse (PageWebHooks)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageWebHooks>> ListarUsingGET11AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null);
        
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of WebHook</returns>
        System.Threading.Tasks.Task<WebHook> SalvarUsingPOST4Async (string evento, string metodo, string url);

        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of ApiResponse (WebHook)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHook>> SalvarUsingPOST4AsyncWithHttpInfo (string evento, string metodo, string url);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi : IWebhooksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebhooksApi(Configuration configuration = null)
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
        /// Alterar Webhook Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param> 
        /// <param name="evento">Evento a ser chamado pelo WebHook</param> 
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook</param> 
        /// <returns>WebHook</returns>
        public WebHook AlterarUsingPUT3 (long? id, string evento, string metodo, string url)
        {
             ApiResponse<WebHook> localVarResponse = AlterarUsingPUT3WithHttpInfo(id, evento, metodo, url);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Webhook Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param> 
        /// <param name="evento">Evento a ser chamado pelo WebHook</param> 
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook</param> 
        /// <returns>ApiResponse of WebHook</returns>
        public ApiResponse< WebHook > AlterarUsingPUT3WithHttpInfo (long? id, string evento, string metodo, string url)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhooksApi->AlterarUsingPUT3");
            
            // verify the required parameter 'evento' is set
            if (evento == null)
                throw new ApiException(400, "Missing required parameter 'evento' when calling WebhooksApi->AlterarUsingPUT3");
            
            // verify the required parameter 'metodo' is set
            if (metodo == null)
                throw new ApiException(400, "Missing required parameter 'metodo' when calling WebhooksApi->AlterarUsingPUT3");
            
            // verify the required parameter 'url' is set
            if (url == null)
                throw new ApiException(400, "Missing required parameter 'url' when calling WebhooksApi->AlterarUsingPUT3");
            
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (evento != null) localVarQueryParams.Add("evento", Configuration.ApiClient.ParameterToString(evento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebHook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHook)));
            
        }

        
        /// <summary>
        /// Alterar Webhook Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of WebHook</returns>
        public async System.Threading.Tasks.Task<WebHook> AlterarUsingPUT3Async (long? id, string evento, string metodo, string url)
        {
             ApiResponse<WebHook> localVarResponse = await AlterarUsingPUT3AsyncWithHttpInfo(id, evento, metodo, url);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Webhook Este m\u00C3\u00A9todo permite que seja modificado um webhooks j\u00C3\u00A1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo identificador do Webhook</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of ApiResponse (WebHook)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHook>> AlterarUsingPUT3AsyncWithHttpInfo (long? id, string evento, string metodo, string url)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT3");
            // verify the required parameter 'evento' is set
            if (evento == null) throw new ApiException(400, "Missing required parameter 'evento' when calling AlterarUsingPUT3");
            // verify the required parameter 'metodo' is set
            if (metodo == null) throw new ApiException(400, "Missing required parameter 'metodo' when calling AlterarUsingPUT3");
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling AlterarUsingPUT3");
            
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (evento != null) localVarQueryParams.Add("evento", Configuration.ApiClient.ParameterToString(evento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebHook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHook)));
            
        }
        
        /// <summary>
        /// Consultar Webhook Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param> 
        /// <returns>WebHook</returns>
        public WebHook ConsultarUsingGET10 (long? id)
        {
             ApiResponse<WebHook> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Webhook Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param> 
        /// <returns>ApiResponse of WebHook</returns>
        public ApiResponse< WebHook > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhooksApi->ConsultarUsingGET10");
            
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebHook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHook)));
            
        }

        
        /// <summary>
        /// Consultar Webhook Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param>
        /// <returns>Task of WebHook</returns>
        public async System.Threading.Tasks.Task<WebHook> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<WebHook> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Webhook Este m\u00C3\u00A9todo permite que sejam consultado um webhook do emissor atrav\u00C3\u00A9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Webhook (id).</param>
        /// <returns>Task of ApiResponse (WebHook)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHook>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebHook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHook)));
            
        }
        
        /// <summary>
        /// Lista os Webhooks Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">Id do WebHook (optional)</param> 
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param> 
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param> 
        /// <returns>PageWebHooks</returns>
        public PageWebHooks ListarUsingGET11 (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null)
        {
             ApiResponse<PageWebHooks> localVarResponse = ListarUsingGET11WithHttpInfo(page, limit, id, evento, metodo, url);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Webhooks Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">Id do WebHook (optional)</param> 
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param> 
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param> 
        /// <returns>ApiResponse of PageWebHooks</returns>
        public ApiResponse< PageWebHooks > ListarUsingGET11WithHttpInfo (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (evento != null) localVarQueryParams.Add("evento", Configuration.ApiClient.ParameterToString(evento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageWebHooks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebHooks) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebHooks)));
            
        }

        
        /// <summary>
        /// Lista os Webhooks Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of PageWebHooks</returns>
        public async System.Threading.Tasks.Task<PageWebHooks> ListarUsingGET11Async (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null)
        {
             ApiResponse<PageWebHooks> localVarResponse = await ListarUsingGET11AsyncWithHttpInfo(page, limit, id, evento, metodo, url);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Webhooks Este m\u00C3\u00A9todo permite que sejam listados os webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id do WebHook (optional)</param>
        /// <param name="evento">Evento a ser chamado pelo WebHook (optional)</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (optional)</param>
        /// <param name="url">URL que a ser consumida pelo WebHook (optional)</param>
        /// <returns>Task of ApiResponse (PageWebHooks)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageWebHooks>> ListarUsingGET11AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string evento = null, string metodo = null, string url = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (evento != null) localVarQueryParams.Add("evento", Configuration.ApiClient.ParameterToString(evento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageWebHooks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebHooks) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebHooks)));
            
        }
        
        /// <summary>
        /// Salvar Webhook Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param> 
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook</param> 
        /// <returns>WebHook</returns>
        public WebHook SalvarUsingPOST4 (string evento, string metodo, string url)
        {
             ApiResponse<WebHook> localVarResponse = SalvarUsingPOST4WithHttpInfo(evento, metodo, url);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar Webhook Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param> 
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param> 
        /// <param name="url">URL que a ser consumida pelo WebHook</param> 
        /// <returns>ApiResponse of WebHook</returns>
        public ApiResponse< WebHook > SalvarUsingPOST4WithHttpInfo (string evento, string metodo, string url)
        {
            
            // verify the required parameter 'evento' is set
            if (evento == null)
                throw new ApiException(400, "Missing required parameter 'evento' when calling WebhooksApi->SalvarUsingPOST4");
            
            // verify the required parameter 'metodo' is set
            if (metodo == null)
                throw new ApiException(400, "Missing required parameter 'metodo' when calling WebhooksApi->SalvarUsingPOST4");
            
            // verify the required parameter 'url' is set
            if (url == null)
                throw new ApiException(400, "Missing required parameter 'url' when calling WebhooksApi->SalvarUsingPOST4");
            
    
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
            
            if (evento != null) localVarQueryParams.Add("evento", Configuration.ApiClient.ParameterToString(evento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebHook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHook)));
            
        }

        
        /// <summary>
        /// Salvar Webhook Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of WebHook</returns>
        public async System.Threading.Tasks.Task<WebHook> SalvarUsingPOST4Async (string evento, string metodo, string url)
        {
             ApiResponse<WebHook> localVarResponse = await SalvarUsingPOST4AsyncWithHttpInfo(evento, metodo, url);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar Webhook Este m\u00C3\u00A9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evento">Evento a ser chamado pelo WebHook</param>
        /// <param name="metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook</param>
        /// <param name="url">URL que a ser consumida pelo WebHook</param>
        /// <returns>Task of ApiResponse (WebHook)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHook>> SalvarUsingPOST4AsyncWithHttpInfo (string evento, string metodo, string url)
        {
            // verify the required parameter 'evento' is set
            if (evento == null) throw new ApiException(400, "Missing required parameter 'evento' when calling SalvarUsingPOST4");
            // verify the required parameter 'metodo' is set
            if (metodo == null) throw new ApiException(400, "Missing required parameter 'metodo' when calling SalvarUsingPOST4");
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling SalvarUsingPOST4");
            
    
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
            
            if (evento != null) localVarQueryParams.Add("evento", Configuration.ApiClient.ParameterToString(evento)); // query parameter
            if (metodo != null) localVarQueryParams.Add("metodo", Configuration.ApiClient.ParameterToString(metodo)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebHook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHook)));
            
        }
        
    }
    
}
