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
    public interface IAntecipationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Configurate the Antecipation taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConfigurarTaxaAntecipacao (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
  
        /// <summary>
        /// Configurate the Antecipation taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConsultarTaxaAntecipacao (long? id, string tipoTransacao);
  
        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConsultarTaxaAntecipacaoWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacao (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
  
        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacaoWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
        
        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacoes (long? idConta, string complemento = null);
  
        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacoesWithHttpInfo (long? idConta, string complemento = null);
        
        /// <summary>
        /// List the shops with antecipate installments
        /// </summary>
        /// <remarks>
        /// List the antecipate shops of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param>
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param>
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param>
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param>
        /// <returns>PageCompraResponse</returns>
        PageCompraResponse Listar (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
  
        /// <summary>
        /// List the shops with antecipate installments
        /// </summary>
        /// <remarks>
        /// List the antecipate shops of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param>
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param>
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param>
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param>
        /// <returns>ApiResponse of PageCompraResponse</returns>
        ApiResponse<PageCompraResponse> ListarWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// Simulate the antecipation of installments
        /// </summary>
        /// <remarks>
        /// Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>AntecipacaoSimuladaResponse</returns>
        AntecipacaoSimuladaResponse SimularAntecipacao (long? idConta, long? id, string complemento = null);
  
        /// <summary>
        /// Simulate the antecipation of installments
        /// </summary>
        /// <remarks>
        /// Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        ApiResponse<AntecipacaoSimuladaResponse> SimularAntecipacaoWithHttpInfo (long? idConta, long? id, string complemento = null);
        
        /// <summary>
        /// Simulate the antecipation of all the antecipate installments
        /// </summary>
        /// <remarks>
        /// The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>AntecipacaoSimuladaLoteResponse</returns>
        AntecipacaoSimuladaLoteResponse SimularAntecipacoes (long? idConta, string complemento = null);
  
        /// <summary>
        /// Simulate the antecipation of all the antecipate installments
        /// </summary>
        /// <remarks>
        /// The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaLoteResponse</returns>
        ApiResponse<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesWithHttpInfo (long? idConta, string complemento = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Configurate the Antecipation taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);

        /// <summary>
        /// Configurate the Antecipation taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoAsync (long? id, string tipoTransacao);

        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoAsyncWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoAsync (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);

        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
        
        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacoesAsync (long? idConta, string complemento = null);

        /// <summary>
        /// Do the effectivennes of the antecipation
        /// </summary>
        /// <remarks>
        /// Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacoesAsyncWithHttpInfo (long? idConta, string complemento = null);
        
        /// <summary>
        /// List the shops with antecipate installments
        /// </summary>
        /// <remarks>
        /// List the antecipate shops of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param>
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param>
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param>
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        System.Threading.Tasks.Task<PageCompraResponse> ListarAsync (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);

        /// <summary>
        /// List the shops with antecipate installments
        /// </summary>
        /// <remarks>
        /// List the antecipate shops of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param>
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param>
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param>
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarAsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// Simulate the antecipation of installments
        /// </summary>
        /// <remarks>
        /// Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoAsync (long? idConta, long? id, string complemento = null);

        /// <summary>
        /// Simulate the antecipation of installments
        /// </summary>
        /// <remarks>
        /// Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoAsyncWithHttpInfo (long? idConta, long? id, string complemento = null);
        
        /// <summary>
        /// Simulate the antecipation of all the antecipate installments
        /// </summary>
        /// <remarks>
        /// The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaLoteResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesAsync (long? idConta, string complemento = null);

        /// <summary>
        /// Simulate the antecipation of all the antecipate installments
        /// </summary>
        /// <remarks>
        /// The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaLoteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaLoteResponse>> SimularAntecipacoesAsyncWithHttpInfo (long? idConta, string complemento = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AntecipationApi : IAntecipationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AntecipationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AntecipationApi(Configuration configuration = null)
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
        /// Configurate the Antecipation taxe of a Product this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConfigurarTaxaAntecipacao (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConfigurarTaxaAntecipacaoWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Configurate the Antecipation taxe of a Product this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConfigurarTaxaAntecipacaoWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipationApi->ConfigurarTaxaAntecipacao");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling AntecipationApi->ConfigurarTaxaAntecipacao");
            
    
            var localVarPath = "/api/produtos/{id}/configurar-taxa-antecipacao";
    
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
            
            
            
            
            if (taxaAntecipacaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taxaAntecipacaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taxaAntecipacaoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }

        
        /// <summary>
        /// Configurate the Antecipation taxe of a Product this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConfigurarTaxaAntecipacaoAsyncWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Configurate the Antecipation taxe of a Product this resource allows to configurate the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConfigurarTaxaAntecipacao");
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null) throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling ConfigurarTaxaAntecipacao");
            
    
            var localVarPath = "/api/produtos/{id}/configurar-taxa-antecipacao";
    
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
            
            
            
            
            if (taxaAntecipacaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taxaAntecipacaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taxaAntecipacaoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param> 
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConsultarTaxaAntecipacao (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConsultarTaxaAntecipacaoWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param> 
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConsultarTaxaAntecipacaoWithHttpInfo (long? id, string tipoTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipationApi->ConsultarTaxaAntecipacao");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling AntecipationApi->ConsultarTaxaAntecipacao");
            
    
            var localVarPath = "/api/produtos/{id}/consultar-taxa-antecipacao";
    
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
            
            if (tipoTransacao != null) localVarQueryParams.Add("tipoTransacao", Configuration.ApiClient.ParameterToString(tipoTransacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoAsync (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConsultarTaxaAntecipacaoAsyncWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the Antecipation Taxe of a Product this resource allows to retrieve the Antecipation Taxe of a Product, using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Product</param>
        /// <param name="tipoTransacao">Transaction type (ON-US ou OFF-US)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoAsyncWithHttpInfo (long? id, string tipoTransacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxaAntecipacao");
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null) throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling ConsultarTaxaAntecipacao");
            
    
            var localVarPath = "/api/produtos/{id}/consultar-taxa-antecipacao";
    
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
            
            if (tipoTransacao != null) localVarQueryParams.Add("tipoTransacao", Configuration.ApiClient.ParameterToString(tipoTransacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }
        
        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="id">Identification Code of the Event</param> 
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param> 
        /// <param name="complemento">Complementary dates about the transactions (optional)</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacao (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacaoWithHttpInfo(idConta, id, quantidadeParcelas, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="id">Identification Code of the Event</param> 
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param> 
        /// <param name="complemento">Complementary dates about the transactions (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacaoWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipationApi->EfetivarAntecipacao");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipationApi->EfetivarAntecipacao");
            
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null)
                throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling AntecipationApi->EfetivarAntecipacao");
            
    
            var localVarPath = "/api/compras-antecipaveis/{id}/efetivar-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoAsync (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacaoAsyncWithHttpInfo(idConta, id, quantidadeParcelas, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of the antecipation, which the discount is calculated based on the last open installments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="quantidadeParcelas">Quantity of parcels to be antecipated</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacao");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EfetivarAntecipacao");
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null) throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling EfetivarAntecipacao");
            
    
            var localVarPath = "/api/compras-antecipaveis/{id}/efetivar-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="complemento">Complementary dates about the transaction (optional)</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacoes (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacoesWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="complemento">Complementary dates about the transaction (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacoesWithHttpInfo (long? idConta, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipationApi->EfetivarAntecipacoes");
            
    
            var localVarPath = "/api/compras-antecipaveis/efetivar-antecipacao";
    
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
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacoesAsync (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacoesAsyncWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Do the effectivennes of the antecipation Method responsable for the effectiveness of all the antecipated shops and all the installments of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacoesAsyncWithHttpInfo (long? idConta, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacoes");
            
    
            var localVarPath = "/api/compras-antecipaveis/efetivar-antecipacao";
    
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
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// List the shops with antecipate installments List the antecipate shops of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param> 
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param> 
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param> 
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param> 
        /// <returns>PageCompraResponse</returns>
        public PageCompraResponse Listar (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = ListarWithHttpInfo(idConta, sort, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the shops with antecipate installments List the antecipate shops of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param> 
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param> 
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param> 
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param> 
        /// <returns>ApiResponse of PageCompraResponse</returns>
        public ApiResponse< PageCompraResponse > ListarWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipationApi->Listar");
            
    
            var localVarPath = "/api/compras-antecipaveis";
    
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
            if (idCompra != null) localVarQueryParams.Add("idCompra", Configuration.ApiClient.ParameterToString(idCompra)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (parcelada != null) localVarQueryParams.Add("parcelada", Configuration.ApiClient.ParameterToString(parcelada)); // query parameter
            if (juros != null) localVarQueryParams.Add("juros", Configuration.ApiClient.ParameterToString(juros)); // query parameter
            if (tipoOrigemTransacao != null) localVarQueryParams.Add("tipoOrigemTransacao", Configuration.ApiClient.ParameterToString(tipoOrigemTransacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }

        
        /// <summary>
        /// List the shops with antecipate installments List the antecipate shops of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param>
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param>
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param>
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        public async System.Threading.Tasks.Task<PageCompraResponse> ListarAsync (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = await ListarAsyncWithHttpInfo(idConta, sort, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the shops with antecipate installments List the antecipate shops of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Purchase account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">Identifier Code of the Purchase (optional)</param>
        /// <param name="parcelada">Indicate if the purchase is parceled (optional)</param>
        /// <param name="juros">Indicate if the account is with or without interests (optional)</param>
        /// <param name="tipoOrigemTransacao">Indicate if the purchase is ON-US or OFF-US (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarAsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling Listar");
            
    
            var localVarPath = "/api/compras-antecipaveis";
    
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
            if (idCompra != null) localVarQueryParams.Add("idCompra", Configuration.ApiClient.ParameterToString(idCompra)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (parcelada != null) localVarQueryParams.Add("parcelada", Configuration.ApiClient.ParameterToString(parcelada)); // query parameter
            if (juros != null) localVarQueryParams.Add("juros", Configuration.ApiClient.ParameterToString(juros)); // query parameter
            if (tipoOrigemTransacao != null) localVarQueryParams.Add("tipoOrigemTransacao", Configuration.ApiClient.ParameterToString(tipoOrigemTransacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }
        
        /// <summary>
        /// Simulate the antecipation of installments Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param> 
        /// <param name="id">Identification Code of the Event</param> 
        /// <param name="complemento">Complementary dates about the transaction (optional)</param> 
        /// <returns>AntecipacaoSimuladaResponse</returns>
        public AntecipacaoSimuladaResponse SimularAntecipacao (long? idConta, long? id, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = SimularAntecipacaoWithHttpInfo(idConta, id, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simulate the antecipation of installments Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param> 
        /// <param name="id">Identification Code of the Event</param> 
        /// <param name="complemento">Complementary dates about the transaction (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        public ApiResponse< AntecipacaoSimuladaResponse > SimularAntecipacaoWithHttpInfo (long? idConta, long? id, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipationApi->SimularAntecipacao");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipationApi->SimularAntecipacao");
            
    
            var localVarPath = "/api/compras-antecipaveis/{id}/simular-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }

        
        /// <summary>
        /// Simulate the antecipation of installments Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoAsync (long? idConta, long? id, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = await SimularAntecipacaoAsyncWithHttpInfo(idConta, id, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simulate the antecipation of installments Simulate the antecipation of the installments of an event, listing all the able plans of installment, which the discount is calculated on the last date of the open installment
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification code of the account</param>
        /// <param name="id">Identification Code of the Event</param>
        /// <param name="complemento">Complementary dates about the transaction (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoAsyncWithHttpInfo (long? idConta, long? id, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacao");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularAntecipacao");
            
    
            var localVarPath = "/api/compras-antecipaveis/{id}/simular-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }
        
        /// <summary>
        /// Simulate the antecipation of all the antecipate installments The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="complemento">Complementary dates about the transactions (optional)</param> 
        /// <returns>AntecipacaoSimuladaLoteResponse</returns>
        public AntecipacaoSimuladaLoteResponse SimularAntecipacoes (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaLoteResponse> localVarResponse = SimularAntecipacoesWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simulate the antecipation of all the antecipate installments The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param> 
        /// <param name="complemento">Complementary dates about the transactions (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaLoteResponse</returns>
        public ApiResponse< AntecipacaoSimuladaLoteResponse > SimularAntecipacoesWithHttpInfo (long? idConta, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipationApi->SimularAntecipacoes");
            
    
            var localVarPath = "/api/compras-antecipaveis/simular-antecipacao";
    
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
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaLoteResponse)));
            
        }

        
        /// <summary>
        /// Simulate the antecipation of all the antecipate installments The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaLoteResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesAsync (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaLoteResponse> localVarResponse = await SimularAntecipacoesAsyncWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simulate the antecipation of all the antecipate installments The resource allows to simulate the antecipation of all the antecipate shops and installments of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account</param>
        /// <param name="complemento">Complementary dates about the transactions (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaLoteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaLoteResponse>> SimularAntecipacoesAsyncWithHttpInfo (long? idConta, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacoes");
            
    
            var localVarPath = "/api/compras-antecipaveis/simular-antecipacao";
    
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
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaLoteResponse)));
            
        }
        
    }
    
}
