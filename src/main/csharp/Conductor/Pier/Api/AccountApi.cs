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
    public interface IAccountApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Launch an adjust for the account of the informed ID
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the account of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identifier External (optional)</param>
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>AjusteFinanceiroResponse</returns>
        AjusteFinanceiroResponse AjustarConta (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Launch an adjust for the account of the informed ID
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the account of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identifier External (optional)</param>
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        ApiResponse<AjusteFinanceiroResponse> AjustarContaWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Update the product associated to the account
        /// </summary>
        /// <remarks>
        /// the resource allows to make some modification of the product associated to the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>string</returns>
        string AlterarProduto (long? id, AlterarProdutoRequest request);
  
        /// <summary>
        /// Update the product associated to the account
        /// </summary>
        /// <remarks>
        /// the resource allows to make some modification of the product associated to the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarProdutoWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Update the account of a Personal holder
        /// </summary>
        /// <remarks>
        /// This method allows to change the person of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of a Person (id)</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarTitular (long? id, long? idPessoa);
  
        /// <summary>
        /// Update the account of a Personal holder
        /// </summary>
        /// <remarks>
        /// This method allows to change the person of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of a Person (id)</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarTitularWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Update the expiration of the invoices
        /// </summary>
        /// <remarks>
        /// This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="novoDiaVencimento">New day of expiration</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AlterarVencimento (long? id, int? novoDiaVencimento);
  
        /// <summary>
        /// Update the expiration of the invoices
        /// </summary>
        /// <remarks>
        /// This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="novoDiaVencimento">New day of expiration</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AlterarVencimentoWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        /// Attribute Annuity
        /// </summary>
        /// <remarks>
        /// This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idAnuidade">Identifier of annuity</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD of the cell phone (optional)</param>
        /// <param name="celular">Cell Phone Number (optional)</param>
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param>
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param>
        /// <returns>Object</returns>
        Object AtivarAnuidade (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
  
        /// <summary>
        /// Attribute Annuity
        /// </summary>
        /// <remarks>
        /// This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idAnuidade">Identifier of annuity</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD of the cell phone (optional)</param>
        /// <param name="celular">Cell Phone Number (optional)</param>
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param>
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarAnuidadeWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        /// Activate the sending service of invoice by email
        /// </summary>
        /// <remarks>
        /// This resource activates the sending service of invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Object</returns>
        Object AtivarEnvioFaturaEmail (long? id);
  
        /// <summary>
        /// Activate the sending service of invoice by email
        /// </summary>
        /// <remarks>
        /// This resource activates the sending service of invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarEnvioFaturaEmailWithHttpInfo (long? id);
        
        /// <summary>
        /// Performs partial account update
        /// </summary>
        /// <remarks>
        /// This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>ContaResponse</returns>
        ContaResponse AtualizarParcial (long? id, ContaPartialUpdate contaPartialUpdate);
  
        /// <summary>
        /// Performs partial account update
        /// </summary>
        /// <remarks>
        /// This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> AtualizarParcialWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate);
        
        /// <summary>
        /// Block a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to block a determined account using de id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Identification Code of the New Status Account</param>
        /// <returns>ContaResponse</returns>
        ContaResponse Bloquear (long? id, long? idStatus);
  
        /// <summary>
        /// Block a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to block a determined account using de id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Identification Code of the New Status Account</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> BloquearWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Registration payment enrollment on Saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to register a payment membership on Saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        AdesaoPagamentoSabadoResponse Cadastrar (long? id);
  
        /// <summary>
        /// Registration payment enrollment on Saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to register a payment membership on Saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        ApiResponse<AdesaoPagamentoSabadoResponse> CadastrarWithHttpInfo (long? id);
        
        /// <summary>
        /// Do the cancellation of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to do the cancellation of a determined account using the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Idetification Code of the Account Status</param>
        /// <returns>ContaResponse</returns>
        ContaResponse Cancelar (long? id, long? idStatus);
  
        /// <summary>
        /// Do the cancellation of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to do the cancellation of a determined account using the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Idetification Code of the Account Status</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> CancelarWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Find an adhesion of payment on saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to find an adhesion of payment on saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param>
        /// <param name="dataVencimento">Adhesion due date</param>
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        AdesaoPagamentoSabadoResponse Consultar (long? id, string dataVencimento);
  
        /// <summary>
        /// Find an adhesion of payment on saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to find an adhesion of payment on saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param>
        /// <param name="dataVencimento">Adhesion due date</param>
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        ApiResponse<AdesaoPagamentoSabadoResponse> ConsultarWithHttpInfo (long? id, string dataVencimento);
        
        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtraso (long? id);
  
        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        ApiResponse<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the dates of a determined invoice slip
        /// </summary>
        /// <remarks>
        /// this resource retrieves an invoice slip
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse ConsultarBoletoEmitido (long? id);
  
        /// <summary>
        /// Retrieve the dates of a determined invoice slip
        /// </summary>
        /// <remarks>
        /// this resource retrieves an invoice slip
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> ConsultarBoletoEmitidoWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the updated debt of the client
        /// </summary>
        /// <remarks>
        /// This resource retrieves the updated debt of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration (optional)</param>
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param>
        /// <returns>DividaClienteResponse</returns>
        DividaClienteResponse ConsultarDividaAtualizadaCliente (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
  
        /// <summary>
        /// Retrieve the updated debt of the client
        /// </summary>
        /// <remarks>
        /// This resource retrieves the updated debt of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration (optional)</param>
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param>
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        ApiResponse<DividaClienteResponse> ConsultarDividaAtualizadaClienteWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Retrieves a processed transaction for an account.
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param>
        /// <param name="idTransacao">Identification code of the Transaction (id).</param>
        /// <returns>TransacoesCorrentesResponse</returns>
        TransacoesCorrentesResponse ConsultarProcessada (long? id, long? idTransacao);
  
        /// <summary>
        /// Retrieves a processed transaction for an account.
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param>
        /// <param name="idTransacao">Identification code of the Transaction (id).</param>
        /// <returns>ApiResponse of TransacoesCorrentesResponse</returns>
        ApiResponse<TransacoesCorrentesResponse> ConsultarProcessadaWithHttpInfo (long? id, long? idTransacao);
        
        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        PageTaxasRefinanciamentoResponse ConsultarTaxasTarifas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        ApiResponse<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Displays data for a particular function type for accounts
        /// </summary>
        /// <remarks>
        /// This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param>
        /// <returns>string</returns>
        string Consultar_0 (int? id);
  
        /// <summary>
        /// Displays data for a particular function type for accounts
        /// </summary>
        /// <remarks>
        /// This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> Consultar_0WithHttpInfo (int? id);
        
        /// <summary>
        /// Show dates of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>ContaDetalheResponse</returns>
        ContaDetalheResponse Consultar_1 (long? id);
  
        /// <summary>
        /// Show dates of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        ApiResponse<ContaDetalheResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the details of a determined transfer
        /// </summary>
        /// <remarks>
        /// This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse Consultar_2 (long? id, long? idTransferencia);
  
        /// <summary>
        /// Retrieve the details of a determined transfer
        /// </summary>
        /// <remarks>
        /// This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> Consultar_2WithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ContaMultiAppResponse</returns>
        ContaMultiAppResponse CriarContasMultiApp (CountMultiAppPersist contaMultiAppPersist);
  
        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        ApiResponse<ContaMultiAppResponse> CriarContasMultiAppWithHttpInfo (CountMultiAppPersist contaMultiAppPersist);
        
        /// <summary>
        /// Disable the service of sending the invoice by email
        /// </summary>
        /// <remarks>
        /// This resorurce desables the service of sending the invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Object</returns>
        Object DesativarEnvioFaturaEmail (long? id);
  
        /// <summary>
        /// Disable the service of sending the invoice by email
        /// </summary>
        /// <remarks>
        /// This resorurce desables the service of sending the invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarEnvioFaturaEmailWithHttpInfo (long? id);
        
        /// <summary>
        /// Create a slip of recharge
        /// </summary>
        /// <remarks>
        /// This resource creates a slip of recharge
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param>
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse GerarBoletoRecarga (long? id, double? valor, string dataVencimento);
  
        /// <summary>
        /// Create a slip of recharge
        /// </summary>
        /// <remarks>
        /// This resource creates a slip of recharge
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param>
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> GerarBoletoRecargaWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// Create a new card for printing
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the person (id)</param>
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartao (long? id, long? idPessoa, long? idTipoPlastico = null);
  
        /// <summary>
        /// Create a new card for printing
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the person (id)</param>
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Do the sending for the generation of a new card in graphic
        /// </summary>
        /// <remarks>
        /// This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>CartaoEmbossingResponse</returns>
        CartaoEmbossingResponse GerarCartaoEmbossing (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
  
        /// <summary>
        /// Do the sending for the generation of a new card in graphic
        /// </summary>
        /// <remarks>
        /// This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        ApiResponse<CartaoEmbossingResponse> GerarCartaoEmbossingWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// Create a provisory card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        CartaoImpressaoProvisorioResponse GerarCartaoProvisorio (long? id);
  
        /// <summary>
        /// Create a provisory card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        ApiResponse<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioWithHttpInfo (long? id);
        
        /// <summary>
        /// Create a virtual card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataValidade">Expiration date</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarCartaoVirtual (long? id, string dataValidade);
  
        /// <summary>
        /// Create a virtual card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataValidade">Expiration date</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarCartaoVirtualWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// List existent accounts in the database of the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent accounts in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param>
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param>
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param>
        /// <param name="diaVencimento">List the day of expiration (optional)</param>
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param>
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param>
        /// <param name="dataCadastro">List the date that the card was created (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>PageContaResponse</returns>
        PageContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);
  
        /// <summary>
        /// List existent accounts in the database of the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent accounts in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param>
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param>
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param>
        /// <param name="diaVencimento">List the day of expiration (optional)</param>
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param>
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param>
        /// <param name="dataCadastro">List the date that the card was created (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>ApiResponse of PageContaResponse</returns>
        ApiResponse<PageContaResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);
        
        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoEventosResponse</returns>
        PageHistoricoEventosResponse ListarHistoricoAlteracoesLimites (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        ApiResponse<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the historic of in/out  of advisories of collection
        /// </summary>
        /// <remarks>
        /// Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        PageHistoricoAssessoriaResponse ListarHistoricoAssessoria (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the historic of in/out  of advisories of collection
        /// </summary>
        /// <remarks>
        /// Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        ApiResponse<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the historic of late invoices
        /// </summary>
        /// <remarks>
        /// This resource lists the historic the late invoice payments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturas (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the historic of late invoices
        /// </summary>
        /// <remarks>
        /// This resource lists the historic the late invoice payments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        ApiResponse<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the transactions unprocessed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions unprocessed of the Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param>
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param>
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        PageTransacaoNaoProcessadaResponse ListarNaoProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
  
        /// <summary>
        /// List the transactions unprocessed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions unprocessed of the Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param>
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param>
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// List of the transactions processed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions processed of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param>
        /// <returns>PageTransacoesCorrentesResponse</returns>
        PageTransacoesCorrentesResponse ListarProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
  
        /// <summary>
        /// List of the transactions processed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions processed of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param>
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        ApiResponse<PageTransacoesCorrentesResponse> ListarProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string Listar_0 ();
  
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> Listar_0WithHttpInfo ();
        
        /// <summary>
        /// Lists unprocessed and processed account transactions
        /// </summary>
        /// <remarks>
        /// This method allows all unprocessed and processed transactions in the Account to be listed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param>
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param>
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param>
        /// <param name="status">Transaction Status (optional)</param>
        /// <param name="plano">Transaction plan (optional)</param>
        /// <param name="codigoMCC">MCC transaction code (optional)</param>
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param>
        /// <returns>PageTransacaoProcessadaNaoProcessadaResponse</returns>
        PageTransacaoProcessadaNaoProcessadaResponse Listar_1 (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
  
        /// <summary>
        /// Lists unprocessed and processed account transactions
        /// </summary>
        /// <remarks>
        /// This method allows all unprocessed and processed transactions in the Account to be listed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param>
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param>
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param>
        /// <param name="status">Transaction Status (optional)</param>
        /// <param name="plano">Transaction plan (optional)</param>
        /// <param name="codigoMCC">MCC transaction code (optional)</param>
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param>
        /// <returns>ApiResponse of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> Listar_1WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
        
        /// <summary>
        /// List the transfers made by the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param>
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param>
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param>
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param>
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param>
        /// <returns>PageTransferenciaResponse</returns>
        PageTransferenciaResponse Listar_2 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
  
        /// <summary>
        /// List the transfers made by the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param>
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param>
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param>
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param>
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        ApiResponse<PageTransferenciaResponse> Listar_2WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// Do the reactivation of the account
        /// </summary>
        /// <remarks>
        /// this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Object</returns>
        Object Reativar (long? id);
  
        /// <summary>
        /// Do the reactivation of the account
        /// </summary>
        /// <remarks>
        /// this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReativarWithHttpInfo (long? id);
        
        /// <summary>
        /// Includes a new account
        /// </summary>
        /// <remarks>
        /// This resource includes a new account for an existing client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>ContaResponse</returns>
        ContaResponse Salvar (ContaPersist contaPersist);
  
        /// <summary>
        /// Includes a new account
        /// </summary>
        /// <remarks>
        /// This resource includes a new account for an existing client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> SalvarWithHttpInfo (ContaPersist contaPersist);
        
        /// <summary>
        /// Make a registration of a new service adhesion
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new service subscription at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>AdesaoServicoResponse</returns>
        AdesaoServicoResponse SalvarAdesaoServicos (long? id, AdesaoServicoPersist adesaoServicoPersist);
  
        /// <summary>
        /// Make a registration of a new service adhesion
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new service subscription at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>ApiResponse of AdesaoServicoResponse</returns>
        ApiResponse<AdesaoServicoResponse> SalvarAdesaoServicosWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist);
        
        /// <summary>
        /// Simulate values of loans/financing
        /// </summary>
        /// <remarks>
        /// This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>EmprestimoPessoalResponse</returns>
        EmprestimoPessoalResponse SimularEmprestimoFinanciamento (long? id, EmprestimoPessoalRequest request);
  
        /// <summary>
        /// Simulate values of loans/financing
        /// </summary>
        /// <remarks>
        /// This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        ApiResponse<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Allow to list a timeline of the event of the account
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageTransacaoResponse</returns>
        PageTransacaoResponse Transacoes (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Allow to list a timeline of the event of the account
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        ApiResponse<PageTransacaoResponse> TransacoesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Make a credit transfer to another client of the same Issuer
        /// </summary>
        /// <remarks>
        /// This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param>
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param>
        /// <param name="valorTransferencia">Value of the Transfer</param>
        /// <returns>TransferenciaDetalheResponse</returns>
        TransferenciaDetalheResponse Transferir (long? id, long? idContaDestino, double? valorTransferencia);
  
        /// <summary>
        /// Make a credit transfer to another client of the same Issuer
        /// </summary>
        /// <remarks>
        /// This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param>
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param>
        /// <param name="valorTransferencia">Value of the Transfer</param>
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        ApiResponse<TransferenciaDetalheResponse> TransferirWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Launch an adjust for the account of the informed ID
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the account of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identifier External (optional)</param>
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaAsync (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);

        /// <summary>
        /// Launch an adjust for the account of the informed ID
        /// </summary>
        /// <remarks>
        /// This resource insert an adjust for the account of the informed ID
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identifier External (optional)</param>
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaAsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Update the product associated to the account
        /// </summary>
        /// <remarks>
        /// the resource allows to make some modification of the product associated to the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarProdutoAsync (long? id, AlterarProdutoRequest request);

        /// <summary>
        /// Update the product associated to the account
        /// </summary>
        /// <remarks>
        /// the resource allows to make some modification of the product associated to the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoAsyncWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Update the account of a Personal holder
        /// </summary>
        /// <remarks>
        /// This method allows to change the person of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of a Person (id)</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarTitularAsync (long? id, long? idPessoa);

        /// <summary>
        /// Update the account of a Personal holder
        /// </summary>
        /// <remarks>
        /// This method allows to change the person of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of a Person (id)</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Update the expiration of the invoices
        /// </summary>
        /// <remarks>
        /// This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="novoDiaVencimento">New day of expiration</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoAsync (long? id, int? novoDiaVencimento);

        /// <summary>
        /// Update the expiration of the invoices
        /// </summary>
        /// <remarks>
        /// This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="novoDiaVencimento">New day of expiration</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoAsyncWithHttpInfo (long? id, int? novoDiaVencimento);
        
        /// <summary>
        /// Attribute Annuity
        /// </summary>
        /// <remarks>
        /// This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idAnuidade">Identifier of annuity</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD of the cell phone (optional)</param>
        /// <param name="celular">Cell Phone Number (optional)</param>
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param>
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarAnuidadeAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);

        /// <summary>
        /// Attribute Annuity
        /// </summary>
        /// <remarks>
        /// This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idAnuidade">Identifier of annuity</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD of the cell phone (optional)</param>
        /// <param name="celular">Cell Phone Number (optional)</param>
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param>
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        /// Activate the sending service of invoice by email
        /// </summary>
        /// <remarks>
        /// This resource activates the sending service of invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailAsync (long? id);

        /// <summary>
        /// Activate the sending service of invoice by email
        /// </summary>
        /// <remarks>
        /// This resource activates the sending service of invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Performs partial account update
        /// </summary>
        /// <remarks>
        /// This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> AtualizarParcialAsync (long? id, ContaPartialUpdate contaPartialUpdate);

        /// <summary>
        /// Performs partial account update
        /// </summary>
        /// <remarks>
        /// This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AtualizarParcialAsyncWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate);
        
        /// <summary>
        /// Block a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to block a determined account using de id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Identification Code of the New Status Account</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> BloquearAsync (long? id, long? idStatus);

        /// <summary>
        /// Block a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to block a determined account using de id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Identification Code of the New Status Account</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Registration payment enrollment on Saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to register a payment membership on Saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> CadastrarAsync (long? id);

        /// <summary>
        /// Registration payment enrollment on Saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to register a payment membership on Saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> CadastrarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Do the cancellation of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to do the cancellation of a determined account using the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Idetification Code of the Account Status</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> CancelarAsync (long? id, long? idStatus);

        /// <summary>
        /// Do the cancellation of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to do the cancellation of a determined account using the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Idetification Code of the Account Status</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Find an adhesion of payment on saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to find an adhesion of payment on saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param>
        /// <param name="dataVencimento">Adhesion due date</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> ConsultarAsync (long? id, string dataVencimento);

        /// <summary>
        /// Find an adhesion of payment on saturday
        /// </summary>
        /// <remarks>
        /// This resource allows you to find an adhesion of payment on saturday
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param>
        /// <param name="dataVencimento">Adhesion due date</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> ConsultarAsyncWithHttpInfo (long? id, string dataVencimento);
        
        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoAsync (long? id);

        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the dates of a determined invoice slip
        /// </summary>
        /// <remarks>
        /// this resource retrieves an invoice slip
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoAsync (long? id);

        /// <summary>
        /// Retrieve the dates of a determined invoice slip
        /// </summary>
        /// <remarks>
        /// this resource retrieves an invoice slip
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the updated debt of the client
        /// </summary>
        /// <remarks>
        /// This resource retrieves the updated debt of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration (optional)</param>
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);

        /// <summary>
        /// Retrieve the updated debt of the client
        /// </summary>
        /// <remarks>
        /// This resource retrieves the updated debt of the client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration (optional)</param>
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null);
        
        /// <summary>
        /// Retrieves a processed transaction for an account.
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param>
        /// <param name="idTransacao">Identification code of the Transaction (id).</param>
        /// <returns>Task of TransacoesCorrentesResponse</returns>
        System.Threading.Tasks.Task<TransacoesCorrentesResponse> ConsultarProcessadaAsync (long? id, long? idTransacao);

        /// <summary>
        /// Retrieves a processed transaction for an account.
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param>
        /// <param name="idTransacao">Identification code of the Transaction (id).</param>
        /// <returns>Task of ApiResponse (TransacoesCorrentesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacoesCorrentesResponse>> ConsultarProcessadaAsyncWithHttpInfo (long? id, long? idTransacao);
        
        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Displays data for a particular function type for accounts
        /// </summary>
        /// <remarks>
        /// This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> Consultar_0Async (int? id);

        /// <summary>
        /// Displays data for a particular function type for accounts
        /// </summary>
        /// <remarks>
        /// This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> Consultar_0AsyncWithHttpInfo (int? id);
        
        /// <summary>
        /// Show dates of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        System.Threading.Tasks.Task<ContaDetalheResponse> Consultar_1Async (long? id);

        /// <summary>
        /// Show dates of a determined account
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve dates of a determined account using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the details of a determined transfer
        /// </summary>
        /// <remarks>
        /// This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> Consultar_2Async (long? id, long? idTransferencia);

        /// <summary>
        /// Retrieve the details of a determined transfer
        /// </summary>
        /// <remarks>
        /// This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id, long? idTransferencia);
        
        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppAsync (CountMultiAppPersist contaMultiAppPersist);

        /// <summary>
        /// Register accounts MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows you to register accounts MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppAsyncWithHttpInfo (CountMultiAppPersist contaMultiAppPersist);
        
        /// <summary>
        /// Disable the service of sending the invoice by email
        /// </summary>
        /// <remarks>
        /// This resorurce desables the service of sending the invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailAsync (long? id);

        /// <summary>
        /// Disable the service of sending the invoice by email
        /// </summary>
        /// <remarks>
        /// This resorurce desables the service of sending the invoice by email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Create a slip of recharge
        /// </summary>
        /// <remarks>
        /// This resource creates a slip of recharge
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param>
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaAsync (long? id, double? valor, string dataVencimento);

        /// <summary>
        /// Create a slip of recharge
        /// </summary>
        /// <remarks>
        /// This resource creates a slip of recharge
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param>
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaAsyncWithHttpInfo (long? id, double? valor, string dataVencimento);
        
        /// <summary>
        /// Create a new card for printing
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the person (id)</param>
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoAsync (long? id, long? idPessoa, long? idTipoPlastico = null);

        /// <summary>
        /// Create a new card for printing
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the person (id)</param>
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null);
        
        /// <summary>
        /// Do the sending for the generation of a new card in graphic
        /// </summary>
        /// <remarks>
        /// This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);

        /// <summary>
        /// Do the sending for the generation of a new card in graphic
        /// </summary>
        /// <remarks>
        /// This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest);
        
        /// <summary>
        /// Create a provisory card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioAsync (long? id);

        /// <summary>
        /// Create a provisory card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Create a virtual card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataValidade">Expiration date</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualAsync (long? id, string dataValidade);

        /// <summary>
        /// Create a virtual card
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataValidade">Expiration date</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualAsyncWithHttpInfo (long? id, string dataValidade);
        
        /// <summary>
        /// List existent accounts in the database of the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent accounts in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param>
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param>
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param>
        /// <param name="diaVencimento">List the day of expiration (optional)</param>
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param>
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param>
        /// <param name="dataCadastro">List the date that the card was created (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        System.Threading.Tasks.Task<PageContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);

        /// <summary>
        /// List existent accounts in the database of the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to list existent accounts in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param>
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param>
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param>
        /// <param name="diaVencimento">List the day of expiration (optional)</param>
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param>
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param>
        /// <param name="dataCadastro">List the date that the card was created (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null);
        
        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the historic of updatings of the Account limit
        /// </summary>
        /// <remarks>
        /// This resource retrieves the historic with the updatings of the Account limit informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the historic of in/out  of advisories of collection
        /// </summary>
        /// <remarks>
        /// Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the historic of in/out  of advisories of collection
        /// </summary>
        /// <remarks>
        /// Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the historic of late invoices
        /// </summary>
        /// <remarks>
        /// This resource lists the historic the late invoice payments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the historic of late invoices
        /// </summary>
        /// <remarks>
        /// This resource lists the historic the late invoice payments
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the transactions unprocessed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions unprocessed of the Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param>
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);

        /// <summary>
        /// List the transactions unprocessed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions unprocessed of the Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param>
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null);
        
        /// <summary>
        /// List of the transactions processed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions processed of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);

        /// <summary>
        /// List of the transactions processed of the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed all the transactions processed of the account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null);
        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> Listar_0Async ();

        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> Listar_0AsyncWithHttpInfo ();
        
        /// <summary>
        /// Lists unprocessed and processed account transactions
        /// </summary>
        /// <remarks>
        /// This method allows all unprocessed and processed transactions in the Account to be listed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param>
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param>
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param>
        /// <param name="status">Transaction Status (optional)</param>
        /// <param name="plano">Transaction plan (optional)</param>
        /// <param name="codigoMCC">MCC transaction code (optional)</param>
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param>
        /// <returns>Task of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoProcessadaNaoProcessadaResponse> Listar_1Async (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);

        /// <summary>
        /// Lists unprocessed and processed account transactions
        /// </summary>
        /// <remarks>
        /// This method allows all unprocessed and processed transactions in the Account to be listed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param>
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param>
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param>
        /// <param name="status">Transaction Status (optional)</param>
        /// <param name="plano">Transaction plan (optional)</param>
        /// <param name="codigoMCC">MCC transaction code (optional)</param>
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoProcessadaNaoProcessadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>> Listar_1AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null);
        
        /// <summary>
        /// List the transfers made by the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param>
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param>
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param>
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param>
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaResponse> Listar_2Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);

        /// <summary>
        /// List the transfers made by the account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param>
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param>
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param>
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param>
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> Listar_2AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null);
        
        /// <summary>
        /// Do the reactivation of the account
        /// </summary>
        /// <remarks>
        /// this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReativarAsync (long? id);

        /// <summary>
        /// Do the reactivation of the account
        /// </summary>
        /// <remarks>
        /// this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReativarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Includes a new account
        /// </summary>
        /// <remarks>
        /// This resource includes a new account for an existing client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> SalvarAsync (ContaPersist contaPersist);

        /// <summary>
        /// Includes a new account
        /// </summary>
        /// <remarks>
        /// This resource includes a new account for an existing client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> SalvarAsyncWithHttpInfo (ContaPersist contaPersist);
        
        /// <summary>
        /// Make a registration of a new service adhesion
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new service subscription at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of AdesaoServicoResponse</returns>
        System.Threading.Tasks.Task<AdesaoServicoResponse> SalvarAdesaoServicosAsync (long? id, AdesaoServicoPersist adesaoServicoPersist);

        /// <summary>
        /// Make a registration of a new service adhesion
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new service subscription at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of ApiResponse (AdesaoServicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoServicoResponse>> SalvarAdesaoServicosAsyncWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist);
        
        /// <summary>
        /// Simulate values of loans/financing
        /// </summary>
        /// <remarks>
        /// This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoAsync (long? id, EmprestimoPessoalRequest request);

        /// <summary>
        /// Simulate values of loans/financing
        /// </summary>
        /// <remarks>
        /// This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Allow to list a timeline of the event of the account
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Allow to list a timeline of the event of the account
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Make a credit transfer to another client of the same Issuer
        /// </summary>
        /// <remarks>
        /// This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param>
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param>
        /// <param name="valorTransferencia">Value of the Transfer</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirAsync (long? id, long? idContaDestino, double? valorTransferencia);

        /// <summary>
        /// Make a credit transfer to another client of the same Issuer
        /// </summary>
        /// <remarks>
        /// This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param>
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param>
        /// <param name="valorTransferencia">Value of the Transfer</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirAsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountApi : IAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountApi(Configuration configuration = null)
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
        /// Launch an adjust for the account of the informed ID This resource insert an adjust for the account of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param> 
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Value of the adjustment</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Identifier External (optional)</param> 
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param> 
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param> 
        /// <returns>AjusteFinanceiroResponse</returns>
        public AjusteFinanceiroResponse AjustarConta (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = AjustarContaWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Launch an adjust for the account of the informed ID This resource insert an adjust for the account of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param> 
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param> 
        /// <param name="valorAjuste">Value of the adjustment</param> 
        /// <param name="login">login (optional)</param> 
        /// <param name="identificadorExterno">Identifier External (optional)</param> 
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param> 
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param> 
        /// <returns>ApiResponse of AjusteFinanceiroResponse</returns>
        public ApiResponse< AjusteFinanceiroResponse > AjustarContaWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AjustarConta");
            
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null)
                throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AccountApi->AjustarConta");
            
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null)
                throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AccountApi->AjustarConta");
            
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null)
                throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AccountApi->AjustarConta");
            
    
            var localVarPath = "/api/contas/{id}/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }

        
        /// <summary>
        /// Launch an adjust for the account of the informed ID This resource insert an adjust for the account of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identifier External (optional)</param>
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of AjusteFinanceiroResponse</returns>
        public async System.Threading.Tasks.Task<AjusteFinanceiroResponse> AjustarContaAsync (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
             ApiResponse<AjusteFinanceiroResponse> localVarResponse = await AjustarContaAsyncWithHttpInfo(id, idTipoAjuste, dataAjuste, valorAjuste, login, identificadorExterno, idTransacaoOriginal, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Launch an adjust for the account of the informed ID This resource insert an adjust for the account of the informed ID
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTipoAjuste">Identifier Code of the adjustment type</param>
        /// <param name="dataAjuste">Date of the adjustment in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</param>
        /// <param name="valorAjuste">Value of the adjustment</param>
        /// <param name="login">login (optional)</param>
        /// <param name="identificadorExterno">Identifier External (optional)</param>
        /// <param name="idTransacaoOriginal">Original transaction identifier (optional)</param>
        /// <param name="idEstabelecimento">Store identifier when payment is made in store (optional)</param>
        /// <returns>Task of ApiResponse (AjusteFinanceiroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AjusteFinanceiroResponse>> AjustarContaAsyncWithHttpInfo (long? id, long? idTipoAjuste, string dataAjuste, double? valorAjuste, string login = null, string identificadorExterno = null, long? idTransacaoOriginal = null, long? idEstabelecimento = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AjustarConta");
            // verify the required parameter 'idTipoAjuste' is set
            if (idTipoAjuste == null) throw new ApiException(400, "Missing required parameter 'idTipoAjuste' when calling AjustarConta");
            // verify the required parameter 'dataAjuste' is set
            if (dataAjuste == null) throw new ApiException(400, "Missing required parameter 'dataAjuste' when calling AjustarConta");
            // verify the required parameter 'valorAjuste' is set
            if (valorAjuste == null) throw new ApiException(400, "Missing required parameter 'valorAjuste' when calling AjustarConta");
            
    
            var localVarPath = "/api/contas/{id}/ajustes-financeiros";
    
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
            
            if (idTipoAjuste != null) localVarQueryParams.Add("idTipoAjuste", Configuration.ApiClient.ParameterToString(idTipoAjuste)); // query parameter
            if (dataAjuste != null) localVarQueryParams.Add("dataAjuste", Configuration.ApiClient.ParameterToString(dataAjuste)); // query parameter
            if (valorAjuste != null) localVarQueryParams.Add("valorAjuste", Configuration.ApiClient.ParameterToString(valorAjuste)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            if (idTransacaoOriginal != null) localVarQueryParams.Add("idTransacaoOriginal", Configuration.ApiClient.ParameterToString(idTransacaoOriginal)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AjustarConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AjusteFinanceiroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AjusteFinanceiroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AjusteFinanceiroResponse)));
            
        }
        
        /// <summary>
        /// Update the product associated to the account the resource allows to make some modification of the product associated to the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>string</returns>
        public string AlterarProduto (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = AlterarProdutoWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the product associated to the account the resource allows to make some modification of the product associated to the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarProdutoWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AlterarProduto");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling AccountApi->AlterarProduto");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Update the product associated to the account the resource allows to make some modification of the product associated to the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarProdutoAsync (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<string> localVarResponse = await AlterarProdutoAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the product associated to the account the resource allows to make some modification of the product associated to the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarProdutoAsyncWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarProduto");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarProduto");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Update the account of a Personal holder This method allows to change the person of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idPessoa">Identification Code of a Person (id)</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarTitular (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarTitularWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the account of a Personal holder This method allows to change the person of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idPessoa">Identification Code of a Person (id)</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarTitularWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AlterarTitular");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AccountApi->AlterarTitular");
            
    
            var localVarPath = "/api/contas/{id}/alterar-titular";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Update the account of a Personal holder This method allows to change the person of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of a Person (id)</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarTitularAsync (long? id, long? idPessoa)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarTitularAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the account of a Personal holder This method allows to change the person of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of a Person (id)</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarTitularAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTitular");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AlterarTitular");
            
    
            var localVarPath = "/api/contas/{id}/alterar-titular";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTitular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Update the expiration of the invoices This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param> 
        /// <param name="novoDiaVencimento">New day of expiration</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AlterarVencimento (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = AlterarVencimentoWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the expiration of the invoices This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param> 
        /// <param name="novoDiaVencimento">New day of expiration</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AlterarVencimentoWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AlterarVencimento");
            
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null)
                throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling AccountApi->AlterarVencimento");
            
    
            var localVarPath = "/api/contas/{id}/alterar-vencimento";
    
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
            
            if (novoDiaVencimento != null) localVarQueryParams.Add("novo_dia_vencimento", Configuration.ApiClient.ParameterToString(novoDiaVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Update the expiration of the invoices This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="novoDiaVencimento">New day of expiration</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AlterarVencimentoAsync (long? id, int? novoDiaVencimento)
        {
             ApiResponse<ContaResponse> localVarResponse = await AlterarVencimentoAsyncWithHttpInfo(id, novoDiaVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the expiration of the invoices This resource allos to update the expiration for at most in 30 days after the current date  of a specific account on the PIER, respecting the parameter of intervalue among changments of the expiration informed by the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="novoDiaVencimento">New day of expiration</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AlterarVencimentoAsyncWithHttpInfo (long? id, int? novoDiaVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarVencimento");
            // verify the required parameter 'novoDiaVencimento' is set
            if (novoDiaVencimento == null) throw new ApiException(400, "Missing required parameter 'novoDiaVencimento' when calling AlterarVencimento");
            
    
            var localVarPath = "/api/contas/{id}/alterar-vencimento";
    
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
            
            if (novoDiaVencimento != null) localVarQueryParams.Add("novo_dia_vencimento", Configuration.ApiClient.ParameterToString(novoDiaVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarVencimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Attribute Annuity This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param> 
        /// <param name="idAnuidade">Identifier of annuity</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="DDD">DDD of the cell phone (optional)</param> 
        /// <param name="celular">Cell Phone Number (optional)</param> 
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param> 
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param> 
        /// <returns>Object</returns>
        public Object AtivarAnuidade (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = AtivarAnuidadeWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attribute Annuity This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param> 
        /// <param name="idAnuidade">Identifier of annuity</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="DDD">DDD of the cell phone (optional)</param> 
        /// <param name="celular">Cell Phone Number (optional)</param> 
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param> 
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarAnuidadeWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AtivarAnuidade");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AccountApi->AtivarAnuidade");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
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
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Attribute Annuity This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idAnuidade">Identifier of annuity</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD of the cell phone (optional)</param>
        /// <param name="celular">Cell Phone Number (optional)</param>
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param>
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarAnuidadeAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = await AtivarAnuidadeAsyncWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attribute Annuity This resource allows to configurate what Annuity rule will be attributed for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idAnuidade">Identifier of annuity</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD of the cell phone (optional)</param>
        /// <param name="celular">Cell Phone Number (optional)</param>
        /// <param name="idOperadora">Identifier of the Cell Phone Operator (optional)</param>
        /// <param name="idOrigemComercial">Identifier of the Commercial Origin (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarAnuidade");
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null) throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AtivarAnuidade");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
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
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Activate the sending service of invoice by email This resource activates the sending service of invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>Object</returns>
        public Object AtivarEnvioFaturaEmail (long? id)
        {
             ApiResponse<Object> localVarResponse = AtivarEnvioFaturaEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activate the sending service of invoice by email This resource activates the sending service of invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarEnvioFaturaEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AtivarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Activate the sending service of invoice by email This resource activates the sending service of invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await AtivarEnvioFaturaEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activate the sending service of invoice by email This resource activates the sending service of invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Performs partial account update This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param> 
        /// <param name="contaPartialUpdate">contaPartialUpdate</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse AtualizarParcial (long? id, ContaPartialUpdate contaPartialUpdate)
        {
             ApiResponse<ContaResponse> localVarResponse = AtualizarParcialWithHttpInfo(id, contaPartialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs partial account update This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param> 
        /// <param name="contaPartialUpdate">contaPartialUpdate</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > AtualizarParcialWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->AtualizarParcial");
            
            // verify the required parameter 'contaPartialUpdate' is set
            if (contaPartialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'contaPartialUpdate' when calling AccountApi->AtualizarParcial");
            
    
            var localVarPath = "/api/contas/{id}";
    
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
            
            
            
            
            if (contaPartialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPartialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPartialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Performs partial account update This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> AtualizarParcialAsync (long? id, ContaPartialUpdate contaPartialUpdate)
        {
             ApiResponse<ContaResponse> localVarResponse = await AtualizarParcialAsyncWithHttpInfo(id, contaPartialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs partial account update This feature allows you to perform partial account updating. This indicates that only the fields entered in the request will be updated, and the others will be ignored
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account identification code (id)</param>
        /// <param name="contaPartialUpdate">contaPartialUpdate</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> AtualizarParcialAsyncWithHttpInfo (long? id, ContaPartialUpdate contaPartialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcial");
            // verify the required parameter 'contaPartialUpdate' is set
            if (contaPartialUpdate == null) throw new ApiException(400, "Missing required parameter 'contaPartialUpdate' when calling AtualizarParcial");
            
    
            var localVarPath = "/api/contas/{id}";
    
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
            
            
            
            
            if (contaPartialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPartialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPartialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Block a determined account This method allows to block a determined account using de id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idStatus">Identification Code of the New Status Account</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse Bloquear (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = BloquearWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Block a determined account This method allows to block a determined account using de id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idStatus">Identification Code of the New Status Account</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > BloquearWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Bloquear");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling AccountApi->Bloquear");
            
    
            var localVarPath = "/api/contas/{id}/bloquear";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Block a determined account This method allows to block a determined account using de id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Identification Code of the New Status Account</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> BloquearAsync (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await BloquearAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Block a determined account This method allows to block a determined account using de id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Identification Code of the New Status Account</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> BloquearAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Bloquear");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling Bloquear");
            
    
            var localVarPath = "/api/contas/{id}/bloquear";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Registration payment enrollment on Saturday This resource allows you to register a payment membership on Saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        public AdesaoPagamentoSabadoResponse Cadastrar (long? id)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = CadastrarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registration payment enrollment on Saturday This resource allows you to register a payment membership on Saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        public ApiResponse< AdesaoPagamentoSabadoResponse > CadastrarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Cadastrar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }

        
        /// <summary>
        /// Registration payment enrollment on Saturday This resource allows you to register a payment membership on Saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> CadastrarAsync (long? id)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = await CadastrarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registration payment enrollment on Saturday This resource allows you to register a payment membership on Saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> CadastrarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cadastrar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }
        
        /// <summary>
        /// Do the cancellation of a determined account This method allows to do the cancellation of a determined account using the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idStatus">Idetification Code of the Account Status</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse Cancelar (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = CancelarWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Do the cancellation of a determined account This method allows to do the cancellation of a determined account using the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idStatus">Idetification Code of the Account Status</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > CancelarWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Cancelar");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling AccountApi->Cancelar");
            
    
            var localVarPath = "/api/contas/{id}/cancelar";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Do the cancellation of a determined account This method allows to do the cancellation of a determined account using the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Idetification Code of the Account Status</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> CancelarAsync (long? id, long? idStatus)
        {
             ApiResponse<ContaResponse> localVarResponse = await CancelarAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Do the cancellation of a determined account This method allows to do the cancellation of a determined account using the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idStatus">Idetification Code of the Account Status</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> CancelarAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cancelar");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling Cancelar");
            
    
            var localVarPath = "/api/contas/{id}/cancelar";
    
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
            
            if (idStatus != null) localVarQueryParams.Add("id_status", Configuration.ApiClient.ParameterToString(idStatus)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Find an adhesion of payment on saturday This resource allows you to find an adhesion of payment on saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param> 
        /// <param name="dataVencimento">Adhesion due date</param> 
        /// <returns>AdesaoPagamentoSabadoResponse</returns>
        public AdesaoPagamentoSabadoResponse Consultar (long? id, string dataVencimento)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = ConsultarWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find an adhesion of payment on saturday This resource allows you to find an adhesion of payment on saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param> 
        /// <param name="dataVencimento">Adhesion due date</param> 
        /// <returns>ApiResponse of AdesaoPagamentoSabadoResponse</returns>
        public ApiResponse< AdesaoPagamentoSabadoResponse > ConsultarWithHttpInfo (long? id, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Consultar");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling AccountApi->Consultar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }

        
        /// <summary>
        /// Find an adhesion of payment on saturday This resource allows you to find an adhesion of payment on saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param>
        /// <param name="dataVencimento">Adhesion due date</param>
        /// <returns>Task of AdesaoPagamentoSabadoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPagamentoSabadoResponse> ConsultarAsync (long? id, string dataVencimento)
        {
             ApiResponse<AdesaoPagamentoSabadoResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find an adhesion of payment on saturday This resource allows you to find an adhesion of payment on saturday
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account id</param>
        /// <param name="dataVencimento">Adhesion due date</param>
        /// <returns>Task of ApiResponse (AdesaoPagamentoSabadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPagamentoSabadoResponse>> ConsultarAsyncWithHttpInfo (long? id, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling Consultar");
            
    
            var localVarPath = "/api/adesoes-pagamentos-sabados";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPagamentoSabadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPagamentoSabadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPagamentoSabadoResponse)));
            
        }
        
        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>BeneficioPagamentoAtrasoResponse</returns>
        public BeneficioPagamentoAtrasoResponse ConsultarBeneficioPagamentoAtraso (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = ConsultarBeneficioPagamentoAtrasoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>ApiResponse of BeneficioPagamentoAtrasoResponse</returns>
        public ApiResponse< BeneficioPagamentoAtrasoResponse > ConsultarBeneficioPagamentoAtrasoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ConsultarBeneficioPagamentoAtraso");
            
    
            var localVarPath = "/api/contas/{id}/consultar-beneficio-pagamento-atraso";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }

        
        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of BeneficioPagamentoAtrasoResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioPagamentoAtrasoResponse> ConsultarBeneficioPagamentoAtrasoAsync (long? id)
        {
             ApiResponse<BeneficioPagamentoAtrasoResponse> localVarResponse = await ConsultarBeneficioPagamentoAtrasoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show the deadline for payment of the invoice in debt to recieve the benefit This method allows to retrieve if the client has the right to the benefit of the late payment, at the store, until the Saturday subsequent the deadline, being isent of penalty, fees, extra percentual taxe for late payment and IOF
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (BeneficioPagamentoAtrasoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioPagamentoAtrasoResponse>> ConsultarBeneficioPagamentoAtrasoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBeneficioPagamentoAtraso");
            
    
            var localVarPath = "/api/contas/{id}/consultar-beneficio-pagamento-atraso";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficioPagamentoAtraso: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioPagamentoAtrasoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioPagamentoAtrasoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioPagamentoAtrasoResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the dates of a determined invoice slip this resource retrieves an invoice slip
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse ConsultarBoletoEmitido (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = ConsultarBoletoEmitidoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the dates of a determined invoice slip this resource retrieves an invoice slip
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > ConsultarBoletoEmitidoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ConsultarBoletoEmitido");
            
    
            var localVarPath = "/api/contas/{id}/consultar-dados-pagamento-fatura";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the dates of a determined invoice slip this resource retrieves an invoice slip
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> ConsultarBoletoEmitidoAsync (long? id)
        {
             ApiResponse<BoletoResponse> localVarResponse = await ConsultarBoletoEmitidoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the dates of a determined invoice slip this resource retrieves an invoice slip
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> ConsultarBoletoEmitidoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBoletoEmitido");
            
    
            var localVarPath = "/api/contas/{id}/consultar-dados-pagamento-fatura";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBoletoEmitido: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the updated debt of the client This resource retrieves the updated debt of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Date of expiration (optional)</param> 
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param> 
        /// <returns>DividaClienteResponse</returns>
        public DividaClienteResponse ConsultarDividaAtualizadaCliente (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = ConsultarDividaAtualizadaClienteWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the updated debt of the client This resource retrieves the updated debt of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Date of expiration (optional)</param> 
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param> 
        /// <returns>ApiResponse of DividaClienteResponse</returns>
        public ApiResponse< DividaClienteResponse > ConsultarDividaAtualizadaClienteWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ConsultarDividaAtualizadaCliente");
            
    
            var localVarPath = "/api/contas/{id}/recuperar-divida-atualizada";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the updated debt of the client This resource retrieves the updated debt of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration (optional)</param>
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param>
        /// <returns>Task of DividaClienteResponse</returns>
        public async System.Threading.Tasks.Task<DividaClienteResponse> ConsultarDividaAtualizadaClienteAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
             ApiResponse<DividaClienteResponse> localVarResponse = await ConsultarDividaAtualizadaClienteAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, idEscritorioCobranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the updated debt of the client This resource retrieves the updated debt of the client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration (optional)</param>
        /// <param name="idEscritorioCobranca">Identification Code of the billing office (optional)</param>
        /// <returns>Task of ApiResponse (DividaClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DividaClienteResponse>> ConsultarDividaAtualizadaClienteAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, long? idEscritorioCobranca = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDividaAtualizadaCliente");
            
    
            var localVarPath = "/api/contas/{id}/recuperar-divida-atualizada";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (idEscritorioCobranca != null) localVarQueryParams.Add("idEscritorioCobranca", Configuration.ApiClient.ParameterToString(idEscritorioCobranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDividaAtualizadaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DividaClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividaClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividaClienteResponse)));
            
        }
        
        /// <summary>
        /// Retrieves a processed transaction for an account. This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param> 
        /// <param name="idTransacao">Identification code of the Transaction (id).</param> 
        /// <returns>TransacoesCorrentesResponse</returns>
        public TransacoesCorrentesResponse ConsultarProcessada (long? id, long? idTransacao)
        {
             ApiResponse<TransacoesCorrentesResponse> localVarResponse = ConsultarProcessadaWithHttpInfo(id, idTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a processed transaction for an account. This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param> 
        /// <param name="idTransacao">Identification code of the Transaction (id).</param> 
        /// <returns>ApiResponse of TransacoesCorrentesResponse</returns>
        public ApiResponse< TransacoesCorrentesResponse > ConsultarProcessadaWithHttpInfo (long? id, long? idTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ConsultarProcessada");
            
            // verify the required parameter 'idTransacao' is set
            if (idTransacao == null)
                throw new ApiException(400, "Missing required parameter 'idTransacao' when calling AccountApi->ConsultarProcessada");
            
    
            var localVarPath = "/api/contas/{id}/transacoes-processadas/{idTransacao}";
    
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
            if (idTransacao != null) localVarPathParams.Add("idTransacao", Configuration.ApiClient.ParameterToString(idTransacao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacoesCorrentesResponse)));
            
        }

        
        /// <summary>
        /// Retrieves a processed transaction for an account. This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param>
        /// <param name="idTransacao">Identification code of the Transaction (id).</param>
        /// <returns>Task of TransacoesCorrentesResponse</returns>
        public async System.Threading.Tasks.Task<TransacoesCorrentesResponse> ConsultarProcessadaAsync (long? id, long? idTransacao)
        {
             ApiResponse<TransacoesCorrentesResponse> localVarResponse = await ConsultarProcessadaAsyncWithHttpInfo(id, idTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a processed transaction for an account. This resource allows to retrieve the details of a processed transaction belonging to an account.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id).</param>
        /// <param name="idTransacao">Identification code of the Transaction (id).</param>
        /// <returns>Task of ApiResponse (TransacoesCorrentesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacoesCorrentesResponse>> ConsultarProcessadaAsyncWithHttpInfo (long? id, long? idTransacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarProcessada");
            // verify the required parameter 'idTransacao' is set
            if (idTransacao == null) throw new ApiException(400, "Missing required parameter 'idTransacao' when calling ConsultarProcessada");
            
    
            var localVarPath = "/api/contas/{id}/transacoes-processadas/{idTransacao}";
    
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
            if (idTransacao != null) localVarPathParams.Add("idTransacao", Configuration.ApiClient.ParameterToString(idTransacao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProcessada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacoesCorrentesResponse)));
            
        }
        
        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTaxasRefinanciamentoResponse</returns>
        public PageTaxasRefinanciamentoResponse ConsultarTaxasTarifas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = ConsultarTaxasTarifasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTaxasRefinanciamentoResponse</returns>
        public ApiResponse< PageTaxasRefinanciamentoResponse > ConsultarTaxasTarifasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ConsultarTaxasTarifas");
            
    
            var localVarPath = "/api/contas/{id}/consultar-taxas-tarifas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }

        
        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTaxasRefinanciamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTaxasRefinanciamentoResponse> ConsultarTaxasTarifasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTaxasRefinanciamentoResponse> localVarResponse = await ConsultarTaxasTarifasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to retrieve using the IDAccount fees and rates This operation has as an aim to allow the Issuers retrieve the taxes and rates of the account. Esta opera??o tem como objetivo permitir que os Emissores consultem as taxas e tarifas da conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the account to be retrieved</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTaxasRefinanciamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTaxasRefinanciamentoResponse>> ConsultarTaxasTarifasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasTarifas");
            
    
            var localVarPath = "/api/contas/{id}/consultar-taxas-tarifas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasTarifas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTaxasRefinanciamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTaxasRefinanciamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTaxasRefinanciamentoResponse)));
            
        }
        
        /// <summary>
        /// Displays data for a particular function type for accounts This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param> 
        /// <returns>string</returns>
        public string Consultar_0 (int? id)
        {
             ApiResponse<string> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Displays data for a particular function type for accounts This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > Consultar_0WithHttpInfo (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Consultar_0");
            
    
            var localVarPath = "/api/contas/tipos-funcoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Displays data for a particular function type for accounts This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> Consultar_0Async (int? id)
        {
             ApiResponse<string> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Displays data for a particular function type for accounts This method allows you to query data from a particular function type for accounts from your identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the function type for accounts (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> Consultar_0AsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/contas/tipos-funcoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Show dates of a determined account This method allows to retrieve dates of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>ContaDetalheResponse</returns>
        public ContaDetalheResponse Consultar_1 (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show dates of a determined account This method allows to retrieve dates of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>ApiResponse of ContaDetalheResponse</returns>
        public ApiResponse< ContaDetalheResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Consultar_1");
            
    
            var localVarPath = "/api/contas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Show dates of a determined account This method allows to retrieve dates of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ContaDetalheResponse> Consultar_1Async (long? id)
        {
             ApiResponse<ContaDetalheResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show dates of a determined account This method allows to retrieve dates of a determined account using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (ContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_1");
            
    
            var localVarPath = "/api/contas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the details of a determined transfer This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse Consultar_2 (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = Consultar_2WithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the details of a determined transfer This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > Consultar_2WithHttpInfo (long? id, long? idTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Consultar_2");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling AccountApi->Consultar_2");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes/{id_transferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("id_transferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the details of a determined transfer This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> Consultar_2Async (long? id, long? idTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await Consultar_2AsyncWithHttpInfo(id, idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the details of a determined transfer This method allowst to retrieve the details of a determined credit transfer made among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id_transfer)</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id, long? idTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_2");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling Consultar_2");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes/{id_transferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("id_transferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ContaMultiAppResponse</returns>
        public ContaMultiAppResponse CriarContasMultiApp (CountMultiAppPersist contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = CriarContasMultiAppWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param> 
        /// <returns>ApiResponse of ContaMultiAppResponse</returns>
        public ApiResponse< ContaMultiAppResponse > CriarContasMultiAppWithHttpInfo (CountMultiAppPersist contaMultiAppPersist)
        {
            
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling AccountApi->CriarContasMultiApp");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
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
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }

        
        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ContaMultiAppResponse</returns>
        public async System.Threading.Tasks.Task<ContaMultiAppResponse> CriarContasMultiAppAsync (CountMultiAppPersist contaMultiAppPersist)
        {
             ApiResponse<ContaMultiAppResponse> localVarResponse = await CriarContasMultiAppAsyncWithHttpInfo(contaMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Register accounts MultiApp This feature allows you to register accounts MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaMultiAppPersist">contaMultiAppPersist</param>
        /// <returns>Task of ApiResponse (ContaMultiAppResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaMultiAppResponse>> CriarContasMultiAppAsyncWithHttpInfo (CountMultiAppPersist contaMultiAppPersist)
        {
            // verify the required parameter 'contaMultiAppPersist' is set
            if (contaMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'contaMultiAppPersist' when calling CriarContasMultiApp");
            
    
            var localVarPath = "/api/contas/cadastrar-conta-multiapp";
    
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
            
            
            
            
            if (contaMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarContasMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaMultiAppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaMultiAppResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaMultiAppResponse)));
            
        }
        
        /// <summary>
        /// Disable the service of sending the invoice by email This resorurce desables the service of sending the invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>Object</returns>
        public Object DesativarEnvioFaturaEmail (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarEnvioFaturaEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable the service of sending the invoice by email This resorurce desables the service of sending the invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarEnvioFaturaEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->DesativarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Disable the service of sending the invoice by email This resorurce desables the service of sending the invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarEnvioFaturaEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable the service of sending the invoice by email This resorurce desables the service of sending the invoice by email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Create a slip of recharge This resource creates a slip of recharge
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param> 
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse GerarBoletoRecarga (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoRecargaWithHttpInfo(id, valor, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a slip of recharge This resource creates a slip of recharge
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param> 
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > GerarBoletoRecargaWithHttpInfo (long? id, double? valor, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->GerarBoletoRecarga");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling AccountApi->GerarBoletoRecarga");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling AccountApi->GerarBoletoRecarga");
            
    
            var localVarPath = "/api/contas/{id}/gerar-boleto-recarga";
    
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
            
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Create a slip of recharge This resource creates a slip of recharge
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param>
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoRecargaAsync (long? id, double? valor, string dataVencimento)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoRecargaAsyncWithHttpInfo(id, valor, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a slip of recharge This resource creates a slip of recharge
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="valor">Attribute that represents the value of the bank slip issued</param>
        /// <param name="dataVencimento">Attribute that represents the expiration date of the bank slip</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoRecargaAsyncWithHttpInfo (long? id, double? valor, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoRecarga");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling GerarBoletoRecarga");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GerarBoletoRecarga");
            
    
            var localVarPath = "/api/contas/{id}/gerar-boleto-recarga";
    
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
            
            if (valor != null) localVarQueryParams.Add("valor", Configuration.ApiClient.ParameterToString(valor)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoRecarga: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Create a new card for printing This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idPessoa">Identification Code of the person (id)</param> 
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartao (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new card for printing This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idPessoa">Identification Code of the person (id)</param> 
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->GerarCartao");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AccountApi->GerarCartao");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{id_pessoa}/gerar-cartao";
    
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
            if (idPessoa != null) localVarPathParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            if (idTipoPlastico != null) localVarQueryParams.Add("id_tipo_plastico", Configuration.ApiClient.ParameterToString(idTipoPlastico)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Create a new card for printing This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the person (id)</param>
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoAsync (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoAsyncWithHttpInfo(id, idPessoa, idTipoPlastico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new card for printing This resource allows to be created a new card for a determined cardholder that it is linked to the account. For this, it will be necessary inform the id code (id), the IdPersonal of the cardholder and the idPlastictype of the Card that must be created for printing. This functionability will be used to print the cards in stores, kiosks, offices, auto-service attendance, or other places that the Issuer chooses, but it is obligated to have Card Printer to make them, in local
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the person (id)</param>
        /// <param name="idTipoPlastico">Identification Code of the TypePlastic (id) (optional)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoAsyncWithHttpInfo (long? id, long? idPessoa, long? idTipoPlastico = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartao");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GerarCartao");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{id_pessoa}/gerar-cartao";
    
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
            if (idPessoa != null) localVarPathParams.Add("id_pessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            if (idTipoPlastico != null) localVarQueryParams.Add("id_tipo_plastico", Configuration.ApiClient.ParameterToString(idTipoPlastico)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Do the sending for the generation of a new card in graphic This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>CartaoEmbossingResponse</returns>
        public CartaoEmbossingResponse GerarCartaoEmbossing (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = GerarCartaoEmbossingWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Do the sending for the generation of a new card in graphic This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param> 
        /// <returns>ApiResponse of CartaoEmbossingResponse</returns>
        public ApiResponse< CartaoEmbossingResponse > GerarCartaoEmbossingWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->GerarCartaoEmbossing");
            
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null)
                throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling AccountApi->GerarCartaoEmbossing");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-grafica";
    
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
            
            
            
            
            if (cartaoEmbossingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoEmbossingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoEmbossingRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }

        
        /// <summary>
        /// Do the sending for the generation of a new card in graphic This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of CartaoEmbossingResponse</returns>
        public async System.Threading.Tasks.Task<CartaoEmbossingResponse> GerarCartaoEmbossingAsync (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
             ApiResponse<CartaoEmbossingResponse> localVarResponse = await GerarCartaoEmbossingAsyncWithHttpInfo(id, cartaoEmbossingRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Do the sending for the generation of a new card in graphic This resource allows to be generate a new Card for a determined cardholder that it is linked to the account. For this, it&#39;ll be necesseary to inform the id code of the account (id), the idPersonal of the cardholder and the idPlasticType of the card that will be printed. This functionality will be used for the cad printing in graphic
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="cartaoEmbossingRequest">cartaoEmbossingRequest</param>
        /// <returns>Task of ApiResponse (CartaoEmbossingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoEmbossingResponse>> GerarCartaoEmbossingAsyncWithHttpInfo (long? id, CartaoEmbossingRequest cartaoEmbossingRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoEmbossing");
            // verify the required parameter 'cartaoEmbossingRequest' is set
            if (cartaoEmbossingRequest == null) throw new ApiException(400, "Missing required parameter 'cartaoEmbossingRequest' when calling GerarCartaoEmbossing");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-grafica";
    
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
            
            
            
            
            if (cartaoEmbossingRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoEmbossingRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoEmbossingRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoEmbossing: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoEmbossingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoEmbossingResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoEmbossingResponse)));
            
        }
        
        /// <summary>
        /// Create a provisory card This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>CartaoImpressaoProvisorioResponse</returns>
        public CartaoImpressaoProvisorioResponse GerarCartaoProvisorio (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = GerarCartaoProvisorioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a provisory card This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <returns>ApiResponse of CartaoImpressaoProvisorioResponse</returns>
        public ApiResponse< CartaoImpressaoProvisorioResponse > GerarCartaoProvisorioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->GerarCartaoProvisorio");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-provisorio";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }

        
        /// <summary>
        /// Create a provisory card This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of CartaoImpressaoProvisorioResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoProvisorioResponse> GerarCartaoProvisorioAsync (long? id)
        {
             ApiResponse<CartaoImpressaoProvisorioResponse> localVarResponse = await GerarCartaoProvisorioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a provisory card This resource allows to be created a provisory card to a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoProvisorioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoProvisorioResponse>> GerarCartaoProvisorioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoProvisorio");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-provisorio";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoProvisorio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoProvisorioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoProvisorioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoProvisorioResponse)));
            
        }
        
        /// <summary>
        /// Create a virtual card This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataValidade">Expiration date</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarCartaoVirtual (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarCartaoVirtualWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a virtual card This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataValidade">Expiration date</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarCartaoVirtualWithHttpInfo (long? id, string dataValidade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->GerarCartaoVirtual");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling AccountApi->GerarCartaoVirtual");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-virtual";
    
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
            
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Create a virtual card This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataValidade">Expiration date</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarCartaoVirtualAsync (long? id, string dataValidade)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarCartaoVirtualAsyncWithHttpInfo(id, dataValidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a virtual card This resource allows to be created a virtual card for a determined cardholder which one it is linked to an account. For this, it will be necessary to inform the identification code of the account (id). This functionability can be used to creat virtual cards through an App
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataValidade">Expiration date</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarCartaoVirtualAsyncWithHttpInfo (long? id, string dataValidade)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarCartaoVirtual");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling GerarCartaoVirtual");
            
    
            var localVarPath = "/api/contas/{id}/gerar-cartao-virtual";
    
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
            
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarCartaoVirtual: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// List existent accounts in the database of the Issuer This resource allows to list existent accounts in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param> 
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param> 
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param> 
        /// <param name="diaVencimento">List the day of expiration (optional)</param> 
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param> 
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param> 
        /// <param name="dataCadastro">List the date that the card was created (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param> 
        /// <param name="funcaoAtiva"> (optional)</param> 
        /// <returns>PageContaResponse</returns>
        public PageContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento, funcaoAtiva);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List existent accounts in the database of the Issuer This resource allows to list existent accounts in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param> 
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param> 
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param> 
        /// <param name="diaVencimento">List the day of expiration (optional)</param> 
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param> 
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param> 
        /// <param name="dataCadastro">List the date that the card was created (optional)</param> 
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param> 
        /// <param name="funcaoAtiva"> (optional)</param> 
        /// <returns>ApiResponse of PageContaResponse</returns>
        public ApiResponse< PageContaResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
        {
            
    
            var localVarPath = "/api/contas";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idStatusConta != null) localVarQueryParams.Add("idStatusConta", Configuration.ApiClient.ParameterToString(idStatusConta)); // query parameter
            if (diaVencimento != null) localVarQueryParams.Add("diaVencimento", Configuration.ApiClient.ParameterToString(diaVencimento)); // query parameter
            if (melhorDiaCompra != null) localVarQueryParams.Add("melhorDiaCompra", Configuration.ApiClient.ParameterToString(melhorDiaCompra)); // query parameter
            if (dataStatusConta != null) localVarQueryParams.Add("dataStatusConta", Configuration.ApiClient.ParameterToString(dataStatusConta)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataUltimaAlteracaoVencimento != null) localVarQueryParams.Add("dataUltimaAlteracaoVencimento", Configuration.ApiClient.ParameterToString(dataUltimaAlteracaoVencimento)); // query parameter
            if (funcaoAtiva != null) localVarQueryParams.Add("funcaoAtiva", Configuration.ApiClient.ParameterToString(funcaoAtiva)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }

        
        /// <summary>
        /// List existent accounts in the database of the Issuer This resource allows to list existent accounts in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param>
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param>
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param>
        /// <param name="diaVencimento">List the day of expiration (optional)</param>
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param>
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param>
        /// <param name="dataCadastro">List the date that the card was created (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of PageContaResponse</returns>
        public async System.Threading.Tasks.Task<PageContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
        {
             ApiResponse<PageContaResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idProduto, idOrigemComercial, idPessoa, idStatusConta, diaVencimento, melhorDiaCompra, dataStatusConta, dataCadastro, dataUltimaAlteracaoVencimento, funcaoAtiva);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List existent accounts in the database of the Issuer This resource allows to list existent accounts in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the product which the account takes part (id) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of Commercial Origin (id) that gave origin to the Account (optional)</param>
        /// <param name="idPessoa">Identification Code of the Personal holder of the Account (id) (optional)</param>
        /// <param name="idStatusConta">Identification Code of the Account Status (optional)</param>
        /// <param name="diaVencimento">List the day of expiration (optional)</param>
        /// <param name="melhorDiaCompra">List the best shopping day (optional)</param>
        /// <param name="dataStatusConta">List the date that the current idStatusAccount atual was attributed for it (optional)</param>
        /// <param name="dataCadastro">List the date that the card was created (optional)</param>
        /// <param name="dataUltimaAlteracaoVencimento">List the date of the last update of the expiration (optional)</param>
        /// <param name="funcaoAtiva"> (optional)</param>
        /// <returns>Task of ApiResponse (PageContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOrigemComercial = null, long? idPessoa = null, long? idStatusConta = null, int? diaVencimento = null, int? melhorDiaCompra = null, string dataStatusConta = null, string dataCadastro = null, string dataUltimaAlteracaoVencimento = null, string funcaoAtiva = null)
        {
            
    
            var localVarPath = "/api/contas";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idStatusConta != null) localVarQueryParams.Add("idStatusConta", Configuration.ApiClient.ParameterToString(idStatusConta)); // query parameter
            if (diaVencimento != null) localVarQueryParams.Add("diaVencimento", Configuration.ApiClient.ParameterToString(diaVencimento)); // query parameter
            if (melhorDiaCompra != null) localVarQueryParams.Add("melhorDiaCompra", Configuration.ApiClient.ParameterToString(melhorDiaCompra)); // query parameter
            if (dataStatusConta != null) localVarQueryParams.Add("dataStatusConta", Configuration.ApiClient.ParameterToString(dataStatusConta)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataUltimaAlteracaoVencimento != null) localVarQueryParams.Add("dataUltimaAlteracaoVencimento", Configuration.ApiClient.ParameterToString(dataUltimaAlteracaoVencimento)); // query parameter
            if (funcaoAtiva != null) localVarQueryParams.Add("funcaoAtiva", Configuration.ApiClient.ParameterToString(funcaoAtiva)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaResponse)));
            
        }
        
        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoEventosResponse</returns>
        public PageHistoricoEventosResponse ListarHistoricoAlteracoesLimites (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = ListarHistoricoAlteracoesLimitesWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEventosResponse</returns>
        public ApiResponse< PageHistoricoEventosResponse > ListarHistoricoAlteracoesLimitesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ListarHistoricoAlteracoesLimites");
            
    
            var localVarPath = "/api/contas/{id}/historicos-alteracoes-limites";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }

        
        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoEventosResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEventosResponse> ListarHistoricoAlteracoesLimitesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoEventosResponse> localVarResponse = await ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the historic of updatings of the Account limit This resource retrieves the historic with the updatings of the Account limit informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEventosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEventosResponse>> ListarHistoricoAlteracoesLimitesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAlteracoesLimites");
            
    
            var localVarPath = "/api/contas/{id}/historicos-alteracoes-limites";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAlteracoesLimites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEventosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEventosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEventosResponse)));
            
        }
        
        /// <summary>
        /// List the historic of in/out  of advisories of collection Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoAssessoriaResponse</returns>
        public PageHistoricoAssessoriaResponse ListarHistoricoAssessoria (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = ListarHistoricoAssessoriaWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the historic of in/out  of advisories of collection Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAssessoriaResponse</returns>
        public ApiResponse< PageHistoricoAssessoriaResponse > ListarHistoricoAssessoriaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ListarHistoricoAssessoria");
            
    
            var localVarPath = "/api/contas/{id}/historicos-assessorias-cobranca";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }

        
        /// <summary>
        /// List the historic of in/out  of advisories of collection Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAssessoriaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAssessoriaResponse> ListarHistoricoAssessoriaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAssessoriaResponse> localVarResponse = await ListarHistoricoAssessoriaAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the historic of in/out  of advisories of collection Allow to list all the register of in and out of the Account in files of integration with consulting collection firms through the idcode of the account(idAccount)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAssessoriaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAssessoriaResponse>> ListarHistoricoAssessoriaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAssessoria");
            
    
            var localVarPath = "/api/contas/{id}/historicos-assessorias-cobranca";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAssessoria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAssessoriaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAssessoriaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAssessoriaResponse)));
            
        }
        
        /// <summary>
        /// List the historic of late invoices This resource lists the historic the late invoice payments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageHistoricoAtrasoFaturaResponse</returns>
        public PageHistoricoAtrasoFaturaResponse ListarHistoricoAtrasosFaturas (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = ListarHistoricoAtrasosFaturasWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the historic of late invoices This resource lists the historic the late invoice payments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoAtrasoFaturaResponse</returns>
        public ApiResponse< PageHistoricoAtrasoFaturaResponse > ListarHistoricoAtrasosFaturasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ListarHistoricoAtrasosFaturas");
            
    
            var localVarPath = "/api/contas/{id}/historicos-faturas-atrasos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }

        
        /// <summary>
        /// List the historic of late invoices This resource lists the historic the late invoice payments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageHistoricoAtrasoFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoAtrasoFaturaResponse> ListarHistoricoAtrasosFaturasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageHistoricoAtrasoFaturaResponse> localVarResponse = await ListarHistoricoAtrasosFaturasAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the historic of late invoices This resource lists the historic the late invoice payments
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoAtrasoFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoAtrasoFaturaResponse>> ListarHistoricoAtrasosFaturasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoAtrasosFaturas");
            
    
            var localVarPath = "/api/contas/{id}/historicos-faturas-atrasos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoAtrasosFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoAtrasoFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoAtrasoFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoAtrasoFaturaResponse)));
            
        }
        
        /// <summary>
        /// List the transactions unprocessed of the account This method allows to be listed all the transactions unprocessed of the Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param> 
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param> 
        /// <returns>PageTransacaoNaoProcessadaResponse</returns>
        public PageTransacaoNaoProcessadaResponse ListarNaoProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = ListarNaoProcessadasWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the transactions unprocessed of the account This method allows to be listed all the transactions unprocessed of the Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param> 
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoNaoProcessadaResponse > ListarNaoProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ListarNaoProcessadas");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-nao-processadas";
    
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
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// List the transactions unprocessed of the account This method allows to be listed all the transactions unprocessed of the Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param>
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param>
        /// <returns>Task of PageTransacaoNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoNaoProcessadaResponse> ListarNaoProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
             ApiResponse<PageTransacaoNaoProcessadaResponse> localVarResponse = await ListarNaoProcessadasAsyncWithHttpInfo(id, sort, page, limit, dataInicio, dataFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the transactions unprocessed of the account This method allows to be listed all the transactions unprocessed of the Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Parameter ignored if the Ending date is not set) (optional)</param>
        /// <param name="dataFim">Date of ending of the bank statement retrievement in the format yyyy-MM-dd  (Parameter ignored if the Beginning date is not set) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoNaoProcessadaResponse>> ListarNaoProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataInicio = null, string dataFim = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarNaoProcessadas");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-nao-processadas";
    
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
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaoProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// List of the transactions processed of the account This method allows to be listed all the transactions processed of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="idTipoTransacao">Transaction Type (optional)</param> 
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param> 
        /// <returns>PageTransacoesCorrentesResponse</returns>
        public PageTransacoesCorrentesResponse ListarProcessadas (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = ListarProcessadasWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, recuperaEncargos);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of the transactions processed of the account This method allows to be listed all the transactions processed of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="idTipoTransacao">Transaction Type (optional)</param> 
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param> 
        /// <returns>ApiResponse of PageTransacoesCorrentesResponse</returns>
        public ApiResponse< PageTransacoesCorrentesResponse > ListarProcessadasWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->ListarProcessadas");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-processadas";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (recuperaEncargos != null) localVarQueryParams.Add("recuperaEncargos", Configuration.ApiClient.ParameterToString(recuperaEncargos)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }

        
        /// <summary>
        /// List of the transactions processed of the account This method allows to be listed all the transactions processed of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param>
        /// <returns>Task of PageTransacoesCorrentesResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacoesCorrentesResponse> ListarProcessadasAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
             ApiResponse<PageTransacoesCorrentesResponse> localVarResponse = await ListarProcessadasAsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, recuperaEncargos);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of the transactions processed of the account This method allows to be listed all the transactions processed of the account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="recuperaEncargos">Add the interest transactions in the query (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacoesCorrentesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacoesCorrentesResponse>> ListarProcessadasAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, int? recuperaEncargos = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarProcessadas");
            
    
            var localVarPath = "/api/contas/{id}/transacoes/listar-processadas";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (recuperaEncargos != null) localVarQueryParams.Add("recuperaEncargos", Configuration.ApiClient.ParameterToString(recuperaEncargos)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProcessadas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacoesCorrentesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacoesCorrentesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacoesCorrentesResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string Listar_0 ()
        {
             ApiResponse<string> localVarResponse = Listar_0WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > Listar_0WithHttpInfo ()
        {
            
    
            var localVarPath = "/api/contas/tipos-funcoes";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> Listar_0Async ()
        {
             ApiResponse<string> localVarResponse = await Listar_0AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de fun\u00E7\u00F5es para contas do Emissor This feature allows you to list the types of roles for the Issuer&#39;s accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> Listar_0AsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/contas/tipos-funcoes";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Lists unprocessed and processed account transactions This method allows all unprocessed and processed transactions in the Account to be listed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="idTipoTransacao">Transaction Type (optional)</param> 
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param> 
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param> 
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param> 
        /// <param name="status">Transaction Status (optional)</param> 
        /// <param name="plano">Transaction plan (optional)</param> 
        /// <param name="codigoMCC">MCC transaction code (optional)</param> 
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param> 
        /// <returns>PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public PageTransacaoProcessadaNaoProcessadaResponse Listar_1 (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
             ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> localVarResponse = Listar_1WithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, flagCredito, flagFaturado, flagProcessada, status, plano, codigoMCC, grupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists unprocessed and processed account transactions This method allows all unprocessed and processed transactions in the Account to be listed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param> 
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param> 
        /// <param name="idTipoTransacao">Transaction Type (optional)</param> 
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param> 
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param> 
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param> 
        /// <param name="status">Transaction Status (optional)</param> 
        /// <param name="plano">Transaction plan (optional)</param> 
        /// <param name="codigoMCC">MCC transaction code (optional)</param> 
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public ApiResponse< PageTransacaoProcessadaNaoProcessadaResponse > Listar_1WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Listar_1");
            
    
            var localVarPath = "/api/contas/{id}/transacoes";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (flagCredito != null) localVarQueryParams.Add("flagCredito", Configuration.ApiClient.ParameterToString(flagCredito)); // query parameter
            if (flagFaturado != null) localVarQueryParams.Add("flagFaturado", Configuration.ApiClient.ParameterToString(flagFaturado)); // query parameter
            if (flagProcessada != null) localVarQueryParams.Add("flagProcessada", Configuration.ApiClient.ParameterToString(flagProcessada)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plano != null) localVarQueryParams.Add("plano", Configuration.ApiClient.ParameterToString(plano)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            if (grupoMCC != null) localVarQueryParams.Add("grupoMCC", Configuration.ApiClient.ParameterToString(grupoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoProcessadaNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoProcessadaNaoProcessadaResponse)));
            
        }

        
        /// <summary>
        /// Lists unprocessed and processed account transactions This method allows all unprocessed and processed transactions in the Account to be listed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param>
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param>
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param>
        /// <param name="status">Transaction Status (optional)</param>
        /// <param name="plano">Transaction plan (optional)</param>
        /// <param name="codigoMCC">MCC transaction code (optional)</param>
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param>
        /// <returns>Task of PageTransacaoProcessadaNaoProcessadaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoProcessadaNaoProcessadaResponse> Listar_1Async (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
             ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(id, sort, page, limit, dataVencimento, dataInicio, dataFim, idTipoTransacao, flagCredito, flagFaturado, flagProcessada, status, plano, codigoMCC, grupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists unprocessed and processed account transactions This method allows all unprocessed and processed transactions in the Account to be listed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Date of expiration of the bank statement in the format yyyy-MM-dd (optional)</param>
        /// <param name="dataInicio">Date of beginning of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="dataFim">Date of Ending of the bank statement retrievement in the format yyyy-MM-dd (Ignored when the parameter dateExpiration is used) (optional)</param>
        /// <param name="idTipoTransacao">Transaction Type (optional)</param>
        /// <param name="flagCredito">Flag that indicates whether the transaction is credit (optional)</param>
        /// <param name="flagFaturado">Flag indicating whether the transaction was billed (optional)</param>
        /// <param name="flagProcessada">Flag indicating whether the transaction was processed (optional)</param>
        /// <param name="status">Transaction Status (optional)</param>
        /// <param name="plano">Transaction plan (optional)</param>
        /// <param name="codigoMCC">MCC transaction code (optional)</param>
        /// <param name="grupoMCC">Transaction MCC Group (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoProcessadaNaoProcessadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>> Listar_1AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataInicio = null, string dataFim = null, long? idTipoTransacao = null, bool? flagCredito = null, bool? flagFaturado = null, bool? flagProcessada = null, int? status = null, int? plano = null, long? codigoMCC = null, long? grupoMCC = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_1");
            
    
            var localVarPath = "/api/contas/{id}/transacoes";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataInicio != null) localVarQueryParams.Add("dataInicio", Configuration.ApiClient.ParameterToString(dataInicio)); // query parameter
            if (dataFim != null) localVarQueryParams.Add("dataFim", Configuration.ApiClient.ParameterToString(dataFim)); // query parameter
            if (idTipoTransacao != null) localVarQueryParams.Add("idTipoTransacao", Configuration.ApiClient.ParameterToString(idTipoTransacao)); // query parameter
            if (flagCredito != null) localVarQueryParams.Add("flagCredito", Configuration.ApiClient.ParameterToString(flagCredito)); // query parameter
            if (flagFaturado != null) localVarQueryParams.Add("flagFaturado", Configuration.ApiClient.ParameterToString(flagFaturado)); // query parameter
            if (flagProcessada != null) localVarQueryParams.Add("flagProcessada", Configuration.ApiClient.ParameterToString(flagProcessada)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (plano != null) localVarQueryParams.Add("plano", Configuration.ApiClient.ParameterToString(plano)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            if (grupoMCC != null) localVarQueryParams.Add("grupoMCC", Configuration.ApiClient.ParameterToString(grupoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoProcessadaNaoProcessadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoProcessadaNaoProcessadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoProcessadaNaoProcessadaResponse)));
            
        }
        
        /// <summary>
        /// List the transfers made by the account This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param> 
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param> 
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param> 
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param> 
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param> 
        /// <returns>PageTransferenciaResponse</returns>
        public PageTransferenciaResponse Listar_2 (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = Listar_2WithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the transfers made by the account This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param> 
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param> 
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param> 
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param> 
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaResponse</returns>
        public ApiResponse< PageTransferenciaResponse > Listar_2WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Listar_2");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }

        
        /// <summary>
        /// List the transfers made by the account This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param>
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param>
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param>
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param>
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param>
        /// <returns>Task of PageTransferenciaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaResponse> Listar_2Async (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
             ApiResponse<PageTransferenciaResponse> localVarResponse = await Listar_2AsyncWithHttpInfo(id, sort, page, limit, idTransferencia, idContaOrigem, idContaDestino, valorTransferencia, dataTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the transfers made by the account This method allows to be listed the transfers made by the existing account in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTransferencia">Identification Code of the transfer (id) (optional)</param>
        /// <param name="idContaOrigem">Identification Code of the account which the value will be debited for the transfer (id) (optional)</param>
        /// <param name="idContaDestino">Identification Code of the account which the value wull be creditedfor the transfer (id) (optional)</param>
        /// <param name="valorTransferencia">Value established to be transfered (optional)</param>
        /// <param name="dataTransferencia">Date established to occur the transfer (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaResponse>> Listar_2AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idTransferencia = null, long? idContaOrigem = null, long? idContaDestino = null, double? valorTransferencia = null, string dataTransferencia = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_2");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            if (idTransferencia != null) localVarQueryParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // query parameter
            if (idContaOrigem != null) localVarQueryParams.Add("idContaOrigem", Configuration.ApiClient.ParameterToString(idContaOrigem)); // query parameter
            if (idContaDestino != null) localVarQueryParams.Add("idContaDestino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valorTransferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            if (dataTransferencia != null) localVarQueryParams.Add("dataTransferencia", Configuration.ApiClient.ParameterToString(dataTransferencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaResponse)));
            
        }
        
        /// <summary>
        /// Do the reactivation of the account this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <returns>Object</returns>
        public Object Reativar (long? id)
        {
             ApiResponse<Object> localVarResponse = ReativarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Do the reactivation of the account this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReativarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Reativar");
            
    
            var localVarPath = "/api/contas/{id}/reativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Do the reactivation of the account this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReativarAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await ReativarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Do the reactivation of the account this resource allows to reactivate the accounts. For this, It&#39;s necessary to inform the idcode of the account (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReativarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Reativar");
            
    
            var localVarPath = "/api/contas/{id}/reativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Reativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Includes a new account This resource includes a new account for an existing client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse Salvar (ContaPersist contaPersist)
        {
             ApiResponse<ContaResponse> localVarResponse = SalvarWithHttpInfo(contaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Includes a new account This resource includes a new account for an existing client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > SalvarWithHttpInfo (ContaPersist contaPersist)
        {
            
            // verify the required parameter 'contaPersist' is set
            if (contaPersist == null)
                throw new ApiException(400, "Missing required parameter 'contaPersist' when calling AccountApi->Salvar");
            
    
            var localVarPath = "/api/contas";
    
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
            
            
            
            
            if (contaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Includes a new account This resource includes a new account for an existing client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> SalvarAsync (ContaPersist contaPersist)
        {
             ApiResponse<ContaResponse> localVarResponse = await SalvarAsyncWithHttpInfo(contaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Includes a new account This resource includes a new account for an existing client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contaPersist">contaPersist</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> SalvarAsyncWithHttpInfo (ContaPersist contaPersist)
        {
            // verify the required parameter 'contaPersist' is set
            if (contaPersist == null) throw new ApiException(400, "Missing required parameter 'contaPersist' when calling Salvar");
            
    
            var localVarPath = "/api/contas";
    
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
            
            
            
            
            if (contaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Make a registration of a new service adhesion This feature allows you to register a new service subscription at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param> 
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param> 
        /// <returns>AdesaoServicoResponse</returns>
        public AdesaoServicoResponse SalvarAdesaoServicos (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
             ApiResponse<AdesaoServicoResponse> localVarResponse = SalvarAdesaoServicosWithHttpInfo(id, adesaoServicoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make a registration of a new service adhesion This feature allows you to register a new service subscription at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param> 
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param> 
        /// <returns>ApiResponse of AdesaoServicoResponse</returns>
        public ApiResponse< AdesaoServicoResponse > SalvarAdesaoServicosWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->SalvarAdesaoServicos");
            
            // verify the required parameter 'adesaoServicoPersist' is set
            if (adesaoServicoPersist == null)
                throw new ApiException(400, "Missing required parameter 'adesaoServicoPersist' when calling AccountApi->SalvarAdesaoServicos");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-servicos";
    
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
            
            
            
            
            if (adesaoServicoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoServicoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoServicoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoServicoResponse)));
            
        }

        
        /// <summary>
        /// Make a registration of a new service adhesion This feature allows you to register a new service subscription at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of AdesaoServicoResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoServicoResponse> SalvarAdesaoServicosAsync (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
             ApiResponse<AdesaoServicoResponse> localVarResponse = await SalvarAdesaoServicosAsyncWithHttpInfo(id, adesaoServicoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make a registration of a new service adhesion This feature allows you to register a new service subscription at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identify account</param>
        /// <param name="adesaoServicoPersist">adesaoServicoPersist</param>
        /// <returns>Task of ApiResponse (AdesaoServicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoServicoResponse>> SalvarAdesaoServicosAsyncWithHttpInfo (long? id, AdesaoServicoPersist adesaoServicoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarAdesaoServicos");
            // verify the required parameter 'adesaoServicoPersist' is set
            if (adesaoServicoPersist == null) throw new ApiException(400, "Missing required parameter 'adesaoServicoPersist' when calling SalvarAdesaoServicos");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-servicos";
    
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
            
            
            
            
            if (adesaoServicoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoServicoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoServicoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdesaoServicos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoServicoResponse)));
            
        }
        
        /// <summary>
        /// Simulate values of loans/financing This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>EmprestimoPessoalResponse</returns>
        public EmprestimoPessoalResponse SimularEmprestimoFinanciamento (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = SimularEmprestimoFinanciamentoWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simulate values of loans/financing This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        public ApiResponse< EmprestimoPessoalResponse > SimularEmprestimoFinanciamentoWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->SimularEmprestimoFinanciamento");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling AccountApi->SimularEmprestimoFinanciamento");
            
    
            var localVarPath = "/api/contas/{id}/simular-emprestimos-financiamentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }

        
        /// <summary>
        /// Simulate values of loans/financing This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        public async System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoAsync (long? id, EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = await SimularEmprestimoFinanciamentoAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simulate values of loans/financing This operation can be used to simulate financial operations with the information given by the user. The created calculus must be considered only as a reference for real situations and not as official values
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoAsyncWithHttpInfo (long? id, EmprestimoPessoalRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularEmprestimoFinanciamento");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularEmprestimoFinanciamento");
            
    
            var localVarPath = "/api/contas/{id}/simular-emprestimos-financiamentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }
        
        /// <summary>
        /// Allow to list a timeline of the event of the account This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTransacaoResponse</returns>
        public PageTransacaoResponse Transacoes (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = TransacoesWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to list a timeline of the event of the account This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTransacaoResponse</returns>
        public ApiResponse< PageTransacaoResponse > TransacoesWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Transacoes");
            
    
            var localVarPath = "/api/contas/{id}/timeline";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }

        
        /// <summary>
        /// Allow to list a timeline of the event of the account This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageTransacaoResponse> TransacoesAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransacaoResponse> localVarResponse = await TransacoesAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to list a timeline of the event of the account This operation has as an aim to allow a listing, in a timeline mode, of the events linked to a determined account. Transactions, invoice closing, payments, create cards and update the limit are exemples of the events contemplated for this funcionality. In this method, the operations are ordered in descending form
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransacaoResponse>> TransacoesAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Transacoes");
            
    
            var localVarPath = "/api/contas/{id}/timeline";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransacaoResponse)));
            
        }
        
        /// <summary>
        /// Make a credit transfer to another client of the same Issuer This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param> 
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param> 
        /// <param name="valorTransferencia">Value of the Transfer</param> 
        /// <returns>TransferenciaDetalheResponse</returns>
        public TransferenciaDetalheResponse Transferir (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = TransferirWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make a credit transfer to another client of the same Issuer This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param> 
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param> 
        /// <param name="valorTransferencia">Value of the Transfer</param> 
        /// <returns>ApiResponse of TransferenciaDetalheResponse</returns>
        public ApiResponse< TransferenciaDetalheResponse > TransferirWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountApi->Transferir");
            
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null)
                throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling AccountApi->Transferir");
            
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling AccountApi->Transferir");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            
            if (idContaDestino != null) localVarQueryParams.Add("id_conta_destino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valor_transferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Make a credit transfer to another client of the same Issuer This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param>
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param>
        /// <param name="valorTransferencia">Value of the Transfer</param>
        /// <returns>Task of TransferenciaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaDetalheResponse> TransferirAsync (long? id, long? idContaDestino, double? valorTransferencia)
        {
             ApiResponse<TransferenciaDetalheResponse> localVarResponse = await TransferirAsyncWithHttpInfo(id, idContaDestino, valorTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make a credit transfer to another client of the same Issuer This method allows that a cardholder can make credit transfer to another client of the same Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder client account that will be debited (id)</param>
        /// <param name="idContaDestino">Identification Code of the cardholder client that will be credited (id)</param>
        /// <param name="valorTransferencia">Value of the Transfer</param>
        /// <returns>Task of ApiResponse (TransferenciaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaDetalheResponse>> TransferirAsyncWithHttpInfo (long? id, long? idContaDestino, double? valorTransferencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Transferir");
            // verify the required parameter 'idContaDestino' is set
            if (idContaDestino == null) throw new ApiException(400, "Missing required parameter 'idContaDestino' when calling Transferir");
            // verify the required parameter 'valorTransferencia' is set
            if (valorTransferencia == null) throw new ApiException(400, "Missing required parameter 'valorTransferencia' when calling Transferir");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-cartoes";
    
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
            
            if (idContaDestino != null) localVarQueryParams.Add("id_conta_destino", Configuration.ApiClient.ParameterToString(idContaDestino)); // query parameter
            if (valorTransferencia != null) localVarQueryParams.Add("valor_transferencia", Configuration.ApiClient.ParameterToString(valorTransferencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaDetalheResponse)));
            
        }
        
    }
    
}
