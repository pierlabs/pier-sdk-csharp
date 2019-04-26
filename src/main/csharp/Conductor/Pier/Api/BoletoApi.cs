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
    public interface IBoletoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Busca um boleto pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca um boleto pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse Consultar (long? id, bool? zeraValorCodigoBarras = null);
  
        /// <summary>
        /// Busca um boleto pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca um boleto pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> ConsultarWithHttpInfo (long? id, bool? zeraValorCodigoBarras = null);
        
        /// <summary>
        /// Envia um boleto por E-mail
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o envia um boleto por E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object EnviarBoletoEmail (long? id, BoletoEmailRequest request);
  
        /// <summary>
        /// Envia um boleto por E-mail
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o envia um boleto por E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarBoletoEmailWithHttpInfo (long? id, BoletoEmailRequest request);
        
        /// <summary>
        /// Gera um tipo de boleto
        /// </summary>
        /// <remarks>
        /// Este recurso gera um tipo de boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse GerarBoleto (BoletoRequest boletoRequest);
  
        /// <summary>
        /// Gera um tipo de boleto
        /// </summary>
        /// <remarks>
        /// Este recurso gera um tipo de boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> GerarBoletoWithHttpInfo (BoletoRequest boletoRequest);
        
        /// <summary>
        /// Lista os boletos especificados
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista os boletos especificados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Id da Conta (optional)</param>
        /// <param name="dataVencimento">Data de vencimento (optional)</param>
        /// <param name="valorBoleto">Valor do boleto (optional)</param>
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param>
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param>
        /// <param name="statusParcela">Status da parcela (optional)</param>
        /// <returns>PageBoletoListarResponse</returns>
        PageBoletoListarResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null);
  
        /// <summary>
        /// Lista os boletos especificados
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista os boletos especificados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Id da Conta (optional)</param>
        /// <param name="dataVencimento">Data de vencimento (optional)</param>
        /// <param name="valorBoleto">Valor do boleto (optional)</param>
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param>
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param>
        /// <param name="statusParcela">Status da parcela (optional)</param>
        /// <returns>ApiResponse of PageBoletoListarResponse</returns>
        ApiResponse<PageBoletoListarResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null);
        
        /// <summary>
        /// Listar hist\u00F3rico de status do boleto
        /// </summary>
        /// <remarks>
        /// Lista todos os status que um determinado boleto passou
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageStatusBoletoResponse</returns>
        PageStatusBoletoResponse ListarHistoricoStatusBoleto (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar hist\u00F3rico de status do boleto
        /// </summary>
        /// <remarks>
        /// Lista todos os status que um determinado boleto passou
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageStatusBoletoResponse</returns>
        ApiResponse<PageStatusBoletoResponse> ListarHistoricoStatusBoletoWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado
        /// </summary>
        /// <remarks>
        /// Este recurso registra uma cobranca emitido
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse RegistrarBoleto (long? id);
  
        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado
        /// </summary>
        /// <remarks>
        /// Este recurso registra uma cobranca emitido
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> RegistrarBoletoWithHttpInfo (long? id);
        
        /// <summary>
        /// Gera um pdf do boleto
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o gera um pdf do boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Object</returns>
        Object VisualizarBoleto (long? id);
  
        /// <summary>
        /// Gera um pdf do boleto
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o gera um pdf do boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarBoletoWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Busca um boleto pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca um boleto pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> ConsultarAsync (long? id, bool? zeraValorCodigoBarras = null);

        /// <summary>
        /// Busca um boleto pelo seu identificador
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o busca um boleto pelo seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarAsyncWithHttpInfo (long? id, bool? zeraValorCodigoBarras = null);
        
        /// <summary>
        /// Envia um boleto por E-mail
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o envia um boleto por E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarBoletoEmailAsync (long? id, BoletoEmailRequest request);

        /// <summary>
        /// Envia um boleto por E-mail
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o envia um boleto por E-mail
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarBoletoEmailAsyncWithHttpInfo (long? id, BoletoEmailRequest request);
        
        /// <summary>
        /// Gera um tipo de boleto
        /// </summary>
        /// <remarks>
        /// Este recurso gera um tipo de boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoAsync (BoletoRequest boletoRequest);

        /// <summary>
        /// Gera um tipo de boleto
        /// </summary>
        /// <remarks>
        /// Este recurso gera um tipo de boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoAsyncWithHttpInfo (BoletoRequest boletoRequest);
        
        /// <summary>
        /// Lista os boletos especificados
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista os boletos especificados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Id da Conta (optional)</param>
        /// <param name="dataVencimento">Data de vencimento (optional)</param>
        /// <param name="valorBoleto">Valor do boleto (optional)</param>
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param>
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param>
        /// <param name="statusParcela">Status da parcela (optional)</param>
        /// <returns>Task of PageBoletoListarResponse</returns>
        System.Threading.Tasks.Task<PageBoletoListarResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null);

        /// <summary>
        /// Lista os boletos especificados
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o lista os boletos especificados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Id da Conta (optional)</param>
        /// <param name="dataVencimento">Data de vencimento (optional)</param>
        /// <param name="valorBoleto">Valor do boleto (optional)</param>
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param>
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param>
        /// <param name="statusParcela">Status da parcela (optional)</param>
        /// <returns>Task of ApiResponse (PageBoletoListarResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBoletoListarResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null);
        
        /// <summary>
        /// Listar hist\u00F3rico de status do boleto
        /// </summary>
        /// <remarks>
        /// Lista todos os status que um determinado boleto passou
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageStatusBoletoResponse</returns>
        System.Threading.Tasks.Task<PageStatusBoletoResponse> ListarHistoricoStatusBoletoAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar hist\u00F3rico de status do boleto
        /// </summary>
        /// <remarks>
        /// Lista todos os status que um determinado boleto passou
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusBoletoResponse>> ListarHistoricoStatusBoletoAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado
        /// </summary>
        /// <remarks>
        /// Este recurso registra uma cobranca emitido
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> RegistrarBoletoAsync (long? id);

        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado
        /// </summary>
        /// <remarks>
        /// Este recurso registra uma cobranca emitido
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> RegistrarBoletoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Gera um pdf do boleto
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o gera um pdf do boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarBoletoAsync (long? id);

        /// <summary>
        /// Gera um pdf do boleto
        /// </summary>
        /// <remarks>
        /// Este servi\u00E7o gera um pdf do boleto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarBoletoAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BoletoApi : IBoletoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BoletoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BoletoApi(Configuration configuration = null)
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
        /// Busca um boleto pelo seu identificador Este servi\u00E7o busca um boleto pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse Consultar (long? id, bool? zeraValorCodigoBarras = null)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarWithHttpInfo(id, zeraValorCodigoBarras);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Busca um boleto pelo seu identificador Este servi\u00E7o busca um boleto pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > ConsultarWithHttpInfo (long? id, bool? zeraValorCodigoBarras = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BoletoApi->Consultar");
            
    
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
            
            if (zeraValorCodigoBarras != null) localVarQueryParams.Add("zeraValorCodigoBarras", Configuration.ApiClient.ParameterToString(zeraValorCodigoBarras)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Busca um boleto pelo seu identificador Este servi\u00E7o busca um boleto pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarAsync (long? id, bool? zeraValorCodigoBarras = null)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id, zeraValorCodigoBarras);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Busca um boleto pelo seu identificador Este servi\u00E7o busca um boleto pelo seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="zeraValorCodigoBarras">Indica se deve zerar o campo de valor do c\u00F3digo de barras (optional)</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarAsyncWithHttpInfo (long? id, bool? zeraValorCodigoBarras = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
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
            
            if (zeraValorCodigoBarras != null) localVarQueryParams.Add("zeraValorCodigoBarras", Configuration.ApiClient.ParameterToString(zeraValorCodigoBarras)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Envia um boleto por E-mail Este servi\u00E7o envia um boleto por E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object EnviarBoletoEmail (long? id, BoletoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = EnviarBoletoEmailWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Envia um boleto por E-mail Este servi\u00E7o envia um boleto por E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarBoletoEmailWithHttpInfo (long? id, BoletoEmailRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BoletoApi->EnviarBoletoEmail");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BoletoApi->EnviarBoletoEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Envia um boleto por E-mail Este servi\u00E7o envia um boleto por E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarBoletoEmailAsync (long? id, BoletoEmailRequest request)
        {
             ApiResponse<Object> localVarResponse = await EnviarBoletoEmailAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Envia um boleto por E-mail Este servi\u00E7o envia um boleto por E-mail
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarBoletoEmailAsyncWithHttpInfo (long? id, BoletoEmailRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarBoletoEmail");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling EnviarBoletoEmail");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarBoletoEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Gera um tipo de boleto Este recurso gera um tipo de boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse GerarBoleto (BoletoRequest boletoRequest)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoWithHttpInfo(boletoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gera um tipo de boleto Este recurso gera um tipo de boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > GerarBoletoWithHttpInfo (BoletoRequest boletoRequest)
        {
            
            // verify the required parameter 'boletoRequest' is set
            if (boletoRequest == null)
                throw new ApiException(400, "Missing required parameter 'boletoRequest' when calling BoletoApi->GerarBoleto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Gera um tipo de boleto Este recurso gera um tipo de boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoAsync (BoletoRequest boletoRequest)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoAsyncWithHttpInfo(boletoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gera um tipo de boleto Este recurso gera um tipo de boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="boletoRequest">boletoRequest</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoAsyncWithHttpInfo (BoletoRequest boletoRequest)
        {
            // verify the required parameter 'boletoRequest' is set
            if (boletoRequest == null) throw new ApiException(400, "Missing required parameter 'boletoRequest' when calling GerarBoleto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Lista os boletos especificados Este servi\u00E7o lista os boletos especificados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Id da Conta (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento (optional)</param> 
        /// <param name="valorBoleto">Valor do boleto (optional)</param> 
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param> 
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param> 
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param> 
        /// <param name="statusParcela">Status da parcela (optional)</param> 
        /// <returns>PageBoletoListarResponse</returns>
        public PageBoletoListarResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null)
        {
             ApiResponse<PageBoletoListarResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idConta, dataVencimento, valorBoleto, idTipoBoleto, nossoNumero, idEventoPagamento, statusParcela);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os boletos especificados Este servi\u00E7o lista os boletos especificados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Id da Conta (optional)</param> 
        /// <param name="dataVencimento">Data de vencimento (optional)</param> 
        /// <param name="valorBoleto">Valor do boleto (optional)</param> 
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param> 
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param> 
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param> 
        /// <param name="statusParcela">Status da parcela (optional)</param> 
        /// <returns>ApiResponse of PageBoletoListarResponse</returns>
        public ApiResponse< PageBoletoListarResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null)
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
            if (nossoNumero != null) localVarQueryParams.Add("nossoNumero", Configuration.ApiClient.ParameterToString(nossoNumero)); // query parameter
            if (idEventoPagamento != null) localVarQueryParams.Add("idEventoPagamento", Configuration.ApiClient.ParameterToString(idEventoPagamento)); // query parameter
            if (statusParcela != null) localVarQueryParams.Add("statusParcela", Configuration.ApiClient.ParameterToString(statusParcela)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBoletoListarResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBoletoListarResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBoletoListarResponse)));
            
        }

        
        /// <summary>
        /// Lista os boletos especificados Este servi\u00E7o lista os boletos especificados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Id da Conta (optional)</param>
        /// <param name="dataVencimento">Data de vencimento (optional)</param>
        /// <param name="valorBoleto">Valor do boleto (optional)</param>
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param>
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param>
        /// <param name="statusParcela">Status da parcela (optional)</param>
        /// <returns>Task of PageBoletoListarResponse</returns>
        public async System.Threading.Tasks.Task<PageBoletoListarResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null)
        {
             ApiResponse<PageBoletoListarResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idConta, dataVencimento, valorBoleto, idTipoBoleto, nossoNumero, idEventoPagamento, statusParcela);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os boletos especificados Este servi\u00E7o lista os boletos especificados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Id da Conta (optional)</param>
        /// <param name="dataVencimento">Data de vencimento (optional)</param>
        /// <param name="valorBoleto">Valor do boleto (optional)</param>
        /// <param name="idTipoBoleto">Tipo de boleto (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero (optional)</param>
        /// <param name="idEventoPagamento">Id do evento de pagamento (optional)</param>
        /// <param name="statusParcela">Status da parcela (optional)</param>
        /// <returns>Task of ApiResponse (PageBoletoListarResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBoletoListarResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataVencimento = null, double? valorBoleto = null, long? idTipoBoleto = null, long? nossoNumero = null, int? idEventoPagamento = null, int? statusParcela = null)
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
            if (nossoNumero != null) localVarQueryParams.Add("nossoNumero", Configuration.ApiClient.ParameterToString(nossoNumero)); // query parameter
            if (idEventoPagamento != null) localVarQueryParams.Add("idEventoPagamento", Configuration.ApiClient.ParameterToString(idEventoPagamento)); // query parameter
            if (statusParcela != null) localVarQueryParams.Add("statusParcela", Configuration.ApiClient.ParameterToString(statusParcela)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBoletoListarResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBoletoListarResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBoletoListarResponse)));
            
        }
        
        /// <summary>
        /// Listar hist\u00F3rico de status do boleto Lista todos os status que um determinado boleto passou
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageStatusBoletoResponse</returns>
        public PageStatusBoletoResponse ListarHistoricoStatusBoleto (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageStatusBoletoResponse> localVarResponse = ListarHistoricoStatusBoletoWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar hist\u00F3rico de status do boleto Lista todos os status que um determinado boleto passou
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageStatusBoletoResponse</returns>
        public ApiResponse< PageStatusBoletoResponse > ListarHistoricoStatusBoletoWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BoletoApi->ListarHistoricoStatusBoleto");
            
    
            var localVarPath = "/api/boletos/{id}/historicos";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoStatusBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoStatusBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusBoletoResponse)));
            
        }

        
        /// <summary>
        /// Listar hist\u00F3rico de status do boleto Lista todos os status que um determinado boleto passou
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageStatusBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusBoletoResponse> ListarHistoricoStatusBoletoAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageStatusBoletoResponse> localVarResponse = await ListarHistoricoStatusBoletoAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar hist\u00F3rico de status do boleto Lista todos os status que um determinado boleto passou
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do boleto</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusBoletoResponse>> ListarHistoricoStatusBoletoAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoStatusBoleto");
            
    
            var localVarPath = "/api/boletos/{id}/historicos";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoStatusBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoStatusBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusBoletoResponse)));
            
        }
        
        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado Este recurso registra uma cobranca emitido
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse RegistrarBoleto (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = RegistrarBoletoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado Este recurso registra uma cobranca emitido
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > RegistrarBoletoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BoletoApi->RegistrarBoleto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado Este recurso registra uma cobranca emitido
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> RegistrarBoletoAsync (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await RegistrarBoletoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registra uma cobranca na entidade banco relacionada a cobranca informado Este recurso registra uma cobranca emitido
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> RegistrarBoletoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RegistrarBoleto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RegistrarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Gera um pdf do boleto Este servi\u00E7o gera um pdf do boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <returns>Object</returns>
        public Object VisualizarBoleto (long? id)
        {
             ApiResponse<Object> localVarResponse = VisualizarBoletoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gera um pdf do boleto Este servi\u00E7o gera um pdf do boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarBoletoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BoletoApi->VisualizarBoleto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Gera um pdf do boleto Este servi\u00E7o gera um pdf do boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarBoletoAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await VisualizarBoletoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gera um pdf do boleto Este servi\u00E7o gera um pdf do boleto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Cobranca (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarBoletoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarBoleto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
