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
    public interface IDeviceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Activate devices
        /// </summary>
        /// <remarks>
        /// This resource allows to activate devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse Ativar (long? id);
  
        /// <summary>
        /// Activate devices
        /// </summary>
        /// <remarks>
        /// This resource allows to activate devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> AtivarWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable Device
        /// </summary>
        /// <remarks>
        /// This resource allows to disable device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse Desativar (long? id);
  
        /// <summary>
        /// Disable Device
        /// </summary>
        /// <remarks>
        /// This resource allows to disable device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> DesativarWithHttpInfo (long? id);
        
        /// <summary>
        /// List the devices registered
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent devices in the base of PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token of the Device (optional)</param>
        /// <param name="idUsuario">User identifier (optional)</param>
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param>
        /// <param name="dataCriacao">List the date that the register was created (optional)</param>
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param>
        /// <returns>PageDispositivoResponse</returns>
        PageDispositivoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
  
        /// <summary>
        /// List the devices registered
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent devices in the base of PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token of the Device (optional)</param>
        /// <param name="idUsuario">User identifier (optional)</param>
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param>
        /// <param name="dataCriacao">List the date that the register was created (optional)</param>
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param>
        /// <returns>ApiResponse of PageDispositivoResponse</returns>
        ApiResponse<PageDispositivoResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// Create Device
        /// </summary>
        /// <remarks>
        /// This resource allows to create devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse Salvar (DevicePersist persist);
  
        /// <summary>
        /// Create Device
        /// </summary>
        /// <remarks>
        /// This resource allows to create devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> SalvarWithHttpInfo (DevicePersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Activate devices
        /// </summary>
        /// <remarks>
        /// This resource allows to activate devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> AtivarAsync (long? id);

        /// <summary>
        /// Activate devices
        /// </summary>
        /// <remarks>
        /// This resource allows to activate devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> AtivarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable Device
        /// </summary>
        /// <remarks>
        /// This resource allows to disable device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> DesativarAsync (long? id);

        /// <summary>
        /// Disable Device
        /// </summary>
        /// <remarks>
        /// This resource allows to disable device
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> DesativarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the devices registered
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent devices in the base of PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token of the Device (optional)</param>
        /// <param name="idUsuario">User identifier (optional)</param>
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param>
        /// <param name="dataCriacao">List the date that the register was created (optional)</param>
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param>
        /// <returns>Task of PageDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageDispositivoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);

        /// <summary>
        /// List the devices registered
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent devices in the base of PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token of the Device (optional)</param>
        /// <param name="idUsuario">User identifier (optional)</param>
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param>
        /// <param name="dataCriacao">List the date that the register was created (optional)</param>
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDispositivoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// Create Device
        /// </summary>
        /// <remarks>
        /// This resource allows to create devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> SalvarAsync (DevicePersist persist);

        /// <summary>
        /// Create Device
        /// </summary>
        /// <remarks>
        /// This resource allows to create devices
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> SalvarAsyncWithHttpInfo (DevicePersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DeviceApi : IDeviceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeviceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeviceApi(Configuration configuration = null)
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
        /// Activate devices This resource allows to activate devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse Ativar (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = AtivarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activate devices This resource allows to activate devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > AtivarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DeviceApi->Ativar");
            
    
            var localVarPath = "/api/dispositivos/{id}/ativar-dispositivo";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Ativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Ativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// Activate devices This resource allows to activate devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> AtivarAsync (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await AtivarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activate devices This resource allows to activate devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> AtivarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Ativar");
            
    
            var localVarPath = "/api/dispositivos/{id}/ativar-dispositivo";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Ativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Ativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
        /// <summary>
        /// Disable Device This resource allows to disable device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse Desativar (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = DesativarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable Device This resource allows to disable device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > DesativarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DeviceApi->Desativar");
            
    
            var localVarPath = "/api/dispositivos/{id}/desativar-dispositivo";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// Disable Device This resource allows to disable device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> DesativarAsync (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await DesativarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable Device This resource allows to disable device
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Platform (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> DesativarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Desativar");
            
    
            var localVarPath = "/api/dispositivos/{id}/desativar-dispositivo";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
        /// <summary>
        /// List the devices registered This method allows to be listed the existent devices in the base of PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="token">Token of the Device (optional)</param> 
        /// <param name="idUsuario">User identifier (optional)</param> 
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param> 
        /// <param name="dataCriacao">List the date that the register was created (optional)</param> 
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param> 
        /// <returns>PageDispositivoResponse</returns>
        public PageDispositivoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivoResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the devices registered This method allows to be listed the existent devices in the base of PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="token">Token of the Device (optional)</param> 
        /// <param name="idUsuario">User identifier (optional)</param> 
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param> 
        /// <param name="dataCriacao">List the date that the register was created (optional)</param> 
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param> 
        /// <returns>ApiResponse of PageDispositivoResponse</returns>
        public ApiResponse< PageDispositivoResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
            
    
            var localVarPath = "/api/dispositivos";
    
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (idAplicacaoMobile != null) localVarQueryParams.Add("idAplicacaoMobile", Configuration.ApiClient.ParameterToString(idAplicacaoMobile)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (dataDesativacao != null) localVarQueryParams.Add("dataDesativacao", Configuration.ApiClient.ParameterToString(dataDesativacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivoResponse)));
            
        }

        
        /// <summary>
        /// List the devices registered This method allows to be listed the existent devices in the base of PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token of the Device (optional)</param>
        /// <param name="idUsuario">User identifier (optional)</param>
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param>
        /// <param name="dataCriacao">List the date that the register was created (optional)</param>
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param>
        /// <returns>Task of PageDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageDispositivoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivoResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the devices registered This method allows to be listed the existent devices in the base of PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token of the Device (optional)</param>
        /// <param name="idUsuario">User identifier (optional)</param>
        /// <param name="idAplicacaoMobile">Application identifier (optional)</param>
        /// <param name="dataCriacao">List the date that the register was created (optional)</param>
        /// <param name="dataDesativacao">List the date that the register was deactivated (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDispositivoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
            
    
            var localVarPath = "/api/dispositivos";
    
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
            if (token != null) localVarQueryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (idAplicacaoMobile != null) localVarQueryParams.Add("idAplicacaoMobile", Configuration.ApiClient.ParameterToString(idAplicacaoMobile)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (dataDesativacao != null) localVarQueryParams.Add("dataDesativacao", Configuration.ApiClient.ParameterToString(dataDesativacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Create Device This resource allows to create devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse Salvar (DevicePersist persist)
        {
             ApiResponse<DispositivoResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Device This resource allows to create devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > SalvarWithHttpInfo (DevicePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DeviceApi->Salvar");
            
    
            var localVarPath = "/api/dispositivos";
    
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
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// Create Device This resource allows to create devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> SalvarAsync (DevicePersist persist)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Device This resource allows to create devices
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> SalvarAsyncWithHttpInfo (DevicePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
            var localVarPath = "/api/dispositivos";
    
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

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
    }
    
}
