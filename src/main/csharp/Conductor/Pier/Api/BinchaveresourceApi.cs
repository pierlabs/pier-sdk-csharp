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
    public interface IBinchaveresourceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// alterarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login</param>
        /// <returns>Object</returns>
        Object AlterarBinChaveUsingPUT (long? id, BinChaveUpdate request, string login);
  
        /// <summary>
        /// alterarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AlterarBinChaveUsingPUTWithHttpInfo (long? id, BinChaveUpdate request, string login);
        
        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Object</returns>
        Object ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// listarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="idTipoChave"> (optional)</param>
        /// <param name="idBin"> (optional)</param>
        /// <param name="chave"> (optional)</param>
        /// <param name="checkValue"> (optional)</param>
        /// <param name="validade"> (optional)</param>
        /// <param name="flagDescriptografado"> (optional)</param>
        /// <param name="label"> (optional)</param>
        /// <returns>Object</returns>
        Object ListarBinChaveUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null);
  
        /// <summary>
        /// listarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="idTipoChave"> (optional)</param>
        /// <param name="idBin"> (optional)</param>
        /// <param name="chave"> (optional)</param>
        /// <param name="checkValue"> (optional)</param>
        /// <param name="validade"> (optional)</param>
        /// <param name="flagDescriptografado"> (optional)</param>
        /// <param name="label"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ListarBinChaveUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null);
        
        /// <summary>
        /// salvar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param>
        /// <param name="login">login</param>
        /// <returns>Object</returns>
        Object SalvarUsingPOST4 (BinChavePersist binChavePersist, string login);
  
        /// <summary>
        /// salvar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param>
        /// <param name="login">login</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SalvarUsingPOST4WithHttpInfo (BinChavePersist binChavePersist, string login);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// alterarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AlterarBinChaveUsingPUTAsync (long? id, BinChaveUpdate request, string login);

        /// <summary>
        /// alterarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AlterarBinChaveUsingPUTAsyncWithHttpInfo (long? id, BinChaveUpdate request, string login);
        
        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// listarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="idTipoChave"> (optional)</param>
        /// <param name="idBin"> (optional)</param>
        /// <param name="chave"> (optional)</param>
        /// <param name="checkValue"> (optional)</param>
        /// <param name="validade"> (optional)</param>
        /// <param name="flagDescriptografado"> (optional)</param>
        /// <param name="label"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ListarBinChaveUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null);

        /// <summary>
        /// listarBinChave
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="idTipoChave"> (optional)</param>
        /// <param name="idBin"> (optional)</param>
        /// <param name="chave"> (optional)</param>
        /// <param name="checkValue"> (optional)</param>
        /// <param name="validade"> (optional)</param>
        /// <param name="flagDescriptografado"> (optional)</param>
        /// <param name="label"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ListarBinChaveUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null);
        
        /// <summary>
        /// salvar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param>
        /// <param name="login">login</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SalvarUsingPOST4Async (BinChavePersist binChavePersist, string login);

        /// <summary>
        /// salvar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param>
        /// <param name="login">login</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SalvarUsingPOST4AsyncWithHttpInfo (BinChavePersist binChavePersist, string login);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BinchaveresourceApi : IBinchaveresourceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinchaveresourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BinchaveresourceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BinchaveresourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BinchaveresourceApi(Configuration configuration = null)
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
        /// alterarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login</param> 
        /// <returns>Object</returns>
        public Object AlterarBinChaveUsingPUT (long? id, BinChaveUpdate request, string login)
        {
             ApiResponse<Object> localVarResponse = AlterarBinChaveUsingPUTWithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// alterarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AlterarBinChaveUsingPUTWithHttpInfo (long? id, BinChaveUpdate request, string login)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BinchaveresourceApi->AlterarBinChaveUsingPUT");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BinchaveresourceApi->AlterarBinChaveUsingPUT");
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling BinchaveresourceApi->AlterarBinChaveUsingPUT");
            
    
            var localVarPath = "/api/bins-chaves/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBinChaveUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBinChaveUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// alterarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AlterarBinChaveUsingPUTAsync (long? id, BinChaveUpdate request, string login)
        {
             ApiResponse<Object> localVarResponse = await AlterarBinChaveUsingPUTAsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// alterarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AlterarBinChaveUsingPUTAsyncWithHttpInfo (long? id, BinChaveUpdate request, string login)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarBinChaveUsingPUT");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarBinChaveUsingPUT");
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling AlterarBinChaveUsingPUT");
            
    
            var localVarPath = "/api/bins-chaves/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBinChaveUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBinChaveUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>Object</returns>
        public Object ConsultarUsingGET10 (long? id)
        {
             ApiResponse<Object> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BinchaveresourceApi->ConsultarUsingGET10");
            
    
            var localVarPath = "/api/bins-chaves/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<Object> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
            var localVarPath = "/api/bins-chaves/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// listarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id"> (optional)</param> 
        /// <param name="idTipoChave"> (optional)</param> 
        /// <param name="idBin"> (optional)</param> 
        /// <param name="chave"> (optional)</param> 
        /// <param name="checkValue"> (optional)</param> 
        /// <param name="validade"> (optional)</param> 
        /// <param name="flagDescriptografado"> (optional)</param> 
        /// <param name="label"> (optional)</param> 
        /// <returns>Object</returns>
        public Object ListarBinChaveUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null)
        {
             ApiResponse<Object> localVarResponse = ListarBinChaveUsingGETWithHttpInfo(sort, page, limit, id, idTipoChave, idBin, chave, checkValue, validade, flagDescriptografado, label);
             return localVarResponse.Data;
        }

        /// <summary>
        /// listarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id"> (optional)</param> 
        /// <param name="idTipoChave"> (optional)</param> 
        /// <param name="idBin"> (optional)</param> 
        /// <param name="chave"> (optional)</param> 
        /// <param name="checkValue"> (optional)</param> 
        /// <param name="validade"> (optional)</param> 
        /// <param name="flagDescriptografado"> (optional)</param> 
        /// <param name="label"> (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ListarBinChaveUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null)
        {
            
    
            var localVarPath = "/api/bins-chaves";
    
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
            if (idTipoChave != null) localVarQueryParams.Add("idTipoChave", Configuration.ApiClient.ParameterToString(idTipoChave)); // query parameter
            if (idBin != null) localVarQueryParams.Add("idBin", Configuration.ApiClient.ParameterToString(idBin)); // query parameter
            if (chave != null) localVarQueryParams.Add("chave", Configuration.ApiClient.ParameterToString(chave)); // query parameter
            if (checkValue != null) localVarQueryParams.Add("checkValue", Configuration.ApiClient.ParameterToString(checkValue)); // query parameter
            if (validade != null) localVarQueryParams.Add("validade", Configuration.ApiClient.ParameterToString(validade)); // query parameter
            if (flagDescriptografado != null) localVarQueryParams.Add("flagDescriptografado", Configuration.ApiClient.ParameterToString(flagDescriptografado)); // query parameter
            if (label != null) localVarQueryParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarBinChaveUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarBinChaveUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// listarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="idTipoChave"> (optional)</param>
        /// <param name="idBin"> (optional)</param>
        /// <param name="chave"> (optional)</param>
        /// <param name="checkValue"> (optional)</param>
        /// <param name="validade"> (optional)</param>
        /// <param name="flagDescriptografado"> (optional)</param>
        /// <param name="label"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ListarBinChaveUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null)
        {
             ApiResponse<Object> localVarResponse = await ListarBinChaveUsingGETAsyncWithHttpInfo(sort, page, limit, id, idTipoChave, idBin, chave, checkValue, validade, flagDescriptografado, label);
             return localVarResponse.Data;

        }

        /// <summary>
        /// listarBinChave 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="idTipoChave"> (optional)</param>
        /// <param name="idBin"> (optional)</param>
        /// <param name="chave"> (optional)</param>
        /// <param name="checkValue"> (optional)</param>
        /// <param name="validade"> (optional)</param>
        /// <param name="flagDescriptografado"> (optional)</param>
        /// <param name="label"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ListarBinChaveUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoChave = null, long? idBin = null, string chave = null, string checkValue = null, string validade = null, bool? flagDescriptografado = null, string label = null)
        {
            
    
            var localVarPath = "/api/bins-chaves";
    
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
            if (idTipoChave != null) localVarQueryParams.Add("idTipoChave", Configuration.ApiClient.ParameterToString(idTipoChave)); // query parameter
            if (idBin != null) localVarQueryParams.Add("idBin", Configuration.ApiClient.ParameterToString(idBin)); // query parameter
            if (chave != null) localVarQueryParams.Add("chave", Configuration.ApiClient.ParameterToString(chave)); // query parameter
            if (checkValue != null) localVarQueryParams.Add("checkValue", Configuration.ApiClient.ParameterToString(checkValue)); // query parameter
            if (validade != null) localVarQueryParams.Add("validade", Configuration.ApiClient.ParameterToString(validade)); // query parameter
            if (flagDescriptografado != null) localVarQueryParams.Add("flagDescriptografado", Configuration.ApiClient.ParameterToString(flagDescriptografado)); // query parameter
            if (label != null) localVarQueryParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarBinChaveUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarBinChaveUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// salvar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param> 
        /// <param name="login">login</param> 
        /// <returns>Object</returns>
        public Object SalvarUsingPOST4 (BinChavePersist binChavePersist, string login)
        {
             ApiResponse<Object> localVarResponse = SalvarUsingPOST4WithHttpInfo(binChavePersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// salvar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param> 
        /// <param name="login">login</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SalvarUsingPOST4WithHttpInfo (BinChavePersist binChavePersist, string login)
        {
            
            // verify the required parameter 'binChavePersist' is set
            if (binChavePersist == null)
                throw new ApiException(400, "Missing required parameter 'binChavePersist' when calling BinchaveresourceApi->SalvarUsingPOST4");
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling BinchaveresourceApi->SalvarUsingPOST4");
            
    
            var localVarPath = "/api/bins-chaves";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (binChavePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(binChavePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = binChavePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// salvar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param>
        /// <param name="login">login</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SalvarUsingPOST4Async (BinChavePersist binChavePersist, string login)
        {
             ApiResponse<Object> localVarResponse = await SalvarUsingPOST4AsyncWithHttpInfo(binChavePersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// salvar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binChavePersist">binChavePersist</param>
        /// <param name="login">login</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SalvarUsingPOST4AsyncWithHttpInfo (BinChavePersist binChavePersist, string login)
        {
            // verify the required parameter 'binChavePersist' is set
            if (binChavePersist == null) throw new ApiException(400, "Missing required parameter 'binChavePersist' when calling SalvarUsingPOST4");
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling SalvarUsingPOST4");
            
    
            var localVarPath = "/api/bins-chaves";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (binChavePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(binChavePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = binChavePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
