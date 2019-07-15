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
    public interface ILogApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param>
        /// <param name="logRequisicao">logRequisicao</param>
        /// <returns>LogRequisicaoMobileResponse</returns>
        LogRequisicaoMobileResponse AtualizarParcialmenteLogRequisicaoMobile (long? id, LogRequisicaoMobilePartialUpdate logRequisicao);
  
        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param>
        /// <param name="logRequisicao">logRequisicao</param>
        /// <returns>ApiResponse of LogRequisicaoMobileResponse</returns>
        ApiResponse<LogRequisicaoMobileResponse> AtualizarParcialmenteLogRequisicaoMobileWithHttpInfo (long? id, LogRequisicaoMobilePartialUpdate logRequisicao);
        
        /// <summary>
        /// Salva os registros parametrizados
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os registros parametrizados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>LogAcessoUsuarioResponse</returns>
        LogAcessoUsuarioResponse SalvarLogAcessoUsuario (LogAcessoUsuarioPersist logAcessoUsuarioPersist);
  
        /// <summary>
        /// Salva os registros parametrizados
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os registros parametrizados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>ApiResponse of LogAcessoUsuarioResponse</returns>
        ApiResponse<LogAcessoUsuarioResponse> SalvarLogAcessoUsuarioWithHttpInfo (LogAcessoUsuarioPersist logAcessoUsuarioPersist);
        
        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param>
        /// <returns>LogRequisicaoMobileResponse</returns>
        LogRequisicaoMobileResponse SalvarLogRequisicaoMobile (LogRequisicaoMobilePersist logRequisicaoMobilePersist);
  
        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param>
        /// <returns>ApiResponse of LogRequisicaoMobileResponse</returns>
        ApiResponse<LogRequisicaoMobileResponse> SalvarLogRequisicaoMobileWithHttpInfo (LogRequisicaoMobilePersist logRequisicaoMobilePersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param>
        /// <param name="logRequisicao">logRequisicao</param>
        /// <returns>Task of LogRequisicaoMobileResponse</returns>
        System.Threading.Tasks.Task<LogRequisicaoMobileResponse> AtualizarParcialmenteLogRequisicaoMobileAsync (long? id, LogRequisicaoMobilePartialUpdate logRequisicao);

        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param>
        /// <param name="logRequisicao">logRequisicao</param>
        /// <returns>Task of ApiResponse (LogRequisicaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogRequisicaoMobileResponse>> AtualizarParcialmenteLogRequisicaoMobileAsyncWithHttpInfo (long? id, LogRequisicaoMobilePartialUpdate logRequisicao);
        
        /// <summary>
        /// Salva os registros parametrizados
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os registros parametrizados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of LogAcessoUsuarioResponse</returns>
        System.Threading.Tasks.Task<LogAcessoUsuarioResponse> SalvarLogAcessoUsuarioAsync (LogAcessoUsuarioPersist logAcessoUsuarioPersist);

        /// <summary>
        /// Salva os registros parametrizados
        /// </summary>
        /// <remarks>
        /// Este recurso permite salvar os registros parametrizados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of ApiResponse (LogAcessoUsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogAcessoUsuarioResponse>> SalvarLogAcessoUsuarioAsyncWithHttpInfo (LogAcessoUsuarioPersist logAcessoUsuarioPersist);
        
        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param>
        /// <returns>Task of LogRequisicaoMobileResponse</returns>
        System.Threading.Tasks.Task<LogRequisicaoMobileResponse> SalvarLogRequisicaoMobileAsync (LogRequisicaoMobilePersist logRequisicaoMobilePersist);

        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile
        /// </summary>
        /// <remarks>
        /// Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param>
        /// <returns>Task of ApiResponse (LogRequisicaoMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogRequisicaoMobileResponse>> SalvarLogRequisicaoMobileAsyncWithHttpInfo (LogRequisicaoMobilePersist logRequisicaoMobilePersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LogApi : ILogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LogApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LogApi(Configuration configuration = null)
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
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param> 
        /// <param name="logRequisicao">logRequisicao</param> 
        /// <returns>LogRequisicaoMobileResponse</returns>
        public LogRequisicaoMobileResponse AtualizarParcialmenteLogRequisicaoMobile (long? id, LogRequisicaoMobilePartialUpdate logRequisicao)
        {
             ApiResponse<LogRequisicaoMobileResponse> localVarResponse = AtualizarParcialmenteLogRequisicaoMobileWithHttpInfo(id, logRequisicao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param> 
        /// <param name="logRequisicao">logRequisicao</param> 
        /// <returns>ApiResponse of LogRequisicaoMobileResponse</returns>
        public ApiResponse< LogRequisicaoMobileResponse > AtualizarParcialmenteLogRequisicaoMobileWithHttpInfo (long? id, LogRequisicaoMobilePartialUpdate logRequisicao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LogApi->AtualizarParcialmenteLogRequisicaoMobile");
            
            // verify the required parameter 'logRequisicao' is set
            if (logRequisicao == null)
                throw new ApiException(400, "Missing required parameter 'logRequisicao' when calling LogApi->AtualizarParcialmenteLogRequisicaoMobile");
            
    
            var localVarPath = "/api/logs/requisicoes-mobile/{id}";
    
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
            
            
            
            
            if (logRequisicao.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logRequisicao); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logRequisicao; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteLogRequisicaoMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteLogRequisicaoMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LogRequisicaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogRequisicaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogRequisicaoMobileResponse)));
            
        }

        
        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param>
        /// <param name="logRequisicao">logRequisicao</param>
        /// <returns>Task of LogRequisicaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<LogRequisicaoMobileResponse> AtualizarParcialmenteLogRequisicaoMobileAsync (long? id, LogRequisicaoMobilePartialUpdate logRequisicao)
        {
             ApiResponse<LogRequisicaoMobileResponse> localVarResponse = await AtualizarParcialmenteLogRequisicaoMobileAsyncWithHttpInfo(id, logRequisicao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar parcialmente o log de requisi\u00E7\u00E3o mobile Atualiza parcialmente as informa\u00E7\u00F5es adicionais da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifica\u00E7\u00E3o do registro</param>
        /// <param name="logRequisicao">logRequisicao</param>
        /// <returns>Task of ApiResponse (LogRequisicaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogRequisicaoMobileResponse>> AtualizarParcialmenteLogRequisicaoMobileAsyncWithHttpInfo (long? id, LogRequisicaoMobilePartialUpdate logRequisicao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcialmenteLogRequisicaoMobile");
            // verify the required parameter 'logRequisicao' is set
            if (logRequisicao == null) throw new ApiException(400, "Missing required parameter 'logRequisicao' when calling AtualizarParcialmenteLogRequisicaoMobile");
            
    
            var localVarPath = "/api/logs/requisicoes-mobile/{id}";
    
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
            
            
            
            
            if (logRequisicao.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logRequisicao); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logRequisicao; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteLogRequisicaoMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteLogRequisicaoMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogRequisicaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogRequisicaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogRequisicaoMobileResponse)));
            
        }
        
        /// <summary>
        /// Salva os registros parametrizados Este recurso permite salvar os registros parametrizados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param> 
        /// <returns>LogAcessoUsuarioResponse</returns>
        public LogAcessoUsuarioResponse SalvarLogAcessoUsuario (LogAcessoUsuarioPersist logAcessoUsuarioPersist)
        {
             ApiResponse<LogAcessoUsuarioResponse> localVarResponse = SalvarLogAcessoUsuarioWithHttpInfo(logAcessoUsuarioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva os registros parametrizados Este recurso permite salvar os registros parametrizados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param> 
        /// <returns>ApiResponse of LogAcessoUsuarioResponse</returns>
        public ApiResponse< LogAcessoUsuarioResponse > SalvarLogAcessoUsuarioWithHttpInfo (LogAcessoUsuarioPersist logAcessoUsuarioPersist)
        {
            
            // verify the required parameter 'logAcessoUsuarioPersist' is set
            if (logAcessoUsuarioPersist == null)
                throw new ApiException(400, "Missing required parameter 'logAcessoUsuarioPersist' when calling LogApi->SalvarLogAcessoUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogAcessoUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogAcessoUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LogAcessoUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogAcessoUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogAcessoUsuarioResponse)));
            
        }

        
        /// <summary>
        /// Salva os registros parametrizados Este recurso permite salvar os registros parametrizados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of LogAcessoUsuarioResponse</returns>
        public async System.Threading.Tasks.Task<LogAcessoUsuarioResponse> SalvarLogAcessoUsuarioAsync (LogAcessoUsuarioPersist logAcessoUsuarioPersist)
        {
             ApiResponse<LogAcessoUsuarioResponse> localVarResponse = await SalvarLogAcessoUsuarioAsyncWithHttpInfo(logAcessoUsuarioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva os registros parametrizados Este recurso permite salvar os registros parametrizados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logAcessoUsuarioPersist">logAcessoUsuarioPersist</param>
        /// <returns>Task of ApiResponse (LogAcessoUsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogAcessoUsuarioResponse>> SalvarLogAcessoUsuarioAsyncWithHttpInfo (LogAcessoUsuarioPersist logAcessoUsuarioPersist)
        {
            // verify the required parameter 'logAcessoUsuarioPersist' is set
            if (logAcessoUsuarioPersist == null) throw new ApiException(400, "Missing required parameter 'logAcessoUsuarioPersist' when calling SalvarLogAcessoUsuario");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogAcessoUsuario: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogAcessoUsuario: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogAcessoUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogAcessoUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogAcessoUsuarioResponse)));
            
        }
        
        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param> 
        /// <returns>LogRequisicaoMobileResponse</returns>
        public LogRequisicaoMobileResponse SalvarLogRequisicaoMobile (LogRequisicaoMobilePersist logRequisicaoMobilePersist)
        {
             ApiResponse<LogRequisicaoMobileResponse> localVarResponse = SalvarLogRequisicaoMobileWithHttpInfo(logRequisicaoMobilePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param> 
        /// <returns>ApiResponse of LogRequisicaoMobileResponse</returns>
        public ApiResponse< LogRequisicaoMobileResponse > SalvarLogRequisicaoMobileWithHttpInfo (LogRequisicaoMobilePersist logRequisicaoMobilePersist)
        {
            
            // verify the required parameter 'logRequisicaoMobilePersist' is set
            if (logRequisicaoMobilePersist == null)
                throw new ApiException(400, "Missing required parameter 'logRequisicaoMobilePersist' when calling LogApi->SalvarLogRequisicaoMobile");
            
    
            var localVarPath = "/api/logs/requisicoes-mobile";
    
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
            
            
            
            
            if (logRequisicaoMobilePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logRequisicaoMobilePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logRequisicaoMobilePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogRequisicaoMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogRequisicaoMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LogRequisicaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogRequisicaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogRequisicaoMobileResponse)));
            
        }

        
        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param>
        /// <returns>Task of LogRequisicaoMobileResponse</returns>
        public async System.Threading.Tasks.Task<LogRequisicaoMobileResponse> SalvarLogRequisicaoMobileAsync (LogRequisicaoMobilePersist logRequisicaoMobilePersist)
        {
             ApiResponse<LogRequisicaoMobileResponse> localVarResponse = await SalvarLogRequisicaoMobileAsyncWithHttpInfo(logRequisicaoMobilePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra o log requisi\u00E7\u00E3o mobile Cadastra registros da requisi\u00E7\u00E3o de um dispositivo m\u00F3vel
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logRequisicaoMobilePersist">logRequisicaoMobilePersist</param>
        /// <returns>Task of ApiResponse (LogRequisicaoMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogRequisicaoMobileResponse>> SalvarLogRequisicaoMobileAsyncWithHttpInfo (LogRequisicaoMobilePersist logRequisicaoMobilePersist)
        {
            // verify the required parameter 'logRequisicaoMobilePersist' is set
            if (logRequisicaoMobilePersist == null) throw new ApiException(400, "Missing required parameter 'logRequisicaoMobilePersist' when calling SalvarLogRequisicaoMobile");
            
    
            var localVarPath = "/api/logs/requisicoes-mobile";
    
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
            
            
            
            
            if (logRequisicaoMobilePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logRequisicaoMobilePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logRequisicaoMobilePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogRequisicaoMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLogRequisicaoMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogRequisicaoMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogRequisicaoMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogRequisicaoMobileResponse)));
            
        }
        
    }
    
}
