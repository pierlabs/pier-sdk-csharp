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
    public interface IAjusteFinanceiroApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse ConsultarAjusteFinanceiro (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> ConsultarAjusteFinanceiroWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Valor do ajuste (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param>
        /// <returns>PageAjusteResponse</returns>
        PageAjusteResponse ListarAjustesFinanceiros (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
  
        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Valor do ajuste (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param>
        /// <returns>ApiResponse of PageAjusteResponse</returns>
        ApiResponse<PageAjusteResponse> ListarAjustesFinanceirosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
        
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="idConta">C\u00F3digo identificador da conta</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param>
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse SalvarAjusteFinanceiro (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null);
  
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="idConta">C\u00F3digo identificador da conta</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param>
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> SalvarAjusteFinanceiroWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> ConsultarAjusteFinanceiroAsync (long? id);

        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> ConsultarAjusteFinanceiroAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Valor do ajuste (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param>
        /// <returns>Task of PageAjusteResponse</returns>
        System.Threading.Tasks.Task<PageAjusteResponse> ListarAjustesFinanceirosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);

        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Valor do ajuste (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param>
        /// <returns>Task of ApiResponse (PageAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAjusteResponse>> ListarAjustesFinanceirosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null);
        
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="idConta">C\u00F3digo identificador da conta</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param>
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> SalvarAjusteFinanceiroAsync (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null);

        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada
        /// </summary>
        /// <remarks>
        /// Este recurso insere um ajuste para a conta do id informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="idConta">C\u00F3digo identificador da conta</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param>
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> SalvarAjusteFinanceiroAsyncWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AjusteFinanceiroApi : IAjusteFinanceiroApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AjusteFinanceiroApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AjusteFinanceiroApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AjusteFinanceiroApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AjusteFinanceiroApi(Configuration configuration = null)
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
        /// Apresenta dados de um determinado ajuste financeiro Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse ConsultarAjusteFinanceiro (long? id)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = ConsultarAjusteFinanceiroWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > ConsultarAjusteFinanceiroWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AjusteFinanceiroApi->ConsultarAjusteFinanceiro");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAjusteFinanceiro: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAjusteFinanceiro: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> ConsultarAjusteFinanceiroAsync (long? id)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await ConsultarAjusteFinanceiroAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado ajuste financeiro Este m\u00E9todo permite consultar dados de um determinado ajuste a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do ajuste (id)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> ConsultarAjusteFinanceiroAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarAjusteFinanceiro");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAjusteFinanceiro: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAjusteFinanceiro: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param> 
        /// <param name="valorAjuste">Valor do ajuste (optional)</param> 
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param> 
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param> 
        /// <returns>PageAjusteResponse</returns>
        public PageAjusteResponse ListarAjustesFinanceiros (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
             ApiResponse<PageAjusteResponse> localVarResponse = ListarAjustesFinanceirosWithHttpInfo(sort, page, limit, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param> 
        /// <param name="valorAjuste">Valor do ajuste (optional)</param> 
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param> 
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param> 
        /// <returns>ApiResponse of PageAjusteResponse</returns>
        public ApiResponse< PageAjusteResponse > ListarAjustesFinanceirosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAjustesFinanceiros: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAjustesFinanceiros: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAjusteResponse)));
            
        }

        
        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Valor do ajuste (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param>
        /// <returns>Task of PageAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageAjusteResponse> ListarAjustesFinanceirosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
        {
             ApiResponse<PageAjusteResponse> localVarResponse = await ListarAjustesFinanceirosAsyncWithHttpInfo(sort, page, limit, idTipoAjuste, dataAjuste, valorAjuste, identificadorExterno, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista ajustes existentes na base de dados do Emissor Este recurso permite listar ajustes existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (optional)</param>
        /// <param name="valorAjuste">Valor do ajuste (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idConta">C\u00F3digo identificador da conta (optional)</param>
        /// <returns>Task of ApiResponse (PageAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAjusteResponse>> ListarAjustesFinanceirosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAjuste = null, string dataAjuste = null, double? valorAjuste = null, string identificadorExterno = null, long? idConta = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAjustesFinanceiros: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAjustesFinanceiros: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAjusteResponse)));
            
        }
        
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="idConta">C\u00F3digo identificador da conta</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param> 
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param> 
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param> 
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse SalvarAjusteFinanceiro (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = SalvarAjusteFinanceiroWithHttpInfo(idTipoAjuste, dataAjuste, valorAjuste, idConta, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento, flagAtendimento, mensagemAtendimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param> 
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Valor do ajuste</param> 
        /// <param name="idConta">C\u00F3digo identificador da conta</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param> 
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param> 
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param> 
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > SalvarAjusteFinanceiroWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null)
        {
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjusteFinanceiroApi->SalvarAjusteFinanceiro");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjusteFinanceiroApi->SalvarAjusteFinanceiro");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjusteFinanceiroApi->SalvarAjusteFinanceiro");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AjusteFinanceiroApi->SalvarAjusteFinanceiro");
            
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (flagAtendimento != null) localVarQueryParams.Add("flagAtendimento", Configuration.ApiClient.ParameterToString(flagAtendimento)); // query parameter
            if (mensagemAtendimento != null) localVarQueryParams.Add("mensagemAtendimento", Configuration.ApiClient.ParameterToString(mensagemAtendimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAjusteFinanceiro: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAjusteFinanceiro: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="idConta">C\u00F3digo identificador da conta</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param>
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> SalvarAjusteFinanceiroAsync (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await SalvarAjusteFinanceiroAsyncWithHttpInfo(idTipoAjuste, dataAjuste, valorAjuste, idConta, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento, flagAtendimento, mensagemAtendimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lan\u00E7a um ajuste para a conta informada Este recurso insere um ajuste para a conta do id informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoAjuste">C\u00F3digo identificador do tipo de ajuste</param>
        /// <param name="dataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Valor do ajuste</param>
        /// <param name="idConta">C\u00F3digo identificador da conta</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Codigo Hexadecimal (optional)</param>
        /// <param name="idTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno) (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja (optional)</param>
        /// <param name="flagAtendimento">Flag para lan\u00E7ar o atendimento (optional)</param>
        /// <param name="mensagemAtendimento">Mensagem enviada no atendimento (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> SalvarAjusteFinanceiroAsyncWithHttpInfo (long? idTipoAjuste, string dataAjuste, double? valorAjuste, long? idConta, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null, bool? flagAtendimento = null, string mensagemAtendimento = null)
        {
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling SalvarAjusteFinanceiro");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling SalvarAjusteFinanceiro");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling SalvarAjusteFinanceiro");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SalvarAjusteFinanceiro");
            
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (flagAtendimento != null) localVarQueryParams.Add("flagAtendimento", Configuration.ApiClient.ParameterToString(flagAtendimento)); // query parameter
            if (mensagemAtendimento != null) localVarQueryParams.Add("mensagemAtendimento", Configuration.ApiClient.ParameterToString(mensagemAtendimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAjusteFinanceiro: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAjusteFinanceiro: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
    }
    
}
