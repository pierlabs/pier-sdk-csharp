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
    public interface IPermissionCountryApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// List the dates of a determined country
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined country using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param>
        /// <returns>PaisResponse</returns>
        PaisResponse ConsultarPais (long? id);
  
        /// <summary>
        /// List the dates of a determined country
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined country using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param>
        /// <returns>ApiResponse of PaisResponse</returns>
        ApiResponse<PaisResponse> ConsultarPaisWithHttpInfo (long? id);
        
        /// <summary>
        /// List of the continents
        /// </summary>
        /// <remarks>
        /// This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarContinentes ();
  
        /// <summary>
        /// List of the continents
        /// </summary>
        /// <remarks>
        /// This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarContinentesWithHttpInfo ();
        
        /// <summary>
        /// List the countries
        /// </summary>
        /// <remarks>
        /// This resource allows to list the countries
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="codigo">Country Code (optional)</param>
        /// <param name="sigla">Country Acronym (optional)</param>
        /// <param name="descricao">Country name (optional)</param>
        /// <param name="continente">Continent which the country takes part (optional)</param>
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param>
        /// <returns>PagePaisResponse</returns>
        PagePaisResponse ListarPaises (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);
  
        /// <summary>
        /// List the countries
        /// </summary>
        /// <remarks>
        /// This resource allows to list the countries
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="codigo">Country Code (optional)</param>
        /// <param name="sigla">Country Acronym (optional)</param>
        /// <param name="descricao">Country name (optional)</param>
        /// <param name="continente">Continent which the country takes part (optional)</param>
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param>
        /// <returns>ApiResponse of PagePaisResponse</returns>
        ApiResponse<PagePaisResponse> ListarPaisesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// List the dates of a determined country
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined country using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param>
        /// <returns>Task of PaisResponse</returns>
        System.Threading.Tasks.Task<PaisResponse> ConsultarPaisAsync (long? id);

        /// <summary>
        /// List the dates of a determined country
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined country using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param>
        /// <returns>Task of ApiResponse (PaisResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaisResponse>> ConsultarPaisAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List of the continents
        /// </summary>
        /// <remarks>
        /// This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarContinentesAsync ();

        /// <summary>
        /// List of the continents
        /// </summary>
        /// <remarks>
        /// This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarContinentesAsyncWithHttpInfo ();
        
        /// <summary>
        /// List the countries
        /// </summary>
        /// <remarks>
        /// This resource allows to list the countries
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="codigo">Country Code (optional)</param>
        /// <param name="sigla">Country Acronym (optional)</param>
        /// <param name="descricao">Country name (optional)</param>
        /// <param name="continente">Continent which the country takes part (optional)</param>
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param>
        /// <returns>Task of PagePaisResponse</returns>
        System.Threading.Tasks.Task<PagePaisResponse> ListarPaisesAsync (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);

        /// <summary>
        /// List the countries
        /// </summary>
        /// <remarks>
        /// This resource allows to list the countries
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="codigo">Country Code (optional)</param>
        /// <param name="sigla">Country Acronym (optional)</param>
        /// <param name="descricao">Country name (optional)</param>
        /// <param name="continente">Continent which the country takes part (optional)</param>
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param>
        /// <returns>Task of ApiResponse (PagePaisResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePaisResponse>> ListarPaisesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PermissionCountryApi : IPermissionCountryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionCountryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissionCountryApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionCountryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PermissionCountryApi(Configuration configuration = null)
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
        /// List the dates of a determined country This method allows to retrieve dates of a determined country using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param> 
        /// <returns>PaisResponse</returns>
        public PaisResponse ConsultarPais (long? id)
        {
             ApiResponse<PaisResponse> localVarResponse = ConsultarPaisWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined country This method allows to retrieve dates of a determined country using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param> 
        /// <returns>ApiResponse of PaisResponse</returns>
        public ApiResponse< PaisResponse > ConsultarPaisWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PermissionCountryApi->ConsultarPais");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaisResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined country This method allows to retrieve dates of a determined country using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param>
        /// <returns>Task of PaisResponse</returns>
        public async System.Threading.Tasks.Task<PaisResponse> ConsultarPaisAsync (long? id)
        {
             ApiResponse<PaisResponse> localVarResponse = await ConsultarPaisAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined country This method allows to retrieve dates of a determined country using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the country (id)</param>
        /// <returns>Task of ApiResponse (PaisResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaisResponse>> ConsultarPaisAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPais");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaisResponse)));
            
        }
        
        /// <summary>
        /// List of the continents This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarContinentes ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarContinentesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of the continents This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarContinentesWithHttpInfo ()
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
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// List of the continents This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarContinentesAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarContinentesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of the continents This resource allows to list the continentes used in the resource of the using permission of the card abroad
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarContinentesAsyncWithHttpInfo ()
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
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContinentes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// List the countries This resource allows to list the countries
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="codigo">Country Code (optional)</param> 
        /// <param name="sigla">Country Acronym (optional)</param> 
        /// <param name="descricao">Country name (optional)</param> 
        /// <param name="continente">Continent which the country takes part (optional)</param> 
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param> 
        /// <returns>PagePaisResponse</returns>
        public PagePaisResponse ListarPaises (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
        {
             ApiResponse<PagePaisResponse> localVarResponse = ListarPaisesWithHttpInfo(sort, page, limit, codigo, sigla, descricao, continente, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the countries This resource allows to list the countries
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="codigo">Country Code (optional)</param> 
        /// <param name="sigla">Country Acronym (optional)</param> 
        /// <param name="descricao">Country name (optional)</param> 
        /// <param name="continente">Continent which the country takes part (optional)</param> 
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param> 
        /// <returns>ApiResponse of PagePaisResponse</returns>
        public ApiResponse< PagePaisResponse > ListarPaisesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPaises: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPaises: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePaisResponse)));
            
        }

        
        /// <summary>
        /// List the countries This resource allows to list the countries
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="codigo">Country Code (optional)</param>
        /// <param name="sigla">Country Acronym (optional)</param>
        /// <param name="descricao">Country name (optional)</param>
        /// <param name="continente">Continent which the country takes part (optional)</param>
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param>
        /// <returns>Task of PagePaisResponse</returns>
        public async System.Threading.Tasks.Task<PagePaisResponse> ListarPaisesAsync (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
        {
             ApiResponse<PagePaisResponse> localVarResponse = await ListarPaisesAsyncWithHttpInfo(sort, page, limit, codigo, sigla, descricao, continente, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the countries This resource allows to list the countries
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="codigo">Country Code (optional)</param>
        /// <param name="sigla">Country Acronym (optional)</param>
        /// <param name="descricao">Country name (optional)</param>
        /// <param name="continente">Continent which the country takes part (optional)</param>
        /// <param name="flagAtivo">Attribute that represents if the country is active (optional)</param>
        /// <returns>Task of ApiResponse (PagePaisResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePaisResponse>> ListarPaisesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigo = null, string sigla = null, string descricao = null, string continente = null, bool? flagAtivo = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarPaises: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPaises: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePaisResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePaisResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePaisResponse)));
            
        }
        
    }
    
}
