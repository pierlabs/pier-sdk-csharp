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
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        
    }
    
}
