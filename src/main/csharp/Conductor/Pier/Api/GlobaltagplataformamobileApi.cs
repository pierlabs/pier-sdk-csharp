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
    public interface IGlobaltagplataformamobileApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>PlataformaMobileResponse</returns>
        PlataformaMobileResponse AtualizarUsingPUT1 (long? id, PlataformaMobileUpdateValue update);
  
        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        ApiResponse<PlataformaMobileResponse> AtualizarUsingPUT1WithHttpInfo (long? id, PlataformaMobileUpdateValue update);
        
        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param>
        /// <returns>PagePlataformaMobileResponse</returns>
        PagePlataformaMobileResponse ListarUsingGET40 (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
  
        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePlataformaMobileResponse</returns>
        ApiResponse<PagePlataformaMobileResponse> ListarUsingGET40WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>PlataformaMobileResponse</returns>
        PlataformaMobileResponse SalvarUsingPOST26 (PlataformaMobilePersistValue persist);
  
        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        ApiResponse<PlataformaMobileResponse> SalvarUsingPOST26WithHttpInfo (PlataformaMobilePersistValue persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        System.Threading.Tasks.Task<PlataformaMobileResponse> AtualizarUsingPUT1Async (long? id, PlataformaMobileUpdateValue update);

        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, PlataformaMobileUpdateValue update);
        
        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param>
        /// <returns>Task of PagePlataformaMobileResponse</returns>
        System.Threading.Tasks.Task<PagePlataformaMobileResponse> ListarUsingGET40Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null);

        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePlataformaMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePlataformaMobileResponse>> ListarUsingGET40AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        System.Threading.Tasks.Task<PlataformaMobileResponse> SalvarUsingPOST26Async (PlataformaMobilePersistValue persist);

        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{plataforma_mobile_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> SalvarUsingPOST26AsyncWithHttpInfo (PlataformaMobilePersistValue persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagplataformamobileApi : IGlobaltagplataformamobileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagplataformamobileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagplataformamobileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagplataformamobileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagplataformamobileApi(Configuration configuration = null)
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
        /// {{{plataforma_mobile_resource_atualizar}}} {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>PlataformaMobileResponse</returns>
        public PlataformaMobileResponse AtualizarUsingPUT1 (long? id, PlataformaMobileUpdateValue update)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = AtualizarUsingPUT1WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}} {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        public ApiResponse< PlataformaMobileResponse > AtualizarUsingPUT1WithHttpInfo (long? id, PlataformaMobileUpdateValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagplataformamobileApi->AtualizarUsingPUT1");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagplataformamobileApi->AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/plataformas-mobile/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }

        
        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}} {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        public async System.Threading.Tasks.Task<PlataformaMobileResponse> AtualizarUsingPUT1Async (long? id, PlataformaMobileUpdateValue update)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = await AtualizarUsingPUT1AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{plataforma_mobile_resource_atualizar}}} {{{plataforma_mobile_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{plataforma_mobile_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, PlataformaMobileUpdateValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT1");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/plataformas-mobile/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }
        
        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}} {{{plataforma_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param> 
        /// <returns>PagePlataformaMobileResponse</returns>
        public PagePlataformaMobileResponse ListarUsingGET40 (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PagePlataformaMobileResponse> localVarResponse = ListarUsingGET40WithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}} {{{plataforma_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePlataformaMobileResponse</returns>
        public ApiResponse< PagePlataformaMobileResponse > ListarUsingGET40WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlataformaMobileResponse)));
            
        }

        
        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}} {{{plataforma_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param>
        /// <returns>Task of PagePlataformaMobileResponse</returns>
        public async System.Threading.Tasks.Task<PagePlataformaMobileResponse> ListarUsingGET40Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PagePlataformaMobileResponse> localVarResponse = await ListarUsingGET40AsyncWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{plataforma_mobile_resource_listar}}} {{{plataforma_mobile_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{plataforma_mobile_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePlataformaMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePlataformaMobileResponse>> ListarUsingGET40AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlataformaMobileResponse)));
            
        }
        
        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}} {{{plataforma_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>PlataformaMobileResponse</returns>
        public PlataformaMobileResponse SalvarUsingPOST26 (PlataformaMobilePersistValue persist)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = SalvarUsingPOST26WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}} {{{plataforma_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        public ApiResponse< PlataformaMobileResponse > SalvarUsingPOST26WithHttpInfo (PlataformaMobilePersistValue persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagplataformamobileApi->SalvarUsingPOST26");
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }

        
        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}} {{{plataforma_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        public async System.Threading.Tasks.Task<PlataformaMobileResponse> SalvarUsingPOST26Async (PlataformaMobilePersistValue persist)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = await SalvarUsingPOST26AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{plataforma_mobile_resource_salvar}}} {{{plataforma_mobile_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> SalvarUsingPOST26AsyncWithHttpInfo (PlataformaMobilePersistValue persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST26");
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }
        
    }
    
}
