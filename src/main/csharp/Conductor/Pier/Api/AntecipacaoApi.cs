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
    public interface IAntecipacaoApi
    {
        #region Synchronous Operations
        
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
        ParametroProdutoResponse ConfigurarTaxaAntecipacaoProduto (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
  
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
        ApiResponse<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoProdutoWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
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
        ParametroProdutoResponse ConsultarTaxaAntecipacaoProduto (long? id, string tipoTransacao);
  
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
        ApiResponse<ParametroProdutoResponse> ConsultarTaxaAntecipacaoProdutoWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacaoCompra (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
  
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacaoCompraWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacoesEmLotes (long? idConta, string complemento = null);
  
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacoesEmLotesWithHttpInfo (long? idConta, string complemento = null);
        
        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// Lista as compras antecip\u00E1veis de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param>
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param>
        /// <returns>PageCompraResponse</returns>
        PageCompraResponse ListarComprasAntecipaveis (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
  
        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// Lista as compras antecip\u00E1veis de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param>
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param>
        /// <returns>ApiResponse of PageCompraResponse</returns>
        ApiResponse<PageCompraResponse> ListarComprasAntecipaveisWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>AntecipacaoSimuladaResponse</returns>
        AntecipacaoSimuladaResponse SimularAntecipacaoCompra (long? idConta, long? id, string complemento = null);
  
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        ApiResponse<AntecipacaoSimuladaResponse> SimularAntecipacaoCompraWithHttpInfo (long? idConta, long? id, string complemento = null);
        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>AntecipacaoSimuladaLoteResponse</returns>
        AntecipacaoSimuladaLoteResponse SimularAntecipacoesEmLote (long? idConta, string complemento = null);
  
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaLoteResponse</returns>
        ApiResponse<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesEmLoteWithHttpInfo (long? idConta, string complemento = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
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
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoProdutoAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);

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
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoProdutoAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest);
        
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
        System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoProdutoAsync (long? id, string tipoTransacao);

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
        System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoProdutoAsyncWithHttpInfo (long? id, string tipoTransacao);
        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoCompraAsync (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);

        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoCompraAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null);
        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacoesEmLotesAsync (long? idConta, string complemento = null);

        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacoesEmLotesAsyncWithHttpInfo (long? idConta, string complemento = null);
        
        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// Lista as compras antecip\u00E1veis de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param>
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        System.Threading.Tasks.Task<PageCompraResponse> ListarComprasAntecipaveisAsync (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);

        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// Lista as compras antecip\u00E1veis de uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param>
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarComprasAntecipaveisAsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoCompraAsync (long? idConta, long? id, string complemento = null);

        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoCompraAsyncWithHttpInfo (long? idConta, long? id, string complemento = null);
        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaLoteResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesEmLoteAsync (long? idConta, string complemento = null);

        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis
        /// </summary>
        /// <remarks>
        /// O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaLoteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaLoteResponse>> SimularAntecipacoesEmLoteAsyncWithHttpInfo (long? idConta, string complemento = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AntecipacaoApi : IAntecipacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AntecipacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AntecipacaoApi(Configuration configuration = null)
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
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConfigurarTaxaAntecipacaoProduto (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConfigurarTaxaAntecipacaoProdutoWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConfigurarTaxaAntecipacaoProdutoWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipacaoApi->ConfigurarTaxaAntecipacaoProduto");
            
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling AntecipacaoApi->ConfigurarTaxaAntecipacaoProduto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConfigurarTaxaAntecipacaoProdutoAsync (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConfigurarTaxaAntecipacaoProdutoAsyncWithHttpInfo(id, taxaAntecipacaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Configura a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite configurar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="taxaAntecipacaoRequest">taxaAntecipacaoRequest</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConfigurarTaxaAntecipacaoProdutoAsyncWithHttpInfo (long? id, TaxaAntecipacaoRequest taxaAntecipacaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConfigurarTaxaAntecipacaoProduto");
            // verify the required parameter 'taxaAntecipacaoRequest' is set
            if (taxaAntecipacaoRequest == null) throw new ApiException(400, "Missing required parameter 'taxaAntecipacaoRequest' when calling ConfigurarTaxaAntecipacaoProduto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurarTaxaAntecipacaoProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>ParametroProdutoResponse</returns>
        public ParametroProdutoResponse ConsultarTaxaAntecipacaoProduto (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = ConsultarTaxaAntecipacaoProdutoWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param> 
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param> 
        /// <returns>ApiResponse of ParametroProdutoResponse</returns>
        public ApiResponse< ParametroProdutoResponse > ConsultarTaxaAntecipacaoProdutoWithHttpInfo (long? id, string tipoTransacao)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipacaoApi->ConsultarTaxaAntecipacaoProduto");
            
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null)
                throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling AntecipacaoApi->ConsultarTaxaAntecipacaoProduto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ParametroProdutoResponse> ConsultarTaxaAntecipacaoProdutoAsync (long? id, string tipoTransacao)
        {
             ApiResponse<ParametroProdutoResponse> localVarResponse = await ConsultarTaxaAntecipacaoProdutoAsyncWithHttpInfo(id, tipoTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta a Taxa de Antecipa\u00E7\u00E3o de um Produto Este recurso permite consultar a Taxa de Antecipa\u00E7\u00E3o de um Produto, a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Produto</param>
        /// <param name="tipoTransacao">Tipo da Transa\u00E7\u00E3o (ON-US ou OFF-US)</param>
        /// <returns>Task of ApiResponse (ParametroProdutoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroProdutoResponse>> ConsultarTaxaAntecipacaoProdutoAsyncWithHttpInfo (long? id, string tipoTransacao)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxaAntecipacaoProduto");
            // verify the required parameter 'tipoTransacao' is set
            if (tipoTransacao == null) throw new ApiException(400, "Missing required parameter 'tipoTransacao' when calling ConsultarTaxaAntecipacaoProduto");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxaAntecipacaoProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroProdutoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroProdutoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroProdutoResponse)));
            
        }
        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param> 
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacaoCompra (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacaoCompraWithHttpInfo(idConta, id, quantidadeParcelas, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param> 
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacaoCompraWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipacaoApi->EfetivarAntecipacaoCompra");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipacaoApi->EfetivarAntecipacaoCompra");
            
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null)
                throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling AntecipacaoApi->EfetivarAntecipacaoCompra");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoCompraAsync (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacaoCompraAsyncWithHttpInfo(idConta, id, quantidadeParcelas, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoCompraAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacaoCompra");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EfetivarAntecipacaoCompra");
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null) throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling EfetivarAntecipacaoCompra");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacoesEmLotes (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacoesEmLotesWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacoesEmLotesWithHttpInfo (long? idConta, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipacaoApi->EfetivarAntecipacoesEmLotes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesEmLotes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesEmLotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacoesEmLotesAsync (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacoesEmLotesAsyncWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Faz a efetiva\u00E7\u00E3o da antecipa\u00E7\u00E3o M\u00E9todo responsavel pela efetiva\u00E7\u00E3o de todas as compras antecip\u00E1veis com todas as parcelas de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacoesEmLotesAsyncWithHttpInfo (long? idConta, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacoesEmLotes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesEmLotes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacoesEmLotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis Lista as compras antecip\u00E1veis de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param> 
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param> 
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param> 
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param> 
        /// <returns>PageCompraResponse</returns>
        public PageCompraResponse ListarComprasAntecipaveis (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = ListarComprasAntecipaveisWithHttpInfo(idConta, sort, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis Lista as compras antecip\u00E1veis de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param> 
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param> 
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param> 
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param> 
        /// <returns>ApiResponse of PageCompraResponse</returns>
        public ApiResponse< PageCompraResponse > ListarComprasAntecipaveisWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipacaoApi->ListarComprasAntecipaveis");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarComprasAntecipaveis: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarComprasAntecipaveis: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }

        
        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis Lista as compras antecip\u00E1veis de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param>
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        public async System.Threading.Tasks.Task<PageCompraResponse> ListarComprasAntecipaveisAsync (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = await ListarComprasAntecipaveisAsyncWithHttpInfo(idConta, sort, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar compras com parcelas antecip\u00E1veis Lista as compras antecip\u00E1veis de uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta da Compra</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idCompra">C\u00F3digo identificador da Compra (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00E9 parcelada (optional)</param>
        /// <param name="juros">Indica se a compra \u00E9 com ou sem juros (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00E9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarComprasAntecipaveisAsyncWithHttpInfo (long? idConta, List<string> sort = null, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarComprasAntecipaveis");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarComprasAntecipaveis: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarComprasAntecipaveis: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }
        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>AntecipacaoSimuladaResponse</returns>
        public AntecipacaoSimuladaResponse SimularAntecipacaoCompra (long? idConta, long? id, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = SimularAntecipacaoCompraWithHttpInfo(idConta, id, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        public ApiResponse< AntecipacaoSimuladaResponse > SimularAntecipacaoCompraWithHttpInfo (long? idConta, long? id, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipacaoApi->SimularAntecipacaoCompra");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AntecipacaoApi->SimularAntecipacaoCompra");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }

        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoCompraAsync (long? idConta, long? id, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = await SimularAntecipacaoCompraAsyncWithHttpInfo(idConta, id, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de parcelas Simula a antecipa\u00E7\u00E3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00EDveis, cujo desconto \u00E9 calculado baseado na data da \u00FAltima parcela em aberto
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do evento</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoCompraAsyncWithHttpInfo (long? idConta, long? id, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacaoCompra");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularAntecipacaoCompra");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }
        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>AntecipacaoSimuladaLoteResponse</returns>
        public AntecipacaoSimuladaLoteResponse SimularAntecipacoesEmLote (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaLoteResponse> localVarResponse = SimularAntecipacoesEmLoteWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaLoteResponse</returns>
        public ApiResponse< AntecipacaoSimuladaLoteResponse > SimularAntecipacoesEmLoteWithHttpInfo (long? idConta, string complemento = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling AntecipacaoApi->SimularAntecipacoesEmLote");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesEmLote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesEmLote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaLoteResponse)));
            
        }

        
        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of AntecipacaoSimuladaLoteResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaLoteResponse> SimularAntecipacoesEmLoteAsync (long? idConta, string complemento = null)
        {
             ApiResponse<AntecipacaoSimuladaLoteResponse> localVarResponse = await SimularAntecipacoesEmLoteAsyncWithHttpInfo(idConta, complemento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simular antecipa\u00E7\u00E3o de todas as parcelas antecip\u00E1veis O recurso permite realizar a simula\u00E7\u00E3o da antecipa\u00E7\u00E3o de todas as compras antecip\u00E1veis de todas as parcelas de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="complemento">Dados complementares sobre a realiza\u00E7\u00E3o da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaLoteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaLoteResponse>> SimularAntecipacoesEmLoteAsyncWithHttpInfo (long? idConta, string complemento = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacoesEmLote");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesEmLote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacoesEmLote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaLoteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaLoteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaLoteResponse)));
            
        }
        
    }
    
}
