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
    public interface IAplicacoesMobileApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param>
        /// <param name="update">update</param>
        /// <returns>AplicacaoMobile</returns>
        AplicacaoMobile AtualizarUsingPUT (long? id, AplicacaoMobileUpdate update);
  
        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of AplicacaoMobile</returns>
        ApiResponse<AplicacaoMobile> AtualizarUsingPUTWithHttpInfo (long? id, AplicacaoMobileUpdate update);
        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>PageAplicacoesMobile</returns>
        PageAplicacoesMobile ListarUsingGET (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
  
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>ApiResponse of PageAplicacoesMobile</returns>
        ApiResponse<PageAplicacoesMobile> ListarUsingGETWithHttpInfo (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
        
        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>AplicacaoMobile</returns>
        AplicacaoMobile SalvarUsingPOST (AplicacaoMobilePersist persist);
  
        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AplicacaoMobile</returns>
        ApiResponse<AplicacaoMobile> SalvarUsingPOSTWithHttpInfo (AplicacaoMobilePersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of AplicacaoMobile</returns>
        System.Threading.Tasks.Task<AplicacaoMobile> AtualizarUsingPUTAsync (long? id, AplicacaoMobileUpdate update);

        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (AplicacaoMobile)</returns>
        System.Threading.Tasks.Task<ApiResponse<AplicacaoMobile>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, AplicacaoMobileUpdate update);
        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of PageAplicacoesMobile</returns>
        System.Threading.Tasks.Task<PageAplicacoesMobile> ListarUsingGETAsync (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);

        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of ApiResponse (PageAplicacoesMobile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAplicacoesMobile>> ListarUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
        
        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of AplicacaoMobile</returns>
        System.Threading.Tasks.Task<AplicacaoMobile> SalvarUsingPOSTAsync (AplicacaoMobilePersist persist);

        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AplicacaoMobile)</returns>
        System.Threading.Tasks.Task<ApiResponse<AplicacaoMobile>> SalvarUsingPOSTAsyncWithHttpInfo (AplicacaoMobilePersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AplicacoesMobileApi : IAplicacoesMobileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacoesMobileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AplicacoesMobileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacoesMobileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AplicacoesMobileApi(Configuration configuration = null)
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
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>AplicacaoMobile</returns>
        public AplicacaoMobile AtualizarUsingPUT (long? id, AplicacaoMobileUpdate update)
        {
             ApiResponse<AplicacaoMobile> localVarResponse = AtualizarUsingPUTWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of AplicacaoMobile</returns>
        public ApiResponse< AplicacaoMobile > AtualizarUsingPUTWithHttpInfo (long? id, AplicacaoMobileUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AplicacoesMobileApi->AtualizarUsingPUT");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling AplicacoesMobileApi->AtualizarUsingPUT");
            
    
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
    
            return new ApiResponse<AplicacaoMobile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobile)));
            
        }

        
        /// <summary>
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of AplicacaoMobile</returns>
        public async System.Threading.Tasks.Task<AplicacaoMobile> AtualizarUsingPUTAsync (long? id, AplicacaoMobileUpdate update)
        {
             ApiResponse<AplicacaoMobile> localVarResponse = await AtualizarUsingPUTAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Aplicacao (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (AplicacaoMobile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AplicacaoMobile>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, AplicacaoMobileUpdate update)
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

            return new ApiResponse<AplicacaoMobile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobile)));
            
        }
        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param> 
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param> 
        /// <returns>PageAplicacoesMobile</returns>
        public PageAplicacoesMobile ListarUsingGET (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
             ApiResponse<PageAplicacoesMobile> localVarResponse = ListarUsingGETWithHttpInfo(page, limit, id, idPlataformaMobile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param> 
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param> 
        /// <returns>ApiResponse of PageAplicacoesMobile</returns>
        public ApiResponse< PageAplicacoesMobile > ListarUsingGETWithHttpInfo (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAplicacoesMobile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAplicacoesMobile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAplicacoesMobile)));
            
        }

        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of PageAplicacoesMobile</returns>
        public async System.Threading.Tasks.Task<PageAplicacoesMobile> ListarUsingGETAsync (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
             ApiResponse<PageAplicacoesMobile> localVarResponse = await ListarUsingGETAsyncWithHttpInfo(page, limit, id, idPlataformaMobile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00C3\u00A9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of ApiResponse (PageAplicacoesMobile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAplicacoesMobile>> ListarUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAplicacoesMobile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAplicacoesMobile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAplicacoesMobile)));
            
        }
        
        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>AplicacaoMobile</returns>
        public AplicacaoMobile SalvarUsingPOST (AplicacaoMobilePersist persist)
        {
             ApiResponse<AplicacaoMobile> localVarResponse = SalvarUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AplicacaoMobile</returns>
        public ApiResponse< AplicacaoMobile > SalvarUsingPOSTWithHttpInfo (AplicacaoMobilePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling AplicacoesMobileApi->SalvarUsingPOST");
            
    
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
    
            return new ApiResponse<AplicacaoMobile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobile)));
            
        }

        
        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of AplicacaoMobile</returns>
        public async System.Threading.Tasks.Task<AplicacaoMobile> SalvarUsingPOSTAsync (AplicacaoMobilePersist persist)
        {
             ApiResponse<AplicacaoMobile> localVarResponse = await SalvarUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AplicacaoMobile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AplicacaoMobile>> SalvarUsingPOSTAsyncWithHttpInfo (AplicacaoMobilePersist persist)
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

            return new ApiResponse<AplicacaoMobile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobile)));
            
        }
        
    }
    
}
