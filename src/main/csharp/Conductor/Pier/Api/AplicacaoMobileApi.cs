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
    public interface IAplicacaoMobileApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param>
        /// <param name="update">update</param>
        /// <returns>AplicacaoMobileResponse</returns>
        AplicacaoMobileResponse Atualizar (long? id, AplicacaoMobileUpdate update);
  
        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        ApiResponse<AplicacaoMobileResponse> AtualizarWithHttpInfo (long? id, AplicacaoMobileUpdate update);
        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>PageAplicacaoMobileResponse</returns>
        PageAplicacaoMobileResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
  
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>ApiResponse of PageAplicacaoMobileResponse</returns>
        ApiResponse<PageAplicacaoMobileResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
        
        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>AplicacaoMobileResponse</returns>
        AplicacaoMobileResponse Salvar (AplicacaoMobilePersist persist);
  
        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        ApiResponse<AplicacaoMobileResponse> SalvarWithHttpInfo (AplicacaoMobilePersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        System.Threading.Tasks.Task<AplicacaoMobileResponse> AtualizarAsync (long? id, AplicacaoMobileUpdate update);

        /// <summary>
        /// Atualiza Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar aplicacao mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> AtualizarAsyncWithHttpInfo (long? id, AplicacaoMobileUpdate update);
        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of PageAplicacaoMobileResponse</returns>
        System.Threading.Tasks.Task<PageAplicacaoMobileResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);

        /// <summary>
        /// Lista os aplicacoes mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of ApiResponse (PageAplicacaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAplicacaoMobileResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null);
        
        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        System.Threading.Tasks.Task<AplicacaoMobileResponse> SalvarAsync (AplicacaoMobilePersist persist);

        /// <summary>
        /// Cadastra Aplicacao Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar aplicacoes mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> SalvarAsyncWithHttpInfo (AplicacaoMobilePersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AplicacaoMobileApi : IAplicacaoMobileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoMobileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AplicacaoMobileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoMobileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AplicacaoMobileApi(Configuration configuration = null)
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
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>AplicacaoMobileResponse</returns>
        public AplicacaoMobileResponse Atualizar (long? id, AplicacaoMobileUpdate update)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = AtualizarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        public ApiResponse< AplicacaoMobileResponse > AtualizarWithHttpInfo (long? id, AplicacaoMobileUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AplicacaoMobileApi->Atualizar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling AplicacaoMobileApi->Atualizar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }

        
        /// <summary>
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<AplicacaoMobileResponse> AtualizarAsync (long? id, AplicacaoMobileUpdate update)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza Aplicacao Mobile Esse recurso permite atualizar aplicacao mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Aplicacao (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> AtualizarAsyncWithHttpInfo (long? id, AplicacaoMobileUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Atualizar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }
        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param> 
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param> 
        /// <returns>PageAplicacaoMobileResponse</returns>
        public PageAplicacaoMobileResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
             ApiResponse<PageAplicacaoMobileResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, id, idPlataformaMobile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param> 
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param> 
        /// <returns>ApiResponse of PageAplicacaoMobileResponse</returns>
        public ApiResponse< PageAplicacaoMobileResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAplicacaoMobileResponse)));
            
        }

        
        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of PageAplicacaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<PageAplicacaoMobileResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
        {
             ApiResponse<PageAplicacaoMobileResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, id, idPlataformaMobile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os aplicacoes mobile cadastradas Este m\u00E9todo permite que sejam listadas as aplicacoes mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identificador da Aplicacao Mobile (optional)</param>
        /// <param name="idPlataformaMobile">Identificador da Plataforma Mobile (optional)</param>
        /// <returns>Task of ApiResponse (PageAplicacaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAplicacaoMobileResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string id = null, long? idPlataformaMobile = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAplicacaoMobileResponse)));
            
        }
        
        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>AplicacaoMobileResponse</returns>
        public AplicacaoMobileResponse Salvar (AplicacaoMobilePersist persist)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AplicacaoMobileResponse</returns>
        public ApiResponse< AplicacaoMobileResponse > SalvarWithHttpInfo (AplicacaoMobilePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling AplicacaoMobileApi->Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }

        
        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of AplicacaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<AplicacaoMobileResponse> SalvarAsync (AplicacaoMobilePersist persist)
        {
             ApiResponse<AplicacaoMobileResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra Aplicacao Mobile Esse recurso permite cadastrar aplicacoes mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AplicacaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AplicacaoMobileResponse>> SalvarAsyncWithHttpInfo (AplicacaoMobilePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AplicacaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AplicacaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AplicacaoMobileResponse)));
            
        }
        
    }
    
}
