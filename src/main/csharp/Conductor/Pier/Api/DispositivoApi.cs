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
    public interface IDispositivoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse AtivarDispositivo (long? id);
  
        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> AtivarDispositivoWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse DesativarDispositivo (long? id);
  
        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> DesativarDispositivoWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param>
        /// <returns>PageDispositivoResponse</returns>
        PageDispositivoResponse ListarDispositivos (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
  
        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param>
        /// <returns>ApiResponse of PageDispositivoResponse</returns>
        ApiResponse<PageDispositivoResponse> ListarDispositivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DispositivoResponse</returns>
        DispositivoResponse SalvarDispositivo (DispositivoPersist persist);
  
        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DispositivoResponse</returns>
        ApiResponse<DispositivoResponse> SalvarDispositivoWithHttpInfo (DispositivoPersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> AtivarDispositivoAsync (long? id);

        /// <summary>
        /// Ativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite ativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> AtivarDispositivoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> DesativarDispositivoAsync (long? id);

        /// <summary>
        /// Desativa Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar dispositivo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> DesativarDispositivoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param>
        /// <returns>Task of PageDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageDispositivoResponse> ListarDispositivosAsync (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);

        /// <summary>
        /// Lista os dispositivos cadastrados
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDispositivoResponse>> ListarDispositivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null);
        
        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DispositivoResponse</returns>
        System.Threading.Tasks.Task<DispositivoResponse> SalvarDispositivoAsync (DispositivoPersist persist);

        /// <summary>
        /// Cadastra Dispositivo
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar dispositivos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> SalvarDispositivoAsyncWithHttpInfo (DispositivoPersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DispositivoApi : IDispositivoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositivoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DispositivoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositivoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DispositivoApi(Configuration configuration = null)
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
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse AtivarDispositivo (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = AtivarDispositivoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > AtivarDispositivoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DispositivoApi->AtivarDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> AtivarDispositivoAsync (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await AtivarDispositivoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa Dispositivo Esse recurso permite ativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> AtivarDispositivoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse DesativarDispositivo (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = DesativarDispositivoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > DesativarDispositivoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DispositivoApi->DesativarDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> DesativarDispositivoAsync (long? id)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await DesativarDispositivoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa Dispositivo Esse recurso permite desativar dispositivo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> DesativarDispositivoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="token">Token do Dispositivo (optional)</param> 
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param> 
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param> 
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param> 
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param> 
        /// <returns>PageDispositivoResponse</returns>
        public PageDispositivoResponse ListarDispositivos (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivoResponse> localVarResponse = ListarDispositivosWithHttpInfo(sort, page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="token">Token do Dispositivo (optional)</param> 
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param> 
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param> 
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param> 
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param> 
        /// <returns>ApiResponse of PageDispositivoResponse</returns>
        public ApiResponse< PageDispositivoResponse > ListarDispositivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDispositivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDispositivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivoResponse)));
            
        }

        
        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param>
        /// <returns>Task of PageDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageDispositivoResponse> ListarDispositivosAsync (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
        {
             ApiResponse<PageDispositivoResponse> localVarResponse = await ListarDispositivosAsyncWithHttpInfo(sort, page, limit, token, idUsuario, idAplicacaoMobile, dataCriacao, dataDesativacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os dispositivos cadastrados Este m\u00E9todo permite que sejam listados os dispositivos existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="token">Token do Dispositivo (optional)</param>
        /// <param name="idUsuario">Identificador do Usu\u00E1rio (optional)</param>
        /// <param name="idAplicacaoMobile">Identificador da aplica\u00E7\u00E3o (optional)</param>
        /// <param name="dataCriacao">Apresenta a data e em que o registro foi criado (optional)</param>
        /// <param name="dataDesativacao">Apresenta a data e em que o registro foi desativado (optional)</param>
        /// <returns>Task of ApiResponse (PageDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDispositivoResponse>> ListarDispositivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string token = null, long? idUsuario = null, long? idAplicacaoMobile = null, string dataCriacao = null, string dataDesativacao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarDispositivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarDispositivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDispositivoResponse)));
            
        }
        
        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DispositivoResponse</returns>
        public DispositivoResponse SalvarDispositivo (DispositivoPersist persist)
        {
             ApiResponse<DispositivoResponse> localVarResponse = SalvarDispositivoWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DispositivoResponse</returns>
        public ApiResponse< DispositivoResponse > SalvarDispositivoWithHttpInfo (DispositivoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DispositivoApi->SalvarDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DispositivoResponse</returns>
        public async System.Threading.Tasks.Task<DispositivoResponse> SalvarDispositivoAsync (DispositivoPersist persist)
        {
             ApiResponse<DispositivoResponse> localVarResponse = await SalvarDispositivoAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra Dispositivo Esse recurso permite cadastrar dispositivos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DispositivoResponse>> SalvarDispositivoAsyncWithHttpInfo (DispositivoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarDispositivo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarDispositivo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarDispositivo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DispositivoResponse)));
            
        }
        
    }
    
}
