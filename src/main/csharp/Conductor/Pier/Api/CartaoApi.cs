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
    public interface ICartaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Bloquear um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do bloqueio</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param>
        /// <returns>CancelarCartaoResponse</returns>
        CancelarCartaoResponse BloquearCartaoUsingPOST (int? idConta, int? idCartao, int? motivo, string observacao = null);
  
        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Bloquear um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do bloqueio</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param>
        /// <returns>ApiResponse of CancelarCartaoResponse</returns>
        ApiResponse<CancelarCartaoResponse> BloquearCartaoUsingPOSTWithHttpInfo (int? idConta, int? idCartao, int? motivo, string observacao = null);
        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>ConsultarCartaoResponse</returns>
        ConsultarCartaoResponse ConsultarCartaoUsingGET (int? idConta, int? idCartao, string numeroCartao = null);
  
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        ApiResponse<ConsultarCartaoResponse> ConsultarCartaoUsingGETWithHttpInfo (int? idConta, int? idCartao, string numeroCartao = null);
        
        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ConsultarCartaoResponse</returns>
        ConsultarCartaoResponse ConsultarCartoesUsingGET (int? idConta);
  
        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        ApiResponse<ConsultarCartaoResponse> ConsultarCartoesUsingGETWithHttpInfo (int? idConta);
        
        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param>
        /// <returns>DesbloquearCartaoResponse</returns>
        DesbloquearCartaoResponse DesbloquearCartaoUsingPOST (int? idConta, int? idCartao, string codigoSegurancao = null);
  
        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of DesbloquearCartaoResponse</returns>
        ApiResponse<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTWithHttpInfo (int? idConta, int? idCartao, string codigoSegurancao = null);
        
        /// <summary>
        /// Embossado
        /// </summary>
        /// <remarks>
        /// N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <returns>EmbossadoCartaoResponse</returns>
        EmbossadoCartaoResponse EmbossadoCartaoUsingPUT (int? idConta, int? idCartao);
  
        /// <summary>
        /// Embossado
        /// </summary>
        /// <remarks>
        /// N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <returns>ApiResponse of EmbossadoCartaoResponse</returns>
        ApiResponse<EmbossadoCartaoResponse> EmbossadoCartaoUsingPUTWithHttpInfo (int? idConta, int? idCartao);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Bloquear um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do bloqueio</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param>
        /// <returns>Task of CancelarCartaoResponse</returns>
        System.Threading.Tasks.Task<CancelarCartaoResponse> BloquearCartaoUsingPOSTAsync (int? idConta, int? idCartao, int? motivo, string observacao = null);

        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Bloquear um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do bloqueio</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param>
        /// <returns>Task of ApiResponse (CancelarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CancelarCartaoResponse>> BloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idConta, int? idCartao, int? motivo, string observacao = null);
        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartaoUsingGETAsync (int? idConta, int? idCartao, string numeroCartao = null);

        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartaoUsingGETAsyncWithHttpInfo (int? idConta, int? idCartao, string numeroCartao = null);
        
        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartoesUsingGETAsync (int? idConta);

        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartoesUsingGETAsyncWithHttpInfo (int? idConta);
        
        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of DesbloquearCartaoResponse</returns>
        System.Threading.Tasks.Task<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTAsync (int? idConta, int? idCartao, string codigoSegurancao = null);

        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (DesbloquearCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DesbloquearCartaoResponse>> DesbloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idConta, int? idCartao, string codigoSegurancao = null);
        
        /// <summary>
        /// Embossado
        /// </summary>
        /// <remarks>
        /// N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <returns>Task of EmbossadoCartaoResponse</returns>
        System.Threading.Tasks.Task<EmbossadoCartaoResponse> EmbossadoCartaoUsingPUTAsync (int? idConta, int? idCartao);

        /// <summary>
        /// Embossado
        /// </summary>
        /// <remarks>
        /// N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <returns>Task of ApiResponse (EmbossadoCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmbossadoCartaoResponse>> EmbossadoCartaoUsingPUTAsyncWithHttpInfo (int? idConta, int? idCartao);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartaoApi : ICartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartaoApi(Configuration configuration = null)
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
        /// Bloqueia um cart\u00C3\u00A3o Bloquear um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param> 
        /// <param name="motivo">Motivo do bloqueio</param> 
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param> 
        /// <returns>CancelarCartaoResponse</returns>
        public CancelarCartaoResponse BloquearCartaoUsingPOST (int? idConta, int? idCartao, int? motivo, string observacao = null)
        {
             ApiResponse<CancelarCartaoResponse> localVarResponse = BloquearCartaoUsingPOSTWithHttpInfo(idConta, idCartao, motivo, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o Bloquear um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param> 
        /// <param name="motivo">Motivo do bloqueio</param> 
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param> 
        /// <returns>ApiResponse of CancelarCartaoResponse</returns>
        public ApiResponse< CancelarCartaoResponse > BloquearCartaoUsingPOSTWithHttpInfo (int? idConta, int? idCartao, int? motivo, string observacao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->BloquearCartaoUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->BloquearCartaoUsingPOST");
            
            // verify the required parameter 'motivo' is set
            if (motivo == null)
                throw new ApiException(400, "Missing required parameter 'motivo' when calling CartaoApi->BloquearCartaoUsingPOST");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}/bloquear";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CancelarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CancelarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CancelarCartaoResponse)));
            
        }

        
        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o Bloquear um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do bloqueio</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param>
        /// <returns>Task of CancelarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<CancelarCartaoResponse> BloquearCartaoUsingPOSTAsync (int? idConta, int? idCartao, int? motivo, string observacao = null)
        {
             ApiResponse<CancelarCartaoResponse> localVarResponse = await BloquearCartaoUsingPOSTAsyncWithHttpInfo(idConta, idCartao, motivo, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bloqueia um cart\u00C3\u00A3o Bloquear um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <param name="motivo">Motivo do bloqueio</param>
        /// <param name="observacao">Alguma observa\u00C3\u00A7\u00C3\u00A3o para o bloqueio (optional)</param>
        /// <returns>Task of ApiResponse (CancelarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CancelarCartaoResponse>> BloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idConta, int? idCartao, int? motivo, string observacao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling BloquearCartaoUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling BloquearCartaoUsingPOST");
            // verify the required parameter 'motivo' is set
            if (motivo == null) throw new ApiException(400, "Missing required parameter 'motivo' when calling BloquearCartaoUsingPOST");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}/bloquear";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CancelarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CancelarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CancelarCartaoResponse)));
            
        }
        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param> 
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param> 
        /// <returns>ConsultarCartaoResponse</returns>
        public ConsultarCartaoResponse ConsultarCartaoUsingGET (int? idConta, int? idCartao, string numeroCartao = null)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = ConsultarCartaoUsingGETWithHttpInfo(idConta, idCartao, numeroCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param> 
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param> 
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        public ApiResponse< ConsultarCartaoResponse > ConsultarCartaoUsingGETWithHttpInfo (int? idConta, int? idCartao, string numeroCartao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->ConsultarCartaoUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->ConsultarCartaoUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (numeroCartao != null) localVarHeaderParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // header parameter
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }

        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartaoUsingGETAsync (int? idConta, int? idCartao, string numeroCartao = null)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = await ConsultarCartaoUsingGETAsyncWithHttpInfo(idConta, idCartao, numeroCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consultar as informa\u00C3\u00A7\u00C3\u00B5es de um determinado cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta que pertence o cart\u00C3\u00A3o</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que deseja consultar (opcional) (optional)</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartaoUsingGETAsyncWithHttpInfo (int? idConta, int? idCartao, string numeroCartao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarCartaoUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarCartaoUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (numeroCartao != null) localVarHeaderParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }
        
        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ConsultarCartaoResponse</returns>
        public ConsultarCartaoResponse ConsultarCartoesUsingGET (int? idConta)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = ConsultarCartoesUsingGETWithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        public ApiResponse< ConsultarCartaoResponse > ConsultarCartoesUsingGETWithHttpInfo (int? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->ConsultarCartoesUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }

        
        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartoesUsingGETAsync (int? idConta)
        {
             ApiResponse<ConsultarCartaoResponse> localVarResponse = await ConsultarCartoesUsingGETAsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna todos os cart\u00C3\u00B5es Consultar todos os cart\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartoesUsingGETAsyncWithHttpInfo (int? idConta)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarCartoesUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarCartaoResponse)));
            
        }
        
        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param> 
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param> 
        /// <returns>DesbloquearCartaoResponse</returns>
        public DesbloquearCartaoResponse DesbloquearCartaoUsingPOST (int? idConta, int? idCartao, string codigoSegurancao = null)
        {
             ApiResponse<DesbloquearCartaoResponse> localVarResponse = DesbloquearCartaoUsingPOSTWithHttpInfo(idConta, idCartao, codigoSegurancao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param> 
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of DesbloquearCartaoResponse</returns>
        public ApiResponse< DesbloquearCartaoResponse > DesbloquearCartaoUsingPOSTWithHttpInfo (int? idConta, int? idCartao, string codigoSegurancao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->DesbloquearCartaoUsingPOST");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}/desbloquear";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (codigoSegurancao != null) localVarHeaderParams.Add("codigoSegurancao", Configuration.ApiClient.ParameterToString(codigoSegurancao)); // header parameter
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DesbloquearCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DesbloquearCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DesbloquearCartaoResponse)));
            
        }

        
        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of DesbloquearCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTAsync (int? idConta, int? idCartao, string codigoSegurancao = null)
        {
             ApiResponse<DesbloquearCartaoResponse> localVarResponse = await DesbloquearCartaoUsingPOSTAsyncWithHttpInfo(idConta, idCartao, codigoSegurancao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desbloqueia um cart\u00C3\u00A3o Desbloquear cart\u00C3\u00A3o de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">C\u00C3\u00B3digo seguran\u00C3\u00A7a do cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (DesbloquearCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DesbloquearCartaoResponse>> DesbloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idConta, int? idCartao, string codigoSegurancao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DesbloquearCartaoUsingPOST");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}/desbloquear";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (codigoSegurancao != null) localVarHeaderParams.Add("codigoSegurancao", Configuration.ApiClient.ParameterToString(codigoSegurancao)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearCartaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DesbloquearCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DesbloquearCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DesbloquearCartaoResponse)));
            
        }
        
        /// <summary>
        /// Embossado N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param> 
        /// <returns>EmbossadoCartaoResponse</returns>
        public EmbossadoCartaoResponse EmbossadoCartaoUsingPUT (int? idConta, int? idCartao)
        {
             ApiResponse<EmbossadoCartaoResponse> localVarResponse = EmbossadoCartaoUsingPUTWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Embossado N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param> 
        /// <returns>ApiResponse of EmbossadoCartaoResponse</returns>
        public ApiResponse< EmbossadoCartaoResponse > EmbossadoCartaoUsingPUTWithHttpInfo (int? idConta, int? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->EmbossadoCartaoUsingPUT");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->EmbossadoCartaoUsingPUT");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}/embossado";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling EmbossadoCartaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EmbossadoCartaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmbossadoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmbossadoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmbossadoCartaoResponse)));
            
        }

        
        /// <summary>
        /// Embossado N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <returns>Task of EmbossadoCartaoResponse</returns>
        public async System.Threading.Tasks.Task<EmbossadoCartaoResponse> EmbossadoCartaoUsingPUTAsync (int? idConta, int? idCartao)
        {
             ApiResponse<EmbossadoCartaoResponse> localVarResponse = await EmbossadoCartaoUsingPUTAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Embossado N\u00C3\u00B3s informe caso tenha embossado algum cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o que deseja cancelar</param>
        /// <returns>Task of ApiResponse (EmbossadoCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmbossadoCartaoResponse>> EmbossadoCartaoUsingPUTAsyncWithHttpInfo (int? idConta, int? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EmbossadoCartaoUsingPUT");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling EmbossadoCartaoUsingPUT");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/cartoes/{idCartao}/embossado";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling EmbossadoCartaoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EmbossadoCartaoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmbossadoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmbossadoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmbossadoCartaoResponse)));
            
        }
        
    }
    
}
