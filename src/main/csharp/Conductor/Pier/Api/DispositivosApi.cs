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
    public interface IDispositivosApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Dispositivo</returns>
        Dispositivo AtivarUsingPOST (long? id);
  
        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>ApiResponse of Dispositivo</returns>
        ApiResponse<Dispositivo> AtivarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Dispositivo</returns>
        Dispositivo DesativarUsingPOST (long? id);
  
        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>ApiResponse of Dispositivo</returns>
        ApiResponse<Dispositivo> DesativarUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param>
        /// <returns>PageDispositivos</returns>
        PageDispositivos ListarUsingGET7 (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
  
        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param>
        /// <returns>ApiResponse of PageDispositivos</returns>
        ApiResponse<PageDispositivos> ListarUsingGET7WithHttpInfo (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Dispositivo</returns>
        Dispositivo SalvarUsingPOST3 (DispositivoPersist persist);
  
        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of Dispositivo</returns>
        ApiResponse<Dispositivo> SalvarUsingPOST3WithHttpInfo (DispositivoPersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of Dispositivo</returns>
        System.Threading.Tasks.Task<Dispositivo> AtivarUsingPOSTAsync (long? id);

        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of ApiResponse (Dispositivo)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dispositivo>> AtivarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of Dispositivo</returns>
        System.Threading.Tasks.Task<Dispositivo> DesativarUsingPOSTAsync (long? id);

        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of ApiResponse (Dispositivo)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dispositivo>> DesativarUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param>
        /// <returns>Task of PageDispositivos</returns>
        System.Threading.Tasks.Task<PageDispositivos> ListarUsingGET7Async (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);

        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivos)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDispositivos>> ListarUsingGET7AsyncWithHttpInfo (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of Dispositivo</returns>
        System.Threading.Tasks.Task<Dispositivo> SalvarUsingPOST3Async (DispositivoPersist persist);

        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (Dispositivo)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dispositivo>> SalvarUsingPOST3AsyncWithHttpInfo (DispositivoPersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DispositivosApi : IDispositivosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositivosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DispositivosApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositivosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DispositivosApi(Configuration configuration = null)
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
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param> 
        /// <returns>Dispositivo</returns>
        public Dispositivo AtivarUsingPOST (long? id)
        {
             ApiResponse<Dispositivo> localVarResponse = AtivarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param> 
        /// <returns>ApiResponse of Dispositivo</returns>
        public ApiResponse< Dispositivo > AtivarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DispositivosApi->AtivarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Dispositivo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dispositivo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dispositivo)));
            
        }

        
        /// <summary>
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of Dispositivo</returns>
        public async System.Threading.Tasks.Task<Dispositivo> AtivarUsingPOSTAsync (long? id)
        {
             ApiResponse<Dispositivo> localVarResponse = await AtivarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of ApiResponse (Dispositivo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dispositivo>> AtivarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dispositivo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dispositivo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dispositivo)));
            
        }
        
        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param> 
        /// <returns>Dispositivo</returns>
        public Dispositivo DesativarUsingPOST (long? id)
        {
             ApiResponse<Dispositivo> localVarResponse = DesativarUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param> 
        /// <returns>ApiResponse of Dispositivo</returns>
        public ApiResponse< Dispositivo > DesativarUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DispositivosApi->DesativarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Dispositivo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dispositivo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dispositivo)));
            
        }

        
        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of Dispositivo</returns>
        public async System.Threading.Tasks.Task<Dispositivo> DesativarUsingPOSTAsync (long? id)
        {
             ApiResponse<Dispositivo> localVarResponse = await DesativarUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Plataforma (id).</param>
        /// <returns>Task of ApiResponse (Dispositivo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dispositivo>> DesativarUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dispositivo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dispositivo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dispositivo)));
            
        }
        
        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="token">Token do Dispositivo (optional)</param> 
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param> 
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param> 
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param> 
        /// <returns>PageDispositivos</returns>
        public PageDispositivos ListarUsingGET7 (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivos> localVarResponse = ListarUsingGET7WithHttpInfo(page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="token">Token do Dispositivo (optional)</param> 
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param> 
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param> 
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param> 
        /// <returns>ApiResponse of PageDispositivos</returns>
        public ApiResponse< PageDispositivos > ListarUsingGET7WithHttpInfo (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDispositivos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivos)));
            
        }

        
        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param>
        /// <returns>Task of PageDispositivos</returns>
        public async System.Threading.Tasks.Task<PageDispositivos> ListarUsingGET7Async (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivos> localVarResponse = await ListarUsingGET7AsyncWithHttpInfo(page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00C3\u00A9todo permite que sejam listados os dispositivos existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00C3\u00A1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado. (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado. (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivos)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDispositivos>> ListarUsingGET7AsyncWithHttpInfo (int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDispositivos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivos)));
            
        }
        
        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>Dispositivo</returns>
        public Dispositivo SalvarUsingPOST3 (DispositivoPersist persist)
        {
             ApiResponse<Dispositivo> localVarResponse = SalvarUsingPOST3WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of Dispositivo</returns>
        public ApiResponse< Dispositivo > SalvarUsingPOST3WithHttpInfo (DispositivoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DispositivosApi->SalvarUsingPOST3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Dispositivo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dispositivo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dispositivo)));
            
        }

        
        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of Dispositivo</returns>
        public async System.Threading.Tasks.Task<Dispositivo> SalvarUsingPOST3Async (DispositivoPersist persist)
        {
             ApiResponse<Dispositivo> localVarResponse = await SalvarUsingPOST3AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (Dispositivo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dispositivo>> SalvarUsingPOST3AsyncWithHttpInfo (DispositivoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Dispositivo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dispositivo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dispositivo)));
            
        }
        
    }
    
}
