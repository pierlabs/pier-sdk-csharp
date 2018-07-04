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
    public interface IGlobaltagtipochaveApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param>
        /// <returns>PageTipoChaveResponse</returns>
        PageTipoChaveResponse ListarTipoChaveUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
  
        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoChaveResponse</returns>
        ApiResponse<PageTipoChaveResponse> ListarTipoChaveUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoChaveResponse</returns>
        System.Threading.Tasks.Task<PageTipoChaveResponse> ListarTipoChaveUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);

        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoChaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoChaveResponse>> ListarTipoChaveUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagtipochaveApi : IGlobaltagtipochaveApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagtipochaveApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagtipochaveApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagtipochaveApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagtipochaveApi(Configuration configuration = null)
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
        /// {{{tipo_chave_resource_listar_tipos_chaves}}} {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param> 
        /// <returns>PageTipoChaveResponse</returns>
        public PageTipoChaveResponse ListarTipoChaveUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
             ApiResponse<PageTipoChaveResponse> localVarResponse = ListarTipoChaveUsingGETWithHttpInfo(sort, page, limit, id, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}} {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoChaveResponse</returns>
        public ApiResponse< PageTipoChaveResponse > ListarTipoChaveUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-chaves";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoChaveUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoChaveUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoChaveResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}} {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoChaveResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoChaveResponse> ListarTipoChaveUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
             ApiResponse<PageTipoChaveResponse> localVarResponse = await ListarTipoChaveUsingGETAsyncWithHttpInfo(sort, page, limit, id, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_chave_resource_listar_tipos_chaves}}} {{{tipo_chave_resource_listar_tipos_chaves_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_chave_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_chave_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoChaveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoChaveResponse>> ListarTipoChaveUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-chaves";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoChaveUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoChaveUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoChaveResponse)));
            
        }
        
    }
    
}
