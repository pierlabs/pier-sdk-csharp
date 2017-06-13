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
    public interface IPermissaoPaisesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param>
        /// <returns>PaisResponse</returns>
        PaisResponse ConsultarPaisUsingGET (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param>
        /// <returns>ApiResponse of PaisResponse</returns>
        ApiResponse<PaisResponse> ConsultarPaisUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os continentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarContinentesUsingGET ();
  
        /// <summary>
        /// Lista os continentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarContinentesUsingGETWithHttpInfo ();
        
        /// <summary>
        /// Lista os pa\u00C3\u00ADses
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os pa\u00C3\u00ADses.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param>
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param>
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param>
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>PagePaisResponse</returns>
        PagePaisResponse ListarPaisesUsingGET (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista os pa\u00C3\u00ADses
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os pa\u00C3\u00ADses.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param>
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param>
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param>
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>ApiResponse of PagePaisResponse</returns>
        ApiResponse<PagePaisResponse> ListarPaisesUsingGETWithHttpInfo (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param>
        /// <returns>Task of PaisResponse</returns>
        System.Threading.Tasks.Task<PaisResponse> ConsultarPaisUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param>
        /// <returns>Task of ApiResponse (PaisResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaisResponse>> ConsultarPaisUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os continentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarContinentesUsingGETAsync ();

        /// <summary>
        /// Lista os continentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarContinentesUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// Lista os pa\u00C3\u00ADses
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os pa\u00C3\u00ADses.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param>
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param>
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param>
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of PagePaisResponse</returns>
        System.Threading.Tasks.Task<PagePaisResponse> ListarPaisesUsingGETAsync (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista os pa\u00C3\u00ADses
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os pa\u00C3\u00ADses.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param>
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param>
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param>
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PagePaisResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePaisResponse>> ListarPaisesUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PermissaoPaisesApi : IPermissaoPaisesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissaoPaisesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissaoPaisesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissaoPaisesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PermissaoPaisesApi(Configuration configuration = null)
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
        /// Apresenta dados de um determinado pa\u00C3\u00ADs Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param> 
        /// <returns>PaisResponse</returns>
        public PaisResponse ConsultarPaisUsingGET (long? id)
        {
             ApiResponse<PaisResponse> localVarResponse = ConsultarPaisUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param> 
        /// <returns>ApiResponse of PaisResponse</returns>
        public ApiResponse< PaisResponse > ConsultarPaisUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PermissaoPaisesApi->ConsultarPaisUsingGET");
            
    
            var localVarPath = "/api/paises/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaisResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param>
        /// <returns>Task of PaisResponse</returns>
        public async System.Threading.Tasks.Task<PaisResponse> ConsultarPaisUsingGETAsync (long? id)
        {
             ApiResponse<PaisResponse> localVarResponse = await ConsultarPaisUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado pa\u00C3\u00ADs Este m\u00C3\u00A9todo permite consultar dados de um determinado pa\u00C3\u00ADs a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do pa\u00C3\u00ADs (id).</param>
        /// <returns>Task of ApiResponse (PaisResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaisResponse>> ConsultarPaisUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPaisUsingGET");
            
    
            var localVarPath = "/api/paises/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaisResponse)));
            
        }
        
        /// <summary>
        /// Lista os continentes Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarContinentesUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarContinentesUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os continentes Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarContinentesUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/continentes";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Lista os continentes Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarContinentesUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarContinentesUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os continentes Este recurso permite listar os continentes utilizados no recurso de permiss\u00C3\u00A3o de uso do cart\u00C3\u00A3o no exterior
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarContinentesUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/continentes";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Lista os pa\u00C3\u00ADses Este recurso permite listar os pa\u00C3\u00ADses.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param> 
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param> 
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param> 
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param> 
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param> 
        /// <returns>PagePaisResponse</returns>
        public PagePaisResponse ListarPaisesUsingGET (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
        {
             ApiResponse<PagePaisResponse> localVarResponse = ListarPaisesUsingGETWithHttpInfo(page, limit, codigo, sigla, descricao, continente, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os pa\u00C3\u00ADses Este recurso permite listar os pa\u00C3\u00ADses.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param> 
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param> 
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param> 
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param> 
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param> 
        /// <returns>ApiResponse of PagePaisResponse</returns>
        public ApiResponse< PagePaisResponse > ListarPaisesUsingGETWithHttpInfo (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/paises";
    
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
            if (codigo != null) localVarQueryParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // query parameter
            if (sigla != null) localVarQueryParams.Add("sigla", Configuration.ApiClient.ParameterToString(sigla)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (continente != null) localVarQueryParams.Add("continente", Configuration.ApiClient.ParameterToString(continente)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPaisesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPaisesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePaisResponse)));
            
        }

        
        /// <summary>
        /// Lista os pa\u00C3\u00ADses Este recurso permite listar os pa\u00C3\u00ADses.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param>
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param>
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param>
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of PagePaisResponse</returns>
        public async System.Threading.Tasks.Task<PagePaisResponse> ListarPaisesUsingGETAsync (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
        {
             ApiResponse<PagePaisResponse> localVarResponse = await ListarPaisesUsingGETAsyncWithHttpInfo(page, limit, codigo, sigla, descricao, continente, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os pa\u00C3\u00ADses Este recurso permite listar os pa\u00C3\u00ADses.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="codigo">C\u00C3\u00B3digo do pa\u00C3\u00ADs (optional)</param>
        /// <param name="sigla">Sigla do pa\u00C3\u00ADs (optional)</param>
        /// <param name="descricao">Nome do pa\u00C3\u00ADs (optional)</param>
        /// <param name="continente">Continente no qual o pa\u00C3\u00ADs faz parte (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o pa\u00C3\u00ADs est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PagePaisResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePaisResponse>> ListarPaisesUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/paises";
    
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
            if (codigo != null) localVarQueryParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // query parameter
            if (sigla != null) localVarQueryParams.Add("sigla", Configuration.ApiClient.ParameterToString(sigla)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (continente != null) localVarQueryParams.Add("continente", Configuration.ApiClient.ParameterToString(continente)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPaisesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPaisesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePaisResponse)));
            
        }
        
    }
    
}
