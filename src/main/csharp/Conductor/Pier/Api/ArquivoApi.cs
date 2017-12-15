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
    public interface IArquivoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <returns>ArquivoResponse</returns>
        ArquivoResponse ConsultarUsingGET2 (long? id);
  
        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <returns>ApiResponse of ArquivoResponse</returns>
        ApiResponse<ArquivoResponse> ConsultarUsingGET2WithHttpInfo (long? id);
        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ArquivoResponse</returns>
        ArquivoResponse SalvarUsingPOST1 (ArquivoPersist arquivoPersist);
  
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ApiResponse of ArquivoResponse</returns>
        ApiResponse<ArquivoResponse> SalvarUsingPOST1WithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <returns>Task of ArquivoResponse</returns>
        System.Threading.Tasks.Task<ArquivoResponse> ConsultarUsingGET2Async (long? id);

        /// <summary>
        /// Consulta de arquivo no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <returns>Task of ApiResponse (ArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoResponse>> ConsultarUsingGET2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoResponse</returns>
        System.Threading.Tasks.Task<ArquivoResponse> SalvarUsingPOST1Async (ArquivoPersist arquivoPersist);

        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud
        /// </summary>
        /// <remarks>
        /// Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoResponse>> SalvarUsingPOST1AsyncWithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArquivoApi : IArquivoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArquivoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArquivoApi(Configuration configuration = null)
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
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param> 
        /// <returns>ArquivoResponse</returns>
        public ArquivoResponse ConsultarUsingGET2 (long? id)
        {
             ApiResponse<ArquivoResponse> localVarResponse = ConsultarUsingGET2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param> 
        /// <returns>ApiResponse of ArquivoResponse</returns>
        public ApiResponse< ArquivoResponse > ConsultarUsingGET2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArquivoApi->ConsultarUsingGET2");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoResponse)));
            
        }

        
        /// <summary>
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <returns>Task of ArquivoResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoResponse> ConsultarUsingGET2Async (long? id)
        {
             ApiResponse<ArquivoResponse> localVarResponse = await ConsultarUsingGET2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta de arquivo no PIER Cloud Este recurso permite consultar um determinado arquivo armazenado no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <returns>Task of ApiResponse (ArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoResponse>> ConsultarUsingGET2AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET2");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoResponse)));
            
        }
        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ArquivoResponse</returns>
        public ArquivoResponse SalvarUsingPOST1 (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoResponse> localVarResponse = SalvarUsingPOST1WithHttpInfo(arquivoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ApiResponse of ArquivoResponse</returns>
        public ApiResponse< ArquivoResponse > SalvarUsingPOST1WithHttpInfo (ArquivoPersist arquivoPersist)
        {
            
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null)
                throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling ArquivoApi->SalvarUsingPOST1");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoResponse)));
            
        }

        
        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoResponse> SalvarUsingPOST1Async (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoResponse> localVarResponse = await SalvarUsingPOST1AsyncWithHttpInfo(arquivoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite armazenar arquivos no PIER Cloud Este recurso permite o armazenamento de arquivos no PIER Cloud.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoResponse>> SalvarUsingPOST1AsyncWithHttpInfo (ArquivoPersist arquivoPersist)
        {
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null) throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling SalvarUsingPOST1");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoResponse)));
            
        }
        
    }
    
}
