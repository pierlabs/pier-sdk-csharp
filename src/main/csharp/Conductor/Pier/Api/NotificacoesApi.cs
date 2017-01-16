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
    public interface INotificacoesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param>
        /// <param name="status">Status</param>
        /// <param name="data">Data</param>
        /// <param name="textoStatus">TextoStatus</param>
        /// <param name="operadora">Operadora</param>
        /// <returns>SMS</returns>
        SMS AtualizarSMSUsingPUT (string seuNum, string status, string data, string textoStatus, string operadora);
  
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param>
        /// <param name="status">Status</param>
        /// <param name="data">Data</param>
        /// <param name="textoStatus">TextoStatus</param>
        /// <param name="operadora">Operadora</param>
        /// <returns>ApiResponse of SMS</returns>
        ApiResponse<SMS> AtualizarSMSUsingPUTWithHttpInfo (string seuNum, string status, string data, string textoStatus, string operadora);
        
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param>
        /// <param name="data">Data</param>
        /// <param name="textoSmsMo">TextoStatus</param>
        /// <returns>SMS</returns>
        SMS ResponderSMSUsingPUT (string seunum, string data, string textoSmsMo);
  
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param>
        /// <param name="data">Data</param>
        /// <param name="textoSmsMo">TextoStatus</param>
        /// <returns>ApiResponse of SMS</returns>
        ApiResponse<SMS> ResponderSMSUsingPUTWithHttpInfo (string seunum, string data, string textoSmsMo);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param>
        /// <param name="status">Status</param>
        /// <param name="data">Data</param>
        /// <param name="textoStatus">TextoStatus</param>
        /// <param name="operadora">Operadora</param>
        /// <returns>Task of SMS</returns>
        System.Threading.Tasks.Task<SMS> AtualizarSMSUsingPUTAsync (string seuNum, string status, string data, string textoStatus, string operadora);

        /// <summary>
        /// Atualizar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar o status do SMS do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param>
        /// <param name="status">Status</param>
        /// <param name="data">Data</param>
        /// <param name="textoStatus">TextoStatus</param>
        /// <param name="operadora">Operadora</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        System.Threading.Tasks.Task<ApiResponse<SMS>> AtualizarSMSUsingPUTAsyncWithHttpInfo (string seuNum, string status, string data, string textoStatus, string operadora);
        
        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param>
        /// <param name="data">Data</param>
        /// <param name="textoSmsMo">TextoStatus</param>
        /// <returns>Task of SMS</returns>
        System.Threading.Tasks.Task<SMS> ResponderSMSUsingPUTAsync (string seunum, string data, string textoSmsMo);

        /// <summary>
        /// Responder SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param>
        /// <param name="data">Data</param>
        /// <param name="textoSmsMo">TextoStatus</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        System.Threading.Tasks.Task<ApiResponse<SMS>> ResponderSMSUsingPUTAsyncWithHttpInfo (string seunum, string data, string textoSmsMo);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificacoesApi : INotificacoesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacoesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificacoesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacoesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificacoesApi(Configuration configuration = null)
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
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param> 
        /// <param name="status">Status</param> 
        /// <param name="data">Data</param> 
        /// <param name="textoStatus">TextoStatus</param> 
        /// <param name="operadora">Operadora</param> 
        /// <returns>SMS</returns>
        public SMS AtualizarSMSUsingPUT (string seuNum, string status, string data, string textoStatus, string operadora)
        {
             ApiResponse<SMS> localVarResponse = AtualizarSMSUsingPUTWithHttpInfo(seuNum, status, data, textoStatus, operadora);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param> 
        /// <param name="status">Status</param> 
        /// <param name="data">Data</param> 
        /// <param name="textoStatus">TextoStatus</param> 
        /// <param name="operadora">Operadora</param> 
        /// <returns>ApiResponse of SMS</returns>
        public ApiResponse< SMS > AtualizarSMSUsingPUTWithHttpInfo (string seuNum, string status, string data, string textoStatus, string operadora)
        {
            
            // verify the required parameter 'seuNum' is set
            if (seuNum == null)
                throw new ApiException(400, "Missing required parameter 'seuNum' when calling NotificacoesApi->AtualizarSMSUsingPUT");
            
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling NotificacoesApi->AtualizarSMSUsingPUT");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling NotificacoesApi->AtualizarSMSUsingPUT");
            
            // verify the required parameter 'textoStatus' is set
            if (textoStatus == null)
                throw new ApiException(400, "Missing required parameter 'textoStatus' when calling NotificacoesApi->AtualizarSMSUsingPUT");
            
            // verify the required parameter 'operadora' is set
            if (operadora == null)
                throw new ApiException(400, "Missing required parameter 'operadora' when calling NotificacoesApi->AtualizarSMSUsingPUT");
            
    
            var localVarPath = "/api/notificacoes/sms/atualizar-status";
    
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
            
            if (seuNum != null) localVarQueryParams.Add("SeuNum", Configuration.ApiClient.ParameterToString(seuNum)); // query parameter
            if (status != null) localVarQueryParams.Add("Status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (data != null) localVarQueryParams.Add("Data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (textoStatus != null) localVarQueryParams.Add("TextoStatus", Configuration.ApiClient.ParameterToString(textoStatus)); // query parameter
            if (operadora != null) localVarQueryParams.Add("Operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }

        
        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param>
        /// <param name="status">Status</param>
        /// <param name="data">Data</param>
        /// <param name="textoStatus">TextoStatus</param>
        /// <param name="operadora">Operadora</param>
        /// <returns>Task of SMS</returns>
        public async System.Threading.Tasks.Task<SMS> AtualizarSMSUsingPUTAsync (string seuNum, string status, string data, string textoStatus, string operadora)
        {
             ApiResponse<SMS> localVarResponse = await AtualizarSMSUsingPUTAsyncWithHttpInfo(seuNum, status, data, textoStatus, operadora);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar SMS Esse recurso permite atualizar o status do SMS do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seuNum">Seu n\u00C3\u00BAmero</param>
        /// <param name="status">Status</param>
        /// <param name="data">Data</param>
        /// <param name="textoStatus">TextoStatus</param>
        /// <param name="operadora">Operadora</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SMS>> AtualizarSMSUsingPUTAsyncWithHttpInfo (string seuNum, string status, string data, string textoStatus, string operadora)
        {
            // verify the required parameter 'seuNum' is set
            if (seuNum == null) throw new ApiException(400, "Missing required parameter 'seuNum' when calling AtualizarSMSUsingPUT");
            // verify the required parameter 'status' is set
            if (status == null) throw new ApiException(400, "Missing required parameter 'status' when calling AtualizarSMSUsingPUT");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AtualizarSMSUsingPUT");
            // verify the required parameter 'textoStatus' is set
            if (textoStatus == null) throw new ApiException(400, "Missing required parameter 'textoStatus' when calling AtualizarSMSUsingPUT");
            // verify the required parameter 'operadora' is set
            if (operadora == null) throw new ApiException(400, "Missing required parameter 'operadora' when calling AtualizarSMSUsingPUT");
            
    
            var localVarPath = "/api/notificacoes/sms/atualizar-status";
    
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
            
            if (seuNum != null) localVarQueryParams.Add("SeuNum", Configuration.ApiClient.ParameterToString(seuNum)); // query parameter
            if (status != null) localVarQueryParams.Add("Status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (data != null) localVarQueryParams.Add("Data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (textoStatus != null) localVarQueryParams.Add("TextoStatus", Configuration.ApiClient.ParameterToString(textoStatus)); // query parameter
            if (operadora != null) localVarQueryParams.Add("Operadora", Configuration.ApiClient.ParameterToString(operadora)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarSMSUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }
        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param> 
        /// <param name="data">Data</param> 
        /// <param name="textoSmsMo">TextoStatus</param> 
        /// <returns>SMS</returns>
        public SMS ResponderSMSUsingPUT (string seunum, string data, string textoSmsMo)
        {
             ApiResponse<SMS> localVarResponse = ResponderSMSUsingPUTWithHttpInfo(seunum, data, textoSmsMo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param> 
        /// <param name="data">Data</param> 
        /// <param name="textoSmsMo">TextoStatus</param> 
        /// <returns>ApiResponse of SMS</returns>
        public ApiResponse< SMS > ResponderSMSUsingPUTWithHttpInfo (string seunum, string data, string textoSmsMo)
        {
            
            // verify the required parameter 'seunum' is set
            if (seunum == null)
                throw new ApiException(400, "Missing required parameter 'seunum' when calling NotificacoesApi->ResponderSMSUsingPUT");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling NotificacoesApi->ResponderSMSUsingPUT");
            
            // verify the required parameter 'textoSmsMo' is set
            if (textoSmsMo == null)
                throw new ApiException(400, "Missing required parameter 'textoSmsMo' when calling NotificacoesApi->ResponderSMSUsingPUT");
            
    
            var localVarPath = "/api/notificacoes/sms/responder";
    
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
            
            if (seunum != null) localVarQueryParams.Add("Seunum", Configuration.ApiClient.ParameterToString(seunum)); // query parameter
            if (data != null) localVarQueryParams.Add("Data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (textoSmsMo != null) localVarQueryParams.Add("TextoSmsMo", Configuration.ApiClient.ParameterToString(textoSmsMo)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }

        
        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param>
        /// <param name="data">Data</param>
        /// <param name="textoSmsMo">TextoStatus</param>
        /// <returns>Task of SMS</returns>
        public async System.Threading.Tasks.Task<SMS> ResponderSMSUsingPUTAsync (string seunum, string data, string textoSmsMo)
        {
             ApiResponse<SMS> localVarResponse = await ResponderSMSUsingPUTAsyncWithHttpInfo(seunum, data, textoSmsMo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Responder SMS Esse recurso permite atualizar a resposta do SMS, fornecida pedo usu\u00C3\u00A1rio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seunum">Seu n\u00C3\u00BAmero</param>
        /// <param name="data">Data</param>
        /// <param name="textoSmsMo">TextoStatus</param>
        /// <returns>Task of ApiResponse (SMS)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SMS>> ResponderSMSUsingPUTAsyncWithHttpInfo (string seunum, string data, string textoSmsMo)
        {
            // verify the required parameter 'seunum' is set
            if (seunum == null) throw new ApiException(400, "Missing required parameter 'seunum' when calling ResponderSMSUsingPUT");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling ResponderSMSUsingPUT");
            // verify the required parameter 'textoSmsMo' is set
            if (textoSmsMo == null) throw new ApiException(400, "Missing required parameter 'textoSmsMo' when calling ResponderSMSUsingPUT");
            
    
            var localVarPath = "/api/notificacoes/sms/responder";
    
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
            
            if (seunum != null) localVarQueryParams.Add("Seunum", Configuration.ApiClient.ParameterToString(seunum)); // query parameter
            if (data != null) localVarQueryParams.Add("Data", Configuration.ApiClient.ParameterToString(data)); // query parameter
            if (textoSmsMo != null) localVarQueryParams.Add("TextoSmsMo", Configuration.ApiClient.ParameterToString(textoSmsMo)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResponderSMSUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SMS>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SMS) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SMS)));
            
        }
        
    }
    
}
