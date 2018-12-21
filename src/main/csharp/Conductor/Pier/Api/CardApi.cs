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
    public interface ICardApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Make the update the password of a card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to register or update</param>
        /// <returns>string</returns>
        string AlterarAlterarSenha (long? id, string senha);
  
        /// <summary>
        /// Make the update the password of a card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to register or update</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarAlterarSenhaWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Update a card stage
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the card stage for another informed resquest
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="update">Identification Code of the Card Stage (stage)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AlterarEstagio (long? id, EstagioCartaoUpdate update);
  
        /// <summary>
        /// Update a card stage
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the card stage for another informed resquest
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="update">Identification Code of the Card Stage (stage)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AlterarEstagioWithHttpInfo (long? id, EstagioCartaoUpdate update);
        
        /// <summary>
        /// Perform the updating of the Status of Impression of the Card
        /// </summary>
        /// <remarks>
        /// This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param>
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param>
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        HistoricoImpressaoCartaoResponse AlterarStatusImpressao (long? id, long? idStatusImpressao);
  
        /// <summary>
        /// Perform the updating of the Status of Impression of the Card
        /// </summary>
        /// <remarks>
        /// This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param>
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param>
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        ApiResponse<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person
        /// </summary>
        /// <remarks>
        /// This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse AtribuirPessoa (long? id, long? idPessoa);
  
        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person
        /// </summary>
        /// <remarks>
        /// This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> AtribuirPessoaWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Make the block of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idStatus">Identification Code of the new card status</param>
        /// <param name="observacao">Text informing an observation about the Lock</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse Bloquear (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// Make the block of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idStatus">Identification Code of the new card status</param>
        /// <param name="observacao">Text informing an observation about the Lock</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> BloquearWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Accomplish the registerment of a password for the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be registered or updated</param>
        /// <returns>string</returns>
        string CadastrarAlterarSenha (long? id, string senha);
  
        /// <summary>
        /// Accomplish the registerment of a password for the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be registered or updated</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CadastrarAlterarSenhaWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Apply the cancellation of a determined Card
        /// </summary>
        /// <remarks>
        /// This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param>
        /// <param name="observacao">Text informed an observation about the cancellation</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse Cancelar (long? id, long? idStatus, string observacao);
  
        /// <summary>
        /// Apply the cancellation of a determined Card
        /// </summary>
        /// <remarks>
        /// This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param>
        /// <param name="observacao">Text informed an observation about the cancellation</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> CancelarWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Present the dates of a determine card
        /// </summary>
        /// <remarks>
        /// This method allows to update the basic information of a determined card from its ID code(id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>CartaoDetalheResponse</returns>
        CartaoDetalheResponse Consultar (long? id);
  
        /// <summary>
        /// Present the dates of a determine card
        /// </summary>
        /// <remarks>
        /// This method allows to update the basic information of a determined card from its ID code(id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        ApiResponse<CartaoDetalheResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Search dates of print Card
        /// </summary>
        /// <remarks>
        /// This resource allows to  search the dates of a Card printed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>DadosCartaoImpressaoResponse</returns>
        DadosCartaoImpressaoResponse ConsultarCartaoImpressao (long? id);
  
        /// <summary>
        /// Search dates of print Card
        /// </summary>
        /// <remarks>
        /// This resource allows to  search the dates of a Card printed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        ApiResponse<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Search Details of the Card
        /// </summary>
        /// <remarks>
        /// This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>DadosCartaoResponse</returns>
        DadosCartaoResponse ConsultarDadosReaisCartao (long? id);
  
        /// <summary>
        /// Search Details of the Card
        /// </summary>
        /// <remarks>
        /// This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        ApiResponse<DadosCartaoResponse> ConsultarDadosReaisCartaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Present the limits of the cardholder
        /// </summary>
        /// <remarks>
        /// This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>LimiteDisponibilidadeResponse</returns>
        LimiteDisponibilidadeResponse ConsultarLimiteDisponibilidade (long? id);
  
        /// <summary>
        /// Present the limits of the cardholder
        /// </summary>
        /// <remarks>
        /// This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        ApiResponse<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeWithHttpInfo (long? id);
        
        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards
        /// </summary>
        /// <remarks>
        /// This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse ConsultarLotesCartoesPrePagos (long? id);
  
        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards
        /// </summary>
        /// <remarks>
        /// This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosWithHttpInfo (long? id);
        
        /// <summary>
        /// Present the dates of the Cardholder
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>PortadorResponse</returns>
        PortadorResponse ConsultarPortador (long? id);
  
        /// <summary>
        /// Present the dates of the Cardholder
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of PortadorResponse</returns>
        ApiResponse<PortadorResponse> ConsultarPortadorWithHttpInfo (long? id);
        
        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>VinculoCartoesResponse</returns>
        VinculoCartoesResponse CriarCartoesMultiApp (CardMultiAppPersist cartaoMultiAppPersist);
  
        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        ApiResponse<VinculoCartoesResponse> CriarCartoesMultiAppWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist);
        
        /// <summary>
        /// Make an unblock of a dtermined card
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse Desbloquear (long? id);
  
        /// <summary>
        /// Make an unblock of a dtermined card
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearWithHttpInfo (long? id);
        
        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse DesbloquearSenhaIncorreta (long? id);
  
        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> DesbloquearSenhaIncorretaWithHttpInfo (long? id);
        
        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards
        /// </summary>
        /// <remarks>
        /// This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param>
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param>
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param>
        /// <returns>LoteCartoesPrePagosResponse</returns>
        LoteCartoesPrePagosResponse GerarLotesCartoesPrePagos (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
  
        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards
        /// </summary>
        /// <remarks>
        /// This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param>
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param>
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param>
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        ApiResponse<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
        
        /// <summary>
        /// Create a new VIA of the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>CartaoImpressaoResponse</returns>
        CartaoImpressaoResponse GerarNovaVia (long? id);
  
        /// <summary>
        /// Create a new VIA of the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        ApiResponse<CartaoImpressaoResponse> GerarNovaViaWithHttpInfo (long? id);
        
        /// <summary>
        /// Create a new VIA of multiple card
        /// </summary>
        /// <remarks>
        /// This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>CartaoMultiAppImpressaoResponse</returns>
        CartaoMultiAppImpressaoResponse GerarNovaViaCartaoMultiApp (long? id);
  
        /// <summary>
        /// Create a new VIA of multiple card
        /// </summary>
        /// <remarks>
        /// This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of CartaoMultiAppImpressaoResponse</returns>
        ApiResponse<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppWithHttpInfo (long? id);
        
        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card
        /// </summary>
        /// <remarks>
        /// This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Object</returns>
        Object LancarTarifaSegundaVia (long? id);
  
        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card
        /// </summary>
        /// <remarks>
        /// This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LancarTarifaSegundaViaWithHttpInfo (long? id);
        
        /// <summary>
        /// List cards made by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to list the existent cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param>
        /// <param name="numeroCartao">Show the number of the card (optional)</param>
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param>
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param>
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param>
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param>
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param>
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param>
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param>
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param>
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param>
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param>
        /// <param name="identificadorExterno">External identification number (optional)</param>
        /// <returns>PageCartaoResponse</returns>
        PageCartaoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
  
        /// <summary>
        /// List cards made by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to list the existent cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param>
        /// <param name="numeroCartao">Show the number of the card (optional)</param>
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param>
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param>
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param>
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param>
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param>
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param>
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param>
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param>
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param>
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param>
        /// <param name="identificadorExterno">External identification number (optional)</param>
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        ApiResponse<PageCartaoResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
        
        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param>
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param>
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param>
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param>
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param>
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param>
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param>
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagos (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
  
        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param>
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param>
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param>
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param>
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param>
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param>
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param>
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        ApiResponse<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
        
        /// <summary>
        /// Do the reactivation of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the reactivation of a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>CartaoResponse</returns>
        CartaoResponse Reativar (long? id);
  
        /// <summary>
        /// Do the reactivation of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the reactivation of a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>ApiResponse of CartaoResponse</returns>
        ApiResponse<CartaoResponse> ReativarWithHttpInfo (long? id);
        
        /// <summary>
        /// Validate CVV of the Card
        /// </summary>
        /// <remarks>
        /// This resource allows the validation of the cvv of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>string</returns>
        string ValidarCVV (long? id, ValidaCVVRequest validaCVV);
  
        /// <summary>
        /// Validate CVV of the Card
        /// </summary>
        /// <remarks>
        /// This resource allows the validation of the cvv of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarCVVWithHttpInfo (long? id, ValidaCVVRequest validaCVV);
        
        /// <summary>
        /// Allow to validate the printed dates in a flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param>
        /// <param name="nomePortador">Cardholder name</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosImpressosBandeirado (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Allow to validate the printed dates in a flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param>
        /// <param name="nomePortador">Cardholder name</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="nomePortador">Name of the cardholder</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDadosImpressosNaoBandeirado (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
  
        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="nomePortador">Name of the cardholder</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarDe55CartaoMastercard (string numeroCartao, string criptograma);
  
        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarDe55CartaoMastercardWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Allow validate the password of a Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be validated</param>
        /// <returns>ValidaSenhaCartaoResponse</returns>
        ValidaSenhaCartaoResponse ValidarSenha (long? id, string senha);
  
        /// <summary>
        /// Allow validate the password of a Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be validated</param>
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        ApiResponse<ValidaSenhaCartaoResponse> ValidarSenhaWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Allow validate the Flagged Card through the targe
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param>
        /// <param name="trilha1">Trail 1 of the card to be validate</param>
        /// <param name="trilha2">Trail 2 of the card to be validate</param>
        /// <returns>ValidaCartaoResponse</returns>
        ValidaCartaoResponse ValidarTarja (string numeroCartao, string trilha1, string trilha2);
  
        /// <summary>
        /// Allow validate the Flagged Card through the targe
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param>
        /// <param name="trilha1">Trail 1 of the card to be validate</param>
        /// <param name="trilha2">Trail 2 of the card to be validate</param>
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        ApiResponse<ValidaCartaoResponse> ValidarTarjaWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Make the update the password of a card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to register or update</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarAlterarSenhaAsync (long? id, string senha);

        /// <summary>
        /// Make the update the password of a card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to register or update</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarAlterarSenhaAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Update a card stage
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the card stage for another informed resquest
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="update">Identification Code of the Card Stage (stage)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AlterarEstagioAsync (long? id, EstagioCartaoUpdate update);

        /// <summary>
        /// Update a card stage
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the card stage for another informed resquest
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="update">Identification Code of the Card Stage (stage)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AlterarEstagioAsyncWithHttpInfo (long? id, EstagioCartaoUpdate update);
        
        /// <summary>
        /// Perform the updating of the Status of Impression of the Card
        /// </summary>
        /// <remarks>
        /// This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param>
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoAsync (long? id, long? idStatusImpressao);

        /// <summary>
        /// Perform the updating of the Status of Impression of the Card
        /// </summary>
        /// <remarks>
        /// This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param>
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoAsyncWithHttpInfo (long? id, long? idStatusImpressao);
        
        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person
        /// </summary>
        /// <remarks>
        /// This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaAsync (long? id, long? idPessoa);

        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person
        /// </summary>
        /// <remarks>
        /// This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Make the block of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idStatus">Identification Code of the new card status</param>
        /// <param name="observacao">Text informing an observation about the Lock</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> BloquearAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// Make the block of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idStatus">Identification Code of the new card status</param>
        /// <param name="observacao">Text informing an observation about the Lock</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Accomplish the registerment of a password for the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be registered or updated</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CadastrarAlterarSenhaAsync (long? id, string senha);

        /// <summary>
        /// Accomplish the registerment of a password for the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be registered or updated</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Apply the cancellation of a determined Card
        /// </summary>
        /// <remarks>
        /// This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param>
        /// <param name="observacao">Text informed an observation about the cancellation</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> CancelarAsync (long? id, long? idStatus, string observacao);

        /// <summary>
        /// Apply the cancellation of a determined Card
        /// </summary>
        /// <remarks>
        /// This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param>
        /// <param name="observacao">Text informed an observation about the cancellation</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarAsyncWithHttpInfo (long? id, long? idStatus, string observacao);
        
        /// <summary>
        /// Present the dates of a determine card
        /// </summary>
        /// <remarks>
        /// This method allows to update the basic information of a determined card from its ID code(id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Present the dates of a determine card
        /// </summary>
        /// <remarks>
        /// This method allows to update the basic information of a determined card from its ID code(id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Search dates of print Card
        /// </summary>
        /// <remarks>
        /// This resource allows to  search the dates of a Card printed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoAsync (long? id);

        /// <summary>
        /// Search dates of print Card
        /// </summary>
        /// <remarks>
        /// This resource allows to  search the dates of a Card printed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarCartaoImpressaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Search Details of the Card
        /// </summary>
        /// <remarks>
        /// This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoAsync (long? id);

        /// <summary>
        /// Search Details of the Card
        /// </summary>
        /// <remarks>
        /// This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Present the limits of the cardholder
        /// </summary>
        /// <remarks>
        /// This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeAsync (long? id);

        /// <summary>
        /// Present the limits of the cardholder
        /// </summary>
        /// <remarks>
        /// This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimiteDisponibilidadeAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards
        /// </summary>
        /// <remarks>
        /// This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosAsync (long? id);

        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards
        /// </summary>
        /// <remarks>
        /// This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLotesCartoesPrePagosAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Present the dates of the Cardholder
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of PortadorResponse</returns>
        System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorAsync (long? id);

        /// <summary>
        /// Present the dates of the Cardholder
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppAsync (CardMultiAppPersist cartaoMultiAppPersist);

        /// <summary>
        /// Register cards MultiApp
        /// </summary>
        /// <remarks>
        /// This feature allows the registration of cards MultiApp
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppAsyncWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist);
        
        /// <summary>
        /// Make an unblock of a dtermined card
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearAsync (long? id);

        /// <summary>
        /// Make an unblock of a dtermined card
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> DesbloquearSenhaIncorretaAsync (long? id);

        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password
        /// </summary>
        /// <remarks>
        /// This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearSenhaIncorretaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards
        /// </summary>
        /// <remarks>
        /// This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param>
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param>
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);

        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards
        /// </summary>
        /// <remarks>
        /// This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param>
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param>
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLotesCartoesPrePagosAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null);
        
        /// <summary>
        /// Create a new VIA of the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarNovaViaAsync (long? id);

        /// <summary>
        /// Create a new VIA of the Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarNovaViaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Create a new VIA of multiple card
        /// </summary>
        /// <remarks>
        /// This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoMultiAppImpressaoResponse</returns>
        System.Threading.Tasks.Task<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppAsync (long? id);

        /// <summary>
        /// Create a new VIA of multiple card
        /// </summary>
        /// <remarks>
        /// This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoMultiAppImpressaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoMultiAppImpressaoResponse>> GerarNovaViaCartaoMultiAppAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card
        /// </summary>
        /// <remarks>
        /// This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LancarTarifaSegundaViaAsync (long? id);

        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card
        /// </summary>
        /// <remarks>
        /// This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaSegundaViaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List cards made by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to list the existent cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param>
        /// <param name="numeroCartao">Show the number of the card (optional)</param>
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param>
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param>
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param>
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param>
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param>
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param>
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param>
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param>
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param>
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param>
        /// <param name="identificadorExterno">External identification number (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        System.Threading.Tasks.Task<PageCartaoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);

        /// <summary>
        /// List cards made by the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to list the existent cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param>
        /// <param name="numeroCartao">Show the number of the card (optional)</param>
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param>
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param>
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param>
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param>
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param>
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param>
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param>
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param>
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param>
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param>
        /// <param name="identificadorExterno">External identification number (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null);
        
        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param>
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param>
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param>
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param>
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param>
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param>
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);

        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param>
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param>
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param>
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param>
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param>
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param>
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null);
        
        /// <summary>
        /// Do the reactivation of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the reactivation of a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        System.Threading.Tasks.Task<CartaoResponse> ReativarAsync (long? id);

        /// <summary>
        /// Do the reactivation of a determined card
        /// </summary>
        /// <remarks>
        /// This method allows the reactivation of a determined card from its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Validate CVV of the Card
        /// </summary>
        /// <remarks>
        /// This resource allows the validation of the cvv of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarCVVAsync (long? id, ValidaCVVRequest validaCVV);

        /// <summary>
        /// Validate CVV of the Card
        /// </summary>
        /// <remarks>
        /// This resource allows the validation of the cvv of the card
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarCVVAsyncWithHttpInfo (long? id, ValidaCVVRequest validaCVV);
        
        /// <summary>
        /// Allow to validate the printed dates in a flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param>
        /// <param name="nomePortador">Cardholder name</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Allow to validate the printed dates in a flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param>
        /// <param name="nomePortador">Cardholder name</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosBandeiradoAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="nomePortador">Name of the cardholder</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);

        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="nomePortador">Name of the cardholder</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosNaoBandeiradoAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca);
        
        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDe55CartaoMastercardAsync (string numeroCartao, string criptograma);

        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDe55CartaoMastercardAsyncWithHttpInfo (string numeroCartao, string criptograma);
        
        /// <summary>
        /// Allow validate the password of a Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be validated</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaAsync (long? id, string senha);

        /// <summary>
        /// Allow validate the password of a Card
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be validated</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaAsyncWithHttpInfo (long? id, string senha);
        
        /// <summary>
        /// Allow validate the Flagged Card through the targe
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param>
        /// <param name="trilha1">Trail 1 of the card to be validate</param>
        /// <param name="trilha2">Trail 2 of the card to be validate</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaAsync (string numeroCartao, string trilha1, string trilha2);

        /// <summary>
        /// Allow validate the Flagged Card through the targe
        /// </summary>
        /// <remarks>
        /// This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param>
        /// <param name="trilha1">Trail 1 of the card to be validate</param>
        /// <param name="trilha2">Trail 2 of the card to be validate</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CardApi : ICardApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CardApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardApi(Configuration configuration = null)
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
        /// Make the update the password of a card This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="senha">Password to register or update</param> 
        /// <returns>string</returns>
        public string AlterarAlterarSenha (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = AlterarAlterarSenhaWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the update the password of a card This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="senha">Password to register or update</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarAlterarSenhaWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->AlterarAlterarSenha");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CardApi->AlterarAlterarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Make the update the password of a card This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to register or update</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarAlterarSenhaAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await AlterarAlterarSenhaAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the update the password of a card This operation has as an aim to allow the cardholder of a determined card can definite a password of your own choice
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to register or update</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarAlterarSenhaAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarAlterarSenha");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling AlterarAlterarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Update a card stage This method allows to be updated the card stage for another informed resquest
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="update">Identification Code of the Card Stage (stage)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AlterarEstagio (long? id, EstagioCartaoUpdate update)
        {
             ApiResponse<CartaoResponse> localVarResponse = AlterarEstagioWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a card stage This method allows to be updated the card stage for another informed resquest
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="update">Identification Code of the Card Stage (stage)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AlterarEstagioWithHttpInfo (long? id, EstagioCartaoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->AlterarEstagio");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling CardApi->AlterarEstagio");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-estagio";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Update a card stage This method allows to be updated the card stage for another informed resquest
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="update">Identification Code of the Card Stage (stage)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AlterarEstagioAsync (long? id, EstagioCartaoUpdate update)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AlterarEstagioAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a card stage This method allows to be updated the card stage for another informed resquest
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="update">Identification Code of the Card Stage (stage)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AlterarEstagioAsyncWithHttpInfo (long? id, EstagioCartaoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarEstagio");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarEstagio");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-estagio";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstagio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Perform the updating of the Status of Impression of the Card This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param> 
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param> 
        /// <returns>HistoricoImpressaoCartaoResponse</returns>
        public HistoricoImpressaoCartaoResponse AlterarStatusImpressao (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = AlterarStatusImpressaoWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform the updating of the Status of Impression of the Card This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param> 
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param> 
        /// <returns>ApiResponse of HistoricoImpressaoCartaoResponse</returns>
        public ApiResponse< HistoricoImpressaoCartaoResponse > AlterarStatusImpressaoWithHttpInfo (long? id, long? idStatusImpressao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->AlterarStatusImpressao");
            
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null)
                throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling CardApi->AlterarStatusImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-status-impressao";
    
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
            
            if (idStatusImpressao != null) localVarQueryParams.Add("id_status_impressao", Configuration.ApiClient.ParameterToString(idStatusImpressao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }

        
        /// <summary>
        /// Perform the updating of the Status of Impression of the Card This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param>
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param>
        /// <returns>Task of HistoricoImpressaoCartaoResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoImpressaoCartaoResponse> AlterarStatusImpressaoAsync (long? id, long? idStatusImpressao)
        {
             ApiResponse<HistoricoImpressaoCartaoResponse> localVarResponse = await AlterarStatusImpressaoAsyncWithHttpInfo(id, idStatusImpressao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Perform the updating of the Status of Impression of the Card This method allows that an application that makes the print of the cards can indicate  that a determined  idCard printed or in process of print. For this, it&#39;s necessary to inform the respective code of identification of the card (id) that want to have your determined id_status_ print attributed to him/her. By default, provisory cards must be alredy included in a file for printing by graphicwill have this request denied, if it is used
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the card (id)</param>
        /// <param name="idStatusImpressao">Identification Code of the Printing Status (Id)</param>
        /// <returns>Task of ApiResponse (HistoricoImpressaoCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoImpressaoCartaoResponse>> AlterarStatusImpressaoAsyncWithHttpInfo (long? id, long? idStatusImpressao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusImpressao");
            // verify the required parameter 'idStatusImpressao' is set
            if (idStatusImpressao == null) throw new ApiException(400, "Missing required parameter 'idStatusImpressao' when calling AlterarStatusImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/alterar-status-impressao";
    
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
            
            if (idStatusImpressao != null) localVarQueryParams.Add("id_status_impressao", Configuration.ApiClient.ParameterToString(idStatusImpressao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoImpressaoCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoImpressaoCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoImpressaoCartaoResponse)));
            
        }
        
        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse AtribuirPessoa (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = AtribuirPessoaWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > AtribuirPessoaWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->AtribuirPessoa");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CardApi->AtribuirPessoa");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-titular";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> AtribuirPessoaAsync (long? id, long? idPessoa)
        {
             ApiResponse<CartaoResponse> localVarResponse = await AtribuirPessoaAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Perform the attribuition of a pre-paid card to one person This method allows that a pre-paid printed card and anonymous be attributed to a person, for this person can be able to be the mainly user
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> AtribuirPessoaAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirPessoa");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AtribuirPessoa");
            
    
            var localVarPath = "/api/cartoes/{id}/atribuir-titular";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Make the block of a determined card This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="idStatus">Identification Code of the new card status</param> 
        /// <param name="observacao">Text informing an observation about the Lock</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse Bloquear (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = BloquearWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the block of a determined card This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="idStatus">Identification Code of the new card status</param> 
        /// <param name="observacao">Text informing an observation about the Lock</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > BloquearWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->Bloquear");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CardApi->Bloquear");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CardApi->Bloquear");
            
    
            var localVarPath = "/api/cartoes/{id}/bloquear";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Make the block of a determined card This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idStatus">Identification Code of the new card status</param>
        /// <param name="observacao">Text informing an observation about the Lock</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> BloquearAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await BloquearAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the block of a determined card This method allows the to make the block (temporary) or cancellation (definitive) of a determined card from its ID code. For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="idStatus">Identification Code of the new card status</param>
        /// <param name="observacao">Text informing an observation about the Lock</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> BloquearAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Bloquear");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling Bloquear");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling Bloquear");
            
    
            var localVarPath = "/api/cartoes/{id}/bloquear";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Bloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Accomplish the registerment of a password for the Card This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="senha">Password to be registered or updated</param> 
        /// <returns>string</returns>
        public string CadastrarAlterarSenha (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = CadastrarAlterarSenhaWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Accomplish the registerment of a password for the Card This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="senha">Password to be registered or updated</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CadastrarAlterarSenhaWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->CadastrarAlterarSenha");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CardApi->CadastrarAlterarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/cadastrar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Accomplish the registerment of a password for the Card This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be registered or updated</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CadastrarAlterarSenhaAsync (long? id, string senha)
        {
             ApiResponse<string> localVarResponse = await CadastrarAlterarSenhaAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Accomplish the registerment of a password for the Card This operation has as an aim to allow the cardholder a  de um determinado cart?o possa definir uma senha a sua escolha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be registered or updated</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CadastrarAlterarSenhaAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAlterarSenha");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling CadastrarAlterarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/cadastrar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAlterarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Apply the cancellation of a determined Card This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param> 
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param> 
        /// <param name="observacao">Text informed an observation about the cancellation</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse Cancelar (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = CancelarWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apply the cancellation of a determined Card This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param> 
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param> 
        /// <param name="observacao">Text informed an observation about the cancellation</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > CancelarWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->Cancelar");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling CardApi->Cancelar");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null)
                throw new ApiException(400, "Missing required parameter 'observacao' when calling CardApi->Cancelar");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Apply the cancellation of a determined Card This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param>
        /// <param name="observacao">Text informed an observation about the cancellation</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> CancelarAsync (long? id, long? idStatus, string observacao)
        {
             ApiResponse<CartaoResponse> localVarResponse = await CancelarAsyncWithHttpInfo(id, idStatus, observacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apply the cancellation of a determined Card This method allows to apply the cancella of determined card from your ID code (id). For this, It is necessary to inform what is the motive of this block, that it is to attribute a new StatusCard for the client, among other practices practiced by the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="idStatus">C?digo de Identifica??o do Novo Status Cart?o</param>
        /// <param name="observacao">Text informed an observation about the cancellation</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> CancelarAsyncWithHttpInfo (long? id, long? idStatus, string observacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cancelar");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling Cancelar");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling Cancelar");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar";
    
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
            if (observacao != null) localVarQueryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cancelar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Present the dates of a determine card This method allows to update the basic information of a determined card from its ID code(id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>CartaoDetalheResponse</returns>
        public CartaoDetalheResponse Consultar (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Present the dates of a determine card This method allows to update the basic information of a determined card from its ID code(id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of CartaoDetalheResponse</returns>
        public ApiResponse< CartaoDetalheResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->Consultar");
            
    
            var localVarPath = "/api/cartoes/{id}";
    
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
    
            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Present the dates of a determine card This method allows to update the basic information of a determined card from its ID code(id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<CartaoDetalheResponse> ConsultarAsync (long? id)
        {
             ApiResponse<CartaoDetalheResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Present the dates of a determine card This method allows to update the basic information of a determined card from its ID code(id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/cartoes/{id}";
    
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

            return new ApiResponse<CartaoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Search dates of print Card This resource allows to  search the dates of a Card printed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>DadosCartaoImpressaoResponse</returns>
        public DadosCartaoImpressaoResponse ConsultarCartaoImpressao (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = ConsultarCartaoImpressaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search dates of print Card This resource allows to  search the dates of a Card printed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of DadosCartaoImpressaoResponse</returns>
        public ApiResponse< DadosCartaoImpressaoResponse > ConsultarCartaoImpressaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ConsultarCartaoImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-impressao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Search dates of print Card This resource allows to  search the dates of a Card printed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of DadosCartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoImpressaoResponse> ConsultarCartaoImpressaoAsync (long? id)
        {
             ApiResponse<DadosCartaoImpressaoResponse> localVarResponse = await ConsultarCartaoImpressaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search dates of print Card This resource allows to  search the dates of a Card printed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (DadosCartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoImpressaoResponse>> ConsultarCartaoImpressaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCartaoImpressao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-impressao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCartaoImpressao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Search Details of the Card This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>DadosCartaoResponse</returns>
        public DadosCartaoResponse ConsultarDadosReaisCartao (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = ConsultarDadosReaisCartaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Details of the Card This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of DadosCartaoResponse</returns>
        public ApiResponse< DadosCartaoResponse > ConsultarDadosReaisCartaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ConsultarDadosReaisCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-reais";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }

        
        /// <summary>
        /// Search Details of the Card This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of DadosCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DadosCartaoResponse> ConsultarDadosReaisCartaoAsync (long? id)
        {
             ApiResponse<DadosCartaoResponse> localVarResponse = await ConsultarDadosReaisCartaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Details of the Card This method allows to be searched the necessary dates of a card to execute the services of authorization
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (DadosCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DadosCartaoResponse>> ConsultarDadosReaisCartaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarDadosReaisCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/consultar-dados-reais";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarDadosReaisCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DadosCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DadosCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DadosCartaoResponse)));
            
        }
        
        /// <summary>
        /// Present the limits of the cardholder This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>LimiteDisponibilidadeResponse</returns>
        public LimiteDisponibilidadeResponse ConsultarLimiteDisponibilidade (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = ConsultarLimiteDisponibilidadeWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Present the limits of the cardholder This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of LimiteDisponibilidadeResponse</returns>
        public ApiResponse< LimiteDisponibilidadeResponse > ConsultarLimiteDisponibilidadeWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ConsultarLimiteDisponibilidade");
            
    
            var localVarPath = "/api/cartoes/{id}/limites-disponibilidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }

        
        /// <summary>
        /// Present the limits of the cardholder This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of LimiteDisponibilidadeResponse</returns>
        public async System.Threading.Tasks.Task<LimiteDisponibilidadeResponse> ConsultarLimiteDisponibilidadeAsync (long? id)
        {
             ApiResponse<LimiteDisponibilidadeResponse> localVarResponse = await ConsultarLimiteDisponibilidadeAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Present the limits of the cardholder This me thod allows to retrieve the limits configurated for the cardholder of a determined card, either it is the holder of the account or an additional,  starting from the identification code of the Card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (LimiteDisponibilidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimiteDisponibilidadeResponse>> ConsultarLimiteDisponibilidadeAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLimiteDisponibilidade");
            
    
            var localVarPath = "/api/cartoes/{id}/limites-disponibilidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimiteDisponibilidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimiteDisponibilidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimiteDisponibilidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimiteDisponibilidadeResponse)));
            
        }
        
        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse ConsultarLotesCartoesPrePagos (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = ConsultarLotesCartoesPrePagosWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > ConsultarLotesCartoesPrePagosWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ConsultarLotesCartoesPrePagos");
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> ConsultarLotesCartoesPrePagosAsync (long? id)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await ConsultarLotesCartoesPrePagosAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow retrieving a determined Lot of Pre-Paid Cards This method allows retrieving the existent pre-paid cards in the base of the issuer through the ID of the Lot
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card Batch (id)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> ConsultarLotesCartoesPrePagosAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLotesCartoesPrePagos");
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Present the dates of the Cardholder This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>PortadorResponse</returns>
        public PortadorResponse ConsultarPortador (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = ConsultarPortadorWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Present the dates of the Cardholder This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of PortadorResponse</returns>
        public ApiResponse< PortadorResponse > ConsultarPortadorWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ConsultarPortador");
            
    
            var localVarPath = "/api/cartoes/{id}/portadores";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }

        
        /// <summary>
        /// Present the dates of the Cardholder This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of PortadorResponse</returns>
        public async System.Threading.Tasks.Task<PortadorResponse> ConsultarPortadorAsync (long? id)
        {
             ApiResponse<PortadorResponse> localVarResponse = await ConsultarPortadorAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Present the dates of the Cardholder This method allows to retrieve the information of the cardholder of a determined Card from the identification code of the card (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> ConsultarPortadorAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPortador");
            
    
            var localVarPath = "/api/cartoes/{id}/portadores";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }
        
        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>VinculoCartoesResponse</returns>
        public VinculoCartoesResponse CriarCartoesMultiApp (CardMultiAppPersist cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = CriarCartoesMultiAppWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param> 
        /// <returns>ApiResponse of VinculoCartoesResponse</returns>
        public ApiResponse< VinculoCartoesResponse > CriarCartoesMultiAppWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist)
        {
            
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null)
                throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling CardApi->CriarCartoesMultiApp");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
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
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }

        
        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of VinculoCartoesResponse</returns>
        public async System.Threading.Tasks.Task<VinculoCartoesResponse> CriarCartoesMultiAppAsync (CardMultiAppPersist cartaoMultiAppPersist)
        {
             ApiResponse<VinculoCartoesResponse> localVarResponse = await CriarCartoesMultiAppAsyncWithHttpInfo(cartaoMultiAppPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Register cards MultiApp This feature allows the registration of cards MultiApp
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartaoMultiAppPersist">cartaoMultiAppPersist</param>
        /// <returns>Task of ApiResponse (VinculoCartoesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoCartoesResponse>> CriarCartoesMultiAppAsyncWithHttpInfo (CardMultiAppPersist cartaoMultiAppPersist)
        {
            // verify the required parameter 'cartaoMultiAppPersist' is set
            if (cartaoMultiAppPersist == null) throw new ApiException(400, "Missing required parameter 'cartaoMultiAppPersist' when calling CriarCartoesMultiApp");
            
    
            var localVarPath = "/api/cartoes/gerar-cartoes-multiapp";
    
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
            
            
            
            
            if (cartaoMultiAppPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartaoMultiAppPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartaoMultiAppPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CriarCartoesMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoCartoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoCartoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoCartoesResponse)));
            
        }
        
        /// <summary>
        /// Make an unblock of a dtermined card This method allows to be unblocked a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse Desbloquear (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make an unblock of a dtermined card This method allows to be unblocked a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->Desbloquear");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Desbloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desbloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Make an unblock of a dtermined card This method allows to be unblocked a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make an unblock of a dtermined card This method allows to be unblocked a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification  Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Desbloquear");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Desbloquear: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desbloquear: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse DesbloquearSenhaIncorreta (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = DesbloquearSenhaIncorretaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > DesbloquearSenhaIncorretaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->DesbloquearSenhaIncorreta");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear-senha-incorreta";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorreta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorreta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> DesbloquearSenhaIncorretaAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await DesbloquearSenhaIncorretaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the unblock of a blocked card by trying the incorrect password This method allows to be unblocked a determined card that was blocked by trying the incorrect password, from its id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> DesbloquearSenhaIncorretaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesbloquearSenhaIncorreta");
            
    
            var localVarPath = "/api/cartoes/{id}/desbloquear-senha-incorreta";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorreta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearSenhaIncorreta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param> 
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param> 
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param> 
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param> 
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param> 
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param> 
        /// <returns>LoteCartoesPrePagosResponse</returns>
        public LoteCartoesPrePagosResponse GerarLotesCartoesPrePagos (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = GerarLotesCartoesPrePagosWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param> 
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param> 
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param> 
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param> 
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param> 
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param> 
        /// <returns>ApiResponse of LoteCartoesPrePagosResponse</returns>
        public ApiResponse< LoteCartoesPrePagosResponse > GerarLotesCartoesPrePagosWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param>
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param>
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param>
        /// <returns>Task of LoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<LoteCartoesPrePagosResponse> GerarLotesCartoesPrePagosAsync (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
             ApiResponse<LoteCartoesPrePagosResponse> localVarResponse = await GerarLotesCartoesPrePagosAsyncWithHttpInfo(idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to create a new Lot of Pre-paid cards This method has as an aim allow Issuers to create a determined quantity of pre-paid cards, not rated, which they ca be comercialized and then linked to a client who is going to purchase it. For this,  besides defining how many cards must be created, it will be possible to definite what is the Comercial Origin, the Product, the Type of the Card, the Image and the Address for delivering the Cards presents in the lot created. By default, all the cards will be associated to an idPersonal ficticious and they will recieve an unique IdAccount to each one of them. Then, the created Cards for this operation will follow the same processos of graphic print previously definite between the Issuer and Conductor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idOrigemComercial">Identification Code of the Commerical Origin (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Prdocut (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the image (id) (optional)</param>
        /// <param name="idEndereco">Identification code of the address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existent cards in the Batch (optional)</param>
        /// <param name="identificadorExterno">Number of exeternal identification (used by th issuer) (optional)</param>
        /// <returns>Task of ApiResponse (LoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoteCartoesPrePagosResponse>> GerarLotesCartoesPrePagosAsyncWithHttpInfo (long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Create a new VIA of the Card This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>CartaoImpressaoResponse</returns>
        public CartaoImpressaoResponse GerarNovaVia (long? id)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = GerarNovaViaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new VIA of the Card This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of CartaoImpressaoResponse</returns>
        public ApiResponse< CartaoImpressaoResponse > GerarNovaViaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->GerarNovaVia");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaVia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaVia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Create a new VIA of the Card This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoImpressaoResponse> GerarNovaViaAsync (long? id)
        {
             ApiResponse<CartaoImpressaoResponse> localVarResponse = await GerarNovaViaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new VIA of the Card This operation has as an aim to allow the issuers or your clients can request a new VIA of the card that will be headed to printing and posting according to the standard demand already definite by the issuer. For this, It is necessary that the client has already a card and inform the identification code of it (idCard) so the client can be able to use this operation. So,  this functionability applies only to the physical generation cards
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoImpressaoResponse>> GerarNovaViaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaVia");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaVia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaVia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Create a new VIA of multiple card This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>CartaoMultiAppImpressaoResponse</returns>
        public CartaoMultiAppImpressaoResponse GerarNovaViaCartaoMultiApp (long? id)
        {
             ApiResponse<CartaoMultiAppImpressaoResponse> localVarResponse = GerarNovaViaCartaoMultiAppWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new VIA of multiple card This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of CartaoMultiAppImpressaoResponse</returns>
        public ApiResponse< CartaoMultiAppImpressaoResponse > GerarNovaViaCartaoMultiAppWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->GerarNovaViaCartaoMultiApp");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via-multiplo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoMultiAppImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoMultiAppImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoMultiAppImpressaoResponse)));
            
        }

        
        /// <summary>
        /// Create a new VIA of multiple card This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoMultiAppImpressaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoMultiAppImpressaoResponse> GerarNovaViaCartaoMultiAppAsync (long? id)
        {
             ApiResponse<CartaoMultiAppImpressaoResponse> localVarResponse = await GerarNovaViaCartaoMultiAppAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new VIA of multiple card This resource generates a new VIA of multiple product (with 2 cards associated)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoMultiAppImpressaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoMultiAppImpressaoResponse>> GerarNovaViaCartaoMultiAppAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarNovaViaCartaoMultiApp");
            
    
            var localVarPath = "/api/cartoes/{id}/gerar-nova-via-multiplo";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarNovaViaCartaoMultiApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoMultiAppImpressaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoMultiAppImpressaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoMultiAppImpressaoResponse)));
            
        }
        
        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>Object</returns>
        public Object LancarTarifaSegundaVia (long? id)
        {
             ApiResponse<Object> localVarResponse = LancarTarifaSegundaViaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > LancarTarifaSegundaViaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->LancarTarifaSegundaVia");
            
    
            var localVarPath = "/api/cartoes/{id}/lancar-tarifa-reemissao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaVia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaVia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LancarTarifaSegundaViaAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await LancarTarifaSegundaViaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a fee of adjustment of the second VIA of the card This resource allow to add the task of adjustment by the emission of the second re-print of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LancarTarifaSegundaViaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LancarTarifaSegundaVia");
            
    
            var localVarPath = "/api/cartoes/{id}/lancar-tarifa-reemissao";
    
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
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaVia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LancarTarifaSegundaVia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// List cards made by the Issuer This method allows to list the existent cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param> 
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param> 
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param> 
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param> 
        /// <param name="numeroCartao">Show the number of the card (optional)</param> 
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param> 
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param> 
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param> 
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param> 
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param> 
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param> 
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param> 
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param> 
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param> 
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param> 
        /// <param name="identificadorExterno">External identification number (optional)</param> 
        /// <returns>PageCartaoResponse</returns>
        public PageCartaoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List cards made by the Issuer This method allows to list the existent cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param> 
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param> 
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param> 
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param> 
        /// <param name="numeroCartao">Show the number of the card (optional)</param> 
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param> 
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param> 
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param> 
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param> 
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param> 
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param> 
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param> 
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param> 
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param> 
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param> 
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param> 
        /// <param name="identificadorExterno">External identification number (optional)</param> 
        /// <returns>ApiResponse of PageCartaoResponse</returns>
        public ApiResponse< PageCartaoResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes";
    
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
            if (idStatusCartao != null) localVarQueryParams.Add("idStatusCartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (idEstagioCartao != null) localVarQueryParams.Add("idEstagioCartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (dataGeracao != null) localVarQueryParams.Add("dataGeracao", Configuration.ApiClient.ParameterToString(dataGeracao)); // query parameter
            if (dataStatusCartao != null) localVarQueryParams.Add("dataStatusCartao", Configuration.ApiClient.ParameterToString(dataStatusCartao)); // query parameter
            if (dataEstagioCartao != null) localVarQueryParams.Add("dataEstagioCartao", Configuration.ApiClient.ParameterToString(dataEstagioCartao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (dataImpressao != null) localVarQueryParams.Add("dataImpressao", Configuration.ApiClient.ParameterToString(dataImpressao)); // query parameter
            if (arquivoImpressao != null) localVarQueryParams.Add("arquivoImpressao", Configuration.ApiClient.ParameterToString(arquivoImpressao)); // query parameter
            if (flagImpressaoOrigemComercial != null) localVarQueryParams.Add("flagImpressaoOrigemComercial", Configuration.ApiClient.ParameterToString(flagImpressaoOrigemComercial)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flagProvisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (codigoDesbloqueio != null) localVarQueryParams.Add("codigoDesbloqueio", Configuration.ApiClient.ParameterToString(codigoDesbloqueio)); // query parameter
            if (sequencialCartao != null) localVarQueryParams.Add("sequencialCartao", Configuration.ApiClient.ParameterToString(sequencialCartao)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }

        
        /// <summary>
        /// List cards made by the Issuer This method allows to list the existent cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param>
        /// <param name="numeroCartao">Show the number of the card (optional)</param>
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param>
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param>
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param>
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param>
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param>
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param>
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param>
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param>
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param>
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param>
        /// <param name="identificadorExterno">External identification number (optional)</param>
        /// <returns>Task of PageCartaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCartaoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
             ApiResponse<PageCartaoResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idStatusCartao, idEstagioCartao, idConta, idPessoa, idProduto, tipoPortador, numeroCartao, nomeImpresso, dataGeracao, dataStatusCartao, dataEstagioCartao, dataValidade, dataImpressao, arquivoImpressao, flagImpressaoOrigemComercial, flagProvisorio, codigoDesbloqueio, sequencialCartao, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List cards made by the Issuer This method allows to list the existent cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusCartao">Identification Code of the Card Status (id) (optional)</param>
        /// <param name="idEstagioCartao">Identification Code of the Printing Stage of the Card (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account which one the card belongs (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which one the card belongs (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product which one the card belongs (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of the Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional (optional)</param>
        /// <param name="numeroCartao">Show the number of the card (optional)</param>
        /// <param name="nomeImpresso">Show the printed name on the card (optional)</param>
        /// <param name="dataGeracao">Show the date when the card was created (optional)</param>
        /// <param name="dataStatusCartao">Show the date which the current idStatusCard of the card was applied, when there is (optional)</param>
        /// <param name="dataEstagioCartao">Show the date which the current idStatusCard of the Card was applied, when there is (optional)</param>
        /// <param name="dataValidade">Show the date of the card expiration in format yyyy-MM, When there is (optional)</param>
        /// <param name="dataImpressao">Show the date which the card was printed, in case of Store printing, or the date which was included in the file for printing in graphic (optional)</param>
        /// <param name="arquivoImpressao">Show the name of the file where the card was included for printing, when thre is (optional)</param>
        /// <param name="flagImpressaoOrigemComercial">when it is activated, it indicates that the card was printed in the Commercial Origin (optional)</param>
        /// <param name="flagProvisorio">When it is activated, it indicates that the card is provisory. By the way, it is a card for a temporary use when allows that the client transacts without having recieved a definitive card (optional)</param>
        /// <param name="codigoDesbloqueio">Show a specific code to be used as a variable in the unlocking process of the card for the issuers who wants to use this functionality (optional)</param>
        /// <param name="sequencialCartao">Sequel Number of the card (optional)</param>
        /// <param name="identificadorExterno">External identification number (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartaoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusCartao = null, long? idEstagioCartao = null, long? idConta = null, long? idPessoa = null, long? idProduto = null, string tipoPortador = null, string numeroCartao = null, string nomeImpresso = null, string dataGeracao = null, string dataStatusCartao = null, string dataEstagioCartao = null, string dataValidade = null, string dataImpressao = null, string arquivoImpressao = null, int? flagImpressaoOrigemComercial = null, int? flagProvisorio = null, string codigoDesbloqueio = null, int? sequencialCartao = null, long? identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes";
    
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
            if (idStatusCartao != null) localVarQueryParams.Add("idStatusCartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (idEstagioCartao != null) localVarQueryParams.Add("idEstagioCartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (dataGeracao != null) localVarQueryParams.Add("dataGeracao", Configuration.ApiClient.ParameterToString(dataGeracao)); // query parameter
            if (dataStatusCartao != null) localVarQueryParams.Add("dataStatusCartao", Configuration.ApiClient.ParameterToString(dataStatusCartao)); // query parameter
            if (dataEstagioCartao != null) localVarQueryParams.Add("dataEstagioCartao", Configuration.ApiClient.ParameterToString(dataEstagioCartao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (dataImpressao != null) localVarQueryParams.Add("dataImpressao", Configuration.ApiClient.ParameterToString(dataImpressao)); // query parameter
            if (arquivoImpressao != null) localVarQueryParams.Add("arquivoImpressao", Configuration.ApiClient.ParameterToString(arquivoImpressao)); // query parameter
            if (flagImpressaoOrigemComercial != null) localVarQueryParams.Add("flagImpressaoOrigemComercial", Configuration.ApiClient.ParameterToString(flagImpressaoOrigemComercial)); // query parameter
            if (flagProvisorio != null) localVarQueryParams.Add("flagProvisorio", Configuration.ApiClient.ParameterToString(flagProvisorio)); // query parameter
            if (codigoDesbloqueio != null) localVarQueryParams.Add("codigoDesbloqueio", Configuration.ApiClient.ParameterToString(codigoDesbloqueio)); // query parameter
            if (sequencialCartao != null) localVarQueryParams.Add("sequencialCartao", Configuration.ApiClient.ParameterToString(sequencialCartao)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoResponse)));
            
        }
        
        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param> 
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param> 
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param> 
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param> 
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param> 
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param> 
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param> 
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param> 
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param> 
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param> 
        /// <returns>PageLoteCartoesPrePagosResponse</returns>
        public PageLoteCartoesPrePagosResponse ListarLotesCartoesPrePagos (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = ListarLotesCartoesPrePagosWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento, identificadorExterno);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param> 
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param> 
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param> 
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param> 
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param> 
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param> 
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param> 
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param> 
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param> 
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param> 
        /// <returns>ApiResponse of PageLoteCartoesPrePagosResponse</returns>
        public ApiResponse< PageLoteCartoesPrePagosResponse > ListarLotesCartoesPrePagosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (statusProcessamento != null) localVarQueryParams.Add("statusProcessamento", Configuration.ApiClient.ParameterToString(statusProcessamento)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }

        
        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param>
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param>
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param>
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param>
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param>
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param>
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param>
        /// <returns>Task of PageLoteCartoesPrePagosResponse</returns>
        public async System.Threading.Tasks.Task<PageLoteCartoesPrePagosResponse> ListarLotesCartoesPrePagosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
             ApiResponse<PageLoteCartoesPrePagosResponse> localVarResponse = await ListarLotesCartoesPrePagosAsyncWithHttpInfo(sort, page, limit, idOrigemComercial, idProduto, idTipoCartao, idImagem, idEndereco, quantidadeCartoes, dataCadastro, usuarioCadastro, statusProcessamento, identificadorExterno);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to list the Lots of Pre-Paid Card This method allows to be listed the exitent pre-paid cards in the base of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idOrigemComercial">Identification Code of the Commercial Origin (id) (optional)</param>
        /// <param name="idProduto">Code of Identification of the Product (id) (optional)</param>
        /// <param name="idTipoCartao">Identification Code of the Card Type (id) (optional)</param>
        /// <param name="idImagem">Identification Code of the Image (id) (optional)</param>
        /// <param name="idEndereco">Identification Code of the Address (id) (optional)</param>
        /// <param name="quantidadeCartoes">Number of existing cards in the Batch (optional)</param>
        /// <param name="dataCadastro">Date of register of the Batch of the non-nominal cards (optional)</param>
        /// <param name="usuarioCadastro">Username that created the Batch (optional)</param>
        /// <param name="statusProcessamento">Indicate the Status of the Batch Processing (optional)</param>
        /// <param name="identificadorExterno">Number of the exeternal identification (used by the issuer) (optional)</param>
        /// <returns>Task of ApiResponse (PageLoteCartoesPrePagosResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageLoteCartoesPrePagosResponse>> ListarLotesCartoesPrePagosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOrigemComercial = null, long? idProduto = null, long? idTipoCartao = null, long? idImagem = null, long? idEndereco = null, int? quantidadeCartoes = null, string dataCadastro = null, string usuarioCadastro = null, int? statusProcessamento = null, string identificadorExterno = null)
        {
            
    
            var localVarPath = "/api/cartoes/lotes-cartoes-pre-pagos";
    
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
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idEndereco != null) localVarQueryParams.Add("idEndereco", Configuration.ApiClient.ParameterToString(idEndereco)); // query parameter
            if (quantidadeCartoes != null) localVarQueryParams.Add("quantidadeCartoes", Configuration.ApiClient.ParameterToString(quantidadeCartoes)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (usuarioCadastro != null) localVarQueryParams.Add("usuarioCadastro", Configuration.ApiClient.ParameterToString(usuarioCadastro)); // query parameter
            if (statusProcessamento != null) localVarQueryParams.Add("statusProcessamento", Configuration.ApiClient.ParameterToString(statusProcessamento)); // query parameter
            if (identificadorExterno != null) localVarQueryParams.Add("identificadorExterno", Configuration.ApiClient.ParameterToString(identificadorExterno)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarLotesCartoesPrePagos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageLoteCartoesPrePagosResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageLoteCartoesPrePagosResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageLoteCartoesPrePagosResponse)));
            
        }
        
        /// <summary>
        /// Do the reactivation of a determined card This method allows the reactivation of a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>CartaoResponse</returns>
        public CartaoResponse Reativar (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = ReativarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Do the reactivation of a determined card This method allows the reactivation of a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <returns>ApiResponse of CartaoResponse</returns>
        public ApiResponse< CartaoResponse > ReativarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->Reativar");
            
    
            var localVarPath = "/api/cartoes/{id}/reativar";
    
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
    
            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }

        
        /// <summary>
        /// Do the reactivation of a determined card This method allows the reactivation of a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of CartaoResponse</returns>
        public async System.Threading.Tasks.Task<CartaoResponse> ReativarAsync (long? id)
        {
             ApiResponse<CartaoResponse> localVarResponse = await ReativarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Do the reactivation of a determined card This method allows the reactivation of a determined card from its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <returns>Task of ApiResponse (CartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoResponse>> ReativarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Reativar");
            
    
            var localVarPath = "/api/cartoes/{id}/reativar";
    
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

            return new ApiResponse<CartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoResponse)));
            
        }
        
        /// <summary>
        /// Validate CVV of the Card This resource allows the validation of the cvv of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param> 
        /// <param name="validaCVV">validaCVV</param> 
        /// <returns>string</returns>
        public string ValidarCVV (long? id, ValidaCVVRequest validaCVV)
        {
             ApiResponse<string> localVarResponse = ValidarCVVWithHttpInfo(id, validaCVV);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate CVV of the Card This resource allows the validation of the cvv of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param> 
        /// <param name="validaCVV">validaCVV</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarCVVWithHttpInfo (long? id, ValidaCVVRequest validaCVV)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ValidarCVV");
            
            // verify the required parameter 'validaCVV' is set
            if (validaCVV == null)
                throw new ApiException(400, "Missing required parameter 'validaCVV' when calling CardApi->ValidarCVV");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-cvv";
    
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
            
            
            
            
            if (validaCVV.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validaCVV); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validaCVV; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Validate CVV of the Card This resource allows the validation of the cvv of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarCVVAsync (long? id, ValidaCVVRequest validaCVV)
        {
             ApiResponse<string> localVarResponse = await ValidarCVVAsyncWithHttpInfo(id, validaCVV);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate CVV of the Card This resource allows the validation of the cvv of the card
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the card (id)</param>
        /// <param name="validaCVV">validaCVV</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarCVVAsyncWithHttpInfo (long? id, ValidaCVVRequest validaCVV)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarCVV");
            // verify the required parameter 'validaCVV' is set
            if (validaCVV == null) throw new ApiException(400, "Missing required parameter 'validaCVV' when calling ValidarCVV");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-cvv";
    
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
            
            
            
            
            if (validaCVV.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validaCVV); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validaCVV; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarCVV: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Allow to validate the printed dates in a flagged card This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param> 
        /// <param name="nomePortador">Cardholder name</param> 
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param> 
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosImpressosBandeirado (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosImpressosBandeiradoWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to validate the printed dates in a flagged card This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param> 
        /// <param name="nomePortador">Cardholder name</param> 
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param> 
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosImpressosBandeiradoWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CardApi->ValidarDadosImpressosBandeirado");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CardApi->ValidarDadosImpressosBandeirado");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CardApi->ValidarDadosImpressosBandeirado");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CardApi->ValidarDadosImpressosBandeirado");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeirado: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeirado: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Allow to validate the printed dates in a flagged card This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param>
        /// <param name="nomePortador">Cardholder name</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosBandeiradoAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosImpressosBandeiradoAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to validate the printed dates in a flagged card This operation has as an aim to allow that the Issuers validate the authenticity of a determined card starting from the sending of the dates  printed on it. The use of this method has many applications, being the mainly one of them the Positive Idetification of the Card for making transactions e-commerce or through the Attendance Eletronic Center (AEC), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validate</param>
        /// <param name="nomePortador">Cardholder name</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosBandeiradoAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosImpressosBandeirado");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosImpressosBandeirado");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosImpressosBandeirado");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosImpressosBandeirado");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeirado: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosBandeirado: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param> 
        /// <param name="nomePortador">Name of the cardholder</param> 
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param> 
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDadosImpressosNaoBandeirado (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDadosImpressosNaoBandeiradoWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param> 
        /// <param name="nomePortador">Name of the cardholder</param> 
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param> 
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDadosImpressosNaoBandeiradoWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CardApi->ValidarDadosImpressosNaoBandeirado");
            
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null)
                throw new ApiException(400, "Missing required parameter 'nomePortador' when calling CardApi->ValidarDadosImpressosNaoBandeirado");
            
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null)
                throw new ApiException(400, "Missing required parameter 'dataValidade' when calling CardApi->ValidarDadosImpressosNaoBandeirado");
            
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null)
                throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling CardApi->ValidarDadosImpressosNaoBandeirado");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-nao-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeirado: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeirado: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="nomePortador">Name of the cardholder</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDadosImpressosNaoBandeiradoAsync (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDadosImpressosNaoBandeiradoAsyncWithHttpInfo(numeroCartao, nomePortador, dataValidade, codigoSeguranca);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to validate the printed dates of a non-flagged card This operation has as an aim to allow the issuers validate the authenticity of a determined Card from de printed dates on it.The use of this methode has a lot of  application, such as  the Positive Identification of the Card to do transactions e-commerce or through Attendance Eletronic Center (URA), etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="nomePortador">Name of the cardholder</param>
        /// <param name="dataValidade">Expiration date of the card in the format yyyy-MM</param>
        /// <param name="codigoSeguranca">Security Code of the card with three numbers</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDadosImpressosNaoBandeiradoAsyncWithHttpInfo (string numeroCartao, string nomePortador, string dataValidade, string codigoSeguranca)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDadosImpressosNaoBandeirado");
            // verify the required parameter 'nomePortador' is set
            if (nomePortador == null) throw new ApiException(400, "Missing required parameter 'nomePortador' when calling ValidarDadosImpressosNaoBandeirado");
            // verify the required parameter 'dataValidade' is set
            if (dataValidade == null) throw new ApiException(400, "Missing required parameter 'dataValidade' when calling ValidarDadosImpressosNaoBandeirado");
            // verify the required parameter 'codigoSeguranca' is set
            if (codigoSeguranca == null) throw new ApiException(400, "Missing required parameter 'codigoSeguranca' when calling ValidarDadosImpressosNaoBandeirado");
            
    
            var localVarPath = "/api/cartoes/validar-dados-impressos-nao-bandeirados";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (nomePortador != null) localVarQueryParams.Add("nome_portador", Configuration.ApiClient.ParameterToString(nomePortador)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("data_validade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (codigoSeguranca != null) localVarQueryParams.Add("codigo_seguranca", Configuration.ApiClient.ParameterToString(codigoSeguranca)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeirado: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDadosImpressosNaoBandeirado: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55 This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param> 
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarDe55CartaoMastercard (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarDe55CartaoMastercardWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55 This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param> 
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarDe55CartaoMastercardWithHttpInfo (string numeroCartao, string criptograma)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CardApi->ValidarDe55CartaoMastercard");
            
            // verify the required parameter 'criptograma' is set
            if (criptograma == null)
                throw new ApiException(400, "Missing required parameter 'criptograma' when calling CardApi->ValidarDe55CartaoMastercard");
            
    
            var localVarPath = "/api/cartoes/validar-de55-mastercard";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (criptograma != null) localVarQueryParams.Add("criptograma", Configuration.ApiClient.ParameterToString(criptograma)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55 This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarDe55CartaoMastercardAsync (string numeroCartao, string criptograma)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarDe55CartaoMastercardAsyncWithHttpInfo(numeroCartao, criptograma);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to validate a Card with the Mastercard Flag from de55 This operation has as an aim to allow the Issuers validate DE55 created from the reading of a EMV chip of a Mastercard Flg in order to verify its authenticity. The use of this method has many applications, being one of the main one the Positive Identification of the Card before the issuer do radom transactions, such as shopping and withdraw in debt in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card number to be validate</param>
        /// <param name="criptograma">Criptograma do cart?o no formato de55</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarDe55CartaoMastercardAsyncWithHttpInfo (string numeroCartao, string criptograma)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarDe55CartaoMastercard");
            // verify the required parameter 'criptograma' is set
            if (criptograma == null) throw new ApiException(400, "Missing required parameter 'criptograma' when calling ValidarDe55CartaoMastercard");
            
    
            var localVarPath = "/api/cartoes/validar-de55-mastercard";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (criptograma != null) localVarQueryParams.Add("criptograma", Configuration.ApiClient.ParameterToString(criptograma)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarDe55CartaoMastercard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Allow validate the password of a Card This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="senha">Password to be validated</param> 
        /// <returns>ValidaSenhaCartaoResponse</returns>
        public ValidaSenhaCartaoResponse ValidarSenha (long? id, string senha)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = ValidarSenhaWithHttpInfo(id, senha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow validate the password of a Card This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param> 
        /// <param name="senha">Password to be validated</param> 
        /// <returns>ApiResponse of ValidaSenhaCartaoResponse</returns>
        public ApiResponse< ValidaSenhaCartaoResponse > ValidarSenhaWithHttpInfo (long? id, string senha)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CardApi->ValidarSenha");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling CardApi->ValidarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Allow validate the password of a Card This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be validated</param>
        /// <returns>Task of ValidaSenhaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaSenhaCartaoResponse> ValidarSenhaAsync (long? id, string senha)
        {
             ApiResponse<ValidaSenhaCartaoResponse> localVarResponse = await ValidarSenhaAsyncWithHttpInfo(id, senha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow validate the password of a Card This operation has as an aim to allow validating that the password informed by the carrier of a determined card are right
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Card (id)</param>
        /// <param name="senha">Password to be validated</param>
        /// <returns>Task of ApiResponse (ValidaSenhaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaSenhaCartaoResponse>> ValidarSenhaAsyncWithHttpInfo (long? id, string senha)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenha");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenha");
            
    
            var localVarPath = "/api/cartoes/{id}/validar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaSenhaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaSenhaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaSenhaCartaoResponse)));
            
        }
        
        /// <summary>
        /// Allow validate the Flagged Card through the targe This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param> 
        /// <param name="trilha1">Trail 1 of the card to be validate</param> 
        /// <param name="trilha2">Trail 2 of the card to be validate</param> 
        /// <returns>ValidaCartaoResponse</returns>
        public ValidaCartaoResponse ValidarTarja (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = ValidarTarjaWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow validate the Flagged Card through the targe This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param> 
        /// <param name="trilha1">Trail 1 of the card to be validate</param> 
        /// <param name="trilha2">Trail 2 of the card to be validate</param> 
        /// <returns>ApiResponse of ValidaCartaoResponse</returns>
        public ApiResponse< ValidaCartaoResponse > ValidarTarjaWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null)
                throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling CardApi->ValidarTarja");
            
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null)
                throw new ApiException(400, "Missing required parameter 'trilha1' when calling CardApi->ValidarTarja");
            
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null)
                throw new ApiException(400, "Missing required parameter 'trilha2' when calling CardApi->ValidarTarja");
            
    
            var localVarPath = "/api/cartoes/validar-tarja";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (trilha1 != null) localVarQueryParams.Add("trilha1", Configuration.ApiClient.ParameterToString(trilha1)); // query parameter
            if (trilha2 != null) localVarQueryParams.Add("trilha2", Configuration.ApiClient.ParameterToString(trilha2)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }

        
        /// <summary>
        /// Allow validate the Flagged Card through the targe This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param>
        /// <param name="trilha1">Trail 1 of the card to be validate</param>
        /// <param name="trilha2">Trail 2 of the card to be validate</param>
        /// <returns>Task of ValidaCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ValidaCartaoResponse> ValidarTarjaAsync (string numeroCartao, string trilha1, string trilha2)
        {
             ApiResponse<ValidaCartaoResponse> localVarResponse = await ValidarTarjaAsyncWithHttpInfo(numeroCartao, trilha1, trilha2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow validate the Flagged Card through the targe This operation has as an aim to permit that the issuers the authenticity of a determined Card by the reading magnetic targe. The use of this methode has a lot of  application, such as  the Positive Identification of the Card before allowing the cardholder do lots of transactions, such as shopping and withdraw in debt modality  in a current account, etc
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroCartao">Card Number to be validated</param>
        /// <param name="trilha1">Trail 1 of the card to be validate</param>
        /// <param name="trilha2">Trail 2 of the card to be validate</param>
        /// <returns>Task of ApiResponse (ValidaCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidaCartaoResponse>> ValidarTarjaAsyncWithHttpInfo (string numeroCartao, string trilha1, string trilha2)
        {
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ValidarTarja");
            // verify the required parameter 'trilha1' is set
            if (trilha1 == null) throw new ApiException(400, "Missing required parameter 'trilha1' when calling ValidarTarja");
            // verify the required parameter 'trilha2' is set
            if (trilha2 == null) throw new ApiException(400, "Missing required parameter 'trilha2' when calling ValidarTarja");
            
    
            var localVarPath = "/api/cartoes/validar-tarja";
    
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
            
            if (numeroCartao != null) localVarQueryParams.Add("numero_cartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (trilha1 != null) localVarQueryParams.Add("trilha1", Configuration.ApiClient.ParameterToString(trilha1)); // query parameter
            if (trilha2 != null) localVarQueryParams.Add("trilha2", Configuration.ApiClient.ParameterToString(trilha2)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarTarja: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ValidaCartaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ValidaCartaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidaCartaoResponse)));
            
        }
        
    }
    
}
