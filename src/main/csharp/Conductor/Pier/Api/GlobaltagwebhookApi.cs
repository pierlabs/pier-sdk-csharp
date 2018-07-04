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
    public interface IGlobaltagwebhookApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{web_hook_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param>
        /// <returns>WebHookResponse</returns>
        WebHookResponse AlterarUsingPUT24 (long? id, WebHookPersistValue webhook, string status = null);
  
        /// <summary>
        /// {{{web_hook_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param>
        /// <returns>ApiResponse of WebHookResponse</returns>
        ApiResponse<WebHookResponse> AlterarUsingPUT24WithHttpInfo (long? id, WebHookPersistValue webhook, string status = null);
        
        /// <summary>
        /// {{{web_hook_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param>
        /// <returns>WebHookResponse</returns>
        WebHookResponse ConsultarUsingGET52 (long? id);
  
        /// <summary>
        /// {{{web_hook_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of WebHookResponse</returns>
        ApiResponse<WebHookResponse> ConsultarUsingGET52WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{web_hook_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param>
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param>
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param>
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param>
        /// <returns>PageWebHookResponse</returns>
        PageWebHookResponse ListarUsingGET66 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);
  
        /// <summary>
        /// {{{web_hook_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param>
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param>
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param>
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param>
        /// <returns>ApiResponse of PageWebHookResponse</returns>
        ApiResponse<PageWebHookResponse> ListarUsingGET66WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);
        
        /// <summary>
        /// {{{web_hook_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>WebHookResponse</returns>
        WebHookResponse SalvarUsingPOST35 (WebHookPersistValue webhook);
  
        /// <summary>
        /// {{{web_hook_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>ApiResponse of WebHookResponse</returns>
        ApiResponse<WebHookResponse> SalvarUsingPOST35WithHttpInfo (WebHookPersistValue webhook);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{web_hook_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param>
        /// <returns>Task of WebHookResponse</returns>
        System.Threading.Tasks.Task<WebHookResponse> AlterarUsingPUT24Async (long? id, WebHookPersistValue webhook, string status = null);

        /// <summary>
        /// {{{web_hook_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> AlterarUsingPUT24AsyncWithHttpInfo (long? id, WebHookPersistValue webhook, string status = null);
        
        /// <summary>
        /// {{{web_hook_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param>
        /// <returns>Task of WebHookResponse</returns>
        System.Threading.Tasks.Task<WebHookResponse> ConsultarUsingGET52Async (long? id);

        /// <summary>
        /// {{{web_hook_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> ConsultarUsingGET52AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{web_hook_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param>
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param>
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param>
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param>
        /// <returns>Task of PageWebHookResponse</returns>
        System.Threading.Tasks.Task<PageWebHookResponse> ListarUsingGET66Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);

        /// <summary>
        /// {{{web_hook_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param>
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param>
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param>
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageWebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageWebHookResponse>> ListarUsingGET66AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null);
        
        /// <summary>
        /// {{{web_hook_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of WebHookResponse</returns>
        System.Threading.Tasks.Task<WebHookResponse> SalvarUsingPOST35Async (WebHookPersistValue webhook);

        /// <summary>
        /// {{{web_hook_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{web_hook_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> SalvarUsingPOST35AsyncWithHttpInfo (WebHookPersistValue webhook);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagwebhookApi : IGlobaltagwebhookApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagwebhookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagwebhookApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagwebhookApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagwebhookApi(Configuration configuration = null)
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
        /// {{{web_hook_resource_alterar}}} {{{web_hook_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param> 
        /// <param name="webhook">webhook</param> 
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param> 
        /// <returns>WebHookResponse</returns>
        public WebHookResponse AlterarUsingPUT24 (long? id, WebHookPersistValue webhook, string status = null)
        {
             ApiResponse<WebHookResponse> localVarResponse = AlterarUsingPUT24WithHttpInfo(id, webhook, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{web_hook_resource_alterar}}} {{{web_hook_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param> 
        /// <param name="webhook">webhook</param> 
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param> 
        /// <returns>ApiResponse of WebHookResponse</returns>
        public ApiResponse< WebHookResponse > AlterarUsingPUT24WithHttpInfo (long? id, WebHookPersistValue webhook, string status = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagwebhookApi->AlterarUsingPUT24");
            
            // verify the required parameter 'webhook' is set
            if (webhook == null)
                throw new ApiException(400, "Missing required parameter 'webhook' when calling GlobaltagwebhookApi->AlterarUsingPUT24");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }

        
        /// <summary>
        /// {{{web_hook_resource_alterar}}} {{{web_hook_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param>
        /// <returns>Task of WebHookResponse</returns>
        public async System.Threading.Tasks.Task<WebHookResponse> AlterarUsingPUT24Async (long? id, WebHookPersistValue webhook, string status = null)
        {
             ApiResponse<WebHookResponse> localVarResponse = await AlterarUsingPUT24AsyncWithHttpInfo(id, webhook, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{web_hook_resource_alterar}}} {{{web_hook_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_alterar_param_id}}}</param>
        /// <param name="webhook">webhook</param>
        /// <param name="status">{{{web_hook_resource_alterar_param_status}}} (optional)</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> AlterarUsingPUT24AsyncWithHttpInfo (long? id, WebHookPersistValue webhook, string status = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT24");
            // verify the required parameter 'webhook' is set
            if (webhook == null) throw new ApiException(400, "Missing required parameter 'webhook' when calling AlterarUsingPUT24");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }
        
        /// <summary>
        /// {{{web_hook_resource_consultar}}} {{{web_hook_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param> 
        /// <returns>WebHookResponse</returns>
        public WebHookResponse ConsultarUsingGET52 (long? id)
        {
             ApiResponse<WebHookResponse> localVarResponse = ConsultarUsingGET52WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{web_hook_resource_consultar}}} {{{web_hook_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of WebHookResponse</returns>
        public ApiResponse< WebHookResponse > ConsultarUsingGET52WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagwebhookApi->ConsultarUsingGET52");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }

        
        /// <summary>
        /// {{{web_hook_resource_consultar}}} {{{web_hook_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param>
        /// <returns>Task of WebHookResponse</returns>
        public async System.Threading.Tasks.Task<WebHookResponse> ConsultarUsingGET52Async (long? id)
        {
             ApiResponse<WebHookResponse> localVarResponse = await ConsultarUsingGET52AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{web_hook_resource_consultar}}} {{{web_hook_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{web_hook_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> ConsultarUsingGET52AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET52");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }
        
        /// <summary>
        /// {{{web_hook_resource_listar}}} {{{web_hook_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param> 
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param> 
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param> 
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param> 
        /// <returns>PageWebHookResponse</returns>
        public PageWebHookResponse ListarUsingGET66 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
        {
             ApiResponse<PageWebHookResponse> localVarResponse = ListarUsingGET66WithHttpInfo(sort, page, limit, id, tipoEvento, metodo, url);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{web_hook_resource_listar}}} {{{web_hook_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param> 
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param> 
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param> 
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageWebHookResponse</returns>
        public ApiResponse< PageWebHookResponse > ListarUsingGET66WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET66: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET66: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageWebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebHookResponse)));
            
        }

        
        /// <summary>
        /// {{{web_hook_resource_listar}}} {{{web_hook_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param>
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param>
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param>
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param>
        /// <returns>Task of PageWebHookResponse</returns>
        public async System.Threading.Tasks.Task<PageWebHookResponse> ListarUsingGET66Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
        {
             ApiResponse<PageWebHookResponse> localVarResponse = await ListarUsingGET66AsyncWithHttpInfo(sort, page, limit, id, tipoEvento, metodo, url);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{web_hook_resource_listar}}} {{{web_hook_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{web_hook_request_id_value}}} (optional)</param>
        /// <param name="tipoEvento">{{{web_hook_request_tipo_evento_value}}} (optional)</param>
        /// <param name="metodo">{{{web_hook_request_metodo_value}}} (optional)</param>
        /// <param name="url">{{{web_hook_request_url_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageWebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageWebHookResponse>> ListarUsingGET66AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string tipoEvento = null, string metodo = null, string url = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET66: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET66: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageWebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageWebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageWebHookResponse)));
            
        }
        
        /// <summary>
        /// {{{web_hook_resource_salvar}}} {{{web_hook_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param> 
        /// <returns>WebHookResponse</returns>
        public WebHookResponse SalvarUsingPOST35 (WebHookPersistValue webhook)
        {
             ApiResponse<WebHookResponse> localVarResponse = SalvarUsingPOST35WithHttpInfo(webhook);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{web_hook_resource_salvar}}} {{{web_hook_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param> 
        /// <returns>ApiResponse of WebHookResponse</returns>
        public ApiResponse< WebHookResponse > SalvarUsingPOST35WithHttpInfo (WebHookPersistValue webhook)
        {
            
            // verify the required parameter 'webhook' is set
            if (webhook == null)
                throw new ApiException(400, "Missing required parameter 'webhook' when calling GlobaltagwebhookApi->SalvarUsingPOST35");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }

        
        /// <summary>
        /// {{{web_hook_resource_salvar}}} {{{web_hook_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of WebHookResponse</returns>
        public async System.Threading.Tasks.Task<WebHookResponse> SalvarUsingPOST35Async (WebHookPersistValue webhook)
        {
             ApiResponse<WebHookResponse> localVarResponse = await SalvarUsingPOST35AsyncWithHttpInfo(webhook);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{web_hook_resource_salvar}}} {{{web_hook_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhook">webhook</param>
        /// <returns>Task of ApiResponse (WebHookResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebHookResponse>> SalvarUsingPOST35AsyncWithHttpInfo (WebHookPersistValue webhook)
        {
            // verify the required parameter 'webhook' is set
            if (webhook == null) throw new ApiException(400, "Missing required parameter 'webhook' when calling SalvarUsingPOST35");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebHookResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebHookResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebHookResponse)));
            
        }
        
    }
    
}
