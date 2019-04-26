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
    public interface ISMSApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param>
        /// <param name="idServicoSMSConta">idServicoSMSConta</param>
        /// <returns>Object</returns>
        Object DesativarServicoSMSConta (long? id, long? idServicoSMSConta);
  
        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param>
        /// <param name="idServicoSMSConta">idServicoSMSConta</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarServicoSMSContaWithHttpInfo (long? id, long? idServicoSMSConta);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>PageSMSEnvioResponse</returns>
        PageSMSEnvioResponse ListarSMS (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
  
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>ApiResponse of PageSMSEnvioResponse</returns>
        ApiResponse<PageSMSEnvioResponse> ListarSMSWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista os servi\u00E7os SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param>
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param>
        /// <returns>PageSMSContaResponse</returns>
        PageSMSContaResponse ListarServicosSmsConta (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista os servi\u00E7os SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param>
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param>
        /// <returns>ApiResponse of PageSMSContaResponse</returns>
        ApiResponse<PageSMSContaResponse> ListarServicosSmsContaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoServicoSMSResponse</returns>
        PageTipoServicoSMSResponse ListarTiposServicosSMS (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoServicoSMSResponse</returns>
        ApiResponse<PageTipoServicoSMSResponse> ListarTiposServicosSMSWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="smsContaPersist">smsContaPersist</param>
        /// <returns>Object</returns>
        Object SalvarServicoSMSConta (long? id, SMSContaPersist smsContaPersist);
  
        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="smsContaPersist">smsContaPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SalvarServicoSMSContaWithHttpInfo (long? id, SMSContaPersist smsContaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param>
        /// <param name="idServicoSMSConta">idServicoSMSConta</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarServicoSMSContaAsync (long? id, long? idServicoSMSConta);

        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param>
        /// <param name="idServicoSMSConta">idServicoSMSConta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarServicoSMSContaAsyncWithHttpInfo (long? id, long? idServicoSMSConta);
        
        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of PageSMSEnvioResponse</returns>
        System.Threading.Tasks.Task<PageSMSEnvioResponse> ListarSMSAsync (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);

        /// <summary>
        /// Listar SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSEnvioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageSMSEnvioResponse>> ListarSMSAsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// Lista os servi\u00E7os SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param>
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param>
        /// <returns>Task of PageSMSContaResponse</returns>
        System.Threading.Tasks.Task<PageSMSContaResponse> ListarServicosSmsContaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista os servi\u00E7os SMS da conta
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param>
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageSMSContaResponse>> ListarServicosSmsContaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoServicoSMSResponse</returns>
        System.Threading.Tasks.Task<PageTipoServicoSMSResponse> ListarTiposServicosSMSAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoServicoSMSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoServicoSMSResponse>> ListarTiposServicosSMSAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="smsContaPersist">smsContaPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SalvarServicoSMSContaAsync (long? id, SMSContaPersist smsContaPersist);

        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <remarks>
        /// Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="smsContaPersist">smsContaPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SalvarServicoSMSContaAsyncWithHttpInfo (long? id, SMSContaPersist smsContaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SMSApi : ISMSApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SMSApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SMSApi(Configuration configuration = null)
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
        /// Desativa um servi\u00E7o SMS da conta Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param> 
        /// <param name="idServicoSMSConta">idServicoSMSConta</param> 
        /// <returns>Object</returns>
        public Object DesativarServicoSMSConta (long? id, long? idServicoSMSConta)
        {
             ApiResponse<Object> localVarResponse = DesativarServicoSMSContaWithHttpInfo(id, idServicoSMSConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param> 
        /// <param name="idServicoSMSConta">idServicoSMSConta</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarServicoSMSContaWithHttpInfo (long? id, long? idServicoSMSConta)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SMSApi->DesativarServicoSMSConta");
            
            // verify the required parameter 'idServicoSMSConta' is set
            if (idServicoSMSConta == null)
                throw new ApiException(400, "Missing required parameter 'idServicoSMSConta' when calling SMSApi->DesativarServicoSMSConta");
            
    
            var localVarPath = "/api/contas/{id}/servicos-sms/{idServicoSMSConta}";
    
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
            if (idServicoSMSConta != null) localVarPathParams.Add("idServicoSMSConta", Configuration.ApiClient.ParameterToString(idServicoSMSConta)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoSMSConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoSMSConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param>
        /// <param name="idServicoSMSConta">idServicoSMSConta</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarServicoSMSContaAsync (long? id, long? idServicoSMSConta)
        {
             ApiResponse<Object> localVarResponse = await DesativarServicoSMSContaAsyncWithHttpInfo(id, idServicoSMSConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa um servi\u00E7o SMS da conta Esse recurso permite desativar um servi\u00E7o SMS ativado de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do Servi\u00E7o SMS Conta</param>
        /// <param name="idServicoSMSConta">idServicoSMSConta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarServicoSMSContaAsyncWithHttpInfo (long? id, long? idServicoSMSConta)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarServicoSMSConta");
            // verify the required parameter 'idServicoSMSConta' is set
            if (idServicoSMSConta == null) throw new ApiException(400, "Missing required parameter 'idServicoSMSConta' when calling DesativarServicoSMSConta");
            
    
            var localVarPath = "/api/contas/{id}/servicos-sms/{idServicoSMSConta}";
    
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
            if (idServicoSMSConta != null) localVarPathParams.Add("idServicoSMSConta", Configuration.ApiClient.ParameterToString(idServicoSMSConta)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoSMSConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoSMSConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param> 
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param> 
        /// <returns>PageSMSEnvioResponse</returns>
        public PageSMSEnvioResponse ListarSMS (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageSMSEnvioResponse> localVarResponse = ListarSMSWithHttpInfo(idConta, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param> 
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param> 
        /// <returns>ApiResponse of PageSMSEnvioResponse</returns>
        public ApiResponse< PageSMSEnvioResponse > ListarSMSWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling SMSApi->ListarSMS");
            
    
            var localVarPath = "/api/sms";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageSMSEnvioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSEnvioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSEnvioResponse)));
            
        }

        
        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of PageSMSEnvioResponse</returns>
        public async System.Threading.Tasks.Task<PageSMSEnvioResponse> ListarSMSAsync (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageSMSEnvioResponse> localVarResponse = await ListarSMSAsyncWithHttpInfo(idConta, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar SMS Esse recurso permite listar os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Data in\u00EDcio do per\u00EDodo da consulta (optional)</param>
        /// <param name="dataFim">Data fim do per\u00EDodo da consulta (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSEnvioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageSMSEnvioResponse>> ListarSMSAsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarSMS");
            
    
            var localVarPath = "/api/sms";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageSMSEnvioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSEnvioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSEnvioResponse)));
            
        }
        
        /// <summary>
        /// Lista os servi\u00E7os SMS da conta Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param> 
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param> 
        /// <returns>PageSMSContaResponse</returns>
        public PageSMSContaResponse ListarServicosSmsConta (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null)
        {
             ApiResponse<PageSMSContaResponse> localVarResponse = ListarServicosSmsContaWithHttpInfo(id, sort, page, limit, idSMSTipoServico, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os servi\u00E7os SMS da conta Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param> 
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param> 
        /// <returns>ApiResponse of PageSMSContaResponse</returns>
        public ApiResponse< PageSMSContaResponse > ListarServicosSmsContaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SMSApi->ListarServicosSmsConta");
            
    
            var localVarPath = "/api/contas/{id}/servicos-sms";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idSMSTipoServico != null) localVarQueryParams.Add("idSMSTipoServico", Configuration.ApiClient.ParameterToString(idSMSTipoServico)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosSmsConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosSmsConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageSMSContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSContaResponse)));
            
        }

        
        /// <summary>
        /// Lista os servi\u00E7os SMS da conta Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param>
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param>
        /// <returns>Task of PageSMSContaResponse</returns>
        public async System.Threading.Tasks.Task<PageSMSContaResponse> ListarServicosSmsContaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null)
        {
             ApiResponse<PageSMSContaResponse> localVarResponse = await ListarServicosSmsContaAsyncWithHttpInfo(id, sort, page, limit, idSMSTipoServico, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os servi\u00E7os SMS da conta Esse recurso permite listar servi\u00E7os SMS de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idSMSTipoServico">C\u00F3digo Identificador do tipo de Servi\u00E7o SMS (Id_SMSTipoServico) (optional)</param>
        /// <param name="flagAtivo">Se o par\u00E2metro for verdadeiro o recurso s\u00F3 retornar\u00E1 os servi\u00E7os ativos para a conta requisitada. Caso seja falso, retornar\u00E1 os servi\u00E7os inativos. Se o par\u00E2metro for nulo, retornar\u00E1 servi\u00E7os ativos e inativos (optional)</param>
        /// <returns>Task of ApiResponse (PageSMSContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageSMSContaResponse>> ListarServicosSmsContaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idSMSTipoServico = null, bool? flagAtivo = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarServicosSmsConta");
            
    
            var localVarPath = "/api/contas/{id}/servicos-sms";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idSMSTipoServico != null) localVarQueryParams.Add("idSMSTipoServico", Configuration.ApiClient.ParameterToString(idSMSTipoServico)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosSmsConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosSmsConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageSMSContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageSMSContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageSMSContaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoServicoSMSResponse</returns>
        public PageTipoServicoSMSResponse ListarTiposServicosSMS (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoServicoSMSResponse> localVarResponse = ListarTiposServicosSMSWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoServicoSMSResponse</returns>
        public ApiResponse< PageTipoServicoSMSResponse > ListarTiposServicosSMSWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-servicos-sms";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposServicosSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposServicosSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoServicoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoServicoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoServicoSMSResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoServicoSMSResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoServicoSMSResponse> ListarTiposServicosSMSAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoServicoSMSResponse> localVarResponse = await ListarTiposServicosSMSAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de Servi\u00E7os SMS Esse recurso permite listar os Tipos de Servi\u00E7os SMS
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoServicoSMSResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoServicoSMSResponse>> ListarTiposServicosSMSAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-servicos-sms";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposServicosSMS: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposServicosSMS: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoServicoSMSResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoServicoSMSResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoServicoSMSResponse)));
            
        }
        
        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta. Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="smsContaPersist">smsContaPersist</param> 
        /// <returns>Object</returns>
        public Object SalvarServicoSMSConta (long? id, SMSContaPersist smsContaPersist)
        {
             ApiResponse<Object> localVarResponse = SalvarServicoSMSContaWithHttpInfo(id, smsContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta. Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="smsContaPersist">smsContaPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SalvarServicoSMSContaWithHttpInfo (long? id, SMSContaPersist smsContaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SMSApi->SalvarServicoSMSConta");
            
            // verify the required parameter 'smsContaPersist' is set
            if (smsContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'smsContaPersist' when calling SMSApi->SalvarServicoSMSConta");
            
    
            var localVarPath = "/api/contas/{id}/servicos-sms";
    
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
            
            
            
            
            if (smsContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(smsContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = smsContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoSMSConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoSMSConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta. Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="smsContaPersist">smsContaPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SalvarServicoSMSContaAsync (long? id, SMSContaPersist smsContaPersist)
        {
             ApiResponse<Object> localVarResponse = await SalvarServicoSMSContaAsyncWithHttpInfo(id, smsContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva um Servi\u00E7o SMS para uma conta. Esse recurso permite salvar um servi\u00E7o SMS para uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="smsContaPersist">smsContaPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SalvarServicoSMSContaAsyncWithHttpInfo (long? id, SMSContaPersist smsContaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarServicoSMSConta");
            // verify the required parameter 'smsContaPersist' is set
            if (smsContaPersist == null) throw new ApiException(400, "Missing required parameter 'smsContaPersist' when calling SalvarServicoSMSConta");
            
    
            var localVarPath = "/api/contas/{id}/servicos-sms";
    
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
            
            
            
            
            if (smsContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(smsContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = smsContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoSMSConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoSMSConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
