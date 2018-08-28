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
    public interface IGlobaltagdebitorecorrenteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        ContaDebitoRecorrenteResponse AderirDebitoRecorrenteUsingPOST (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);
  
        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        ApiResponse<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteUsingPOSTWithHttpInfo (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        ContaDebitoRecorrenteResponse CancelarDebitoRecorrenteUsingPOST (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);
  
        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        ApiResponse<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteUsingPOSTWithHttpInfo (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param>
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param>
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param>
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param>
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param>
        /// <returns>PageContaDebitoRecorrenteResponse</returns>
        PageContaDebitoRecorrenteResponse ListarUsingGET18 (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
  
        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param>
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param>
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param>
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param>
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageContaDebitoRecorrenteResponse</returns>
        ApiResponse<PageContaDebitoRecorrenteResponse> ListarUsingGET18WithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param>
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param>
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        PageTipoDebitoRecorrenteResponse ListarUsingGET56 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
  
        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param>
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        ApiResponse<PageTipoDebitoRecorrenteResponse> ListarUsingGET56WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteUsingPOSTAsync (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);

        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> AderirDebitoRecorrenteUsingPOSTAsyncWithHttpInfo (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteUsingPOSTAsync (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);

        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> CancelarDebitoRecorrenteUsingPOSTAsyncWithHttpInfo (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist);
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param>
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param>
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param>
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param>
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param>
        /// <returns>Task of PageContaDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageContaDebitoRecorrenteResponse> ListarUsingGET18Async (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);

        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param>
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param>
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param>
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param>
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDebitoRecorrenteResponse>> ListarUsingGET18AsyncWithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null);
        
        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param>
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> ListarUsingGET56Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);

        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param>
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> ListarUsingGET56AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagdebitorecorrenteApi : IGlobaltagdebitorecorrenteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdebitorecorrenteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagdebitorecorrenteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdebitorecorrenteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagdebitorecorrenteApi(Configuration configuration = null)
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
        /// {{{conta_debito_recorrente_resource_aderir}}} {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        public ContaDebitoRecorrenteResponse AderirDebitoRecorrenteUsingPOST (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = AderirDebitoRecorrenteUsingPOSTWithHttpInfo(contaDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}} {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        public ApiResponse< ContaDebitoRecorrenteResponse > AderirDebitoRecorrenteUsingPOSTWithHttpInfo (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling GlobaltagdebitorecorrenteApi->AderirDebitoRecorrenteUsingPOST");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrenteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrenteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}} {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> AderirDebitoRecorrenteUsingPOSTAsync (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = await AderirDebitoRecorrenteUsingPOSTAsyncWithHttpInfo(contaDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_debito_recorrente_resource_aderir}}} {{{conta_debito_recorrente_resource_aderir_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> AderirDebitoRecorrenteUsingPOSTAsyncWithHttpInfo (ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling AderirDebitoRecorrenteUsingPOST");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrenteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirDebitoRecorrenteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}} {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param> 
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ContaDebitoRecorrenteResponse</returns>
        public ContaDebitoRecorrenteResponse CancelarDebitoRecorrenteUsingPOST (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = CancelarDebitoRecorrenteUsingPOSTWithHttpInfo(id, contaDebitoRecorrentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}} {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param> 
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param> 
        /// <returns>ApiResponse of ContaDebitoRecorrenteResponse</returns>
        public ApiResponse< ContaDebitoRecorrenteResponse > CancelarDebitoRecorrenteUsingPOSTWithHttpInfo (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdebitorecorrenteApi->CancelarDebitoRecorrenteUsingPOST");
            
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null)
                throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling GlobaltagdebitorecorrenteApi->CancelarDebitoRecorrenteUsingPOST");
            
    
            var localVarPath = "/api/debitos-recorrentes/{id}/cancelar";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrenteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrenteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}} {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<ContaDebitoRecorrenteResponse> CancelarDebitoRecorrenteUsingPOSTAsync (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
             ApiResponse<ContaDebitoRecorrenteResponse> localVarResponse = await CancelarDebitoRecorrenteUsingPOSTAsyncWithHttpInfo(id, contaDebitoRecorrentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_debito_recorrente_resource_cancelar}}} {{{conta_debito_recorrente_resource_cancelar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_debito_recorrente_resource_cancelar_param_id_debito_recorrente}}}</param>
        /// <param name="contaDebitoRecorrentePersist">contaDebitoRecorrentePersist</param>
        /// <returns>Task of ApiResponse (ContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDebitoRecorrenteResponse>> CancelarDebitoRecorrenteUsingPOSTAsyncWithHttpInfo (long? id, ContaDebitoRecorrentePersistValue contaDebitoRecorrentePersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarDebitoRecorrenteUsingPOST");
            // verify the required parameter 'contaDebitoRecorrentePersist' is set
            if (contaDebitoRecorrentePersist == null) throw new ApiException(400, "Missing required parameter 'contaDebitoRecorrentePersist' when calling CancelarDebitoRecorrenteUsingPOST");
            
    
            var localVarPath = "/api/debitos-recorrentes/{id}/cancelar";
    
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
            
            
            
            
            if (contaDebitoRecorrentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaDebitoRecorrentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaDebitoRecorrentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrenteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarDebitoRecorrenteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}} {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param> 
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param> 
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param> 
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param> 
        /// <returns>PageContaDebitoRecorrenteResponse</returns>
        public PageContaDebitoRecorrenteResponse ListarUsingGET18 (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageContaDebitoRecorrenteResponse> localVarResponse = ListarUsingGET18WithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}} {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param> 
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param> 
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param> 
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param> 
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageContaDebitoRecorrenteResponse</returns>
        public ApiResponse< PageContaDebitoRecorrenteResponse > ListarUsingGET18WithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagdebitorecorrenteApi->ListarUsingGET18");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}} {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param>
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param>
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param>
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param>
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param>
        /// <returns>Task of PageContaDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDebitoRecorrenteResponse> ListarUsingGET18Async (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
             ApiResponse<PageContaDebitoRecorrenteResponse> localVarResponse = await ListarUsingGET18AsyncWithHttpInfo(idConta, idTipoDebitoRecorrente, sort, page, limit, dataHoraInicio, dataHoraFim, ativo, dataHoraUltimoPagamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_debito_recorrente_resource_listar}}} {{{conta_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{conta_debito_recorrente_resource_listar_param_id_conta}}}</param>
        /// <param name="idTipoDebitoRecorrente">{{{conta_debito_recorrente_resource_listar_param_id_tipo_debito_recorrente}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataHoraInicio">{{{conta_debito_recorrente_request_data_hora_inicio_value}}} (optional)</param>
        /// <param name="dataHoraFim">{{{conta_debito_recorrente_request_data_hora_fim_value}}} (optional)</param>
        /// <param name="ativo">{{{conta_debito_recorrente_request_ativo_value}}} (optional)</param>
        /// <param name="dataHoraUltimoPagamento">{{{conta_debito_recorrente_request_data_hora_ultimo_pagamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDebitoRecorrenteResponse>> ListarUsingGET18AsyncWithHttpInfo (long? idConta, long? idTipoDebitoRecorrente = null, List<string> sort = null, int? page = null, int? limit = null, string dataHoraInicio = null, string dataHoraFim = null, bool? ativo = null, string dataHoraUltimoPagamento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarUsingGET18");
            
    
            var localVarPath = "/api/debitos-recorrentes";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoDebitoRecorrente != null) localVarQueryParams.Add("idTipoDebitoRecorrente", Configuration.ApiClient.ParameterToString(idTipoDebitoRecorrente)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (dataHoraInicio != null) localVarQueryParams.Add("dataHoraInicio", Configuration.ApiClient.ParameterToString(dataHoraInicio)); // query parameter
            if (dataHoraFim != null) localVarQueryParams.Add("dataHoraFim", Configuration.ApiClient.ParameterToString(dataHoraFim)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (dataHoraUltimoPagamento != null) localVarQueryParams.Add("dataHoraUltimoPagamento", Configuration.ApiClient.ParameterToString(dataHoraUltimoPagamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDebitoRecorrenteResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}} {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param> 
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param> 
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param> 
        /// <returns>PageTipoDebitoRecorrenteResponse</returns>
        public PageTipoDebitoRecorrenteResponse ListarUsingGET56 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = ListarUsingGET56WithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}} {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param> 
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param> 
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoDebitoRecorrenteResponse</returns>
        public ApiResponse< PageTipoDebitoRecorrenteResponse > ListarUsingGET56WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}} {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param>
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param>
        /// <returns>Task of PageTipoDebitoRecorrenteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoDebitoRecorrenteResponse> ListarUsingGET56Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoDebitoRecorrenteResponse> localVarResponse = await ListarUsingGET56AsyncWithHttpInfo(sort, page, limit, id, descricao, valor, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_debito_recorrente_resource_listar}}} {{{tipo_debito_recorrente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_debito_recorrente_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_debito_recorrente_request_descricao_value}}} (optional)</param>
        /// <param name="valor">{{{tipo_debito_recorrente_request_valor_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{tipo_debito_recorrente_request_flag_ativo_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoDebitoRecorrenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoDebitoRecorrenteResponse>> ListarUsingGET56AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, double? valor = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-debitos-recorrentes";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET56: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoDebitoRecorrenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoDebitoRecorrenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoDebitoRecorrenteResponse)));
            
        }
        
    }
    
}
