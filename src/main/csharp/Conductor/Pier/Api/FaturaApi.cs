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
    public interface IFaturaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>FaturaDetalheResponse</returns>
        FaturaDetalheResponse ConsultarFaturaUsingGET1 (string dataVencimento, long? idConta);
  
        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>ApiResponse of FaturaDetalheResponse</returns>
        ApiResponse<FaturaDetalheResponse> ConsultarFaturaUsingGET1WithHttpInfo (string dataVencimento, long? idConta);
        
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PagePlanoParcelamentoResponse</returns>
        PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFaturaUsingGET1 (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        ApiResponse<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaUsingGET1WithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Object</returns>
        Object EnviarFaturaEmailUsingPOST (long? id, string dataVencimento, string email = null);
  
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarFaturaEmailUsingPOSTWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// Listar faturas de um cliente.
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageFaturaResponse</returns>
        PageFaturaResponse ListarFaturasUsingGET1 (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar faturas de um cliente.
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageFaturaResponse</returns>
        ApiResponse<PageFaturaResponse> ListarFaturasUsingGET1WithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Object</returns>
        Object VisualizarDocumentoUsingGET (long? id, string dataVencimento);
  
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarDocumentoUsingGETWithHttpInfo (long? id, string dataVencimento);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of FaturaDetalheResponse</returns>
        System.Threading.Tasks.Task<FaturaDetalheResponse> ConsultarFaturaUsingGET1Async (string dataVencimento, long? idConta);

        /// <summary>
        /// Consulta fatura de um cliente
        /// </summary>
        /// <remarks>
        /// Consulta fatura de um cliente pela data de vencimento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of ApiResponse (FaturaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaturaDetalheResponse>> ConsultarFaturaUsingGET1AsyncWithHttpInfo (string dataVencimento, long? idConta);
        
        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaUsingGET1Async (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar planos de parcelamento
        /// </summary>
        /// <remarks>
        /// Lista os planos de parcelamento da fatura de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaUsingGET1AsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarFaturaEmailUsingPOSTAsync (long? id, string dataVencimento, string email = null);

        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// Listar faturas de um cliente.
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageFaturaResponse</returns>
        System.Threading.Tasks.Task<PageFaturaResponse> ListarFaturasUsingGET1Async (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar faturas de um cliente.
        /// </summary>
        /// <remarks>
        /// Lista faturas de um cliente.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturaResponse>> ListarFaturasUsingGET1AsyncWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarDocumentoUsingGETAsync (long? id, string dataVencimento);

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoUsingGETAsyncWithHttpInfo (long? id, string dataVencimento);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FaturaApi : IFaturaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FaturaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FaturaApi(Configuration configuration = null)
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
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <returns>FaturaDetalheResponse</returns>
        public FaturaDetalheResponse ConsultarFaturaUsingGET1 (string dataVencimento, long? idConta)
        {
             ApiResponse<FaturaDetalheResponse> localVarResponse = ConsultarFaturaUsingGET1WithHttpInfo(dataVencimento, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <returns>ApiResponse of FaturaDetalheResponse</returns>
        public ApiResponse< FaturaDetalheResponse > ConsultarFaturaUsingGET1WithHttpInfo (string dataVencimento, long? idConta)
        {
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling FaturaApi->ConsultarFaturaUsingGET1");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling FaturaApi->ConsultarFaturaUsingGET1");
            
    
            var localVarPath = "/api/faturas/{dataVencimento}";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaturaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of FaturaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<FaturaDetalheResponse> ConsultarFaturaUsingGET1Async (string dataVencimento, long? idConta)
        {
             ApiResponse<FaturaDetalheResponse> localVarResponse = await ConsultarFaturaUsingGET1AsyncWithHttpInfo(dataVencimento, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta fatura de um cliente Consulta fatura de um cliente pela data de vencimento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Data Vencimento</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of ApiResponse (FaturaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaturaDetalheResponse>> ConsultarFaturaUsingGET1AsyncWithHttpInfo (string dataVencimento, long? idConta)
        {
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarFaturaUsingGET1");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarFaturaUsingGET1");
            
    
            var localVarPath = "/api/faturas/{dataVencimento}";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFaturaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaturaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PagePlanoParcelamentoResponse</returns>
        public PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFaturaUsingGET1 (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = ConsultarLancamentosFuturosFaturaUsingGET1WithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        public ApiResponse< PagePlanoParcelamentoResponse > ConsultarLancamentosFuturosFaturaUsingGET1WithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->ConsultarLancamentosFuturosFaturaUsingGET1");
            
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling FaturaApi->ConsultarLancamentosFuturosFaturaUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }

        
        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        public async System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaUsingGET1Async (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = await ConsultarLancamentosFuturosFaturaUsingGET1AsyncWithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar planos de parcelamento Lista os planos de parcelamento da fatura de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimentoPadrao">Indica a data de vencimento padr\u00E3o das faturas</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaUsingGET1AsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLancamentosFuturosFaturaUsingGET1");
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null) throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling ConsultarLancamentosFuturosFaturaUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFaturaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }
        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param> 
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param> 
        /// <returns>Object</returns>
        public Object EnviarFaturaEmailUsingPOST (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = EnviarFaturaEmailUsingPOSTWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param> 
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarFaturaEmailUsingPOSTWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->EnviarFaturaEmailUsingPOST");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling FaturaApi->EnviarFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/enviar-email";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarFaturaEmailUsingPOSTAsync (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = await EnviarFaturaEmailUsingPOSTAsyncWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Envia 2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura (yyyy-MM-dd).</param>
        /// <param name="email">E-mail para envio da 2\u00AA via da fatura, caso n\u00E3o seja informado ser\u00E1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarFaturaEmailUsingPOST");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling EnviarFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/enviar-email";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar faturas de um cliente. Lista faturas de um cliente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageFaturaResponse</returns>
        public PageFaturaResponse ListarFaturasUsingGET1 (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaResponse> localVarResponse = ListarFaturasUsingGET1WithHttpInfo(idConta, situacaoProcessamento, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar faturas de um cliente. Lista faturas de um cliente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageFaturaResponse</returns>
        public ApiResponse< PageFaturaResponse > ListarFaturasUsingGET1WithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling FaturaApi->ListarFaturasUsingGET1");
            
    
            var localVarPath = "/api/faturas";
    
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
            if (situacaoProcessamento != null) localVarQueryParams.Add("situacaoProcessamento", Configuration.ApiClient.ParameterToString(situacaoProcessamento)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaResponse)));
            
        }

        
        /// <summary>
        /// Listar faturas de um cliente. Lista faturas de um cliente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageFaturaResponse> ListarFaturasUsingGET1Async (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaResponse> localVarResponse = await ListarFaturasUsingGET1AsyncWithHttpInfo(idConta, situacaoProcessamento, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar faturas de um cliente. Lista faturas de um cliente.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="situacaoProcessamento">Status do processamento das faturas. Valores possiveis [ABERTA, FECHADA, TODAS]. (optional, default to TODAS)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturaResponse>> ListarFaturasUsingGET1AsyncWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarFaturasUsingGET1");
            
    
            var localVarPath = "/api/faturas";
    
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
            if (situacaoProcessamento != null) localVarQueryParams.Add("situacaoProcessamento", Configuration.ApiClient.ParameterToString(situacaoProcessamento)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturasUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaResponse)));
            
        }
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param> 
        /// <returns>Object</returns>
        public Object VisualizarDocumentoUsingGET (long? id, string dataVencimento)
        {
             ApiResponse<Object> localVarResponse = VisualizarDocumentoUsingGETWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarDocumentoUsingGETWithHttpInfo (long? id, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturaApi->VisualizarDocumentoUsingGET");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling FaturaApi->VisualizarDocumentoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/arquivo.pdf";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarDocumentoUsingGETAsync (long? id, string dataVencimento)
        {
             ApiResponse<Object> localVarResponse = await VisualizarDocumentoUsingGETAsyncWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00E7\u00E3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00EAs corrente, o pdf ser\u00E1 composto pelo extrato de lan\u00E7amentos e pela ficha de compensa\u00E7\u00E3o banc\u00E1ria. Quando for de uma fatura do hist\u00F3rico do cliente, o PDF ser\u00E1 composto apenas pelo extrato de transa\u00E7\u00F5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoUsingGETAsyncWithHttpInfo (long? id, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarDocumentoUsingGET");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling VisualizarDocumentoUsingGET");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/arquivo.pdf";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
