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
    public interface IGeneralRegisterApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the dates of the campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param>
        /// <param name="update">update</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse Alterar (long? id, CampaignUpdate update);
  
        /// <summary>
        /// Update Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the dates of the campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> AlterarWithHttpInfo (long? id, CampaignUpdate update);
        
        /// <summary>
        /// Update a covenant
        /// </summary>
        /// <remarks>
        /// Update a covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse AlterarConvenio (long? id, ConvenioPersist convenioPersist);
  
        /// <summary>
        /// Update a covenant
        /// </summary>
        /// <remarks>
        /// Update a covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> AlterarConvenioWithHttpInfo (long? id, ConvenioPersist convenioPersist);
        
        /// <summary>
        /// updates the provision for the cut from the due date
        /// </summary>
        /// <remarks>
        /// updates the provision for the cut from the due date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="update">update</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ControleVencimentoResponse</returns>
        ControleVencimentoResponse AlterarCorte (string dataVencimento, VencimentoUpdate update, string login = null);
  
        /// <summary>
        /// updates the provision for the cut from the due date
        /// </summary>
        /// <remarks>
        /// updates the provision for the cut from the due date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="update">update</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of ControleVencimentoResponse</returns>
        ApiResponse<ControleVencimentoResponse> AlterarCorteWithHttpInfo (string dataVencimento, VencimentoUpdate update, string login = null);
        
        /// <summary>
        /// Edits an operation type
        /// </summary>
        /// <remarks>
        /// Edits operation type fields that were passed through the request object
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse AlterarParcial (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
  
        /// <summary>
        /// Edits an operation type
        /// </summary>
        /// <remarks>
        /// Edits operation type fields that were passed through the request object
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> AlterarParcialWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
        
        /// <summary>
        /// Update configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to update a configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Alterar_0 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// Update configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to update a configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Alterar_0WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse Alterar_1 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> Alterar_1WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// Insert configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Cadastrar (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// Insert configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> CadastrarWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Adds new covenant
        /// </summary>
        /// <remarks>
        /// Adds new covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse CadastrarConvenio (ConvenioPersist convenioPersist);
  
        /// <summary>
        /// Adds new covenant
        /// </summary>
        /// <remarks>
        /// Adds new covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> CadastrarConvenioWithHttpInfo (ConvenioPersist convenioPersist);
        
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
        /// Present the dates of a determined Attendance
        /// </summary>
        /// <remarks>
        /// This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse Consultar (long? id);
  
        /// <summary>
        /// Present the dates of a determined Attendance
        /// </summary>
        /// <remarks>
        /// This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Search Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse ConsultarCampanha (long? id);
  
        /// <summary>
        /// Search Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> ConsultarCampanhaWithHttpInfo (long? id);
        
        /// <summary>
        /// Consult bank details of a particular agreement
        /// </summary>
        /// <remarks>
        /// Query bank details by agreement id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse ConsultarConvenio (long? id);
  
        /// <summary>
        /// Consult bank details of a particular agreement
        /// </summary>
        /// <remarks>
        /// Query bank details by agreement id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> ConsultarConvenioWithHttpInfo (long? id);
        
        /// <summary>
        /// List the product rate packages
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the product rate packages
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageProdutoPacoteTarifaResponse</returns>
        PageProdutoPacoteTarifaResponse ConsultarProdutoPacoteTarifa (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the product rate packages
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the product rate packages
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageProdutoPacoteTarifaResponse</returns>
        ApiResponse<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
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
        /// Present the dates of a determined Bank
        /// </summary>
        /// <remarks>
        /// This method allows to search a determined Bank starting from your ID code
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param>
        /// <returns>BancoResponse</returns>
        BancoResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Present the dates of a determined Bank
        /// </summary>
        /// <remarks>
        /// This method allows to search a determined Bank starting from your ID code
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param>
        /// <returns>ApiResponse of BancoResponse</returns>
        ApiResponse<BancoResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to find a configuration, for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Consultar_1 (long? id);
  
        /// <summary>
        /// Retrieve configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to find a configuration, for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// Show dates of a configuration of an specific revolving
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse Consultar_2 (long? id);
  
        /// <summary>
        /// Show dates of a configuration of an specific revolving
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> Consultar_2WithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the dates of a determined Product
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Product using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param>
        /// <returns>ProdutoDetalhesResponse</returns>
        ProdutoDetalhesResponse Consultar_3 (long? id);
  
        /// <summary>
        /// Retrieve the dates of a determined Product
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Product using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param>
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        ApiResponse<ProdutoDetalhesResponse> Consultar_3WithHttpInfo (long? id);
        
        /// <summary>
        /// Query a Transaction Type
        /// </summary>
        /// <remarks>
        /// Query a Transaction Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param>
        /// <returns>TipoAjusteResponse</returns>
        TipoAjusteResponse Consultar_4 (long? id);
  
        /// <summary>
        /// Query a Transaction Type
        /// </summary>
        /// <remarks>
        /// Query a Transaction Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param>
        /// <returns>ApiResponse of TipoAjusteResponse</returns>
        ApiResponse<TipoAjusteResponse> Consultar_4WithHttpInfo (long? id);
        
        /// <summary>
        /// List the types of slips of the Issuer
        /// </summary>
        /// <remarks>
        /// this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param>
        /// <param name="descricao">Description of the bank slip type (optional)</param>
        /// <param name="banco">Identifier Code of the Bank (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse Consultar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
  
        /// <summary>
        /// List the types of slips of the Issuer
        /// </summary>
        /// <remarks>
        /// this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param>
        /// <param name="descricao">Description of the bank slip type (optional)</param>
        /// <param name="banco">Identifier Code of the Bank (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> Consultar_5WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// List the dates of a determined Type of Address
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param>
        /// <returns>TipoEnderecoResponse</returns>
        TipoEnderecoResponse Consultar_6 (long? id);
  
        /// <summary>
        /// List the dates of a determined Type of Address
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param>
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        ApiResponse<TipoEnderecoResponse> Consultar_6WithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined type of operation
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param>
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param>
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse Consultar_7 (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
  
        /// <summary>
        /// List the dates of a determined type of operation
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param>
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param>
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> Consultar_7WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// List the dates of a determined Type of Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param>
        /// <returns>TipoTelefoneResponse</returns>
        TipoTelefoneResponse Consultar_8 (long? id);
  
        /// <summary>
        /// List the dates of a determined Type of Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param>
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        ApiResponse<TipoTelefoneResponse> Consultar_8WithHttpInfo (long? id);
        
        /// <summary>
        /// List all the attendances
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Attendance Register, regardlessof the Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param>
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param>
        /// <returns>PageAtendimentoClienteResponse</returns>
        PageAtendimentoClienteResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
  
        /// <summary>
        /// List all the attendances
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Attendance Register, regardlessof the Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param>
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param>
        /// <returns>ApiResponse of PageAtendimentoClienteResponse</returns>
        ApiResponse<PageAtendimentoClienteResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// List Campaigns
        /// </summary>
        /// <remarks>
        /// List the Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param>
        /// <returns>PageCampanhaResponse</returns>
        PageCampanhaResponse ListarCampanhas (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
  
        /// <summary>
        /// List Campaigns
        /// </summary>
        /// <remarks>
        /// List the Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param>
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        ApiResponse<PageCampanhaResponse> ListarCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
        
        /// <summary>
        /// List bank details of existing agreements
        /// </summary>
        /// <remarks>
        /// List bank details of existing agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Bank Id (optional)</param>
        /// <param name="agencia">Agency Number (optional)</param>
        /// <param name="contaCorrente">Current Account (optional)</param>
        /// <param name="numeroConvenio">Number Convenant (optional)</param>
        /// <returns>PageConvenioResponse</returns>
        PageConvenioResponse ListarConvenios (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
  
        /// <summary>
        /// List bank details of existing agreements
        /// </summary>
        /// <remarks>
        /// List bank details of existing agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Bank Id (optional)</param>
        /// <param name="agencia">Agency Number (optional)</param>
        /// <param name="contaCorrente">Current Account (optional)</param>
        /// <param name="numeroConvenio">Number Convenant (optional)</param>
        /// <returns>ApiResponse of PageConvenioResponse</returns>
        ApiResponse<PageConvenioResponse> ListarConveniosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
        
        /// <summary>
        /// List Marital Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Marital Status in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarEstadosCivis (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List Marital Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Marital Status in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista the Basic Fantasies
        /// </summary>
        /// <remarks>
        /// List the Basic Fantasies
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageFantasiaBasicaResponse</returns>
        PageFantasiaBasicaResponse ListarFantasiasBasicas (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista the Basic Fantasies
        /// </summary>
        /// <remarks>
        /// List the Basic Fantasies
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageFantasiaBasicaResponse</returns>
        ApiResponse<PageFantasiaBasicaResponse> ListarFantasiasBasicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listnationalities
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nationalities in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNacionalidades (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listnationalities
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nationalities in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List of the Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nature of the operations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoes (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List of the Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nature of the operations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List of Parentage
        /// </summary>
        /// <remarks>
        /// This method allows to be listed  parentage in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarParentescos (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List of Parentage
        /// </summary>
        /// <remarks>
        /// This method allows to be listed  parentage in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarParentescosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List  Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the occupations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarProfissoes (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List  Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the occupations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarProfissoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List types of Campaigns
        /// </summary>
        /// <remarks>
        /// List the types of Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoCampanhaResponse</returns>
        PageTipoCampanhaResponse ListarTiposCampanhas (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List types of Campaigns
        /// </summary>
        /// <remarks>
        /// List the types of Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoCampanhaResponse</returns>
        ApiResponse<PageTipoCampanhaResponse> ListarTiposCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List of the Banks created for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent Banks in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageBancoResponse</returns>
        PageBancoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List of the Banks created for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent Banks in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageBancoResponse</returns>
        ApiResponse<PageBancoResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List configurations for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List configurations for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the revolving configuration
        /// </summary>
        /// <remarks>
        /// This resource allows to list the revolving configuration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (optional)</param>
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        PageConfiguracaoRotativoResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
  
        /// <summary>
        /// List the revolving configuration
        /// </summary>
        /// <remarks>
        /// This resource allows to list the revolving configuration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        ApiResponse<PageConfiguracaoRotativoResponse> Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// List the existing Cardholders
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the cardholders registered in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param>
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param>
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param>
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param>
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param>
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param>
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param>
        /// <returns>PagePortadorResponse</returns>
        PagePortadorResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
  
        /// <summary>
        /// List the existing Cardholders
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the cardholders registered in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param>
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param>
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param>
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param>
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param>
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param>
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param>
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        ApiResponse<PagePortadorResponse> Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// List the Products of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Products in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Description of the Product Name (optional)</param>
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param>
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param>
        /// <returns>PageProdutoResponse</returns>
        PageProdutoResponse Listar_4 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
  
        /// <summary>
        /// List the Products of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Products in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Description of the Product Name (optional)</param>
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param>
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param>
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        ApiResponse<PageProdutoResponse> Listar_4WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// List promoters registered in the base of the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param>
        /// <param name="nome">Prosecutor Name (optional)</param>
        /// <param name="dataCadastro">Inclusion date (optional)</param>
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param>
        /// <param name="idUsuario">Identification Code of the user (optional)</param>
        /// <returns>PagePromotorResponse</returns>
        PagePromotorResponse Listar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
  
        /// <summary>
        /// List promoters registered in the base of the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param>
        /// <param name="nome">Prosecutor Name (optional)</param>
        /// <param name="dataCadastro">Inclusion date (optional)</param>
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param>
        /// <param name="idUsuario">Identification Code of the user (optional)</param>
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        ApiResponse<PagePromotorResponse> Listar_5WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// List the types of adjustments of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of type of adjust (optional)</param>
        /// <param name="descricao">Description of the type of adjust (optional)</param>
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param>
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param>
        /// <returns>PageTipoAjusteResponse</returns>
        PageTipoAjusteResponse Listar_6 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
  
        /// <summary>
        /// List the types of adjustments of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of type of adjust (optional)</param>
        /// <param name="descricao">Description of the type of adjust (optional)</param>
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param>
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param>
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        ApiResponse<PageTipoAjusteResponse> Listar_6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
        
        /// <summary>
        /// List the options of Types of Addresses of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param>
        /// <param name="nome">Name of Type of the Address (optional)</param>
        /// <returns>PageTipoEnderecoResponse</returns>
        PageTipoEnderecoResponse Listar_7 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// List the options of Types of Addresses of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param>
        /// <param name="nome">Name of Type of the Address (optional)</param>
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        ApiResponse<PageTipoEnderecoResponse> Listar_7WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// List the Types of Telephones
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="nome">Telephone type name (optional)</param>
        /// <returns>PageTipoTelefoneResponse</returns>
        PageTipoTelefoneResponse Listar_8 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// List the Types of Telephones
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="nome">Telephone type name (optional)</param>
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        ApiResponse<PageTipoTelefoneResponse> Listar_8WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// List Expiration
        /// </summary>
        /// <remarks>
        /// This resource allows to ve listed the expirations of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param>
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param>
        /// <returns>PageControleVencimentoResponse</returns>
        PageControleVencimentoResponse Listar_9 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
  
        /// <summary>
        /// List Expiration
        /// </summary>
        /// <remarks>
        /// This resource allows to ve listed the expirations of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param>
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param>
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        ApiResponse<PageControleVencimentoResponse> Listar_9WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        /// <summary>
        /// Create a new Attendance of Generic type for a new Account
        /// </summary>
        /// <remarks>
        /// This Method allows register a new generic attendances for a Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param>
        /// <param name="conteudoAtendimento">Attendance content (optional)</param>
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse Salvar (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
  
        /// <summary>
        /// Create a new Attendance of Generic type for a new Account
        /// </summary>
        /// <remarks>
        /// This Method allows register a new generic attendances for a Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param>
        /// <param name="conteudoAtendimento">Attendance content (optional)</param>
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> SalvarWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// Insert campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse Salvar_0 (CampanhaPersist campanhaPersist);
  
        /// <summary>
        /// Insert campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> Salvar_0WithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// Insert the configuration dates of a revolving of the product
        /// </summary>
        /// <remarks>
        /// This method allows to be registred a new configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse Salvar_1 (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// Insert the configuration dates of a revolving of the product
        /// </summary>
        /// <remarks>
        /// This method allows to be registred a new configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> Salvar_1WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the dates of the campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> AlterarAsync (long? id, CampaignUpdate update);

        /// <summary>
        /// Update Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be updated the dates of the campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarAsyncWithHttpInfo (long? id, CampaignUpdate update);
        
        /// <summary>
        /// Update a covenant
        /// </summary>
        /// <remarks>
        /// Update a covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> AlterarConvenioAsync (long? id, ConvenioPersist convenioPersist);

        /// <summary>
        /// Update a covenant
        /// </summary>
        /// <remarks>
        /// Update a covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> AlterarConvenioAsyncWithHttpInfo (long? id, ConvenioPersist convenioPersist);
        
        /// <summary>
        /// updates the provision for the cut from the due date
        /// </summary>
        /// <remarks>
        /// updates the provision for the cut from the due date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="update">update</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ControleVencimentoResponse</returns>
        System.Threading.Tasks.Task<ControleVencimentoResponse> AlterarCorteAsync (string dataVencimento, VencimentoUpdate update, string login = null);

        /// <summary>
        /// updates the provision for the cut from the due date
        /// </summary>
        /// <remarks>
        /// updates the provision for the cut from the due date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="update">update</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (ControleVencimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleVencimentoResponse>> AlterarCorteAsyncWithHttpInfo (string dataVencimento, VencimentoUpdate update, string login = null);
        
        /// <summary>
        /// Edits an operation type
        /// </summary>
        /// <remarks>
        /// Edits operation type fields that were passed through the request object
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> AlterarParcialAsync (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);

        /// <summary>
        /// Edits an operation type
        /// </summary>
        /// <remarks>
        /// Edits operation type fields that were passed through the request object
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> AlterarParcialAsyncWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
        
        /// <summary>
        /// Update configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to update a configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Alterar_0Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// Update configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to update a configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Alterar_0AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Alterar_1Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// Insert configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> CadastrarAsync (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// Insert configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> CadastrarAsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Adds new covenant
        /// </summary>
        /// <remarks>
        /// Adds new covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> CadastrarConvenioAsync (ConvenioPersist convenioPersist);

        /// <summary>
        /// Adds new covenant
        /// </summary>
        /// <remarks>
        /// Adds new covenant
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> CadastrarConvenioAsyncWithHttpInfo (ConvenioPersist convenioPersist);
        
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
        /// Present the dates of a determined Attendance
        /// </summary>
        /// <remarks>
        /// This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Present the dates of a determined Attendance
        /// </summary>
        /// <remarks>
        /// This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Search Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaAsync (long? id);

        /// <summary>
        /// Search Campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> ConsultarCampanhaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consult bank details of a particular agreement
        /// </summary>
        /// <remarks>
        /// Query bank details by agreement id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> ConsultarConvenioAsync (long? id);

        /// <summary>
        /// Consult bank details of a particular agreement
        /// </summary>
        /// <remarks>
        /// Query bank details by agreement id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> ConsultarConvenioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the product rate packages
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the product rate packages
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageProdutoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the product rate packages
        /// </summary>
        /// <remarks>
        /// This feature allows you to list the product rate packages
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoPacoteTarifaResponse>> ConsultarProdutoPacoteTarifaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
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
        /// Present the dates of a determined Bank
        /// </summary>
        /// <remarks>
        /// This method allows to search a determined Bank starting from your ID code
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param>
        /// <returns>Task of BancoResponse</returns>
        System.Threading.Tasks.Task<BancoResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Present the dates of a determined Bank
        /// </summary>
        /// <remarks>
        /// This method allows to search a determined Bank starting from your ID code
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BancoResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to find a configuration, for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Consultar_1Async (long? id);

        /// <summary>
        /// Retrieve configuration for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to find a configuration, for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Show dates of a configuration of an specific revolving
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Consultar_2Async (long? id);

        /// <summary>
        /// Show dates of a configuration of an specific revolving
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Retrieve the dates of a determined Product
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Product using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        System.Threading.Tasks.Task<ProdutoDetalhesResponse> Consultar_3Async (long? id);

        /// <summary>
        /// Retrieve the dates of a determined Product
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Product using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> Consultar_3AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Query a Transaction Type
        /// </summary>
        /// <remarks>
        /// Query a Transaction Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param>
        /// <returns>Task of TipoAjusteResponse</returns>
        System.Threading.Tasks.Task<TipoAjusteResponse> Consultar_4Async (long? id);

        /// <summary>
        /// Query a Transaction Type
        /// </summary>
        /// <remarks>
        /// Query a Transaction Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param>
        /// <returns>Task of ApiResponse (TipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoAjusteResponse>> Consultar_4AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the types of slips of the Issuer
        /// </summary>
        /// <remarks>
        /// this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param>
        /// <param name="descricao">Description of the bank slip type (optional)</param>
        /// <param name="banco">Identifier Code of the Bank (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> Consultar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);

        /// <summary>
        /// List the types of slips of the Issuer
        /// </summary>
        /// <remarks>
        /// this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param>
        /// <param name="descricao">Description of the bank slip type (optional)</param>
        /// <param name="banco">Identifier Code of the Bank (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> Consultar_5AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// List the dates of a determined Type of Address
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<TipoEnderecoResponse> Consultar_6Async (long? id);

        /// <summary>
        /// List the dates of a determined Type of Address
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> Consultar_6AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined type of operation
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param>
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param>
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> Consultar_7Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento);

        /// <summary>
        /// List the dates of a determined type of operation
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param>
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param>
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> Consultar_7AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// List the dates of a determined Type of Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<TipoTelefoneResponse> Consultar_8Async (long? id);

        /// <summary>
        /// List the dates of a determined Type of Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> Consultar_8AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List all the attendances
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Attendance Register, regardlessof the Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param>
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);

        /// <summary>
        /// List all the attendances
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Attendance Register, regardlessof the Type
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param>
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param>
        /// <returns>Task of ApiResponse (PageAtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAtendimentoClienteResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// List Campaigns
        /// </summary>
        /// <remarks>
        /// List the Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);

        /// <summary>
        /// List Campaigns
        /// </summary>
        /// <remarks>
        /// List the Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
        
        /// <summary>
        /// List bank details of existing agreements
        /// </summary>
        /// <remarks>
        /// List bank details of existing agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Bank Id (optional)</param>
        /// <param name="agencia">Agency Number (optional)</param>
        /// <param name="contaCorrente">Current Account (optional)</param>
        /// <param name="numeroConvenio">Number Convenant (optional)</param>
        /// <returns>Task of PageConvenioResponse</returns>
        System.Threading.Tasks.Task<PageConvenioResponse> ListarConveniosAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);

        /// <summary>
        /// List bank details of existing agreements
        /// </summary>
        /// <remarks>
        /// List bank details of existing agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Bank Id (optional)</param>
        /// <param name="agencia">Agency Number (optional)</param>
        /// <param name="contaCorrente">Current Account (optional)</param>
        /// <param name="numeroConvenio">Number Convenant (optional)</param>
        /// <returns>Task of ApiResponse (PageConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConvenioResponse>> ListarConveniosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
        
        /// <summary>
        /// List Marital Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Marital Status in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List Marital Status
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Marital Status in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarEstadosCivisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista the Basic Fantasies
        /// </summary>
        /// <remarks>
        /// List the Basic Fantasies
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista the Basic Fantasies
        /// </summary>
        /// <remarks>
        /// List the Basic Fantasies
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFantasiaBasicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFantasiaBasicaResponse>> ListarFantasiasBasicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listnationalities
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nationalities in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listnationalities
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nationalities in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNacionalidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List of the Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nature of the operations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List of the Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the nature of the operations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNaturezasOcupacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List of Parentage
        /// </summary>
        /// <remarks>
        /// This method allows to be listed  parentage in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List of Parentage
        /// </summary>
        /// <remarks>
        /// This method allows to be listed  parentage in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarParentescosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List  Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the occupations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List  Occupations
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the occupations in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarProfissoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List types of Campaigns
        /// </summary>
        /// <remarks>
        /// List the types of Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List types of Campaigns
        /// </summary>
        /// <remarks>
        /// List the types of Campaigns
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoCampanhaResponse>> ListarTiposCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List of the Banks created for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent Banks in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        System.Threading.Tasks.Task<PageBancoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List of the Banks created for the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent Banks in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageBancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBancoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List configurations for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List configurations for the register of collection
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration for the register of collection
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the revolving configuration
        /// </summary>
        /// <remarks>
        /// This resource allows to list the revolving configuration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);

        /// <summary>
        /// List the revolving configuration
        /// </summary>
        /// <remarks>
        /// This resource allows to list the revolving configuration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// List the existing Cardholders
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the cardholders registered in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param>
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param>
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param>
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param>
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param>
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param>
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        System.Threading.Tasks.Task<PagePortadorResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);

        /// <summary>
        /// List the existing Cardholders
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the cardholders registered in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param>
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param>
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param>
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param>
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param>
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param>
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// List the Products of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Products in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Description of the Product Name (optional)</param>
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param>
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        System.Threading.Tasks.Task<PageProdutoResponse> Listar_4Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);

        /// <summary>
        /// List the Products of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existing Products in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Description of the Product Name (optional)</param>
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param>
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> Listar_4AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// List promoters registered in the base of the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param>
        /// <param name="nome">Prosecutor Name (optional)</param>
        /// <param name="dataCadastro">Inclusion date (optional)</param>
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param>
        /// <param name="idUsuario">Identification Code of the user (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        System.Threading.Tasks.Task<PagePromotorResponse> Listar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);

        /// <summary>
        /// List promoters registered in the base of the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param>
        /// <param name="nome">Prosecutor Name (optional)</param>
        /// <param name="dataCadastro">Inclusion date (optional)</param>
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param>
        /// <param name="idUsuario">Identification Code of the user (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> Listar_5AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// List the types of adjustments of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of type of adjust (optional)</param>
        /// <param name="descricao">Description of the type of adjust (optional)</param>
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param>
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        System.Threading.Tasks.Task<PageTipoAjusteResponse> Listar_6Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);

        /// <summary>
        /// List the types of adjustments of the issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of type of adjust (optional)</param>
        /// <param name="descricao">Description of the type of adjust (optional)</param>
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param>
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> Listar_6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
        
        /// <summary>
        /// List the options of Types of Addresses of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param>
        /// <param name="nome">Name of Type of the Address (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageTipoEnderecoResponse> Listar_7Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// List the options of Types of Addresses of the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param>
        /// <param name="nome">Name of Type of the Address (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> Listar_7AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// List the Types of Telephones
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="nome">Telephone type name (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTipoTelefoneResponse> Listar_8Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// List the Types of Telephones
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="nome">Telephone type name (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> Listar_8AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// List Expiration
        /// </summary>
        /// <remarks>
        /// This resource allows to ve listed the expirations of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param>
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        System.Threading.Tasks.Task<PageControleVencimentoResponse> Listar_9Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);

        /// <summary>
        /// List Expiration
        /// </summary>
        /// <remarks>
        /// This resource allows to ve listed the expirations of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param>
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> Listar_9AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        /// <summary>
        /// Create a new Attendance of Generic type for a new Account
        /// </summary>
        /// <remarks>
        /// This Method allows register a new generic attendances for a Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param>
        /// <param name="conteudoAtendimento">Attendance content (optional)</param>
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarAsync (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);

        /// <summary>
        /// Create a new Attendance of Generic type for a new Account
        /// </summary>
        /// <remarks>
        /// This Method allows register a new generic attendances for a Account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param>
        /// <param name="conteudoAtendimento">Attendance content (optional)</param>
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> SalvarAsyncWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// Insert campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> Salvar_0Async (CampanhaPersist campanhaPersist);

        /// <summary>
        /// Insert campaign
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new campaign
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> Salvar_0AsyncWithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// Insert the configuration dates of a revolving of the product
        /// </summary>
        /// <remarks>
        /// This method allows to be registred a new configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Salvar_1Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// Insert the configuration dates of a revolving of the product
        /// </summary>
        /// <remarks>
        /// This method allows to be registred a new configuration of the revolving for a determined product
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Salvar_1AsyncWithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GeneralRegisterApi : IGeneralRegisterApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRegisterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeneralRegisterApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRegisterApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GeneralRegisterApi(Configuration configuration = null)
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
        /// Update Campaign This method allows to be updated the dates of the campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse Alterar (long? id, CampaignUpdate update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = AlterarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Campaign This method allows to be updated the dates of the campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > AlterarWithHttpInfo (long? id, CampaignUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Alterar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GeneralRegisterApi->Alterar");
            
    
            var localVarPath = "/api/campanhas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// Update Campaign This method allows to be updated the dates of the campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> AlterarAsync (long? id, CampaignUpdate update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Campaign This method allows to be updated the dates of the campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the campaign (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarAsyncWithHttpInfo (long? id, CampaignUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Alterar");
            
    
            var localVarPath = "/api/campanhas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// Update a covenant Update a covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ConvenioResponse</returns>
        public ConvenioResponse AlterarConvenio (long? id, ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = AlterarConvenioWithHttpInfo(id, convenioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a covenant Update a covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > AlterarConvenioWithHttpInfo (long? id, ConvenioPersist convenioPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->AlterarConvenio");
            
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null)
                throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling GeneralRegisterApi->AlterarConvenio");
            
    
            var localVarPath = "/api/convenios/{id}";
    
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
            
            
            
            
            if (convenioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(convenioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = convenioPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }

        
        /// <summary>
        /// Update a covenant Update a covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        public async System.Threading.Tasks.Task<ConvenioResponse> AlterarConvenioAsync (long? id, ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = await AlterarConvenioAsyncWithHttpInfo(id, convenioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a covenant Update a covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> AlterarConvenioAsyncWithHttpInfo (long? id, ConvenioPersist convenioPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarConvenio");
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null) throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling AlterarConvenio");
            
    
            var localVarPath = "/api/convenios/{id}";
    
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
            
            
            
            
            if (convenioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(convenioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = convenioPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }
        
        /// <summary>
        /// updates the provision for the cut from the due date updates the provision for the cut from the due date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param> 
        /// <param name="update">update</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ControleVencimentoResponse</returns>
        public ControleVencimentoResponse AlterarCorte (string dataVencimento, VencimentoUpdate update, string login = null)
        {
             ApiResponse<ControleVencimentoResponse> localVarResponse = AlterarCorteWithHttpInfo(dataVencimento, update, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// updates the provision for the cut from the due date updates the provision for the cut from the due date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param> 
        /// <param name="update">update</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of ControleVencimentoResponse</returns>
        public ApiResponse< ControleVencimentoResponse > AlterarCorteWithHttpInfo (string dataVencimento, VencimentoUpdate update, string login = null)
        {
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GeneralRegisterApi->AlterarCorte");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GeneralRegisterApi->AlterarCorte");
            
    
            var localVarPath = "/api/vencimentos/{dataVencimento}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorte: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorte: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleVencimentoResponse)));
            
        }

        
        /// <summary>
        /// updates the provision for the cut from the due date updates the provision for the cut from the due date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="update">update</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ControleVencimentoResponse</returns>
        public async System.Threading.Tasks.Task<ControleVencimentoResponse> AlterarCorteAsync (string dataVencimento, VencimentoUpdate update, string login = null)
        {
             ApiResponse<ControleVencimentoResponse> localVarResponse = await AlterarCorteAsyncWithHttpInfo(dataVencimento, update, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// updates the provision for the cut from the due date updates the provision for the cut from the due date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="update">update</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (ControleVencimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleVencimentoResponse>> AlterarCorteAsyncWithHttpInfo (string dataVencimento, VencimentoUpdate update, string login = null)
        {
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling AlterarCorte");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarCorte");
            
    
            var localVarPath = "/api/vencimentos/{dataVencimento}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorte: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorte: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleVencimentoResponse)));
            
        }
        
        /// <summary>
        /// Edits an operation type Edits operation type fields that were passed through the request object
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param> 
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse AlterarParcial (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = AlterarParcialWithHttpInfo(id, tipoOperacaoParcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edits an operation type Edits operation type fields that were passed through the request object
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param> 
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > AlterarParcialWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->AlterarParcial");
            
            // verify the required parameter 'tipoOperacaoParcialUpdate' is set
            if (tipoOperacaoParcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'tipoOperacaoParcialUpdate' when calling GeneralRegisterApi->AlterarParcial");
            
    
            var localVarPath = "/api/tipos-operacoes/{id}";
    
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
            
            
            
            
            if (tipoOperacaoParcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoOperacaoParcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoOperacaoParcialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Edits an operation type Edits operation type fields that were passed through the request object
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> AlterarParcialAsync (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await AlterarParcialAsyncWithHttpInfo(id, tipoOperacaoParcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edits an operation type Edits operation type fields that were passed through the request object
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Operation Type Id</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> AlterarParcialAsyncWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarParcial");
            // verify the required parameter 'tipoOperacaoParcialUpdate' is set
            if (tipoOperacaoParcialUpdate == null) throw new ApiException(400, "Missing required parameter 'tipoOperacaoParcialUpdate' when calling AlterarParcial");
            
    
            var localVarPath = "/api/tipos-operacoes/{id}";
    
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
            
            
            
            
            if (tipoOperacaoParcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoOperacaoParcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoOperacaoParcialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Update configuration for the register of collection This method allows to update a configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Alterar_0 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Alterar_0WithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update configuration for the register of collection This method allows to update a configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > Alterar_0WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Alterar_0");
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling GeneralRegisterApi->Alterar_0");
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca/{id}";
    
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
            
            
            
            
            if (configuracaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Update configuration for the register of collection This method allows to update a configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Alterar_0Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Alterar_0AsyncWithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update configuration for the register of collection This method allows to update a configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Configuration (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Alterar_0AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_0");
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling Alterar_0");
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca/{id}";
    
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
            
            
            
            
            if (configuracaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto This method allows to be updated a configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse Alterar_1 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = Alterar_1WithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto This method allows to be updated a configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > Alterar_1WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Alterar_1");
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling GeneralRegisterApi->Alterar_1");
            
    
            var localVarPath = "/api/configuracoes-rotativos/{id}";
    
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
            
            
            
            
            if (configuracaoRotativoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoRotativoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoRotativoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto This method allows to be updated a configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Alterar_1Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await Alterar_1AsyncWithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar os dados de configura??o do rotativo de um produto This method allows to be updated a configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificatication Code of the configuration (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_1");
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling Alterar_1");
            
    
            var localVarPath = "/api/configuracoes-rotativos/{id}";
    
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
            
            
            
            
            if (configuracaoRotativoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoRotativoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoRotativoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Insert configuration for the register of collection This method allows to be created a new configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Cadastrar (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = CadastrarWithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insert configuration for the register of collection This method allows to be created a new configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > CadastrarWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling GeneralRegisterApi->Cadastrar");
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca";
    
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
            
            
            
            
            if (configuracaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Insert configuration for the register of collection This method allows to be created a new configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> CadastrarAsync (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await CadastrarAsyncWithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insert configuration for the register of collection This method allows to be created a new configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> CadastrarAsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling Cadastrar");
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca";
    
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
            
            
            
            
            if (configuracaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Adds new covenant Adds new covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ConvenioResponse</returns>
        public ConvenioResponse CadastrarConvenio (ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = CadastrarConvenioWithHttpInfo(convenioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adds new covenant Adds new covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > CadastrarConvenioWithHttpInfo (ConvenioPersist convenioPersist)
        {
            
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null)
                throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling GeneralRegisterApi->CadastrarConvenio");
            
    
            var localVarPath = "/api/convenios";
    
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
            
            
            
            
            if (convenioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(convenioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = convenioPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }

        
        /// <summary>
        /// Adds new covenant Adds new covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        public async System.Threading.Tasks.Task<ConvenioResponse> CadastrarConvenioAsync (ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = await CadastrarConvenioAsyncWithHttpInfo(convenioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adds new covenant Adds new covenant
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> CadastrarConvenioAsyncWithHttpInfo (ConvenioPersist convenioPersist)
        {
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null) throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling CadastrarConvenio");
            
    
            var localVarPath = "/api/convenios";
    
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
            
            
            
            
            if (convenioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(convenioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = convenioPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->ConfigurarTaxaAntecipacao");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling GeneralRegisterApi->ConfigurarTaxaAntecipacao");
            
    
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
        /// Present the dates of a determined Attendance This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse Consultar (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Present the dates of a determined Attendance This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param> 
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        public ApiResponse< AtendimentoClienteResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar");
            
    
            var localVarPath = "/api/atendimento-clientes/{id}";
    
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
    
            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// Present the dates of a determined Attendance This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarAsync (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Present the dates of a determined Attendance This method allows searching the parameters of determined Attendance starting from your ID code (idAttendance)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Client Attedance (id)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/atendimento-clientes/{id}";
    
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

            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// Search Campaign This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse ConsultarCampanha (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = ConsultarCampanhaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Campaign This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > ConsultarCampanhaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->ConsultarCampanha");
            
    
            var localVarPath = "/api/campanhas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// Search Campaign This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaAsync (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await ConsultarCampanhaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Campaign This method allows to be listed the dates of a determined existent campaign  in the base of the issuer. So, It&#39;s necessary to inform the respective code of identification (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Campaign</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> ConsultarCampanhaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCampanha");
            
    
            var localVarPath = "/api/campanhas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanha: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanha: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// Consult bank details of a particular agreement Query bank details by agreement id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ConvenioResponse</returns>
        public ConvenioResponse ConsultarConvenio (long? id)
        {
             ApiResponse<ConvenioResponse> localVarResponse = ConsultarConvenioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consult bank details of a particular agreement Query bank details by agreement id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > ConsultarConvenioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->ConsultarConvenio");
            
    
            var localVarPath = "/api/convenios/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }

        
        /// <summary>
        /// Consult bank details of a particular agreement Query bank details by agreement id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ConvenioResponse</returns>
        public async System.Threading.Tasks.Task<ConvenioResponse> ConsultarConvenioAsync (long? id)
        {
             ApiResponse<ConvenioResponse> localVarResponse = await ConsultarConvenioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consult bank details of a particular agreement Query bank details by agreement id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> ConsultarConvenioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarConvenio");
            
    
            var localVarPath = "/api/convenios/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }
        
        /// <summary>
        /// List the product rate packages This feature allows you to list the product rate packages
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageProdutoPacoteTarifaResponse</returns>
        public PageProdutoPacoteTarifaResponse ConsultarProdutoPacoteTarifa (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageProdutoPacoteTarifaResponse> localVarResponse = ConsultarProdutoPacoteTarifaWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the product rate packages This feature allows you to list the product rate packages
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageProdutoPacoteTarifaResponse</returns>
        public ApiResponse< PageProdutoPacoteTarifaResponse > ConsultarProdutoPacoteTarifaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->ConsultarProdutoPacoteTarifa");
            
    
            var localVarPath = "/api/produtos/{id}/pacotes-tarifas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageProdutoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoPacoteTarifaResponse)));
            
        }

        
        /// <summary>
        /// List the product rate packages This feature allows you to list the product rate packages
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageProdutoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageProdutoPacoteTarifaResponse> localVarResponse = await ConsultarProdutoPacoteTarifaAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the product rate packages This feature allows you to list the product rate packages
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Product identification code (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoPacoteTarifaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageProdutoPacoteTarifaResponse>> ConsultarProdutoPacoteTarifaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarProdutoPacoteTarifa");
            
    
            var localVarPath = "/api/produtos/{id}/pacotes-tarifas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageProdutoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoPacoteTarifaResponse)));
            
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->ConsultarTaxaAntecipacao");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling GeneralRegisterApi->ConsultarTaxaAntecipacao");
            
    
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
        /// Present the dates of a determined Bank This method allows to search a determined Bank starting from your ID code
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param> 
        /// <returns>BancoResponse</returns>
        public BancoResponse Consultar_0 (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Present the dates of a determined Bank This method allows to search a determined Bank starting from your ID code
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param> 
        /// <returns>ApiResponse of BancoResponse</returns>
        public ApiResponse< BancoResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_0");
            
    
            var localVarPath = "/api/bancos/{id}";
    
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
    
            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }

        
        /// <summary>
        /// Present the dates of a determined Bank This method allows to search a determined Bank starting from your ID code
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param>
        /// <returns>Task of BancoResponse</returns>
        public async System.Threading.Tasks.Task<BancoResponse> Consultar_0Async (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Present the dates of a determined Bank This method allows to search a determined Bank starting from your ID code
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Bank (id)</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BancoResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/bancos/{id}";
    
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

            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }
        
        /// <summary>
        /// Retrieve configuration for the register of collection This method allows to find a configuration, for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Consultar_1 (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve configuration for the register of collection This method allows to find a configuration, for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_1");
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca/{id}";
    
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
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Retrieve configuration for the register of collection This method allows to find a configuration, for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Consultar_1Async (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve configuration for the register of collection This method allows to find a configuration, for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the configuration (id)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Consultar_1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_1");
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca/{id}";
    
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

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Show dates of a configuration of an specific revolving This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse Consultar_2 (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = Consultar_2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show dates of a configuration of an specific revolving This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > Consultar_2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_2");
            
    
            var localVarPath = "/api/configuracoes-rotativos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Show dates of a configuration of an specific revolving This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Consultar_2Async (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await Consultar_2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show dates of a configuration of an specific revolving This resource allows to retrieve configuration dates of a revolving installment by the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the revolving configuration (id)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_2");
            
    
            var localVarPath = "/api/configuracoes-rotativos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the dates of a determined Product This method allows to retrieve a determined Product using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param> 
        /// <returns>ProdutoDetalhesResponse</returns>
        public ProdutoDetalhesResponse Consultar_3 (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = Consultar_3WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the dates of a determined Product This method allows to retrieve a determined Product using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param> 
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        public ApiResponse< ProdutoDetalhesResponse > Consultar_3WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_3");
            
    
            var localVarPath = "/api/produtos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProdutoDetalhesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProdutoDetalhesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProdutoDetalhesResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the dates of a determined Product This method allows to retrieve a determined Product using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        public async System.Threading.Tasks.Task<ProdutoDetalhesResponse> Consultar_3Async (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = await Consultar_3AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the dates of a determined Product This method allows to retrieve a determined Product using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Product (id)</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> Consultar_3AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_3");
            
    
            var localVarPath = "/api/produtos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProdutoDetalhesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProdutoDetalhesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProdutoDetalhesResponse)));
            
        }
        
        /// <summary>
        /// Query a Transaction Type Query a Transaction Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param> 
        /// <returns>TipoAjusteResponse</returns>
        public TipoAjusteResponse Consultar_4 (long? id)
        {
             ApiResponse<TipoAjusteResponse> localVarResponse = Consultar_4WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a Transaction Type Query a Transaction Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param> 
        /// <returns>ApiResponse of TipoAjusteResponse</returns>
        public ApiResponse< TipoAjusteResponse > Consultar_4WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_4");
            
    
            var localVarPath = "/api/tipos-ajustes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoAjusteResponse)));
            
        }

        
        /// <summary>
        /// Query a Transaction Type Query a Transaction Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param>
        /// <returns>Task of TipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<TipoAjusteResponse> Consultar_4Async (long? id)
        {
             ApiResponse<TipoAjusteResponse> localVarResponse = await Consultar_4AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a Transaction Type Query a Transaction Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transation Type Id</param>
        /// <returns>Task of ApiResponse (TipoAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoAjusteResponse>> Consultar_4AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_4");
            
    
            var localVarPath = "/api/tipos-ajustes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoAjusteResponse)));
            
        }
        
        /// <summary>
        /// List the types of slips of the Issuer this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param> 
        /// <param name="descricao">Description of the bank slip type (optional)</param> 
        /// <param name="banco">Identifier Code of the Bank (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse Consultar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = Consultar_5WithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the types of slips of the Issuer this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param> 
        /// <param name="descricao">Description of the bank slip type (optional)</param> 
        /// <param name="banco">Identifier Code of the Bank (optional)</param> 
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        public ApiResponse< PageTipoBoletoResponse > Consultar_5WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
            
    
            var localVarPath = "/api/tipos-boletos";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }

        
        /// <summary>
        /// List the types of slips of the Issuer this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param>
        /// <param name="descricao">Description of the bank slip type (optional)</param>
        /// <param name="banco">Identifier Code of the Bank (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> Consultar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await Consultar_5AsyncWithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the types of slips of the Issuer this resource allows to be listed all the types of existing slips in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of the Bank Slip (optional)</param>
        /// <param name="descricao">Description of the bank slip type (optional)</param>
        /// <param name="banco">Identifier Code of the Bank (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> Consultar_5AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
            
    
            var localVarPath = "/api/tipos-boletos";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Type of Address This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param> 
        /// <returns>TipoEnderecoResponse</returns>
        public TipoEnderecoResponse Consultar_6 (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = Consultar_6WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Type of Address This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param> 
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        public ApiResponse< TipoEnderecoResponse > Consultar_6WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_6");
            
    
            var localVarPath = "/api/tipos-enderecos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Type of Address This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<TipoEnderecoResponse> Consultar_6Async (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = await Consultar_6AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Type of Address This method allows to retrieve a determined Type of Address using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address Type (id)</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> Consultar_6AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_6");
            
    
            var localVarPath = "/api/tipos-enderecos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined type of operation This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param> 
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param> 
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse Consultar_7 (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = Consultar_7WithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined type of operation This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param> 
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param> 
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > Consultar_7WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling GeneralRegisterApi->Consultar_7");
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling GeneralRegisterApi->Consultar_7");
            
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null)
                throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling GeneralRegisterApi->Consultar_7");
            
    
            var localVarPath = "/api/tipos-operacoes";
    
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
            
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined type of operation This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param>
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param>
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> Consultar_7Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await Consultar_7AsyncWithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined type of operation This resource allows to retrieve dates of a determined type of operation using the idCard, idEstablishment and Processingcode
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">Identification Code of the Card (idCard)</param>
        /// <param name="idEstabelecimento">Identification Code of the Merchant (idMerchant)</param>
        /// <param name="codigoProcessamento">C?digo de processamento da opera??o</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> Consultar_7AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling Consultar_7");
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null) throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling Consultar_7");
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null) throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling Consultar_7");
            
    
            var localVarPath = "/api/tipos-operacoes";
    
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
            
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Type of Telephone This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param> 
        /// <returns>TipoTelefoneResponse</returns>
        public TipoTelefoneResponse Consultar_8 (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = Consultar_8WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Type of Telephone This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param> 
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        public ApiResponse< TipoTelefoneResponse > Consultar_8WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GeneralRegisterApi->Consultar_8");
            
    
            var localVarPath = "/api/tipos-telefones/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Type of Telephone This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TipoTelefoneResponse> Consultar_8Async (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = await Consultar_8AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Type of Telephone This method allows to retrieve a determined Type of Telephone using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone Type (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> Consultar_8AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_8");
            
    
            var localVarPath = "/api/tipos-telefones/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// List all the attendances This method allows to be listed the Attendance Register, regardlessof the Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param> 
        /// <param name="idConta">Identification Code of the account (id) (optional)</param> 
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param> 
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param> 
        /// <returns>PageAtendimentoClienteResponse</returns>
        public PageAtendimentoClienteResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all the attendances This method allows to be listed the Attendance Register, regardlessof the Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param> 
        /// <param name="idConta">Identification Code of the account (id) (optional)</param> 
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param> 
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param> 
        /// <returns>ApiResponse of PageAtendimentoClienteResponse</returns>
        public ApiResponse< PageAtendimentoClienteResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
            
    
            var localVarPath = "/api/atendimento-clientes";
    
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
            if (idTipoAtendimento != null) localVarQueryParams.Add("idTipoAtendimento", Configuration.ApiClient.ParameterToString(idTipoAtendimento)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (nomeAtendente != null) localVarQueryParams.Add("nomeAtendente", Configuration.ApiClient.ParameterToString(nomeAtendente)); // query parameter
            if (dataAtendimento != null) localVarQueryParams.Add("dataAtendimento", Configuration.ApiClient.ParameterToString(dataAtendimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// List all the attendances This method allows to be listed the Attendance Register, regardlessof the Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param>
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all the attendances This method allows to be listed the Attendance Register, regardlessof the Type
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">Identification Code of the Type of Attendance (id) (optional)</param>
        /// <param name="idConta">Identification Code of the account (id) (optional)</param>
        /// <param name="nomeAtendente">Show the name of the Attendant that registered the Attendance (optional)</param>
        /// <param name="dataAtendimento">Show the date that the Attendance was made (optional)</param>
        /// <returns>Task of ApiResponse (PageAtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAtendimentoClienteResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
            
    
            var localVarPath = "/api/atendimento-clientes";
    
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
            if (idTipoAtendimento != null) localVarQueryParams.Add("idTipoAtendimento", Configuration.ApiClient.ParameterToString(idTipoAtendimento)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (nomeAtendente != null) localVarQueryParams.Add("nomeAtendente", Configuration.ApiClient.ParameterToString(nomeAtendente)); // query parameter
            if (dataAtendimento != null) localVarQueryParams.Add("dataAtendimento", Configuration.ApiClient.ParameterToString(dataAtendimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// List Campaigns List the Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param> 
        /// <returns>PageCampanhaResponse</returns>
        public PageCampanhaResponse ListarCampanhas (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = ListarCampanhasWithHttpInfo(sort, page, limit, idTipoCampanha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Campaigns List the Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param> 
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        public ApiResponse< PageCampanhaResponse > ListarCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
            
    
            var localVarPath = "/api/campanhas";
    
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
            if (idTipoCampanha != null) localVarQueryParams.Add("idTipoCampanha", Configuration.ApiClient.ParameterToString(idTipoCampanha)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampanhaResponse)));
            
        }

        
        /// <summary>
        /// List Campaigns List the Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = await ListarCampanhasAsyncWithHttpInfo(sort, page, limit, idTipoCampanha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Campaigns List the Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">Identification Code of the Type of campaign (id) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
            
    
            var localVarPath = "/api/campanhas";
    
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
            if (idTipoCampanha != null) localVarQueryParams.Add("idTipoCampanha", Configuration.ApiClient.ParameterToString(idTipoCampanha)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampanhaResponse)));
            
        }
        
        /// <summary>
        /// List bank details of existing agreements List bank details of existing agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="banco">Bank Id (optional)</param> 
        /// <param name="agencia">Agency Number (optional)</param> 
        /// <param name="contaCorrente">Current Account (optional)</param> 
        /// <param name="numeroConvenio">Number Convenant (optional)</param> 
        /// <returns>PageConvenioResponse</returns>
        public PageConvenioResponse ListarConvenios (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
             ApiResponse<PageConvenioResponse> localVarResponse = ListarConveniosWithHttpInfo(sort, page, limit, banco, agencia, contaCorrente, numeroConvenio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List bank details of existing agreements List bank details of existing agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="banco">Bank Id (optional)</param> 
        /// <param name="agencia">Agency Number (optional)</param> 
        /// <param name="contaCorrente">Current Account (optional)</param> 
        /// <param name="numeroConvenio">Number Convenant (optional)</param> 
        /// <returns>ApiResponse of PageConvenioResponse</returns>
        public ApiResponse< PageConvenioResponse > ListarConveniosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
            
    
            var localVarPath = "/api/convenios";
    
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
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (numeroConvenio != null) localVarQueryParams.Add("numeroConvenio", Configuration.ApiClient.ParameterToString(numeroConvenio)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarConvenios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConvenios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConvenioResponse)));
            
        }

        
        /// <summary>
        /// List bank details of existing agreements List bank details of existing agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Bank Id (optional)</param>
        /// <param name="agencia">Agency Number (optional)</param>
        /// <param name="contaCorrente">Current Account (optional)</param>
        /// <param name="numeroConvenio">Number Convenant (optional)</param>
        /// <returns>Task of PageConvenioResponse</returns>
        public async System.Threading.Tasks.Task<PageConvenioResponse> ListarConveniosAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
             ApiResponse<PageConvenioResponse> localVarResponse = await ListarConveniosAsyncWithHttpInfo(sort, page, limit, banco, agencia, contaCorrente, numeroConvenio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List bank details of existing agreements List bank details of existing agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Bank Id (optional)</param>
        /// <param name="agencia">Agency Number (optional)</param>
        /// <param name="contaCorrente">Current Account (optional)</param>
        /// <param name="numeroConvenio">Number Convenant (optional)</param>
        /// <returns>Task of ApiResponse (PageConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConvenioResponse>> ListarConveniosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
            
    
            var localVarPath = "/api/convenios";
    
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
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (numeroConvenio != null) localVarQueryParams.Add("numeroConvenio", Configuration.ApiClient.ParameterToString(numeroConvenio)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarConvenios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConvenios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConvenioResponse)));
            
        }
        
        /// <summary>
        /// List Marital Status This method allows to be listed the Marital Status in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarEstadosCivis (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarEstadosCivisWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Marital Status This method allows to be listed the Marital Status in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarEstadosCivisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/estados-civis";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivis: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivis: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// List Marital Status This method allows to be listed the Marital Status in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarEstadosCivisAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Marital Status This method allows to be listed the Marital Status in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarEstadosCivisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/estados-civis";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivis: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivis: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Lista the Basic Fantasies List the Basic Fantasies
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageFantasiaBasicaResponse</returns>
        public PageFantasiaBasicaResponse ListarFantasiasBasicas (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = ListarFantasiasBasicasWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista the Basic Fantasies List the Basic Fantasies
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageFantasiaBasicaResponse</returns>
        public ApiResponse< PageFantasiaBasicaResponse > ListarFantasiasBasicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/fantasias-basicas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFantasiaBasicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFantasiaBasicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFantasiaBasicaResponse)));
            
        }

        
        /// <summary>
        /// Lista the Basic Fantasies List the Basic Fantasies
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        public async System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = await ListarFantasiasBasicasAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista the Basic Fantasies List the Basic Fantasies
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFantasiaBasicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFantasiaBasicaResponse>> ListarFantasiasBasicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/fantasias-basicas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFantasiaBasicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFantasiaBasicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFantasiaBasicaResponse)));
            
        }
        
        /// <summary>
        /// Listnationalities This method allows to be listed the nationalities in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNacionalidades (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNacionalidadesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listnationalities This method allows to be listed the nationalities in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarNacionalidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/nacionalidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Listnationalities This method allows to be listed the nationalities in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNacionalidadesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listnationalities This method allows to be listed the nationalities in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNacionalidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/nacionalidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// List of the Occupations This method allows to be listed the nature of the operations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoes (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNaturezasOcupacoesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of the Occupations This method allows to be listed the nature of the operations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarNaturezasOcupacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/ocupacoes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// List of the Occupations This method allows to be listed the nature of the operations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNaturezasOcupacoesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of the Occupations This method allows to be listed the nature of the operations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNaturezasOcupacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/ocupacoes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// List of Parentage This method allows to be listed  parentage in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarParentescos (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarParentescosWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of Parentage This method allows to be listed  parentage in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarParentescosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/parentescos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// List of Parentage This method allows to be listed  parentage in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarParentescosAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of Parentage This method allows to be listed  parentage in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarParentescosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/parentescos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// List  Occupations This method allows to be listed the occupations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarProfissoes (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarProfissoesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List  Occupations This method allows to be listed the occupations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarProfissoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/profissoes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// List  Occupations This method allows to be listed the occupations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarProfissoesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List  Occupations This method allows to be listed the occupations in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarProfissoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/profissoes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// List types of Campaigns List the types of Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoCampanhaResponse</returns>
        public PageTipoCampanhaResponse ListarTiposCampanhas (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = ListarTiposCampanhasWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List types of Campaigns List the types of Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoCampanhaResponse</returns>
        public ApiResponse< PageTipoCampanhaResponse > ListarTiposCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-campanhas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoCampanhaResponse)));
            
        }

        
        /// <summary>
        /// List types of Campaigns List the types of Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = await ListarTiposCampanhasAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List types of Campaigns List the types of Campaigns
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoCampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoCampanhaResponse>> ListarTiposCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-campanhas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoCampanhaResponse)));
            
        }
        
        /// <summary>
        /// List of the Banks created for the Issuer This method allows to be listed the existent Banks in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageBancoResponse</returns>
        public PageBancoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of the Banks created for the Issuer This method allows to be listed the existent Banks in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageBancoResponse</returns>
        public ApiResponse< PageBancoResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/bancos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBancoResponse)));
            
        }

        
        /// <summary>
        /// List of the Banks created for the Issuer This method allows to be listed the existent Banks in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        public async System.Threading.Tasks.Task<PageBancoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of the Banks created for the Issuer This method allows to be listed the existent Banks in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageBancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBancoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/bancos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBancoResponse)));
            
        }
        
        /// <summary>
        /// List configurations for the register of collection This method allows to list the configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Listar_1WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List configurations for the register of collection This method allows to list the configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// List configurations for the register of collection This method allows to list the configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List configurations for the register of collection This method allows to list the configuration for the register of collection
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/configuracoes-registro-cobranca";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// List the revolving configuration This resource allows to list the revolving configuration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Product (optional)</param> 
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        public PageConfiguracaoRotativoResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = Listar_2WithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the revolving configuration This resource allows to list the revolving configuration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Product (optional)</param> 
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        public ApiResponse< PageConfiguracaoRotativoResponse > Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/configuracoes-rotativos";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConfiguracaoRotativoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoRotativoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoRotativoResponse)));
            
        }

        
        /// <summary>
        /// List the revolving configuration This resource allows to list the revolving configuration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = await Listar_2AsyncWithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the revolving configuration This resource allows to list the revolving configuration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/configuracoes-rotativos";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConfiguracaoRotativoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoRotativoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoRotativoResponse)));
            
        }
        
        /// <summary>
        /// List the existing Cardholders This method allows to be listed the cardholders registered in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param> 
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param> 
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param> 
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param> 
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param> 
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param> 
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param> 
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param> 
        /// <returns>PagePortadorResponse</returns>
        public PagePortadorResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = Listar_3WithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the existing Cardholders This method allows to be listed the cardholders registered in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param> 
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param> 
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param> 
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param> 
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param> 
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param> 
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param> 
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param> 
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param> 
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        public ApiResponse< PagePortadorResponse > Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
            
    
            var localVarPath = "/api/portadores";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idParentesco != null) localVarQueryParams.Add("idParentesco", Configuration.ApiClient.ParameterToString(idParentesco)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (dataCadastroPortador != null) localVarQueryParams.Add("dataCadastroPortador", Configuration.ApiClient.ParameterToString(dataCadastroPortador)); // query parameter
            if (dataCancelamentoPortador != null) localVarQueryParams.Add("dataCancelamentoPortador", Configuration.ApiClient.ParameterToString(dataCancelamentoPortador)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorResponse)));
            
        }

        
        /// <summary>
        /// List the existing Cardholders This method allows to be listed the cardholders registered in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param>
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param>
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param>
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param>
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param>
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param>
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        public async System.Threading.Tasks.Task<PagePortadorResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = await Listar_3AsyncWithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the existing Cardholders This method allows to be listed the cardholders registered in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the Account (id) (optional)</param>
        /// <param name="idProduto">Identification Code of the Product (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Perso (id) (optional)</param>
        /// <param name="idParentesco">Identification Code of Kinship (id) (optional)</param>
        /// <param name="tipoPortador">Show the type of Cardholder, being: (&#39;T&#39;: Holder, &#39;A&#39;: Additional) (optional)</param>
        /// <param name="nomeImpresso">Show the name to be printed on the card (optional)</param>
        /// <param name="idTipoCartao">Show the identification code of the type of the Card (id), that it will be used to create the cards of this cardholder, linked to a respective account through the fiel idAccount (optional)</param>
        /// <param name="flagAtivo">When it is active, it indicates that the cardholder register is active, in issuers that do this type of management (optional)</param>
        /// <param name="dataCadastroPortador">Show the date which the cardholder was registered, when there is this information (optional)</param>
        /// <param name="dataCancelamentoPortador">Show the date which the cardholder that was canceled, when there is this information (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
            
    
            var localVarPath = "/api/portadores";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idParentesco != null) localVarQueryParams.Add("idParentesco", Configuration.ApiClient.ParameterToString(idParentesco)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (dataCadastroPortador != null) localVarQueryParams.Add("dataCadastroPortador", Configuration.ApiClient.ParameterToString(dataCadastroPortador)); // query parameter
            if (dataCancelamentoPortador != null) localVarQueryParams.Add("dataCancelamentoPortador", Configuration.ApiClient.ParameterToString(dataCancelamentoPortador)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorResponse)));
            
        }
        
        /// <summary>
        /// List the Products of the Issuer This method allows to be listed the existing Products in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Description of the Product Name (optional)</param> 
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param> 
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param> 
        /// <returns>PageProdutoResponse</returns>
        public PageProdutoResponse Listar_4 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = Listar_4WithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the Products of the Issuer This method allows to be listed the existing Products in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Description of the Product Name (optional)</param> 
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param> 
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param> 
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        public ApiResponse< PageProdutoResponse > Listar_4WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
            
    
            var localVarPath = "/api/produtos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idFantasiaBasica != null) localVarQueryParams.Add("idFantasiaBasica", Configuration.ApiClient.ParameterToString(idFantasiaBasica)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoResponse)));
            
        }

        
        /// <summary>
        /// List the Products of the Issuer This method allows to be listed the existing Products in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Description of the Product Name (optional)</param>
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param>
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoResponse> Listar_4Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = await Listar_4AsyncWithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the Products of the Issuer This method allows to be listed the existing Products in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Description of the Product Name (optional)</param>
        /// <param name="status">Represent the Status of the Product, where: (&#39;0&#39;: Inactive), (&#39;1&#39;: Active) (optional)</param>
        /// <param name="idFantasiaBasica">Identification Code of the Basic Fantasy (id) which the product belongs (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> Listar_4AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
            
    
            var localVarPath = "/api/produtos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idFantasiaBasica != null) localVarQueryParams.Add("idFantasiaBasica", Configuration.ApiClient.ParameterToString(idFantasiaBasica)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoResponse)));
            
        }
        
        /// <summary>
        /// List promoters registered in the base of the issuer This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param> 
        /// <param name="nome">Prosecutor Name (optional)</param> 
        /// <param name="dataCadastro">Inclusion date (optional)</param> 
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param> 
        /// <param name="idUsuario">Identification Code of the user (optional)</param> 
        /// <returns>PagePromotorResponse</returns>
        public PagePromotorResponse Listar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = Listar_5WithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List promoters registered in the base of the issuer This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param> 
        /// <param name="nome">Prosecutor Name (optional)</param> 
        /// <param name="dataCadastro">Inclusion date (optional)</param> 
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param> 
        /// <param name="idUsuario">Identification Code of the user (optional)</param> 
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        public ApiResponse< PagePromotorResponse > Listar_5WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
            
    
            var localVarPath = "/api/promotores";
    
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
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePromotorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePromotorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePromotorResponse)));
            
        }

        
        /// <summary>
        /// List promoters registered in the base of the issuer This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param>
        /// <param name="nome">Prosecutor Name (optional)</param>
        /// <param name="dataCadastro">Inclusion date (optional)</param>
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param>
        /// <param name="idUsuario">Identification Code of the user (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        public async System.Threading.Tasks.Task<PagePromotorResponse> Listar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = await Listar_5AsyncWithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List promoters registered in the base of the issuer This method allows to be listed the register of existing Promoters in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Prosecutor (id) (optional)</param>
        /// <param name="nome">Prosecutor Name (optional)</param>
        /// <param name="dataCadastro">Inclusion date (optional)</param>
        /// <param name="idEstabelecimento">Identification Code of the Establishment (optional)</param>
        /// <param name="idUsuario">Identification Code of the user (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> Listar_5AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
            
    
            var localVarPath = "/api/promotores";
    
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
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePromotorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePromotorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePromotorResponse)));
            
        }
        
        /// <summary>
        /// List the types of adjustments of the issuer This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identifier Code of type of adjust (optional)</param> 
        /// <param name="descricao">Description of the type of adjust (optional)</param> 
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param> 
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param> 
        /// <returns>PageTipoAjusteResponse</returns>
        public PageTipoAjusteResponse Listar_6 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = Listar_6WithHttpInfo(sort, page, limit, id, descricao, flagPagamentoLojista, flagSistema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the types of adjustments of the issuer This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identifier Code of type of adjust (optional)</param> 
        /// <param name="descricao">Description of the type of adjust (optional)</param> 
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param> 
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param> 
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        public ApiResponse< PageTipoAjusteResponse > Listar_6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
            
    
            var localVarPath = "/api/tipos-ajustes";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagPagamentoLojista != null) localVarQueryParams.Add("flagPagamentoLojista", Configuration.ApiClient.ParameterToString(flagPagamentoLojista)); // query parameter
            if (flagSistema != null) localVarQueryParams.Add("flagSistema", Configuration.ApiClient.ParameterToString(flagSistema)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoAjusteResponse)));
            
        }

        
        /// <summary>
        /// List the types of adjustments of the issuer This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of type of adjust (optional)</param>
        /// <param name="descricao">Description of the type of adjust (optional)</param>
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param>
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoAjusteResponse> Listar_6Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = await Listar_6AsyncWithHttpInfo(sort, page, limit, id, descricao, flagPagamentoLojista, flagSistema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the types of adjustments of the issuer This resource allows to be listed the types of existing adjustments in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identifier Code of type of adjust (optional)</param>
        /// <param name="descricao">Description of the type of adjust (optional)</param>
        /// <param name="flagPagamentoLojista">Identifies whether the payment was made in an establishment (optional)</param>
        /// <param name="flagSistema">Identifies whether the ajust type was made by system (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> Listar_6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
            
    
            var localVarPath = "/api/tipos-ajustes";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagPagamentoLojista != null) localVarQueryParams.Add("flagPagamentoLojista", Configuration.ApiClient.ParameterToString(flagPagamentoLojista)); // query parameter
            if (flagSistema != null) localVarQueryParams.Add("flagSistema", Configuration.ApiClient.ParameterToString(flagSistema)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoAjusteResponse)));
            
        }
        
        /// <summary>
        /// List the options of Types of Addresses of the Issuer This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param> 
        /// <param name="nome">Name of Type of the Address (optional)</param> 
        /// <returns>PageTipoEnderecoResponse</returns>
        public PageTipoEnderecoResponse Listar_7 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = Listar_7WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the options of Types of Addresses of the Issuer This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param> 
        /// <param name="nome">Name of Type of the Address (optional)</param> 
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        public ApiResponse< PageTipoEnderecoResponse > Listar_7WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-enderecos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// List the options of Types of Addresses of the Issuer This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param>
        /// <param name="nome">Name of Type of the Address (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoEnderecoResponse> Listar_7Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = await Listar_7AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the options of Types of Addresses of the Issuer This method allows to be listed the Types of existing Addresses in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of Type of the Address (id) (optional)</param>
        /// <param name="nome">Name of Type of the Address (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> Listar_7AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-enderecos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// List the Types of Telephones This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param> 
        /// <param name="nome">Telephone type name (optional)</param> 
        /// <returns>PageTipoTelefoneResponse</returns>
        public PageTipoTelefoneResponse Listar_8 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = Listar_8WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the Types of Telephones This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param> 
        /// <param name="nome">Telephone type name (optional)</param> 
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        public ApiResponse< PageTipoTelefoneResponse > Listar_8WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-telefones";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// List the Types of Telephones This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="nome">Telephone type name (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTelefoneResponse> Listar_8Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = await Listar_8AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the Types of Telephones This method allows to be listed the Types of Telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="nome">Telephone type name (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> Listar_8AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-telefones";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// List Expiration This resource allows to ve listed the expirations of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param> 
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param> 
        /// <returns>PageControleVencimentoResponse</returns>
        public PageControleVencimentoResponse Listar_9 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = Listar_9WithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Expiration This resource allows to ve listed the expirations of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param> 
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param> 
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        public ApiResponse< PageControleVencimentoResponse > Listar_9WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
            
    
            var localVarPath = "/api/vencimentos";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataVencimentoFim != null) localVarQueryParams.Add("dataVencimentoFim", Configuration.ApiClient.ParameterToString(dataVencimentoFim)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleVencimentoResponse)));
            
        }

        
        /// <summary>
        /// List Expiration This resource allows to ve listed the expirations of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param>
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleVencimentoResponse> Listar_9Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = await Listar_9AsyncWithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Expiration This resource allows to ve listed the expirations of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indicates the date of expiration of the invoices (optional)</param>
        /// <param name="dataVencimentoFim">finished Date for query (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> Listar_9AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
            
    
            var localVarPath = "/api/vencimentos";
    
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
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            if (dataVencimentoFim != null) localVarQueryParams.Add("dataVencimentoFim", Configuration.ApiClient.ParameterToString(dataVencimentoFim)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleVencimentoResponse)));
            
        }
        
        /// <summary>
        /// Create a new Attendance of Generic type for a new Account This Method allows register a new generic attendances for a Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param> 
        /// <param name="conteudoAtendimento">Attendance content (optional)</param> 
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param> 
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse Salvar (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = SalvarWithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Attendance of Generic type for a new Account This Method allows register a new generic attendances for a Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param> 
        /// <param name="conteudoAtendimento">Attendance content (optional)</param> 
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param> 
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param> 
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        public ApiResponse< AtendimentoClienteResponse > SalvarWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
            
    
            var localVarPath = "/api/atendimento-clientes";
    
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
            if (conteudoAtendimento != null) localVarQueryParams.Add("conteudoAtendimento", Configuration.ApiClient.ParameterToString(conteudoAtendimento)); // query parameter
            if (detalhesAtendimento != null) localVarQueryParams.Add("detalhesAtendimento", Configuration.ApiClient.ParameterToString(detalhesAtendimento)); // query parameter
            if (nomeAtendente != null) localVarQueryParams.Add("nomeAtendente", Configuration.ApiClient.ParameterToString(nomeAtendente)); // query parameter
            if (dataAtendimento != null) localVarQueryParams.Add("dataAtendimento", Configuration.ApiClient.ParameterToString(dataAtendimento)); // query parameter
            if (dataAgendamento != null) localVarQueryParams.Add("dataAgendamento", Configuration.ApiClient.ParameterToString(dataAgendamento)); // query parameter
            if (dataHoraInicioAtendimento != null) localVarQueryParams.Add("dataHoraInicioAtendimento", Configuration.ApiClient.ParameterToString(dataHoraInicioAtendimento)); // query parameter
            if (dataHoraFimAtendimento != null) localVarQueryParams.Add("dataHoraFimAtendimento", Configuration.ApiClient.ParameterToString(dataHoraFimAtendimento)); // query parameter
            if (flagFilaFraude != null) localVarQueryParams.Add("flagFilaFraude", Configuration.ApiClient.ParameterToString(flagFilaFraude)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// Create a new Attendance of Generic type for a new Account This Method allows register a new generic attendances for a Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param>
        /// <param name="conteudoAtendimento">Attendance content (optional)</param>
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarAsync (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await SalvarAsyncWithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Attendance of Generic type for a new Account This Method allows register a new generic attendances for a Account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account which the Attendance is associated (optional)</param>
        /// <param name="conteudoAtendimento">Attendance content (optional)</param>
        /// <param name="detalhesAtendimento">Show the details launched by the system or by the Attendant during the attendance (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Show the date and time which the attendance was made in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">When it is used, according to the Attendance type, show the date and time to processing or the date and time to return the attendance in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Show the date and time which the attendance was begun, it serves to measure the performance of the Attendants in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Show the date and time which the attendance was finished. When it is used, it serves to measure the performance of the attendances in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag line fraud (optional)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> SalvarAsyncWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
            
    
            var localVarPath = "/api/atendimento-clientes";
    
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
            if (conteudoAtendimento != null) localVarQueryParams.Add("conteudoAtendimento", Configuration.ApiClient.ParameterToString(conteudoAtendimento)); // query parameter
            if (detalhesAtendimento != null) localVarQueryParams.Add("detalhesAtendimento", Configuration.ApiClient.ParameterToString(detalhesAtendimento)); // query parameter
            if (nomeAtendente != null) localVarQueryParams.Add("nomeAtendente", Configuration.ApiClient.ParameterToString(nomeAtendente)); // query parameter
            if (dataAtendimento != null) localVarQueryParams.Add("dataAtendimento", Configuration.ApiClient.ParameterToString(dataAtendimento)); // query parameter
            if (dataAgendamento != null) localVarQueryParams.Add("dataAgendamento", Configuration.ApiClient.ParameterToString(dataAgendamento)); // query parameter
            if (dataHoraInicioAtendimento != null) localVarQueryParams.Add("dataHoraInicioAtendimento", Configuration.ApiClient.ParameterToString(dataHoraInicioAtendimento)); // query parameter
            if (dataHoraFimAtendimento != null) localVarQueryParams.Add("dataHoraFimAtendimento", Configuration.ApiClient.ParameterToString(dataHoraFimAtendimento)); // query parameter
            if (flagFilaFraude != null) localVarQueryParams.Add("flagFilaFraude", Configuration.ApiClient.ParameterToString(flagFilaFraude)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// Insert campaign This method allows to be created a new campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse Salvar_0 (CampanhaPersist campanhaPersist)
        {
             ApiResponse<CampanhaResponse> localVarResponse = Salvar_0WithHttpInfo(campanhaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insert campaign This method allows to be created a new campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > Salvar_0WithHttpInfo (CampanhaPersist campanhaPersist)
        {
            
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null)
                throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling GeneralRegisterApi->Salvar_0");
            
    
            var localVarPath = "/api/campanhas";
    
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
            
            
            
            
            if (campanhaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(campanhaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = campanhaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// Insert campaign This method allows to be created a new campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> Salvar_0Async (CampanhaPersist campanhaPersist)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(campanhaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insert campaign This method allows to be created a new campaign
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> Salvar_0AsyncWithHttpInfo (CampanhaPersist campanhaPersist)
        {
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null) throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling Salvar_0");
            
    
            var localVarPath = "/api/campanhas";
    
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
            
            
            
            
            if (campanhaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(campanhaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = campanhaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// Insert the configuration dates of a revolving of the product This method allows to be registred a new configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse Salvar_1 (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = Salvar_1WithHttpInfo(configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insert the configuration dates of a revolving of the product This method allows to be registred a new configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > Salvar_1WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling GeneralRegisterApi->Salvar_1");
            
    
            var localVarPath = "/api/configuracoes-rotativos";
    
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
            
            
            
            
            if (configuracaoRotativoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoRotativoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoRotativoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Insert the configuration dates of a revolving of the product This method allows to be registred a new configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Salvar_1Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await Salvar_1AsyncWithHttpInfo(configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insert the configuration dates of a revolving of the product This method allows to be registred a new configuration of the revolving for a determined product
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Salvar_1AsyncWithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling Salvar_1");
            
    
            var localVarPath = "/api/configuracoes-rotativos";
    
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
            
            
            
            
            if (configuracaoRotativoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(configuracaoRotativoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = configuracaoRotativoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
    }
    
}
