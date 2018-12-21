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
    public interface IMultiAppApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>VinculoCartoesResponse</returns>
        VinculoCartoesResponse CriarCartoesMultiApp (CardMultiAppPersist cartaoMultiAppPersist);
  
        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        ApiResponse<VinculoCartoesResponse> CriarCartoesMultiAppWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist);
        
        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ContaMultiAppResponse</returns>
        ContaMultiAppResponse CriarContasMultiApp (CountMultiAppPersist contaMultiAppPersist);
  
        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        ApiResponse<ContaMultiAppResponse> CriarContasMultiAppWithHttpInfo (CountMultiAppPersist contaMultiAppPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppAsync (CardMultiAppPersist cartaoMultiAppPersist);

        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppAsyncWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist);
        
        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppAsync (CountMultiAppPersist contaMultiAppPersist);

        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppAsyncWithHttpInfo (CountMultiAppPersist contaMultiAppPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MultiAppApi : IMultiAppApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiAppApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MultiAppApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiAppApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MultiAppApi(Configuration configuration = null)
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
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>VinculoCartoesResponse</returns>
        public VinculoCartoesResponse CriarCartoesMultiApp (CardMultiAppPersist cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = CriarCartoesMultiAppWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        public ApiResponse< VinculoCartoesResponse > CriarCartoesMultiAppWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist)
        {
            
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling MultiAppApi->CriarCartoesMultiApp");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
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
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }

        
        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        public async System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppAsync (CardMultiAppPersist cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = await CriarCartoesMultiAppAsyncWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppAsyncWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist)
        {
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling CriarCartoesMultiApp");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
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
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }
        
        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ContaMultiAppResponse</returns>
        public ContaMultiAppResponse CriarContasMultiApp (CountMultiAppPersist contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = CriarContasMultiAppWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        public ApiResponse< ContaMultiAppResponse > CriarContasMultiAppWithHttpInfo (CountMultiAppPersist contaMultiAppPersist)
        {
            
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling MultiAppApi->CriarContasMultiApp");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
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
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }

        
        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        public async System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppAsync (CountMultiAppPersist contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = await CriarContasMultiAppAsyncWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppAsyncWithHttpInfo (CountMultiAppPersist contaMultiAppPersist)
        {
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling CriarContasMultiApp");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
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
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }
        
    }
    
}
