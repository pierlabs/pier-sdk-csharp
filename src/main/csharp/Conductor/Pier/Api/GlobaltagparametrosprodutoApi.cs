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
    public interface IGlobaltagparametrosprodutoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{parametro_produto_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_produto_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param>
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param>
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param>
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ListarUsingGET37 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null);
  
        /// <summary>
        /// {{{parametro_produto_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_produto_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param>
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param>
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param>
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ListarUsingGET37WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{parametro_produto_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_produto_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param>
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param>
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param>
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ListarUsingGET37Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null);

        /// <summary>
        /// {{{parametro_produto_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_produto_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param>
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param>
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param>
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ListarUsingGET37AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagparametrosprodutoApi : IGlobaltagparametrosprodutoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagparametrosprodutoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagparametrosprodutoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagparametrosprodutoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagparametrosprodutoApi(Configuration configuration = null)
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
        /// {{{parametro_produto_listar}}} {{{parametro_produto_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param> 
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param> 
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param> 
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ListarUsingGET37 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ListarUsingGET37WithHttpInfo(sort, page, limit, id, codigo, tipo, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{parametro_produto_listar}}} {{{parametro_produto_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param> 
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param> 
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param> 
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ListarUsingGET37WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/parametros-produto";
    
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
            if (codigo != null) localVarQueryParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }

        
        /// <summary>
        /// {{{parametro_produto_listar}}} {{{parametro_produto_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param>
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param>
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param>
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ListarUsingGET37Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ListarUsingGET37AsyncWithHttpInfo(sort, page, limit, id, codigo, tipo, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{parametro_produto_listar}}} {{{parametro_produto_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{parametro_produto_request_id_value}}} (optional)</param>
        /// <param name="codigo">{{{parametro_produto_request_codigo_value}}} (optional)</param>
        /// <param name="tipo">{{{parametro_produto_request_tipo_value}}} (optional)</param>
        /// <param name="idProduto">{{{parametro_produto_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ListarUsingGET37AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/parametros-produto";
    
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
            if (codigo != null) localVarQueryParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }
        
    }
    
}
