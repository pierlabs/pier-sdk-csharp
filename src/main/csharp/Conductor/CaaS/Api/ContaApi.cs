using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Conductor.CaaS.Client;
using Conductor.CaaS.Model;

namespace Conductor.CaaS.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContaApi
    {
        
        /// <summary>
        /// /contas/{idConta}
        /// </summary>
        /// <remarks>
        /// Consulte informaÃ§Ãµes de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ContaResponse</returns>
        ContaResponse ConsultarContaUsingGET1 (int? idEmissor, int? idConta);
  
        /// <summary>
        /// /contas/{idConta}
        /// </summary>
        /// <remarks>
        /// Consulte informaÃ§Ãµes de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> ConsultarContaUsingGET1WithHttpInfo (int? idEmissor, int? idConta);

        /// <summary>
        /// /contas/{idConta}
        /// </summary>
        /// <remarks>
        /// Consulte informaÃ§Ãµes de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> ConsultarContaUsingGET1Async (int? idEmissor, int? idConta);

        /// <summary>
        /// /contas/{idConta}
        /// </summary>
        /// <remarks>
        /// Consulte informaÃ§Ãµes de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> ConsultarContaUsingGET1AsyncWithHttpInfo (int? idEmissor, int? idConta);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContaApi : IContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContaApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
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
        /// /contas/{idConta} Consulte informaÃ§Ãµes de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse ConsultarContaUsingGET1 (int? idEmissor, int? idConta)
        {
             ApiResponse<ContaResponse> response = ConsultarContaUsingGET1WithHttpInfo(idEmissor, idConta);
             return response.Data;
        }

        /// <summary>
        /// /contas/{idConta} Consulte informaÃ§Ãµes de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > ConsultarContaUsingGET1WithHttpInfo (int? idEmissor, int? idConta)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarContaUsingGET1");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarContaUsingGET1");
            
    
            var path_ = "/api/v1/contas/{idConta}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarContaUsingGET1: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarContaUsingGET1: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(response, typeof(ContaResponse)));
            
        }
    
        /// <summary>
        /// /contas/{idConta} Consulte informaÃ§Ãµes de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> ConsultarContaUsingGET1Async (int? idEmissor, int? idConta)
        {
             ApiResponse<ContaResponse> response = await ConsultarContaUsingGET1AsyncWithHttpInfo(idEmissor, idConta);
             return response.Data;

        }

        /// <summary>
        /// /contas/{idConta} Consulte informaÃ§Ãµes de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> ConsultarContaUsingGET1AsyncWithHttpInfo (int? idEmissor, int? idConta)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarContaUsingGET1");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarContaUsingGET1");
            
    
            var path_ = "/api/v1/contas/{idConta}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarContaUsingGET1: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarContaUsingGET1: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContaResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(response, typeof(ContaResponse)));
            
        }
        
    }
    
}
