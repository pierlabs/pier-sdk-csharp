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
    public interface IStatusParameterApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// List the dates of a determined Account Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <returns>StatusContaResponse</returns>
        StatusContaResponse Consultar (long? id);
  
        /// <summary>
        /// List the dates of a determined Account Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <returns>ApiResponse of StatusContaResponse</returns>
        ApiResponse<StatusContaResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Show the dates of a determined Level Card
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param>
        /// <returns>EstagioCartaoResponse</returns>
        EstagioCartaoResponse ConsultarEstagioCartao (long? id);
  
        /// <summary>
        /// Show the dates of a determined Level Card
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param>
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        ApiResponse<EstagioCartaoResponse> ConsultarEstagioCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Card Status
        /// </summary>
        /// <remarks>
        /// this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param>
        /// <returns>StatusCartaoResponse</returns>
        StatusCartaoResponse ConsultarStatusCartao (long? id);
  
        /// <summary>
        /// List the dates of a determined Card Status
        /// </summary>
        /// <remarks>
        /// this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param>
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        ApiResponse<StatusCartaoResponse> ConsultarStatusCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param>
        /// <returns>StatusImpressaoResponse</returns>
        StatusImpressaoResponse Consultar_0 (long? id);
  
        /// <summary>
        /// List the dates of a determined Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param>
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        ApiResponse<StatusImpressaoResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// List the Account Status for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Account Status in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Account Status (optional)</param>
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>PageStatusContaResponse</returns>
        PageStatusContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
  
        /// <summary>
        /// List the Account Status for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Account Status in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Account Status (optional)</param>
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        ApiResponse<PageStatusContaResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// List the options of Level of the Cards
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Card Stage (optional)</param>
        /// <returns>PageEstagioCartaoResponse</returns>
        PageEstagioCartaoResponse ListarEstagiosCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// List the options of Level of the Cards
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Card Stage (optional)</param>
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        ApiResponse<PageEstagioCartaoResponse> ListarEstagiosCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// List summarized CNAB statuses
        /// </summary>
        /// <remarks>
        /// Existing CNAB status list
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse ListarStatusCNABSumarizados (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List summarized CNAB statuses
        /// </summary>
        /// <remarks>
        /// Existing CNAB status list
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> ListarStatusCNABSumarizadosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the options of Card Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>PageStatusCartaoResponse</returns>
        PageStatusCartaoResponse ListarStatusCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
  
        /// <summary>
        /// List the options of Card Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        ApiResponse<PageStatusCartaoResponse> ListarStatusCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// List the options of Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Status Printing (optional)</param>
        /// <returns>PageStatusImpressaoResponse</returns>
        PageStatusImpressaoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// List the options of Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Status Printing (optional)</param>
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        ApiResponse<PageStatusImpressaoResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// List the dates of a determined Account Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <returns>Task of StatusContaResponse</returns>
        System.Threading.Tasks.Task<StatusContaResponse> ConsultarAsync (long? id);

        /// <summary>
        /// List the dates of a determined Account Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Show the dates of a determined Level Card
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoAsync (long? id);

        /// <summary>
        /// Show the dates of a determined Level Card
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Card Status
        /// </summary>
        /// <remarks>
        /// this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoAsync (long? id);

        /// <summary>
        /// List the dates of a determined Card Status
        /// </summary>
        /// <remarks>
        /// this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<StatusImpressaoResponse> Consultar_0Async (long? id);

        /// <summary>
        /// List the dates of a determined Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the Account Status for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Account Status in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Account Status (optional)</param>
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        System.Threading.Tasks.Task<PageStatusContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);

        /// <summary>
        /// List the Account Status for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Account Status in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Account Status (optional)</param>
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null);
        
        /// <summary>
        /// List the options of Level of the Cards
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Card Stage (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// List the options of Level of the Cards
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Card Stage (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// List summarized CNAB statuses
        /// </summary>
        /// <remarks>
        /// Existing CNAB status list
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> ListarStatusCNABSumarizadosAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List summarized CNAB statuses
        /// </summary>
        /// <remarks>
        /// Existing CNAB status list
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ListarStatusCNABSumarizadosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the options of Card Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);

        /// <summary>
        /// List the options of Card Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null);
        
        /// <summary>
        /// List the options of Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Status Printing (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        System.Threading.Tasks.Task<PageStatusImpressaoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// List the options of Printing Status
        /// </summary>
        /// <remarks>
        /// This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Status Printing (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatusParameterApi : IStatusParameterApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusParameterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusParameterApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusParameterApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusParameterApi(Configuration configuration = null)
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
        /// List the dates of a determined Account Status This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param> 
        /// <returns>StatusContaResponse</returns>
        public StatusContaResponse Consultar (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Account Status This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param> 
        /// <returns>ApiResponse of StatusContaResponse</returns>
        public ApiResponse< StatusContaResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParameterApi->Consultar");
            
    
            var localVarPath = "/api/status-contas/{id}";
    
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
    
            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Account Status This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <returns>Task of StatusContaResponse</returns>
        public async System.Threading.Tasks.Task<StatusContaResponse> ConsultarAsync (long? id)
        {
             ApiResponse<StatusContaResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Account Status This method allows to retrieve the parameters of a determined Account Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account status (id)</param>
        /// <returns>Task of ApiResponse (StatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusContaResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/status-contas/{id}";
    
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

            return new ApiResponse<StatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusContaResponse)));
            
        }
        
        /// <summary>
        /// Show the dates of a determined Level Card This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param> 
        /// <returns>EstagioCartaoResponse</returns>
        public EstagioCartaoResponse ConsultarEstagioCartao (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = ConsultarEstagioCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show the dates of a determined Level Card This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param> 
        /// <returns>ApiResponse of EstagioCartaoResponse</returns>
        public ApiResponse< EstagioCartaoResponse > ConsultarEstagioCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParameterApi->ConsultarEstagioCartao");
            
    
            var localVarPath = "/api/estagios-cartoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// Show the dates of a determined Level Card This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param>
        /// <returns>Task of EstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<EstagioCartaoResponse> ConsultarEstagioCartaoAsync (long? id)
        {
             ApiResponse<EstagioCartaoResponse> localVarResponse = await ConsultarEstagioCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show the dates of a determined Level Card This method allows to retrieve the parameters of a determined Level of delivery of the Card using the Id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Delivery Stage (id)</param>
        /// <returns>Task of ApiResponse (EstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstagioCartaoResponse>> ConsultarEstagioCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarEstagioCartao");
            
    
            var localVarPath = "/api/estagios-cartoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Card Status this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param> 
        /// <returns>StatusCartaoResponse</returns>
        public StatusCartaoResponse ConsultarStatusCartao (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = ConsultarStatusCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Card Status this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param> 
        /// <returns>ApiResponse of StatusCartaoResponse</returns>
        public ApiResponse< StatusCartaoResponse > ConsultarStatusCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParameterApi->ConsultarStatusCartao");
            
    
            var localVarPath = "/api/status-cartoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Card Status this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param>
        /// <returns>Task of StatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusCartaoResponse> ConsultarStatusCartaoAsync (long? id)
        {
             ApiResponse<StatusCartaoResponse> localVarResponse = await ConsultarStatusCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Card Status this method allows to retrieve the parameters of a determined Card Status using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card delivery Stage (id)</param>
        /// <returns>Task of ApiResponse (StatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusCartaoResponse>> ConsultarStatusCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusCartao");
            
    
            var localVarPath = "/api/status-cartoes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Printing Status This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param> 
        /// <returns>StatusImpressaoResponse</returns>
        public StatusImpressaoResponse Consultar_0 (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Printing Status This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param> 
        /// <returns>ApiResponse of StatusImpressaoResponse</returns>
        public ApiResponse< StatusImpressaoResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StatusParameterApi->Consultar_0");
            
    
            var localVarPath = "/api/status-impressoes/{id}";
    
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
    
            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Printing Status This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param>
        /// <returns>Task of StatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<StatusImpressaoResponse> Consultar_0Async (long? id)
        {
             ApiResponse<StatusImpressaoResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Printing Status This method allows to retrieve the parameters of a determined Status of the Printing of the Card using de identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Printing Card Status (id)</param>
        /// <returns>Task of ApiResponse (StatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusImpressaoResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/status-impressoes/{id}";
    
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

            return new ApiResponse<StatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusImpressaoResponse)));
            
        }
        
        /// <summary>
        /// List the Account Status for the Issuer This method allows to be listed the existing Account Status in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param> 
        /// <param name="nome">Name attributed to the Account Status (optional)</param> 
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param> 
        /// <returns>PageStatusContaResponse</returns>
        public PageStatusContaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the Account Status for the Issuer This method allows to be listed the existing Account Status in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param> 
        /// <param name="nome">Name attributed to the Account Status (optional)</param> 
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param> 
        /// <returns>ApiResponse of PageStatusContaResponse</returns>
        public ApiResponse< PageStatusContaResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteAlterarVencimento != null) localVarQueryParams.Add("permiteAlterarVencimento", Configuration.ApiClient.ParameterToString(permiteAlterarVencimento)); // query parameter
            if (permiteAlterarLimite != null) localVarQueryParams.Add("permiteAlterarLimite", Configuration.ApiClient.ParameterToString(permiteAlterarLimite)); // query parameter
            if (permiteEmitirNovaViaCartao != null) localVarQueryParams.Add("permiteEmitirNovaViaCartao", Configuration.ApiClient.ParameterToString(permiteEmitirNovaViaCartao)); // query parameter
            if (permiteFazerTransferencia != null) localVarQueryParams.Add("permiteFazerTransferencia", Configuration.ApiClient.ParameterToString(permiteFazerTransferencia)); // query parameter
            if (permiteReceberTransferencia != null) localVarQueryParams.Add("permiteReceberTransferencia", Configuration.ApiClient.ParameterToString(permiteReceberTransferencia)); // query parameter
            if (permiteCriarAcordoCobranca != null) localVarQueryParams.Add("permiteCriarAcordoCobranca", Configuration.ApiClient.ParameterToString(permiteCriarAcordoCobranca)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }

        
        /// <summary>
        /// List the Account Status for the Issuer This method allows to be listed the existing Account Status in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Account Status (optional)</param>
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of PageStatusContaResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusContaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
             ApiResponse<PageStatusContaResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, id, nome, permiteAlterarVencimento, permiteAlterarLimite, permiteEmitirNovaViaCartao, permiteFazerTransferencia, permiteReceberTransferencia, permiteCriarAcordoCobranca, permiteAtribuirComoBloqueio, permiteDesbloquear, permiteAtribuirComoCancelamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the Account Status for the Issuer This method allows to be listed the existing Account Status in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Account Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Account Status (optional)</param>
        /// <param name="permiteAlterarVencimento">Parameter that sets if the card status allows the resquest of updating of the expiration dates of the invoices, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAlterarLimite">Parameter that sets if the card status allows update of limits of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteEmitirNovaViaCartao">Parameter that sets if the card status allows to request a new card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteFazerTransferencia">Parameter that sets if the card status allows to make Credit transfer to other accounts of the same issuer or other bank account, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteReceberTransferencia">Parameter that sets if the card status allows recieve Credit transfer from other account of the same issuer, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteCriarAcordoCobranca">Parameter that sets if the card status allows to have a debt collection agreement created for it, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows to be attributed to lock an account temporarily, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows to be unlocked, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows to be attributed to do the definitive cancellation of the account, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusContaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteAlterarVencimento = null, int? permiteAlterarLimite = null, int? permiteEmitirNovaViaCartao = null, int? permiteFazerTransferencia = null, int? permiteReceberTransferencia = null, int? permiteCriarAcordoCobranca = null, int? permiteAtribuirComoBloqueio = null, int? permiteDesbloquear = null, int? permiteAtribuirComoCancelamento = null)
        {
            
    
            var localVarPath = "/api/status-contas";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteAlterarVencimento != null) localVarQueryParams.Add("permiteAlterarVencimento", Configuration.ApiClient.ParameterToString(permiteAlterarVencimento)); // query parameter
            if (permiteAlterarLimite != null) localVarQueryParams.Add("permiteAlterarLimite", Configuration.ApiClient.ParameterToString(permiteAlterarLimite)); // query parameter
            if (permiteEmitirNovaViaCartao != null) localVarQueryParams.Add("permiteEmitirNovaViaCartao", Configuration.ApiClient.ParameterToString(permiteEmitirNovaViaCartao)); // query parameter
            if (permiteFazerTransferencia != null) localVarQueryParams.Add("permiteFazerTransferencia", Configuration.ApiClient.ParameterToString(permiteFazerTransferencia)); // query parameter
            if (permiteReceberTransferencia != null) localVarQueryParams.Add("permiteReceberTransferencia", Configuration.ApiClient.ParameterToString(permiteReceberTransferencia)); // query parameter
            if (permiteCriarAcordoCobranca != null) localVarQueryParams.Add("permiteCriarAcordoCobranca", Configuration.ApiClient.ParameterToString(permiteCriarAcordoCobranca)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusContaResponse)));
            
        }
        
        /// <summary>
        /// List the options of Level of the Cards This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id of the Card Stage (optional)</param> 
        /// <param name="nome">Name of the Card Stage (optional)</param> 
        /// <returns>PageEstagioCartaoResponse</returns>
        public PageEstagioCartaoResponse ListarEstagiosCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = ListarEstagiosCartoesWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the options of Level of the Cards This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id of the Card Stage (optional)</param> 
        /// <param name="nome">Name of the Card Stage (optional)</param> 
        /// <returns>ApiResponse of PageEstagioCartaoResponse</returns>
        public ApiResponse< PageEstagioCartaoResponse > ListarEstagiosCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }

        
        /// <summary>
        /// List the options of Level of the Cards This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Card Stage (optional)</param>
        /// <returns>Task of PageEstagioCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstagioCartaoResponse> ListarEstagiosCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageEstagioCartaoResponse> localVarResponse = await ListarEstagiosCartoesAsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the options of Level of the Cards This method allows to be listed the options of Level of delivery that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Card Stage (optional)</param>
        /// <returns>Task of ApiResponse (PageEstagioCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstagioCartaoResponse>> ListarEstagiosCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstagioCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstagioCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstagioCartaoResponse)));
            
        }
        
        /// <summary>
        /// List summarized CNAB statuses Existing CNAB status list
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse ListarStatusCNABSumarizados (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = ListarStatusCNABSumarizadosWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List summarized CNAB statuses Existing CNAB status list
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        public ApiResponse< PageTipoBoletoResponse > ListarStatusCNABSumarizadosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cnab-sumarizados";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }

        
        /// <summary>
        /// List summarized CNAB statuses Existing CNAB status list
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> ListarStatusCNABSumarizadosAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await ListarStatusCNABSumarizadosAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List summarized CNAB statuses Existing CNAB status list
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ListarStatusCNABSumarizadosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cnab-sumarizados";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCNABSumarizados: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }
        
        /// <summary>
        /// List the options of Card Status This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param> 
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param> 
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <returns>PageStatusCartaoResponse</returns>
        public PageStatusCartaoResponse ListarStatusCartoes (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = ListarStatusCartoesWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the options of Card Status This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param> 
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param> 
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param> 
        /// <returns>ApiResponse of PageStatusCartaoResponse</returns>
        public ApiResponse< PageStatusCartaoResponse > ListarStatusCartoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            if (cobrarTarifaAoEmitirNovaVia != null) localVarQueryParams.Add("cobrarTarifaAoEmitirNovaVia", Configuration.ApiClient.ParameterToString(cobrarTarifaAoEmitirNovaVia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }

        
        /// <summary>
        /// List the options of Card Status This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of PageStatusCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusCartaoResponse> ListarStatusCartoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
             ApiResponse<PageStatusCartaoResponse> localVarResponse = await ListarStatusCartoesAsyncWithHttpInfo(sort, page, limit, id, nome, permiteDesbloquear, permiteAtribuirComoBloqueio, permiteAtribuirComoCancelamento, cobrarTarifaAoEmitirNovaVia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the options of Card Status This method allows to be listed the possibilities of Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="nome">Name attributed to the Status of the Card delivery (optional)</param>
        /// <param name="permiteDesbloquear">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoBloqueio">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="permiteAtribuirComoCancelamento">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <param name="cobrarTarifaAoEmitirNovaVia">Parameter that sets if the card status allows the reactivation of the card, being: 0: Inactive and 1: Active (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusCartaoResponse>> ListarStatusCartoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? permiteDesbloquear = null, int? permiteAtribuirComoBloqueio = null, int? permiteAtribuirComoCancelamento = null, int? cobrarTarifaAoEmitirNovaVia = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (permiteDesbloquear != null) localVarQueryParams.Add("permiteDesbloquear", Configuration.ApiClient.ParameterToString(permiteDesbloquear)); // query parameter
            if (permiteAtribuirComoBloqueio != null) localVarQueryParams.Add("permiteAtribuirComoBloqueio", Configuration.ApiClient.ParameterToString(permiteAtribuirComoBloqueio)); // query parameter
            if (permiteAtribuirComoCancelamento != null) localVarQueryParams.Add("permiteAtribuirComoCancelamento", Configuration.ApiClient.ParameterToString(permiteAtribuirComoCancelamento)); // query parameter
            if (cobrarTarifaAoEmitirNovaVia != null) localVarQueryParams.Add("cobrarTarifaAoEmitirNovaVia", Configuration.ApiClient.ParameterToString(cobrarTarifaAoEmitirNovaVia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusCartaoResponse)));
            
        }
        
        /// <summary>
        /// List the options of Printing Status This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id of the Card Stage (optional)</param> 
        /// <param name="nome">Name of the Status Printing (optional)</param> 
        /// <returns>PageStatusImpressaoResponse</returns>
        public PageStatusImpressaoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the options of Printing Status This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id of the Card Stage (optional)</param> 
        /// <param name="nome">Name of the Status Printing (optional)</param> 
        /// <returns>ApiResponse of PageStatusImpressaoResponse</returns>
        public ApiResponse< PageStatusImpressaoResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/status-impressoes";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }

        
        /// <summary>
        /// List the options of Printing Status This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Status Printing (optional)</param>
        /// <returns>Task of PageStatusImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusImpressaoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageStatusImpressaoResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the options of Printing Status This method allows to to be listed the options of Printing Status that can be attributed to the Cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id of the Card Stage (optional)</param>
        /// <param name="nome">Name of the Status Printing (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusImpressaoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/status-impressoes";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusImpressaoResponse)));
            
        }
        
    }
    
}
