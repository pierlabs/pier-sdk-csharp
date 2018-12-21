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
    public interface ITransferBankApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update the banck account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to update the bank account of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param>
        /// <param name="update">update</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse Atualizar (long? id, BankAccountCardholderUpdate update);
  
        /// <summary>
        /// Update the banck account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to update the bank account of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> AtualizarWithHttpInfo (long? id, BankAccountCardholderUpdate update);
        
        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <remarks>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="update">update</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse AtualizarTaxasJurosContas (long? id, TaxaTaxaJurosConta update);
  
        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <remarks>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> AtualizarTaxasJurosContasWithHttpInfo (long? id, TaxaTaxaJurosConta update);
        
        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>string</returns>
        string CancelarTransferenciaCreditoContaBancaria (long? idTransferencia);
  
        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CancelarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>string</returns>
        string ConfirmarTransferenciaCreditoContaBancaria (long? idTransferencia);
  
        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfirmarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Retrieve the bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse Consultar (long? id);
  
        /// <summary>
        /// Retrieve the bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse ConsultarTaxasJurosContas (long? id, int? numeroMesesCarencia);
  
        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> ConsultarTaxasJurosContasWithHttpInfo (long? id, int? numeroMesesCarencia);
        
        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder
        /// </summary>
        /// <remarks>
        /// Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancaria (long? idTransferencia);
  
        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder
        /// </summary>
        /// <remarks>
        /// Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Retrieve a bank transfer for a bank
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse Consultar_0 (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
  
        /// <summary>
        /// Retrieve a bank transfer for a bank
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> Consultar_0WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// List the bank accounts of the cardholder
        /// </summary>
        /// <remarks>
        /// Ehis resource allows to list the bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param>
        /// <param name="nomeAgencia">Description of the angency (optional)</param>
        /// <param name="banco">Bank code (optional)</param>
        /// <param name="numeroAgencia">Number of the angency (optional)</param>
        /// <param name="numeroConta">Number of the account (optional)</param>
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param>
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">Code of the person (optional)</param>
        /// <param name="favorecido">Name of the favored (optional)</param>
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageContaBancariaPortadorResponse</returns>
        PageContaBancariaPortadorResponse Listar (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the bank accounts of the cardholder
        /// </summary>
        /// <remarks>
        /// Ehis resource allows to list the bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param>
        /// <param name="nomeAgencia">Description of the angency (optional)</param>
        /// <param name="banco">Bank code (optional)</param>
        /// <param name="numeroAgencia">Number of the angency (optional)</param>
        /// <param name="numeroConta">Number of the account (optional)</param>
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param>
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">Code of the person (optional)</param>
        /// <param name="favorecido">Name of the favored (optional)</param>
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        ApiResponse<PageContaBancariaPortadorResponse> ListarWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the bank transfers of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account (optional)</param>
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param>
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param>
        /// <param name="status">C?digo do status do processamento (optional)</param>
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancaria (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
  
        /// <summary>
        /// List the bank transfers of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account (optional)</param>
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param>
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param>
        /// <param name="status">C?digo do status do processamento (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
        
        /// <summary>
        /// List the bank transfers made
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageTransferenciaBancariaResponse</returns>
        PageTransferenciaBancariaResponse Listar_0 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the bank transfers made
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        ApiResponse<PageTransferenciaBancariaResponse> Listar_0WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Create a new bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// This resource allows to create bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse Salvar (BankaccountCardholderPersist persist);
  
        /// <summary>
        /// Create a new bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// This resource allows to create bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> SalvarWithHttpInfo (BankaccountCardholderPersist persist);
        
        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="persist">persist</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse SalvarTaxasJurosContas (long? id, TaxaTaxaJurosConta persist);
  
        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> SalvarTaxasJurosContasWithHttpInfo (long? id, TaxaTaxaJurosConta persist);
        
        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancaria (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
  
        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// Make a bank transfer from the card to the bank accounts
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancaria (TransferCreditBankingAccountPersist persist);
  
        /// <summary>
        /// Make a bank transfer from the card to the bank accounts
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaWithHttpInfo (TransferCreditBankingAccountPersist persist);
        
        /// <summary>
        /// Make bank transfer of the card for the bank account
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse Transferir (long? id, TransferBankingPersist transferenciaBancariaPersist);
  
        /// <summary>
        /// Make bank transfer of the card for the bank account
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> TransferirWithHttpInfo (long? id, TransferBankingPersist transferenciaBancariaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update the banck account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to update the bank account of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarAsync (long? id, BankAccountCardholderUpdate update);

        /// <summary>
        /// Update the banck account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to update the bank account of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarAsyncWithHttpInfo (long? id, BankAccountCardholderUpdate update);
        
        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <remarks>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> AtualizarTaxasJurosContasAsync (long? id, TaxaTaxaJurosConta update);

        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <remarks>
        /// It updates new interest rates from a given account to the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> AtualizarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaTaxaJurosConta update);
        
        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CancelarTransferenciaCreditoContaBancariaAsync (long? idTransferencia);

        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CancelarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfirmarTransferenciaCreditoContaBancariaAsync (long? idTransferencia);

        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfirmarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Retrieve the bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Retrieve the bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> ConsultarTaxasJurosContasAsync (long? id, int? numeroMesesCarencia);

        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> ConsultarTaxasJurosContasAsyncWithHttpInfo (long? id, int? numeroMesesCarencia);
        
        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder
        /// </summary>
        /// <remarks>
        /// Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaAsync (long? idTransferencia);

        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder
        /// </summary>
        /// <remarks>
        /// Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Retrieve a bank transfer for a bank
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> Consultar_0Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null);

        /// <summary>
        /// Retrieve a bank transfer for a bank
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> Consultar_0AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// List the bank accounts of the cardholder
        /// </summary>
        /// <remarks>
        /// Ehis resource allows to list the bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param>
        /// <param name="nomeAgencia">Description of the angency (optional)</param>
        /// <param name="banco">Bank code (optional)</param>
        /// <param name="numeroAgencia">Number of the angency (optional)</param>
        /// <param name="numeroConta">Number of the account (optional)</param>
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param>
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">Code of the person (optional)</param>
        /// <param name="favorecido">Name of the favored (optional)</param>
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarAsync (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the bank accounts of the cardholder
        /// </summary>
        /// <remarks>
        /// Ehis resource allows to list the bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param>
        /// <param name="nomeAgencia">Description of the angency (optional)</param>
        /// <param name="banco">Bank code (optional)</param>
        /// <param name="numeroAgencia">Number of the angency (optional)</param>
        /// <param name="numeroConta">Number of the account (optional)</param>
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param>
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">Code of the person (optional)</param>
        /// <param name="favorecido">Name of the favored (optional)</param>
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarAsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the bank transfers of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account (optional)</param>
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param>
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param>
        /// <param name="status">C?digo do status do processamento (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);

        /// <summary>
        /// List the bank transfers of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account (optional)</param>
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param>
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param>
        /// <param name="status">C?digo do status do processamento (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
        
        /// <summary>
        /// List the bank transfers made
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> Listar_0Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the bank transfers made
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> Listar_0AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Create a new bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// This resource allows to create bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarAsync (BankaccountCardholderPersist persist);

        /// <summary>
        /// Create a new bank account of the cardholder
        /// </summary>
        /// <remarks>
        /// This resource allows to create bank accounts of the cardholder
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarAsyncWithHttpInfo (BankaccountCardholderPersist persist);
        
        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> SalvarTaxasJurosContasAsync (long? id, TaxaTaxaJurosConta persist);

        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <remarks>
        /// Registers new interest rates for a particular account for the credit transfer feature
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> SalvarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaTaxaJurosConta persist);
        
        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);

        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <remarks>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// Make a bank transfer from the card to the bank accounts
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaAsync (TransferCreditBankingAccountPersist persist);

        /// <summary>
        /// Make a bank transfer from the card to the bank accounts
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaAsyncWithHttpInfo (TransferCreditBankingAccountPersist persist);
        
        /// <summary>
        /// Make bank transfer of the card for the bank account
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirAsync (long? id, TransferBankingPersist transferenciaBancariaPersist);

        /// <summary>
        /// Make bank transfer of the card for the bank account
        /// </summary>
        /// <remarks>
        /// This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirAsyncWithHttpInfo (long? id, TransferBankingPersist transferenciaBancariaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransferBankApi : ITransferBankApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBankApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransferBankApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBankApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransferBankApi(Configuration configuration = null)
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
        /// Update the banck account of the cardholder his resource allows to update the bank account of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse Atualizar (long? id, BankAccountCardholderUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = AtualizarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the banck account of the cardholder his resource allows to update the bank account of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > AtualizarWithHttpInfo (long? id, BankAccountCardholderUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->Atualizar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling TransferBankApi->Atualizar");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Update the banck account of the cardholder his resource allows to update the bank account of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarAsync (long? id, BankAccountCardholderUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the banck account of the cardholder his resource allows to update the bank account of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the cardholder Bank Account (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarAsyncWithHttpInfo (long? id, BankAccountCardholderUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Atualizar");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <param name="update">update</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse AtualizarTaxasJurosContas (long? id, TaxaTaxaJurosConta update)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = AtualizarTaxasJurosContasWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > AtualizarTaxasJurosContasWithHttpInfo (long? id, TaxaTaxaJurosConta update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->AtualizarTaxasJurosContas");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling TransferBankApi->AtualizarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> AtualizarTaxasJurosContasAsync (long? id, TaxaTaxaJurosConta update)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await AtualizarTaxasJurosContasAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// It updates new interest rates from a given account to the credit transfer feature It updates new interest rates from a given account to the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> AtualizarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaTaxaJurosConta update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarTaxasJurosContas");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <returns>string</returns>
        public string CancelarTransferenciaCreditoContaBancaria (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = CancelarTransferenciaCreditoContaBancariaWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CancelarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferBankApi->CancelarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/cancelar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CancelarTransferenciaCreditoContaBancariaAsync (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = await CancelarTransferenciaCreditoContaBancariaAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the cancellation of a banking transfer of the card for banking accounts that are pending of confirmation This resource has as an aim to allow the cancellation of a credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CancelarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling CancelarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/cancelar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <returns>string</returns>
        public string ConfirmarTransferenciaCreditoContaBancaria (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = ConfirmarTransferenciaCreditoContaBancariaWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfirmarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferBankApi->ConfirmarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/confirmar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfirmarTransferenciaCreditoContaBancariaAsync (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = await ConfirmarTransferenciaCreditoContaBancariaAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the information of a banking transfer of the card to other banking accounts that are pending of configuration This resource has as an aim to allow the confirmation of the credit transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfirmarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConfirmarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/confirmar";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Retrieve the bank account of the cardholder his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse Consultar (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the bank account of the cardholder his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->Consultar");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the bank account of the cardholder his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarAsync (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the bank account of the cardholder his resource allows to retrieve the bank account of the cardholder by the ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the bank account (id)</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse ConsultarTaxasJurosContas (long? id, int? numeroMesesCarencia)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = ConsultarTaxasJurosContasWithHttpInfo(id, numeroMesesCarencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > ConsultarTaxasJurosContasWithHttpInfo (long? id, int? numeroMesesCarencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->ConsultarTaxasJurosContas");
            
            // verify the required parameter 'numeroMesesCarencia' is set
            if (numeroMesesCarencia == null)
                throw new ApiException(400, "Missing required parameter 'numeroMesesCarencia' when calling TransferBankApi->ConsultarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            if (numeroMesesCarencia != null) localVarQueryParams.Add("numeroMesesCarencia", Configuration.ApiClient.ParameterToString(numeroMesesCarencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> ConsultarTaxasJurosContasAsync (long? id, int? numeroMesesCarencia)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await ConsultarTaxasJurosContasAsyncWithHttpInfo(id, numeroMesesCarencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs the query of the interest rates of a certain account for the credit transfer feature Performs the query of the interest rates of a certain account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> ConsultarTaxasJurosContasAsyncWithHttpInfo (long? id, int? numeroMesesCarencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasJurosContas");
            // verify the required parameter 'numeroMesesCarencia' is set
            if (numeroMesesCarencia == null) throw new ApiException(400, "Missing required parameter 'numeroMesesCarencia' when calling ConsultarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            if (numeroMesesCarencia != null) localVarQueryParams.Add("numeroMesesCarencia", Configuration.ApiClient.ParameterToString(numeroMesesCarencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancaria (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = ConsultarTransferenciaBancariaWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > ConsultarTransferenciaBancariaWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferBankApi->ConsultarTransferenciaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaAsync (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await ConsultarTransferenciaBancariaAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the consultation of a bank transfer of credit among bank accountsof a cardholder Resource used to retrieve a credit transfer among bank accounts of a cardholder, use the ID of the bank transfer the idAccount makes the consultation
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarTransferenciaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Retrieve a bank transfer for a bank This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse Consultar_0 (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = Consultar_0WithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a bank transfer for a bank This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="idTransferencia">Id Transfer</param> 
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > Consultar_0WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->Consultar_0");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferBankApi->Consultar_0");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias/{id_transferencia}";
    
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
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Retrieve a bank transfer for a bank This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> Consultar_0Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a bank transfer for a bank This resource allows to retrieve the details of a determined credit transfer made to a bank account. In general, this operations can be used to a simple consultation of these deatails or to make an assembling of a second voucher of transfer among accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idTransferencia">Id Transfer</param>
        /// <param name="idContaBancariaDestino">Identification Code of the banking account of destiny (id) (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> Consultar_0AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling Consultar_0");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias/{id_transferencia}";
    
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
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// List the bank accounts of the cardholder Ehis resource allows to list the bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param> 
        /// <param name="nomeAgencia">Description of the angency (optional)</param> 
        /// <param name="banco">Bank code (optional)</param> 
        /// <param name="numeroAgencia">Number of the angency (optional)</param> 
        /// <param name="numeroConta">Number of the account (optional)</param> 
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param> 
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">Code of the person (optional)</param> 
        /// <param name="favorecido">Name of the favored (optional)</param> 
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageContaBancariaPortadorResponse</returns>
        public PageContaBancariaPortadorResponse Listar (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = ListarWithHttpInfo(idConta, nomeAgencia, banco, numeroAgencia, numeroConta, flagAtivo, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the bank accounts of the cardholder Ehis resource allows to list the bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param> 
        /// <param name="nomeAgencia">Description of the angency (optional)</param> 
        /// <param name="banco">Bank code (optional)</param> 
        /// <param name="numeroAgencia">Number of the angency (optional)</param> 
        /// <param name="numeroConta">Number of the account (optional)</param> 
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param> 
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">Code of the person (optional)</param> 
        /// <param name="favorecido">Name of the favored (optional)</param> 
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        public ApiResponse< PageContaBancariaPortadorResponse > ListarWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// List the bank accounts of the cardholder Ehis resource allows to list the bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param>
        /// <param name="nomeAgencia">Description of the angency (optional)</param>
        /// <param name="banco">Bank code (optional)</param>
        /// <param name="numeroAgencia">Number of the angency (optional)</param>
        /// <param name="numeroConta">Number of the account (optional)</param>
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param>
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">Code of the person (optional)</param>
        /// <param name="favorecido">Name of the favored (optional)</param>
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarAsync (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = await ListarAsyncWithHttpInfo(idConta, nomeAgencia, banco, numeroAgencia, numeroConta, flagAtivo, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the bank accounts of the cardholder Ehis resource allows to list the bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identifier Code of the Card Account (optional)</param>
        /// <param name="nomeAgencia">Description of the angency (optional)</param>
        /// <param name="banco">Bank code (optional)</param>
        /// <param name="numeroAgencia">Number of the angency (optional)</param>
        /// <param name="numeroConta">Number of the account (optional)</param>
        /// <param name="flagAtivo">Indicates whether the bank account is active (optional)</param>
        /// <param name="flagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">Code of the person (optional)</param>
        /// <param name="favorecido">Name of the favored (optional)</param>
        /// <param name="numeroReceiraFederal">Document of the favored (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarAsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// List the bank transfers of credit among bank accounts Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identification Code of the account (optional)</param> 
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param> 
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param> 
        /// <param name="status">C?digo do status do processamento (optional)</param> 
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        public PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancaria (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = ListarTransferenciaBancariaWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the bank transfers of credit among bank accounts Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identification Code of the account (optional)</param> 
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param> 
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param> 
        /// <param name="status">C?digo do status do processamento (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaCreditoContaBancariaResponse > ListarTransferenciaBancariaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            if (dataSolicitacaoInicial != null) localVarQueryParams.Add("dataSolicitacaoInicial", Configuration.ApiClient.ParameterToString(dataSolicitacaoInicial)); // query parameter
            if (dataSolicitacaoFinal != null) localVarQueryParams.Add("dataSolicitacaoFinal", Configuration.ApiClient.ParameterToString(dataSolicitacaoFinal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// List the bank transfers of credit among bank accounts Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account (optional)</param>
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param>
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param>
        /// <param name="status">C?digo do status do processamento (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = await ListarTransferenciaBancariaAsyncWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the bank transfers of credit among bank accounts Resource used to list the tranfers of credit among bank accounts of a cardholder requested
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account (optional)</param>
        /// <param name="dataSolicitacaoInicial">Initial date of the transfer request (optional)</param>
        /// <param name="dataSolicitacaoFinal">Final date of the transfer resquest (optional)</param>
        /// <param name="status">C?digo do status do processamento (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            if (dataSolicitacaoInicial != null) localVarQueryParams.Add("dataSolicitacaoInicial", Configuration.ApiClient.ParameterToString(dataSolicitacaoInicial)); // query parameter
            if (dataSolicitacaoFinal != null) localVarQueryParams.Add("dataSolicitacaoFinal", Configuration.ApiClient.ParameterToString(dataSolicitacaoFinal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// List the bank transfers made This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTransferenciaBancariaResponse</returns>
        public PageTransferenciaBancariaResponse Listar_0 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = Listar_0WithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the bank transfers made This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaBancariaResponse > Listar_0WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->Listar_0");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// List the bank transfers made This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> Listar_0Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the bank transfers made This resource has as an aim to allow the cardholder can retrieve a list of bank transfers for the favored registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="idContaBancariaDestino">Identification Code of the destination Banking Account (id) (optional)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> Listar_0AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_0");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Create a new bank account of the cardholder This resource allows to create bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse Salvar (BankaccountCardholderPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new bank account of the cardholder This resource allows to create bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > SalvarWithHttpInfo (BankaccountCardholderPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferBankApi->Salvar");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
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
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Create a new bank account of the cardholder This resource allows to create bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarAsync (BankaccountCardholderPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new bank account of the cardholder This resource allows to create bank accounts of the cardholder
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarAsyncWithHttpInfo (BankaccountCardholderPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
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

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse SalvarTaxasJurosContas (long? id, TaxaTaxaJurosConta persist)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = SalvarTaxasJurosContasWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > SalvarTaxasJurosContasWithHttpInfo (long? id, TaxaTaxaJurosConta persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->SalvarTaxasJurosContas");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferBankApi->SalvarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> SalvarTaxasJurosContasAsync (long? id, TaxaTaxaJurosConta persist)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await SalvarTaxasJurosContasAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registers new interest rates for a particular account for the credit transfer feature Registers new interest rates for a particular account for the credit transfer feature
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Accout Id</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> SalvarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaTaxaJurosConta persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarTaxasJurosContas");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancaria (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = SimularTransferenciaBancariaWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PlanoParcelamentoTransferenciaCreditoContaBancariaResponse > SimularTransferenciaBancariaWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TransferBankApi->SimularTransferenciaBancaria");
            
    
            var localVarPath = "/api/simular-transferencias-creditos-contas-bancarias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = await SimularTransferenciaBancariaAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simulate the plans of installment for a bank transfer of credit among bank accounts Simulate the plans of installment for a bank transfer of credit among bank accounts
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularTransferenciaBancaria");
            
    
            var localVarPath = "/api/simular-transferencias-creditos-contas-bancarias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Make a bank transfer from the card to the bank accounts This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancaria (TransferCreditBankingAccountPersist persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = TransferenciaCreditoContaBancariaWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make a bank transfer from the card to the bank accounts This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > TransferenciaCreditoContaBancariaWithHttpInfo (TransferCreditBankingAccountPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferBankApi->TransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Make a bank transfer from the card to the bank accounts This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaAsync (TransferCreditBankingAccountPersist persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await TransferenciaCreditoContaBancariaAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make a bank transfer from the card to the bank accounts This resource has as an aim to allow that the cardholderv can make credit transfer to a bank account.Thus, the value of the credit added to the transfer fee, when is made by the issuer, it will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaAsyncWithHttpInfo (TransferCreditBankingAccountPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Make bank transfer of the card for the bank account This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse Transferir (long? id, TransferBankingPersist transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = TransferirWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make bank transfer of the card for the bank account This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > TransferirWithHttpInfo (long? id, TransferBankingPersist transferenciaBancariaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferBankApi->Transferir");
            
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null)
                throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling TransferBankApi->Transferir");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (transferenciaBancariaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transferenciaBancariaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferenciaBancariaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Make bank transfer of the card for the bank account This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirAsync (long? id, TransferBankingPersist transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await TransferirAsyncWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make bank transfer of the card for the bank account This resource has as an aim to allow the cardholder can make a credit transfer for the bank account. Thus, The value of the credit add to the transfer fee, when is made by the Issuer, It will be charged from the account of origin, if there is enough balance, it will be charged in the bank account of destiny
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Account</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirAsyncWithHttpInfo (long? id, TransferBankingPersist transferenciaBancariaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Transferir");
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null) throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling Transferir");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (transferenciaBancariaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transferenciaBancariaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferenciaBancariaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
    }
    
}
