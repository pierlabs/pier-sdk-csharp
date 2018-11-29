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
    public interface IGlobaltagacordoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{parcela_acordo_resource_consultar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_consultar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>ParcelaAcordoResponse</returns>
        ParcelaAcordoResponse ConsultarPorIdUsingGET (long? id);
  
        /// <summary>
        /// {{parcela_acordo_resource_consultar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_consultar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>ApiResponse of ParcelaAcordoResponse</returns>
        ApiResponse<ParcelaAcordoResponse> ConsultarPorIdUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{acordo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param>
        /// <returns>AcordoDetalheResponse</returns>
        AcordoDetalheResponse ConsultarUsingGET (long? id);
  
        /// <summary>
        /// {{{acordo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        ApiResponse<AcordoDetalheResponse> ConsultarUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>BoletoParcelaAcordoResponse</returns>
        BoletoParcelaAcordoResponse GerarBoletoUsingPOST (long? id);
  
        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>ApiResponse of BoletoParcelaAcordoResponse</returns>
        ApiResponse<BoletoParcelaAcordoResponse> GerarBoletoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{acordo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param>
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param>
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param>
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param>
        /// <returns>PageAcordoResponse</returns>
        PageAcordoResponse ListarUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
  
        /// <summary>
        /// {{{acordo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param>
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param>
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param>
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param>
        /// <returns>ApiResponse of PageAcordoResponse</returns>
        ApiResponse<PageAcordoResponse> ListarUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
        
        /// <summary>
        /// {{parcela_acordo_resource_listar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_listar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param>
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param>
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param>
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param>
        /// <returns>PageAcordoParcelaResponse</returns>
        PageAcordoParcelaResponse ListarUsingGET32 (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
  
        /// <summary>
        /// {{parcela_acordo_resource_listar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_listar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param>
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param>
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param>
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param>
        /// <returns>ApiResponse of PageAcordoParcelaResponse</returns>
        ApiResponse<PageAcordoParcelaResponse> ListarUsingGET32WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
        
        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_quebrarAcordo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param>
        /// <returns>AcordoQuebraResponse</returns>
        AcordoQuebraResponse QuebrarAcordoUsingPOST (long? id);
  
        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_quebrarAcordo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param>
        /// <returns>ApiResponse of AcordoQuebraResponse</returns>
        ApiResponse<AcordoQuebraResponse> QuebrarAcordoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanoParcelamentosAcordoResponseValue</returns>
        PlanoParcelamentosAcordoResponseValue SimularPlanosParcelamentosUsingPOST (PlanoParcelamentoAcordoRequestValue request);
  
        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanoParcelamentosAcordoResponseValue</returns>
        ApiResponse<PlanoParcelamentosAcordoResponseValue> SimularPlanosParcelamentosUsingPOSTWithHttpInfo (PlanoParcelamentoAcordoRequestValue request);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{parcela_acordo_resource_consultar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_consultar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of ParcelaAcordoResponse</returns>
        System.Threading.Tasks.Task<ParcelaAcordoResponse> ConsultarPorIdUsingGETAsync (long? id);

        /// <summary>
        /// {{parcela_acordo_resource_consultar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_consultar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of ApiResponse (ParcelaAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelaAcordoResponse>> ConsultarPorIdUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{acordo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        System.Threading.Tasks.Task<AcordoDetalheResponse> ConsultarUsingGETAsync (long? id);

        /// <summary>
        /// {{{acordo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> ConsultarUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of BoletoParcelaAcordoResponse</returns>
        System.Threading.Tasks.Task<BoletoParcelaAcordoResponse> GerarBoletoUsingPOSTAsync (long? id);

        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of ApiResponse (BoletoParcelaAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoParcelaAcordoResponse>> GerarBoletoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{acordo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param>
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param>
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param>
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param>
        /// <returns>Task of PageAcordoResponse</returns>
        System.Threading.Tasks.Task<PageAcordoResponse> ListarUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);

        /// <summary>
        /// {{{acordo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param>
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param>
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param>
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAcordoResponse>> ListarUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
        
        /// <summary>
        /// {{parcela_acordo_resource_listar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_listar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param>
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param>
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param>
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param>
        /// <returns>Task of PageAcordoParcelaResponse</returns>
        System.Threading.Tasks.Task<PageAcordoParcelaResponse> ListarUsingGET32Async (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);

        /// <summary>
        /// {{parcela_acordo_resource_listar}}
        /// </summary>
        /// <remarks>
        /// {{parcela_acordo_resource_listar_notes}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param>
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param>
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param>
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoParcelaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAcordoParcelaResponse>> ListarUsingGET32AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
        
        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_quebrarAcordo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param>
        /// <returns>Task of AcordoQuebraResponse</returns>
        System.Threading.Tasks.Task<AcordoQuebraResponse> QuebrarAcordoUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_quebrarAcordo_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param>
        /// <returns>Task of ApiResponse (AcordoQuebraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoQuebraResponse>> QuebrarAcordoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentosAcordoResponseValue</returns>
        System.Threading.Tasks.Task<PlanoParcelamentosAcordoResponseValue> SimularPlanosParcelamentosUsingPOSTAsync (PlanoParcelamentoAcordoRequestValue request);

        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}}
        /// </summary>
        /// <remarks>
        /// {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentosAcordoResponseValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentosAcordoResponseValue>> SimularPlanosParcelamentosUsingPOSTAsyncWithHttpInfo (PlanoParcelamentoAcordoRequestValue request);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagacordoApi : IGlobaltagacordoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagacordoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagacordoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagacordoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagacordoApi(Configuration configuration = null)
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
        /// {{parcela_acordo_resource_consultar}} {{parcela_acordo_resource_consultar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param> 
        /// <returns>ParcelaAcordoResponse</returns>
        public ParcelaAcordoResponse ConsultarPorIdUsingGET (long? id)
        {
             ApiResponse<ParcelaAcordoResponse> localVarResponse = ConsultarPorIdUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{parcela_acordo_resource_consultar}} {{parcela_acordo_resource_consultar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param> 
        /// <returns>ApiResponse of ParcelaAcordoResponse</returns>
        public ApiResponse< ParcelaAcordoResponse > ConsultarPorIdUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagacordoApi->ConsultarPorIdUsingGET");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorIdUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorIdUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelaAcordoResponse)));
            
        }

        
        /// <summary>
        /// {{parcela_acordo_resource_consultar}} {{parcela_acordo_resource_consultar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of ParcelaAcordoResponse</returns>
        public async System.Threading.Tasks.Task<ParcelaAcordoResponse> ConsultarPorIdUsingGETAsync (long? id)
        {
             ApiResponse<ParcelaAcordoResponse> localVarResponse = await ConsultarPorIdUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{parcela_acordo_resource_consultar}} {{parcela_acordo_resource_consultar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of ApiResponse (ParcelaAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelaAcordoResponse>> ConsultarPorIdUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPorIdUsingGET");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorIdUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorIdUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelaAcordoResponse)));
            
        }
        
        /// <summary>
        /// {{{acordo_resource_consultar}}} {{{acordo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param> 
        /// <returns>AcordoDetalheResponse</returns>
        public AcordoDetalheResponse ConsultarUsingGET (long? id)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = ConsultarUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{acordo_resource_consultar}}} {{{acordo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        public ApiResponse< AcordoDetalheResponse > ConsultarUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagacordoApi->ConsultarUsingGET");
            
    
            var localVarPath = "/api/acordos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{acordo_resource_consultar}}} {{{acordo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AcordoDetalheResponse> ConsultarUsingGETAsync (long? id)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = await ConsultarUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{acordo_resource_consultar}}} {{{acordo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> ConsultarUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET");
            
    
            var localVarPath = "/api/acordos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}} {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param> 
        /// <returns>BoletoParcelaAcordoResponse</returns>
        public BoletoParcelaAcordoResponse GerarBoletoUsingPOST (long? id)
        {
             ApiResponse<BoletoParcelaAcordoResponse> localVarResponse = GerarBoletoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}} {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param> 
        /// <returns>ApiResponse of BoletoParcelaAcordoResponse</returns>
        public ApiResponse< BoletoParcelaAcordoResponse > GerarBoletoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagacordoApi->GerarBoletoUsingPOST");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}/boletos";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoParcelaAcordoResponse)));
            
        }

        
        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}} {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of BoletoParcelaAcordoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoParcelaAcordoResponse> GerarBoletoUsingPOSTAsync (long? id)
        {
             ApiResponse<BoletoParcelaAcordoResponse> localVarResponse = await GerarBoletoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{parcela_acordo_resource_gerar_boleto}} {{parcela_acordo_resource_gerar_boleto_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{parcela_acordo_resource_param_value_id}}</param>
        /// <returns>Task of ApiResponse (BoletoParcelaAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoParcelaAcordoResponse>> GerarBoletoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoUsingPOST");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}/boletos";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoParcelaAcordoResponse)));
            
        }
        
        /// <summary>
        /// {{{acordo_resource_listar}}} {{{acordo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param> 
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param> 
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param> 
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param> 
        /// <returns>PageAcordoResponse</returns>
        public PageAcordoResponse ListarUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
             ApiResponse<PageAcordoResponse> localVarResponse = ListarUsingGETWithHttpInfo(sort, page, limit, idConta, statusAcordo, dataAcordo, quantidadeParcelas);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{acordo_resource_listar}}} {{{acordo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param> 
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param> 
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param> 
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageAcordoResponse</returns>
        public ApiResponse< PageAcordoResponse > ListarUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
            
    
            var localVarPath = "/api/acordos";
    
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
            if (statusAcordo != null) localVarQueryParams.Add("statusAcordo", Configuration.ApiClient.ParameterToString(statusAcordo)); // query parameter
            if (dataAcordo != null) localVarQueryParams.Add("dataAcordo", Configuration.ApiClient.ParameterToString(dataAcordo)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoResponse)));
            
        }

        
        /// <summary>
        /// {{{acordo_resource_listar}}} {{{acordo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param>
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param>
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param>
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param>
        /// <returns>Task of PageAcordoResponse</returns>
        public async System.Threading.Tasks.Task<PageAcordoResponse> ListarUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
             ApiResponse<PageAcordoResponse> localVarResponse = await ListarUsingGETAsyncWithHttpInfo(sort, page, limit, idConta, statusAcordo, dataAcordo, quantidadeParcelas);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{acordo_resource_listar}}} {{{acordo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{acordo_request_id_conta_value}}} (optional)</param>
        /// <param name="statusAcordo">{{{acordo_request_status_acordo_value}}} (optional)</param>
        /// <param name="dataAcordo">{{{acordo_request_data_acordo_value}}} (optional)</param>
        /// <param name="quantidadeParcelas">{{{acordo_request_quantidade_parcelas_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAcordoResponse>> ListarUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
            
    
            var localVarPath = "/api/acordos";
    
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
            if (statusAcordo != null) localVarQueryParams.Add("statusAcordo", Configuration.ApiClient.ParameterToString(statusAcordo)); // query parameter
            if (dataAcordo != null) localVarQueryParams.Add("dataAcordo", Configuration.ApiClient.ParameterToString(dataAcordo)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoResponse)));
            
        }
        
        /// <summary>
        /// {{parcela_acordo_resource_listar}} {{parcela_acordo_resource_listar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param> 
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param> 
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param> 
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param> 
        /// <returns>PageAcordoParcelaResponse</returns>
        public PageAcordoParcelaResponse ListarUsingGET32 (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
             ApiResponse<PageAcordoParcelaResponse> localVarResponse = ListarUsingGET32WithHttpInfo(sort, page, limit, idAcordo, nossoNumero, numeroParcela, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{parcela_acordo_resource_listar}} {{parcela_acordo_resource_listar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param> 
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param> 
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param> 
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param> 
        /// <returns>ApiResponse of PageAcordoParcelaResponse</returns>
        public ApiResponse< PageAcordoParcelaResponse > ListarUsingGET32WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
            
    
            var localVarPath = "/api/parcelas-acordos";
    
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
            if (idAcordo != null) localVarQueryParams.Add("idAcordo", Configuration.ApiClient.ParameterToString(idAcordo)); // query parameter
            if (nossoNumero != null) localVarQueryParams.Add("nossoNumero", Configuration.ApiClient.ParameterToString(nossoNumero)); // query parameter
            if (numeroParcela != null) localVarQueryParams.Add("numeroParcela", Configuration.ApiClient.ParameterToString(numeroParcela)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAcordoParcelaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoParcelaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoParcelaResponse)));
            
        }

        
        /// <summary>
        /// {{parcela_acordo_resource_listar}} {{parcela_acordo_resource_listar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param>
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param>
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param>
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param>
        /// <returns>Task of PageAcordoParcelaResponse</returns>
        public async System.Threading.Tasks.Task<PageAcordoParcelaResponse> ListarUsingGET32Async (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
             ApiResponse<PageAcordoParcelaResponse> localVarResponse = await ListarUsingGET32AsyncWithHttpInfo(sort, page, limit, idAcordo, nossoNumero, numeroParcela, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{parcela_acordo_resource_listar}} {{parcela_acordo_resource_listar_notes}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idAcordo">{{acordo_parcela_request_id_acordo_value}} (optional)</param>
        /// <param name="nossoNumero">{{acordo_parcela_request_nosso_numero_value}} (optional)</param>
        /// <param name="numeroParcela">{{acordo_parcela_request_numero_parcela_value}} (optional)</param>
        /// <param name="dataVencimento">{{acordo_parcela_request_data_vencimento_value}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoParcelaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAcordoParcelaResponse>> ListarUsingGET32AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
            
    
            var localVarPath = "/api/parcelas-acordos";
    
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
            if (idAcordo != null) localVarQueryParams.Add("idAcordo", Configuration.ApiClient.ParameterToString(idAcordo)); // query parameter
            if (nossoNumero != null) localVarQueryParams.Add("nossoNumero", Configuration.ApiClient.ParameterToString(nossoNumero)); // query parameter
            if (numeroParcela != null) localVarQueryParams.Add("numeroParcela", Configuration.ApiClient.ParameterToString(numeroParcela)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAcordoParcelaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoParcelaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoParcelaResponse)));
            
        }
        
        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}} {{{acordo_resource_quebrarAcordo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param> 
        /// <returns>AcordoQuebraResponse</returns>
        public AcordoQuebraResponse QuebrarAcordoUsingPOST (long? id)
        {
             ApiResponse<AcordoQuebraResponse> localVarResponse = QuebrarAcordoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}} {{{acordo_resource_quebrarAcordo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param> 
        /// <returns>ApiResponse of AcordoQuebraResponse</returns>
        public ApiResponse< AcordoQuebraResponse > QuebrarAcordoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagacordoApi->QuebrarAcordoUsingPOST");
            
    
            var localVarPath = "/api/acordos/{id}/quebrar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AcordoQuebraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoQuebraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoQuebraResponse)));
            
        }

        
        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}} {{{acordo_resource_quebrarAcordo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param>
        /// <returns>Task of AcordoQuebraResponse</returns>
        public async System.Threading.Tasks.Task<AcordoQuebraResponse> QuebrarAcordoUsingPOSTAsync (long? id)
        {
             ApiResponse<AcordoQuebraResponse> localVarResponse = await QuebrarAcordoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{acordo_resource_quebrarAcordo}}} {{{acordo_resource_quebrarAcordo_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{acordo_resource_quebrarAcordo_param_id}}}</param>
        /// <returns>Task of ApiResponse (AcordoQuebraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcordoQuebraResponse>> QuebrarAcordoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling QuebrarAcordoUsingPOST");
            
    
            var localVarPath = "/api/acordos/{id}/quebrar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AcordoQuebraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoQuebraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoQuebraResponse)));
            
        }
        
        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}} {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanoParcelamentosAcordoResponseValue</returns>
        public PlanoParcelamentosAcordoResponseValue SimularPlanosParcelamentosUsingPOST (PlanoParcelamentoAcordoRequestValue request)
        {
             ApiResponse<PlanoParcelamentosAcordoResponseValue> localVarResponse = SimularPlanosParcelamentosUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}} {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanoParcelamentosAcordoResponseValue</returns>
        public ApiResponse< PlanoParcelamentosAcordoResponseValue > SimularPlanosParcelamentosUsingPOSTWithHttpInfo (PlanoParcelamentoAcordoRequestValue request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagacordoApi->SimularPlanosParcelamentosUsingPOST");
            
    
            var localVarPath = "/api/acordos/planos-parcelamentos";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanoParcelamentosAcordoResponseValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentosAcordoResponseValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentosAcordoResponseValue)));
            
        }

        
        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}} {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentosAcordoResponseValue</returns>
        public async System.Threading.Tasks.Task<PlanoParcelamentosAcordoResponseValue> SimularPlanosParcelamentosUsingPOSTAsync (PlanoParcelamentoAcordoRequestValue request)
        {
             ApiResponse<PlanoParcelamentosAcordoResponseValue> localVarResponse = await SimularPlanosParcelamentosUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{acordo_resource_simular_planos_parcelamentos_value}}} {{{acordo_resource_simular_planos_parcelamentos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentosAcordoResponseValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentosAcordoResponseValue>> SimularPlanosParcelamentosUsingPOSTAsyncWithHttpInfo (PlanoParcelamentoAcordoRequestValue request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularPlanosParcelamentosUsingPOST");
            
    
            var localVarPath = "/api/acordos/planos-parcelamentos";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanoParcelamentosAcordoResponseValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentosAcordoResponseValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentosAcordoResponseValue)));
            
        }
        
    }
    
}
