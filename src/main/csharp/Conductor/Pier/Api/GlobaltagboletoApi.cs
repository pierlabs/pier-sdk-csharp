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
    public interface IGlobaltagboletoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param>
        /// <returns>BoletoResponse</returns>
<<<<<<< HEAD
        BoletoResponse ConsultarUsingGET33 (long? id);
=======
        BoletoResponse ConsultarUsingGET34 (long? id);
>>>>>>> v2.68.0
  
        /// <summary>
        /// {{{boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
<<<<<<< HEAD
        ApiResponse<BoletoResponse> ConsultarUsingGET33WithHttpInfo (long? id);
=======
        ApiResponse<BoletoResponse> ConsultarUsingGET34WithHttpInfo (long? id);
>>>>>>> v2.68.0
        
        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object EnviarBoletoEmailUsingPOST (long? id, BoletoEmailRequest request);
  
        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarBoletoEmailUsingPOSTWithHttpInfo (long? id, BoletoEmailRequest request);
        
        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_gerar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse GerarBoletoUsingPOST (BoletoRequest boletoRequest);
  
        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_gerar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> GerarBoletoUsingPOSTWithHttpInfo (BoletoRequest boletoRequest);
        
        /// <summary>
        /// {{{boleto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param>
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param>
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param>
        /// <returns>PageBoletoListarResponse</returns>
        PageBoletoListarResponse ListarUsingGET45 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null);
  
        /// <summary>
        /// {{{boleto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param>
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param>
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param>
        /// <returns>ApiResponse of PageBoletoListarResponse</returns>
        ApiResponse<PageBoletoListarResponse> ListarUsingGET45WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null);
        
        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse RegistrarBoletoUsingPOST (long? id);
  
        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> RegistrarBoletoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_visualizar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param>
        /// <returns>Object</returns>
        Object VisualizarBoletoUsingGET (long? id);
  
        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_visualizar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarBoletoUsingGETWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param>
        /// <returns>Task of BoletoResponse</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<BoletoResponse> ConsultarUsingGET33Async (long? id);
=======
        System.Threading.Tasks.Task<BoletoResponse> ConsultarUsingGET34Async (long? id);
>>>>>>> v2.68.0

        /// <summary>
        /// {{{boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarUsingGET33AsyncWithHttpInfo (long? id);
=======
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarUsingGET34AsyncWithHttpInfo (long? id);
>>>>>>> v2.68.0
        
        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarBoletoEmailUsingPOSTAsync (long? id, BoletoEmailRequest request);

        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarBoletoEmailUsingPOSTAsyncWithHttpInfo (long? id, BoletoEmailRequest request);
        
        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_gerar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoUsingPOSTAsync (BoletoRequest boletoRequest);

        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_gerar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoUsingPOSTAsyncWithHttpInfo (BoletoRequest boletoRequest);
        
        /// <summary>
        /// {{{boleto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param>
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param>
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param>
        /// <returns>Task of PageBoletoListarResponse</returns>
        System.Threading.Tasks.Task<PageBoletoListarResponse> ListarUsingGET45Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null);

        /// <summary>
        /// {{{boleto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param>
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param>
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageBoletoListarResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBoletoListarResponse>> ListarUsingGET45AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null);
        
        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> RegistrarBoletoUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> RegistrarBoletoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_visualizar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarBoletoUsingGETAsync (long? id);

        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}}
        /// </summary>
        /// <remarks>
        /// {{{boleto_resource_visualizar_boleto_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarBoletoUsingGETAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagboletoApi : IGlobaltagboletoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagboletoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagboletoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagboletoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagboletoApi(Configuration configuration = null)
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
        /// {{{boleto_resource_consultar}}} {{{boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param> 
        /// <returns>BoletoResponse</returns>
<<<<<<< HEAD
        public BoletoResponse ConsultarUsingGET33 (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarUsingGET33WithHttpInfo(id);
=======
        public BoletoResponse ConsultarUsingGET34 (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarUsingGET34WithHttpInfo(id);
>>>>>>> v2.68.0
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{boleto_resource_consultar}}} {{{boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
<<<<<<< HEAD
        public ApiResponse< BoletoResponse > ConsultarUsingGET33WithHttpInfo (long? id)
=======
        public ApiResponse< BoletoResponse > ConsultarUsingGET34WithHttpInfo (long? id)
>>>>>>> v2.68.0
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagboletoApi->ConsultarUsingGET33");
=======
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagboletoApi->ConsultarUsingGET34");
>>>>>>> v2.68.0
            
    
            var localVarPath = "/api/boletos/{id}";
    
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> v2.68.0
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{boleto_resource_consultar}}} {{{boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param>
        /// <returns>Task of BoletoResponse</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarUsingGET33Async (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarUsingGET33AsyncWithHttpInfo(id);
=======
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarUsingGET34Async (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarUsingGET34AsyncWithHttpInfo(id);
>>>>>>> v2.68.0
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{boleto_resource_consultar}}} {{{boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarUsingGET33AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET33");
=======
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarUsingGET34AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET34");
>>>>>>> v2.68.0
            
    
            var localVarPath = "/api/boletos/{id}";
    
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> v2.68.0

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}} {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param> 
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object EnviarBoletoEmailUsingPOST (long? id, BoletoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = EnviarBoletoEmailUsingPOSTWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}} {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarBoletoEmailUsingPOSTWithHttpInfo (long? id, BoletoEmailRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagboletoApi->EnviarBoletoEmailUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagboletoApi->EnviarBoletoEmailUsingPOST");
            
    
            var localVarPath = "/api/boletos/{id}/enviar-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}} {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarBoletoEmailUsingPOSTAsync (long? id, BoletoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = await EnviarBoletoEmailUsingPOSTAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{boleto_resource_enviar_boleto_email}}} {{{boleto_resource_enviar_boleto_email_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_enviar_boleto_param_id}}}</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarBoletoEmailUsingPOSTAsyncWithHttpInfo (long? id, BoletoEmailRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarBoletoEmailUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling EnviarBoletoEmailUsingPOST");
            
    
            var localVarPath = "/api/boletos/{id}/enviar-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}} {{{boleto_resource_gerar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse GerarBoletoUsingPOST (BoletoRequest boletoRequest)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoUsingPOSTWithHttpInfo(boletoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}} {{{boleto_resource_gerar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > GerarBoletoUsingPOSTWithHttpInfo (BoletoRequest boletoRequest)
        {
            
            // verify the required parameter 'boletoRequest' is set
            if (boletoRequest == null)
                throw new ApiException(400, "Missing required parameter 'boletoRequest' when calling GlobaltagboletoApi->GerarBoletoUsingPOST");
            
    
            var localVarPath = "/api/boletos";
    
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
            
            
            
            
            if (boletoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(boletoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = boletoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}} {{{boleto_resource_gerar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoUsingPOSTAsync (BoletoRequest boletoRequest)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoUsingPOSTAsyncWithHttpInfo(boletoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{boleto_resource_gerar_boleto}}} {{{boleto_resource_gerar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoUsingPOSTAsyncWithHttpInfo (BoletoRequest boletoRequest)
        {
            // verify the required parameter 'boletoRequest' is set
            if (boletoRequest == null) throw new ApiException(400, "Missing required parameter 'boletoRequest' when calling GerarBoletoUsingPOST");
            
    
            var localVarPath = "/api/boletos";
    
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
            
            
            
            
            if (boletoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(boletoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = boletoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{boleto_resource_listar}}} {{{boleto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param> 
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param> 
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param> 
        /// <returns>PageBoletoListarResponse</returns>
        public PageBoletoListarResponse ListarUsingGET45 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null)
        {
             ApiResponse<PageBoletoListarResponse> localVarResponse = ListarUsingGET45WithHttpInfo(sort, page, limit, idConta, dataVencimento, valorBoleto, idTipoBoleto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{boleto_resource_listar}}} {{{boleto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param> 
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param> 
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageBoletoListarResponse</returns>
        public ApiResponse< PageBoletoListarResponse > ListarUsingGET45WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null)
        {
            
    
            var localVarPath = "/api/boletos";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (valorBoleto != null) localVarQueryParams.Add("valorBoleto", Configuration.ApiClient.ParameterToString(valorBoleto)); // query parameter
            if (idTipoBoleto != null) localVarQueryParams.Add("idTipoBoleto", Configuration.ApiClient.ParameterToString(idTipoBoleto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBoletoListarResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBoletoListarResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBoletoListarResponse)));
            
        }

        
        /// <summary>
        /// {{{boleto_resource_listar}}} {{{boleto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param>
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param>
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param>
        /// <returns>Task of PageBoletoListarResponse</returns>
        public async System.Threading.Tasks.Task<PageBoletoListarResponse> ListarUsingGET45Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null)
        {
             ApiResponse<PageBoletoListarResponse> localVarResponse = await ListarUsingGET45AsyncWithHttpInfo(sort, page, limit, idConta, dataVencimento, valorBoleto, idTipoBoleto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{boleto_resource_listar}}} {{{boleto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{boleto_listar_request_id_conta_value}}} (optional)</param>
        /// <param name="dataVencimento">{{{boleto_listar_request_data_vencimento_value}}} (optional)</param>
        /// <param name="valorBoleto">{{{boleto_listar_request_valor_value}}} (optional)</param>
        /// <param name="idTipoBoleto">{{{boleto_listar_request_id_tipo_boleto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageBoletoListarResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBoletoListarResponse>> ListarUsingGET45AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null)
        {
            
    
            var localVarPath = "/api/boletos";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (valorBoleto != null) localVarQueryParams.Add("valorBoleto", Configuration.ApiClient.ParameterToString(valorBoleto)); // query parameter
            if (idTipoBoleto != null) localVarQueryParams.Add("idTipoBoleto", Configuration.ApiClient.ParameterToString(idTipoBoleto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET45: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBoletoListarResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBoletoListarResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBoletoListarResponse)));
            
        }
        
        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}} {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse RegistrarBoletoUsingPOST (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = RegistrarBoletoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}} {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > RegistrarBoletoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagboletoApi->RegistrarBoletoUsingPOST");
            
    
            var localVarPath = "/api/boletos/{id}/registrar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoletoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoletoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}} {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> RegistrarBoletoUsingPOSTAsync (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await RegistrarBoletoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{registro_cobranca_resource_registrar_boleto}}} {{{registro_cobranca_resource_registrar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{registro_cobranca_resource_registrar_boleto_param_id_boleto}}}</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> RegistrarBoletoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RegistrarBoletoUsingPOST");
            
    
            var localVarPath = "/api/boletos/{id}/registrar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoletoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoletoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}} {{{boleto_resource_visualizar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param> 
        /// <returns>Object</returns>
        public Object VisualizarBoletoUsingGET (long? id)
        {
             ApiResponse<Object> localVarResponse = VisualizarBoletoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}} {{{boleto_resource_visualizar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarBoletoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagboletoApi->VisualizarBoletoUsingGET");
            
    
            var localVarPath = "/api/boletos/{id}/arquivo.pdf";
    
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
                "application/pdf"
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
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}} {{{boleto_resource_visualizar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarBoletoUsingGETAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await VisualizarBoletoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{boleto_resource_visualizar_boleto}}} {{{boleto_resource_visualizar_boleto_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{boleto_resource_visualizar_boleto_param_id}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarBoletoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarBoletoUsingGET");
            
    
            var localVarPath = "/api/boletos/{id}/arquivo.pdf";
    
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
                "application/pdf"
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
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
