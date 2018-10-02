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
    public interface IGlobaltagantecipacaoApi
    {
        #region Synchronous Operations
        
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
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param>
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacaoUsingPOST (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
  
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param>
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacaoUsingPOSTWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacoesUsingPOST (long? idConta, string complemento = null);
  
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacoesUsingPOSTWithHttpInfo (long? idConta, string complemento = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param>
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param>
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param>
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param>
        /// <returns>PageCompraResponse</returns>
        PageCompraResponse ListarUsingGET12 (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
  
        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param>
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param>
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param>
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageCompraResponse</returns>
        ApiResponse<PageCompraResponse> ListarUsingGET12WithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>AntecipacaoSimuladaResponse</returns>
        AntecipacaoSimuladaResponse SimularAntecipacaoUsingGET (long? idConta, long? id, string complemento = null);
  
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        ApiResponse<AntecipacaoSimuladaResponse> SimularAntecipacaoUsingGETWithHttpInfo (long? idConta, long? id, string complemento = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>AntecipacaoSimuladaLoteResponse</returns>
        AntecipacaoSimuladaLoteResponse SimularAntecipacoesUsingGET (long? idConta, string complemento = null);
  
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaLoteResponse</returns>
        ApiResponse<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesUsingGETWithHttpInfo (long? idConta, string complemento = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param>
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoUsingPOSTAsync (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);

        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param>
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoUsingPOSTAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacoesUsingPOSTAsync (long? idConta, string complemento = null);

        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacoesUsingPOSTAsyncWithHttpInfo (long? idConta, string complemento = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param>
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param>
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param>
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        System.Threading.Tasks.Task<PageCompraResponse> ListarUsingGET12Async (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);

        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param>
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param>
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param>
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarUsingGET12AsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoUsingGETAsync (long? idConta, long? id, string complemento = null);

        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoUsingGETAsyncWithHttpInfo (long? idConta, long? id, string complemento = null);
        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaLoteResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesUsingGETAsync (long? idConta, string complemento = null);

        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaLoteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaLoteResponse>> SimularAntecipacoesUsingGETAsyncWithHttpInfo (long? idConta, string complemento = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagantecipacaoApi : IGlobaltagantecipacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagantecipacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagantecipacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagantecipacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagantecipacaoApi(Configuration configuration = null)
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagantecipacaoApi->ConfigurarTaxaAntecipacaoUsingPOST");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling GlobaltagantecipacaoApi->ConfigurarTaxaAntecipacaoUsingPOST");
            
    
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
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagantecipacaoApi->ConsultarTaxaAntecipacaoUsingGET");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling GlobaltagantecipacaoApi->ConsultarTaxaAntecipacaoUsingGET");
            
    
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
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}} {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param> 
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param> 
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacaoUsingPOST (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacaoUsingPOSTWithHttpInfo(idConta, id, quantidadeParcelas, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}} {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param> 
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param> 
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacaoUsingPOSTWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagantecipacaoApi->EfetivarAntecipacaoUsingPOST");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagantecipacaoApi->EfetivarAntecipacaoUsingPOST");
            
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null)
                throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling GlobaltagantecipacaoApi->EfetivarAntecipacaoUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}} {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param>
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoUsingPOSTAsync (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacaoUsingPOSTAsyncWithHttpInfo(idConta, id, quantidadeParcelas, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacao}}} {{{compra_antecipavel_resource_efetivar_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_efetivar_antecipacao_param_id_compra}}}</param>
        /// <param name="quantidadeParcelas">{{{compra_antecipavel_resource_efetivar_antecipacao_param_quantidade_parcelas}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoUsingPOSTAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacaoUsingPOST");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EfetivarAntecipacaoUsingPOST");
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null) throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling EfetivarAntecipacaoUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}} {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacoesUsingPOST (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacoesUsingPOSTWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}} {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacoesUsingPOSTWithHttpInfo (long? idConta, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagantecipacaoApi->EfetivarAntecipacoesUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}} {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacoesUsingPOSTAsync (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacoesUsingPOSTAsyncWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_antecipavel_resource_efetivar_antecipacoes}}} {{{compra_antecipavel_resource_efetivar_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_efetivar_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacoesUsingPOSTAsyncWithHttpInfo (long? idConta, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacoesUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}} {{{compra_antecipavel_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param> 
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param> 
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param> 
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param> 
        /// <returns>PageCompraResponse</returns>
        public PageCompraResponse ListarUsingGET12 (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = ListarUsingGET12WithHttpInfo(idConta, sort, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}} {{{compra_antecipavel_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param> 
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param> 
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param> 
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageCompraResponse</returns>
        public ApiResponse< PageCompraResponse > ListarUsingGET12WithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagantecipacaoApi->ListarUsingGET12");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}} {{{compra_antecipavel_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param>
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param>
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param>
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        public async System.Threading.Tasks.Task<PageCompraResponse> ListarUsingGET12Async (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = await ListarUsingGET12AsyncWithHttpInfo(idConta, sort, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_antecipavel_resource_listar}}} {{{compra_antecipavel_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_d_t_o_id_conta_value}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idCompra">{{{compra_d_t_o_id_compra_value}}} (optional)</param>
        /// <param name="parcelada">{{{compra_d_t_o_parcelada_value}}} (optional)</param>
        /// <param name="juros">{{{compra_d_t_o_juros_value}}} (optional)</param>
        /// <param name="tipoOrigemTransacao">{{{compra_d_t_o_tipo_origem_transacao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarUsingGET12AsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarUsingGET12");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }
        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}} {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param> 
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param> 
        /// <returns>AntecipacaoSimuladaResponse</returns>
        public AntecipacaoSimuladaResponse SimularAntecipacaoUsingGET (long? idConta, long? id, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = SimularAntecipacaoUsingGETWithHttpInfo(idConta, id, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}} {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param> 
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        public ApiResponse< AntecipacaoSimuladaResponse > SimularAntecipacaoUsingGETWithHttpInfo (long? idConta, long? id, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagantecipacaoApi->SimularAntecipacaoUsingGET");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagantecipacaoApi->SimularAntecipacaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}} {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoUsingGETAsync (long? idConta, long? id, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = await SimularAntecipacaoUsingGETAsyncWithHttpInfo(idConta, id, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacao}}} {{{compra_antecipavel_resource_simular_antecipacao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacao_param_id_conta}}}</param>
        /// <param name="id">{{{compra_antecipavel_resource_simular_antecipacao_param_id_evento}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacao_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoUsingGETAsyncWithHttpInfo (long? idConta, long? id, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacaoUsingGET");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularAntecipacaoUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }
        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}} {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param> 
        /// <returns>AntecipacaoSimuladaLoteResponse</returns>
        public AntecipacaoSimuladaLoteResponse SimularAntecipacoesUsingGET (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaLoteResponse> localVarResponse = SimularAntecipacoesUsingGETWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}} {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param> 
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaLoteResponse</returns>
        public ApiResponse< AntecipacaoSimuladaLoteResponse > SimularAntecipacoesUsingGETWithHttpInfo (long? idConta, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagantecipacaoApi->SimularAntecipacoesUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaLoteResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}} {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaLoteResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesUsingGETAsync (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaLoteResponse> localVarResponse = await SimularAntecipacoesUsingGETAsyncWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_antecipavel_resource_simular_antecipacoes}}} {{{compra_antecipavel_resource_simular_antecipacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">{{{compra_antecipavel_resource_simular_antecipacoes_param_id_conta}}}</param>
        /// <param name="complemento">{{{compra_antecipavel_resource_simular_antecipacoes_param_complemento}}} (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaLoteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaLoteResponse>> SimularAntecipacoesUsingGETAsyncWithHttpInfo (long? idConta, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacoesUsingGET");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaLoteResponse)));
            
        }
        
    }
    
}
