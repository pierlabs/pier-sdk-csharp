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
    public interface IParametroApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consultar par\u00E2metro do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param>
        /// <returns>ParametroEmissorResponse</returns>
        ParametroEmissorResponse Consultar (string codigo);
  
        /// <summary>
        /// Consultar par\u00E2metro do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param>
        /// <returns>ApiResponse of ParametroEmissorResponse</returns>
        ApiResponse<ParametroEmissorResponse> ConsultarWithHttpInfo (string codigo);
        
        /// <summary>
        /// Consultar um par\u00E2metro de produto
        /// </summary>
        /// <remarks>
        /// Consulta um par\u00E2metro de produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ParametrosProdutoResponse</returns>
        ParametrosProdutoResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Consultar um par\u00E2metro de produto
        /// </summary>
        /// <remarks>
        /// Consulta um par\u00E2metro de produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of ParametrosProdutoResponse</returns>
        ApiResponse<ParametrosProdutoResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar os par\u00E2metros de produtos
        /// </summary>
        /// <remarks>
        /// Lista os par\u00E2metros de produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param>
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param>
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param>
        /// <returns>PageParametroProdutoResponse</returns>
        PageParametroProdutoResponse ListarParametrosProduto (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null);
  
        /// <summary>
        /// Listar os par\u00E2metros de produtos
        /// </summary>
        /// <remarks>
        /// Lista os par\u00E2metros de produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param>
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param>
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param>
        /// <returns>ApiResponse of PageParametroProdutoResponse</returns>
        ApiResponse<PageParametroProdutoResponse> ListarParametrosProdutoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar par\u00E2metro do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param>
        /// <returns>Task of ParametroEmissorResponse</returns>
        System.Threading.Tasks.Task<ParametroEmissorResponse> ConsultarAsync (string codigo);

        /// <summary>
        /// Consultar par\u00E2metro do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param>
        /// <returns>Task of ApiResponse (ParametroEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroEmissorResponse>> ConsultarAsyncWithHttpInfo (string codigo);
        
        /// <summary>
        /// Consultar um par\u00E2metro de produto
        /// </summary>
        /// <remarks>
        /// Consulta um par\u00E2metro de produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ParametrosProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametrosProdutoResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Consultar um par\u00E2metro de produto
        /// </summary>
        /// <remarks>
        /// Consulta um par\u00E2metro de produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (ParametrosProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametrosProdutoResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar os par\u00E2metros de produtos
        /// </summary>
        /// <remarks>
        /// Lista os par\u00E2metros de produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param>
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param>
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param>
        /// <returns>Task of PageParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<PageParametroProdutoResponse> ListarParametrosProdutoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null);

        /// <summary>
        /// Listar os par\u00E2metros de produtos
        /// </summary>
        /// <remarks>
        /// Lista os par\u00E2metros de produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param>
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param>
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param>
        /// <returns>Task of ApiResponse (PageParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageParametroProdutoResponse>> ListarParametrosProdutoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ParametroApi : IParametroApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParametroApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ParametroApi(Configuration configuration = null)
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
        /// Consultar par\u00E2metro do emissor Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param> 
        /// <returns>ParametroEmissorResponse</returns>
        public ParametroEmissorResponse Consultar (string codigo)
        {
             ApiResponse<ParametroEmissorResponse> localVarResponse = ConsultarWithHttpInfo(codigo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar par\u00E2metro do emissor Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param> 
        /// <returns>ApiResponse of ParametroEmissorResponse</returns>
        public ApiResponse< ParametroEmissorResponse > ConsultarWithHttpInfo (string codigo)
        {
            
            // verify the required parameter 'codigo' is set
            if (codigo == null)
                throw new ApiException(400, "Missing required parameter 'codigo' when calling ParametroApi->Consultar");
            
    
            var localVarPath = "/api/parametros-emissor/{codigo}";
    
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
            if (codigo != null) localVarPathParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroEmissorResponse)));
            
        }

        
        /// <summary>
        /// Consultar par\u00E2metro do emissor Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param>
        /// <returns>Task of ParametroEmissorResponse</returns>
        public async System.Threading.Tasks.Task<ParametroEmissorResponse> ConsultarAsync (string codigo)
        {
             ApiResponse<ParametroEmissorResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(codigo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar par\u00E2metro do emissor Este m\u00E9todo consulta par\u00E2metro do emissor pelo seu c\u00F3digo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">C\u00F3digo para pesquisa</param>
        /// <returns>Task of ApiResponse (ParametroEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroEmissorResponse>> ConsultarAsyncWithHttpInfo (string codigo)
        {
            // verify the required parameter 'codigo' is set
            if (codigo == null) throw new ApiException(400, "Missing required parameter 'codigo' when calling Consultar");
            
    
            var localVarPath = "/api/parametros-emissor/{codigo}";
    
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
            if (codigo != null) localVarPathParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroEmissorResponse)));
            
        }
        
        /// <summary>
        /// Consultar um par\u00E2metro de produto Consulta um par\u00E2metro de produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ParametrosProdutoResponse</returns>
        public ParametrosProdutoResponse Consultar_0 (long? id)
        {
             ApiResponse<ParametrosProdutoResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar um par\u00E2metro de produto Consulta um par\u00E2metro de produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of ParametrosProdutoResponse</returns>
        public ApiResponse< ParametrosProdutoResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ParametroApi->Consultar_0");
            
    
            var localVarPath = "/api/parametros-produto/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametrosProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametrosProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametrosProdutoResponse)));
            
        }

        
        /// <summary>
        /// Consultar um par\u00E2metro de produto Consulta um par\u00E2metro de produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ParametrosProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametrosProdutoResponse> Consultar_0Async (long? id)
        {
             ApiResponse<ParametrosProdutoResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar um par\u00E2metro de produto Consulta um par\u00E2metro de produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (ParametrosProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametrosProdutoResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/parametros-produto/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametrosProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametrosProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametrosProdutoResponse)));
            
        }
        
        /// <summary>
        /// Listar os par\u00E2metros de produtos Lista os par\u00E2metros de produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param> 
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param> 
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param> 
        /// <param name="idProduto">Identificador do produto (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param> 
        /// <returns>PageParametroProdutoResponse</returns>
        public PageParametroProdutoResponse ListarParametrosProduto (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null)
        {
             ApiResponse<PageParametroProdutoResponse> localVarResponse = ListarParametrosProdutoWithHttpInfo(sort, page, limit, id, codigo, tipo, idProduto, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar os par\u00E2metros de produtos Lista os par\u00E2metros de produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param> 
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param> 
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param> 
        /// <param name="idProduto">Identificador do produto (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param> 
        /// <returns>ApiResponse of PageParametroProdutoResponse</returns>
        public ApiResponse< PageParametroProdutoResponse > ListarParametrosProdutoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null)
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageParametroProdutoResponse)));
            
        }

        
        /// <summary>
        /// Listar os par\u00E2metros de produtos Lista os par\u00E2metros de produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param>
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param>
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param>
        /// <returns>Task of PageParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<PageParametroProdutoResponse> ListarParametrosProdutoAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null)
        {
             ApiResponse<PageParametroProdutoResponse> localVarResponse = await ListarParametrosProdutoAsyncWithHttpInfo(sort, page, limit, id, codigo, tipo, idProduto, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar os par\u00E2metros de produtos Lista os par\u00E2metros de produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador do par\u00E2metro de produto (optional)</param>
        /// <param name="codigo">C\u00F3digo do par\u00E2metro do produto (optional)</param>
        /// <param name="tipo">Tipo do par\u00E2metro de produto (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (optional)</param>
        /// <returns>Task of ApiResponse (PageParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageParametroProdutoResponse>> ListarParametrosProdutoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string codigo = null, string tipo = null, long? idProduto = null, string descricao = null)
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageParametroProdutoResponse)));
            
        }
        
    }
    
}
