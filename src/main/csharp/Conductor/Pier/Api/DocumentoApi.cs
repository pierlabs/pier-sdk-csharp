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
    public interface IDocumentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse AtualizarUsingPUT (long? id, DocumentoTemplatePersist persist);
  
        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> AtualizarUsingPUTWithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse ConsultarUsingGET7 (long? id);
  
        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> ConsultarUsingGET7WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param>
        /// <returns>PageDocumentoTemplateResponse</returns>
        PageDocumentoTemplateResponse ListarUsingGET10 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null);
  
        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param>
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        ApiResponse<PageDocumentoTemplateResponse> ListarUsingGET10WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null);
        
        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoResponse</returns>
        DocumentoResponse SalvarUsingPOST5 (DocumentoParametrosRequest persist);
  
        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoResponse</returns>
        ApiResponse<DocumentoResponse> SalvarUsingPOST5WithHttpInfo (DocumentoParametrosRequest persist);
        
        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse SalvarUsingPOST6 (DocumentoTemplatePersist persist);
  
        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> SalvarUsingPOST6WithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Cadastra os tipos de documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTipoResponse</returns>
        DocumentoTipoResponse SalvarUsingPOST7 (DocumentoTipoRequest persist);
  
        /// <summary>
        /// Cadastra os tipos de documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTipoResponse</returns>
        ApiResponse<DocumentoTipoResponse> SalvarUsingPOST7WithHttpInfo (DocumentoTipoRequest persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarUsingPUTAsync (long? id, DocumentoTemplatePersist persist);

        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> ConsultarUsingGET7Async (long? id);

        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> ConsultarUsingGET7AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoTemplateResponse> ListarUsingGET10Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null);

        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> ListarUsingGET10AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null);
        
        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoResponse</returns>
        System.Threading.Tasks.Task<DocumentoResponse> SalvarUsingPOST5Async (DocumentoParametrosRequest persist);

        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoResponse>> SalvarUsingPOST5AsyncWithHttpInfo (DocumentoParametrosRequest persist);
        
        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> SalvarUsingPOST6Async (DocumentoTemplatePersist persist);

        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> SalvarUsingPOST6AsyncWithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Cadastra os tipos de documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTipoResponse</returns>
        System.Threading.Tasks.Task<DocumentoTipoResponse> SalvarUsingPOST7Async (DocumentoTipoRequest persist);

        /// <summary>
        /// Cadastra os tipos de documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTipoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTipoResponse>> SalvarUsingPOST7AsyncWithHttpInfo (DocumentoTipoRequest persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentoApi : IDocumentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentoApi(Configuration configuration = null)
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
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse AtualizarUsingPUT (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = AtualizarUsingPUTWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > AtualizarUsingPUTWithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->AtualizarUsingPUT");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->AtualizarUsingPUT");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarUsingPUTAsync (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await AtualizarUsingPUTAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AtualizarUsingPUT");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse ConsultarUsingGET7 (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = ConsultarUsingGET7WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > ConsultarUsingGET7WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->ConsultarUsingGET7");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> ConsultarUsingGET7Async (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await ConsultarUsingGET7AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> ConsultarUsingGET7AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET7");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param> 
        /// <returns>PageDocumentoTemplateResponse</returns>
        public PageDocumentoTemplateResponse ListarUsingGET10 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = ListarUsingGET10WithHttpInfo(sort, page, limit, idTipoDocumento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        public ApiResponse< PageDocumentoTemplateResponse > ListarUsingGET10WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null)
        {
            
    
            var localVarPath = "/api/templates-documentos";
    
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
            if (idTipoDocumento != null) localVarQueryParams.Add("idTipoDocumento", Configuration.ApiClient.ParameterToString(idTipoDocumento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoTemplateResponse> ListarUsingGET10Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = await ListarUsingGET10AsyncWithHttpInfo(sort, page, limit, idTipoDocumento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do documento. (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> ListarUsingGET10AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoDocumento = null)
        {
            
    
            var localVarPath = "/api/templates-documentos";
    
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
            if (idTipoDocumento != null) localVarQueryParams.Add("idTipoDocumento", Configuration.ApiClient.ParameterToString(idTipoDocumento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoResponse</returns>
        public DocumentoResponse SalvarUsingPOST5 (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoResponse> localVarResponse = SalvarUsingPOST5WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoResponse</returns>
        public ApiResponse< DocumentoResponse > SalvarUsingPOST5WithHttpInfo (DocumentoParametrosRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->SalvarUsingPOST5");
            
    
            var localVarPath = "/api/documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoResponse> SalvarUsingPOST5Async (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoResponse> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoResponse>> SalvarUsingPOST5AsyncWithHttpInfo (DocumentoParametrosRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST5");
            
    
            var localVarPath = "/api/documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoResponse)));
            
        }
        
        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse SalvarUsingPOST6 (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = SalvarUsingPOST6WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > SalvarUsingPOST6WithHttpInfo (DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->SalvarUsingPOST6");
            
    
            var localVarPath = "/api/templates-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> SalvarUsingPOST6Async (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await SalvarUsingPOST6AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> SalvarUsingPOST6AsyncWithHttpInfo (DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST6");
            
    
            var localVarPath = "/api/templates-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Cadastra os tipos de documentos Esse recurso permite cadastrar tipos de documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTipoResponse</returns>
        public DocumentoTipoResponse SalvarUsingPOST7 (DocumentoTipoRequest persist)
        {
             ApiResponse<DocumentoTipoResponse> localVarResponse = SalvarUsingPOST7WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra os tipos de documentos Esse recurso permite cadastrar tipos de documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTipoResponse</returns>
        public ApiResponse< DocumentoTipoResponse > SalvarUsingPOST7WithHttpInfo (DocumentoTipoRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->SalvarUsingPOST7");
            
    
            var localVarPath = "/api/tipos-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTipoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTipoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTipoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra os tipos de documentos Esse recurso permite cadastrar tipos de documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTipoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTipoResponse> SalvarUsingPOST7Async (DocumentoTipoRequest persist)
        {
             ApiResponse<DocumentoTipoResponse> localVarResponse = await SalvarUsingPOST7AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra os tipos de documentos Esse recurso permite cadastrar tipos de documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTipoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTipoResponse>> SalvarUsingPOST7AsyncWithHttpInfo (DocumentoTipoRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST7");
            
    
            var localVarPath = "/api/tipos-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTipoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTipoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTipoResponse)));
            
        }
        
    }
    
}
