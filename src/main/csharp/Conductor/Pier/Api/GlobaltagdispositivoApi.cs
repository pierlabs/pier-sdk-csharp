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
    public interface IGlobaltagdispositivoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{dispositivo_resource_ativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_ativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse AtivarUsingPOST (long? id);
  
        /// <summary>
        /// {{{dispositivo_resource_ativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_ativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> AtivarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{dispositivo_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_desativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse DesativarUsingPOST (long? id);
  
        /// <summary>
        /// {{{dispositivo_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_desativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> DesativarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{dispositivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param>
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param>
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param>
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param>
        /// <returns>PageDispositivoResponse</returns>
        PageDispositivoResponse ListarUsingGET18 (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
  
        /// <summary>
        /// {{{dispositivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param>
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param>
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param>
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageDispositivoResponse</returns>
        ApiResponse<PageDispositivoResponse> ListarUsingGET18WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// {{{dispositivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse SalvarUsingPOST9 (DispositivoPersistValue persist);
  
        /// <summary>
        /// {{{dispositivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> SalvarUsingPOST9WithHttpInfo (DispositivoPersistValue persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{dispositivo_resource_ativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_ativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> AtivarUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{dispositivo_resource_ativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_ativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> AtivarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{dispositivo_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_desativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> DesativarUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{dispositivo_resource_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_desativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> DesativarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{dispositivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param>
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param>
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param>
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param>
        /// <returns>Task of PageDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageDispositivoResponse> ListarUsingGET18Async (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);

        /// <summary>
        /// {{{dispositivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param>
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param>
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param>
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDispositivoResponse>> ListarUsingGET18AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// {{{dispositivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> SalvarUsingPOST9Async (DispositivoPersistValue persist);

        /// <summary>
        /// {{{dispositivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dispositivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> SalvarUsingPOST9AsyncWithHttpInfo (DispositivoPersistValue persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagdispositivoApi : IGlobaltagdispositivoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdispositivoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagdispositivoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdispositivoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagdispositivoApi(Configuration configuration = null)
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
        /// {{{dispositivo_resource_ativar}}} {{{dispositivo_resource_ativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse AtivarUsingPOST (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = AtivarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dispositivo_resource_ativar}}} {{{dispositivo_resource_ativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > AtivarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdispositivoApi->AtivarUsingPOST");
            
    
            var localVarPath = "/api/dispositivos/{id}/ativar-dispositivo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{dispositivo_resource_ativar}}} {{{dispositivo_resource_ativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> AtivarUsingPOSTAsync (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await AtivarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dispositivo_resource_ativar}}} {{{dispositivo_resource_ativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_ativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> AtivarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarUsingPOST");
            
    
            var localVarPath = "/api/dispositivos/{id}/ativar-dispositivo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{dispositivo_resource_desativar}}} {{{dispositivo_resource_desativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse DesativarUsingPOST (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = DesativarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dispositivo_resource_desativar}}} {{{dispositivo_resource_desativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > DesativarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdispositivoApi->DesativarUsingPOST");
            
    
            var localVarPath = "/api/dispositivos/{id}/desativar-dispositivo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{dispositivo_resource_desativar}}} {{{dispositivo_resource_desativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> DesativarUsingPOSTAsync (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await DesativarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dispositivo_resource_desativar}}} {{{dispositivo_resource_desativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dispositivo_resource_desativar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> DesativarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsingPOST");
            
    
            var localVarPath = "/api/dispositivos/{id}/desativar-dispositivo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{dispositivo_resource_listar}}} {{{dispositivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param> 
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param> 
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param> 
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param> 
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param> 
        /// <returns>PageDispositivoResponse</returns>
        public PageDispositivoResponse ListarUsingGET18 (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivoResponse> localVarResponse = ListarUsingGET18WithHttpInfo(sort, page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dispositivo_resource_listar}}} {{{dispositivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param> 
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param> 
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param> 
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param> 
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageDispositivoResponse</returns>
        public ApiResponse< PageDispositivoResponse > ListarUsingGET18WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
            
    
            var localVarPath = "/api/dispositivos";
    
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (idAplicacaoMobile != null) localVarQueryParams.Add("idAplicacaoMobile", Configuration.ApiClient.ParameterToString(idAplicacaoMobile)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (dataDesativacao != null) localVarQueryParams.Add("dataDesativacao", Configuration.ApiClient.ParameterToString(dataDesativacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{dispositivo_resource_listar}}} {{{dispositivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param>
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param>
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param>
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param>
        /// <returns>Task of PageDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageDispositivoResponse> ListarUsingGET18Async (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivoResponse> localVarResponse = await ListarUsingGET18AsyncWithHttpInfo(sort, page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dispositivo_resource_listar}}} {{{dispositivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="token">{{{dispositivo_request_token_value}}} (optional)</param>
        /// <param name="idUsuario">{{{dispositivo_request_id_usuario_value}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{dispositivo_request_id_aplicacao_mobile_value}}} (optional)</param>
        /// <param name="dataCriacao">{{{dispositivo_request_data_criacao_value}}} (optional)</param>
        /// <param name="dataDesativacao">{{{dispositivo_request_data_desativacao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDispositivoResponse>> ListarUsingGET18AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
            
    
            var localVarPath = "/api/dispositivos";
    
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (idAplicacaoMobile != null) localVarQueryParams.Add("idAplicacaoMobile", Configuration.ApiClient.ParameterToString(idAplicacaoMobile)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (dataDesativacao != null) localVarQueryParams.Add("dataDesativacao", Configuration.ApiClient.ParameterToString(dataDesativacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{dispositivo_resource_salvar}}} {{{dispositivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse SalvarUsingPOST9 (DispositivoPersistValue persist)
        {
             ApiResponse<DispositivoResponse> localVarResponse = SalvarUsingPOST9WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dispositivo_resource_salvar}}} {{{dispositivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > SalvarUsingPOST9WithHttpInfo (DispositivoPersistValue persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagdispositivoApi->SalvarUsingPOST9");
            
    
            var localVarPath = "/api/dispositivos";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{dispositivo_resource_salvar}}} {{{dispositivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> SalvarUsingPOST9Async (DispositivoPersistValue persist)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await SalvarUsingPOST9AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dispositivo_resource_salvar}}} {{{dispositivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> SalvarUsingPOST9AsyncWithHttpInfo (DispositivoPersistValue persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST9");
            
    
            var localVarPath = "/api/dispositivos";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
    }
    
}
