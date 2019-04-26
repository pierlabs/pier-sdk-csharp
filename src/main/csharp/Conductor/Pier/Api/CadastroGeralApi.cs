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
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param>
        /// <param name="update">update</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse Alterar (long? id, CampanhaUpdate update);
  
        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> AlterarWithHttpInfo (long? id, CampanhaUpdate update);
        
        /// <summary>
        /// Recurso para atualizar dados de um banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="bancoUpdate">bancoUpdate</param>
        /// <returns>BancoResponse</returns>
        BancoResponse AlterarBanco (long? id, BancoUpdate bancoUpdate);
  
        /// <summary>
        /// Recurso para atualizar dados de um banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="bancoUpdate">bancoUpdate</param>
        /// <returns>ApiResponse of BancoResponse</returns>
        ApiResponse<BancoResponse> AlterarBancoWithHttpInfo (long? id, BancoUpdate bancoUpdate);
        
        /// <summary>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse AlterarConvenio (long? id, ConvenioPersist convenioPersist);
  
        /// <summary>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> AlterarConvenioWithHttpInfo (long? id, ConvenioPersist convenioPersist);
        
        /// <summary>
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse AlterarParcial (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
  
        /// <summary>
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> AlterarParcialWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
        
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Alterar_0 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Alterar_0WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse Alterar_1 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> Alterar_1WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <param name="portador">portador</param>
        /// <returns>PortadorResponse</returns>
        PortadorResponse AtualizarParcial (long? id, long? idPessoa, PortadorParcialUpdate portador);
  
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <param name="portador">portador</param>
        /// <returns>ApiResponse of PortadorResponse</returns>
        ApiResponse<PortadorResponse> AtualizarParcialWithHttpInfo (long? id, long? idPessoa, PortadorParcialUpdate portador);
        
        /// <summary>
        /// Recurso para salvar um banco
        /// </summary>
        /// <remarks>
        /// Recurso para salvar um novo banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param>
        /// <returns>BancoResponse</returns>
        BancoResponse Cadastrar (BancoPersist bancoPersist);
  
        /// <summary>
        /// Recurso para salvar um banco
        /// </summary>
        /// <remarks>
        /// Recurso para salvar um novo banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param>
        /// <returns>ApiResponse of BancoResponse</returns>
        ApiResponse<BancoResponse> CadastrarWithHttpInfo (BancoPersist bancoPersist);
        
        /// <summary>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </summary>
        /// <remarks>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse CadastrarConvenio (ConvenioPersist convenioPersist);
  
        /// <summary>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </summary>
        /// <remarks>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> CadastrarConvenioWithHttpInfo (ConvenioPersist convenioPersist);
        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Cadastrar_0 (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Cadastrar_0WithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConfigurarTaxaAntecipacao (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
  
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse Consultar (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse ConsultarCampanha (long? id);
  
        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> ConsultarCampanhaWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse ConsultarConvenio (long? id);
  
        /// <summary>
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> ConsultarConvenioWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar limites portadores
        /// </summary>
        /// <remarks>
        /// Consulta o limite de um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <returns>LimitePortadorResponse</returns>
        LimitePortadorResponse ConsultarLimitePortador (long? id, long? idPessoa);
  
        /// <summary>
        /// Consultar limites portadores
        /// </summary>
        /// <remarks>
        /// Consulta o limite de um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <returns>ApiResponse of LimitePortadorResponse</returns>
        ApiResponse<LimitePortadorResponse> ConsultarLimitePortadorWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Listar pacote de tarfias do produtos
        /// </summary>
        /// <remarks>
        /// Listar pacote de tarfias do produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageProdutoPacoteTarifaResponse</returns>
        PageProdutoPacoteTarifaResponse ConsultarProdutoPacoteTarifa (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar pacote de tarfias do produtos
        /// </summary>
        /// <remarks>
        /// Listar pacote de tarfias do produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageProdutoPacoteTarifaResponse</returns>
        ApiResponse<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConsultarTaxaAntecipacao (long? id, string tipoTransacao);
  
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConsultarTaxaAntecipacaoWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse ConsultarTipoOperacao (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> ConsultarTipoOperacaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param>
        /// <returns>BancoResponse</returns>
        BancoResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param>
        /// <returns>ApiResponse of BancoResponse</returns>
        ApiResponse<BancoResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Consultar_1 (long? id);
  
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse Consultar_2 (long? id);
  
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> Consultar_2WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>ProdutoDetalhesResponse</returns>
        ProdutoDetalhesResponse Consultar_3 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        ApiResponse<ProdutoDetalhesResponse> Consultar_3WithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Consultar um tipo de trasa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param>
        /// <returns>TipoAjusteResponse</returns>
        TipoAjusteResponse Consultar_4 (long? id);
  
        /// <summary>
        /// Consulta um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Consultar um tipo de trasa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param>
        /// <returns>ApiResponse of TipoAjusteResponse</returns>
        ApiResponse<TipoAjusteResponse> Consultar_4WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os tipos de boletos do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse Consultar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
  
        /// <summary>
        /// Lista os tipos de boletos do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> Consultar_5WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>TipoEnderecoResponse</returns>
        TipoEnderecoResponse Consultar_6 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        ApiResponse<TipoEnderecoResponse> Consultar_6WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse Consultar_7 (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> Consultar_7WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>TipoTelefoneResponse</returns>
        TipoTelefoneResponse Consultar_8 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        ApiResponse<TipoTelefoneResponse> Consultar_8WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param>
        /// <returns>PageAtendimentoClienteResponse</returns>
        PageAtendimentoClienteResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
  
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param>
        /// <returns>ApiResponse of PageAtendimentoClienteResponse</returns>
        ApiResponse<PageAtendimentoClienteResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param>
        /// <param name="nome">Nome da campanha (optional)</param>
        /// <returns>PageCampanhaResponse</returns>
        PageCampanhaResponse ListarCampanhas (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null);
  
        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param>
        /// <param name="nome">Nome da campanha (optional)</param>
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        ApiResponse<PageCampanhaResponse> ListarCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null);
        
        /// <summary>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <remarks>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente (optional)</param>
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param>
        /// <returns>PageConvenioResponse</returns>
        PageConvenioResponse ListarConvenios (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
  
        /// <summary>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <remarks>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente (optional)</param>
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param>
        /// <returns>ApiResponse of PageConvenioResponse</returns>
        ApiResponse<PageConvenioResponse> ListarConveniosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
        
        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarEstadosCivis (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageFantasiaBasicaResponse</returns>
        PageFantasiaBasicaResponse ListarFantasiasBasicas (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageFantasiaBasicaResponse</returns>
        ApiResponse<PageFantasiaBasicaResponse> ListarFantasiasBasicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Grupos MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param>
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param>
        /// <returns>PageGrupoMCCResponse</returns>
        PageGrupoMCCResponse ListarGrupoMCC (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null);
  
        /// <summary>
        /// Lista os Grupos MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param>
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param>
        /// <returns>ApiResponse of PageGrupoMCCResponse</returns>
        ApiResponse<PageGrupoMCCResponse> ListarGrupoMCCWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null);
        
        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNacionalidades (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoes (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarParentescos (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarParentescosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarProfissoes (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarProfissoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoCampanhaResponse</returns>
        PageTipoCampanhaResponse ListarTiposCampanhas (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoCampanhaResponse</returns>
        ApiResponse<PageTipoCampanhaResponse> ListarTiposCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageBancoResponse</returns>
        PageBancoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageBancoResponse</returns>
        ApiResponse<PageBancoResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param>
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        PageConfiguracaoRotativoResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
  
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        ApiResponse<PageConfiguracaoRotativoResponse> Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <returns>PagePortadorResponse</returns>
        PagePortadorResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
  
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        ApiResponse<PagePortadorResponse> Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param>
        /// <returns>PageProdutoResponse</returns>
        PageProdutoResponse Listar_4 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
  
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param>
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        ApiResponse<PageProdutoResponse> Listar_4WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>PagePromotorResponse</returns>
        PagePromotorResponse Listar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
  
        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        ApiResponse<PagePromotorResponse> Listar_5WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// Lista os tipos de ajustes do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param>
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param>
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param>
        /// <returns>PageTipoAjusteResponse</returns>
        PageTipoAjusteResponse Listar_6 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
  
        /// <summary>
        /// Lista os tipos de ajustes do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param>
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param>
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param>
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        ApiResponse<PageTipoAjusteResponse> Listar_6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
        
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>PageTipoEnderecoResponse</returns>
        PageTipoEnderecoResponse Listar_7 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        ApiResponse<PageTipoEnderecoResponse> Listar_7WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>PageTipoTelefoneResponse</returns>
        PageTipoTelefoneResponse Listar_8 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        ApiResponse<PageTipoTelefoneResponse> Listar_8WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param>
        /// <returns>PageControleVencimentoResponse</returns>
        PageControleVencimentoResponse Listar_9 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
  
        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param>
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        ApiResponse<PageControleVencimentoResponse> Listar_9WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse Salvar (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
  
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> SalvarWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// Adiciona limite ao portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite adicionar limite \u00E0 um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>LimitePortadorResponse</returns>
        LimitePortadorResponse SalvarLimitePortador (long? id, long? idPessoa, LimitePortadorPersist persist);
  
        /// <summary>
        /// Adiciona limite ao portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite adicionar limite \u00E0 um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of LimitePortadorResponse</returns>
        ApiResponse<LimitePortadorResponse> SalvarLimitePortadorWithHttpInfo (long? id, long? idPessoa, LimitePortadorPersist persist);
        
        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse Salvar_0 (CampanhaPersist campanhaPersist);
  
        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> Salvar_0WithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse Salvar_1 (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> Salvar_1WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> AlterarAsync (long? id, CampanhaUpdate update);

        /// <summary>
        /// Alterar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarAsyncWithHttpInfo (long? id, CampanhaUpdate update);
        
        /// <summary>
        /// Recurso para atualizar dados de um banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="bancoUpdate">bancoUpdate</param>
        /// <returns>Task of BancoResponse</returns>
        System.Threading.Tasks.Task<BancoResponse> AlterarBancoAsync (long? id, BancoUpdate bancoUpdate);

        /// <summary>
        /// Recurso para atualizar dados de um banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="bancoUpdate">bancoUpdate</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BancoResponse>> AlterarBancoAsyncWithHttpInfo (long? id, BancoUpdate bancoUpdate);
        
        /// <summary>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> AlterarConvenioAsync (long? id, ConvenioPersist convenioPersist);

        /// <summary>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> AlterarConvenioAsyncWithHttpInfo (long? id, ConvenioPersist convenioPersist);
        
        /// <summary>
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> AlterarParcialAsync (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);

        /// <summary>
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> AlterarParcialAsyncWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
        
        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Alterar_0Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Alterar_0AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Alterar_1Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <param name="portador">portador</param>
        /// <returns>Task of PortadorResponse</returns>
        System.Threading.Tasks.Task<PortadorResponse> AtualizarParcialAsync (long? id, long? idPessoa, PortadorParcialUpdate portador);

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <param name="portador">portador</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> AtualizarParcialAsyncWithHttpInfo (long? id, long? idPessoa, PortadorParcialUpdate portador);
        
        /// <summary>
        /// Recurso para salvar um banco
        /// </summary>
        /// <remarks>
        /// Recurso para salvar um novo banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param>
        /// <returns>Task of BancoResponse</returns>
        System.Threading.Tasks.Task<BancoResponse> CadastrarAsync (BancoPersist bancoPersist);

        /// <summary>
        /// Recurso para salvar um banco
        /// </summary>
        /// <remarks>
        /// Recurso para salvar um novo banco
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BancoResponse>> CadastrarAsyncWithHttpInfo (BancoPersist bancoPersist);
        
        /// <summary>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </summary>
        /// <remarks>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> CadastrarConvenioAsync (ConvenioPersist convenioPersist);

        /// <summary>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </summary>
        /// <remarks>
        /// Adiciona novo conv\u00EAnio para o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> CadastrarConvenioAsyncWithHttpInfo (ConvenioPersist convenioPersist);
        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Cadastrar_0Async (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Cadastrar_0AsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Atendimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaAsync (long? id);

        /// <summary>
        /// Consultar campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> ConsultarCampanhaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> ConsultarConvenioAsync (long? id);

        /// <summary>
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <remarks>
        /// Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> ConsultarConvenioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar limites portadores
        /// </summary>
        /// <remarks>
        /// Consulta o limite de um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <returns>Task of LimitePortadorResponse</returns>
        System.Threading.Tasks.Task<LimitePortadorResponse> ConsultarLimitePortadorAsync (long? id, long? idPessoa);

        /// <summary>
        /// Consultar limites portadores
        /// </summary>
        /// <remarks>
        /// Consulta o limite de um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <returns>Task of ApiResponse (LimitePortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimitePortadorResponse>> ConsultarLimitePortadorAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Listar pacote de tarfias do produtos
        /// </summary>
        /// <remarks>
        /// Listar pacote de tarfias do produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageProdutoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar pacote de tarfias do produtos
        /// </summary>
        /// <remarks>
        /// Listar pacote de tarfias do produtos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoPacoteTarifaResponse>> ConsultarProdutoPacoteTarifaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoAsync (long? id, string tipoTransacao);

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoAsyncWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> ConsultarTipoOperacaoAsync (long? id);

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> ConsultarTipoOperacaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param>
        /// <returns>Task of BancoResponse</returns>
        System.Threading.Tasks.Task<BancoResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Banco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BancoResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Consultar_1Async (long? id);

        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Consultar_2Async (long? id);

        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> Consultar_2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        System.Threading.Tasks.Task<ProdutoDetalhesResponse> Consultar_3Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> Consultar_3AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Consultar um tipo de trasa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param>
        /// <returns>Task of TipoAjusteResponse</returns>
        System.Threading.Tasks.Task<TipoAjusteResponse> Consultar_4Async (long? id);

        /// <summary>
        /// Consulta um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Consultar um tipo de trasa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (TipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoAjusteResponse>> Consultar_4AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os tipos de boletos do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> Consultar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);

        /// <summary>
        /// Lista os tipos de boletos do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> Consultar_5AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<TipoEnderecoResponse> Consultar_6Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> Consultar_6AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> Consultar_7Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento);

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> Consultar_7AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<TipoTelefoneResponse> Consultar_8Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> Consultar_8AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);

        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param>
        /// <returns>Task of ApiResponse (PageAtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAtendimentoClienteResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param>
        /// <param name="nome">Nome da campanha (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null);

        /// <summary>
        /// Listar Campanhas
        /// </summary>
        /// <remarks>
        /// Lista as campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param>
        /// <param name="nome">Nome da campanha (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null);
        
        /// <summary>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <remarks>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente (optional)</param>
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param>
        /// <returns>Task of PageConvenioResponse</returns>
        System.Threading.Tasks.Task<PageConvenioResponse> ListarConveniosAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);

        /// <summary>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <remarks>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente (optional)</param>
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param>
        /// <returns>Task of ApiResponse (PageConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConvenioResponse>> ListarConveniosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
        
        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Estados C\u00EDvis
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarEstadosCivisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Fantasias B\u00E1sicas
        /// </summary>
        /// <remarks>
        /// Lista as fantasia b\u00E1sicas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFantasiaBasicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFantasiaBasicaResponse>> ListarFantasiasBasicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Grupos MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param>
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param>
        /// <returns>Task of PageGrupoMCCResponse</returns>
        System.Threading.Tasks.Task<PageGrupoMCCResponse> ListarGrupoMCCAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null);

        /// <summary>
        /// Lista os Grupos MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param>
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoMCCResponse>> ListarGrupoMCCAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null);
        
        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista nacionalidades
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNacionalidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNaturezasOcupacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Parentescos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarParentescosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista profiss\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarProfissoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Tipos de Campanhas
        /// </summary>
        /// <remarks>
        /// Lista os tipos de campanhas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoCampanhaResponse>> ListarTiposCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        System.Threading.Tasks.Task<PageBancoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageBancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBancoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);

        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        System.Threading.Tasks.Task<PagePortadorResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);

        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        System.Threading.Tasks.Task<PageProdutoResponse> Listar_4Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);

        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> Listar_4AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        System.Threading.Tasks.Task<PagePromotorResponse> Listar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);

        /// <summary>
        /// Lista promotores cadastrados na base do emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> Listar_5AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// Lista os tipos de ajustes do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param>
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param>
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        System.Threading.Tasks.Task<PageTipoAjusteResponse> Listar_6Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);

        /// <summary>
        /// Lista os tipos de ajustes do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param>
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param>
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> Listar_6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
        
        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageTipoEnderecoResponse> Listar_7Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> Listar_7AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTipoTelefoneResponse> Listar_8Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> Listar_8AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        System.Threading.Tasks.Task<PageControleVencimentoResponse> Listar_9Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);

        /// <summary>
        /// Listar Vencimentos
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os Vencimentos do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> Listar_9AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarAsync (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);

        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> SalvarAsyncWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// Adiciona limite ao portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite adicionar limite \u00E0 um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of LimitePortadorResponse</returns>
        System.Threading.Tasks.Task<LimitePortadorResponse> SalvarLimitePortadorAsync (long? id, long? idPessoa, LimitePortadorPersist persist);

        /// <summary>
        /// Adiciona limite ao portador
        /// </summary>
        /// <remarks>
        /// Este recurso permite adicionar limite \u00E0 um portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (LimitePortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LimitePortadorResponse>> SalvarLimitePortadorAsyncWithHttpInfo (long? id, long? idPessoa, LimitePortadorPersist persist);
        
        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> Salvar_0Async (CampanhaPersist campanhaPersist);

        /// <summary>
        /// Inserir campanha
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova campanha
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> Salvar_0AsyncWithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Salvar_1Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
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
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse Alterar (long? id, CampanhaUpdate update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = AlterarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > AlterarWithHttpInfo (long? id, CampanhaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Alterar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling CadastroGeralApi->Alterar");
            
    
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
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> AlterarAsync (long? id, CampanhaUpdate update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar campanha Este m\u00E9todo permite que sejam alterados os dados de uma campanha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da campanha (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarAsyncWithHttpInfo (long? id, CampanhaUpdate update)
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
        /// Recurso para atualizar dados de um banco Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="bancoUpdate">bancoUpdate</param> 
        /// <returns>BancoResponse</returns>
        public BancoResponse AlterarBanco (long? id, BancoUpdate bancoUpdate)
        {
             ApiResponse<BancoResponse> localVarResponse = AlterarBancoWithHttpInfo(id, bancoUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recurso para atualizar dados de um banco Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="bancoUpdate">bancoUpdate</param> 
        /// <returns>ApiResponse of BancoResponse</returns>
        public ApiResponse< BancoResponse > AlterarBancoWithHttpInfo (long? id, BancoUpdate bancoUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AlterarBanco");
            
            // verify the required parameter 'bancoUpdate' is set
            if (bancoUpdate == null)
                throw new ApiException(400, "Missing required parameter 'bancoUpdate' when calling CadastroGeralApi->AlterarBanco");
            
    
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
            
            
            
            
            if (bancoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bancoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bancoUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBanco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBanco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }

        
        /// <summary>
        /// Recurso para atualizar dados de um banco Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="bancoUpdate">bancoUpdate</param>
        /// <returns>Task of BancoResponse</returns>
        public async System.Threading.Tasks.Task<BancoResponse> AlterarBancoAsync (long? id, BancoUpdate bancoUpdate)
        {
             ApiResponse<BancoResponse> localVarResponse = await AlterarBancoAsyncWithHttpInfo(id, bancoUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recurso para atualizar dados de um banco Este m\u00E9todo permite que sejam alterados os dados de um banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="bancoUpdate">bancoUpdate</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BancoResponse>> AlterarBancoAsyncWithHttpInfo (long? id, BancoUpdate bancoUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarBanco");
            // verify the required parameter 'bancoUpdate' is set
            if (bancoUpdate == null) throw new ApiException(400, "Missing required parameter 'bancoUpdate' when calling AlterarBanco");
            
    
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
            
            
            
            
            if (bancoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bancoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bancoUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBanco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBanco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }
        
        /// <summary>
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
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
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > AlterarConvenioWithHttpInfo (long? id, ConvenioPersist convenioPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AlterarConvenio");
            
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null)
                throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling CadastroGeralApi->AlterarConvenio");
            
    
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
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
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
        /// Altera os dados banc\u00E1rios de um determinado conv\u00EAnio Altera os dados banc\u00E1rios de um determinado conv\u00EAnio
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
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param> 
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse AlterarParcial (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = AlterarParcialWithHttpInfo(id, tipoOperacaoParcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param> 
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > AlterarParcialWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AlterarParcial");
            
            // verify the required parameter 'tipoOperacaoParcialUpdate' is set
            if (tipoOperacaoParcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'tipoOperacaoParcialUpdate' when calling CadastroGeralApi->AlterarParcial");
            
    
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
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> AlterarParcialAsync (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await AlterarParcialAsyncWithHttpInfo(id, tipoOperacaoParcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera\u00E7\u00E3o parcial de um tipo opera\u00E7\u00E3o Edita os campos de tipos opera\u00E7\u00F5es que foram passadas no objeto de requisi\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de opera\u00E7\u00E3o</param>
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
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Alterar_0 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Alterar_0WithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > Alterar_0WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Alterar_0");
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling CadastroGeralApi->Alterar_0");
            
    
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
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Alterar_0Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Alterar_0AsyncWithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite atualizar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
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
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse Alterar_1 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = Alterar_1WithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > Alterar_1WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Alterar_1");
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling CadastroGeralApi->Alterar_1");
            
    
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
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Alterar_1Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await Alterar_1AsyncWithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja alterada uma configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
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
        /// Atualiza\u00E7\u00E3o parcial do Portador Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="idPessoa">Identificador da pessoa</param> 
        /// <param name="portador">portador</param> 
        /// <returns>PortadorResponse</returns>
        public PortadorResponse AtualizarParcial (long? id, long? idPessoa, PortadorParcialUpdate portador)
        {
             ApiResponse<PortadorResponse> localVarResponse = AtualizarParcialWithHttpInfo(id, idPessoa, portador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="idPessoa">Identificador da pessoa</param> 
        /// <param name="portador">portador</param> 
        /// <returns>ApiResponse of PortadorResponse</returns>
        public ApiResponse< PortadorResponse > AtualizarParcialWithHttpInfo (long? id, long? idPessoa, PortadorParcialUpdate portador)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->AtualizarParcial");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroGeralApi->AtualizarParcial");
            
            // verify the required parameter 'portador' is set
            if (portador == null)
                throw new ApiException(400, "Missing required parameter 'portador' when calling CadastroGeralApi->AtualizarParcial");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{idPessoa}/portadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (portador.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(portador); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portador; // byte array
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
    
            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }

        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <param name="portador">portador</param>
        /// <returns>Task of PortadorResponse</returns>
        public async System.Threading.Tasks.Task<PortadorResponse> AtualizarParcialAsync (long? id, long? idPessoa, PortadorParcialUpdate portador)
        {
             ApiResponse<PortadorResponse> localVarResponse = await AtualizarParcialAsyncWithHttpInfo(id, idPessoa, portador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do Portador Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos dados do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <param name="portador">portador</param>
        /// <returns>Task of ApiResponse (PortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PortadorResponse>> AtualizarParcialAsyncWithHttpInfo (long? id, long? idPessoa, PortadorParcialUpdate portador)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcial");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AtualizarParcial");
            // verify the required parameter 'portador' is set
            if (portador == null) throw new ApiException(400, "Missing required parameter 'portador' when calling AtualizarParcial");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{idPessoa}/portadores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (portador.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(portador); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portador; // byte array
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

            return new ApiResponse<PortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PortadorResponse)));
            
        }
        
        /// <summary>
        /// Recurso para salvar um banco Recurso para salvar um novo banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param> 
        /// <returns>BancoResponse</returns>
        public BancoResponse Cadastrar (BancoPersist bancoPersist)
        {
             ApiResponse<BancoResponse> localVarResponse = CadastrarWithHttpInfo(bancoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recurso para salvar um banco Recurso para salvar um novo banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param> 
        /// <returns>ApiResponse of BancoResponse</returns>
        public ApiResponse< BancoResponse > CadastrarWithHttpInfo (BancoPersist bancoPersist)
        {
            
            // verify the required parameter 'bancoPersist' is set
            if (bancoPersist == null)
                throw new ApiException(400, "Missing required parameter 'bancoPersist' when calling CadastroGeralApi->Cadastrar");
            
    
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
            
            
            
            
            if (bancoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bancoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bancoPersist; // byte array
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
    
            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }

        
        /// <summary>
        /// Recurso para salvar um banco Recurso para salvar um novo banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param>
        /// <returns>Task of BancoResponse</returns>
        public async System.Threading.Tasks.Task<BancoResponse> CadastrarAsync (BancoPersist bancoPersist)
        {
             ApiResponse<BancoResponse> localVarResponse = await CadastrarAsyncWithHttpInfo(bancoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recurso para salvar um banco Recurso para salvar um novo banco
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bancoPersist">bancoPersist</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BancoResponse>> CadastrarAsyncWithHttpInfo (BancoPersist bancoPersist)
        {
            // verify the required parameter 'bancoPersist' is set
            if (bancoPersist == null) throw new ApiException(400, "Missing required parameter 'bancoPersist' when calling Cadastrar");
            
    
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
            
            
            
            
            if (bancoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bancoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bancoPersist; // byte array
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

            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }
        
        /// <summary>
        /// Adiciona novo conv\u00EAnio para o emissor Adiciona novo conv\u00EAnio para o emissor
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
        /// Adiciona novo conv\u00EAnio para o emissor Adiciona novo conv\u00EAnio para o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > CadastrarConvenioWithHttpInfo (ConvenioPersist convenioPersist)
        {
            
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null)
                throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling CadastroGeralApi->CadastrarConvenio");
            
    
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
        /// Adiciona novo conv\u00EAnio para o emissor Adiciona novo conv\u00EAnio para o emissor
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
        /// Adiciona novo conv\u00EAnio para o emissor Adiciona novo conv\u00EAnio para o emissor
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
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Cadastrar_0 (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Cadastrar_0WithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > Cadastrar_0WithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling CadastroGeralApi->Cadastrar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Cadastrar_0Async (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Cadastrar_0AsyncWithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserir configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> Cadastrar_0AsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling Cadastrar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConfigurarTaxaAntecipacao (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConfigurarTaxaAntecipacaoWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConfigurarTaxaAntecipacaoWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConfigurarTaxaAntecipacao");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling CadastroGeralApi->ConfigurarTaxaAntecipacao");
            
    
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
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConfigurarTaxaAntecipacaoAsyncWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
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
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse Consultar (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param> 
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        public ApiResponse< AtendimentoClienteResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar");
            
    
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
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarAsync (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Atendimento Este m\u00E9todo permite consultar os par\u00E2metros de um determinado Atendimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (idAtendimento)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do atendimento cliente (id)</param>
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
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse ConsultarCampanha (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = ConsultarCampanhaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > ConsultarCampanhaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarCampanha");
            
    
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
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaAsync (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await ConsultarCampanhaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar campanha Este m\u00E9todo permite que sejam listados os dados de uma determinada campanha existente na base do emissor. Para isso, \u00E9 preciso informar o seu respectivo c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Campanha</param>
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
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
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
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > ConsultarConvenioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarConvenio");
            
    
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
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
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
        /// Consultar dados banc\u00E1rios de um determinado conv\u00EAnio Consultar dados banc\u00E1rios pelo id do conv\u00EAnio
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
        /// Consultar limites portadores Consulta o limite de um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param> 
        /// <returns>LimitePortadorResponse</returns>
        public LimitePortadorResponse ConsultarLimitePortador (long? id, long? idPessoa)
        {
             ApiResponse<LimitePortadorResponse> localVarResponse = ConsultarLimitePortadorWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar limites portadores Consulta o limite de um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param> 
        /// <returns>ApiResponse of LimitePortadorResponse</returns>
        public ApiResponse< LimitePortadorResponse > ConsultarLimitePortadorWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarLimitePortador");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroGeralApi->ConsultarLimitePortador");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{idPessoa}/portadores/limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitePortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitePortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimitePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimitePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitePortadorResponse)));
            
        }

        
        /// <summary>
        /// Consultar limites portadores Consulta o limite de um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <returns>Task of LimitePortadorResponse</returns>
        public async System.Threading.Tasks.Task<LimitePortadorResponse> ConsultarLimitePortadorAsync (long? id, long? idPessoa)
        {
             ApiResponse<LimitePortadorResponse> localVarResponse = await ConsultarLimitePortadorAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar limites portadores Consulta o limite de um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <returns>Task of ApiResponse (LimitePortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimitePortadorResponse>> ConsultarLimitePortadorAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLimitePortador");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ConsultarLimitePortador");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{idPessoa}/portadores/limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitePortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLimitePortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimitePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitePortadorResponse)));
            
        }
        
        /// <summary>
        /// Listar pacote de tarfias do produtos Listar pacote de tarfias do produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageProdutoPacoteTarifaResponse</returns>
        public PageProdutoPacoteTarifaResponse ConsultarProdutoPacoteTarifa (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageProdutoPacoteTarifaResponse> localVarResponse = ConsultarProdutoPacoteTarifaWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar pacote de tarfias do produtos Listar pacote de tarfias do produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageProdutoPacoteTarifaResponse</returns>
        public ApiResponse< PageProdutoPacoteTarifaResponse > ConsultarProdutoPacoteTarifaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarProdutoPacoteTarifa");
            
    
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
        /// Listar pacote de tarfias do produtos Listar pacote de tarfias do produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageProdutoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageProdutoPacoteTarifaResponse> localVarResponse = await ConsultarProdutoPacoteTarifaAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar pacote de tarfias do produtos Listar pacote de tarfias do produtos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do produto (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConsultarTaxaAntecipacao (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConsultarTaxaAntecipacaoWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConsultarTaxaAntecipacaoWithHttpInfo (long? id, string tipoTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarTaxaAntecipacao");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling CadastroGeralApi->ConsultarTaxaAntecipacao");
            
    
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
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoAsync (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConsultarTaxaAntecipacaoAsyncWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
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
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse ConsultarTipoOperacao (long? id)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = ConsultarTipoOperacaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > ConsultarTipoOperacaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->ConsultarTipoOperacao");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> ConsultarTipoOperacaoAsync (long? id)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await ConsultarTipoOperacaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir de seu c\u00F3digo identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> ConsultarTipoOperacaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoOperacao");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param> 
        /// <returns>BancoResponse</returns>
        public BancoResponse Consultar_0 (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param> 
        /// <returns>ApiResponse of BancoResponse</returns>
        public ApiResponse< BancoResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_0");
            
    
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
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param>
        /// <returns>Task of BancoResponse</returns>
        public async System.Threading.Tasks.Task<BancoResponse> Consultar_0Async (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Banco Este m\u00E9todo permite consultar um determinado Banco a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Banco (id)</param>
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
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Consultar_1 (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_1");
            
    
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
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Consultar_1Async (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar configura\u00E7\u00E3o para registro de cobran\u00E7a Este m\u00E9todo permite buscar uma configura\u00E7\u00E3o, para registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da configura\u00E7\u00E3o (id)</param>
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
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse Consultar_2 (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = Consultar_2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > Consultar_2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_2");
            
    
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
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> Consultar_2Async (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await Consultar_2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de configura\u00E7\u00E3o do rotativo espec\u00EDfico Este recurso permite consultar dados de configura\u00E7\u00E3o do parcelamento rotativo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o de configura\u00E7\u00E3o rotativo (id)</param>
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
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param> 
        /// <returns>ProdutoDetalhesResponse</returns>
        public ProdutoDetalhesResponse Consultar_3 (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = Consultar_3WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param> 
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        public ApiResponse< ProdutoDetalhesResponse > Consultar_3WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_3");
            
    
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
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        public async System.Threading.Tasks.Task<ProdutoDetalhesResponse> Consultar_3Async (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = await Consultar_3AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00E9todo permite consultar um determinado Produto a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</param>
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
        /// Consulta um tipo de trasa\u00E7\u00E3o Consultar um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param> 
        /// <returns>TipoAjusteResponse</returns>
        public TipoAjusteResponse Consultar_4 (long? id)
        {
             ApiResponse<TipoAjusteResponse> localVarResponse = Consultar_4WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta um tipo de trasa\u00E7\u00E3o Consultar um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of TipoAjusteResponse</returns>
        public ApiResponse< TipoAjusteResponse > Consultar_4WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_4");
            
    
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
        /// Consulta um tipo de trasa\u00E7\u00E3o Consultar um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param>
        /// <returns>Task of TipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<TipoAjusteResponse> Consultar_4Async (long? id)
        {
             ApiResponse<TipoAjusteResponse> localVarResponse = await Consultar_4AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta um tipo de trasa\u00E7\u00E3o Consultar um tipo de trasa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do tipo de transa\u00E7\u00E3o</param>
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
        /// Lista os tipos de boletos do emissor Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param> 
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse Consultar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = Consultar_5WithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de boletos do emissor Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param> 
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param> 
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
        /// Lista os tipos de boletos do emissor Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> Consultar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await Consultar_5AsyncWithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de boletos do emissor Este recurso permite que sejam listados os tipos de boletos existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de boleto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de boleto (optional)</param>
        /// <param name="banco">C\u00F3digo identificador do banco (optional)</param>
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
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param> 
        /// <returns>TipoEnderecoResponse</returns>
        public TipoEnderecoResponse Consultar_6 (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = Consultar_6WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param> 
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        public ApiResponse< TipoEnderecoResponse > Consultar_6WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_6");
            
    
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
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<TipoEnderecoResponse> Consultar_6Async (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = await Consultar_6AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00E7o Este m\u00E9todo permite consultar um determinado Tipo de Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id)</param>
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
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse Consultar_7 (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = Consultar_7WithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > Consultar_7WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CadastroGeralApi->Consultar_7");
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling CadastroGeralApi->Consultar_7");
            
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null)
                throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling CadastroGeralApi->Consultar_7");
            
    
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
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> Consultar_7Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await Consultar_7AsyncWithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idCartao, idEstabelecimento e codigoProcessamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">C\u00F3digo de identifica\u00E7\u00E3o do cartao (idCartao)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (idEstabelecimento)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da opera\u00E7\u00E3o</param>
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
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param> 
        /// <returns>TipoTelefoneResponse</returns>
        public TipoTelefoneResponse Consultar_8 (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = Consultar_8WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param> 
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        public ApiResponse< TipoTelefoneResponse > Consultar_8WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->Consultar_8");
            
    
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
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TipoTelefoneResponse> Consultar_8Async (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = await Consultar_8AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00E9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id)</param>
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
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param> 
        /// <returns>PageAtendimentoClienteResponse</returns>
        public PageAtendimentoClienteResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param> 
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
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista todos os atendimentos Este m\u00E9todo permite que sejam listados todos os Registro de Atendimento, independente do Tipo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o de conta (id) (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data em que o Atendimento foi realizado (optional)</param>
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
        /// Listar Campanhas Lista as campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param> 
        /// <param name="nome">Nome da campanha (optional)</param> 
        /// <returns>PageCampanhaResponse</returns>
        public PageCampanhaResponse ListarCampanhas (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = ListarCampanhasWithHttpInfo(sort, page, limit, idTipoCampanha, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Campanhas Lista as campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param> 
        /// <param name="nome">Nome da campanha (optional)</param> 
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        public ApiResponse< PageCampanhaResponse > ListarCampanhasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null)
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
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
        /// Listar Campanhas Lista as campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param>
        /// <param name="nome">Nome da campanha (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = await ListarCampanhasAsyncWithHttpInfo(sort, page, limit, idTipoCampanha, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Campanhas Lista as campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo de campanha (id) (optional)</param>
        /// <param name="nome">Nome da campanha (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null, string nome = null)
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

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
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param> 
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">Conta corrente (optional)</param> 
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param> 
        /// <returns>PageConvenioResponse</returns>
        public PageConvenioResponse ListarConvenios (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
             ApiResponse<PageConvenioResponse> localVarResponse = ListarConveniosWithHttpInfo(sort, page, limit, banco, agencia, contaCorrente, numeroConvenio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param> 
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">Conta corrente (optional)</param> 
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param> 
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
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente (optional)</param>
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param>
        /// <returns>Task of PageConvenioResponse</returns>
        public async System.Threading.Tasks.Task<PageConvenioResponse> ListarConveniosAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
             ApiResponse<PageConvenioResponse> localVarResponse = await ListarConveniosAsyncWithHttpInfo(sort, page, limit, banco, agencia, contaCorrente, numeroConvenio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os dados banc\u00E1rios dos conv\u00EAnios existentes Lista os dados banc\u00E1rios dos conv\u00EAnios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="banco">Identifica\u00E7\u00E3o do banco (optional)</param>
        /// <param name="agencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">Conta corrente (optional)</param>
        /// <param name="numeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio (optional)</param>
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
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarEstadosCivis (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarEstadosCivisWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarEstadosCivisAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Estados C\u00EDvis Este m\u00E9todo permite que sejam listados os Estados C\u00EDvis na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageFantasiaBasicaResponse</returns>
        public PageFantasiaBasicaResponse ListarFantasiasBasicas (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = ListarFantasiasBasicasWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        public async System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = await ListarFantasiasBasicasAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Fantasias B\u00E1sicas Lista as fantasia b\u00E1sicas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Lista os Grupos MCCs Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param> 
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param> 
        /// <returns>PageGrupoMCCResponse</returns>
        public PageGrupoMCCResponse ListarGrupoMCC (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null)
        {
             ApiResponse<PageGrupoMCCResponse> localVarResponse = ListarGrupoMCCWithHttpInfo(sort, page, limit, id, descricao, descricaoExtrato);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Grupos MCCs Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param> 
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param> 
        /// <returns>ApiResponse of PageGrupoMCCResponse</returns>
        public ApiResponse< PageGrupoMCCResponse > ListarGrupoMCCWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null)
        {
            
    
            var localVarPath = "/api/mcc/grupos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (descricaoExtrato != null) localVarQueryParams.Add("descricaoExtrato", Configuration.ApiClient.ParameterToString(descricaoExtrato)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarGrupoMCC: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarGrupoMCC: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoMCCResponse)));
            
        }

        
        /// <summary>
        /// Lista os Grupos MCCs Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param>
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param>
        /// <returns>Task of PageGrupoMCCResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoMCCResponse> ListarGrupoMCCAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null)
        {
             ApiResponse<PageGrupoMCCResponse> localVarResponse = await ListarGrupoMCCAsyncWithHttpInfo(sort, page, limit, id, descricao, descricaoExtrato);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Grupos MCCs Este m\u00E9todo permite que sejam listados os grupos MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do grupo MCC (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o internacional do grupo MCC (optional)</param>
        /// <param name="descricaoExtrato">Descri\u00E7\u00E3o para ser exibida em extratos (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoMCCResponse>> ListarGrupoMCCAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, string descricaoExtrato = null)
        {
            
    
            var localVarPath = "/api/mcc/grupos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (descricaoExtrato != null) localVarQueryParams.Add("descricaoExtrato", Configuration.ApiClient.ParameterToString(descricaoExtrato)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarGrupoMCC: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarGrupoMCC: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoMCCResponse)));
            
        }
        
        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNacionalidades (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNacionalidadesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNacionalidadesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista nacionalidades Este m\u00E9todo permite que sejam listados as nacionalidades na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoes (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNaturezasOcupacoesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNaturezasOcupacoesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Ocupa\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as naturezas de opera\u00E7\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarParentescos (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarParentescosWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarParentescosAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Parentescos Este m\u00E9todo permite que sejam listados parentescos na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarProfissoes (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarProfissoesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarProfissoesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista profiss\u00F5es Este m\u00E9todo permite que sejam listados as profiss\u00F5es na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Listar Tipos de Campanhas Lista os tipos de campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoCampanhaResponse</returns>
        public PageTipoCampanhaResponse ListarTiposCampanhas (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = ListarTiposCampanhasWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Tipos de Campanhas Lista os tipos de campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Listar Tipos de Campanhas Lista os tipos de campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = await ListarTiposCampanhasAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Tipos de Campanhas Lista os tipos de campanhas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageBancoResponse</returns>
        public PageBancoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        public async System.Threading.Tasks.Task<PageBancoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Bancos cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Bancos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = Listar_1WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
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
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar configura\u00E7\u00F5es para registro de cobran\u00E7a Este m\u00E9todo permite listar as configura\u00E7\u00F5es de registro de cobran\u00E7a
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
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
        /// Listar as configura\u00E7\u00F5es rotativo Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param> 
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        public PageConfiguracaoRotativoResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = Listar_2WithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param> 
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
        /// Listar as configura\u00E7\u00F5es rotativo Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = await Listar_2AsyncWithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as configura\u00E7\u00F5es rotativo Este recurso permite listar as configura\u00E7\u00F5es rotativo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do Produto (optional)</param>
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
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param> 
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param> 
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param> 
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param> 
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param> 
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param> 
        /// <returns>PagePortadorResponse</returns>
        public PagePortadorResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = Listar_3WithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param> 
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param> 
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param> 
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param> 
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param> 
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param> 
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
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        public async System.Threading.Tasks.Task<PagePortadorResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = await Listar_3AsyncWithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Portadores existentes Este m\u00E9todo permite que sejam listados os portadores cadastrados na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="idParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Mostre o tipo de titular do cart\u00E3o, sendo: (&#39;T&#39;: titular, &#39;A&#39;: adicional) (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o (optional)</param>
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
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param> 
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param> 
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param> 
        /// <returns>PageProdutoResponse</returns>
        public PageProdutoResponse Listar_4 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = Listar_4WithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param> 
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param> 
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param> 
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
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoResponse> Listar_4Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = await Listar_4AsyncWithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00E9todo permite que sejam listados os Produtos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Descri\u00E7\u00E3o do Nome do Produto (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (optional)</param>
        /// <param name="idFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence (optional)</param>
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
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param> 
        /// <param name="nome">Nome do Promotor (optional)</param> 
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param> 
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param> 
        /// <returns>PagePromotorResponse</returns>
        public PagePromotorResponse Listar_5 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = Listar_5WithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param> 
        /// <param name="nome">Nome do Promotor (optional)</param> 
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param> 
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param> 
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
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        public async System.Threading.Tasks.Task<PagePromotorResponse> Listar_5Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = await Listar_5AsyncWithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista promotores cadastrados na base do emissor Este m\u00E9todo permite que sejam listados os cadastros de Promoteres existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do promotor (id) (optional)</param>
        /// <param name="nome">Nome do Promotor (optional)</param>
        /// <param name="dataCadastro">Data da Inclus\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (optional)</param>
        /// <param name="idUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do usu\u00E1rio (optional)</param>
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
        /// Lista os tipos de ajustes do emissor Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param> 
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param> 
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param> 
        /// <returns>PageTipoAjusteResponse</returns>
        public PageTipoAjusteResponse Listar_6 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = Listar_6WithHttpInfo(sort, page, limit, id, descricao, flagPagamentoLojista, flagSistema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de ajustes do emissor Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param> 
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param> 
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param> 
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
        /// Lista os tipos de ajustes do emissor Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param>
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param>
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoAjusteResponse> Listar_6Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = await Listar_6AsyncWithHttpInfo(sort, page, limit, id, descricao, flagPagamentoLojista, flagSistema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de ajustes do emissor Este recurso permite que sejam listados os tipos de ajustes existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo identificador do tipo de ajuste (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de ajuste (optional)</param>
        /// <param name="flagPagamentoLojista">Identifica se o pagamento foi efetuado em estabelecimento (optional)</param>
        /// <param name="flagSistema">Identifica se o tipo de ajuste \u00E9 lan\u00E7ado pelo sistema (optional)</param>
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
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param> 
        /// <returns>PageTipoEnderecoResponse</returns>
        public PageTipoEnderecoResponse Listar_7 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = Listar_7WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param> 
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
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoEnderecoResponse> Listar_7Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = await Listar_7AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00F5es de Tipos de Endere\u00E7os do Emissor Este m\u00E9todo permite que sejam listados os Tipos de Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Endere\u00E7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00E7o (optional)</param>
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
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param> 
        /// <returns>PageTipoTelefoneResponse</returns>
        public PageTipoTelefoneResponse Listar_8 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = Listar_8WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param> 
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
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTelefoneResponse> Listar_8Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = await Listar_8AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00E9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
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
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param> 
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param> 
        /// <returns>PageControleVencimentoResponse</returns>
        public PageControleVencimentoResponse Listar_9 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = Listar_9WithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param> 
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param> 
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
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleVencimentoResponse> Listar_9Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = await Listar_9AsyncWithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Vencimentos Este recurso permite que sejam listados os Vencimentos do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataVencimento">Indica a data de vencimento das faturas (optional)</param>
        /// <param name="dataVencimentoFim">Indica a data vencimento final das faturas (optional)</param>
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
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param> 
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param> 
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse Salvar (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = SalvarWithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param> 
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param> 
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param> 
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param> 
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param> 
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
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarAsync (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await SalvarAsyncWithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro um novo Atendimento do tipo Gen\u00E9rico para uma Conta Este m\u00E9todo permite cadastra um novo atendimento do tipo Gen\u00E9rico para uma Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado (optional)</param>
        /// <param name="conteudoAtendimento">Conte\u00FAdo do Atendimento (optional)</param>
        /// <param name="detalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento (optional)</param>
        /// <param name="nomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento (optional)</param>
        /// <param name="dataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data e hora para retorno do Atendimento no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi finalizado. Quando utilizado, serve para medir a performance dos Atendimentos no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="flagFilaFraude">Flag fila fraude (optional)</param>
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
        /// Adiciona limite ao portador Este recurso permite adicionar limite \u00E0 um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param> 
        /// <param name="persist">persist</param> 
        /// <returns>LimitePortadorResponse</returns>
        public LimitePortadorResponse SalvarLimitePortador (long? id, long? idPessoa, LimitePortadorPersist persist)
        {
             ApiResponse<LimitePortadorResponse> localVarResponse = SalvarLimitePortadorWithHttpInfo(id, idPessoa, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona limite ao portador Este recurso permite adicionar limite \u00E0 um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of LimitePortadorResponse</returns>
        public ApiResponse< LimitePortadorResponse > SalvarLimitePortadorWithHttpInfo (long? id, long? idPessoa, LimitePortadorPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroGeralApi->SalvarLimitePortador");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroGeralApi->SalvarLimitePortador");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling CadastroGeralApi->SalvarLimitePortador");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{idPessoa}/portadores/limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarLimitePortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLimitePortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LimitePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimitePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitePortadorResponse)));
            
        }

        
        /// <summary>
        /// Adiciona limite ao portador Este recurso permite adicionar limite \u00E0 um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of LimitePortadorResponse</returns>
        public async System.Threading.Tasks.Task<LimitePortadorResponse> SalvarLimitePortadorAsync (long? id, long? idPessoa, LimitePortadorPersist persist)
        {
             ApiResponse<LimitePortadorResponse> localVarResponse = await SalvarLimitePortadorAsyncWithHttpInfo(id, idPessoa, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona limite ao portador Este recurso permite adicionar limite \u00E0 um portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo identificador da conta</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (LimitePortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LimitePortadorResponse>> SalvarLimitePortadorAsyncWithHttpInfo (long? id, long? idPessoa, LimitePortadorPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarLimitePortador");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling SalvarLimitePortador");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarLimitePortador");
            
    
            var localVarPath = "/api/contas/{id}/pessoas/{idPessoa}/portadores/limites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarLimitePortador: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarLimitePortador: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LimitePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LimitePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LimitePortadorResponse)));
            
        }
        
        /// <summary>
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha
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
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > Salvar_0WithHttpInfo (CampanhaPersist campanhaPersist)
        {
            
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null)
                throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling CadastroGeralApi->Salvar_0");
            
    
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
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha
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
        /// Inserir campanha Este m\u00E9todo permite que seja cadastrado uma nova campanha
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
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
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
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > Salvar_1WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling CadastroGeralApi->Salvar_1");
            
    
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
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
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
        /// Inserir os dados de configura\u00E7\u00E3o do rotativo de um produto Este m\u00E9todo permite que seja cadastrado uma nova configura\u00E7\u00E3o do rotativo para um determinado produto
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
