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
    public interface IGlobaltaglogApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>LogAcessoUsuarioResposta</returns>
        LogAcessoUsuarioResposta SalvarUsingPOST17 (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist);
  
        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>ApiResponse of LogAcessoUsuarioResposta</returns>
        ApiResponse<LogAcessoUsuarioResposta> SalvarUsingPOST17WithHttpInfo (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of LogAcessoUsuarioResposta</returns>
        System.Threading.Tasks.Task<LogAcessoUsuarioResposta> SalvarUsingPOST17Async (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist);

        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of ApiResponse (LogAcessoUsuarioResposta)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogAcessoUsuarioResposta>> SalvarUsingPOST17AsyncWithHttpInfo (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltaglogApi : IGlobaltaglogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaglogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltaglogApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaglogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltaglogApi(Configuration configuration = null)
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
        /// {{{log_acesso_usuario_recurso_salvar}}} {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param> 
        /// <returns>LogAcessoUsuarioResposta</returns>
        public LogAcessoUsuarioResposta SalvarUsingPOST17 (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist)
        {
             ApiResponse<LogAcessoUsuarioResposta> localVarResponse = SalvarUsingPOST17WithHttpInfo(logAcessoUsuarioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}} {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param> 
        /// <returns>ApiResponse of LogAcessoUsuarioResposta</returns>
        public ApiResponse< LogAcessoUsuarioResposta > SalvarUsingPOST17WithHttpInfo (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist)
        {
            
            // verify the required parameter 'logAcessoUsuarioPersist' is set
            if (logAcessoUsuarioPersist == null)
                throw new ApiException(400, "Missing required parameter 'logAcessoUsuarioPersist' when calling GlobaltaglogApi->SalvarUsingPOST17");
            
    
            var localVarPath = "/api/logs/log-acessos-usuario";
    
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
            
            
            
            
            if (logAcessoUsuarioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logAcessoUsuarioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logAcessoUsuarioPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LogAcessoUsuarioResposta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogAcessoUsuarioResposta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogAcessoUsuarioResposta)));
            
        }

        
        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}} {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of LogAcessoUsuarioResposta</returns>
        public async System.Threading.Tasks.Task<LogAcessoUsuarioResposta> SalvarUsingPOST17Async (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist)
        {
             ApiResponse<LogAcessoUsuarioResposta> localVarResponse = await SalvarUsingPOST17AsyncWithHttpInfo(logAcessoUsuarioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{log_acesso_usuario_recurso_salvar}}} {{{log_acesso_usuario_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of ApiResponse (LogAcessoUsuarioResposta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogAcessoUsuarioResposta>> SalvarUsingPOST17AsyncWithHttpInfo (LogAcessoUsuarioPersistencia logAcessoUsuarioPersist)
        {
            // verify the required parameter 'logAcessoUsuarioPersist' is set
            if (logAcessoUsuarioPersist == null) throw new ApiException(400, "Missing required parameter 'logAcessoUsuarioPersist' when calling SalvarUsingPOST17");
            
    
            var localVarPath = "/api/logs/log-acessos-usuario";
    
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
            
            
            
            
            if (logAcessoUsuarioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logAcessoUsuarioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logAcessoUsuarioPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogAcessoUsuarioResposta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogAcessoUsuarioResposta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogAcessoUsuarioResposta)));
            
        }
        
    }
    
}
