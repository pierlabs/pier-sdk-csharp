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
    public interface ITipoplasticoresourceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// alterarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <returns>TipoPlasticoResponse</returns>
        TipoPlasticoResponse AlterarTipoPlastico (long? id, TipoPlasticoPersist request);
  
        /// <summary>
        /// alterarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of TipoPlasticoResponse</returns>
        ApiResponse<TipoPlasticoResponse> AlterarTipoPlasticoWithHttpInfo (long? id, TipoPlasticoPersist request);
        
        /// <summary>
        /// cadastrarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>TipoPlasticoResponse</returns>
        TipoPlasticoResponse CadastrarTipoPlastico (TipoPlasticoPersist request);
  
        /// <summary>
        /// cadastrarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of TipoPlasticoResponse</returns>
        ApiResponse<TipoPlasticoResponse> CadastrarTipoPlasticoWithHttpInfo (TipoPlasticoPersist request);
        
        /// <summary>
        /// consultarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>TipoPlasticoResponse</returns>
        TipoPlasticoResponse ConsultarTipoPlastico (long? id);
  
        /// <summary>
        /// consultarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of TipoPlasticoResponse</returns>
        ApiResponse<TipoPlasticoResponse> ConsultarTipoPlasticoWithHttpInfo (long? id);
        
        /// <summary>
        /// listarTiposPlasticos
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="idEntidade"> (optional)</param>
        /// <param name="fabrica"> (optional)</param>
        /// <param name="tamanhoLinhas"> (optional)</param>
        /// <param name="bandeirado"> (optional)</param>
        /// <param name="valorEmissao"> (optional)</param>
        /// <param name="nomeArquivo"> (optional)</param>
        /// <returns>PageTipoPlasticoResponse</returns>
        PageTipoPlasticoResponse ListarTiposPlasticos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null);
  
        /// <summary>
        /// listarTiposPlasticos
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="idEntidade"> (optional)</param>
        /// <param name="fabrica"> (optional)</param>
        /// <param name="tamanhoLinhas"> (optional)</param>
        /// <param name="bandeirado"> (optional)</param>
        /// <param name="valorEmissao"> (optional)</param>
        /// <param name="nomeArquivo"> (optional)</param>
        /// <returns>ApiResponse of PageTipoPlasticoResponse</returns>
        ApiResponse<PageTipoPlasticoResponse> ListarTiposPlasticosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// alterarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <returns>Task of TipoPlasticoResponse</returns>
        System.Threading.Tasks.Task<TipoPlasticoResponse> AlterarTipoPlasticoAsync (long? id, TipoPlasticoPersist request);

        /// <summary>
        /// alterarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (TipoPlasticoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoPlasticoResponse>> AlterarTipoPlasticoAsyncWithHttpInfo (long? id, TipoPlasticoPersist request);
        
        /// <summary>
        /// cadastrarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of TipoPlasticoResponse</returns>
        System.Threading.Tasks.Task<TipoPlasticoResponse> CadastrarTipoPlasticoAsync (TipoPlasticoPersist request);

        /// <summary>
        /// cadastrarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (TipoPlasticoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoPlasticoResponse>> CadastrarTipoPlasticoAsyncWithHttpInfo (TipoPlasticoPersist request);
        
        /// <summary>
        /// consultarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of TipoPlasticoResponse</returns>
        System.Threading.Tasks.Task<TipoPlasticoResponse> ConsultarTipoPlasticoAsync (long? id);

        /// <summary>
        /// consultarTipoPlastico
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (TipoPlasticoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoPlasticoResponse>> ConsultarTipoPlasticoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// listarTiposPlasticos
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="idEntidade"> (optional)</param>
        /// <param name="fabrica"> (optional)</param>
        /// <param name="tamanhoLinhas"> (optional)</param>
        /// <param name="bandeirado"> (optional)</param>
        /// <param name="valorEmissao"> (optional)</param>
        /// <param name="nomeArquivo"> (optional)</param>
        /// <returns>Task of PageTipoPlasticoResponse</returns>
        System.Threading.Tasks.Task<PageTipoPlasticoResponse> ListarTiposPlasticosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null);

        /// <summary>
        /// listarTiposPlasticos
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="idEntidade"> (optional)</param>
        /// <param name="fabrica"> (optional)</param>
        /// <param name="tamanhoLinhas"> (optional)</param>
        /// <param name="bandeirado"> (optional)</param>
        /// <param name="valorEmissao"> (optional)</param>
        /// <param name="nomeArquivo"> (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoPlasticoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoPlasticoResponse>> ListarTiposPlasticosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TipoplasticoresourceApi : ITipoplasticoresourceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoplasticoresourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TipoplasticoresourceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoplasticoresourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TipoplasticoresourceApi(Configuration configuration = null)
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
        /// alterarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <returns>TipoPlasticoResponse</returns>
        public TipoPlasticoResponse AlterarTipoPlastico (long? id, TipoPlasticoPersist request)
        {
             ApiResponse<TipoPlasticoResponse> localVarResponse = AlterarTipoPlasticoWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// alterarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of TipoPlasticoResponse</returns>
        public ApiResponse< TipoPlasticoResponse > AlterarTipoPlasticoWithHttpInfo (long? id, TipoPlasticoPersist request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TipoplasticoresourceApi->AlterarTipoPlastico");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TipoplasticoresourceApi->AlterarTipoPlastico");
            
    
            var localVarPath = "/api/tipos-plasticos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoPlastico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoPlastico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoPlasticoResponse)));
            
        }

        
        /// <summary>
        /// alterarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <returns>Task of TipoPlasticoResponse</returns>
        public async System.Threading.Tasks.Task<TipoPlasticoResponse> AlterarTipoPlasticoAsync (long? id, TipoPlasticoPersist request)
        {
             ApiResponse<TipoPlasticoResponse> localVarResponse = await AlterarTipoPlasticoAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// alterarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (TipoPlasticoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoPlasticoResponse>> AlterarTipoPlasticoAsyncWithHttpInfo (long? id, TipoPlasticoPersist request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTipoPlastico");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarTipoPlastico");
            
    
            var localVarPath = "/api/tipos-plasticos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoPlastico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoPlastico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoPlasticoResponse)));
            
        }
        
        /// <summary>
        /// cadastrarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>TipoPlasticoResponse</returns>
        public TipoPlasticoResponse CadastrarTipoPlastico (TipoPlasticoPersist request)
        {
             ApiResponse<TipoPlasticoResponse> localVarResponse = CadastrarTipoPlasticoWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// cadastrarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of TipoPlasticoResponse</returns>
        public ApiResponse< TipoPlasticoResponse > CadastrarTipoPlasticoWithHttpInfo (TipoPlasticoPersist request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TipoplasticoresourceApi->CadastrarTipoPlastico");
            
    
            var localVarPath = "/api/tipos-plasticos";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoPlastico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoPlastico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoPlasticoResponse)));
            
        }

        
        /// <summary>
        /// cadastrarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of TipoPlasticoResponse</returns>
        public async System.Threading.Tasks.Task<TipoPlasticoResponse> CadastrarTipoPlasticoAsync (TipoPlasticoPersist request)
        {
             ApiResponse<TipoPlasticoResponse> localVarResponse = await CadastrarTipoPlasticoAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// cadastrarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (TipoPlasticoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoPlasticoResponse>> CadastrarTipoPlasticoAsyncWithHttpInfo (TipoPlasticoPersist request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling CadastrarTipoPlastico");
            
    
            var localVarPath = "/api/tipos-plasticos";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoPlastico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoPlastico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoPlasticoResponse)));
            
        }
        
        /// <summary>
        /// consultarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>TipoPlasticoResponse</returns>
        public TipoPlasticoResponse ConsultarTipoPlastico (long? id)
        {
             ApiResponse<TipoPlasticoResponse> localVarResponse = ConsultarTipoPlasticoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// consultarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of TipoPlasticoResponse</returns>
        public ApiResponse< TipoPlasticoResponse > ConsultarTipoPlasticoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TipoplasticoresourceApi->ConsultarTipoPlastico");
            
    
            var localVarPath = "/api/tipos-plasticos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoPlastico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoPlastico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoPlasticoResponse)));
            
        }

        
        /// <summary>
        /// consultarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of TipoPlasticoResponse</returns>
        public async System.Threading.Tasks.Task<TipoPlasticoResponse> ConsultarTipoPlasticoAsync (long? id)
        {
             ApiResponse<TipoPlasticoResponse> localVarResponse = await ConsultarTipoPlasticoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// consultarTipoPlastico 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (TipoPlasticoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoPlasticoResponse>> ConsultarTipoPlasticoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoPlastico");
            
    
            var localVarPath = "/api/tipos-plasticos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoPlastico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoPlastico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoPlasticoResponse)));
            
        }
        
        /// <summary>
        /// listarTiposPlasticos 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome"> (optional)</param> 
        /// <param name="idEntidade"> (optional)</param> 
        /// <param name="fabrica"> (optional)</param> 
        /// <param name="tamanhoLinhas"> (optional)</param> 
        /// <param name="bandeirado"> (optional)</param> 
        /// <param name="valorEmissao"> (optional)</param> 
        /// <param name="nomeArquivo"> (optional)</param> 
        /// <returns>PageTipoPlasticoResponse</returns>
        public PageTipoPlasticoResponse ListarTiposPlasticos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null)
        {
             ApiResponse<PageTipoPlasticoResponse> localVarResponse = ListarTiposPlasticosWithHttpInfo(sort, page, limit, nome, idEntidade, fabrica, tamanhoLinhas, bandeirado, valorEmissao, nomeArquivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// listarTiposPlasticos 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome"> (optional)</param> 
        /// <param name="idEntidade"> (optional)</param> 
        /// <param name="fabrica"> (optional)</param> 
        /// <param name="tamanhoLinhas"> (optional)</param> 
        /// <param name="bandeirado"> (optional)</param> 
        /// <param name="valorEmissao"> (optional)</param> 
        /// <param name="nomeArquivo"> (optional)</param> 
        /// <returns>ApiResponse of PageTipoPlasticoResponse</returns>
        public ApiResponse< PageTipoPlasticoResponse > ListarTiposPlasticosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null)
        {
            
    
            var localVarPath = "/api/tipos-plasticos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idEntidade != null) localVarQueryParams.Add("idEntidade", Configuration.ApiClient.ParameterToString(idEntidade)); // query parameter
            if (fabrica != null) localVarQueryParams.Add("fabrica", Configuration.ApiClient.ParameterToString(fabrica)); // query parameter
            if (tamanhoLinhas != null) localVarQueryParams.Add("tamanhoLinhas", Configuration.ApiClient.ParameterToString(tamanhoLinhas)); // query parameter
            if (bandeirado != null) localVarQueryParams.Add("bandeirado", Configuration.ApiClient.ParameterToString(bandeirado)); // query parameter
            if (valorEmissao != null) localVarQueryParams.Add("valorEmissao", Configuration.ApiClient.ParameterToString(valorEmissao)); // query parameter
            if (nomeArquivo != null) localVarQueryParams.Add("nomeArquivo", Configuration.ApiClient.ParameterToString(nomeArquivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposPlasticos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposPlasticos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoPlasticoResponse)));
            
        }

        
        /// <summary>
        /// listarTiposPlasticos 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="idEntidade"> (optional)</param>
        /// <param name="fabrica"> (optional)</param>
        /// <param name="tamanhoLinhas"> (optional)</param>
        /// <param name="bandeirado"> (optional)</param>
        /// <param name="valorEmissao"> (optional)</param>
        /// <param name="nomeArquivo"> (optional)</param>
        /// <returns>Task of PageTipoPlasticoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoPlasticoResponse> ListarTiposPlasticosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null)
        {
             ApiResponse<PageTipoPlasticoResponse> localVarResponse = await ListarTiposPlasticosAsyncWithHttpInfo(sort, page, limit, nome, idEntidade, fabrica, tamanhoLinhas, bandeirado, valorEmissao, nomeArquivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// listarTiposPlasticos 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="idEntidade"> (optional)</param>
        /// <param name="fabrica"> (optional)</param>
        /// <param name="tamanhoLinhas"> (optional)</param>
        /// <param name="bandeirado"> (optional)</param>
        /// <param name="valorEmissao"> (optional)</param>
        /// <param name="nomeArquivo"> (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoPlasticoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoPlasticoResponse>> ListarTiposPlasticosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idEntidade = null, string fabrica = null, string tamanhoLinhas = null, bool? bandeirado = null, double? valorEmissao = null, string nomeArquivo = null)
        {
            
    
            var localVarPath = "/api/tipos-plasticos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idEntidade != null) localVarQueryParams.Add("idEntidade", Configuration.ApiClient.ParameterToString(idEntidade)); // query parameter
            if (fabrica != null) localVarQueryParams.Add("fabrica", Configuration.ApiClient.ParameterToString(fabrica)); // query parameter
            if (tamanhoLinhas != null) localVarQueryParams.Add("tamanhoLinhas", Configuration.ApiClient.ParameterToString(tamanhoLinhas)); // query parameter
            if (bandeirado != null) localVarQueryParams.Add("bandeirado", Configuration.ApiClient.ParameterToString(bandeirado)); // query parameter
            if (valorEmissao != null) localVarQueryParams.Add("valorEmissao", Configuration.ApiClient.ParameterToString(valorEmissao)); // query parameter
            if (nomeArquivo != null) localVarQueryParams.Add("nomeArquivo", Configuration.ApiClient.ParameterToString(nomeArquivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposPlasticos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposPlasticos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoPlasticoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoPlasticoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoPlasticoResponse)));
            
        }
        
    }
    
}
