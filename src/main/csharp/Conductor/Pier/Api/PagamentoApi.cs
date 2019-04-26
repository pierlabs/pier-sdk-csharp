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
    public interface IPagamentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consultar pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param>
        /// <returns>PagamentosInvalidosResponse</returns>
        PagamentosInvalidosResponse ConsultarPagamentoInvalido (long? id);
  
        /// <summary>
        /// Consultar pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param>
        /// <returns>ApiResponse of PagamentosInvalidosResponse</returns>
        ApiResponse<PagamentosInvalidosResponse> ConsultarPagamentoInvalidoWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista hist\u00F3rico de pagamentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param>
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param>
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param>
        /// <returns>PageHistoricoPagamentoResponse</returns>
        PageHistoricoPagamentoResponse ListarPagamentos (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null);
  
        /// <summary>
        /// Lista hist\u00F3rico de pagamentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param>
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param>
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param>
        /// <returns>ApiResponse of PageHistoricoPagamentoResponse</returns>
        ApiResponse<PageHistoricoPagamentoResponse> ListarPagamentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null);
        
        /// <summary>
        /// Listar pagamentos inv\u00E1lidos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param>
        /// <param name="valorPago">Valor pago da fatura (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param>
        /// <returns>PagePagamentosInvalidosResponse</returns>
        PagePagamentosInvalidosResponse ListarPagamentosInvalidos (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null);
  
        /// <summary>
        /// Listar pagamentos inv\u00E1lidos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param>
        /// <param name="valorPago">Valor pago da fatura (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param>
        /// <returns>ApiResponse of PagePagamentosInvalidosResponse</returns>
        ApiResponse<PagePagamentosInvalidosResponse> ListarPagamentosInvalidosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null);
        
        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="persistDto">persistDto</param>
        /// <returns>RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido</returns>
        RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido Regularizar (long? id, RegularizacaoPagamentoPersist persistDto);
  
        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="persistDto">persistDto</param>
        /// <returns>ApiResponse of RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido</returns>
        ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido> RegularizarWithHttpInfo (long? id, RegularizacaoPagamentoPersist persistDto);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consultar pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param>
        /// <returns>Task of PagamentosInvalidosResponse</returns>
        System.Threading.Tasks.Task<PagamentosInvalidosResponse> ConsultarPagamentoInvalidoAsync (long? id);

        /// <summary>
        /// Consultar pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param>
        /// <returns>Task of ApiResponse (PagamentosInvalidosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagamentosInvalidosResponse>> ConsultarPagamentoInvalidoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista hist\u00F3rico de pagamentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param>
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param>
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param>
        /// <returns>Task of PageHistoricoPagamentoResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoPagamentoResponse> ListarPagamentosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null);

        /// <summary>
        /// Lista hist\u00F3rico de pagamentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param>
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param>
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoPagamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoPagamentoResponse>> ListarPagamentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null);
        
        /// <summary>
        /// Listar pagamentos inv\u00E1lidos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param>
        /// <param name="valorPago">Valor pago da fatura (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param>
        /// <returns>Task of PagePagamentosInvalidosResponse</returns>
        System.Threading.Tasks.Task<PagePagamentosInvalidosResponse> ListarPagamentosInvalidosAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null);

        /// <summary>
        /// Listar pagamentos inv\u00E1lidos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param>
        /// <param name="valorPago">Valor pago da fatura (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param>
        /// <returns>Task of ApiResponse (PagePagamentosInvalidosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePagamentosInvalidosResponse>> ListarPagamentosInvalidosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null);
        
        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="persistDto">persistDto</param>
        /// <returns>Task of RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido</returns>
        System.Threading.Tasks.Task<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido> RegularizarAsync (long? id, RegularizacaoPagamentoPersist persistDto);

        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido
        /// </summary>
        /// <remarks>
        /// Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="persistDto">persistDto</param>
        /// <returns>Task of ApiResponse (RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido)</returns>
        System.Threading.Tasks.Task<ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido>> RegularizarAsyncWithHttpInfo (long? id, RegularizacaoPagamentoPersist persistDto);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PagamentoApi : IPagamentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagamentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PagamentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PagamentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PagamentoApi(Configuration configuration = null)
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
        /// Consultar pagamento inv\u00E1lido Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param> 
        /// <returns>PagamentosInvalidosResponse</returns>
        public PagamentosInvalidosResponse ConsultarPagamentoInvalido (long? id)
        {
             ApiResponse<PagamentosInvalidosResponse> localVarResponse = ConsultarPagamentoInvalidoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar pagamento inv\u00E1lido Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param> 
        /// <returns>ApiResponse of PagamentosInvalidosResponse</returns>
        public ApiResponse< PagamentosInvalidosResponse > ConsultarPagamentoInvalidoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PagamentoApi->ConsultarPagamentoInvalido");
            
    
            var localVarPath = "/api/pagamentos-invalidos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPagamentoInvalido: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPagamentoInvalido: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagamentosInvalidosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagamentosInvalidosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagamentosInvalidosResponse)));
            
        }

        
        /// <summary>
        /// Consultar pagamento inv\u00E1lido Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param>
        /// <returns>Task of PagamentosInvalidosResponse</returns>
        public async System.Threading.Tasks.Task<PagamentosInvalidosResponse> ConsultarPagamentoInvalidoAsync (long? id)
        {
             ApiResponse<PagamentosInvalidosResponse> localVarResponse = await ConsultarPagamentoInvalidoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar pagamento inv\u00E1lido Esse recurso permite consultar um pagamento inv\u00E1lido a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do pagamento inv\u00E1lido</param>
        /// <returns>Task of ApiResponse (PagamentosInvalidosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagamentosInvalidosResponse>> ConsultarPagamentoInvalidoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPagamentoInvalido");
            
    
            var localVarPath = "/api/pagamentos-invalidos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPagamentoInvalido: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPagamentoInvalido: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagamentosInvalidosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagamentosInvalidosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagamentosInvalidosResponse)));
            
        }
        
        /// <summary>
        /// Lista hist\u00F3rico de pagamentos Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param> 
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param> 
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param> 
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param> 
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param> 
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param> 
        /// <returns>PageHistoricoPagamentoResponse</returns>
        public PageHistoricoPagamentoResponse ListarPagamentos (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null)
        {
             ApiResponse<PageHistoricoPagamentoResponse> localVarResponse = ListarPagamentosWithHttpInfo(sort, page, limit, idConta, idPagamento, idEstabelecimento, idBanco, idCartao, dataHoraPagamento, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista hist\u00F3rico de pagamentos Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param> 
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param> 
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param> 
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param> 
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param> 
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoPagamentoResponse</returns>
        public ApiResponse< PageHistoricoPagamentoResponse > ListarPagamentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null)
        {
            
    
            var localVarPath = "/api/pagamentos";
    
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
            if (idPagamento != null) localVarQueryParams.Add("idPagamento", Configuration.ApiClient.ParameterToString(idPagamento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idBanco != null) localVarQueryParams.Add("idBanco", Configuration.ApiClient.ParameterToString(idBanco)); // query parameter
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (dataHoraPagamento != null) localVarQueryParams.Add("dataHoraPagamento", Configuration.ApiClient.ParameterToString(dataHoraPagamento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoPagamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoPagamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoPagamentoResponse)));
            
        }

        
        /// <summary>
        /// Lista hist\u00F3rico de pagamentos Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param>
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param>
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param>
        /// <returns>Task of PageHistoricoPagamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoPagamentoResponse> ListarPagamentosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null)
        {
             ApiResponse<PageHistoricoPagamentoResponse> localVarResponse = await ListarPagamentosAsyncWithHttpInfo(sort, page, limit, idConta, idPagamento, idEstabelecimento, idBanco, idCartao, dataHoraPagamento, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista hist\u00F3rico de pagamentos Este recurso permite listar todos os Pagamentos realizados independente do seu Status de Processamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="idPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento (optional)</param>
        /// <param name="idCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (optional)</param>
        /// <param name="dataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero (optional)</param>
        /// <param name="status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoPagamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoPagamentoResponse>> ListarPagamentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idPagamento = null, long? idEstabelecimento = null, long? idBanco = null, long? idCartao = null, string dataHoraPagamento = null, long? status = null)
        {
            
    
            var localVarPath = "/api/pagamentos";
    
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
            if (idPagamento != null) localVarQueryParams.Add("idPagamento", Configuration.ApiClient.ParameterToString(idPagamento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idBanco != null) localVarQueryParams.Add("idBanco", Configuration.ApiClient.ParameterToString(idBanco)); // query parameter
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (dataHoraPagamento != null) localVarQueryParams.Add("dataHoraPagamento", Configuration.ApiClient.ParameterToString(dataHoraPagamento)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoPagamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoPagamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoPagamentoResponse)));
            
        }
        
        /// <summary>
        /// Listar pagamentos inv\u00E1lidos Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param> 
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param> 
        /// <param name="valorPago">Valor pago da fatura (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param> 
        /// <returns>PagePagamentosInvalidosResponse</returns>
        public PagePagamentosInvalidosResponse ListarPagamentosInvalidos (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null)
        {
             ApiResponse<PagePagamentosInvalidosResponse> localVarResponse = ListarPagamentosInvalidosWithHttpInfo(sort, page, limit, banco, dataPagamento, valorPago, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar pagamentos inv\u00E1lidos Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param> 
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param> 
        /// <param name="valorPago">Valor pago da fatura (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param> 
        /// <returns>ApiResponse of PagePagamentosInvalidosResponse</returns>
        public ApiResponse< PagePagamentosInvalidosResponse > ListarPagamentosInvalidosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/pagamentos-invalidos";
    
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
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (dataPagamento != null) localVarQueryParams.Add("dataPagamento", Configuration.ApiClient.ParameterToString(dataPagamento)); // query parameter
            if (valorPago != null) localVarQueryParams.Add("valorPago", Configuration.ApiClient.ParameterToString(valorPago)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentosInvalidos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentosInvalidos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePagamentosInvalidosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePagamentosInvalidosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePagamentosInvalidosResponse)));
            
        }

        
        /// <summary>
        /// Listar pagamentos inv\u00E1lidos Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param>
        /// <param name="valorPago">Valor pago da fatura (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param>
        /// <returns>Task of PagePagamentosInvalidosResponse</returns>
        public async System.Threading.Tasks.Task<PagePagamentosInvalidosResponse> ListarPagamentosInvalidosAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null)
        {
             ApiResponse<PagePagamentosInvalidosResponse> localVarResponse = await ListarPagamentosInvalidosAsyncWithHttpInfo(sort, page, limit, banco, dataPagamento, valorPago, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar pagamentos inv\u00E1lidos Esse recurso permite listar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">C\u00F3digo de identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="dataPagamento">Data de pagamento do boleto (optional)</param>
        /// <param name="valorPago">Valor pago da fatura (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento (optional)</param>
        /// <returns>Task of ApiResponse (PagePagamentosInvalidosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePagamentosInvalidosResponse>> ListarPagamentosInvalidosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, string dataPagamento = null, double? valorPago = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/pagamentos-invalidos";
    
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
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (dataPagamento != null) localVarQueryParams.Add("dataPagamento", Configuration.ApiClient.ParameterToString(dataPagamento)); // query parameter
            if (valorPago != null) localVarQueryParams.Add("valorPago", Configuration.ApiClient.ParameterToString(valorPago)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentosInvalidos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPagamentosInvalidos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePagamentosInvalidosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePagamentosInvalidosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePagamentosInvalidosResponse)));
            
        }
        
        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="persistDto">persistDto</param> 
        /// <returns>RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido</returns>
        public RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido Regularizar (long? id, RegularizacaoPagamentoPersist persistDto)
        {
             ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido> localVarResponse = RegularizarWithHttpInfo(id, persistDto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="persistDto">persistDto</param> 
        /// <returns>ApiResponse of RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido</returns>
        public ApiResponse< RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido > RegularizarWithHttpInfo (long? id, RegularizacaoPagamentoPersist persistDto)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PagamentoApi->Regularizar");
            
            // verify the required parameter 'persistDto' is set
            if (persistDto == null)
                throw new ApiException(400, "Missing required parameter 'persistDto' when calling PagamentoApi->Regularizar");
            
    
            var localVarPath = "/api/pagamentos-invalidos/{id}";
    
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
            
            
            
            
            if (persistDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistDto; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Regularizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Regularizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido)));
            
        }

        
        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="persistDto">persistDto</param>
        /// <returns>Task of RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido</returns>
        public async System.Threading.Tasks.Task<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido> RegularizarAsync (long? id, RegularizacaoPagamentoPersist persistDto)
        {
             ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido> localVarResponse = await RegularizarAsyncWithHttpInfo(id, persistDto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Regularizar um pagamento inv\u00E1lido Esse recurso permite regularizar os pagamentos inv\u00E1lidos na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="persistDto">persistDto</param>
        /// <returns>Task of ApiResponse (RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido>> RegularizarAsyncWithHttpInfo (long? id, RegularizacaoPagamentoPersist persistDto)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Regularizar");
            // verify the required parameter 'persistDto' is set
            if (persistDto == null) throw new ApiException(400, "Missing required parameter 'persistDto' when calling Regularizar");
            
    
            var localVarPath = "/api/pagamentos-invalidos/{id}";
    
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
            
            
            
            
            if (persistDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistDto; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Regularizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Regularizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido)));
            
        }
        
    }
    
}
