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
    public interface IGlobaltagcadastrogeralApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{convenio_resource_alterar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse AlterarConvenioUsingPUT (long? id, ConvenioPersist convenioPersist);
  
        /// <summary>
        /// {{{convenio_resource_alterar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> AlterarConvenioUsingPUTWithHttpInfo (long? id, ConvenioPersist convenioPersist);
        
        /// <summary>
        /// {{{vencimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>ControleVencimentoResponse</returns>
        ControleVencimentoResponse AlterarCorteUsingPUT (string dataVencimento, VencimentoUpdate update);
  
        /// <summary>
        /// {{{vencimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ControleVencimentoResponse</returns>
        ApiResponse<ControleVencimentoResponse> AlterarCorteUsingPUTWithHttpInfo (string dataVencimento, VencimentoUpdate update);
        
        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse AlterarParcialUsingPATCH (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
  
        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> AlterarParcialUsingPATCHWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
        
        /// <summary>
        /// {{{campanha_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse AlterarUsingPUT1 (long? id, CampanhaUpdateValue update);
  
        /// <summary>
        /// {{{campanha_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> AlterarUsingPUT1WithHttpInfo (long? id, CampanhaUpdateValue update);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse AlterarUsingPUT2 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> AlterarUsingPUT2WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse AlterarUsingPUT3 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> AlterarUsingPUT3WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse CadastrarConvenioUsingPOST (ConvenioPersist convenioPersist);
  
        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> CadastrarConvenioUsingPOSTWithHttpInfo (ConvenioPersist convenioPersist);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse CadastrarUsingPOST3 (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
  
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> CadastrarUsingPOST3WithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConfigurarTaxaAntecipacaoUsingPOST (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
  
        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoUsingPOSTWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// {{{campanha_resource_consultar_campanha}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_consultar_campanha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse ConsultarCampanhaUsingGET (long? id);
  
        /// <summary>
        /// {{{campanha_resource_consultar_campanha}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_consultar_campanha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> ConsultarCampanhaUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{convenio_resource_consultar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ConvenioResponse</returns>
        ConvenioResponse ConsultarConvenioUsingGET (long? id);
  
        /// <summary>
        /// {{{convenio_resource_consultar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of ConvenioResponse</returns>
        ApiResponse<ConvenioResponse> ConsultarConvenioUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageProdutoPacoteTarifaResponse</returns>
        PageProdutoPacoteTarifaResponse ConsultarProdutoPacoteTarifaUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageProdutoPacoteTarifaResponse</returns>
        ApiResponse<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param>
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param>
        /// <returns>ParametroProdutoResponse</returns>
        ParametroProdutoResponse ConsultarTaxaAntecipacaoUsingGET (long? id, string tipoTransacao);
  
        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param>
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param>
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        ApiResponse<ParametroProdutoResponse> ConsultarTaxaAntecipacaoUsingGETWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{produto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param>
        /// <returns>ProdutoDetalhesResponse</returns>
        ProdutoDetalhesResponse ConsultarUsingGET31 (long? id);
  
        /// <summary>
        /// {{{produto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        ApiResponse<ProdutoDetalhesResponse> ConsultarUsingGET31WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param>
        /// <returns>TipoAjusteResponse</returns>
        TipoAjusteResponse ConsultarUsingGET40 (long? id);
  
        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TipoAjusteResponse</returns>
        ApiResponse<TipoAjusteResponse> ConsultarUsingGET40WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param>
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param>
        /// <returns>PageTipoBoletoResponse</returns>
        PageTipoBoletoResponse ConsultarUsingGET41 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
  
        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param>
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        ApiResponse<PageTipoBoletoResponse> ConsultarUsingGET41WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param>
        /// <returns>TipoEnderecoResponse</returns>
        TipoEnderecoResponse ConsultarUsingGET43 (long? id);
  
        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        ApiResponse<TipoEnderecoResponse> ConsultarUsingGET43WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param>
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param>
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param>
        /// <returns>TipoOperacaoResponse</returns>
        TipoOperacaoResponse ConsultarUsingGET44 (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
  
        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param>
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param>
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param>
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        ApiResponse<TipoOperacaoResponse> ConsultarUsingGET44WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param>
        /// <returns>TipoTelefoneResponse</returns>
        TipoTelefoneResponse ConsultarUsingGET46 (long? id);
  
        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        ApiResponse<TipoTelefoneResponse> ConsultarUsingGET46WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse ConsultarUsingGET5 (long? id);
  
        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> ConsultarUsingGET5WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{banco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param>
        /// <returns>BancoResponse</returns>
        BancoResponse ConsultarUsingGET7 (long? id);
  
        /// <summary>
        /// {{{banco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of BancoResponse</returns>
        ApiResponse<BancoResponse> ConsultarUsingGET7WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse ConsultarUsingGET9 (long? id);
  
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> ConsultarUsingGET9WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_listar_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param>
        /// <returns>PageCampanhaResponse</returns>
        PageCampanhaResponse ListarCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
  
        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_listar_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param>
        /// <returns>ApiResponse of PageCampanhaResponse</returns>
        ApiResponse<PageCampanhaResponse> ListarCampanhasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
        
        /// <summary>
        /// {{{convenio_resource_listar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param>
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param>
        /// <returns>PageConvenioResponse</returns>
        PageConvenioResponse ListarConveniosUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
  
        /// <summary>
        /// {{{convenio_resource_listar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param>
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param>
        /// <returns>ApiResponse of PageConvenioResponse</returns>
        ApiResponse<PageConvenioResponse> ListarConveniosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarEstadosCivisUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}}
        /// </summary>
        /// <remarks>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageFantasiaBasicaResponse</returns>
        PageFantasiaBasicaResponse ListarFantasiasBasicasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}}
        /// </summary>
        /// <remarks>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageFantasiaBasicaResponse</returns>
        ApiResponse<PageFantasiaBasicaResponse> ListarFantasiasBasicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_nacionalidades}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNacionalidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{campo_codificado_resource_listar_nacionalidades}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_parentescos}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarParentescosUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{campo_codificado_resource_listar_parentescos}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarParentescosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_profissoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarProfissoesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{campo_codificado_resource_listar_profissoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarProfissoesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTipoCampanhaResponse</returns>
        PageTipoCampanhaResponse ListarTiposCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoCampanhaResponse</returns>
        ApiResponse<PageTipoCampanhaResponse> ListarTiposCampanhasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        ConfiguracaoRegistroCobrancaResponse ListarUsingGET11 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        ApiResponse<ConfiguracaoRegistroCobrancaResponse> ListarUsingGET11WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param>
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        PageConfiguracaoRotativoResponse ListarUsingGET12 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
  
        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param>
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        ApiResponse<PageConfiguracaoRotativoResponse> ListarUsingGET12WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// {{{portador_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{portador_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param>
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param>
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param>
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param>
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param>
        /// <returns>PagePortadorResponse</returns>
        PagePortadorResponse ListarUsingGET36 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
  
        /// <summary>
        /// {{{portador_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{portador_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param>
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param>
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param>
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param>
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        ApiResponse<PagePortadorResponse> ListarUsingGET36WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// {{{produto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param>
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param>
        /// <returns>PageProdutoResponse</returns>
        PageProdutoResponse ListarUsingGET37 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
  
        /// <summary>
        /// {{{produto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param>
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param>
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        ApiResponse<PageProdutoResponse> ListarUsingGET37WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// {{{promotor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{promotor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param>
        /// <returns>PagePromotorResponse</returns>
        PagePromotorResponse ListarUsingGET38 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
  
        /// <summary>
        /// {{{promotor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{promotor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        ApiResponse<PagePromotorResponse> ListarUsingGET38WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param>
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param>
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param>
        /// <returns>PageTipoAjusteResponse</returns>
        PageTipoAjusteResponse ListarUsingGET49 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
  
        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param>
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param>
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        ApiResponse<PageTipoAjusteResponse> ListarUsingGET49WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
        
        /// <summary>
        /// {{{tipo_endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param>
        /// <returns>PageTipoEnderecoResponse</returns>
        PageTipoEnderecoResponse ListarUsingGET52 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// {{{tipo_endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        ApiResponse<PageTipoEnderecoResponse> ListarUsingGET52WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// {{{tipo_telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param>
        /// <returns>PageTipoTelefoneResponse</returns>
        PageTipoTelefoneResponse ListarUsingGET54 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// {{{tipo_telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        ApiResponse<PageTipoTelefoneResponse> ListarUsingGET54WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param>
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param>
        /// <returns>PageAtendimentoClienteResponse</returns>
        PageAtendimentoClienteResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
  
        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param>
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param>
        /// <returns>ApiResponse of PageAtendimentoClienteResponse</returns>
        ApiResponse<PageAtendimentoClienteResponse> ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// {{{vencimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param>
        /// <returns>PageControleVencimentoResponse</returns>
        PageControleVencimentoResponse ListarUsingGET60 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
  
        /// <summary>
        /// {{{vencimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param>
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        ApiResponse<PageControleVencimentoResponse> ListarUsingGET60WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        /// <summary>
        /// {{{banco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageBancoResponse</returns>
        PageBancoResponse ListarUsingGET8 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{banco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageBancoResponse</returns>
        ApiResponse<PageBancoResponse> ListarUsingGET8WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{atendimento_cliente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param>
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param>
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param>
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param>
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param>
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param>
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param>
        /// <returns>AtendimentoClienteResponse</returns>
        AtendimentoClienteResponse SalvarUsingPOST2 (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
  
        /// <summary>
        /// {{{atendimento_cliente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param>
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param>
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param>
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param>
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param>
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param>
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param>
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        ApiResponse<AtendimentoClienteResponse> SalvarUsingPOST2WithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// {{{campanha_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>CampanhaResponse</returns>
        CampanhaResponse SalvarUsingPOST4 (CampanhaPersist campanhaPersist);
  
        /// <summary>
        /// {{{campanha_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>ApiResponse of CampanhaResponse</returns>
        ApiResponse<CampanhaResponse> SalvarUsingPOST4WithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        ConfiguracaoRotativoDetalheResponse SalvarUsingPOST5 (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
  
        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        ApiResponse<ConfiguracaoRotativoDetalheResponse> SalvarUsingPOST5WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{convenio_resource_alterar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> AlterarConvenioUsingPUTAsync (long? id, ConvenioPersist convenioPersist);

        /// <summary>
        /// {{{convenio_resource_alterar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> AlterarConvenioUsingPUTAsyncWithHttpInfo (long? id, ConvenioPersist convenioPersist);
        
        /// <summary>
        /// {{{vencimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleVencimentoResponse</returns>
        System.Threading.Tasks.Task<ControleVencimentoResponse> AlterarCorteUsingPUTAsync (string dataVencimento, VencimentoUpdate update);

        /// <summary>
        /// {{{vencimento_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleVencimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleVencimentoResponse>> AlterarCorteUsingPUTAsyncWithHttpInfo (string dataVencimento, VencimentoUpdate update);
        
        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> AlterarParcialUsingPATCHAsync (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);

        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> AlterarParcialUsingPATCHAsyncWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate);
        
        /// <summary>
        /// {{{campanha_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> AlterarUsingPUT1Async (long? id, CampanhaUpdateValue update);

        /// <summary>
        /// {{{campanha_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarUsingPUT1AsyncWithHttpInfo (long? id, CampanhaUpdateValue update);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> AlterarUsingPUT2Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> AlterarUsingPUT3Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> AlterarUsingPUT3AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> CadastrarConvenioUsingPOSTAsync (ConvenioPersist convenioPersist);

        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> CadastrarConvenioUsingPOSTAsyncWithHttpInfo (ConvenioPersist convenioPersist);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> CadastrarUsingPOST3Async (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist);
        
        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoUsingPOSTAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);

        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoUsingPOSTAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
        /// <summary>
        /// {{{campanha_resource_consultar_campanha}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_consultar_campanha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaUsingGETAsync (long? id);

        /// <summary>
        /// {{{campanha_resource_consultar_campanha}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_consultar_campanha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> ConsultarCampanhaUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{convenio_resource_consultar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ConvenioResponse</returns>
        System.Threading.Tasks.Task<ConvenioResponse> ConsultarConvenioUsingGETAsync (long? id);

        /// <summary>
        /// {{{convenio_resource_consultar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> ConsultarConvenioUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageProdutoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoPacoteTarifaResponse>> ConsultarProdutoPacoteTarifaUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param>
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoUsingGETAsync (long? id, string tipoTransacao);

        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param>
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoUsingGETAsyncWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{produto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        System.Threading.Tasks.Task<ProdutoDetalhesResponse> ConsultarUsingGET31Async (long? id);

        /// <summary>
        /// {{{produto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> ConsultarUsingGET31AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoAjusteResponse</returns>
        System.Threading.Tasks.Task<TipoAjusteResponse> ConsultarUsingGET40Async (long? id);

        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoAjusteResponse>> ConsultarUsingGET40AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param>
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        System.Threading.Tasks.Task<PageTipoBoletoResponse> ConsultarUsingGET41Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);

        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_boleto_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param>
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ConsultarUsingGET41AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null);
        
        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<TipoEnderecoResponse> ConsultarUsingGET43Async (long? id);

        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> ConsultarUsingGET43AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param>
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param>
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoResponse> ConsultarUsingGET44Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento);

        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_operacao_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param>
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param>
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> ConsultarUsingGET44AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento);
        
        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<TipoTelefoneResponse> ConsultarUsingGET46Async (long? id);

        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> ConsultarUsingGET46AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarUsingGET5Async (long? id);

        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarUsingGET5AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{banco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param>
        /// <returns>Task of BancoResponse</returns>
        System.Threading.Tasks.Task<BancoResponse> ConsultarUsingGET7Async (long? id);

        /// <summary>
        /// {{{banco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BancoResponse>> ConsultarUsingGET7AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ConsultarUsingGET9Async (long? id);

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ConsultarUsingGET9AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_listar_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);

        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_listar_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampanhaResponse>> ListarCampanhasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null);
        
        /// <summary>
        /// {{{convenio_resource_listar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param>
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param>
        /// <returns>Task of PageConvenioResponse</returns>
        System.Threading.Tasks.Task<PageConvenioResponse> ListarConveniosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);

        /// <summary>
        /// {{{convenio_resource_listar_value}}}
        /// </summary>
        /// <remarks>
        /// {{{convenio_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param>
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageConvenioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConvenioResponse>> ListarConveniosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarEstadosCivisUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}}
        /// </summary>
        /// <remarks>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}}
        /// </summary>
        /// <remarks>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageFantasiaBasicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFantasiaBasicaResponse>> ListarFantasiasBasicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_nacionalidades}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{campo_codificado_resource_listar_nacionalidades}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNacionalidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarNaturezasOcupacoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_parentescos}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{campo_codificado_resource_listar_parentescos}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarParentescosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_profissoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{campo_codificado_resource_listar_profissoes}}}
        /// </summary>
        /// <remarks>
        /// {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarProfissoesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoCampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoCampanhaResponse>> ListarTiposCampanhasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ListarUsingGET11Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ListarUsingGET11AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> ListarUsingGET12Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);

        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> ListarUsingGET12AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null);
        
        /// <summary>
        /// {{{portador_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{portador_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param>
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param>
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param>
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param>
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        System.Threading.Tasks.Task<PagePortadorResponse> ListarUsingGET36Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);

        /// <summary>
        /// {{{portador_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{portador_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param>
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param>
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param>
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param>
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> ListarUsingGET36AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null);
        
        /// <summary>
        /// {{{produto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param>
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        System.Threading.Tasks.Task<PageProdutoResponse> ListarUsingGET37Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);

        /// <summary>
        /// {{{produto_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{produto_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param>
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> ListarUsingGET37AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null);
        
        /// <summary>
        /// {{{promotor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{promotor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        System.Threading.Tasks.Task<PagePromotorResponse> ListarUsingGET38Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);

        /// <summary>
        /// {{{promotor_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{promotor_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> ListarUsingGET38AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null);
        
        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param>
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param>
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        System.Threading.Tasks.Task<PageTipoAjusteResponse> ListarUsingGET49Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);

        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_ajuste_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param>
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param>
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> ListarUsingGET49AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null);
        
        /// <summary>
        /// {{{tipo_endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageTipoEnderecoResponse> ListarUsingGET52Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// {{{tipo_endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> ListarUsingGET52AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// {{{tipo_telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTipoTelefoneResponse> ListarUsingGET54Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// {{{tipo_telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> ListarUsingGET54AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param>
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);

        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param>
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageAtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAtendimentoClienteResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null);
        
        /// <summary>
        /// {{{vencimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        System.Threading.Tasks.Task<PageControleVencimentoResponse> ListarUsingGET60Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);

        /// <summary>
        /// {{{vencimento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{vencimento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> ListarUsingGET60AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null);
        
        /// <summary>
        /// {{{banco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        System.Threading.Tasks.Task<PageBancoResponse> ListarUsingGET8Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{banco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{banco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageBancoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBancoResponse>> ListarUsingGET8AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{atendimento_cliente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param>
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param>
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param>
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param>
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param>
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param>
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarUsingPOST2Async (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);

        /// <summary>
        /// {{{atendimento_cliente_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{atendimento_cliente_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param>
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param>
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param>
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param>
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param>
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param>
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> SalvarUsingPOST2AsyncWithHttpInfo (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null);
        
        /// <summary>
        /// {{{campanha_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        System.Threading.Tasks.Task<CampanhaResponse> SalvarUsingPOST4Async (CampanhaPersist campanhaPersist);

        /// <summary>
        /// {{{campanha_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{campanha_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> SalvarUsingPOST4AsyncWithHttpInfo (CampanhaPersist campanhaPersist);
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> SalvarUsingPOST5Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist);

        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> SalvarUsingPOST5AsyncWithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagcadastrogeralApi : IGlobaltagcadastrogeralApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcadastrogeralApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagcadastrogeralApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcadastrogeralApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagcadastrogeralApi(Configuration configuration = null)
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
        /// {{{convenio_resource_alterar_value}}} {{{convenio_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ConvenioResponse</returns>
        public ConvenioResponse AlterarConvenioUsingPUT (long? id, ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = AlterarConvenioUsingPUTWithHttpInfo(id, convenioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{convenio_resource_alterar_value}}} {{{convenio_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > AlterarConvenioUsingPUTWithHttpInfo (long? id, ConvenioPersist convenioPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->AlterarConvenioUsingPUT");
            
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null)
                throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling GlobaltagcadastrogeralApi->AlterarConvenioUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenioUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenioUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }

        
        /// <summary>
        /// {{{convenio_resource_alterar_value}}} {{{convenio_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        public async System.Threading.Tasks.Task<ConvenioResponse> AlterarConvenioUsingPUTAsync (long? id, ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = await AlterarConvenioUsingPUTAsyncWithHttpInfo(id, convenioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{convenio_resource_alterar_value}}} {{{convenio_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> AlterarConvenioUsingPUTAsyncWithHttpInfo (long? id, ConvenioPersist convenioPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarConvenioUsingPUT");
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null) throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling AlterarConvenioUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenioUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarConvenioUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }
        
        /// <summary>
        /// {{{vencimento_resource_alterar}}} {{{vencimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ControleVencimentoResponse</returns>
        public ControleVencimentoResponse AlterarCorteUsingPUT (string dataVencimento, VencimentoUpdate update)
        {
             ApiResponse<ControleVencimentoResponse> localVarResponse = AlterarCorteUsingPUTWithHttpInfo(dataVencimento, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vencimento_resource_alterar}}} {{{vencimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ControleVencimentoResponse</returns>
        public ApiResponse< ControleVencimentoResponse > AlterarCorteUsingPUTWithHttpInfo (string dataVencimento, VencimentoUpdate update)
        {
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling GlobaltagcadastrogeralApi->AlterarCorteUsingPUT");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagcadastrogeralApi->AlterarCorteUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorteUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorteUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleVencimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{vencimento_resource_alterar}}} {{{vencimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleVencimentoResponse</returns>
        public async System.Threading.Tasks.Task<ControleVencimentoResponse> AlterarCorteUsingPUTAsync (string dataVencimento, VencimentoUpdate update)
        {
             ApiResponse<ControleVencimentoResponse> localVarResponse = await AlterarCorteUsingPUTAsyncWithHttpInfo(dataVencimento, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vencimento_resource_alterar}}} {{{vencimento_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">{{{fatura_resource_consultar_fatura_param_data_vencimento}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleVencimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleVencimentoResponse>> AlterarCorteUsingPUTAsyncWithHttpInfo (string dataVencimento, VencimentoUpdate update)
        {
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling AlterarCorteUsingPUT");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarCorteUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorteUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarCorteUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleVencimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}} {{{tipo_operacao_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param> 
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse AlterarParcialUsingPATCH (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = AlterarParcialUsingPATCHWithHttpInfo(id, tipoOperacaoParcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}} {{{tipo_operacao_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param> 
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > AlterarParcialUsingPATCHWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->AlterarParcialUsingPATCH");
            
            // verify the required parameter 'tipoOperacaoParcialUpdate' is set
            if (tipoOperacaoParcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'tipoOperacaoParcialUpdate' when calling GlobaltagcadastrogeralApi->AlterarParcialUsingPATCH");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcialUsingPATCH: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcialUsingPATCH: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}} {{{tipo_operacao_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> AlterarParcialUsingPATCHAsync (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await AlterarParcialUsingPATCHAsyncWithHttpInfo(id, tipoOperacaoParcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_operacao_resource_alterar}}} {{{tipo_operacao_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_operacao_resource_alterar_param_id}}}</param>
        /// <param name="tipoOperacaoParcialUpdate">tipoOperacaoParcialUpdate</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> AlterarParcialUsingPATCHAsyncWithHttpInfo (long? id, TipoOperacaoParcialUpdate tipoOperacaoParcialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarParcialUsingPATCH");
            // verify the required parameter 'tipoOperacaoParcialUpdate' is set
            if (tipoOperacaoParcialUpdate == null) throw new ApiException(400, "Missing required parameter 'tipoOperacaoParcialUpdate' when calling AlterarParcialUsingPATCH");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcialUsingPATCH: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarParcialUsingPATCH: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{campanha_resource_alterar}}} {{{campanha_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse AlterarUsingPUT1 (long? id, CampanhaUpdateValue update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = AlterarUsingPUT1WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campanha_resource_alterar}}} {{{campanha_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > AlterarUsingPUT1WithHttpInfo (long? id, CampanhaUpdateValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->AlterarUsingPUT1");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagcadastrogeralApi->AlterarUsingPUT1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// {{{campanha_resource_alterar}}} {{{campanha_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> AlterarUsingPUT1Async (long? id, CampanhaUpdateValue update)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await AlterarUsingPUT1AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campanha_resource_alterar}}} {{{campanha_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> AlterarUsingPUT1AsyncWithHttpInfo (long? id, CampanhaUpdateValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT1");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}} {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse AlterarUsingPUT2 (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = AlterarUsingPUT2WithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}} {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param> 
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > AlterarUsingPUT2WithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->AlterarUsingPUT2");
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling GlobaltagcadastrogeralApi->AlterarUsingPUT2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}} {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> AlterarUsingPUT2Async (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await AlterarUsingPUT2AsyncWithHttpInfo(id, configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_alterar}}} {{{configuracao_registro_cobranca_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT2");
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling AlterarUsingPUT2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}} {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse AlterarUsingPUT3 (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = AlterarUsingPUT3WithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}} {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param> 
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > AlterarUsingPUT3WithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->AlterarUsingPUT3");
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling GlobaltagcadastrogeralApi->AlterarUsingPUT3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}} {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> AlterarUsingPUT3Async (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await AlterarUsingPUT3AsyncWithHttpInfo(id, configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_alterar}}} {{{configuracao_rotativo_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_alterar_param_id}}}</param>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> AlterarUsingPUT3AsyncWithHttpInfo (long? id, ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT3");
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling AlterarUsingPUT3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}} {{{convenio_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ConvenioResponse</returns>
        public ConvenioResponse CadastrarConvenioUsingPOST (ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = CadastrarConvenioUsingPOSTWithHttpInfo(convenioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}} {{{convenio_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > CadastrarConvenioUsingPOSTWithHttpInfo (ConvenioPersist convenioPersist)
        {
            
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null)
                throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling GlobaltagcadastrogeralApi->CadastrarConvenioUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }

        
        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}} {{{convenio_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ConvenioResponse</returns>
        public async System.Threading.Tasks.Task<ConvenioResponse> CadastrarConvenioUsingPOSTAsync (ConvenioPersist convenioPersist)
        {
             ApiResponse<ConvenioResponse> localVarResponse = await CadastrarConvenioUsingPOSTAsyncWithHttpInfo(convenioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{convenio_resource_cadastrar_value}}} {{{convenio_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="convenioPersist">convenioPersist</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> CadastrarConvenioUsingPOSTAsyncWithHttpInfo (ConvenioPersist convenioPersist)
        {
            // verify the required parameter 'convenioPersist' is set
            if (convenioPersist == null) throw new ApiException(400, "Missing required parameter 'convenioPersist' when calling CadastrarConvenioUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarConvenioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}} {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse CadastrarUsingPOST3 (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = CadastrarUsingPOST3WithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}} {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > CadastrarUsingPOST3WithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling GlobaltagcadastrogeralApi->CadastrarUsingPOST3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}} {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> CadastrarUsingPOST3Async (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await CadastrarUsingPOST3AsyncWithHttpInfo(configuracaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_cadastrar}}} {{{configuracao_registro_cobranca_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoPersist">configuracaoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (ConfiguracaoRegistroCobrancaPersist configuracaoPersist)
        {
            // verify the required parameter 'configuracaoPersist' is set
            if (configuracaoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoPersist' when calling CadastrarUsingPOST3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}} {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConfigurarTaxaAntecipacaoUsingPOST (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConfigurarTaxaAntecipacaoUsingPOSTWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}} {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConfigurarTaxaAntecipacaoUsingPOSTWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConfigurarTaxaAntecipacaoUsingPOST");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling GlobaltagcadastrogeralApi->ConfigurarTaxaAntecipacaoUsingPOST");
            
    
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
        /// {{{produto_resource_configurar_taxa_antecipacao}}} {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoUsingPOSTAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConfigurarTaxaAntecipacaoUsingPOSTAsyncWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{produto_resource_configurar_taxa_antecipacao}}} {{{produto_resource_configurar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_configurar_taxa_antecipacao_param_id}}}</param>
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
        /// {{{campanha_resource_consultar_campanha}}} {{{campanha_resource_consultar_campanha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse ConsultarCampanhaUsingGET (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = ConsultarCampanhaUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campanha_resource_consultar_campanha}}} {{{campanha_resource_consultar_campanha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > ConsultarCampanhaUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarCampanhaUsingGET");
            
    
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
        /// {{{campanha_resource_consultar_campanha}}} {{{campanha_resource_consultar_campanha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> ConsultarCampanhaUsingGETAsync (long? id)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await ConsultarCampanhaUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campanha_resource_consultar_campanha}}} {{{campanha_resource_consultar_campanha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{campanha_resource_consultar_campanha_param_id_campanha}}}</param>
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
        /// {{{convenio_resource_consultar_value}}} {{{convenio_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ConvenioResponse</returns>
        public ConvenioResponse ConsultarConvenioUsingGET (long? id)
        {
             ApiResponse<ConvenioResponse> localVarResponse = ConsultarConvenioUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{convenio_resource_consultar_value}}} {{{convenio_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of ConvenioResponse</returns>
        public ApiResponse< ConvenioResponse > ConsultarConvenioUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarConvenioUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenioUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenioUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }

        
        /// <summary>
        /// {{{convenio_resource_consultar_value}}} {{{convenio_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ConvenioResponse</returns>
        public async System.Threading.Tasks.Task<ConvenioResponse> ConsultarConvenioUsingGETAsync (long? id)
        {
             ApiResponse<ConvenioResponse> localVarResponse = await ConsultarConvenioUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{convenio_resource_consultar_value}}} {{{convenio_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (ConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConvenioResponse>> ConsultarConvenioUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarConvenioUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenioUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarConvenioUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConvenioResponse)));
            
        }
        
        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}} {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageProdutoPacoteTarifaResponse</returns>
        public PageProdutoPacoteTarifaResponse ConsultarProdutoPacoteTarifaUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageProdutoPacoteTarifaResponse> localVarResponse = ConsultarProdutoPacoteTarifaUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}} {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageProdutoPacoteTarifaResponse</returns>
        public ApiResponse< PageProdutoPacoteTarifaResponse > ConsultarProdutoPacoteTarifaUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarProdutoPacoteTarifaUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageProdutoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoPacoteTarifaResponse)));
            
        }

        
        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}} {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageProdutoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoPacoteTarifaResponse> ConsultarProdutoPacoteTarifaUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageProdutoPacoteTarifaResponse> localVarResponse = await ConsultarProdutoPacoteTarifaUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{produto_resource_listar_produto_pacote_tarifa}}} {{{produto_resource_listar_produto_pacote_tarifa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_listar_produto_pacote_tarifa_param_id_produto}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoPacoteTarifaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageProdutoPacoteTarifaResponse>> ConsultarProdutoPacoteTarifaUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarProdutoPacoteTarifaUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoPacoteTarifaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageProdutoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoPacoteTarifaResponse)));
            
        }
        
        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}} {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param> 
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConsultarTaxaAntecipacaoUsingGET (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConsultarTaxaAntecipacaoUsingGETWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}} {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param> 
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConsultarTaxaAntecipacaoUsingGETWithHttpInfo (long? id, string tipoTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarTaxaAntecipacaoUsingGET");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling GlobaltagcadastrogeralApi->ConsultarTaxaAntecipacaoUsingGET");
            
    
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
        /// {{{produto_resource_consultar_taxa_antecipacao}}} {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param>
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param>
        /// <returns>Task of ParametroProdutoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoUsingGETAsync (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConsultarTaxaAntecipacaoUsingGETAsyncWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{produto_resource_consultar_taxa_antecipacao}}} {{{produto_resource_consultar_taxa_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_taxa_antecipacao_param_id}}}</param>
        /// <param name="tipoTransacao">{{{produto_resource_consultar_taxa_antecipacao_param_tipo_transacao}}}</param>
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
        /// {{{configuracao_rotativo_resource_consultar}}} {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse ConsultarUsingGET10 (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}} {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET10");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}} {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_consultar}}} {{{configuracao_rotativo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_rotativo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{produto_resource_consultar}}} {{{produto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param> 
        /// <returns>ProdutoDetalhesResponse</returns>
        public ProdutoDetalhesResponse ConsultarUsingGET31 (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = ConsultarUsingGET31WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{produto_resource_consultar}}} {{{produto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of ProdutoDetalhesResponse</returns>
        public ApiResponse< ProdutoDetalhesResponse > ConsultarUsingGET31WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET31");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProdutoDetalhesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProdutoDetalhesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProdutoDetalhesResponse)));
            
        }

        
        /// <summary>
        /// {{{produto_resource_consultar}}} {{{produto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param>
        /// <returns>Task of ProdutoDetalhesResponse</returns>
        public async System.Threading.Tasks.Task<ProdutoDetalhesResponse> ConsultarUsingGET31Async (long? id)
        {
             ApiResponse<ProdutoDetalhesResponse> localVarResponse = await ConsultarUsingGET31AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{produto_resource_consultar}}} {{{produto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{produto_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ProdutoDetalhesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProdutoDetalhesResponse>> ConsultarUsingGET31AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET31");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProdutoDetalhesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProdutoDetalhesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProdutoDetalhesResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}} {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param> 
        /// <returns>TipoAjusteResponse</returns>
        public TipoAjusteResponse ConsultarUsingGET40 (long? id)
        {
             ApiResponse<TipoAjusteResponse> localVarResponse = ConsultarUsingGET40WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}} {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TipoAjusteResponse</returns>
        public ApiResponse< TipoAjusteResponse > ConsultarUsingGET40WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET40");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoAjusteResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}} {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<TipoAjusteResponse> ConsultarUsingGET40Async (long? id)
        {
             ApiResponse<TipoAjusteResponse> localVarResponse = await ConsultarUsingGET40AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_transacoes_ajuste_resource_consultar}}} {{{tipo_transacoes_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_transacoes_ajuste_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoAjusteResponse>> ConsultarUsingGET40AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET40");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoAjusteResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}} {{{tipo_boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param> 
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param> 
        /// <returns>PageTipoBoletoResponse</returns>
        public PageTipoBoletoResponse ConsultarUsingGET41 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = ConsultarUsingGET41WithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}} {{{tipo_boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param> 
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoBoletoResponse</returns>
        public ApiResponse< PageTipoBoletoResponse > ConsultarUsingGET41WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}} {{{tipo_boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param>
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param>
        /// <returns>Task of PageTipoBoletoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBoletoResponse> ConsultarUsingGET41Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
        {
             ApiResponse<PageTipoBoletoResponse> localVarResponse = await ConsultarUsingGET41AsyncWithHttpInfo(sort, page, limit, id, descricao, banco);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_boleto_resource_consultar}}} {{{tipo_boleto_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_boleto_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_boleto_request_descricao_value}}} (optional)</param>
        /// <param name="banco">{{{tipo_boleto_request_banco_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBoletoResponse>> ConsultarUsingGET41AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, long? banco = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET41: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBoletoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}} {{{tipo_endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param> 
        /// <returns>TipoEnderecoResponse</returns>
        public TipoEnderecoResponse ConsultarUsingGET43 (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = ConsultarUsingGET43WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}} {{{tipo_endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TipoEnderecoResponse</returns>
        public ApiResponse< TipoEnderecoResponse > ConsultarUsingGET43WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET43");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}} {{{tipo_endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<TipoEnderecoResponse> ConsultarUsingGET43Async (long? id)
        {
             ApiResponse<TipoEnderecoResponse> localVarResponse = await ConsultarUsingGET43AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_endereco_resource_consultar}}} {{{tipo_endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoEnderecoResponse>> ConsultarUsingGET43AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET43");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET43: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}} {{{tipo_operacao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param> 
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param> 
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param> 
        /// <returns>TipoOperacaoResponse</returns>
        public TipoOperacaoResponse ConsultarUsingGET44 (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = ConsultarUsingGET44WithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}} {{{tipo_operacao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param> 
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param> 
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param> 
        /// <returns>ApiResponse of TipoOperacaoResponse</returns>
        public ApiResponse< TipoOperacaoResponse > ConsultarUsingGET44WithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET44");
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET44");
            
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null)
                throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET44");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}} {{{tipo_operacao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param>
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param>
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param>
        /// <returns>Task of TipoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoResponse> ConsultarUsingGET44Async (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
             ApiResponse<TipoOperacaoResponse> localVarResponse = await ConsultarUsingGET44AsyncWithHttpInfo(idCartao, idEstabelecimento, codigoProcessamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_operacao_resource_consultar}}} {{{tipo_operacao_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">{{{tipo_operacao_resource_consultar_param_id_cartao}}}</param>
        /// <param name="idEstabelecimento">{{{tipo_operacao_resource_consultar_param_id_estabelecimento}}}</param>
        /// <param name="codigoProcessamento">{{{tipo_operacao_resource_consultar_param_codigo_processamento}}}</param>
        /// <returns>Task of ApiResponse (TipoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoResponse>> ConsultarUsingGET44AsyncWithHttpInfo (long? idCartao, long? idEstabelecimento, string codigoProcessamento)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarUsingGET44");
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null) throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling ConsultarUsingGET44");
            // verify the required parameter 'codigoProcessamento' is set
            if (codigoProcessamento == null) throw new ApiException(400, "Missing required parameter 'codigoProcessamento' when calling ConsultarUsingGET44");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}} {{{tipo_telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param> 
        /// <returns>TipoTelefoneResponse</returns>
        public TipoTelefoneResponse ConsultarUsingGET46 (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = ConsultarUsingGET46WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}} {{{tipo_telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TipoTelefoneResponse</returns>
        public ApiResponse< TipoTelefoneResponse > ConsultarUsingGET46WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET46");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}} {{{tipo_telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TipoTelefoneResponse> ConsultarUsingGET46Async (long? id)
        {
             ApiResponse<TipoTelefoneResponse> localVarResponse = await ConsultarUsingGET46AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_telefone_resource_consultar}}} {{{tipo_telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTelefoneResponse>> ConsultarUsingGET46AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET46");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}} {{{atendimento_cliente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse ConsultarUsingGET5 (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = ConsultarUsingGET5WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}} {{{atendimento_cliente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param> 
        /// <returns>ApiResponse of AtendimentoClienteResponse</returns>
        public ApiResponse< AtendimentoClienteResponse > ConsultarUsingGET5WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }

        
        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}} {{{atendimento_cliente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> ConsultarUsingGET5Async (long? id)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await ConsultarUsingGET5AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{atendimento_cliente_resource_consultar}}} {{{atendimento_cliente_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{atendimento_cliente_resource_consultar_param_id_atendimento}}}</param>
        /// <returns>Task of ApiResponse (AtendimentoClienteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AtendimentoClienteResponse>> ConsultarUsingGET5AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AtendimentoClienteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AtendimentoClienteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AtendimentoClienteResponse)));
            
        }
        
        /// <summary>
        /// {{{banco_resource_consultar}}} {{{banco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param> 
        /// <returns>BancoResponse</returns>
        public BancoResponse ConsultarUsingGET7 (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = ConsultarUsingGET7WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{banco_resource_consultar}}} {{{banco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of BancoResponse</returns>
        public ApiResponse< BancoResponse > ConsultarUsingGET7WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET7");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }

        
        /// <summary>
        /// {{{banco_resource_consultar}}} {{{banco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param>
        /// <returns>Task of BancoResponse</returns>
        public async System.Threading.Tasks.Task<BancoResponse> ConsultarUsingGET7Async (long? id)
        {
             ApiResponse<BancoResponse> localVarResponse = await ConsultarUsingGET7AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{banco_resource_consultar}}} {{{banco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{banco_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (BancoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BancoResponse>> ConsultarUsingGET7AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET7");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BancoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BancoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BancoResponse)));
            
        }
        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}} {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse ConsultarUsingGET9 (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = ConsultarUsingGET9WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}} {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > ConsultarUsingGET9WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastrogeralApi->ConsultarUsingGET9");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}} {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ConsultarUsingGET9Async (long? id)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await ConsultarUsingGET9AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_consultar}}} {{{configuracao_registro_cobranca_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{configuracao_registro_cobranca_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ConsultarUsingGET9AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET9");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}} {{{campanha_resource_listar_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param> 
        /// <returns>PageCampanhaResponse</returns>
        public PageCampanhaResponse ListarCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = ListarCampanhasUsingGETWithHttpInfo(sort, page, limit, idTipoCampanha);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}} {{{campanha_resource_listar_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param> 
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
        /// {{{campanha_resource_listar_campanhas}}} {{{campanha_resource_listar_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param>
        /// <returns>Task of PageCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageCampanhaResponse> ListarCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoCampanha = null)
        {
             ApiResponse<PageCampanhaResponse> localVarResponse = await ListarCampanhasUsingGETAsyncWithHttpInfo(sort, page, limit, idTipoCampanha);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campanha_resource_listar_campanhas}}} {{{campanha_resource_listar_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoCampanha">{{{campanha_request_id_tipo_campanha_value}}} (optional)</param>
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
        /// {{{convenio_resource_listar_value}}} {{{convenio_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param> 
        /// <returns>PageConvenioResponse</returns>
        public PageConvenioResponse ListarConveniosUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
             ApiResponse<PageConvenioResponse> localVarResponse = ListarConveniosUsingGETWithHttpInfo(sort, page, limit, banco, agencia, contaCorrente, numeroConvenio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{convenio_resource_listar_value}}} {{{convenio_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param> 
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param> 
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param> 
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageConvenioResponse</returns>
        public ApiResponse< PageConvenioResponse > ListarConveniosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarConveniosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConveniosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConvenioResponse)));
            
        }

        
        /// <summary>
        /// {{{convenio_resource_listar_value}}} {{{convenio_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param>
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param>
        /// <returns>Task of PageConvenioResponse</returns>
        public async System.Threading.Tasks.Task<PageConvenioResponse> ListarConveniosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
        {
             ApiResponse<PageConvenioResponse> localVarResponse = await ListarConveniosUsingGETAsyncWithHttpInfo(sort, page, limit, banco, agencia, contaCorrente, numeroConvenio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{convenio_resource_listar_value}}} {{{convenio_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="banco">{{{convenio_request_banco_value}}} (optional)</param>
        /// <param name="agencia">{{{convenio_request_agencia_value}}} (optional)</param>
        /// <param name="contaCorrente">{{{convenio_request_conta_corrente_value}}} (optional)</param>
        /// <param name="numeroConvenio">{{{convenio_request_numero_convenio_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageConvenioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConvenioResponse>> ListarConveniosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? banco = null, long? agencia = null, string contaCorrente = null, double? numeroConvenio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarConveniosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarConveniosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConvenioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConvenioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConvenioResponse)));
            
        }
        
        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}} {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarEstadosCivisUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarEstadosCivisUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}} {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{campo_codificado_resource_listar_estados_civis}}} {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarEstadosCivisUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarEstadosCivisUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_estados_civis}}} {{{campo_codificado_resource_listar_estados_civis_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}} {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageFantasiaBasicaResponse</returns>
        public PageFantasiaBasicaResponse ListarFantasiasBasicasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = ListarFantasiasBasicasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}} {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}} {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageFantasiaBasicaResponse</returns>
        public async System.Threading.Tasks.Task<PageFantasiaBasicaResponse> ListarFantasiasBasicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFantasiaBasicaResponse> localVarResponse = await ListarFantasiasBasicasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{fantasia_basica_resource_listar_fantasias_basicas}}} {{{fantasia_basica_resource_listar_fantasias_basicas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{campo_codificado_resource_listar_nacionalidades}}} {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNacionalidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNacionalidadesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_nacionalidades}}} {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{campo_codificado_resource_listar_nacionalidades}}} {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNacionalidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNacionalidadesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_nacionalidades}}} {{{campo_codificado_resource_listar_nacionalidades_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}} {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarNaturezasOcupacoesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarNaturezasOcupacoesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}} {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}} {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarNaturezasOcupacoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarNaturezasOcupacoesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_naturezas_ocupacoes}}} {{{campo_codificado_resource_listar_naturezas_ocupacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{campo_codificado_resource_listar_parentescos}}} {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarParentescosUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarParentescosUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_parentescos}}} {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{campo_codificado_resource_listar_parentescos}}} {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarParentescosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarParentescosUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_parentescos}}} {{{campo_codificado_resource_listar_parentescos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{campo_codificado_resource_listar_profissoes}}} {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarProfissoesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarProfissoesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_profissoes}}} {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{campo_codificado_resource_listar_profissoes}}} {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarProfissoesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarProfissoesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campo_codificado_resource_listar_profissoes}}} {{{campo_codificado_resource_listar_profissoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}} {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTipoCampanhaResponse</returns>
        public PageTipoCampanhaResponse ListarTiposCampanhasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = ListarTiposCampanhasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}} {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}} {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoCampanhaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoCampanhaResponse> ListarTiposCampanhasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoCampanhaResponse> localVarResponse = await ListarTiposCampanhasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_campanha_resource_listar_tipos_campanhas}}} {{{tipo_campanha_resource_listar_tipos_campanhas_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{configuracao_registro_cobranca_resource_listar}}} {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ConfiguracaoRegistroCobrancaResponse</returns>
        public ConfiguracaoRegistroCobrancaResponse ListarUsingGET11 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = ListarUsingGET11WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}} {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of ConfiguracaoRegistroCobrancaResponse</returns>
        public ApiResponse< ConfiguracaoRegistroCobrancaResponse > ListarUsingGET11WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}} {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ConfiguracaoRegistroCobrancaResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRegistroCobrancaResponse> ListarUsingGET11Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<ConfiguracaoRegistroCobrancaResponse> localVarResponse = await ListarUsingGET11AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_registro_cobranca_resource_listar}}} {{{configuracao_registro_cobranca_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRegistroCobrancaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRegistroCobrancaResponse>> ListarUsingGET11AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRegistroCobrancaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRegistroCobrancaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRegistroCobrancaResponse)));
            
        }
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}} {{{configuracao_rotativo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param> 
        /// <returns>PageConfiguracaoRotativoResponse</returns>
        public PageConfiguracaoRotativoResponse ListarUsingGET12 (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = ListarUsingGET12WithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}} {{{configuracao_rotativo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageConfiguracaoRotativoResponse</returns>
        public ApiResponse< PageConfiguracaoRotativoResponse > ListarUsingGET12WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageConfiguracaoRotativoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoRotativoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoRotativoResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}} {{{configuracao_rotativo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of PageConfiguracaoRotativoResponse</returns>
        public async System.Threading.Tasks.Task<PageConfiguracaoRotativoResponse> ListarUsingGET12Async (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
        {
             ApiResponse<PageConfiguracaoRotativoResponse> localVarResponse = await ListarUsingGET12AsyncWithHttpInfo(sort, page, limit, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_listar}}} {{{configuracao_rotativo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idProduto">{{{configuracao_rotativo_request_id_produto_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageConfiguracaoRotativoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageConfiguracaoRotativoResponse>> ListarUsingGET12AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageConfiguracaoRotativoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageConfiguracaoRotativoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageConfiguracaoRotativoResponse)));
            
        }
        
        /// <summary>
        /// {{{portador_resource_listar}}} {{{portador_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param> 
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param> 
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param> 
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param> 
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param> 
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param> 
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param> 
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param> 
        /// <returns>PagePortadorResponse</returns>
        public PagePortadorResponse ListarUsingGET36 (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = ListarUsingGET36WithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{portador_resource_listar}}} {{{portador_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param> 
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param> 
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param> 
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param> 
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param> 
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param> 
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param> 
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePortadorResponse</returns>
        public ApiResponse< PagePortadorResponse > ListarUsingGET36WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorResponse)));
            
        }

        
        /// <summary>
        /// {{{portador_resource_listar}}} {{{portador_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param>
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param>
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param>
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param>
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param>
        /// <returns>Task of PagePortadorResponse</returns>
        public async System.Threading.Tasks.Task<PagePortadorResponse> ListarUsingGET36Async (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortadorResponse> localVarResponse = await ListarUsingGET36AsyncWithHttpInfo(sort, page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{portador_resource_listar}}} {{{portador_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idConta">{{{portador_request_id_conta_value}}} (optional)</param>
        /// <param name="idProduto">{{{portador_request_id_produto_value}}} (optional)</param>
        /// <param name="idPessoa">{{{portador_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idParentesco">{{{portador_request_id_parentesco_value}}} (optional)</param>
        /// <param name="tipoPortador">{{{portador_request_tipo_portador_value}}} (optional)</param>
        /// <param name="nomeImpresso">{{{portador_request_nome_impresso_value}}} (optional)</param>
        /// <param name="idTipoCartao">{{{portador_request_id_tipo_cartao_value}}} (optional)</param>
        /// <param name="flagAtivo">{{{portador_request_flag_ativo_value}}} (optional)</param>
        /// <param name="dataCadastroPortador">{{{portador_request_data_cadastro_portador_value}}} (optional)</param>
        /// <param name="dataCancelamentoPortador">{{{portador_request_data_cancelamento_portador_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePortadorResponse>> ListarUsingGET36AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idTipoCartao = null, int? flagAtivo = null, string dataCadastroPortador = null, string dataCancelamentoPortador = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortadorResponse)));
            
        }
        
        /// <summary>
        /// {{{produto_resource_listar}}} {{{produto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param> 
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param> 
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param> 
        /// <returns>PageProdutoResponse</returns>
        public PageProdutoResponse ListarUsingGET37 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = ListarUsingGET37WithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{produto_resource_listar}}} {{{produto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param> 
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param> 
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageProdutoResponse</returns>
        public ApiResponse< PageProdutoResponse > ListarUsingGET37WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoResponse)));
            
        }

        
        /// <summary>
        /// {{{produto_resource_listar}}} {{{produto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param>
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param>
        /// <returns>Task of PageProdutoResponse</returns>
        public async System.Threading.Tasks.Task<PageProdutoResponse> ListarUsingGET37Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
        {
             ApiResponse<PageProdutoResponse> localVarResponse = await ListarUsingGET37AsyncWithHttpInfo(sort, page, limit, nome, status, idFantasiaBasica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{produto_resource_listar}}} {{{produto_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{produto_request_nome_value}}} (optional)</param>
        /// <param name="status">{{{produto_request_status_value}}} (optional)</param>
        /// <param name="idFantasiaBasica">{{{produto_request_id_fantasia_basica_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageProdutoResponse>> ListarUsingGET37AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, int? status = null, long? idFantasiaBasica = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageProdutoResponse)));
            
        }
        
        /// <summary>
        /// {{{promotor_resource_listar}}} {{{promotor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param> 
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param> 
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param> 
        /// <returns>PagePromotorResponse</returns>
        public PagePromotorResponse ListarUsingGET38 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = ListarUsingGET38WithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{promotor_resource_listar}}} {{{promotor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param> 
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param> 
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param> 
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePromotorResponse</returns>
        public ApiResponse< PagePromotorResponse > ListarUsingGET38WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePromotorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePromotorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePromotorResponse)));
            
        }

        
        /// <summary>
        /// {{{promotor_resource_listar}}} {{{promotor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param>
        /// <returns>Task of PagePromotorResponse</returns>
        public async System.Threading.Tasks.Task<PagePromotorResponse> ListarUsingGET38Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
        {
             ApiResponse<PagePromotorResponse> localVarResponse = await ListarUsingGET38AsyncWithHttpInfo(sort, page, limit, id, nome, dataCadastro, idEstabelecimento, idUsuario);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{promotor_resource_listar}}} {{{promotor_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{promotor_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{promotor_request_nome_value}}} (optional)</param>
        /// <param name="dataCadastro">{{{promotor_request_data_cadastro_value}}} (optional)</param>
        /// <param name="idEstabelecimento">{{{promotor_request_id_estabelecimento_value}}} (optional)</param>
        /// <param name="idUsuario">{{{promotor_request_id_usuario_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePromotorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePromotorResponse>> ListarUsingGET38AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string dataCadastro = null, long? idEstabelecimento = null, long? idUsuario = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET38: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePromotorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePromotorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePromotorResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}} {{{tipo_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param> 
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param> 
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param> 
        /// <returns>PageTipoAjusteResponse</returns>
        public PageTipoAjusteResponse ListarUsingGET49 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = ListarUsingGET49WithHttpInfo(sort, page, limit, id, descricao, flagPagamentoLojista, flagSistema);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}} {{{tipo_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param> 
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param> 
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoAjusteResponse</returns>
        public ApiResponse< PageTipoAjusteResponse > ListarUsingGET49WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET49: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET49: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoAjusteResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}} {{{tipo_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param>
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param>
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param>
        /// <returns>Task of PageTipoAjusteResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoAjusteResponse> ListarUsingGET49Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
        {
             ApiResponse<PageTipoAjusteResponse> localVarResponse = await ListarUsingGET49AsyncWithHttpInfo(sort, page, limit, id, descricao, flagPagamentoLojista, flagSistema);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_ajuste_resource_consultar}}} {{{tipo_ajuste_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_ajuste_request_id_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_ajuste_request_descricao_value}}} (optional)</param>
        /// <param name="flagPagamentoLojista">{{{tipo_ajuste_request_flag_pagamento_lojista_value}}} (optional)</param>
        /// <param name="flagSistema">{{{tipo_ajuste_request_flag_sistema_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoAjusteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoAjusteResponse>> ListarUsingGET49AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, bool? flagPagamentoLojista = null, int? flagSistema = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET49: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET49: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoAjusteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoAjusteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoAjusteResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_endereco_resource_listar}}} {{{tipo_endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param> 
        /// <returns>PageTipoEnderecoResponse</returns>
        public PageTipoEnderecoResponse ListarUsingGET52 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = ListarUsingGET52WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_endereco_resource_listar}}} {{{tipo_endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoEnderecoResponse</returns>
        public ApiResponse< PageTipoEnderecoResponse > ListarUsingGET52WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_endereco_resource_listar}}} {{{tipo_endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageTipoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoEnderecoResponse> ListarUsingGET52Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoEnderecoResponse> localVarResponse = await ListarUsingGET52AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_endereco_resource_listar}}} {{{tipo_endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_endereco_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_endereco_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoEnderecoResponse>> ListarUsingGET52AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET52: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_telefone_resource_listar}}} {{{tipo_telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param> 
        /// <returns>PageTipoTelefoneResponse</returns>
        public PageTipoTelefoneResponse ListarUsingGET54 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = ListarUsingGET54WithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_telefone_resource_listar}}} {{{tipo_telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoTelefoneResponse</returns>
        public ApiResponse< PageTipoTelefoneResponse > ListarUsingGET54WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET54: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET54: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_telefone_resource_listar}}} {{{tipo_telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param>
        /// <returns>Task of PageTipoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTelefoneResponse> ListarUsingGET54Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefoneResponse> localVarResponse = await ListarUsingGET54AsyncWithHttpInfo(sort, page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_telefone_resource_listar}}} {{{tipo_telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{tipo_telefone_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{tipo_telefone_request_nome_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTelefoneResponse>> ListarUsingGET54AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET54: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET54: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}} {{{atendimento_cliente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param> 
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param> 
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param> 
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param> 
        /// <returns>PageAtendimentoClienteResponse</returns>
        public PageAtendimentoClienteResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = ListarUsingGET6WithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}} {{{atendimento_cliente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param> 
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param> 
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param> 
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param> 
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
        /// {{{atendimento_cliente_resource_listar}}} {{{atendimento_cliente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param>
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param>
        /// <returns>Task of PageAtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<PageAtendimentoClienteResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoAtendimento = null, long? idConta = null, string nomeAtendente = null, string dataAtendimento = null)
        {
             ApiResponse<PageAtendimentoClienteResponse> localVarResponse = await ListarUsingGET6AsyncWithHttpInfo(sort, page, limit, idTipoAtendimento, idConta, nomeAtendente, dataAtendimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{atendimento_cliente_resource_listar}}} {{{atendimento_cliente_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoAtendimento">{{{atendimento_cliente_request_id_tipo_atendimento_value}}} (optional)</param>
        /// <param name="idConta">{{{atendimento_cliente_request_id_conta_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_request_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_request_data_atendimento_value}}} (optional)</param>
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
        /// {{{vencimento_resource_listar}}} {{{vencimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param> 
        /// <returns>PageControleVencimentoResponse</returns>
        public PageControleVencimentoResponse ListarUsingGET60 (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = ListarUsingGET60WithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{vencimento_resource_listar}}} {{{vencimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param> 
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageControleVencimentoResponse</returns>
        public ApiResponse< PageControleVencimentoResponse > ListarUsingGET60WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleVencimentoResponse)));
            
        }

        
        /// <summary>
        /// {{{vencimento_resource_listar}}} {{{vencimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of PageControleVencimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleVencimentoResponse> ListarUsingGET60Async (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
        {
             ApiResponse<PageControleVencimentoResponse> localVarResponse = await ListarUsingGET60AsyncWithHttpInfo(sort, page, limit, dataVencimento, dataVencimentoFim);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{vencimento_resource_listar}}} {{{vencimento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="dataVencimento">{{{controle_vencimento_request_data_vencimento_value}}} (optional)</param>
        /// <param name="dataVencimentoFim">{{{calendario_fatura_request_data_fim_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageControleVencimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleVencimentoResponse>> ListarUsingGET60AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataVencimento = null, string dataVencimentoFim = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleVencimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleVencimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleVencimentoResponse)));
            
        }
        
        /// <summary>
        /// {{{banco_resource_listar}}} {{{banco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageBancoResponse</returns>
        public PageBancoResponse ListarUsingGET8 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = ListarUsingGET8WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{banco_resource_listar}}} {{{banco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
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
        /// {{{banco_resource_listar}}} {{{banco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageBancoResponse</returns>
        public async System.Threading.Tasks.Task<PageBancoResponse> ListarUsingGET8Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageBancoResponse> localVarResponse = await ListarUsingGET8AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{banco_resource_listar}}} {{{banco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
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
        /// {{{atendimento_cliente_resource_salvar}}} {{{atendimento_cliente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param> 
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param> 
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param> 
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param> 
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param> 
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param> 
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param> 
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param> 
        /// <returns>AtendimentoClienteResponse</returns>
        public AtendimentoClienteResponse SalvarUsingPOST2 (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = SalvarUsingPOST2WithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{atendimento_cliente_resource_salvar}}} {{{atendimento_cliente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param> 
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param> 
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param> 
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param> 
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param> 
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param> 
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param> 
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param> 
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param> 
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
        /// {{{atendimento_cliente_resource_salvar}}} {{{atendimento_cliente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param>
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param>
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param>
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param>
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param>
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param>
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param>
        /// <returns>Task of AtendimentoClienteResponse</returns>
        public async System.Threading.Tasks.Task<AtendimentoClienteResponse> SalvarUsingPOST2Async (long? idConta = null, string conteudoAtendimento = null, string detalhesAtendimento = null, string nomeAtendente = null, string dataAtendimento = null, string dataAgendamento = null, string dataHoraInicioAtendimento = null, string dataHoraFimAtendimento = null, int? flagFilaFraude = null)
        {
             ApiResponse<AtendimentoClienteResponse> localVarResponse = await SalvarUsingPOST2AsyncWithHttpInfo(idConta, conteudoAtendimento, detalhesAtendimento, nomeAtendente, dataAtendimento, dataAgendamento, dataHoraInicioAtendimento, dataHoraFimAtendimento, flagFilaFraude);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{atendimento_cliente_resource_salvar}}} {{{atendimento_cliente_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{atendimento_cliente_persist_id_conta_value}}} (optional)</param>
        /// <param name="conteudoAtendimento">{{{atendimento_cliente_persist_conteudo_atendimento_value}}} (optional)</param>
        /// <param name="detalhesAtendimento">{{{atendimento_cliente_persist_detalhes_atendimento_value}}} (optional)</param>
        /// <param name="nomeAtendente">{{{atendimento_cliente_persist_nome_atendente_value}}} (optional)</param>
        /// <param name="dataAtendimento">{{{atendimento_cliente_persist_data_atendimento_value}}} (optional)</param>
        /// <param name="dataAgendamento">{{{atendimento_cliente_persist_data_agendamento_value}}} (optional)</param>
        /// <param name="dataHoraInicioAtendimento">{{{atendimento_cliente_persist_data_hora_inicio_atendimento_value}}} (optional)</param>
        /// <param name="dataHoraFimAtendimento">{{{atendimento_cliente_persist_data_hora_fim_atendimento_value}}} (optional)</param>
        /// <param name="flagFilaFraude">{{{atendimento_cliente_persist_flag_fila_fraude_value}}} (optional)</param>
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
        /// {{{campanha_resource_salvar}}} {{{campanha_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>CampanhaResponse</returns>
        public CampanhaResponse SalvarUsingPOST4 (CampanhaPersist campanhaPersist)
        {
             ApiResponse<CampanhaResponse> localVarResponse = SalvarUsingPOST4WithHttpInfo(campanhaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{campanha_resource_salvar}}} {{{campanha_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param> 
        /// <returns>ApiResponse of CampanhaResponse</returns>
        public ApiResponse< CampanhaResponse > SalvarUsingPOST4WithHttpInfo (CampanhaPersist campanhaPersist)
        {
            
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null)
                throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling GlobaltagcadastrogeralApi->SalvarUsingPOST4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }

        
        /// <summary>
        /// {{{campanha_resource_salvar}}} {{{campanha_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of CampanhaResponse</returns>
        public async System.Threading.Tasks.Task<CampanhaResponse> SalvarUsingPOST4Async (CampanhaPersist campanhaPersist)
        {
             ApiResponse<CampanhaResponse> localVarResponse = await SalvarUsingPOST4AsyncWithHttpInfo(campanhaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{campanha_resource_salvar}}} {{{campanha_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campanhaPersist">campanhaPersist</param>
        /// <returns>Task of ApiResponse (CampanhaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampanhaResponse>> SalvarUsingPOST4AsyncWithHttpInfo (CampanhaPersist campanhaPersist)
        {
            // verify the required parameter 'campanhaPersist' is set
            if (campanhaPersist == null) throw new ApiException(400, "Missing required parameter 'campanhaPersist' when calling SalvarUsingPOST4");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampanhaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampanhaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampanhaResponse)));
            
        }
        
        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}} {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ConfiguracaoRotativoDetalheResponse</returns>
        public ConfiguracaoRotativoDetalheResponse SalvarUsingPOST5 (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = SalvarUsingPOST5WithHttpInfo(configuracaoRotativoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}} {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param> 
        /// <returns>ApiResponse of ConfiguracaoRotativoDetalheResponse</returns>
        public ApiResponse< ConfiguracaoRotativoDetalheResponse > SalvarUsingPOST5WithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null)
                throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling GlobaltagcadastrogeralApi->SalvarUsingPOST5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}} {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ConfiguracaoRotativoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ConfiguracaoRotativoDetalheResponse> SalvarUsingPOST5Async (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
             ApiResponse<ConfiguracaoRotativoDetalheResponse> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(configuracaoRotativoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{configuracao_rotativo_resource_salvar}}} {{{configuracao_rotativo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configuracaoRotativoPersist">configuracaoRotativoPersist</param>
        /// <returns>Task of ApiResponse (ConfiguracaoRotativoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfiguracaoRotativoDetalheResponse>> SalvarUsingPOST5AsyncWithHttpInfo (ConfiguracaoRotativoPersist configuracaoRotativoPersist)
        {
            // verify the required parameter 'configuracaoRotativoPersist' is set
            if (configuracaoRotativoPersist == null) throw new ApiException(400, "Missing required parameter 'configuracaoRotativoPersist' when calling SalvarUsingPOST5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConfiguracaoRotativoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfiguracaoRotativoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfiguracaoRotativoDetalheResponse)));
            
        }
        
    }
    
}
