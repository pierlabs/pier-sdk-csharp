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
    public interface IGlobaltagajustefinanceiroApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param>
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param>
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse AjustarContaUsingPOST (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null);
  
        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param>
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param>
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> AjustarContaUsingPOSTWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null);
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse ConsultarUsingGET2 (long? id);
  
        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> ConsultarUsingGET2WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param>
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param>
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param>
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param>
        /// <returns>PageAjusteResponse</returns>
        PageAjusteResponse ListarUsingGET2 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
  
        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param>
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param>
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param>
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param>
        /// <returns>ApiResponse of PageAjusteResponse</returns>
        ApiResponse<PageAjusteResponse> ListarUsingGET2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param>
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param>
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaUsingPOSTAsync (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null);

        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param>
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param>
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaUsingPOSTAsyncWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null);
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> ConsultarUsingGET2Async (long? id);

        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> ConsultarUsingGET2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param>
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param>
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param>
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param>
        /// <returns>Task of PageAjusteResponse</returns>
        System.Threading.Tasks.Task<PageAjusteResponse> ListarUsingGET2Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);

        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{ajuste_financeiro_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param>
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param>
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param>
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAjusteResponse>> ListarUsingGET2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagajustefinanceiroApi : IGlobaltagajustefinanceiroApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagajustefinanceiroApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagajustefinanceiroApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagajustefinanceiroApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagajustefinanceiroApi(Configuration configuration = null)
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
        /// {{{ajuste_financeiro_resource_ajustar_conta}}} {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param> 
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param> 
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param> 
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param> 
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param> 
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse AjustarContaUsingPOST (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = AjustarContaUsingPOSTWithHttpInfo(idTipoAjuste, dataAjuste, valorAjuste, idConta, identificadorExterno, idTransacaoOriginal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}} {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param> 
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param> 
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param> 
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param> 
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param> 
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > AjustarContaUsingPOSTWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling GlobaltagajustefinanceiroApi->AjustarContaUsingPOST");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling GlobaltagajustefinanceiroApi->AjustarContaUsingPOST");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling GlobaltagajustefinanceiroApi->AjustarContaUsingPOST");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagajustefinanceiroApi->AjustarContaUsingPOST");
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}} {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param>
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param>
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaUsingPOSTAsync (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await AjustarContaUsingPOSTAsyncWithHttpInfo(idTipoAjuste, dataAjuste, valorAjuste, idConta, identificadorExterno, idTransacaoOriginal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{ajuste_financeiro_resource_ajustar_conta}}} {{{ajuste_financeiro_resource_ajustar_conta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">{{{ajuste_financeiro_persist_id_tipo_ajuste_value}}}</param>
        /// <param name="dataAjuste">{{{ajuste_financeiro_persist_data_ajuste_value}}}</param>
        /// <param name="valorAjuste">{{{ajuste_financeiro_persist_valor_ajuste_value}}}</param>
        /// <param name="idConta">{{{ajuste_financeiro_persist_id_conta_value}}}</param>
        /// <param name="identificadorExterno">{{{ajuste_financeiro_persist_identificador_externo_value}}} (optional)</param>
        /// <param name="idTransacaoOriginal">{{{ajuste_persist_id_transacao_original}}} (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaUsingPOSTAsyncWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string identificadorExterno = null, long? idTransacaoOriginal = null)
        {
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarContaUsingPOST");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarContaUsingPOST");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarContaUsingPOST");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AjustarContaUsingPOST");
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}} {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse ConsultarUsingGET2 (long? id)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = ConsultarUsingGET2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}} {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > ConsultarUsingGET2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagajustefinanceiroApi->ConsultarUsingGET2");
            
    
            var localVarPath = "/api/ajustes-financeiros/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}} {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> ConsultarUsingGET2Async (long? id)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await ConsultarUsingGET2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{ajuste_financeiro_resource_consultar}}} {{{ajuste_financeiro_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{ajuste_financeiro_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> ConsultarUsingGET2AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET2");
            
    
            var localVarPath = "/api/ajustes-financeiros/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}} {{{ajuste_financeiro_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param> 
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param> 
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param> 
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param> 
        /// <returns>PageAjusteResponse</returns>
        public PageAjusteResponse ListarUsingGET2 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
             ApiResponse<PageAjusteResponse> localVarResponse = ListarUsingGET2WithHttpInfo(sort, page, limit, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}} {{{ajuste_financeiro_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param> 
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param> 
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param> 
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param> 
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageAjusteResponse</returns>
        public ApiResponse< PageAjusteResponse > ListarUsingGET2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAjusteResponse)));
            
        }

        
        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}} {{{ajuste_financeiro_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param>
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param>
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param>
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param>
        /// <returns>Task of PageAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageAjusteResponse> ListarUsingGET2Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
             ApiResponse<PageAjusteResponse> localVarResponse = await ListarUsingGET2AsyncWithHttpInfo(sort, page, limit, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{ajuste_financeiro_resource_listar}}} {{{ajuste_financeiro_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAjuste">{{{ajuste_request_id_tipo_ajuste_value}}} (optional)</param>
        /// <param name="dataAjuste">{{{ajuste_request_data_ajuste_value}}} (optional)</param>
        /// <param name="valorAjuste">{{{ajuste_request_valor_ajuste_value}}} (optional)</param>
        /// <param name="identificadorExterno">{{{ajuste_request_identificador_externo_value}}} (optional)</param>
        /// <param name="idConta">{{{ajuste_request_id_conta_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAjusteResponse>> ListarUsingGET2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
            
    
            var localVarPath = "/api/ajustes-financeiros";
    
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
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAjusteResponse)));
            
        }
        
    }
    
}
