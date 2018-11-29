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
    public interface IGlobaltagdadosbancarioscontaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>DadosBancariosContaResponse</returns>
        DadosBancariosContaResponse AlterarUsingPUT5 (long? id, DadosBancariosContaUpdate update);
  
        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        ApiResponse<DadosBancariosContaResponse> AlterarUsingPUT5WithHttpInfo (long? id, DadosBancariosContaUpdate update);
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param>
        /// <returns>DadosBancariosContaResponse</returns>
        DadosBancariosContaResponse ConsultarUsingGET15 (long? id);
  
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param>
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        ApiResponse<DadosBancariosContaResponse> ConsultarUsingGET15WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>CdtTipoContaBancaria</returns>
        CdtTipoContaBancaria ConsultarUsingGET42 (long? id);
  
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        ApiResponse<CdtTipoContaBancaria> ConsultarUsingGET42WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param>
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param>
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param>
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param>
        /// <returns>PageDadosBancariosContaResponse</returns>
        PageDadosBancariosContaResponse ListarUsingGET16 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);
  
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param>
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param>
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param>
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param>
        /// <returns>ApiResponse of PageDadosBancariosContaResponse</returns>
        ApiResponse<PageDadosBancariosContaResponse> ListarUsingGET16WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);
        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param>
        /// <returns>CdtTipoContaBancaria</returns>
        CdtTipoContaBancaria ListarUsingGET50 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
  
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        ApiResponse<CdtTipoContaBancaria> ListarUsingGET50WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>DadosBancariosContaResponse</returns>
        DadosBancariosContaResponse SalvarUsingPOST10 (DadosBancariosContaPersist dadosBancariosContaPersist);
  
        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        ApiResponse<DadosBancariosContaResponse> SalvarUsingPOST10WithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<DadosBancariosContaResponse> AlterarUsingPUT5Async (long? id, DadosBancariosContaUpdate update);

        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, DadosBancariosContaUpdate update);
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<DadosBancariosContaResponse> ConsultarUsingGET15Async (long? id);

        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> ConsultarUsingGET15AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        System.Threading.Tasks.Task<CdtTipoContaBancaria> ConsultarUsingGET42Async (long? id);

        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> ConsultarUsingGET42AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param>
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param>
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param>
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param>
        /// <returns>Task of PageDadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<PageDadosBancariosContaResponse> ListarUsingGET16Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);

        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param>
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param>
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param>
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDadosBancariosContaResponse>> ListarUsingGET16AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null);
        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        System.Threading.Tasks.Task<CdtTipoContaBancaria> ListarUsingGET50Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);

        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> ListarUsingGET50AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        System.Threading.Tasks.Task<DadosBancariosContaResponse> SalvarUsingPOST10Async (DadosBancariosContaPersist dadosBancariosContaPersist);

        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> SalvarUsingPOST10AsyncWithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagdadosbancarioscontaApi : IGlobaltagdadosbancarioscontaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdadosbancarioscontaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagdadosbancarioscontaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdadosbancarioscontaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagdadosbancarioscontaApi(Configuration configuration = null)
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
        /// {{{dados_bancarios_conta_resource_alterar}}} {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="update">update</param> 
        /// <returns>DadosBancariosContaResponse</returns>
        public DadosBancariosContaResponse AlterarUsingPUT5 (long? id, DadosBancariosContaUpdate update)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = AlterarUsingPUT5WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}} {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        public ApiResponse< DadosBancariosContaResponse > AlterarUsingPUT5WithHttpInfo (long? id, DadosBancariosContaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdadosbancarioscontaApi->AlterarUsingPUT5");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagdadosbancarioscontaApi->AlterarUsingPUT5");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}} {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<DadosBancariosContaResponse> AlterarUsingPUT5Async (long? id, DadosBancariosContaUpdate update)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = await AlterarUsingPUT5AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_alterar}}} {{{dados_bancarios_conta_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, DadosBancariosContaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT5");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT5");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}} {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param> 
        /// <returns>DadosBancariosContaResponse</returns>
        public DadosBancariosContaResponse ConsultarUsingGET15 (long? id)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = ConsultarUsingGET15WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}} {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        public ApiResponse< DadosBancariosContaResponse > ConsultarUsingGET15WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdadosbancarioscontaApi->ConsultarUsingGET15");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}} {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<DadosBancariosContaResponse> ConsultarUsingGET15Async (long? id)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = await ConsultarUsingGET15AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultar}}} {{{dados_bancarios_conta_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{dados_bancarios_conta_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> ConsultarUsingGET15AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET15");
            
    
            var localVarPath = "/api/dados-bancarios-conta/{id}";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}} {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param> 
        /// <returns>CdtTipoContaBancaria</returns>
        public CdtTipoContaBancaria ConsultarUsingGET42 (long? id)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = ConsultarUsingGET42WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}} {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        public ApiResponse< CdtTipoContaBancaria > ConsultarUsingGET42WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdadosbancarioscontaApi->ConsultarUsingGET42");
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias/{id}";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET42: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET42: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }

        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}} {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        public async System.Threading.Tasks.Task<CdtTipoContaBancaria> ConsultarUsingGET42Async (long? id)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = await ConsultarUsingGET42AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_conta_bancaria_resource_consultar}}} {{{tipo_conta_bancaria_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_conta_bancaria_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> ConsultarUsingGET42AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET42");
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias/{id}";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET42: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET42: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}} {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param> 
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param> 
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param> 
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param> 
        /// <returns>PageDadosBancariosContaResponse</returns>
        public PageDadosBancariosContaResponse ListarUsingGET16 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
             ApiResponse<PageDadosBancariosContaResponse> localVarResponse = ListarUsingGET16WithHttpInfo(sort, page, limit, id, idConta, codigoBanco, numeroAgencia, numeroContaCorrente, idTipoContaBancaria);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}} {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param> 
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param> 
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param> 
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageDadosBancariosContaResponse</returns>
        public ApiResponse< PageDadosBancariosContaResponse > ListarUsingGET16WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (codigoBanco != null) localVarQueryParams.Add("codigoBanco", Configuration.ApiClient.ParameterToString(codigoBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (idTipoContaBancaria != null) localVarQueryParams.Add("idTipoContaBancaria", Configuration.ApiClient.ParameterToString(idTipoContaBancaria)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}} {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param>
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param>
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param>
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param>
        /// <returns>Task of PageDadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<PageDadosBancariosContaResponse> ListarUsingGET16Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
             ApiResponse<PageDadosBancariosContaResponse> localVarResponse = await ListarUsingGET16AsyncWithHttpInfo(sort, page, limit, id, idConta, codigoBanco, numeroAgencia, numeroContaCorrente, idTipoContaBancaria);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_consultarPage}}} {{{dados_bancarios_conta_resource_consultarPage_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{dados_bancarios_conta_request_id_value}}} (optional)</param>
        /// <param name="idConta">{{{dados_bancarios_conta_request_idConta_value}}} (optional)</param>
        /// <param name="codigoBanco">{{{dados_bancarios_conta_request_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{dados_bancarios_conta_request_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{dados_bancarios_conta_request_contaCorrente_value}}} (optional)</param>
        /// <param name="idTipoContaBancaria">{{{dados_bancarios_conta_request_IdTipoContaBancaria_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDadosBancariosContaResponse>> ListarUsingGET16AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? codigoBanco = null, long? numeroAgencia = null, string numeroContaCorrente = null, long? idTipoContaBancaria = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (codigoBanco != null) localVarQueryParams.Add("codigoBanco", Configuration.ApiClient.ParameterToString(codigoBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (idTipoContaBancaria != null) localVarQueryParams.Add("idTipoContaBancaria", Configuration.ApiClient.ParameterToString(idTipoContaBancaria)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDadosBancariosContaResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}} {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param> 
        /// <returns>CdtTipoContaBancaria</returns>
        public CdtTipoContaBancaria ListarUsingGET50 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = ListarUsingGET50WithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}} {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of CdtTipoContaBancaria</returns>
        public ApiResponse< CdtTipoContaBancaria > ListarUsingGET50WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET50: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET50: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }

        
        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}} {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param>
        /// <returns>Task of CdtTipoContaBancaria</returns>
        public async System.Threading.Tasks.Task<CdtTipoContaBancaria> ListarUsingGET50Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<CdtTipoContaBancaria> localVarResponse = await ListarUsingGET50AsyncWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_conta_bancaria_resource_listar}}} {{{tipo_conta_bancaria_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="descricao">{{{tipo_conta_bancaria_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (CdtTipoContaBancaria)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CdtTipoContaBancaria>> ListarUsingGET50AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/dados-bancarios-conta/tipos-contas-bancarias";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET50: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET50: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CdtTipoContaBancaria>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtTipoContaBancaria) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtTipoContaBancaria)));
            
        }
        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}} {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param> 
        /// <returns>DadosBancariosContaResponse</returns>
        public DadosBancariosContaResponse SalvarUsingPOST10 (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = SalvarUsingPOST10WithHttpInfo(dadosBancariosContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}} {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param> 
        /// <returns>ApiResponse of DadosBancariosContaResponse</returns>
        public ApiResponse< DadosBancariosContaResponse > SalvarUsingPOST10WithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
            
            // verify the required parameter 'dadosBancariosContaPersist' is set
            if (dadosBancariosContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'dadosBancariosContaPersist' when calling GlobaltagdadosbancarioscontaApi->SalvarUsingPOST10");
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            
            
            
            
            if (dadosBancariosContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dadosBancariosContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dadosBancariosContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }

        
        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}} {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of DadosBancariosContaResponse</returns>
        public async System.Threading.Tasks.Task<DadosBancariosContaResponse> SalvarUsingPOST10Async (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
             ApiResponse<DadosBancariosContaResponse> localVarResponse = await SalvarUsingPOST10AsyncWithHttpInfo(dadosBancariosContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{dados_bancarios_conta_resource_salvar}}} {{{dados_bancarios_conta_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dadosBancariosContaPersist">dadosBancariosContaPersist</param>
        /// <returns>Task of ApiResponse (DadosBancariosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosBancariosContaResponse>> SalvarUsingPOST10AsyncWithHttpInfo (DadosBancariosContaPersist dadosBancariosContaPersist)
        {
            // verify the required parameter 'dadosBancariosContaPersist' is set
            if (dadosBancariosContaPersist == null) throw new ApiException(400, "Missing required parameter 'dadosBancariosContaPersist' when calling SalvarUsingPOST10");
            
    
            var localVarPath = "/api/dados-bancarios-conta";
    
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
            
            
            
            
            if (dadosBancariosContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dadosBancariosContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dadosBancariosContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosBancariosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosBancariosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosBancariosContaResponse)));
            
        }
        
    }
    
}
