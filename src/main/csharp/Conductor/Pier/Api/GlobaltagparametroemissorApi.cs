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
    public interface IGlobaltagparametroemissorApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{parametro_emissor_recurso}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_emissor_recurso_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param>
        /// <returns>ParametroEmissorResponse</returns>
        ParametroEmissorResponse ConsultarUsingGET27 (string codigo);
  
        /// <summary>
        /// {{{parametro_emissor_recurso}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_emissor_recurso_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param>
        /// <returns>ApiResponse of ParametroEmissorResponse</returns>
        ApiResponse<ParametroEmissorResponse> ConsultarUsingGET27WithHttpInfo (string codigo);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{parametro_emissor_recurso}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_emissor_recurso_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param>
        /// <returns>Task of ParametroEmissorResponse</returns>
        System.Threading.Tasks.Task<ParametroEmissorResponse> ConsultarUsingGET27Async (string codigo);

        /// <summary>
        /// {{{parametro_emissor_recurso}}}
        /// </summary>
        /// <remarks>
        /// {{{parametro_emissor_recurso_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param>
        /// <returns>Task of ApiResponse (ParametroEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroEmissorResponse>> ConsultarUsingGET27AsyncWithHttpInfo (string codigo);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagparametroemissorApi : IGlobaltagparametroemissorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagparametroemissorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagparametroemissorApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagparametroemissorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagparametroemissorApi(Configuration configuration = null)
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
        /// {{{parametro_emissor_recurso}}} {{{parametro_emissor_recurso_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param> 
        /// <returns>ParametroEmissorResponse</returns>
        public ParametroEmissorResponse ConsultarUsingGET27 (string codigo)
        {
             ApiResponse<ParametroEmissorResponse> localVarResponse = ConsultarUsingGET27WithHttpInfo(codigo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{parametro_emissor_recurso}}} {{{parametro_emissor_recurso_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param> 
        /// <returns>ApiResponse of ParametroEmissorResponse</returns>
        public ApiResponse< ParametroEmissorResponse > ConsultarUsingGET27WithHttpInfo (string codigo)
        {
            
            // verify the required parameter 'codigo' is set
            if (codigo == null)
                throw new ApiException(400, "Missing required parameter 'codigo' when calling GlobaltagparametroemissorApi->ConsultarUsingGET27");
            
    
            var localVarPath = "/api/parametros-emissor/{codigo}";
    
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
            if (codigo != null) localVarPathParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroEmissorResponse)));
            
        }

        
        /// <summary>
        /// {{{parametro_emissor_recurso}}} {{{parametro_emissor_recurso_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param>
        /// <returns>Task of ParametroEmissorResponse</returns>
        public async System.Threading.Tasks.Task<ParametroEmissorResponse> ConsultarUsingGET27Async (string codigo)
        {
             ApiResponse<ParametroEmissorResponse> localVarResponse = await ConsultarUsingGET27AsyncWithHttpInfo(codigo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{parametro_emissor_recurso}}} {{{parametro_emissor_recurso_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codigo">{{{parametro_emissor_recurso_pesquisa_codigo_param}}}</param>
        /// <returns>Task of ApiResponse (ParametroEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroEmissorResponse>> ConsultarUsingGET27AsyncWithHttpInfo (string codigo)
        {
            // verify the required parameter 'codigo' is set
            if (codigo == null) throw new ApiException(400, "Missing required parameter 'codigo' when calling ConsultarUsingGET27");
            
    
            var localVarPath = "/api/parametros-emissor/{codigo}";
    
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
            if (codigo != null) localVarPathParams.Add("codigo", Configuration.ApiClient.ParameterToString(codigo)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroEmissorResponse)));
            
        }
        
    }
    
}
