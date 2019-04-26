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
        /// <param name="id">id</param>
        /// <param name="webhookUpdate">webhookUpdate</param>
        /// <returns>WebhookResponse</returns>
        WebhookResponse Alterar (long? id, WebhookUpdate webhookUpdate);
  
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookUpdate">webhookUpdate</param>
        /// <returns>ApiResponse of WebhookResponse</returns>
        ApiResponse<WebhookResponse> AlterarWithHttpInfo (long? id, WebhookUpdate webhookUpdate);
        
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>WebhookResponse</returns>
        WebhookResponse Consultar (long? id);
  
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of WebhookResponse</returns>
        ApiResponse<WebhookResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Header do Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">idHeader</param>
        /// <returns>WebhookHeaderResponse</returns>
        WebhookHeaderResponse Consultar_0 (long? id, long? idHeader);
  
        /// <summary>
        /// Consultar Header do Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">idHeader</param>
        /// <returns>ApiResponse of WebhookHeaderResponse</returns>
        ApiResponse<WebhookHeaderResponse> Consultar_0WithHttpInfo (long? id, long? idHeader);
        
        /// <summary>
        /// Inativa um webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Object</returns>
        Object Desativar (long? id);
  
        /// <summary>
        /// Inativa um webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarWithHttpInfo (long? id);
        
        /// <summary>
        /// Inativa um header do webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um header webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">id</param>
        /// <returns>WebhookHeaderResponse</returns>
        WebhookHeaderResponse Desativar_0 (long? id, long? idHeader);
  
        /// <summary>
        /// Inativa um header do webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um header webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">id</param>
        /// <returns>ApiResponse of WebhookHeaderResponse</returns>
        ApiResponse<WebhookHeaderResponse> Desativar_0WithHttpInfo (long? id, long? idHeader);
        
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
        /// Lista os Headers do Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>PageWebhookHeaderResponse</returns>
        PageWebhookHeaderResponse Listar_0 (long? id);
  
        /// <summary>
        /// Lista os Headers do Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of PageWebhookHeaderResponse</returns>
        ApiResponse<PageWebhookHeaderResponse> Listar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param>
        /// <returns>WebhookResponse</returns>
        WebhookResponse Salvar (WebhookPersist webHookPersist);
  
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param>
        /// <returns>ApiResponse of WebhookResponse</returns>
        ApiResponse<WebhookResponse> SalvarWithHttpInfo (WebhookPersist webHookPersist);
        
        /// <summary>
        /// Salvar um Header Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param>
        /// <returns>WebhookHeaderResponse</returns>
        WebhookHeaderResponse Salvar_0 (long? id, WebhookHeaderPersist webhookHeaderPersist);
  
        /// <summary>
        /// Salvar um Header Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param>
        /// <returns>ApiResponse of WebhookHeaderResponse</returns>
        ApiResponse<WebhookHeaderResponse> Salvar_0WithHttpInfo (long? id, WebhookHeaderPersist webhookHeaderPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookUpdate">webhookUpdate</param>
        /// <returns>Task of WebhookResponse</returns>
        System.Threading.Tasks.Task<WebhookResponse> AlterarAsync (long? id, WebhookUpdate webhookUpdate);

        /// <summary>
        /// Alterar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookUpdate">webhookUpdate</param>
        /// <returns>Task of ApiResponse (WebhookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> AlterarAsyncWithHttpInfo (long? id, WebhookUpdate webhookUpdate);
        
        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of WebhookResponse</returns>
        System.Threading.Tasks.Task<WebhookResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Consultar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (WebhookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Header do Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">idHeader</param>
        /// <returns>Task of WebhookHeaderResponse</returns>
        System.Threading.Tasks.Task<WebhookHeaderResponse> Consultar_0Async (long? id, long? idHeader);

        /// <summary>
        /// Consultar Header do Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">idHeader</param>
        /// <returns>Task of ApiResponse (WebhookHeaderResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookHeaderResponse>> Consultar_0AsyncWithHttpInfo (long? id, long? idHeader);
        
        /// <summary>
        /// Inativa um webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarAsync (long? id);

        /// <summary>
        /// Inativa um webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Inativa um header do webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um header webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">id</param>
        /// <returns>Task of WebhookHeaderResponse</returns>
        System.Threading.Tasks.Task<WebhookHeaderResponse> Desativar_0Async (long? id, long? idHeader);

        /// <summary>
        /// Inativa um header do webhook
        /// </summary>
        /// <remarks>
        /// Esse m\u00E9todo permite inativar um header webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">id</param>
        /// <returns>Task of ApiResponse (WebhookHeaderResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookHeaderResponse>> Desativar_0AsyncWithHttpInfo (long? id, long? idHeader);
        
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
        /// Lista os Headers do Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of PageWebhookHeaderResponse</returns>
        System.Threading.Tasks.Task<PageWebhookHeaderResponse> Listar_0Async (long? id);

        /// <summary>
        /// Lista os Headers do Webhooks
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (PageWebhookHeaderResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageWebhookHeaderResponse>> Listar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param>
        /// <returns>Task of WebhookResponse</returns>
        System.Threading.Tasks.Task<WebhookResponse> SalvarAsync (WebhookPersist webHookPersist);

        /// <summary>
        /// Salvar Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param>
        /// <returns>Task of ApiResponse (WebhookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> SalvarAsyncWithHttpInfo (WebhookPersist webHookPersist);
        
        /// <summary>
        /// Salvar um Header Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param>
        /// <returns>Task of WebhookHeaderResponse</returns>
        System.Threading.Tasks.Task<WebhookHeaderResponse> Salvar_0Async (long? id, WebhookHeaderPersist webhookHeaderPersist);

        /// <summary>
        /// Salvar um Header Webhook
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param>
        /// <returns>Task of ApiResponse (WebhookHeaderResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebhookHeaderResponse>> Salvar_0AsyncWithHttpInfo (long? id, WebhookHeaderPersist webhookHeaderPersist);
        
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
        /// <param name="id">id</param> 
        /// <param name="webhookUpdate">webhookUpdate</param> 
        /// <returns>WebhookResponse</returns>
        public WebhookResponse Alterar (long? id, WebhookUpdate webhookUpdate)
        {
             ApiResponse<WebhookResponse> localVarResponse = AlterarWithHttpInfo(id, webhookUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="webhookUpdate">webhookUpdate</param> 
        /// <returns>ApiResponse of WebhookResponse</returns>
        public ApiResponse< WebhookResponse > AlterarWithHttpInfo (long? id, WebhookUpdate webhookUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Alterar");
            
            // verify the required parameter 'webhookUpdate' is set
            if (webhookUpdate == null)
                throw new ApiException(400, "Missing required parameter 'webhookUpdate' when calling WebhookApi->Alterar");
            
    
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
            
            
            
            
            if (webhookUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhookUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhookUpdate; // byte array
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
    
            return new ApiResponse<WebhookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookResponse)));
            
        }

        
        /// <summary>
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookUpdate">webhookUpdate</param>
        /// <returns>Task of WebhookResponse</returns>
        public async System.Threading.Tasks.Task<WebhookResponse> AlterarAsync (long? id, WebhookUpdate webhookUpdate)
        {
             ApiResponse<WebhookResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, webhookUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Webhook Este m\u00E9todo permite que seja modificado um webhooks j\u00E1 cadastrado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookUpdate">webhookUpdate</param>
        /// <returns>Task of ApiResponse (WebhookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> AlterarAsyncWithHttpInfo (long? id, WebhookUpdate webhookUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'webhookUpdate' is set
            if (webhookUpdate == null) throw new ApiException(400, "Missing required parameter 'webhookUpdate' when calling Alterar");
            
    
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
            
            
            
            
            if (webhookUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhookUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhookUpdate; // byte array
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

            return new ApiResponse<WebhookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookResponse)));
            
        }
        
        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>WebhookResponse</returns>
        public WebhookResponse Consultar (long? id)
        {
             ApiResponse<WebhookResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of WebhookResponse</returns>
        public ApiResponse< WebhookResponse > ConsultarWithHttpInfo (long? id)
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
    
            return new ApiResponse<WebhookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookResponse)));
            
        }

        
        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of WebhookResponse</returns>
        public async System.Threading.Tasks.Task<WebhookResponse> ConsultarAsync (long? id)
        {
             ApiResponse<WebhookResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Webhook Este m\u00E9todo permite que sejam consultado um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (WebhookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> ConsultarAsyncWithHttpInfo (long? id)
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

            return new ApiResponse<WebhookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookResponse)));
            
        }
        
        /// <summary>
        /// Consultar Header do Webhook Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idHeader">idHeader</param> 
        /// <returns>WebhookHeaderResponse</returns>
        public WebhookHeaderResponse Consultar_0 (long? id, long? idHeader)
        {
             ApiResponse<WebhookHeaderResponse> localVarResponse = Consultar_0WithHttpInfo(id, idHeader);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Header do Webhook Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idHeader">idHeader</param> 
        /// <returns>ApiResponse of WebhookHeaderResponse</returns>
        public ApiResponse< WebhookHeaderResponse > Consultar_0WithHttpInfo (long? id, long? idHeader)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Consultar_0");
            
            // verify the required parameter 'idHeader' is set
            if (idHeader == null)
                throw new ApiException(400, "Missing required parameter 'idHeader' when calling WebhookApi->Consultar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers/{idHeader}";
    
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
            if (idHeader != null) localVarPathParams.Add("idHeader", Configuration.ApiClient.ParameterToString(idHeader)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookHeaderResponse)));
            
        }

        
        /// <summary>
        /// Consultar Header do Webhook Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">idHeader</param>
        /// <returns>Task of WebhookHeaderResponse</returns>
        public async System.Threading.Tasks.Task<WebhookHeaderResponse> Consultar_0Async (long? id, long? idHeader)
        {
             ApiResponse<WebhookHeaderResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id, idHeader);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Header do Webhook Este m\u00E9todo permite que sejam consultado um header de um webhook do emissor atrav\u00E9s de um id especifico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">idHeader</param>
        /// <returns>Task of ApiResponse (WebhookHeaderResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebhookHeaderResponse>> Consultar_0AsyncWithHttpInfo (long? id, long? idHeader)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            // verify the required parameter 'idHeader' is set
            if (idHeader == null) throw new ApiException(400, "Missing required parameter 'idHeader' when calling Consultar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers/{idHeader}";
    
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
            if (idHeader != null) localVarPathParams.Add("idHeader", Configuration.ApiClient.ParameterToString(idHeader)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookHeaderResponse)));
            
        }
        
        /// <summary>
        /// Inativa um webhook Esse m\u00E9todo permite inativar um webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>Object</returns>
        public Object Desativar (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inativa um webhook Esse m\u00E9todo permite inativar um webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Desativar");
            
    
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Inativa um webhook Esse m\u00E9todo permite inativar um webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inativa um webhook Esse m\u00E9todo permite inativar um webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Desativar");
            
    
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Inativa um header do webhook Esse m\u00E9todo permite inativar um header webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idHeader">id</param> 
        /// <returns>WebhookHeaderResponse</returns>
        public WebhookHeaderResponse Desativar_0 (long? id, long? idHeader)
        {
             ApiResponse<WebhookHeaderResponse> localVarResponse = Desativar_0WithHttpInfo(id, idHeader);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inativa um header do webhook Esse m\u00E9todo permite inativar um header webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idHeader">id</param> 
        /// <returns>ApiResponse of WebhookHeaderResponse</returns>
        public ApiResponse< WebhookHeaderResponse > Desativar_0WithHttpInfo (long? id, long? idHeader)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Desativar_0");
            
            // verify the required parameter 'idHeader' is set
            if (idHeader == null)
                throw new ApiException(400, "Missing required parameter 'idHeader' when calling WebhookApi->Desativar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers/{idHeader}";
    
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
            if (idHeader != null) localVarPathParams.Add("idHeader", Configuration.ApiClient.ParameterToString(idHeader)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desativar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookHeaderResponse)));
            
        }

        
        /// <summary>
        /// Inativa um header do webhook Esse m\u00E9todo permite inativar um header webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">id</param>
        /// <returns>Task of WebhookHeaderResponse</returns>
        public async System.Threading.Tasks.Task<WebhookHeaderResponse> Desativar_0Async (long? id, long? idHeader)
        {
             ApiResponse<WebhookHeaderResponse> localVarResponse = await Desativar_0AsyncWithHttpInfo(id, idHeader);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inativa um header do webhook Esse m\u00E9todo permite inativar um header webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idHeader">id</param>
        /// <returns>Task of ApiResponse (WebhookHeaderResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebhookHeaderResponse>> Desativar_0AsyncWithHttpInfo (long? id, long? idHeader)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Desativar_0");
            // verify the required parameter 'idHeader' is set
            if (idHeader == null) throw new ApiException(400, "Missing required parameter 'idHeader' when calling Desativar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers/{idHeader}";
    
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
            if (idHeader != null) localVarPathParams.Add("idHeader", Configuration.ApiClient.ParameterToString(idHeader)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desativar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookHeaderResponse)));
            
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
        /// Lista os Headers do Webhooks Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>PageWebhookHeaderResponse</returns>
        public PageWebhookHeaderResponse Listar_0 (long? id)
        {
             ApiResponse<PageWebhookHeaderResponse> localVarResponse = Listar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Headers do Webhooks Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of PageWebhookHeaderResponse</returns>
        public ApiResponse< PageWebhookHeaderResponse > Listar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Listar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageWebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebhookHeaderResponse)));
            
        }

        
        /// <summary>
        /// Lista os Headers do Webhooks Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of PageWebhookHeaderResponse</returns>
        public async System.Threading.Tasks.Task<PageWebhookHeaderResponse> Listar_0Async (long? id)
        {
             ApiResponse<PageWebhookHeaderResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Headers do Webhooks Este m\u00E9todo permite que sejam listados os headers webhooks existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (PageWebhookHeaderResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageWebhookHeaderResponse>> Listar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageWebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebhookHeaderResponse)));
            
        }
        
        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param> 
        /// <returns>WebhookResponse</returns>
        public WebhookResponse Salvar (WebhookPersist webHookPersist)
        {
             ApiResponse<WebhookResponse> localVarResponse = SalvarWithHttpInfo(webHookPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param> 
        /// <returns>ApiResponse of WebhookResponse</returns>
        public ApiResponse< WebhookResponse > SalvarWithHttpInfo (WebhookPersist webHookPersist)
        {
            
            // verify the required parameter 'webHookPersist' is set
            if (webHookPersist == null)
                throw new ApiException(400, "Missing required parameter 'webHookPersist' when calling WebhookApi->Salvar");
            
    
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
            
            
            
            
            if (webHookPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webHookPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webHookPersist; // byte array
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
    
            return new ApiResponse<WebhookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookResponse)));
            
        }

        
        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param>
        /// <returns>Task of WebhookResponse</returns>
        public async System.Threading.Tasks.Task<WebhookResponse> SalvarAsync (WebhookPersist webHookPersist)
        {
             ApiResponse<WebhookResponse> localVarResponse = await SalvarAsyncWithHttpInfo(webHookPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar Webhook Este m\u00E9todo permite que seja adicionado um novo webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webHookPersist">webHookPersist</param>
        /// <returns>Task of ApiResponse (WebhookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebhookResponse>> SalvarAsyncWithHttpInfo (WebhookPersist webHookPersist)
        {
            // verify the required parameter 'webHookPersist' is set
            if (webHookPersist == null) throw new ApiException(400, "Missing required parameter 'webHookPersist' when calling Salvar");
            
    
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
            
            
            
            
            if (webHookPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webHookPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webHookPersist; // byte array
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

            return new ApiResponse<WebhookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookResponse)));
            
        }
        
        /// <summary>
        /// Salvar um Header Webhook Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param> 
        /// <returns>WebhookHeaderResponse</returns>
        public WebhookHeaderResponse Salvar_0 (long? id, WebhookHeaderPersist webhookHeaderPersist)
        {
             ApiResponse<WebhookHeaderResponse> localVarResponse = Salvar_0WithHttpInfo(id, webhookHeaderPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar um Header Webhook Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param> 
        /// <returns>ApiResponse of WebhookHeaderResponse</returns>
        public ApiResponse< WebhookHeaderResponse > Salvar_0WithHttpInfo (long? id, WebhookHeaderPersist webhookHeaderPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookApi->Salvar_0");
            
            // verify the required parameter 'webhookHeaderPersist' is set
            if (webhookHeaderPersist == null)
                throw new ApiException(400, "Missing required parameter 'webhookHeaderPersist' when calling WebhookApi->Salvar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers";
    
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
            
            
            
            
            if (webhookHeaderPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhookHeaderPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhookHeaderPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookHeaderResponse)));
            
        }

        
        /// <summary>
        /// Salvar um Header Webhook Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param>
        /// <returns>Task of WebhookHeaderResponse</returns>
        public async System.Threading.Tasks.Task<WebhookHeaderResponse> Salvar_0Async (long? id, WebhookHeaderPersist webhookHeaderPersist)
        {
             ApiResponse<WebhookHeaderResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(id, webhookHeaderPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar um Header Webhook Este m\u00E9todo permite que seja adicionado um novo header no webhook
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="webhookHeaderPersist">webhookHeaderPersist</param>
        /// <returns>Task of ApiResponse (WebhookHeaderResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebhookHeaderResponse>> Salvar_0AsyncWithHttpInfo (long? id, WebhookHeaderPersist webhookHeaderPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Salvar_0");
            // verify the required parameter 'webhookHeaderPersist' is set
            if (webhookHeaderPersist == null) throw new ApiException(400, "Missing required parameter 'webhookHeaderPersist' when calling Salvar_0");
            
    
            var localVarPath = "/api/webhooks/{id}/headers";
    
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
            
            
            
            
            if (webhookHeaderPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(webhookHeaderPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = webhookHeaderPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebhookHeaderResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebhookHeaderResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookHeaderResponse)));
            
        }
        
    }
    
}
