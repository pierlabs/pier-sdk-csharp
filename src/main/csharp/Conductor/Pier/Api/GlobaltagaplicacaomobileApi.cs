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
    public interface IGlobaltagaplicacaomobileApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>AplicacaoMobileResponse</returns>
        AplicacaoMobileResponse AtualizarUsingPUT (long? id, AplicacaoMobileUpdateValue update);
  
        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        ApiResponse<AplicacaoMobileResponse> AtualizarUsingPUTWithHttpInfo (long? id, AplicacaoMobileUpdateValue update);
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param>
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param>
        /// <returns>PageAplicacaoMobileResponse</returns>
        PageAplicacaoMobileResponse ListarUsingGET3 (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
  
        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param>
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param>
        /// <returns>ApiResponse of PageAplicacaoMobileResponse</returns>
        ApiResponse<PageAplicacaoMobileResponse> ListarUsingGET3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>AplicacaoMobileResponse</returns>
        AplicacaoMobileResponse SalvarUsingPOST (AplicacaoMobilePersistValue persist);
  
        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        ApiResponse<AplicacaoMobileResponse> SalvarUsingPOSTWithHttpInfo (AplicacaoMobilePersistValue persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        System.Threading.Tasks.Task<AplicacaoMobileResponse> AtualizarUsingPUTAsync (long? id, AplicacaoMobileUpdateValue update);

        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, AplicacaoMobileUpdateValue update);
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param>
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param>
        /// <returns>Task of PageAplicacaoMobileResponse</returns>
        System.Threading.Tasks.Task<PageAplicacaoMobileResponse> ListarUsingGET3Async (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);

        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param>
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAplicacaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAplicacaoMobileResponse>> ListarUsingGET3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        System.Threading.Tasks.Task<AplicacaoMobileResponse> SalvarUsingPOSTAsync (AplicacaoMobilePersistValue persist);

        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> SalvarUsingPOSTAsyncWithHttpInfo (AplicacaoMobilePersistValue persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagaplicacaomobileApi : IGlobaltagaplicacaomobileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagaplicacaomobileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagaplicacaomobileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagaplicacaomobileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagaplicacaomobileApi(Configuration configuration = null)
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
        /// {{{aplicacao_mobile_resource_atualizar}}} {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>AplicacaoMobileResponse</returns>
        public AplicacaoMobileResponse AtualizarUsingPUT (long? id, AplicacaoMobileUpdateValue update)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = AtualizarUsingPUTWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}} {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        public ApiResponse< AplicacaoMobileResponse > AtualizarUsingPUTWithHttpInfo (long? id, AplicacaoMobileUpdateValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagaplicacaomobileApi->AtualizarUsingPUT");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagaplicacaomobileApi->AtualizarUsingPUT");
            
    
            var localVarPath = "/api/aplicacoes-mobile/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }

        
        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}} {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<AplicacaoMobileResponse> AtualizarUsingPUTAsync (long? id, AplicacaoMobileUpdateValue update)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = await AtualizarUsingPUTAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{aplicacao_mobile_resource_atualizar}}} {{{aplicacao_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{aplicacao_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, AplicacaoMobileUpdateValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT");
            
    
            var localVarPath = "/api/aplicacoes-mobile/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}} {{{aplicacao_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param> 
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param> 
        /// <returns>PageAplicacaoMobileResponse</returns>
        public PageAplicacaoMobileResponse ListarUsingGET3 (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
             ApiResponse<PageAplicacaoMobileResponse> localVarResponse = ListarUsingGET3WithHttpInfo(sort, page, limit, id, idPlataformaMobile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}} {{{aplicacao_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param> 
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageAplicacaoMobileResponse</returns>
        public ApiResponse< PageAplicacaoMobileResponse > ListarUsingGET3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
            
    
            var localVarPath = "/api/aplicacoes-mobile";
    
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
            if (idPlataformaMobile != null) localVarQueryParams.Add("idPlataformaMobile", Configuration.ApiClient.ParameterToString(idPlataformaMobile)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAplicacaoMobileResponse)));
            
        }

        
        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}} {{{aplicacao_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param>
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param>
        /// <returns>Task of PageAplicacaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<PageAplicacaoMobileResponse> ListarUsingGET3Async (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
             ApiResponse<PageAplicacaoMobileResponse> localVarResponse = await ListarUsingGET3AsyncWithHttpInfo(sort, page, limit, id, idPlataformaMobile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{aplicacao_mobile_resource_listar}}} {{{aplicacao_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{aplicacao_mobile_request_id_value}}} (optional)</param>
        /// <param name="idPlataformaMobile">{{{aplicacao_mobile_request_id_plataforma_mobile_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAplicacaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAplicacaoMobileResponse>> ListarUsingGET3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
            
    
            var localVarPath = "/api/aplicacoes-mobile";
    
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
            if (idPlataformaMobile != null) localVarQueryParams.Add("idPlataformaMobile", Configuration.ApiClient.ParameterToString(idPlataformaMobile)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAplicacaoMobileResponse)));
            
        }
        
        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}} {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>AplicacaoMobileResponse</returns>
        public AplicacaoMobileResponse SalvarUsingPOST (AplicacaoMobilePersistValue persist)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = SalvarUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}} {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        public ApiResponse< AplicacaoMobileResponse > SalvarUsingPOSTWithHttpInfo (AplicacaoMobilePersistValue persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagaplicacaomobileApi->SalvarUsingPOST");
            
    
            var localVarPath = "/api/aplicacoes-mobile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }

        
        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}} {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<AplicacaoMobileResponse> SalvarUsingPOSTAsync (AplicacaoMobilePersistValue persist)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = await SalvarUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{aplicacao_mobile_resource_salvar}}} {{{aplicacao_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> SalvarUsingPOSTAsyncWithHttpInfo (AplicacaoMobilePersistValue persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST");
            
    
            var localVarPath = "/api/aplicacoes-mobile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }
        
    }
    
}
