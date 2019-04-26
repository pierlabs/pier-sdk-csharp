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
    public interface IEnderecoNacionalApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consultar Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse ConsultarEndereco (string CEP);
  
        /// <summary>
        /// Consultar Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> ConsultarEnderecoWithHttpInfo (string CEP);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> ConsultarEnderecoAsync (string CEP);

        /// <summary>
        /// Consultar Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarEnderecoAsyncWithHttpInfo (string CEP);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EnderecoNacionalApi : IEnderecoNacionalApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoNacionalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnderecoNacionalApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoNacionalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EnderecoNacionalApi(Configuration configuration = null)
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
        /// Consultar Endere\u00E7o Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse ConsultarEndereco (string CEP)
        {
             ApiResponse<EnderecoResponse> localVarResponse = ConsultarEnderecoWithHttpInfo(CEP);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Endere\u00E7o Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > ConsultarEnderecoWithHttpInfo (string CEP)
        {
            
            // verify the required parameter 'CEP' is set
            if (CEP == null)
                throw new ApiException(400, "Missing required parameter 'CEP' when calling EnderecoNacionalApi->ConsultarEndereco");
            
    
            var localVarPath = "/api/ceps";
    
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
            
            if (CEP != null) localVarQueryParams.Add("CEP", Configuration.ApiClient.ParameterToString(CEP)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Consultar Endere\u00E7o Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> ConsultarEnderecoAsync (string CEP)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await ConsultarEnderecoAsyncWithHttpInfo(CEP);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Endere\u00E7o Este recurso permite consultar endere\u00E7os atrav\u00E9s do CEP
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="CEP">CEP</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarEnderecoAsyncWithHttpInfo (string CEP)
        {
            // verify the required parameter 'CEP' is set
            if (CEP == null) throw new ApiException(400, "Missing required parameter 'CEP' when calling ConsultarEndereco");
            
    
            var localVarPath = "/api/ceps";
    
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
            
            if (CEP != null) localVarQueryParams.Add("CEP", Configuration.ApiClient.ParameterToString(CEP)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
    }
    
}
