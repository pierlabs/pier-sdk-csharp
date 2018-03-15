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
    public interface ICadastroGeralApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param>
        /// <param name="update">update</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse AlterarUsingPUT2 (long? id, CampanhaUpdate update);
  
        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> AlterarUsingPUT2WithHttpInfo (long? id, CampanhaUpdate update);
        
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse AlterarUsingPUT3 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> AlterarUsingPUT3WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse AlterarUsingPUT4 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> AlterarUsingPUT4WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse CadastrarUsingPOST1 (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> CadastrarUsingPOST1WithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConfigurarTaxaAntecipacaoUsingPOST (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
  
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoUsingPOSTWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse ConsultarCampanhaUsingGET (long? id);
  
        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> ConsultarCampanhaUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConsultarTaxaAntecipacaoUsingGET (long? id, string tipoTransacao);
  
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConsultarTaxaAntecipacaoUsingGETWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse ConsultarUsingGET11 (long? id);
  
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> ConsultarUsingGET11WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>ProdutoDetalhesResponse</returns>
        ProdutoDetalhesResponse ConsultarUsingGET26 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        ApiResponse<ProdutoDetalhesResponse> ConsultarUsingGET26WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os tipos de ajustes do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param>
        /// <returns>PageTipoAjusteResponse</returns>
        PageTipoAjusteResponse ConsultarUsingGET33 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
  
        /// <summary>
        /// Lista os tipos de ajustes do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param>
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        ApiResponse<PageTipoAjusteResponse> ConsultarUsingGET33WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
        
        /// <summary>
        /// Lista os tipos de boletos do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse ConsultarUsingGET34 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
  
        /// <summary>
        /// Lista os tipos de boletos do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> ConsultarUsingGET34WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>TipoEnderecoResponse</returns>
        TipoEnderecoResponse ConsultarUsingGET35 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        ApiResponse<TipoEnderecoResponse> ConsultarUsingGET35WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse ConsultarUsingGET36 (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> ConsultarUsingGET36WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>TipoTelefoneResponse</returns>
        TipoTelefoneResponse ConsultarUsingGET38 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        ApiResponse<TipoTelefoneResponse> ConsultarUsingGET38WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse ConsultarUsingGET4 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> ConsultarUsingGET4WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param>
        /// <returns>BancoResponse</returns>
        BancoResponse ConsultarUsingGET6 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param>
        /// <returns>ApiResponse of BancoResponse</returns>
        ApiResponse<BancoResponse> ConsultarUsingGET6WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param>
        /// <returns>PageCampanhaResponse</returns>
        PageCampanhaResponse ListarCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
  
        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param>
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        ApiResponse<PageCampanhaResponse> ListarCampanhasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
        
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageContaDetalheResponse</returns>
        PageContaDetalheResponse ListarContasPorPessoaUsingGET (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        ApiResponse<PageContaDetalheResponse> ListarContasPorPessoaUsingGETWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarEstadosCivisUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageFantasiaBasicaResponse</returns>
        PageFantasiaBasicaResponse ListarFantasiasBasicasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageFantasiaBasicaResponse</returns>
        ApiResponse<PageFantasiaBasicaResponse> ListarFantasiasBasicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param>
        /// <returns>HistoricoTelefoneResponse</returns>
        HistoricoTelefoneResponse ListarHistoricoTelefonesUsingGET (long? id);
  
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param>
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        ApiResponse<HistoricoTelefoneResponse> ListarHistoricoTelefonesUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNacionalidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarParentescosUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarParentescosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarProfissoesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarProfissoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTipoCampanhaResponse</returns>
        PageTipoCampanhaResponse ListarTiposCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTipoCampanhaResponse</returns>
        ApiResponse<PageTipoCampanhaResponse> ListarTiposCampanhasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse ListarUsingGET13 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> ListarUsingGET13WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param>
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        PageConfiguracaoRotativoResponse ListarUsingGET14 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
  
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        ApiResponse<PageConfiguracaoRotativoResponse> ListarUsingGET14WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <returns>PagePortadorResponse</returns>
        PagePortadorResponse ListarUsingGET34 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
  
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        ApiResponse<PagePortadorResponse> ListarUsingGET34WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param>
        /// <returns>PageProdutoResponse</returns>
        PageProdutoResponse ListarUsingGET35 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
  
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param>
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        ApiResponse<PageProdutoResponse> ListarUsingGET35WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>PagePromotorResponse</returns>
        PagePromotorResponse ListarUsingGET36 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
  
        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        ApiResponse<PagePromotorResponse> ListarUsingGET36WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>PageTipoEnderecoResponse</returns>
        PageTipoEnderecoResponse ListarUsingGET44 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        ApiResponse<PageTipoEnderecoResponse> ListarUsingGET44WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>PageTipoTelefoneResponse</returns>
        PageTipoTelefoneResponse ListarUsingGET46 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        ApiResponse<PageTipoTelefoneResponse> ListarUsingGET46WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <returns>PageControleVencimentoResponse</returns>
        PageControleVencimentoResponse ListarUsingGET52 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null);
  
        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        ApiResponse<PageControleVencimentoResponse> ListarUsingGET52WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null);
        
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param>
        /// <returns>PageAtendimentoClienteResponse</returns>
        PageAtendimentoClienteResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
  
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param>
        /// <returns>ApiResponse of PageAtendimentoClienteResponse</returns>
        ApiResponse<PageAtendimentoClienteResponse> ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageBancoResponse</returns>
        PageBancoResponse ListarUsingGET8 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageBancoResponse</returns>
        ApiResponse<PageBancoResponse> ListarUsingGET8WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse SalvarUsingPOST2 (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
  
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> SalvarUsingPOST2WithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse SalvarUsingPOST5 (CampanhaPersist campanhaPersist);
  
        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> SalvarUsingPOST5WithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse SalvarUsingPOST7 (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> SalvarUsingPOST7WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> AlterarUsingPUT2Async (long? id, CampanhaUpdate update);

        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, CampanhaUpdate update);
        
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> AlterarUsingPUT3Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> AlterarUsingPUT3AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> AlterarUsingPUT4Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> CadastrarUsingPOST1Async (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> CadastrarUsingPOST1AsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoUsingPOSTAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoUsingPOSTAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaUsingGETAsync (long? id);

        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> ConsultarCampanhaUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoUsingGETAsync (long? id, string tipoTransacao);

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoUsingGETAsyncWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> ConsultarUsingGET11Async (long? id);

        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico.
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        System.Threading.Tasks.Task<ProdutoDetalhesResponse> ConsultarUsingGET26Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> ConsultarUsingGET26AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os tipos de ajustes do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        System.Threading.Tasks.Task<PageTipoAjusteResponse> ConsultarUsingGET33Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);

        /// <summary>
        /// Lista os tipos de ajustes do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> ConsultarUsingGET33AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
        
        /// <summary>
        /// Lista os tipos de boletos do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> ConsultarUsingGET34Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);

        /// <summary>
        /// Lista os tipos de boletos do emissor 
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ConsultarUsingGET34AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<TipoEnderecoResponse> ConsultarUsingGET35Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> ConsultarUsingGET35AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> ConsultarUsingGET36Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento);

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<TipoTelefoneResponse> ConsultarUsingGET38Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> ConsultarUsingGET38AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarUsingGET4Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarUsingGET4AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param>
        /// <returns>Task of BancoResponse</returns>
        System.Threading.Tasks.Task<BancoResponse> ConsultarUsingGET6Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BancoResponse>> ConsultarUsingGET6AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);

        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
        
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaUsingGETAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaUsingGETAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarEstadosCivisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFantasiaBasicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFantasiaBasicaResponse>> ListarFantasiasBasicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesUsingGETAsync (long? id);

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNacionalidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNaturezasOcupacoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarParentescosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarProfissoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoCampanhaResponse>> ListarTiposCampanhasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ListarUsingGET13Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ListarUsingGET13AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> ListarUsingGET14Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);

        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> ListarUsingGET14AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        System.Threading.Tasks.Task<PagePortadorResponse> ListarUsingGET34Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);

        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> ListarUsingGET34AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        System.Threading.Tasks.Task<PageProdutoResponse> ListarUsingGET35Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);

        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> ListarUsingGET35AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        System.Threading.Tasks.Task<PagePromotorResponse> ListarUsingGET36Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);

        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> ListarUsingGET36AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageTipoEnderecoResponse> ListarUsingGET44Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> ListarUsingGET44AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTipoTelefoneResponse> ListarUsingGET46Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> ListarUsingGET46AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        System.Threading.Tasks.Task<PageControleVencimentoResponse> ListarUsingGET52Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null);

        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> ListarUsingGET52AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null);
        
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);

        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param>
        /// <returns>Task of ApiResponse (PageAtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAtendimentoClienteResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        System.Threading.Tasks.Task<PageBancoResponse> ListarUsingGET8Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageBancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBancoResponse>> ListarUsingGET8AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarUsingPOST2Async (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);

        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> SalvarUsingPOST2AsyncWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> SalvarUsingPOST5Async (CampanhaPersist campanhaPersist);

        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> SalvarUsingPOST5AsyncWithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> SalvarUsingPOST7Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CadastroGeralApi : ICadastroGeralApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroGeralApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CadastroGeralApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroGeralApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CadastroGeralApi(Configuration configuration = null)
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
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse AlterarUsingPUT2 (long? id, CampanhaUpdate update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = AlterarUsingPUT2WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > AlterarUsingPUT2WithHttpInfo (long? id, CampanhaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AlterarUsingPUT2");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling CadastroGeralApi->AlterarUsingPUT2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> AlterarUsingPUT2Async (long? id, CampanhaUpdate update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await AlterarUsingPUT2AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, CampanhaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT2");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse AlterarUsingPUT3 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = AlterarUsingPUT3WithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > AlterarUsingPUT3WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AlterarUsingPUT3");
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling CadastroGeralApi->AlterarUsingPUT3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> AlterarUsingPUT3Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await AlterarUsingPUT3AsyncWithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> AlterarUsingPUT3AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT3");
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling AlterarUsingPUT3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse AlterarUsingPUT4 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = AlterarUsingPUT4WithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > AlterarUsingPUT4WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AlterarUsingPUT4");
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling CadastroGeralApi->AlterarUsingPUT4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> AlterarUsingPUT4Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await AlterarUsingPUT4AsyncWithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT4");
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling AlterarUsingPUT4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse CadastrarUsingPOST1 (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = CadastrarUsingPOST1WithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > CadastrarUsingPOST1WithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling CadastroGeralApi->CadastrarUsingPOST1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> CadastrarUsingPOST1Async (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await CadastrarUsingPOST1AsyncWithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> CadastrarUsingPOST1AsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling CadastrarUsingPOST1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConfigurarTaxaAntecipacaoUsingPOST (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConfigurarTaxaAntecipacaoUsingPOSTWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConfigurarTaxaAntecipacaoUsingPOSTWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConfigurarTaxaAntecipacaoUsingPOST");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling CadastroGeralApi->ConfigurarTaxaAntecipacaoUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }

        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoUsingPOSTAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConfigurarTaxaAntecipacaoUsingPOSTAsyncWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoUsingPOSTAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConfigurarTaxaAntecipacaoUsingPOST");
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null) throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling ConfigurarTaxaAntecipacaoUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }
        
        /// <summary>
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse ConsultarCampanhaUsingGET (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = ConsultarCampanhaUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > ConsultarCampanhaUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarCampanhaUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaUsingGETAsync (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await ConsultarCampanhaUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> ConsultarCampanhaUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarCampanhaUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanhaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCampanhaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConsultarTaxaAntecipacaoUsingGET (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConsultarTaxaAntecipacaoUsingGETWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConsultarTaxaAntecipacaoUsingGETWithHttpInfo (long? id, string tipoTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarTaxaAntecipacaoUsingGET");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling CadastroGeralApi->ConsultarTaxaAntecipacaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }

        
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoUsingGETAsync (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConsultarTaxaAntecipacaoUsingGETAsyncWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoUsingGETAsyncWithHttpInfo (long? id, string tipoTransacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxaAntecipacaoUsingGET");
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null) throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling ConsultarTaxaAntecipacaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }
        
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse ConsultarUsingGET10 (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET10");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id).</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico. Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse ConsultarUsingGET11 (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = ConsultarUsingGET11WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico. Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > ConsultarUsingGET11WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET11");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico. Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> ConsultarUsingGET11Async (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await ConsultarUsingGET11AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico. Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id).</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET11");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param> 
        /// <returns>ProdutoDetalhesResponse</returns>
        public ProdutoDetalhesResponse ConsultarUsingGET26 (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = ConsultarUsingGET26WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param> 
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        public ApiResponse< ProdutoDetalhesResponse > ConsultarUsingGET26WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET26");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProdutoDetalhesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProdutoDetalhesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProdutoDetalhesResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        public async System.Threading.Tasks.Task<ProdutoDetalhesResponse> ConsultarUsingGET26Async (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = await ConsultarUsingGET26AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> ConsultarUsingGET26AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET26");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProdutoDetalhesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProdutoDetalhesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProdutoDetalhesResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de ajustes do emissor  Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param> 
        /// <returns>PageTipoAjusteResponse</returns>
        public PageTipoAjusteResponse ConsultarUsingGET33 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = ConsultarUsingGET33WithHttpInfo(sort, page, limit, id, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de ajustes do emissor  Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param> 
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        public ApiResponse< PageTipoAjusteResponse > ConsultarUsingGET33WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoAjusteResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de ajustes do emissor  Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoAjusteResponse> ConsultarUsingGET33Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = await ConsultarUsingGET33AsyncWithHttpInfo(sort, page, limit, id, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de ajustes do emissor  Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> ConsultarUsingGET33AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoAjusteResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de boletos do emissor  Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param> 
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse ConsultarUsingGET34 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = ConsultarUsingGET34WithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de boletos do emissor  Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param> 
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param> 
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        public ApiResponse< PageTipoBoletoResponse > ConsultarUsingGET34WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de boletos do emissor  Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> ConsultarUsingGET34Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await ConsultarUsingGET34AsyncWithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de boletos do emissor  Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto. (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto. (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ConsultarUsingGET34AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param> 
        /// <returns>TipoEnderecoResponse</returns>
        public TipoEnderecoResponse ConsultarUsingGET35 (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = ConsultarUsingGET35WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param> 
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        public ApiResponse< TipoEnderecoResponse > ConsultarUsingGET35WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET35");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<TipoEnderecoResponse> ConsultarUsingGET35Async (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = await ConsultarUsingGET35AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> ConsultarUsingGET35AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET35");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse ConsultarUsingGET36 (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = ConsultarUsingGET36WithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > ConsultarUsingGET36WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CadastroGeralApi->ConsultarUsingGET36");
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling CadastroGeralApi->ConsultarUsingGET36");
            
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null)
                throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling CadastroGeralApi->ConsultarUsingGET36");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> ConsultarUsingGET36Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await ConsultarUsingGET36AsyncWithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao).</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento).</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o.</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarUsingGET36");
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null) throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling ConsultarUsingGET36");
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null) throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling ConsultarUsingGET36");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param> 
        /// <returns>TipoTelefoneResponse</returns>
        public TipoTelefoneResponse ConsultarUsingGET38 (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = ConsultarUsingGET38WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param> 
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        public ApiResponse< TipoTelefoneResponse > ConsultarUsingGET38WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET38");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TipoTelefoneResponse> ConsultarUsingGET38Async (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = await ConsultarUsingGET38AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> ConsultarUsingGET38AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET38");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse ConsultarUsingGET4 (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = ConsultarUsingGET4WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param> 
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        public ApiResponse< AtendimentoClienteResponse > ConsultarUsingGET4WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarUsingGET4Async (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await ConsultarUsingGET4AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id).</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarUsingGET4AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param> 
        /// <returns>BancoResponse</returns>
        public BancoResponse ConsultarUsingGET6 (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = ConsultarUsingGET6WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param> 
        /// <returns>ApiResponse of BancoResponse</returns>
        public ApiResponse< BancoResponse > ConsultarUsingGET6WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarUsingGET6");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param>
        /// <returns>Task of BancoResponse</returns>
        public async System.Threading.Tasks.Task<BancoResponse> ConsultarUsingGET6Async (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = await ConsultarUsingGET6AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id).</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BancoResponse>> ConsultarUsingGET6AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET6");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }
        
        /// <summary>
        /// Listar Campanhas Lista as campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param> 
        /// <returns>PageCampanhaResponse</returns>
        public PageCampanhaResponse ListarCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = ListarCampanhasUsingGETWithHttpInfo(sort, page, limit, idTipoCampanha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Campanhas Lista as campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param> 
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        public ApiResponse< PageCampanhaResponse > ListarCampanhasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampanhaResponse)));
            
        }

        
        /// <summary>
        /// Listar Campanhas Lista as campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = await ListarCampanhasUsingGETAsyncWithHttpInfo(sort, page, limit, idTipoCampanha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Campanhas Lista as campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id). (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCampanhasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampanhaResponse)));
            
        }
        
        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageContaDetalheResponse</returns>
        public PageContaDetalheResponse ListarContasPorPessoaUsingGET (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = ListarContasPorPessoaUsingGETWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        public ApiResponse< PageContaDetalheResponse > ListarContasPorPessoaUsingGETWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling CadastroGeralApi->ListarContasPorPessoaUsingGET");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaUsingGETAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = await ListarContasPorPessoaUsingGETAsyncWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaUsingGETAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarContasPorPessoaUsingGET");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarEstadosCivisUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarEstadosCivisUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarEstadosCivisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarEstadosCivisUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarEstadosCivisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstadosCivisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageFantasiaBasicaResponse</returns>
        public PageFantasiaBasicaResponse ListarFantasiasBasicasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = ListarFantasiasBasicasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageFantasiaBasicaResponse</returns>
        public ApiResponse< PageFantasiaBasicaResponse > ListarFantasiasBasicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFantasiaBasicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFantasiaBasicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFantasiaBasicaResponse)));
            
        }

        
        /// <summary>
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        public async System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = await ListarFantasiasBasicasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFantasiaBasicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFantasiaBasicaResponse>> ListarFantasiasBasicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFantasiasBasicasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFantasiaBasicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFantasiaBasicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFantasiaBasicaResponse)));
            
        }
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param> 
        /// <returns>HistoricoTelefoneResponse</returns>
        public HistoricoTelefoneResponse ListarHistoricoTelefonesUsingGET (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = ListarHistoricoTelefonesUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param> 
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        public ApiResponse< HistoricoTelefoneResponse > ListarHistoricoTelefonesUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ListarHistoricoTelefonesUsingGET");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesUsingGETAsync (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = await ListarHistoricoTelefonesUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id).</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoTelefonesUsingGET");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNacionalidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNacionalidadesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarNacionalidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidadesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidadesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNacionalidadesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNacionalidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidadesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNacionalidadesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNaturezasOcupacoesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarNaturezasOcupacoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNaturezasOcupacoesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNaturezasOcupacoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarNaturezasOcupacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarParentescosUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarParentescosUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarParentescosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarParentescosUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarParentescosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParentescosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarProfissoesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarProfissoesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarProfissoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarProfissoesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarProfissoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProfissoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Listar Tipos de Campanhas Lista os tipos de campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTipoCampanhaResponse</returns>
        public PageTipoCampanhaResponse ListarTiposCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = ListarTiposCampanhasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Tipos de Campanhas Lista os tipos de campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoCampanhaResponse</returns>
        public ApiResponse< PageTipoCampanhaResponse > ListarTiposCampanhasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoCampanhaResponse)));
            
        }

        
        /// <summary>
        /// Listar Tipos de Campanhas Lista os tipos de campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = await ListarTiposCampanhasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Tipos de Campanhas Lista os tipos de campanhas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoCampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoCampanhaResponse>> ListarTiposCampanhasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposCampanhasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoCampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoCampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoCampanhaResponse)));
            
        }
        
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse ListarUsingGET13 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = ListarUsingGET13WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > ListarUsingGET13WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ListarUsingGET13Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await ListarUsingGET13AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ListarUsingGET13AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo. Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param> 
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        public PageConfiguracaoRotativoResponse ListarUsingGET14 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = ListarUsingGET14WithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo. Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param> 
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        public ApiResponse< PageConfiguracaoRotativoResponse > ListarUsingGET14WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConfiguracaoRotativoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoRotativoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoRotativoResponse)));
            
        }

        
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo. Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> ListarUsingGET14Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = await ListarUsingGET14AsyncWithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo. Este recurso permite listar as configura\u00E7\u00F5es rotativo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto. (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> ListarUsingGET14AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConfiguracaoRotativoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoRotativoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoRotativoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param> 
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param> 
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param> 
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param> 
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param> 
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param> 
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param> 
        /// <returns>PagePortadorResponse</returns>
        public PagePortadorResponse ListarUsingGET34 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = ListarUsingGET34WithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param> 
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param> 
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param> 
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param> 
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param> 
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param> 
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param> 
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        public ApiResponse< PagePortadorResponse > ListarUsingGET34WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorResponse)));
            
        }

        
        /// <summary>
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        public async System.Threading.Tasks.Task<PagePortadorResponse> ListarUsingGET34Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = await ListarUsingGET34AsyncWithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o. (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> ListarUsingGET34AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET34: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorResponse)));
            
        }
        
        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param> 
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param> 
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param> 
        /// <returns>PageProdutoResponse</returns>
        public PageProdutoResponse ListarUsingGET35 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = ListarUsingGET35WithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param> 
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param> 
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param> 
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        public ApiResponse< PageProdutoResponse > ListarUsingGET35WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoResponse> ListarUsingGET35Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = await ListarUsingGET35AsyncWithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence. (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> ListarUsingGET35AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoResponse)));
            
        }
        
        /// <summary>
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param> 
        /// <param name="nome">Nome do Promotor (optional)</param> 
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param> 
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param> 
        /// <returns>PagePromotorResponse</returns>
        public PagePromotorResponse ListarUsingGET36 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = ListarUsingGET36WithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param> 
        /// <param name="nome">Nome do Promotor (optional)</param> 
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param> 
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param> 
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        public ApiResponse< PagePromotorResponse > ListarUsingGET36WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePromotorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePromotorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePromotorResponse)));
            
        }

        
        /// <summary>
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        public async System.Threading.Tasks.Task<PagePromotorResponse> ListarUsingGET36Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = await ListarUsingGET36AsyncWithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o. (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> ListarUsingGET36AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePromotorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePromotorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePromotorResponse)));
            
        }
        
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor  Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param> 
        /// <returns>PageTipoEnderecoResponse</returns>
        public PageTipoEnderecoResponse ListarUsingGET44 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = ListarUsingGET44WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor  Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param> 
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        public ApiResponse< PageTipoEnderecoResponse > ListarUsingGET44WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor  Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoEnderecoResponse> ListarUsingGET44Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = await ListarUsingGET44AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor  Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> ListarUsingGET44AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param> 
        /// <returns>PageTipoTelefoneResponse</returns>
        public PageTipoTelefoneResponse ListarUsingGET46 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = ListarUsingGET46WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param> 
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        public ApiResponse< PageTipoTelefoneResponse > ListarUsingGET46WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTelefoneResponse> ListarUsingGET46Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = await ListarUsingGET46AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> ListarUsingGET46AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param> 
        /// <returns>PageControleVencimentoResponse</returns>
        public PageControleVencimentoResponse ListarUsingGET52 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = ListarUsingGET52WithHttpInfo(sort, page, limit, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param> 
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        public ApiResponse< PageControleVencimentoResponse > ListarUsingGET52WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleVencimentoResponse)));
            
        }

        
        /// <summary>
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleVencimentoResponse> ListarUsingGET52Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = await ListarUsingGET52AsyncWithHttpInfo(sort, page, limit, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> ListarUsingGET52AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleVencimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param> 
        /// <returns>PageAtendimentoClienteResponse</returns>
        public PageAtendimentoClienteResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = ListarUsingGET6WithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param> 
        /// <returns>ApiResponse of PageAtendimentoClienteResponse</returns>
        public ApiResponse< PageAtendimentoClienteResponse > ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = await ListarUsingGET6AsyncWithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id). (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado. (optional)</param>
        /// <returns>Task of ApiResponse (PageAtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAtendimentoClienteResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageBancoResponse</returns>
        public PageBancoResponse ListarUsingGET8 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = ListarUsingGET8WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageBancoResponse</returns>
        public ApiResponse< PageBancoResponse > ListarUsingGET8WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBancoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        public async System.Threading.Tasks.Task<PageBancoResponse> ListarUsingGET8Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = await ListarUsingGET8AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageBancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBancoResponse>> ListarUsingGET8AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBancoResponse)));
            
        }
        
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param> 
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param> 
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse SalvarUsingPOST2 (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = SalvarUsingPOST2WithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param> 
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param> 
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param> 
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        public ApiResponse< AtendimentoClienteResponse > SalvarUsingPOST2WithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarUsingPOST2Async (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await SalvarUsingPOST2AsyncWithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento. (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento. (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento. (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> SalvarUsingPOST2AsyncWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse SalvarUsingPOST5 (CampanhaPersist campanhaPersist)
        {
             ApiResponse<CampanhaResponse> localVarResponse = SalvarUsingPOST5WithHttpInfo(campanhaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > SalvarUsingPOST5WithHttpInfo (CampanhaPersist campanhaPersist)
        {
            
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null)
                throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling CadastroGeralApi->SalvarUsingPOST5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> SalvarUsingPOST5Async (CampanhaPersist campanhaPersist)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(campanhaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> SalvarUsingPOST5AsyncWithHttpInfo (CampanhaPersist campanhaPersist)
        {
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null) throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling SalvarUsingPOST5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse SalvarUsingPOST7 (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = SalvarUsingPOST7WithHttpInfo(configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > SalvarUsingPOST7WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling CadastroGeralApi->SalvarUsingPOST7");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> SalvarUsingPOST7Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await SalvarUsingPOST7AsyncWithHttpInfo(configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling SalvarUsingPOST7");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
    }
    
}
