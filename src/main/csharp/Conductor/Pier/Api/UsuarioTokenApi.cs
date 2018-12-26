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
    public interface IUsuarioTokenApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Incrementa as tentativas
        /// </summary>
        /// <remarks>
        /// Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param>
        /// <returns>ControleTentativaCadastroResponse</returns>
        ControleTentativaCadastroResponse IncrementarTentativa (string cpf);
  
        /// <summary>
        /// Incrementa as tentativas
        /// </summary>
        /// <remarks>
        /// Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param>
        /// <returns>ApiResponse of ControleTentativaCadastroResponse</returns>
        ApiResponse<ControleTentativaCadastroResponse> IncrementarTentativaWithHttpInfo (string cpf);
        
        /// <summary>
        /// Verifica as tentativas
        /// </summary>
        /// <remarks>
        /// Verifica as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param>
        /// <returns>ControleTentativaCadastroResponse</returns>
        ControleTentativaCadastroResponse VerificarTentativa (string cpf);
  
        /// <summary>
        /// Verifica as tentativas
        /// </summary>
        /// <remarks>
        /// Verifica as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param>
        /// <returns>ApiResponse of ControleTentativaCadastroResponse</returns>
        ApiResponse<ControleTentativaCadastroResponse> VerificarTentativaWithHttpInfo (string cpf);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Incrementa as tentativas
        /// </summary>
        /// <remarks>
        /// Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param>
        /// <returns>Task of ControleTentativaCadastroResponse</returns>
        System.Threading.Tasks.Task<ControleTentativaCadastroResponse> IncrementarTentativaAsync (string cpf);

        /// <summary>
        /// Incrementa as tentativas
        /// </summary>
        /// <remarks>
        /// Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param>
        /// <returns>Task of ApiResponse (ControleTentativaCadastroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleTentativaCadastroResponse>> IncrementarTentativaAsyncWithHttpInfo (string cpf);
        
        /// <summary>
        /// Verifica as tentativas
        /// </summary>
        /// <remarks>
        /// Verifica as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param>
        /// <returns>Task of ControleTentativaCadastroResponse</returns>
        System.Threading.Tasks.Task<ControleTentativaCadastroResponse> VerificarTentativaAsync (string cpf);

        /// <summary>
        /// Verifica as tentativas
        /// </summary>
        /// <remarks>
        /// Verifica as tentativas de cadastro do usu\u00E1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param>
        /// <returns>Task of ApiResponse (ControleTentativaCadastroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleTentativaCadastroResponse>> VerificarTentativaAsyncWithHttpInfo (string cpf);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsuarioTokenApi : IUsuarioTokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsuarioTokenApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioTokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsuarioTokenApi(Configuration configuration = null)
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
        /// Incrementa as tentativas Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param> 
        /// <returns>ControleTentativaCadastroResponse</returns>
        public ControleTentativaCadastroResponse IncrementarTentativa (string cpf)
        {
             ApiResponse<ControleTentativaCadastroResponse> localVarResponse = IncrementarTentativaWithHttpInfo(cpf);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Incrementa as tentativas Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param> 
        /// <returns>ApiResponse of ControleTentativaCadastroResponse</returns>
        public ApiResponse< ControleTentativaCadastroResponse > IncrementarTentativaWithHttpInfo (string cpf)
        {
            
            // verify the required parameter 'cpf' is set
            if (cpf == null)
                throw new ApiException(400, "Missing required parameter 'cpf' when calling UsuarioTokenApi->IncrementarTentativa");
            
    
            var localVarPath = "/api/usuarios-tokens/incrementar-tentativas";
    
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
            
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IncrementarTentativa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IncrementarTentativa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleTentativaCadastroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleTentativaCadastroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleTentativaCadastroResponse)));
            
        }

        
        /// <summary>
        /// Incrementa as tentativas Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param>
        /// <returns>Task of ControleTentativaCadastroResponse</returns>
        public async System.Threading.Tasks.Task<ControleTentativaCadastroResponse> IncrementarTentativaAsync (string cpf)
        {
             ApiResponse<ControleTentativaCadastroResponse> localVarResponse = await IncrementarTentativaAsyncWithHttpInfo(cpf);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Incrementa as tentativas Incrementa as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para incremetar as tentativas</param>
        /// <returns>Task of ApiResponse (ControleTentativaCadastroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleTentativaCadastroResponse>> IncrementarTentativaAsyncWithHttpInfo (string cpf)
        {
            // verify the required parameter 'cpf' is set
            if (cpf == null) throw new ApiException(400, "Missing required parameter 'cpf' when calling IncrementarTentativa");
            
    
            var localVarPath = "/api/usuarios-tokens/incrementar-tentativas";
    
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
            
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IncrementarTentativa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IncrementarTentativa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleTentativaCadastroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleTentativaCadastroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleTentativaCadastroResponse)));
            
        }
        
        /// <summary>
        /// Verifica as tentativas Verifica as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param> 
        /// <returns>ControleTentativaCadastroResponse</returns>
        public ControleTentativaCadastroResponse VerificarTentativa (string cpf)
        {
             ApiResponse<ControleTentativaCadastroResponse> localVarResponse = VerificarTentativaWithHttpInfo(cpf);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verifica as tentativas Verifica as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param> 
        /// <returns>ApiResponse of ControleTentativaCadastroResponse</returns>
        public ApiResponse< ControleTentativaCadastroResponse > VerificarTentativaWithHttpInfo (string cpf)
        {
            
            // verify the required parameter 'cpf' is set
            if (cpf == null)
                throw new ApiException(400, "Missing required parameter 'cpf' when calling UsuarioTokenApi->VerificarTentativa");
            
    
            var localVarPath = "/api/usuarios-tokens/verificar-tentativas";
    
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
            
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VerificarTentativa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VerificarTentativa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleTentativaCadastroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleTentativaCadastroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleTentativaCadastroResponse)));
            
        }

        
        /// <summary>
        /// Verifica as tentativas Verifica as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param>
        /// <returns>Task of ControleTentativaCadastroResponse</returns>
        public async System.Threading.Tasks.Task<ControleTentativaCadastroResponse> VerificarTentativaAsync (string cpf)
        {
             ApiResponse<ControleTentativaCadastroResponse> localVarResponse = await VerificarTentativaAsyncWithHttpInfo(cpf);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Verifica as tentativas Verifica as tentativas de cadastro do usu\u00E1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpf">CPF que ser\u00E1 utilizado para consulta das tentativas</param>
        /// <returns>Task of ApiResponse (ControleTentativaCadastroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleTentativaCadastroResponse>> VerificarTentativaAsyncWithHttpInfo (string cpf)
        {
            // verify the required parameter 'cpf' is set
            if (cpf == null) throw new ApiException(400, "Missing required parameter 'cpf' when calling VerificarTentativa");
            
    
            var localVarPath = "/api/usuarios-tokens/verificar-tentativas";
    
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
            
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VerificarTentativa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VerificarTentativa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleTentativaCadastroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleTentativaCadastroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleTentativaCadastroResponse)));
            
        }
        
    }
    
}
